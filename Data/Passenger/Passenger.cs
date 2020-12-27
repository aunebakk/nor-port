using System;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPort.DataAccessLayer
{
    public class PassengerData
    {
        /// <summary>Get highest Booking Passenger event number</summary>
        public static int BookingPassengerEventHighestNumber(
            SqlConnection connection,
            SqlTransaction transaction,
            Guid bookingPassengerId
            ) {

            int bookingPassengerEventNumber = 0;

            string sql = @" 
                    select 
                         max(bpe.booking_passenger_event_number) as booking_passenger_event_number_highest
                    from booking_passenger_event	as bpe
                    where bpe.booking_passenger_id = @booking_passenger_id
                ";

            using ( var command = new SqlCommand(sql, connection, transaction) ) {
                command.Parameters.Add("@booking_passenger_id", SqlDbType.UniqueIdentifier).Value = bookingPassengerId;

                Logging log = Logging.PerformanceTimeStart("SolutionNorSolutionPort.DataAccessLayer.Passenger.BookingPassengerEventHighestNumber");
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                log.PerformanceTimeStop(sql, command);

                if ( reader.Read() ) {
                    int flightSegmentEventNumberOrdinal = reader.GetOrdinal("booking_passenger_event_number_highest");
                    if ( !reader.IsDBNull(flightSegmentEventNumberOrdinal) )
                        bookingPassengerEventNumber = reader.GetInt32(flightSegmentEventNumberOrdinal);
                }

                reader.Close();
            }

            return bookingPassengerEventNumber;
        }
    }
}
