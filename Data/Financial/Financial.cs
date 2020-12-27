using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public partial class CrudeFinancialCurrencyData
    {
        public static CrudeFinancialCurrencyData FetchByFinancialCurrencyTypeCodeActive(
            string financialCurrencyTypeCode,
            string againstFinancialCurrencyTypeCode
            ) {

            var data = new CrudeFinancialCurrencyData();

            string sql = @" 
                select top 1 financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, financial_currency_against_financial_currency_type_rcd, valid_from_date_time, valid_until_date_time, amount, equals_amount, decimal_count, user_id, date_time
                from financial_currency as fc
                where fc.financial_currency_type_code = @financial_currency_type_code
				  and fc.financial_currency_against_financial_currency_type_rcd = @against_financial_currency_type_code
                  and fc.valid_until_date_time  is null
                  ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@financial_currency_type_code", SqlDbType.NVarChar).Value = financialCurrencyTypeCode;
                command.Parameters.Add("@against_financial_currency_type_code", SqlDbType.NVarChar).Value = againstFinancialCurrencyTypeCode;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Financial.FetchByFinancialCurrencyTypeCodeActive");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() )
                    data.Populate(reader);
            }

            return data;
        }
    }
}
