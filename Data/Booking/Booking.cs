using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public partial class BookingData
    {
        /// <summary>Get booking balance</summary>
        public static decimal BookingFinancialBalance(
            Guid bookingId
            ) {

            decimal balanceAmount = 0;

            string sql = @" 
                    select 
						  coalesce((select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = @booking_id
						    and (fbt.financial_payment_id is null
                                and fbt.financial_adjustment_id is null)
						  ), 0)											
						- coalesce((select sum(fbt.amount)						
						  from financial_booking_transaction	as fbt
						  where fbt.booking_id = @booking_id
						    and (fbt.financial_payment_id is not null
                                or fbt.financial_adjustment_id is not null)
						  ), 0)											as balance_amount
            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Booking.BookingFinancialBalance");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    if ( reader.Read() ) {
                        int balanceAmountOrdinal = reader.GetOrdinal("balance_amount");
                        if ( !reader.IsDBNull(balanceAmountOrdinal) )
                            balanceAmount = reader.GetDecimal(balanceAmountOrdinal);
                    }

                    reader.Close();
                }

                return balanceAmount;
            }
        }

        /// <summary>Get highest booking transaction number</summary>
        public static int TransactionNumberHighest(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid bookingId
            ) {

            int transactionNumber = 0;

            string sql = @" 
                    select 
                         max(fbt.transaction_number) as transaction_number_highest
                    from financial_booking_transaction	as fbt
                    where fbt.booking_id = @booking_id
                ";

            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Booking.TransactionNumberHighest");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() ) {
                    int transactionNumberOrdinal = reader.GetOrdinal("transaction_number_highest");
                    if ( !reader.IsDBNull(transactionNumberOrdinal) )
                        transactionNumber = reader.GetInt32(transactionNumberOrdinal);
                }

                reader.Close();
            }

            return transactionNumber;
        }
    }
}
