using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides car_rental search with different parameter and result sets
    /// </summary>
    /// <domain>CarRental</domain>
    public class CarRentalSearch
    {
        /// <summary>Get CarRental</summary>
        /// <cardinality>Many</cardinality>
        public List<GetCarRentalIndexWithFilterData> GetCarRentalIndexWithFilter() {
            var ret = new List<GetCarRentalIndexWithFilterData>();
            string sql = @"
                SELECT scr.car_name
                    ,scr.day_price_amount
                    ,scr.financial_currency_id
                    ,fc.financial_currency_type_name AS financial_currency_type_name
                    ,scr.product_id
                    ,p.product_name AS product_name
                    ,scr.user_id
                    ,du.default_user_name
                    ,scr.date_time
                    ,scr.service_car_rental_id
                FROM service_car_rental AS scr
                INNER JOIN financial_currency AS fc
                    ON fc.financial_currency_id = scr.financial_currency_id
                LEFT JOIN product AS p
                    ON p.product_id = scr.product_id
                INNER JOIN default_user AS du
                    ON du.default_user_id = scr.user_id
            ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("GetCarRentalIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetCarRentalIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetCarRentalIndexWithFilterData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }
    }
}
