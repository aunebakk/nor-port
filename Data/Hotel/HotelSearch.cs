using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    /// <summary> 
    /// Provides hotel search with different parameter and result sets
    /// </summary>
    /// <domain>Hotel</domain>
    public class HotelSearch
    {
        /// <summary>Get Hotel</summary>
        /// <cardinality>Many</cardinality>
        public List<GetHotelIndexWithFilterData> GetHotelIndexWithFilter() {
            var ret = new List<GetHotelIndexWithFilterData>();
            string sql = @"
                SELECT sh.hotel_name
                    ,sh.day_price_amount
                    ,sh.financial_currency_id
                    ,fc.financial_currency_type_name AS financial_currency_type_name
                    ,sh.product_id
                    ,p.product_name AS product_name
                    ,sh.user_id
                    ,du.default_user_name
                    ,sh.date_time
                    ,sh.service_hotel_id
                FROM service_hotel AS sh
                INNER JOIN financial_currency AS fc
                    ON fc.financial_currency_id = sh.financial_currency_id
                LEFT JOIN product AS p
                    ON p.product_id = sh.product_id
                INNER JOIN default_user AS du
                    ON du.default_user_id = sh.user_id
                ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {

                    command.CommandText = sql;

                    Logging log = Logging.PerformanceTimeStart("GetHotelIndexWithFilter");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetHotelIndexWithFilterDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetHotelIndexWithFilterData();
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
