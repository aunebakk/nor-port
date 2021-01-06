using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public partial class CrudeBookingData
    {
        public void FetchByBookingId(
            System.Guid bookingId,
            SqlConnection connection,
            SqlTransaction transaction
            ) {
            string sql = @" select top 1 booking_id, received_from, address_id, booking_source_rcd, external_system_id, agency_id, financial_currency_id, financial_costcentre_id, comment, user_id, date_time
                            from [booking]
                            where booking_id = @booking_id";
            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                IDataReader reader = null;
                try {
                    reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if ( reader.Read() )
                        Populate(reader);

                } catch ( Exception ex ) {
                    throw new Exception("CrudeBookingData, FetchByBookingId failed", ex);
                } finally {
                    if ( reader != null )
                        reader.Close();
                }
            }
        }
    }

    public partial class CrudeBookingContactMethodData
    {
        public void FetchByBookingIdLast(System.Guid bookingId) {
            string sql = @" select top 1 booking_contact_method_id, contact_method_way, comment, contact_method_rcd, booking_id, user_id, date_time
                            from [booking_contact_method]
                            where booking_id = @booking_id
                            order by date_time desc
                            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if ( reader.Read() )
                        Populate(reader);
                }
            }
        }
    }

    public partial class CrudeBookingIdentifierData
    {
        public void FetchByBookingIdLast(System.Guid bookingId) {
            string sql = @" select top 1 booking_identifier_id, booking_identifier_type_rcd, booking_id, user_id, date_time, booking_identifier_value, comment
                            from [booking_identifier]
                            where booking_id = @booking_id
                            order by date_time desc
                              ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if ( reader.Read() )
                        Populate(reader);
                }
            }
        }
    }
}
