using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public partial class CrudePassengerData
    {
        public List<CrudePassengerData> FetchByBookingId(System.Guid bookingId) {
            var dataList = new List<CrudePassengerData>();

            string sql = @" 
                            select 
                                  pa.passenger_id
                                , pa.became_passenger_id
                                , pa.binding_passenger_id
                                , pa.passenger_type_rcd
                                , pa.passenger_name
                                , pa.default_state_rcd
                                , pa.user_id
                                , pa.date_time
                            from [passenger] as pa
                            inner join booking_passenger as bp on bp.passenger_id = pa.passenger_id
                            where bp.booking_id = @booking_id
                              ";

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@booking_id", SqlDbType.UniqueIdentifier).Value = bookingId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while ( reader.Read() ) {
                        var data = new CrudePassengerData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }

                return dataList;
            }
        }
    }
}
