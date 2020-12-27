using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public partial class CrudeClientContactMethodData
    {

        public static CrudeClientContactMethodData GetCurrentMail(
            Guid clientId
            ) {
            string sql = @" 
                select top 1 client_contact_method_id, client_id, contact_method_rcd, contact_method_way, comment, user_id, date_time
                from [client_contact_method]
                where client_id = @client_id
                  and contact_method_rcd = dbo.ref('client_contact_method_ref.Email')
                ";

            var ret = new CrudeClientContactMethodData();

            using ( var conn = new SqlConnection(Conn.ConnectionString) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if ( reader.Read() )
                        ret.Populate(reader);
                }
            }

            return ret;
        }
    }
}
