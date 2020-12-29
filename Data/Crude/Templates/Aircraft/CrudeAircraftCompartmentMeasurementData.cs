/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 2:28:56 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateChildCrudeData.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/e4965a5f-c9fd-4584-85f0-b4d308f48f29
namespace SolutionNorSolutionPort.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // this class start with an identical representation of aircraft_compartment_measurement's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    // crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
    //  docLink: http://sql2x.org/documentationLink/e32ed6d4-57c7-43b1-8f2e-918c702e730a
    public partial class CrudeAircraftCompartmentMeasurementData {
        
        public System.Guid AircraftCompartmentMeasurementId { get; set; }
        
        public decimal Length { get; set; }
        
        public decimal Height { get; set; }
        
        public decimal Width { get; set; }
        
        public decimal PayloadInKilo { get; set; }
        
        public int UnitLoadDevicePositions { get; set; }
        
        public int CarryOnBinCount { get; set; }
        
        public int CarryOnPiecesAllowedCount { get; set; }
        
        public int CarryOnPieceMaxWeightInKilo { get; set; }
        
        public int InfantLimit { get; set; }
        
        public int BookableLimit { get; set; }
        
        public int PassengerLimit { get; set; }
        
        public int RowCount { get; set; }
        
        public int ColumnCount { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/71a3c70c-2d6d-4115-911c-a61f0383dbd5
        // parameters:
        //  aircraftCompartmentMeasurementId: primary key of table aircraft_compartment_measurement
        public void FetchByAircraftCompartmentMeasurementId(System.Guid aircraftCompartmentMeasurementId) {
            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/34fb7e37-dc72-4674-b0b8-075b6f06e158
            string sql = @" select top 1 aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]
                            where aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/47bd7ea7-2509-4557-a6da-cb80646dc104
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                // links:
                // docLink: http://sql2x.org/documentationLink/887786de-45d6-4e41-bc7a-4ba7955de9b1
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/0dc14388-f77b-4958-9d3b-45ead576ba03
                    command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = aircraftCompartmentMeasurementId;

                    // execute and read one row, close connection
                    // links:
                    // docLink: http://sql2x.org/documentationLink/35606d85-e730-4595-9321-d38f5afe5dd8
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c197df6d-be93-499e-b4da-75d9993bd464
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/7a625d0a-3028-42ce-a543-72ea3673cef4
        // parameters:
        //  aircraftCompartmentMeasurementId: primary key of table aircraft_compartment_measurement
        public static CrudeAircraftCompartmentMeasurementData GetByAircraftCompartmentMeasurementId(System.Guid aircraftCompartmentMeasurementId) {
            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/72f5fc83-c460-40fe-bac9-73b7ee0c6b77
            string sql = @" select top 1 aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]
                            where aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";

            var ret = new CrudeAircraftCompartmentMeasurementData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/1ecca728-0c07-4dd7-b095-d10777b25b70
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/1ecca728-0c07-4dd7-b095-d10777b25b70
                    command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = aircraftCompartmentMeasurementId;

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/fd5c5faa-b400-4f29-b12b-9675c53a757f
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/13095cd7-f136-4532-8969-c50c62cc05ef
        public static List<CrudeAircraftCompartmentMeasurementData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeAircraftCompartmentMeasurementData>();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/86c78f05-a65f-4dfe-b048-d0cbece49f4e
            string sql = @" select aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]
                            where user_id = @user_id
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/6fd25822-459f-4796-803a-071a3a270aa0
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8aec2e5c-4732-4662-badb-83b89d1c34a9
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/bb9abe5c-d2c1-455a-b597-a2af0a35de5a
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of aircraft_compartment_measurement
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/5c413c03-5ddc-472a-a63d-53aecc7a2573
                    while (reader.Read()) {
                        var data = new CrudeAircraftCompartmentMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all rows from table aircraft_compartment_measurement into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/7ca0c014-527e-4a0a-bd1f-12f4d8ea4b43
        public static List<CrudeAircraftCompartmentMeasurementData> FetchAll() {
            var dataList = new List<CrudeAircraftCompartmentMeasurementData>();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/72f9f1bc-447c-4327-9d26-4b0790a07ff8
            string sql = @" select aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/952b3f82-bc00-4e82-9430-6bc26ff8bc4d
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/ed55cc5b-d6be-4f5e-9385-ee726dfc2bf1
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of aircraft_compartment_measurement
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c1b8b800-b250-4822-a699-d93a35f4414d
                    while (reader.Read()) {
                        var data = new CrudeAircraftCompartmentMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/dfaa482b-059b-4f17-a9a9-4885138dbb46
        public static List<CrudeAircraftCompartmentMeasurementData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeAircraftCompartmentMeasurementData>();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/41f82773-6d37-4ebe-840c-c60e06337f45
            string sql = @" select top " + limit.ToString() + @" aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/da228d98-b30e-4d79-89ae-98e813437753
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c32ad724-8a03-4b4c-b6fb-a5abfb1d707e
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of aircraft_compartment_measurement
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/9ba4395d-d8a4-4427-b80f-7b828e34da7a
                    while (reader.Read()) {
                        var data = new CrudeAircraftCompartmentMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/12d2812e-e963-4f26-8014-48c4e9cfb3ae
        public static List<CrudeAircraftCompartmentMeasurementData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeAircraftCompartmentMeasurementData>();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/21eca289-4747-4a75-b0a2-1a58457be608
            string sql = @" select aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/c3e624a4-8479-4c17-bec7-ec09f3abbe64
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/6507b543-adbc-4863-810b-8db439f40d5c
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of aircraft_compartment_measurement
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/fcd15e2f-df3f-44d8-8a13-d2e93d97f685
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeAircraftCompartmentMeasurementData();
                            data.Populate(reader);
                            dataList.Add(data);
                        }
                        count++;
                        if (count > limit + offset) break;
                    }
                }
                
                return dataList;
            }
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/58c70863-ab7a-49e1-a0f9-809a0528eb50
        public static int FetchAllCount() {
                        // create query against aircraft_compartment_measurement
                        // this will be ansi sql and parameterized
                        // parameterized queries are a good way of preventing sql injection
                        //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/2d106245-afb6-427d-8547-3c3d19128f7a
            string sql = @" select count(*) as count from [aircraft_compartment_measurement]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/4826152a-aec8-4417-b176-65b2a6d97f35
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2294956f-872f-4f98-8677-c21f164b7892
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/a736bbfd-030d-492e-a86a-7a5e478eeb79
        public static List<CrudeAircraftCompartmentMeasurementData> FetchWithFilter(
                    System.Guid aircraftCompartmentMeasurementId, 
                    decimal length, 
                    decimal height, 
                    decimal width, 
                    decimal payloadInKilo, 
                    int unitLoadDevicePositions, 
                    int carryOnBinCount, 
                    int carryOnPiecesAllowedCount, 
                    int carryOnPieceMaxWeightInKilo, 
                    int infantLimit, 
                    int bookableLimit, 
                    int passengerLimit, 
                    int rowCount, 
                    int columnCount, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var dataList = new List<CrudeAircraftCompartmentMeasurementData>();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/06da7a50-8760-48cd-b789-a41cac3edd13
            string sql = @" select aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time
                            from [aircraft_compartment_measurement]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
// links:
// docLink: http://sql2x.org/documentationLink/6ec2495f-3a49-4a94-ad59-0ce064fc8654
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2193123a-3534-412b-8521-dac14bb3884d
                    if (aircraftCompartmentMeasurementId != Guid.Empty) {
                        sql += "  and aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";
                        command.Parameters.Add("@aircraft_compartment_measurement_id", SqlDbType.UniqueIdentifier).Value = aircraftCompartmentMeasurementId;
                    }
                    if (length != 0) {
                        sql += "  and length = @length";
                        command.Parameters.Add("@length", SqlDbType.Decimal).Value = length;
                    }
                    if (height != 0) {
                        sql += "  and height = @height";
                        command.Parameters.Add("@height", SqlDbType.Decimal).Value = height;
                    }
                    if (width != 0) {
                        sql += "  and width = @width";
                        command.Parameters.Add("@width", SqlDbType.Decimal).Value = width;
                    }
                    if (payloadInKilo != 0) {
                        sql += "  and payload_in_kilo = @payload_in_kilo";
                        command.Parameters.Add("@payload_in_kilo", SqlDbType.Decimal).Value = payloadInKilo;
                    }
                    if (unitLoadDevicePositions != 0) {
                        sql += "  and unit_load_device_positions = @unit_load_device_positions";
                        command.Parameters.Add("@unit_load_device_positions", SqlDbType.Int).Value = unitLoadDevicePositions;
                    }
                    if (carryOnBinCount != 0) {
                        sql += "  and carry_on_bin_count = @carry_on_bin_count";
                        command.Parameters.Add("@carry_on_bin_count", SqlDbType.Int).Value = carryOnBinCount;
                    }
                    if (carryOnPiecesAllowedCount != 0) {
                        sql += "  and carry_on_pieces_allowed_count = @carry_on_pieces_allowed_count";
                        command.Parameters.Add("@carry_on_pieces_allowed_count", SqlDbType.Int).Value = carryOnPiecesAllowedCount;
                    }
                    if (carryOnPieceMaxWeightInKilo != 0) {
                        sql += "  and carry_on_piece_max_weight_in_kilo = @carry_on_piece_max_weight_in_kilo";
                        command.Parameters.Add("@carry_on_piece_max_weight_in_kilo", SqlDbType.Int).Value = carryOnPieceMaxWeightInKilo;
                    }
                    if (infantLimit != 0) {
                        sql += "  and infant_limit = @infant_limit";
                        command.Parameters.Add("@infant_limit", SqlDbType.Int).Value = infantLimit;
                    }
                    if (bookableLimit != 0) {
                        sql += "  and bookable_limit = @bookable_limit";
                        command.Parameters.Add("@bookable_limit", SqlDbType.Int).Value = bookableLimit;
                    }
                    if (passengerLimit != 0) {
                        sql += "  and passenger_limit = @passenger_limit";
                        command.Parameters.Add("@passenger_limit", SqlDbType.Int).Value = passengerLimit;
                    }
                    if (rowCount != 0) {
                        sql += "  and row_count = @row_count";
                        command.Parameters.Add("@row_count", SqlDbType.Int).Value = rowCount;
                    }
                    if (columnCount != 0) {
                        sql += "  and column_count = @column_count";
                        command.Parameters.Add("@column_count", SqlDbType.Int).Value = columnCount;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    // execute query against aircraft_compartment_measurement
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/9f9fcbf4-4764-4b2e-8dc6-41d0366c95c9
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of aircraft_compartment_measurement
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/60181c7c-4a5e-41a3-9599-4e7a0aaf0cc8
                    while (reader.Read()) {
                        var data = new CrudeAircraftCompartmentMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        // links:
        //  docLink: http://sql2x.org/documentationLink/8305cd6c-8739-45a7-b02b-d68ac4a1b704
        public void Populate(IDataReader reader) {
            if (reader["aircraft_compartment_measurement_id"] != System.DBNull.Value) AircraftCompartmentMeasurementId = (System.Guid) reader["aircraft_compartment_measurement_id"];
            if (reader["length"] != System.DBNull.Value) Length = (System.Decimal) reader["length"];
            if (reader["height"] != System.DBNull.Value) Height = (System.Decimal) reader["height"];
            if (reader["width"] != System.DBNull.Value) Width = (System.Decimal) reader["width"];
            if (reader["payload_in_kilo"] != System.DBNull.Value) PayloadInKilo = (System.Decimal) reader["payload_in_kilo"];
            if (reader["unit_load_device_positions"] != System.DBNull.Value) UnitLoadDevicePositions = (System.Int32) reader["unit_load_device_positions"];
            if (reader["carry_on_bin_count"] != System.DBNull.Value) CarryOnBinCount = (System.Int32) reader["carry_on_bin_count"];
            if (reader["carry_on_pieces_allowed_count"] != System.DBNull.Value) CarryOnPiecesAllowedCount = (System.Int32) reader["carry_on_pieces_allowed_count"];
            if (reader["carry_on_piece_max_weight_in_kilo"] != System.DBNull.Value) CarryOnPieceMaxWeightInKilo = (System.Int32) reader["carry_on_piece_max_weight_in_kilo"];
            if (reader["infant_limit"] != System.DBNull.Value) InfantLimit = (System.Int32) reader["infant_limit"];
            if (reader["bookable_limit"] != System.DBNull.Value) BookableLimit = (System.Int32) reader["bookable_limit"];
            if (reader["passenger_limit"] != System.DBNull.Value) PassengerLimit = (System.Int32) reader["passenger_limit"];
            if (reader["row_count"] != System.DBNull.Value) RowCount = (System.Int32) reader["row_count"];
            if (reader["column_count"] != System.DBNull.Value) ColumnCount = (System.Int32) reader["column_count"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7bdedca5-6a3e-4862-9899-e1e6f0786a65
        public void Insert() {

            if (AircraftCompartmentMeasurementId == Guid.Empty)
                AircraftCompartmentMeasurementId = Guid.NewGuid();

                        // create query against aircraft_compartment_measurement
                        // this will be ansi sql and parameterized
                        // parameterized queries are a good way of preventing sql injection
                        //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/9a2230f9-8b3d-4525-a9a9-a4c654647a8d
            string sql = "insert into [aircraft_compartment_measurement] (aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time)";
            sql += "            values (@aircraft_compartment_measurement_id, @length, @height, @width, @payload_in_kilo, @unit_load_device_positions, @carry_on_bin_count, @carry_on_pieces_allowed_count, @carry_on_piece_max_weight_in_kilo, @infant_limit, @bookable_limit, @passenger_limit, @row_count, @column_count, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/56578739-efc5-4725-b597-1ef4c794c424
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/99823b37-69bd-4bf4-89c7-31c392e6a84a
                    command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)AircraftCompartmentMeasurementId;
                    command.Parameters.Add("@length",SqlDbType.Decimal).Value = (Length == 0 ? (object)DBNull.Value : (System.Decimal)Length);
                    command.Parameters.Add("@height",SqlDbType.Decimal).Value = (Height == 0 ? (object)DBNull.Value : (System.Decimal)Height);
                    command.Parameters.Add("@width",SqlDbType.Decimal).Value = (Width == 0 ? (object)DBNull.Value : (System.Decimal)Width);
                    command.Parameters.Add("@payload_in_kilo",SqlDbType.Decimal).Value = (PayloadInKilo == 0 ? (object)DBNull.Value : (System.Decimal)PayloadInKilo);
                    command.Parameters.Add("@unit_load_device_positions",SqlDbType.Int).Value = (UnitLoadDevicePositions == 0 ? (object)DBNull.Value : (System.Int32)UnitLoadDevicePositions);
                    command.Parameters.Add("@carry_on_bin_count",SqlDbType.Int).Value = (CarryOnBinCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnBinCount);
                    command.Parameters.Add("@carry_on_pieces_allowed_count",SqlDbType.Int).Value = (CarryOnPiecesAllowedCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPiecesAllowedCount);
                    command.Parameters.Add("@carry_on_piece_max_weight_in_kilo",SqlDbType.Int).Value = (CarryOnPieceMaxWeightInKilo == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPieceMaxWeightInKilo);
                    command.Parameters.Add("@infant_limit",SqlDbType.Int).Value = (InfantLimit == 0 ? (object)DBNull.Value : (System.Int32)InfantLimit);
                    command.Parameters.Add("@bookable_limit",SqlDbType.Int).Value = (BookableLimit == 0 ? (object)DBNull.Value : (System.Int32)BookableLimit);
                    command.Parameters.Add("@passenger_limit",SqlDbType.Int).Value = (PassengerLimit == 0 ? (object)DBNull.Value : (System.Int32)PassengerLimit);
                    command.Parameters.Add("@row_count",SqlDbType.Int).Value = (RowCount == 0 ? (object)DBNull.Value : (System.Int32)RowCount);
                    command.Parameters.Add("@column_count",SqlDbType.Int).Value = (ColumnCount == 0 ? (object)DBNull.Value : (System.Int32)ColumnCount);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against aircraft_compartment_measurement
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/f4d3ee95-4d8a-4b08-8485-cefdd78f365f
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/673b8de5-6a72-4992-954e-a06da52fb3d0
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (AircraftCompartmentMeasurementId == Guid.Empty)
                AircraftCompartmentMeasurementId = Guid.NewGuid();

            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/27ed2199-e80d-4b2f-a4bc-ee150909bcfe
            string sql = "insert into [aircraft_compartment_measurement] (aircraft_compartment_measurement_id, length, height, width, payload_in_kilo, unit_load_device_positions, carry_on_bin_count, carry_on_pieces_allowed_count, carry_on_piece_max_weight_in_kilo, infant_limit, bookable_limit, passenger_limit, row_count, column_count, user_id, date_time)";
            sql += "            values (@aircraft_compartment_measurement_id, @length, @height, @width, @payload_in_kilo, @unit_load_device_positions, @carry_on_bin_count, @carry_on_pieces_allowed_count, @carry_on_piece_max_weight_in_kilo, @infant_limit, @bookable_limit, @passenger_limit, @row_count, @column_count, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            // links:
            // docLink: http://sql2x.org/documentationLink/1b80c25f-8155-4b40-b2c8-4af98de6e364
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                // links:
                // docLink: http://sql2x.org/documentationLink/537f7277-d9ca-4a34-9067-3313f69dfbb5
                command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)AircraftCompartmentMeasurementId;
                command.Parameters.Add("@length",SqlDbType.Decimal).Value = (Length == 0 ? (object)DBNull.Value : (System.Decimal)Length);
                command.Parameters.Add("@height",SqlDbType.Decimal).Value = (Height == 0 ? (object)DBNull.Value : (System.Decimal)Height);
                command.Parameters.Add("@width",SqlDbType.Decimal).Value = (Width == 0 ? (object)DBNull.Value : (System.Decimal)Width);
                command.Parameters.Add("@payload_in_kilo",SqlDbType.Decimal).Value = (PayloadInKilo == 0 ? (object)DBNull.Value : (System.Decimal)PayloadInKilo);
                command.Parameters.Add("@unit_load_device_positions",SqlDbType.Int).Value = (UnitLoadDevicePositions == 0 ? (object)DBNull.Value : (System.Int32)UnitLoadDevicePositions);
                command.Parameters.Add("@carry_on_bin_count",SqlDbType.Int).Value = (CarryOnBinCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnBinCount);
                command.Parameters.Add("@carry_on_pieces_allowed_count",SqlDbType.Int).Value = (CarryOnPiecesAllowedCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPiecesAllowedCount);
                command.Parameters.Add("@carry_on_piece_max_weight_in_kilo",SqlDbType.Int).Value = (CarryOnPieceMaxWeightInKilo == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPieceMaxWeightInKilo);
                command.Parameters.Add("@infant_limit",SqlDbType.Int).Value = (InfantLimit == 0 ? (object)DBNull.Value : (System.Int32)InfantLimit);
                command.Parameters.Add("@bookable_limit",SqlDbType.Int).Value = (BookableLimit == 0 ? (object)DBNull.Value : (System.Int32)BookableLimit);
                command.Parameters.Add("@passenger_limit",SqlDbType.Int).Value = (PassengerLimit == 0 ? (object)DBNull.Value : (System.Int32)PassengerLimit);
                command.Parameters.Add("@row_count",SqlDbType.Int).Value = (RowCount == 0 ? (object)DBNull.Value : (System.Int32)RowCount);
                command.Parameters.Add("@column_count",SqlDbType.Int).Value = (ColumnCount == 0 ? (object)DBNull.Value : (System.Int32)ColumnCount);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against aircraft_compartment_measurement
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                // links:
                // docLink: http://sql2x.org/documentationLink/9a5cd1ec-b72c-4f38-8fb0-5ab4a6891bf8
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/128da2b2-c713-4ca8-ab97-9497c39cd400
        public void Update() {
            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/003a6113-375a-4b77-9df9-53ef5a233b78
            string sql = @" update [aircraft_compartment_measurement] set
                 aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id
                ,length = @length
                ,height = @height
                ,width = @width
                ,payload_in_kilo = @payload_in_kilo
                ,unit_load_device_positions = @unit_load_device_positions
                ,carry_on_bin_count = @carry_on_bin_count
                ,carry_on_pieces_allowed_count = @carry_on_pieces_allowed_count
                ,carry_on_piece_max_weight_in_kilo = @carry_on_piece_max_weight_in_kilo
                ,infant_limit = @infant_limit
                ,bookable_limit = @bookable_limit
                ,passenger_limit = @passenger_limit
                ,row_count = @row_count
                ,column_count = @column_count
                ,user_id = @user_id
                ,date_time = @date_time
            where aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/a35f7373-2e2b-4f34-aabb-d23549c39fc9
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2abaaa29-3a36-487c-a096-b2e750cac04b
                    command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)AircraftCompartmentMeasurementId;
                    command.Parameters.Add("@length",SqlDbType.Decimal).Value = (Length == 0 ? (object)DBNull.Value : (System.Decimal)Length);
                    command.Parameters.Add("@height",SqlDbType.Decimal).Value = (Height == 0 ? (object)DBNull.Value : (System.Decimal)Height);
                    command.Parameters.Add("@width",SqlDbType.Decimal).Value = (Width == 0 ? (object)DBNull.Value : (System.Decimal)Width);
                    command.Parameters.Add("@payload_in_kilo",SqlDbType.Decimal).Value = (PayloadInKilo == 0 ? (object)DBNull.Value : (System.Decimal)PayloadInKilo);
                    command.Parameters.Add("@unit_load_device_positions",SqlDbType.Int).Value = (UnitLoadDevicePositions == 0 ? (object)DBNull.Value : (System.Int32)UnitLoadDevicePositions);
                    command.Parameters.Add("@carry_on_bin_count",SqlDbType.Int).Value = (CarryOnBinCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnBinCount);
                    command.Parameters.Add("@carry_on_pieces_allowed_count",SqlDbType.Int).Value = (CarryOnPiecesAllowedCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPiecesAllowedCount);
                    command.Parameters.Add("@carry_on_piece_max_weight_in_kilo",SqlDbType.Int).Value = (CarryOnPieceMaxWeightInKilo == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPieceMaxWeightInKilo);
                    command.Parameters.Add("@infant_limit",SqlDbType.Int).Value = (InfantLimit == 0 ? (object)DBNull.Value : (System.Int32)InfantLimit);
                    command.Parameters.Add("@bookable_limit",SqlDbType.Int).Value = (BookableLimit == 0 ? (object)DBNull.Value : (System.Int32)BookableLimit);
                    command.Parameters.Add("@passenger_limit",SqlDbType.Int).Value = (PassengerLimit == 0 ? (object)DBNull.Value : (System.Int32)PassengerLimit);
                    command.Parameters.Add("@row_count",SqlDbType.Int).Value = (RowCount == 0 ? (object)DBNull.Value : (System.Int32)RowCount);
                    command.Parameters.Add("@column_count",SqlDbType.Int).Value = (ColumnCount == 0 ? (object)DBNull.Value : (System.Int32)ColumnCount);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against aircraft_compartment_measurement
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8205d701-9a29-4b76-ba08-dbad5f0a4f63
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/a5ace3c5-884e-46e2-97e0-05c0878ebfa2
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/1b17fa53-5cf9-4a38-8e7e-500586d09db3
            string sql = @" update [aircraft_compartment_measurement] set
                 aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id
                ,length = @length
                ,height = @height
                ,width = @width
                ,payload_in_kilo = @payload_in_kilo
                ,unit_load_device_positions = @unit_load_device_positions
                ,carry_on_bin_count = @carry_on_bin_count
                ,carry_on_pieces_allowed_count = @carry_on_pieces_allowed_count
                ,carry_on_piece_max_weight_in_kilo = @carry_on_piece_max_weight_in_kilo
                ,infant_limit = @infant_limit
                ,bookable_limit = @bookable_limit
                ,passenger_limit = @passenger_limit
                ,row_count = @row_count
                ,column_count = @column_count
                ,user_id = @user_id
                ,date_time = @date_time
            where aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/4be826df-f0a1-424f-8926-99d948ab0736
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                // links:
                // docLink: http://sql2x.org/documentationLink/f0ab995c-ed68-46d9-9a2b-4ddf72bf94d8
                command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)AircraftCompartmentMeasurementId;
                command.Parameters.Add("@length",SqlDbType.Decimal).Value = (Length == 0 ? (object)DBNull.Value : (System.Decimal)Length);
                command.Parameters.Add("@height",SqlDbType.Decimal).Value = (Height == 0 ? (object)DBNull.Value : (System.Decimal)Height);
                command.Parameters.Add("@width",SqlDbType.Decimal).Value = (Width == 0 ? (object)DBNull.Value : (System.Decimal)Width);
                command.Parameters.Add("@payload_in_kilo",SqlDbType.Decimal).Value = (PayloadInKilo == 0 ? (object)DBNull.Value : (System.Decimal)PayloadInKilo);
                command.Parameters.Add("@unit_load_device_positions",SqlDbType.Int).Value = (UnitLoadDevicePositions == 0 ? (object)DBNull.Value : (System.Int32)UnitLoadDevicePositions);
                command.Parameters.Add("@carry_on_bin_count",SqlDbType.Int).Value = (CarryOnBinCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnBinCount);
                command.Parameters.Add("@carry_on_pieces_allowed_count",SqlDbType.Int).Value = (CarryOnPiecesAllowedCount == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPiecesAllowedCount);
                command.Parameters.Add("@carry_on_piece_max_weight_in_kilo",SqlDbType.Int).Value = (CarryOnPieceMaxWeightInKilo == 0 ? (object)DBNull.Value : (System.Int32)CarryOnPieceMaxWeightInKilo);
                command.Parameters.Add("@infant_limit",SqlDbType.Int).Value = (InfantLimit == 0 ? (object)DBNull.Value : (System.Int32)InfantLimit);
                command.Parameters.Add("@bookable_limit",SqlDbType.Int).Value = (BookableLimit == 0 ? (object)DBNull.Value : (System.Int32)BookableLimit);
                command.Parameters.Add("@passenger_limit",SqlDbType.Int).Value = (PassengerLimit == 0 ? (object)DBNull.Value : (System.Int32)PassengerLimit);
                command.Parameters.Add("@row_count",SqlDbType.Int).Value = (RowCount == 0 ? (object)DBNull.Value : (System.Int32)RowCount);
                command.Parameters.Add("@column_count",SqlDbType.Int).Value = (ColumnCount == 0 ? (object)DBNull.Value : (System.Int32)ColumnCount);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against aircraft_compartment_measurement
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                // links:
                // docLink: http://sql2x.org/documentationLink/80014a96-6231-456f-bdea-a466aa612e1c
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/92ea3c6c-f90b-4c76-a6a1-5f440075b3ba
        public static void Delete(System.Guid aircraftCompartmentMeasurementId) {
            // create query against aircraft_compartment_measurement
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/f5378c5f-33b5-4709-9e9c-8cdfc9fd94f6
            string sql = @" delete [aircraft_compartment_measurement] 
                where aircraft_compartment_measurement_id = @aircraft_compartment_measurement_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/bcb94289-4fee-464c-bca6-2e10f633cd9d
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/32a0ab14-77a5-4b51-a523-9e946c84a4fb
                    command.Parameters.Add("@aircraft_compartment_measurement_id",SqlDbType.UniqueIdentifier).Value = aircraftCompartmentMeasurementId;
                    // execute query against aircraft_compartment_measurement
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/d44130c8-51b4-4162-a9c8-24b6c7df0241
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
