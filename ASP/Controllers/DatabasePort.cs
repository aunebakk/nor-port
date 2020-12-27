using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionNorSolutionPort.BusinessLogicLayer {
    public partial class DatabaseManager {
        void InitPort(
            int majorNumber,
            int minorNumber
            ) {

            int sequence = 0;

            //            scripts.Add(lastScript = new DatabaseScript {
            //                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 12, 25) },
            //                ScriptNumber = this.scriptNumber++,
            //                Name = "PortDropTables",
            //                Description = "Port Drop Tables",
            #region script ( *** )
            //                DatabaseScriptBatch = new DatabaseScriptBatch {
            //                    Script = @"
            //set quoted_identifier on
            //go


            //DROP TABLE cart_product_price
            //go



            //DROP TABLE airline_base_airport
            //go



            //DROP TABLE service_car_rental_link
            //go



            //DROP TABLE airport_terminal_airline
            //go



            //DROP TABLE airport_terminal
            //go



            //DROP TABLE service_hotel_link
            //go



            //DROP TABLE service_hotel_image
            //go



            //DROP TABLE service_image_type_ref
            //go



            //DROP TABLE airport_link
            //go



            //DROP TABLE cart_user
            //go



            //DROP TABLE service_package_promotion
            //go



            //DROP TABLE service_package
            //go



            //DROP TABLE airline_language
            //go



            //DROP TABLE language_ref
            //go



            //DROP TABLE aircraft_identifier
            //go



            //DROP TABLE aircraft_identifier_type_ref
            //go



            //DROP TABLE airport_identifier
            //go



            //DROP TABLE airport_identifier_type_ref
            //go



            //DROP TABLE airport_supplier_link
            //go



            //DROP TABLE airport_supplier
            //go



            //DROP TABLE ferry_identifier
            //go



            //DROP TABLE ferry_identifier_type_ref
            //go



            //DROP TABLE cart_product
            //go



            //DROP TABLE client_contact_method
            //go



            //DROP TABLE client_link
            //go



            //DROP TABLE booking_passenger_event
            //go



            //DROP TABLE booking_passenger_baggage
            //go



            //DROP TABLE booking_passenger_seat
            //go



            //DROP TABLE booking_passenger_ticket
            //go



            //DROP TABLE booking_passenger_event_type_ref
            //go



            //DROP TABLE booking_passenger
            //go



            //DROP TABLE passenger
            //go



            //DROP TABLE booking_flight_segment
            //go



            //DROP TABLE reporting_roundup
            //go



            //DROP TABLE reporting_roundup_type_ref
            //go



            //DROP TABLE booking_identifier
            //go



            //DROP TABLE booking_identifier_type_ref
            //go



            //DROP TABLE airline_contact_method
            //go



            //DROP TABLE airport_hotel_link
            //go



            //DROP TABLE flight_schedule_identifier
            //go



            //DROP TABLE airport_runway
            //go



            //DROP TABLE flight_schedule_segment_rule
            //go



            //DROP TABLE flight_schedule_segment_rule_ref
            //go



            //DROP TABLE flight_schedule_segment
            //go



            //DROP TABLE flight_schedule
            //go



            //DROP TABLE airline_link
            //go



            //DROP TABLE link_type_ref
            //go



            //DROP TABLE booking_event
            //go



            //DROP TABLE booking_event_type_ref
            //go



            //DROP TABLE flight_segment_event
            //go



            //DROP TABLE flight_segment
            //go



            //DROP TABLE client_event
            //go



            //DROP TABLE client_event_type_ref
            //go



            //DROP TABLE client
            //go



            //DROP TABLE passenger_type_ref
            //go



            //DROP TABLE client_type_ref
            //go



            //DROP TABLE title_ref
            //go



            //DROP TABLE gender_ref
            //go



            //DROP TABLE nationality_ref
            //go



            //DROP TABLE aircraft_document
            //go



            //DROP TABLE aircraft_document_type_ref
            //go



            //DROP TABLE booking_document
            //go



            //DROP TABLE booking_document_type_ref
            //go



            //DROP TABLE flight_event
            //go



            //DROP TABLE date_time_type_ref
            //go



            //DROP TABLE flight_identifier
            //go



            //DROP TABLE flight
            //go



            //DROP TABLE flight_identifier_type_ref
            //go



            //DROP TABLE booking_contact_method
            //go



            //DROP TABLE contact_method_ref
            //go



            //DROP TABLE airport_facility
            //go



            //DROP TABLE airport_facility_type_ref
            //go



            //DROP TABLE aircraft_compartment
            //go



            //DROP TABLE aircraft_compartment_measurement
            //go



            //DROP TABLE aircraft_compartment_type_ref
            //go



            //DROP TABLE aircraft
            //go



            //DROP TABLE aircraft_measurement
            //go



            //DROP TABLE aircraft_type_ref
            //go



            //DROP TABLE aircraft_configuration_ref
            //go



            //DROP TABLE aircraft_body_ref
            //go



            //DROP TABLE airline_identifier
            //go



            //DROP TABLE airline_identifier_type_ref
            //go



            //DROP TABLE airline
            //go



            //DROP TABLE airline_type_ref
            //go



            //DROP TABLE financial_booking_transaction
            //go



            //DROP TABLE financial_booking_transaction_type_ref
            //go



            //DROP TABLE financial_service
            //go



            //DROP TABLE financial_ferry_booking
            //go



            //DROP TABLE booking_service_request
            //go



            //DROP TABLE service_ferry
            //go



            //DROP TABLE ferry
            //go



            //DROP TABLE ferry_type_ref
            //go



            //DROP TABLE service_request_status_ref
            //go



            //DROP TABLE financial_car_rental
            //go



            //DROP TABLE service_car_rental
            //go



            //DROP TABLE financial_hotel_booking
            //go



            //DROP TABLE service_hotel
            //go



            //DROP TABLE financial_special_service
            //go



            //DROP TABLE service_special_service_request
            //go



            //DROP TABLE service_special_service_request_operation_rule_ref
            //go



            //DROP TABLE service_special_service_request_requirement_ref
            //go



            //DROP TABLE service_special_service_request_group_ref
            //go



            //DROP TABLE service_type_ref
            //go



            //DROP TABLE financial_adjustment
            //go



            //DROP TABLE financial_adjustment_type_ref
            //go



            //DROP TABLE financial_payment
            //go



            //DROP TABLE financial_payment_coupon
            //go



            //DROP TABLE financial_coupon
            //go



            //DROP TABLE financial_coupon_type_ref
            //go



            //DROP TABLE financial_payment_cash
            //go



            //DROP TABLE financial_payment_card
            //go



            //DROP TABLE financial_card_type_ref
            //go



            //DROP TABLE financial_payment_voucher
            //go



            //DROP TABLE financial_voucher
            //go



            //DROP TABLE financial_voucher_type_ref
            //go



            //DROP TABLE financial_payment_bank
            //go



            //DROP TABLE financial_bank_account_number_type_ref
            //go



            //DROP TABLE financial_payment_accounting
            //go



            //DROP TABLE financial_payment_type_ref
            //go



            //DROP TABLE financial_fare
            //go



            //DROP TABLE airport
            //go



            //DROP TABLE timezone
            //go



            //DROP TABLE airport_type_ref
            //go



            //DROP TABLE city
            //go



            //DROP TABLE country
            //go



            //DROP TABLE product
            //go



            //DROP TABLE financial_fare_type_ref
            //go



            //DROP TABLE financial_tax
            //go



            //DROP TABLE financial_tax_type_ref
            //go



            //DROP TABLE financial_fee
            //go



            //DROP TABLE financial_fee_type_ref
            //go



            //DROP TABLE booking
            //go



            //DROP TABLE financial_costcentre
            //go



            //DROP TABLE financial_company
            //go



            //DROP TABLE financial_currency
            //go



            //DROP TABLE financial_currency_type_ref
            //go



            //DROP TABLE agency
            //go



            //DROP TABLE external_system
            //go



            //DROP TABLE booking_source_ref
            //go



            //DROP TABLE [address]
            //go



            //DROP TABLE address_type_ref
            //go

            //                            ",
            //                    BreakUpToBatches = true
            //                }
            #endregion
            //            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 12, 25) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortDropTypes",
                Description = "Port Drop Types",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
			drop default if exists [time]
			drop default if exists [true]
go
			create default [time]
				as GetUTCDate()
go
            create default [true]
                as 1
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 12, 25) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortTypes",
                Description = "Port Database Types",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                Script = @"
            set quoted_identifier on
            go

            if type_id (N'can_change_flag') is null begin
                exec sp_addtype 'can_change_flag'
                    , 'bit', 'NULL'
            end
            go

            if type_id (N'code') is null begin
                exec sp_addtype 'code'
                    , 'varchar(20)', 'NOT NULL'
            end
            go

            if type_id (N'comment') is null begin
                exec sp_addtype 'comment'
                    , 'nvarchar(255)', 'NOT NULL'
            end
            go


            if type_id (N'currency') is null begin
                exec sp_addtype 'currency'
                    , 'decimal(15,4)', 'NOT NULL'
            end
            go

            if type_id (N'description') is null begin
                exec sp_addtype 'description'
                    , 'varchar(255)', 'NOT NULL'
            end
            go

            if type_id (N'flag') is null begin
                exec sp_addtype 'flag'
                    , 'bit', 'NULL'
            end
            go

            if type_id (N'id') is null begin
                exec sp_addtype 'id'
                    , 'uniqueidentifier', 'NOT NULL'
            end
            go

            if type_id (N'measurement') is null begin
                exec sp_addtype 'measurement'
                    , 'decimal(15,4)', 'NOT NULL'
            end
            go

            if type_id (N'name') is null begin
                exec sp_addtype 'name'
                    , 'nvarchar(240)', 'NOT NULL'
            end
            go

            if type_id (N'sort_order') is null begin
                exec sp_addtype 'sort_order'
                    , 'integer', 'NOT NULL'
            end
                            ",
                BreakUpToBatches = true
            }
            #endregion
            });

            // active_flag_true changed to bit default 1
            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 12, 25) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortCreateTables",
                Description = "Port Create Tables",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"

CREATE TABLE address
( 
	address_id           id  NOT NULL ,
	address_type_rcd     code  NULL ,
	address_one          name  NULL ,
	address_two          name  NULL ,
	address_three        name  NULL ,
	city                 name  NULL ,
	street               name  NULL ,
	state                name  NULL ,
	district             name  NULL ,
	province             name  NULL ,
	zip_code             name  NULL ,
	po_box               name  NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE address
	ADD CONSTRAINT XPKaddress PRIMARY KEY  CLUSTERED (address_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1address ON address
( 
	address_type_rcd      ASC
)
go



CREATE TABLE address_type_ref
( 
	address_type_rcd     code  NOT NULL ,
	address_type_name    name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE address_type_ref
	ADD CONSTRAINT XPKaddress_type_ref PRIMARY KEY  CLUSTERED (address_type_rcd ASC)
go



CREATE TABLE agency
( 
	agency_id            id  NOT NULL ,
	agency_code          code  NOT NULL ,
	agency_name          name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE agency
	ADD CONSTRAINT XPKagency PRIMARY KEY  CLUSTERED (agency_id ASC)
go



CREATE TABLE aircraft
( 
	aircraft_id          id  NOT NULL ,
	aircraft_name        name  NULL ,
	aircraft_type_rcd    code  NOT NULL ,
	aircraft_configuration_rcd code  NOT NULL ,
	aircraft_body_rcd    code  NOT NULL ,
	aircraft_measurement_id id  NULL ,
	product_id           id  NULL ,
	operational_date_time datetime  NULL ,
	first_flight_date_time datetime  NULL ,
	engine_type          name  NULL ,
	passenger_capacity   integer  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft
	ADD CONSTRAINT XPKaircraft PRIMARY KEY  CLUSTERED (aircraft_id ASC)
go



CREATE NONCLUSTERED INDEX XIF2aircraft ON aircraft
( 
	aircraft_body_rcd     ASC
)
go



CREATE NONCLUSTERED INDEX XIF3aircraft ON aircraft
( 
	aircraft_configuration_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5aircraft ON aircraft
( 
	aircraft_type_rcd     ASC
)
go



CREATE NONCLUSTERED INDEX XIF6aircraft ON aircraft
( 
	aircraft_measurement_id  ASC
)
go



CREATE TABLE aircraft_body_ref
( 
	aircraft_body_rcd    code  NOT NULL ,
	aircraft_body_name   name  NOT NULL ,
	description          description  NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_body_ref
	ADD CONSTRAINT XPKaircraft_body_ref PRIMARY KEY  CLUSTERED (aircraft_body_rcd ASC)
go



CREATE TABLE aircraft_compartment
( 
	aircraft_compartment_id id  NOT NULL ,
	aircraft_id          id  NOT NULL ,
	aircraft_compartment_measurement_id id  NULL ,
	aircraft_compartment_type_rcd code  NOT NULL ,
	aircraft_compartment_name name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_compartment
	ADD CONSTRAINT XPKaircraft_compartment PRIMARY KEY  CLUSTERED (aircraft_compartment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1aircraft_compartment ON aircraft_compartment
( 
	aircraft_id           ASC
)
go



CREATE NONCLUSTERED INDEX XIF2aircraft_compartment ON aircraft_compartment
( 
	aircraft_compartment_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3aircraft_compartment ON aircraft_compartment
( 
	aircraft_compartment_measurement_id  ASC
)
go



CREATE TABLE aircraft_compartment_measurement
( 
	aircraft_compartment_measurement_id id  NOT NULL ,
	length               measurement  NULL ,
	height               measurement  NULL ,
	width                measurement  NULL ,
	payload_in_kilo      measurement  NULL ,
	unit_load_device_positions integer  NULL ,
	carry_on_bin_count   integer  NULL ,
	carry_on_pieces_allowed_count integer  NULL ,
	carry_on_piece_max_weight_in_kilo integer  NULL ,
	infant_limit         integer  NULL ,
	bookable_limit       integer  NULL ,
	passenger_limit      integer  NULL ,
	row_count            integer  NULL ,
	column_count         integer  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_compartment_measurement
	ADD CONSTRAINT XPKaircraft_compartment_measurement PRIMARY KEY  CLUSTERED (aircraft_compartment_measurement_id ASC)
go



CREATE TABLE aircraft_compartment_type_ref
( 
	aircraft_compartment_type_rcd code  NOT NULL ,
	aircraft_compartment_type_name name  NOT NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_compartment_type_ref
	ADD CONSTRAINT XPKaircraft_compartment_type_ref PRIMARY KEY  CLUSTERED (aircraft_compartment_type_rcd ASC)
go



CREATE TABLE aircraft_configuration_ref
( 
	aircraft_configuration_rcd code  NOT NULL ,
	aircraft_configuration_name name  NOT NULL ,
	description          description  NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_configuration_ref
	ADD CONSTRAINT XPKaircraft_configuration_ref PRIMARY KEY  CLUSTERED (aircraft_configuration_rcd ASC)
go



CREATE TABLE aircraft_document
( 
	aircraft_document_id id  NOT NULL ,
	aircraft_id          id  NOT NULL ,
	aircraft_document_type_rcd code  NOT NULL ,
	document_name        name  NOT NULL ,
	document_date_time   datetime  NOT NULL ,
	expiry_date_time     datetime  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_document
	ADD CONSTRAINT XPKaircraft_document PRIMARY KEY  CLUSTERED (aircraft_document_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1aircraft_document ON aircraft_document
( 
	aircraft_id           ASC
)
go



CREATE NONCLUSTERED INDEX XIF2aircraft_document ON aircraft_document
( 
	aircraft_document_type_rcd  ASC
)
go



CREATE TABLE aircraft_document_type_ref
( 
	aircraft_document_type_rcd code  NOT NULL ,
	aircraft_document_type_name name  NOT NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_document_type_ref
	ADD CONSTRAINT XPKaircraft_document_type_ref PRIMARY KEY  CLUSTERED (aircraft_document_type_rcd ASC)
go



CREATE TABLE aircraft_identifier
( 
	aircraft_identifier_id id  NOT NULL ,
	aircraft_id          id  NOT NULL ,
	aircraft_identifier_type_rcd code  NOT NULL ,
	aircraft_identifier_code code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_identifier
	ADD CONSTRAINT XPKaircraft_identifier PRIMARY KEY  CLUSTERED (aircraft_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1aircraft_identifier ON aircraft_identifier
( 
	aircraft_id           ASC
)
go



CREATE NONCLUSTERED INDEX XIF2aircraft_identifier ON aircraft_identifier
( 
	aircraft_identifier_type_rcd  ASC
)
go



CREATE TABLE aircraft_identifier_type_ref
( 
	aircraft_identifier_type_rcd code  NOT NULL ,
	aircraft_identifier_type_name name  NOT NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_identifier_type_ref
	ADD CONSTRAINT XPKaircraft_identifier_type_ref PRIMARY KEY  CLUSTERED (aircraft_identifier_type_rcd ASC)
go



CREATE TABLE aircraft_measurement
( 
	aircraft_measurement_id id  NOT NULL ,
	length               measurement  NULL ,
	height               measurement  NULL ,
	weight               measurement  NULL ,
	wingspan             measurement  NULL ,
	width                measurement  NULL ,
	payload              measurement  NULL ,
	takeoff_weight_in_kilo measurement  NULL ,
	speed                measurement  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_measurement
	ADD CONSTRAINT XPKaircraft_measurement PRIMARY KEY  CLUSTERED (aircraft_measurement_id ASC)
go



CREATE TABLE aircraft_type_ref
( 
	aircraft_type_rcd    code  NOT NULL ,
	aircraft_type_name   name  NOT NULL ,
	description          name  NULL ,
	aircraft_family_image image  NULL ,
	active_flag          bit default 1  NOT NULL ,
	sort_order           sort_order  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE aircraft_type_ref
	ADD CONSTRAINT XPKaircraft_type_ref PRIMARY KEY  CLUSTERED (aircraft_type_rcd ASC)
go



CREATE TABLE airline
( 
	airline_id           id  NOT NULL ,
	airline_name         name  NOT NULL ,
	airline_type_rcd     code  NOT NULL ,
	legal_name           name  NULL ,
	address_id           id  NULL ,
	product_id           id  NULL ,
	stock_market_symbol  code  NULL ,
	aircraft_count       integer  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline
	ADD CONSTRAINT XPKairline PRIMARY KEY  CLUSTERED (airline_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline ON airline
( 
	airline_type_rcd      ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline ON airline
( 
	address_id            ASC
)
go



CREATE TABLE airline_base_airport
( 
	airline_base_airport_id id  NOT NULL ,
	airline_id           id  NOT NULL ,
	airport_id           id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_base_airport
	ADD CONSTRAINT XPKairline_base_airport PRIMARY KEY  CLUSTERED (airline_base_airport_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline_base_airport ON airline_base_airport
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline_base_airport ON airline_base_airport
( 
	airport_id            ASC
)
go



CREATE TABLE airline_contact_method
( 
	airline_contact_method_id id  NOT NULL ,
	airline_id           id  NOT NULL ,
	contact_method_rcd   code  NOT NULL ,
	contact_method_way   name  NOT NULL ,
	comment              description  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_contact_method
	ADD CONSTRAINT XPKairline_contact_method PRIMARY KEY  CLUSTERED (airline_contact_method_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline_contact_method ON airline_contact_method
( 
	contact_method_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline_contact_method ON airline_contact_method
( 
	airline_id            ASC
)
go



CREATE TABLE airline_identifier
( 
	airline_identifier_id id  NOT NULL ,
	airline_id           id  NOT NULL ,
	airline_identifier_type_rcd code  NOT NULL ,
	airline_identifier_code code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_identifier
	ADD CONSTRAINT XPKairline_identifier PRIMARY KEY  CLUSTERED (airline_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline_identifier ON airline_identifier
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline_identifier ON airline_identifier
( 
	airline_identifier_type_rcd  ASC
)
go



CREATE TABLE airline_identifier_type_ref
( 
	airline_identifier_type_rcd code  NOT NULL ,
	airline_identifier_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_identifier_type_ref
	ADD CONSTRAINT XPKairline_identifier_type_ref PRIMARY KEY  CLUSTERED (airline_identifier_type_rcd ASC)
go



CREATE TABLE airline_language
( 
	airline_language_id  id  NOT NULL ,
	airline_id           id  NOT NULL ,
	language_rcd         code  NOT NULL ,
	airline_language_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_language
	ADD CONSTRAINT XPKairline_language PRIMARY KEY  CLUSTERED (airline_language_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline_language ON airline_language
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline_language ON airline_language
( 
	language_rcd          ASC
)
go



CREATE NONCLUSTERED INDEX XIE1airline_language ON airline_language
( 
	airline_id            ASC,
	language_rcd          ASC
)
go



CREATE TABLE airline_link
( 
	airline_link_id      id  NOT NULL ,
	airline_id           id  NOT NULL ,
	link_type_rcd        code  NOT NULL ,
	link_name            name  NOT NULL ,
	link                 name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_link
	ADD CONSTRAINT XPKairline_link PRIMARY KEY  CLUSTERED (airline_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airline_link ON airline_link
( 
	link_type_rcd         ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airline_link ON airline_link
( 
	airline_id            ASC
)
go



CREATE TABLE airline_type_ref
( 
	airline_type_rcd     code  NOT NULL ,
	airline_type_name    name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airline_type_ref
	ADD CONSTRAINT XPKairline_type_ref PRIMARY KEY  CLUSTERED (airline_type_rcd ASC)
go



CREATE TABLE airport
( 
	airport_id           id  NOT NULL ,
	airport_name         name  NOT NULL ,
	airport_type_rcd     code  NULL ,
	city_id              id  NOT NULL ,
	product_id           id  NULL ,
	utc_offset           currency  NULL ,
	elevation_in_meters  currency  NULL ,
	runway_in_meters     currency  NULL ,
	latitude             code  NULL ,
	longitude            code  NULL ,
	timezone_id          id  NULL ,
	variation            code  NULL ,
	attendance           code  NULL ,
	control_tower_flag   flag  NULL ,
	activation_date_time datetime  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport
	ADD CONSTRAINT XPKairport PRIMARY KEY  CLUSTERED (airport_id ASC)
go



CREATE NONCLUSTERED INDEX XIF2airport ON airport
( 
	city_id               ASC
)
go



CREATE NONCLUSTERED INDEX XIF3airport ON airport
( 
	airport_type_rcd      ASC
)
go



CREATE NONCLUSTERED INDEX XIF4airport ON airport
( 
	timezone_id           ASC
)
go



CREATE TABLE airport_facility
( 
	airport_facility_id  id  NOT NULL ,
	airport_facility_type_rcd code  NOT NULL ,
	airport_id           id  NOT NULL ,
	airport_facility_name name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_facility
	ADD CONSTRAINT XPKairport_facility PRIMARY KEY  CLUSTERED (airport_facility_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_facility ON airport_facility
( 
	airport_facility_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airport_facility ON airport_facility
( 
	airport_id            ASC
)
go



CREATE TABLE airport_facility_type_ref
( 
	airport_facility_type_rcd code  NOT NULL ,
	airport_facility_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_facility_type_ref
	ADD CONSTRAINT XPKairport_facility_type_ref PRIMARY KEY  CLUSTERED (airport_facility_type_rcd ASC)
go



CREATE TABLE airport_hotel_link
( 
	airport_hotel_link_id id  NOT NULL ,
	airport_id           id  NOT NULL ,
	service_hotel_id     id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_hotel_link
	ADD CONSTRAINT XPKairport_hotel_link PRIMARY KEY  CLUSTERED (airport_hotel_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_hotel_link ON airport_hotel_link
( 
	airport_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airport_hotel_link ON airport_hotel_link
( 
	service_hotel_id      ASC
)
go



CREATE TABLE airport_identifier
( 
	airport_identifier_id id  NOT NULL ,
	airport_id           id  NOT NULL ,
	airport_identifier_type_rcd code  NOT NULL ,
	airport_identifier_code code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_identifier
	ADD CONSTRAINT XPKairport_identifier PRIMARY KEY  CLUSTERED (airport_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_identifier ON airport_identifier
( 
	airport_identifier_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airport_identifier ON airport_identifier
( 
	airport_id            ASC
)
go



CREATE TABLE airport_identifier_type_ref
( 
	airport_identifier_type_rcd code  NOT NULL ,
	airport_identifier_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_identifier_type_ref
	ADD CONSTRAINT XPKairport_identifier_type_ref PRIMARY KEY  CLUSTERED (airport_identifier_type_rcd ASC)
go



CREATE TABLE airport_link
( 
	airport_link_id      id  NOT NULL ,
	airport_id           id  NOT NULL ,
	link_type_rcd        code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_link
	ADD CONSTRAINT XPKairport_link PRIMARY KEY  CLUSTERED (airport_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_link ON airport_link
( 
	airport_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airport_link ON airport_link
( 
	link_type_rcd         ASC
)
go



CREATE TABLE airport_runway
( 
	airport_runway_id    id  NOT NULL ,
	airport_id           id  NOT NULL ,
	direction            code  NOT NULL ,
	dimensions           name  NOT NULL ,
	surface              code  NOT NULL ,
	instrument_landing_system_type code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_runway
	ADD CONSTRAINT XPKairport_runway PRIMARY KEY  CLUSTERED (airport_runway_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_runway ON airport_runway
( 
	airport_id            ASC
)
go



CREATE TABLE airport_supplier
( 
	airport_supplier_id  id  NOT NULL ,
	aiport_supplier_name name  NOT NULL ,
	airport_supplier_code code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_supplier
	ADD CONSTRAINT XPKairport_supplier PRIMARY KEY  CLUSTERED (airport_supplier_id ASC)
go



CREATE TABLE airport_supplier_link
( 
	airport_supplier_link_id id  NOT NULL ,
	airport_id           id  NOT NULL ,
	airport_supplier_id  id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_supplier_link
	ADD CONSTRAINT XPKairport_supplier_link PRIMARY KEY  CLUSTERED (airport_supplier_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_supplier_link ON airport_supplier_link
( 
	airport_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2airport_supplier_link ON airport_supplier_link
( 
	airport_supplier_id   ASC
)
go



CREATE TABLE airport_terminal
( 
	airport_terminal_id  id  NOT NULL ,
	airport_id           id  NOT NULL ,
	airport_terminal_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_terminal
	ADD CONSTRAINT XPKairport_terminal PRIMARY KEY  CLUSTERED (airport_terminal_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1airport_terminal ON airport_terminal
( 
	airport_id            ASC
)
go



CREATE TABLE airport_terminal_airline
( 
	airport_terminal_airline_id id  NOT NULL ,
	airport_terminal_id  id  NOT NULL ,
	airline_id           id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_terminal_airline
	ADD CONSTRAINT XPKairport_terminal_airline PRIMARY KEY  CLUSTERED (airport_terminal_airline_id ASC)
go



CREATE NONCLUSTERED INDEX XIF2airport_terminal_airline ON airport_terminal_airline
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF3airport_terminal_airline ON airport_terminal_airline
( 
	airport_terminal_id   ASC
)
go



CREATE TABLE airport_type_ref
( 
	airport_type_rcd     code  NOT NULL ,
	airport_type_name    name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE airport_type_ref
	ADD CONSTRAINT XPKairport_type_ref PRIMARY KEY  CLUSTERED (airport_type_rcd ASC)
go



CREATE TABLE booking
( 
	booking_id           id  NOT NULL ,
	received_from        code  NULL ,
	address_id           id  NULL ,
	booking_source_rcd   code  NULL ,
	external_system_id   id  NULL ,
	agency_id            id  NULL ,
	financial_currency_id id  NOT NULL ,
	financial_costcentre_id id  NOT NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking
	ADD CONSTRAINT XPKbooking PRIMARY KEY  CLUSTERED (booking_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking ON booking
( 
	address_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking ON booking
( 
	booking_source_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIF3booking ON booking
( 
	external_system_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIF4booking ON booking
( 
	agency_id             ASC
)
go



CREATE NONCLUSTERED INDEX XIF5booking ON booking
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6booking ON booking
( 
	financial_costcentre_id  ASC
)
go



CREATE TABLE booking_contact_method
( 
	booking_contact_method_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	contact_method_rcd   code  NOT NULL ,
	contact_method_way   name  NOT NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_contact_method
	ADD CONSTRAINT XPKbooking_contact_method PRIMARY KEY  CLUSTERED (booking_contact_method_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_contact_method ON booking_contact_method
( 
	contact_method_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_contact_method ON booking_contact_method
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIE1booking_contact_method ON booking_contact_method
( 
	booking_id            ASC,
	user_id               ASC
)
go



CREATE TABLE booking_document
( 
	booking_document_id  id  NOT NULL ,
	booking_id           id  NOT NULL ,
	booking_document_type_rcd code  NOT NULL ,
	booking_document_name name  NOT NULL ,
	booking_document_filename name  NOT NULL ,
	booking_document     name  NOT NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_document
	ADD CONSTRAINT XPKbooking_document PRIMARY KEY  CLUSTERED (booking_document_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_document ON booking_document
( 
	booking_document_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_document ON booking_document
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIE1booking_document ON booking_document
( 
	booking_id            ASC,
	user_id               ASC
)
go



CREATE TABLE booking_document_type_ref
( 
	booking_document_type_rcd code  NOT NULL ,
	booking_document_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_document_type_ref
	ADD CONSTRAINT XPKbooking_document_type_ref PRIMARY KEY  CLUSTERED (booking_document_type_rcd ASC)
go



CREATE TABLE booking_event
( 
	booking_event_id     id  NOT NULL ,
	booking_id           id  NOT NULL ,
	booking_event_type_rcd code  NOT NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_event
	ADD CONSTRAINT XPKbooking_event PRIMARY KEY  CLUSTERED (booking_event_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_event ON booking_event
( 
	booking_event_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_event ON booking_event
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIE1booking_event ON booking_event
( 
	booking_id            ASC,
	user_id               ASC
)
go



CREATE TABLE booking_event_type_ref
( 
	booking_event_type_rcd code  NOT NULL ,
	booking_event_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_event_type_ref
	ADD CONSTRAINT XPKbooking_event_type_ref PRIMARY KEY  CLUSTERED (booking_event_type_rcd ASC)
go



CREATE TABLE booking_flight_segment
( 
	booking_flight_segment_id id  NOT NULL ,
	became_booking_flight_segment_id id  NULL ,
	binding_booking_flight_segment_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	flight_segment_id    id  NOT NULL ,
	default_state_rcd    code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_flight_segment
	ADD CONSTRAINT XPKbooking_flight_segment PRIMARY KEY  CLUSTERED (booking_flight_segment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_flight_segment ON booking_flight_segment
( 
	flight_segment_id     ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_flight_segment ON booking_flight_segment
( 
	booking_id            ASC
)
go



CREATE TABLE booking_identifier
( 
	booking_identifier_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	booking_identifier_type_rcd code  NOT NULL ,
	booking_identifier_value name  NOT NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_identifier
	ADD CONSTRAINT XPKbooking_identifier PRIMARY KEY  CLUSTERED (booking_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_identifier ON booking_identifier
( 
	booking_identifier_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_identifier ON booking_identifier
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIE1booking_identifier ON booking_identifier
( 
	booking_id            ASC,
	user_id               ASC
)
go



CREATE TABLE booking_identifier_type_ref
( 
	booking_identifier_type_rcd code  NOT NULL ,
	booking_identifier_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_identifier_type_ref
	ADD CONSTRAINT XPKbooking_identifier_type_ref PRIMARY KEY  CLUSTERED (booking_identifier_type_rcd ASC)
go



CREATE TABLE booking_passenger
( 
	booking_passenger_id id  NOT NULL ,
	became_booking_passenger_id id  NULL ,
	binding_booking_passenger_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	passenger_id         id  NOT NULL ,
	default_state_rcd    code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_passenger
	ADD CONSTRAINT XPKbooking_passenger PRIMARY KEY  CLUSTERED (booking_passenger_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_passenger ON booking_passenger
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_passenger ON booking_passenger
( 
	passenger_id          ASC
)
go



CREATE NONCLUSTERED INDEX XIE1booking_passenger ON booking_passenger
( 
	booking_id            ASC,
	user_id               ASC
)
go



CREATE TABLE booking_passenger_baggage
( 
	booking_passenger_baggage_id id  NOT NULL ,
	item_count           integer  NOT NULL ,
	weight               currency  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL ,
	remarks              name  NULL 
)
go



ALTER TABLE booking_passenger_baggage
	ADD CONSTRAINT XPKbooking_passenger_baggage PRIMARY KEY  CLUSTERED (booking_passenger_baggage_id ASC)
go



CREATE TABLE booking_passenger_event
( 
	booking_passenger_event_id id  NOT NULL ,
	booking_passenger_event_type_rcd code  NOT NULL ,
	booking_passenger_event_number integer  NOT NULL ,
	booking_passenger_id id  NOT NULL ,
	booking_flight_segment_id id  NOT NULL ,
	booking_passenger_ticket_id id  NULL ,
	booking_passenger_seat_id id  NULL ,
	booking_passenger_baggage_id id  NULL ,
	remarks              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_passenger_event
	ADD CONSTRAINT XPKbooking_passenger_event PRIMARY KEY  CLUSTERED (booking_passenger_event_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_passenger_event ON booking_passenger_event
( 
	booking_flight_segment_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_passenger_event ON booking_passenger_event
( 
	booking_passenger_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3booking_passenger_event ON booking_passenger_event
( 
	booking_passenger_event_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4booking_passenger_event ON booking_passenger_event
( 
	booking_passenger_ticket_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5booking_passenger_event ON booking_passenger_event
( 
	booking_passenger_seat_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6booking_passenger_event ON booking_passenger_event
( 
	booking_passenger_baggage_id  ASC
)
go



CREATE TABLE booking_passenger_event_type_ref
( 
	booking_passenger_event_type_rcd code  NOT NULL ,
	booking_passenger_event_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_passenger_event_type_ref
	ADD CONSTRAINT XPKbooking_passenger_event_type_ref PRIMARY KEY  CLUSTERED (booking_passenger_event_type_rcd ASC)
go



CREATE TABLE booking_passenger_seat
( 
	booking_passenger_seat_id id  NOT NULL ,
	seat_number          code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_passenger_seat
	ADD CONSTRAINT XPKbooking_passenger_seat PRIMARY KEY  CLUSTERED (booking_passenger_seat_id ASC)
go



CREATE TABLE booking_passenger_ticket
( 
	booking_passenger_ticket_id id  NOT NULL ,
	ticket_number        code  NOT NULL ,
	ticket_description   description  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_passenger_ticket
	ADD CONSTRAINT XPKbooking_passenger_ticket PRIMARY KEY  CLUSTERED (booking_passenger_ticket_id ASC)
go



CREATE TABLE booking_service_request
( 
	booking_service_request_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	service_type_rcd     code  NOT NULL ,
	service_special_service_request_id id  NULL ,
	service_request_status_rcd code  NOT NULL ,
	service_hotel_id     id  NULL ,
	service_car_rental_id id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL ,
	service_ferry_id     id  NULL 
)
go



ALTER TABLE booking_service_request
	ADD CONSTRAINT XPKbooking_service_request PRIMARY KEY  CLUSTERED (booking_service_request_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1booking_service_request ON booking_service_request
( 
	service_special_service_request_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2booking_service_request ON booking_service_request
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF3booking_service_request ON booking_service_request
( 
	service_request_status_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4booking_service_request ON booking_service_request
( 
	service_hotel_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF5booking_service_request ON booking_service_request
( 
	service_car_rental_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6booking_service_request ON booking_service_request
( 
	service_type_rcd      ASC
)
go



CREATE NONCLUSTERED INDEX XIF7booking_service_request ON booking_service_request
( 
	service_ferry_id      ASC
)
go



CREATE TABLE booking_source_ref
( 
	booking_source_rcd   code  NOT NULL ,
	booking_source_name  name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE booking_source_ref
	ADD CONSTRAINT XPKbooking_source_ref PRIMARY KEY  CLUSTERED (booking_source_rcd ASC)
go



CREATE TABLE cart_product
( 
	cart_product_id      id  NOT NULL ,
	product_id           id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE cart_product
	ADD CONSTRAINT XPKcart_product PRIMARY KEY  NONCLUSTERED (cart_product_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1cart_product ON cart_product
( 
	product_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2cart_product ON cart_product
( 
	financial_currency_id  ASC
)
go



CREATE TABLE cart_product_price
( 
	cart_product_price_id id  NOT NULL ,
	product_id           id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE cart_product_price
	ADD CONSTRAINT XPKcart_product_price PRIMARY KEY  NONCLUSTERED (cart_product_price_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1cart_product_price ON cart_product_price
( 
	product_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2cart_product_price ON cart_product_price
( 
	financial_currency_id  ASC
)
go



CREATE TABLE cart_user
( 
	cart_user_id         id  NOT NULL 
)
go



ALTER TABLE cart_user
	ADD CONSTRAINT XPKcart_user PRIMARY KEY  NONCLUSTERED (cart_user_id ASC)
go



CREATE TABLE city
( 
	city_id              id  NOT NULL ,
	country_id           id  NOT NULL ,
	city_code            code  NOT NULL ,
	city_name            name  NOT NULL ,
	product_id           id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE city
	ADD CONSTRAINT XPKcity PRIMARY KEY  CLUSTERED (city_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1city ON city
( 
	country_id            ASC
)
go



CREATE TABLE client
( 
	client_id            id  NOT NULL ,
	first_name           name  NOT NULL ,
	middle_name          name  NULL ,
	last_name            name  NOT NULL ,
	address_id           id  NULL ,
	default_user_id      id  NULL ,
	passenger_type_rcd   code  NULL ,
	nationality_rcd      code  NULL ,
	gender_rcd           code  NULL ,
	title_rcd            code  NULL ,
	client_type_rcd      code  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client
	ADD CONSTRAINT XPKclient PRIMARY KEY  CLUSTERED (client_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1client ON client
( 
	address_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2client ON client
( 
	nationality_rcd       ASC
)
go



CREATE NONCLUSTERED INDEX XIF3client ON client
( 
	gender_rcd            ASC
)
go



CREATE NONCLUSTERED INDEX XIF4client ON client
( 
	title_rcd             ASC
)
go



CREATE NONCLUSTERED INDEX XIF5client ON client
( 
	client_type_rcd       ASC
)
go



CREATE NONCLUSTERED INDEX XIF6client ON client
( 
	passenger_type_rcd    ASC
)
go



CREATE TABLE client_contact_method
( 
	client_contact_method_id id  NOT NULL ,
	client_id            id  NOT NULL ,
	contact_method_rcd   code  NOT NULL ,
	contact_method_way   name  NOT NULL ,
	comment              comment  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client_contact_method
	ADD CONSTRAINT XPKclient_contact_method PRIMARY KEY  CLUSTERED (client_contact_method_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1client_contact_method ON client_contact_method
( 
	client_id             ASC
)
go



CREATE NONCLUSTERED INDEX XIF2client_contact_method ON client_contact_method
( 
	contact_method_rcd    ASC
)
go



CREATE TABLE client_event
( 
	client_event_id      id  NOT NULL ,
	client_id            id  NOT NULL ,
	client_event_type_rcd code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client_event
	ADD CONSTRAINT XPKclient_event PRIMARY KEY  CLUSTERED (client_event_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1client_event ON client_event
( 
	client_id             ASC
)
go



CREATE NONCLUSTERED INDEX XIF2client_event ON client_event
( 
	client_event_type_rcd  ASC
)
go



CREATE TABLE client_event_type_ref
( 
	client_event_type_rcd code  NOT NULL ,
	client_event_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client_event_type_ref
	ADD CONSTRAINT XPKclient_event_type_ref PRIMARY KEY  CLUSTERED (client_event_type_rcd ASC)
go



CREATE TABLE client_link
( 
	client_link_id       id  NOT NULL ,
	client_id            id  NOT NULL ,
	link_type_rcd        code  NOT NULL ,
	link                 name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client_link
	ADD CONSTRAINT XPKclient_link PRIMARY KEY  CLUSTERED (client_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1client_link ON client_link
( 
	link_type_rcd         ASC
)
go



CREATE NONCLUSTERED INDEX XIF2client_link ON client_link
( 
	client_id             ASC
)
go



CREATE TABLE client_type_ref
( 
	client_type_rcd      code  NOT NULL ,
	client_type_name     name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE client_type_ref
	ADD CONSTRAINT XPKclient_type_ref PRIMARY KEY  CLUSTERED (client_type_rcd ASC)
go



CREATE TABLE contact_method_ref
( 
	contact_method_rcd   code  NOT NULL ,
	contact_method_name  name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE contact_method_ref
	ADD CONSTRAINT XPKcontact_method_ref PRIMARY KEY  CLUSTERED (contact_method_rcd ASC)
go



CREATE TABLE country
( 
	country_id           id  NOT NULL ,
	country_code         code  NOT NULL ,
	country_name         name  NOT NULL ,
	product_id           id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE country
	ADD CONSTRAINT XPKcountry PRIMARY KEY  CLUSTERED (country_id ASC)
go



CREATE TABLE date_time_type_ref
( 
	date_time_type_rcd   code  NOT NULL ,
	date_time_type_name  name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE date_time_type_ref
	ADD CONSTRAINT XPKdate_time_type_ref PRIMARY KEY  CLUSTERED (date_time_type_rcd ASC)
go



CREATE TABLE external_system
( 
	external_system_id   id  NOT NULL ,
	external_system_code code  NOT NULL ,
	external_system_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE external_system
	ADD CONSTRAINT XPKexternal_system PRIMARY KEY  CLUSTERED (external_system_id ASC)
go



CREATE TABLE ferry
( 
	ferry_id             id  NOT NULL ,
	ferry_name           name  NOT NULL ,
	ferry_type_rcd       code  NOT NULL ,
	product_id           id  NULL ,
	first_float_date_time datetime  NULL ,
	operational_date_time datetime  NULL ,
	engine_type          name  NULL ,
	passenger_capacity   integer  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE ferry
	ADD CONSTRAINT XPKferry PRIMARY KEY  CLUSTERED (ferry_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1ferry ON ferry
( 
	ferry_type_rcd        ASC
)
go



CREATE TABLE ferry_identifier
( 
	ferry_identifier_id  id  NOT NULL ,
	ferry_id             id  NOT NULL ,
	ferry_identifier_type_rcd code  NOT NULL ,
	ferry_identifier_code code  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE ferry_identifier
	ADD CONSTRAINT XPKferry_identifier PRIMARY KEY  CLUSTERED (ferry_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1ferry_identifier ON ferry_identifier
( 
	ferry_id              ASC
)
go



CREATE NONCLUSTERED INDEX XIF2ferry_identifier ON ferry_identifier
( 
	ferry_identifier_type_rcd  ASC
)
go



CREATE TABLE ferry_identifier_type_ref
( 
	ferry_identifier_type_rcd code  NOT NULL ,
	ferry_identifier_type_name name  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE ferry_identifier_type_ref
	ADD CONSTRAINT XPKferry_identifier_type_ref PRIMARY KEY  CLUSTERED (ferry_identifier_type_rcd ASC)
go



CREATE TABLE ferry_type_ref
( 
	ferry_type_rcd       code  NOT NULL ,
	ferry_type_name      name  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE ferry_type_ref
	ADD CONSTRAINT XPKferry_type_ref PRIMARY KEY  CLUSTERED (ferry_type_rcd ASC)
go



CREATE TABLE financial_adjustment
( 
	financial_adjustment_id id  NOT NULL ,
	financial_adjustment_type_rcd code  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_adjustment
	ADD CONSTRAINT XPKfinancial_adjustment PRIMARY KEY  CLUSTERED (financial_adjustment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_adjustment ON financial_adjustment
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_adjustment ON financial_adjustment
( 
	financial_adjustment_type_rcd  ASC
)
go



CREATE TABLE financial_adjustment_type_ref
( 
	financial_adjustment_type_rcd code  NOT NULL ,
	financial_adjustment_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_adjustment_type_ref
	ADD CONSTRAINT XPKfinancial_adjustment_type_ref PRIMARY KEY  CLUSTERED (financial_adjustment_type_rcd ASC)
go



CREATE TABLE financial_bank_account_number_type_ref
( 
	financial_bank_account_number_type_rcd code  NOT NULL ,
	financial_bank_account_number_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_bank_account_number_type_ref
	ADD CONSTRAINT XPKfinancial_bank_account_number_type_ref PRIMARY KEY  CLUSTERED (financial_bank_account_number_type_rcd ASC)
go



CREATE TABLE financial_booking_transaction
( 
	financial_booking_transaction_id id  NOT NULL ,
	booking_id           id  NOT NULL ,
	transaction_number   integer  NOT NULL ,
	financial_booking_transaction_type_rcd code  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_fee_id     id  NULL ,
	financial_tax_id     id  NULL ,
	financial_fare_id    id  NULL ,
	financial_payment_id id  NULL ,
	financial_currency_id id  NOT NULL ,
	financial_costcentre_id id  NOT NULL ,
	financial_adjustment_id id  NULL ,
	financial_service_id id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT XPKfinancial_booking_transaction PRIMARY KEY  CLUSTERED (financial_booking_transaction_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_booking_transaction ON financial_booking_transaction
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_booking_transaction ON financial_booking_transaction
( 
	financial_fee_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF3financial_booking_transaction ON financial_booking_transaction
( 
	financial_tax_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF4financial_booking_transaction ON financial_booking_transaction
( 
	financial_fare_id     ASC
)
go



CREATE NONCLUSTERED INDEX XIF5financial_booking_transaction ON financial_booking_transaction
( 
	financial_payment_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6financial_booking_transaction ON financial_booking_transaction
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF7financial_booking_transaction ON financial_booking_transaction
( 
	financial_costcentre_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF8financial_booking_transaction ON financial_booking_transaction
( 
	financial_adjustment_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF9financial_booking_transaction ON financial_booking_transaction
( 
	financial_service_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF10financial_booking_transaction ON financial_booking_transaction
( 
	financial_booking_transaction_type_rcd  ASC
)
go



CREATE TABLE financial_booking_transaction_type_ref
( 
	financial_booking_transaction_type_rcd code  NOT NULL ,
	financial_booking_transaction_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_booking_transaction_type_ref
	ADD CONSTRAINT XPKfinancial_booking_transaction_type_ref PRIMARY KEY  CLUSTERED (financial_booking_transaction_type_rcd ASC)
go



CREATE TABLE financial_car_rental
( 
	financial_car_rental_id id  NOT NULL ,
	service_car_rental_id id  NOT NULL ,
	from_date_time       datetime  NOT NULL ,
	until_date_time      datetime  NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_car_rental
	ADD CONSTRAINT XPKfinancial_car_rental PRIMARY KEY  CLUSTERED (financial_car_rental_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_car_rental ON financial_car_rental
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_car_rental ON financial_car_rental
( 
	service_car_rental_id  ASC
)
go



CREATE TABLE financial_card_type_ref
( 
	financial_card_type_rcd code  NOT NULL ,
	financial_card_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_card_type_ref
	ADD CONSTRAINT XPKfinancial_card_type_ref PRIMARY KEY  CLUSTERED (financial_card_type_rcd ASC)
go



CREATE TABLE financial_company
( 
	financial_company_id id  NOT NULL ,
	financial_company_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_company
	ADD CONSTRAINT XPKfinancial_company PRIMARY KEY  CLUSTERED (financial_company_id ASC)
go



CREATE TABLE financial_costcentre
( 
	financial_costcentre_id id  NOT NULL ,
	financial_costcentre_code code  NOT NULL ,
	financial_costcentre_name name  NOT NULL ,
	financial_company_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_costcentre
	ADD CONSTRAINT XPKfinancial_costcentre PRIMARY KEY  CLUSTERED (financial_costcentre_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_costcentre ON financial_costcentre
( 
	financial_company_id  ASC
)
go



CREATE TABLE financial_coupon
( 
	financial_coupon_id  id  NOT NULL ,
	financial_coupon_type_rcd code  NOT NULL ,
	coupon_number        integer  NOT NULL ,
	value_amount         currency  NULL ,
	financial_currency_id id  NOT NULL ,
	valid_from_date_time datetime  NOT NULL ,
	valid_until_date_time datetime  NOT NULL ,
	coupon_description   description  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_coupon
	ADD CONSTRAINT XPKfinancial_coupon PRIMARY KEY  CLUSTERED (financial_coupon_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_coupon ON financial_coupon
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_coupon ON financial_coupon
( 
	financial_coupon_type_rcd  ASC
)
go



CREATE TABLE financial_coupon_type_ref
( 
	financial_coupon_type_rcd code  NOT NULL ,
	financial_coupon_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_coupon_type_ref
	ADD CONSTRAINT XPKfinancial_coupon_type_ref PRIMARY KEY  CLUSTERED (financial_coupon_type_rcd ASC)
go



CREATE TABLE financial_currency
( 
	financial_currency_id id  NOT NULL ,
	financial_currency_type_rcd code  NOT NULL ,
	financial_currency_type_code name  NOT NULL ,
	financial_currency_type_name name  NOT NULL ,
	financial_currency_against_financial_currency_type_rcd code  NOT NULL ,
	valid_from_date_time datetime  NOT NULL ,
	valid_until_date_time datetime  NULL ,
	amount               currency  NOT NULL ,
	equals_amount        currency  NOT NULL ,
	decimal_count        integer  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_currency
	ADD CONSTRAINT XPKfinancial_currency PRIMARY KEY  CLUSTERED (financial_currency_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_currency ON financial_currency
( 
	financial_currency_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_currency ON financial_currency
( 
	financial_currency_against_financial_currency_type_rcd  ASC
)
go



CREATE TABLE financial_currency_type_ref
( 
	financial_currency_type_rcd code  NOT NULL ,
	financial_currency_type_code name  NOT NULL ,
	financial_currency_type_name name  NOT NULL ,
	decimal_count        integer  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_currency_type_ref
	ADD CONSTRAINT XPKfinancial_currency_type_ref PRIMARY KEY  CLUSTERED (financial_currency_type_rcd ASC)
go



CREATE TABLE financial_fare
( 
	financial_fare_id    id  NOT NULL ,
	financial_fare_type_rcd code  NOT NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	valid_from_flight_date_time datetime  NOT NULL ,
	valid_until_flight_date_time datetime  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_fare
	ADD CONSTRAINT XPKfinancial_fare PRIMARY KEY  CLUSTERED (financial_fare_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_fare ON financial_fare
( 
	financial_fare_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_fare ON financial_fare
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3financial_fare ON financial_fare
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4financial_fare ON financial_fare
( 
	arrival_airport_id    ASC
)
go



CREATE TABLE financial_fare_type_ref
( 
	financial_fare_type_rcd code  NOT NULL ,
	financial_fare_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_fare_type_ref
	ADD CONSTRAINT XPKfinancial_fare_type_ref PRIMARY KEY  CLUSTERED (financial_fare_type_rcd ASC)
go



CREATE TABLE financial_fee
( 
	financial_fee_id     id  NOT NULL ,
	financial_fee_type_rcd name  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_fee
	ADD CONSTRAINT XPKfinancial_fee PRIMARY KEY  CLUSTERED (financial_fee_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_fee ON financial_fee
( 
	financial_fee_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_fee ON financial_fee
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_fee_type_ref
( 
	financial_fee_type_rcd name  NOT NULL ,
	financial_fee_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_fee_type_ref
	ADD CONSTRAINT XPKfinancial_fee_type_ref PRIMARY KEY  CLUSTERED (financial_fee_type_rcd ASC)
go



CREATE TABLE financial_ferry_booking
( 
	financial_ferry_booking_id id  NOT NULL ,
	service_ferry_id     id  NOT NULL ,
	from_date_time       datetime  NOT NULL ,
	until_date_time      datetime  NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_ferry_booking
	ADD CONSTRAINT XPKfinancial_ferry_booking PRIMARY KEY  CLUSTERED (financial_ferry_booking_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_ferry_booking ON financial_ferry_booking
( 
	service_ferry_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_ferry_booking ON financial_ferry_booking
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_hotel_booking
( 
	financial_hotel_booking_id id  NOT NULL ,
	service_hotel_id     id  NOT NULL ,
	from_date_time       datetime  NOT NULL ,
	until_date_time      datetime  NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_hotel_booking
	ADD CONSTRAINT XPKfinancial_hotel_booking PRIMARY KEY  CLUSTERED (financial_hotel_booking_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_hotel_booking ON financial_hotel_booking
( 
	service_hotel_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_hotel_booking ON financial_hotel_booking
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment
( 
	financial_payment_id id  NOT NULL ,
	financial_payment_type_rcd code  NOT NULL ,
	financial_payment_card_id id  NULL ,
	financial_payment_cash_id id  NULL ,
	financial_payment_voucher_id id  NULL ,
	financial_payment_coupon_id id  NULL ,
	financial_payment_bank_id id  NULL ,
	financial_payment_accounting_id id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment
	ADD CONSTRAINT XPKfinancial_payment PRIMARY KEY  CLUSTERED (financial_payment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment ON financial_payment
( 
	financial_payment_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3financial_payment ON financial_payment
( 
	financial_payment_accounting_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4financial_payment ON financial_payment
( 
	financial_payment_bank_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5financial_payment ON financial_payment
( 
	financial_payment_voucher_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6financial_payment ON financial_payment
( 
	financial_payment_card_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF7financial_payment ON financial_payment
( 
	financial_payment_cash_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF8financial_payment ON financial_payment
( 
	financial_payment_coupon_id  ASC
)
go



CREATE TABLE financial_payment_accounting
( 
	financial_payment_accounting_id id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_accounting
	ADD CONSTRAINT XPKfinancial_payment_accounting PRIMARY KEY  CLUSTERED (financial_payment_accounting_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_accounting ON financial_payment_accounting
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment_bank
( 
	financial_payment_bank_id id  NOT NULL ,
	financial_bank_account_number_type_rcd code  NOT NULL ,
	bank_name            name  NOT NULL ,
	bank_account         code  NOT NULL ,
	bank_number          code  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_bank
	ADD CONSTRAINT XPKfinancial_payment_bank PRIMARY KEY  CLUSTERED (financial_payment_bank_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_bank ON financial_payment_bank
( 
	financial_bank_account_number_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_payment_bank ON financial_payment_bank
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment_card
( 
	financial_payment_card_id id  NOT NULL ,
	financial_card_type_rcd code  NOT NULL ,
	name_on_card         code  NOT NULL ,
	card_number          code  NOT NULL ,
	card_verification_value integer  NULL ,
	address_verification_code code  NULL ,
	issued_year          integer  NULL ,
	issued_month         integer  NULL ,
	expiry_year          integer  NOT NULL ,
	expiry_month         integer  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_card
	ADD CONSTRAINT XPKfinancial_payment_card PRIMARY KEY  CLUSTERED (financial_payment_card_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_card ON financial_payment_card
( 
	financial_card_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_payment_card ON financial_payment_card
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment_cash
( 
	financial_payment_cash_id id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_cash
	ADD CONSTRAINT XPKfinancial_payment_cash PRIMARY KEY  CLUSTERED (financial_payment_cash_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_cash ON financial_payment_cash
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment_coupon
( 
	financial_payment_coupon_id id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	financial_coupon_id  id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_coupon
	ADD CONSTRAINT XPKfinancial_payment_coupon PRIMARY KEY  CLUSTERED (financial_payment_coupon_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_coupon ON financial_payment_coupon
( 
	financial_coupon_id   ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_payment_coupon ON financial_payment_coupon
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_payment_type_ref
( 
	financial_payment_type_rcd code  NOT NULL ,
	financial_payment_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_type_ref
	ADD CONSTRAINT XPKfinancial_payment_type_ref PRIMARY KEY  CLUSTERED (financial_payment_type_rcd ASC)
go



CREATE TABLE financial_payment_voucher
( 
	financial_payment_voucher_id id  NOT NULL ,
	financial_voucher_id id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_payment_voucher
	ADD CONSTRAINT XPKfinancial_payment_voucher PRIMARY KEY  CLUSTERED (financial_payment_voucher_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_payment_voucher ON financial_payment_voucher
( 
	financial_voucher_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_payment_voucher ON financial_payment_voucher
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_service
( 
	financial_service_id id  NOT NULL ,
	booking_service_request_id id  NOT NULL ,
	service_type_rcd     code  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	financial_special_service_id id  NULL ,
	financial_hotel_booking_id id  NULL ,
	financial_car_rental_id id  NULL ,
	financial_ferry_booking_id id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_service
	ADD CONSTRAINT XPKfinancial_service PRIMARY KEY  CLUSTERED (financial_service_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_service ON financial_service
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_service ON financial_service
( 
	service_type_rcd      ASC
)
go



CREATE NONCLUSTERED INDEX XIF3financial_service ON financial_service
( 
	financial_special_service_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4financial_service ON financial_service
( 
	financial_hotel_booking_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5financial_service ON financial_service
( 
	financial_car_rental_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF6financial_service ON financial_service
( 
	booking_service_request_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF7financial_service ON financial_service
( 
	financial_ferry_booking_id  ASC
)
go



CREATE TABLE financial_special_service
( 
	financial_special_service_id id  NOT NULL ,
	service_special_service_request_id id  NOT NULL ,
	quantity             integer  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_special_service
	ADD CONSTRAINT XPKfinancial_special_service PRIMARY KEY  CLUSTERED (financial_special_service_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_special_service ON financial_special_service
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_special_service ON financial_special_service
( 
	service_special_service_request_id  ASC
)
go



CREATE TABLE financial_tax
( 
	financial_tax_id     id  NOT NULL ,
	financial_tax_type_rcd code  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_tax
	ADD CONSTRAINT XPKfinancial_tax PRIMARY KEY  CLUSTERED (financial_tax_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_tax ON financial_tax
( 
	financial_tax_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_tax ON financial_tax
( 
	financial_currency_id  ASC
)
go



CREATE TABLE financial_tax_type_ref
( 
	financial_tax_type_rcd code  NOT NULL ,
	financial_tax_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_tax_type_ref
	ADD CONSTRAINT XPKfinancial_tax_type_ref PRIMARY KEY  CLUSTERED (financial_tax_type_rcd ASC)
go



CREATE TABLE financial_voucher
( 
	financial_voucher_id id  NOT NULL ,
	financial_voucher_type_rcd code  NOT NULL ,
	voucher_number       integer  NOT NULL ,
	voucher_description  description  NULL ,
	value_amount         currency  NULL ,
	financial_currency_id id  NOT NULL ,
	valid_from_date_time datetime  NOT NULL ,
	valid_until_date_time datetime  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_voucher
	ADD CONSTRAINT XPKfinancial_voucher PRIMARY KEY  CLUSTERED (financial_voucher_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1financial_voucher ON financial_voucher
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2financial_voucher ON financial_voucher
( 
	financial_voucher_type_rcd  ASC
)
go



CREATE TABLE financial_voucher_type_ref
( 
	financial_voucher_type_rcd code  NOT NULL ,
	financial_voucher_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE financial_voucher_type_ref
	ADD CONSTRAINT XPKfinancial_voucher_type_ref PRIMARY KEY  CLUSTERED (financial_voucher_type_rcd ASC)
go



CREATE TABLE flight
( 
	flight_id            id  NOT NULL ,
	became_flight_id     id  NULL ,
	binding_flight_id    id  NOT NULL ,
	airline_id           id  NOT NULL ,
	aircraft_id          id  NOT NULL ,
	aircraft_type_rcd    code  NOT NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	from_date_time       datetime  NULL ,
	until_date_time      datetime  NULL ,
	comment              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight
	ADD CONSTRAINT XPKflight PRIMARY KEY  CLUSTERED (flight_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight ON flight
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight ON flight
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF3flight ON flight
( 
	arrival_airport_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIF4flight ON flight
( 
	aircraft_type_rcd     ASC
)
go



CREATE NONCLUSTERED INDEX XIE1flight ON flight
( 
	binding_flight_id     ASC
)
go



CREATE NONCLUSTERED INDEX XIF5flight ON flight
( 
	aircraft_id           ASC
)
go



CREATE TABLE flight_event
( 
	flight_event_id      id  NOT NULL ,
	flight_id            id  NOT NULL ,
	flight_event_number  integer  NOT NULL ,
	date_time_type_rcd   code  NOT NULL ,
	new_date_time        datetime  NOT NULL ,
	remarks              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_event
	ADD CONSTRAINT XPKflight_event PRIMARY KEY  CLUSTERED (flight_event_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_event ON flight_event
( 
	flight_id             ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_event ON flight_event
( 
	date_time_type_rcd    ASC
)
go



CREATE TABLE flight_identifier
( 
	flight_identifier_id id  NOT NULL ,
	flight_id            id  NOT NULL ,
	flight_identifier_code code  NOT NULL ,
	flight_identifier_type_rcd code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_identifier
	ADD CONSTRAINT XPKflight_identifier PRIMARY KEY  CLUSTERED (flight_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_identifier ON flight_identifier
( 
	flight_identifier_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_identifier ON flight_identifier
( 
	flight_id             ASC
)
go



CREATE TABLE flight_identifier_type_ref
( 
	flight_identifier_type_rcd code  NOT NULL ,
	flight_identifier_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_identifier_type_ref
	ADD CONSTRAINT XPKflight_identifier_type_ref PRIMARY KEY  CLUSTERED (flight_identifier_type_rcd ASC)
go



CREATE TABLE flight_schedule
( 
	flight_schedule_id   id  NOT NULL ,
	became_flight_schedule_id id  NULL ,
	binding_flight_schedule_id id  NOT NULL ,
	airline_id           id  NOT NULL ,
	aircraft_type_rcd    code  NOT NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	comment              name  NULL ,
	from_date_time       datetime  NOT NULL ,
	until_date_time      datetime  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_schedule
	ADD CONSTRAINT XPKflight_schedule PRIMARY KEY  CLUSTERED (flight_schedule_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_schedule ON flight_schedule
( 
	airline_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_schedule ON flight_schedule
( 
	aircraft_type_rcd     ASC
)
go



CREATE NONCLUSTERED INDEX XIF3flight_schedule ON flight_schedule
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4flight_schedule ON flight_schedule
( 
	arrival_airport_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIE1flight_schedule ON flight_schedule
( 
	binding_flight_schedule_id  ASC
)
go



CREATE TABLE flight_schedule_identifier
( 
	flight_schedule_identifier_id id  NOT NULL ,
	flight_schedule_id   id  NOT NULL ,
	flight_identifier_type_rcd code  NOT NULL ,
	flight_identifier_code code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_schedule_identifier
	ADD CONSTRAINT XPKflight_schedule_identifier PRIMARY KEY  CLUSTERED (flight_schedule_identifier_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_schedule_identifier ON flight_schedule_identifier
( 
	flight_schedule_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_schedule_identifier ON flight_schedule_identifier
( 
	flight_identifier_type_rcd  ASC
)
go



CREATE TABLE flight_schedule_segment
( 
	flight_schedule_segment_id id  NOT NULL ,
	flight_schedule_id   id  NOT NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	physical_segment_number integer  NULL ,
	logical_segment_number integer  NOT NULL ,
	departure_time       time  NOT NULL ,
	arrival_time         time  NOT NULL ,
	departure_gate       code  NULL ,
	arrival_gate         code  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_schedule_segment
	ADD CONSTRAINT XPKflight_schedule_segment PRIMARY KEY  CLUSTERED (flight_schedule_segment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_schedule_segment ON flight_schedule_segment
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_schedule_segment ON flight_schedule_segment
( 
	arrival_airport_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIF3flight_schedule_segment ON flight_schedule_segment
( 
	flight_schedule_id    ASC
)
go



CREATE TABLE flight_schedule_segment_rule
( 
	flight_schedule_segment_rule_id id  NOT NULL ,
	flight_schedule_segment_id id  NOT NULL ,
	flight_schedule_segment_rule_rcd code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_schedule_segment_rule
	ADD CONSTRAINT XPKflight_schedule_segment_rule PRIMARY KEY  CLUSTERED (flight_schedule_segment_rule_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_schedule_segment_rule ON flight_schedule_segment_rule
( 
	flight_schedule_segment_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_schedule_segment_rule ON flight_schedule_segment_rule
( 
	flight_schedule_segment_rule_rcd  ASC
)
go



CREATE TABLE flight_schedule_segment_rule_ref
( 
	flight_schedule_segment_rule_rcd code  NOT NULL ,
	flight_schedule_segment_rule_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_schedule_segment_rule_ref
	ADD CONSTRAINT XPKflight_schedule_segment_rule_ref PRIMARY KEY  CLUSTERED (flight_schedule_segment_rule_rcd ASC)
go



CREATE TABLE flight_segment
( 
	flight_segment_id    id  NOT NULL ,
	flight_id            id  NOT NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	logical_segment_number integer  NOT NULL ,
	physical_segment_number integer  NULL ,
	from_date_time       datetime  NOT NULL ,
	until_date_time      datetime  NOT NULL ,
	departure_gate       code  NULL ,
	arrival_gate         code  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_segment
	ADD CONSTRAINT XPKflight_segment PRIMARY KEY  CLUSTERED (flight_segment_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1flight_segment ON flight_segment
( 
	flight_id             ASC
)
go



CREATE NONCLUSTERED INDEX XIF2flight_segment ON flight_segment
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3flight_segment ON flight_segment
( 
	arrival_airport_id    ASC
)
go



CREATE TABLE flight_segment_event
( 
	flight_segment_event_id id  NOT NULL ,
	flight_segment_id    id  NOT NULL ,
	flight_segment_event_number integer  NOT NULL ,
	date_time_type_rcd   code  NOT NULL ,
	new_date_time        datetime  NOT NULL ,
	remarks              name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE flight_segment_event
	ADD CONSTRAINT XPKflight_segment_event PRIMARY KEY  CLUSTERED (flight_segment_event_id ASC)
go



CREATE NONCLUSTERED INDEX XIF2flight_segment_event ON flight_segment_event
( 
	date_time_type_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIF3flight_segment_event ON flight_segment_event
( 
	flight_segment_id     ASC
)
go



CREATE TABLE gender_ref
( 
	gender_rcd           code  NOT NULL ,
	gender_name          name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE gender_ref
	ADD CONSTRAINT XPKgender_ref PRIMARY KEY  CLUSTERED (gender_rcd ASC)
go



CREATE TABLE language_ref
( 
	language_rcd         code  NOT NULL ,
	language_name        name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE language_ref
	ADD CONSTRAINT XPKlanguage_ref PRIMARY KEY  CLUSTERED (language_rcd ASC)
go



CREATE TABLE link_type_ref
( 
	link_type_rcd        code  NOT NULL ,
	link_type_name       name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE link_type_ref
	ADD CONSTRAINT XPKlink_type_ref PRIMARY KEY  CLUSTERED (link_type_rcd ASC)
go



CREATE TABLE nationality_ref
( 
	nationality_rcd      code  NOT NULL ,
	nationality_name     name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE nationality_ref
	ADD CONSTRAINT XPKnationality_ref PRIMARY KEY  CLUSTERED (nationality_rcd ASC)
go



CREATE TABLE passenger
( 
	passenger_id         id  NOT NULL ,
	became_passenger_id  id  NULL ,
	binding_passenger_id id  NOT NULL ,
	passenger_type_rcd   code  NOT NULL ,
	passenger_name       name  NOT NULL ,
	default_state_rcd    code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE passenger
	ADD CONSTRAINT XPKpassenger PRIMARY KEY  CLUSTERED (passenger_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1passenger ON passenger
( 
	passenger_type_rcd    ASC
)
go



CREATE NONCLUSTERED INDEX XIE1passenger ON passenger
( 
	passenger_id          ASC,
	user_id               ASC
)
go



CREATE TABLE passenger_type_ref
( 
	passenger_type_rcd   code  NOT NULL ,
	passenger_type_name  name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE passenger_type_ref
	ADD CONSTRAINT XPKpassenger_type_ref PRIMARY KEY  CLUSTERED (passenger_type_rcd ASC)
go



CREATE TABLE product
( 
	product_id           id  NOT NULL ,
	product_name         name  NOT NULL ,
	state_rcd            code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL ,
	product_became_id    id  NULL 
)
go



ALTER TABLE product
	ADD CONSTRAINT XPKproduct PRIMARY KEY  CLUSTERED (product_id ASC)
go



CREATE NONCLUSTERED INDEX XIF5product ON product
( 
	product_became_id     ASC
)
go



CREATE TABLE reporting_roundup
( 
	reporting_roundup_id id  NOT NULL ,
	date                 datetime  NOT NULL ,
	reporting_roundup_type_rcd code  NOT NULL ,
	reporting_reference_code code  NOT NULL ,
	count_number         integer  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE reporting_roundup
	ADD CONSTRAINT XPKreporting_roundup PRIMARY KEY  CLUSTERED (reporting_roundup_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1reporting_roundup ON reporting_roundup
( 
	reporting_roundup_type_rcd  ASC
)
go



CREATE TABLE reporting_roundup_type_ref
( 
	reporting_roundup_type_rcd code  NOT NULL ,
	reporting_roundup_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE reporting_roundup_type_ref
	ADD CONSTRAINT XPKreporting_roundup_type_ref PRIMARY KEY  CLUSTERED (reporting_roundup_type_rcd ASC)
go



CREATE TABLE service_car_rental
( 
	service_car_rental_id id  NOT NULL ,
	car_name             name  NOT NULL ,
	day_price_amount     currency  NULL ,
	financial_currency_id id  NOT NULL ,
	address_id           id  NULL ,
	product_id           id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_car_rental
	ADD CONSTRAINT XPKservice_car_rental PRIMARY KEY  CLUSTERED (service_car_rental_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_car_rental ON service_car_rental
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_car_rental ON service_car_rental
( 
	address_id            ASC
)
go



CREATE TABLE service_car_rental_link
( 
	service_car_rental_link_id id  NOT NULL ,
	service_car_rental_id id  NOT NULL ,
	link_type_rcd        code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_car_rental_link
	ADD CONSTRAINT XPKservice_car_rental_link PRIMARY KEY  CLUSTERED (service_car_rental_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_car_rental_link ON service_car_rental_link
( 
	service_car_rental_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_car_rental_link ON service_car_rental_link
( 
	link_type_rcd         ASC
)
go



CREATE TABLE service_ferry
( 
	service_ferry_id     id  NOT NULL ,
	ferry_id             id  NOT NULL ,
	amount               currency  NOT NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_ferry
	ADD CONSTRAINT XPKservice_ferry PRIMARY KEY  CLUSTERED (service_ferry_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_ferry ON service_ferry
( 
	ferry_id              ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_ferry ON service_ferry
( 
	financial_currency_id  ASC
)
go



CREATE TABLE service_hotel
( 
	service_hotel_id     id  NOT NULL ,
	hotel_name           name  NOT NULL ,
	day_price_amount     currency  NULL ,
	financial_currency_id id  NOT NULL ,
	address_id           id  NULL ,
	product_id           id  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_hotel
	ADD CONSTRAINT XPKservice_hotel PRIMARY KEY  CLUSTERED (service_hotel_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_hotel ON service_hotel
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_hotel ON service_hotel
( 
	address_id            ASC
)
go



CREATE TABLE service_hotel_image
( 
	service_hotel_image_id id  NOT NULL ,
	service_hotel_id     id  NOT NULL ,
	service_image_type_rcd code  NOT NULL ,
	image_file_name      name  NULL ,
	image                varbinary(max)  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_hotel_image
	ADD CONSTRAINT XPKservice_hotel_image PRIMARY KEY  CLUSTERED (service_hotel_image_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_hotel_image ON service_hotel_image
( 
	service_image_type_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_hotel_image ON service_hotel_image
( 
	service_hotel_id      ASC
)
go



CREATE TABLE service_hotel_link
( 
	service_hotel_link_id id  NOT NULL ,
	service_hotel_id     id  NOT NULL ,
	link_type_rcd        code  NOT NULL ,
	link                 name  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_hotel_link
	ADD CONSTRAINT XPKservice_hotel_link PRIMARY KEY  CLUSTERED (service_hotel_link_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_hotel_link ON service_hotel_link
( 
	service_hotel_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_hotel_link ON service_hotel_link
( 
	link_type_rcd         ASC
)
go



CREATE TABLE service_image_type_ref
( 
	service_image_type_rcd code  NOT NULL ,
	service_image_type_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_image_type_ref
	ADD CONSTRAINT XPKservice_image_type_ref PRIMARY KEY  CLUSTERED (service_image_type_rcd ASC)
go



CREATE TABLE service_package
( 
	service_package_id   id  NOT NULL ,
	service_package_name name  NOT NULL ,
	service_hotel_id     id  NULL ,
	service_special_service_request_id id  NULL ,
	service_car_rental_id id  NULL ,
	departure_airport_id id  NOT NULL ,
	arrival_airport_id   id  NOT NULL ,
	stay_duration_days   integer  NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_package
	ADD CONSTRAINT XPKservice_package PRIMARY KEY  CLUSTERED (service_package_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_package ON service_package
( 
	service_hotel_id      ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_package ON service_package
( 
	service_special_service_request_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3service_package ON service_package
( 
	service_car_rental_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4service_package ON service_package
( 
	departure_airport_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5service_package ON service_package
( 
	arrival_airport_id    ASC
)
go



CREATE TABLE service_package_promotion
( 
	service_package_promotion_id id  NOT NULL ,
	service_package_id   id  NOT NULL ,
	promotion_price_amount currency  NULL ,
	financial_currency_id id  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL ,
	booking_id           id  NULL ,
	client_id            id  NOT NULL 
)
go



ALTER TABLE service_package_promotion
	ADD CONSTRAINT XPKservice_package_promotion PRIMARY KEY  CLUSTERED (service_package_promotion_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_package_promotion ON service_package_promotion
( 
	service_package_id    ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_package_promotion ON service_package_promotion
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3service_package_promotion ON service_package_promotion
( 
	booking_id            ASC
)
go



CREATE NONCLUSTERED INDEX XIF4service_package_promotion ON service_package_promotion
( 
	client_id             ASC
)
go



CREATE TABLE service_request_status_ref
( 
	service_request_status_rcd code  NOT NULL ,
	service_request_status_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL ,
	description          text  NULL 
)
go



ALTER TABLE service_request_status_ref
	ADD CONSTRAINT XPKservice_request_status_ref PRIMARY KEY  CLUSTERED (service_request_status_rcd ASC)
go



CREATE TABLE service_special_service_request
( 
	service_special_service_request_id id  NOT NULL ,
	service_special_service_request_group_rcd code  NOT NULL ,
	service_special_service_request_code code  NOT NULL ,
	service_special_service_request_name name  NOT NULL ,
	service_description  description  NULL ,
	amount               currency  NULL ,
	financial_currency_id id  NULL ,
	inventory_controlled_flag flag  NOT NULL ,
	request_service_special_service_request_requirement_rcd code  NOT NULL ,
	reply_service_special_service_request_requirement_rcd code  NOT NULL ,
	service_special_service_request_operation_rule_rcd code  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_special_service_request
	ADD CONSTRAINT XPKservice_special_service_request PRIMARY KEY  CLUSTERED (service_special_service_request_id ASC)
go



CREATE NONCLUSTERED INDEX XIF1service_special_service_request ON service_special_service_request
( 
	financial_currency_id  ASC
)
go



CREATE NONCLUSTERED INDEX XIF2service_special_service_request ON service_special_service_request
( 
	service_special_service_request_group_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF3service_special_service_request ON service_special_service_request
( 
	request_service_special_service_request_requirement_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF4service_special_service_request ON service_special_service_request
( 
	reply_service_special_service_request_requirement_rcd  ASC
)
go



CREATE NONCLUSTERED INDEX XIF5service_special_service_request ON service_special_service_request
( 
	service_special_service_request_operation_rule_rcd  ASC
)
go



CREATE TABLE service_special_service_request_group_ref
( 
	service_special_service_request_group_rcd code  NOT NULL ,
	service_special_service_request_group_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_special_service_request_group_ref
	ADD CONSTRAINT XPKservice_special_service_request_group_ref PRIMARY KEY  CLUSTERED (service_special_service_request_group_rcd ASC)
go



CREATE TABLE service_special_service_request_operation_rule_ref
( 
	service_special_service_request_operation_rule_rcd code  NOT NULL ,
	service_special_service_request_operation_rule_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_special_service_request_operation_rule_ref
	ADD CONSTRAINT XPKservice_special_service_request_operation_rule_ref PRIMARY KEY  CLUSTERED (service_special_service_request_operation_rule_rcd ASC)
go



CREATE TABLE service_special_service_request_requirement_ref
( 
	service_special_service_request_requirement_rcd code  NOT NULL ,
	service_special_service_request_requirement_name name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_special_service_request_requirement_ref
	ADD CONSTRAINT XPKservice_special_service_request_requirement_ref PRIMARY KEY  CLUSTERED (service_special_service_request_requirement_rcd ASC)
go



CREATE TABLE service_type_ref
( 
	service_type_rcd     code  NOT NULL ,
	service_type_name    name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE service_type_ref
	ADD CONSTRAINT XPKservice_type_ref PRIMARY KEY  CLUSTERED (service_type_rcd ASC)
go



CREATE TABLE timezone
( 
	timezone_id          id  NOT NULL ,
	timezone_name        char(180)  NOT NULL ,
	utc_offset           char(18)  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE timezone
	ADD CONSTRAINT XPKtimezone PRIMARY KEY  CLUSTERED (timezone_id ASC)
go



CREATE TABLE title_ref
( 
	title_rcd            code  NOT NULL ,
	title_name           name  NOT NULL ,
	user_id              id  NOT NULL ,
	date_time            datetime  NOT NULL 
)
go



ALTER TABLE title_ref
	ADD CONSTRAINT XPKtitle_ref PRIMARY KEY  CLUSTERED (title_rcd ASC)
go




ALTER TABLE address
	ADD CONSTRAINT address_to_address_type_ref FOREIGN KEY (address_type_rcd) REFERENCES address_type_ref(address_type_rcd)
go




ALTER TABLE aircraft
	ADD CONSTRAINT aircraft_to_aircraft_body_ref FOREIGN KEY (aircraft_body_rcd) REFERENCES aircraft_body_ref(aircraft_body_rcd)
go




ALTER TABLE aircraft
	ADD CONSTRAINT aircraft_to_aircraft_configuration_ref FOREIGN KEY (aircraft_configuration_rcd) REFERENCES aircraft_configuration_ref(aircraft_configuration_rcd)
go




ALTER TABLE aircraft
	ADD CONSTRAINT aircraft_to_aircraft_type FOREIGN KEY (aircraft_type_rcd) REFERENCES aircraft_type_ref(aircraft_type_rcd)
go




ALTER TABLE aircraft
	ADD CONSTRAINT aircraft_to_aircraft_maintenance FOREIGN KEY (aircraft_measurement_id) REFERENCES aircraft_measurement(aircraft_measurement_id)
go




ALTER TABLE aircraft
	ADD CONSTRAINT aircraft_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE aircraft_compartment
	ADD CONSTRAINT aircraft_compartment_to_aircraft FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
go




ALTER TABLE aircraft_compartment
	ADD CONSTRAINT aircraft_compartment_to_aircraft_compartment_type_ref FOREIGN KEY (aircraft_compartment_type_rcd) REFERENCES aircraft_compartment_type_ref(aircraft_compartment_type_rcd)
go




ALTER TABLE aircraft_compartment
	ADD CONSTRAINT aircraft_compartment_to_aircraft_compartment_measurement FOREIGN KEY (aircraft_compartment_measurement_id) REFERENCES aircraft_compartment_measurement(aircraft_compartment_measurement_id)
go




ALTER TABLE aircraft_document
	ADD CONSTRAINT aircraft_document_to_aircraft FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
go




ALTER TABLE aircraft_document
	ADD CONSTRAINT aircraft_document_to_aircraft_document_type_ref FOREIGN KEY (aircraft_document_type_rcd) REFERENCES aircraft_document_type_ref(aircraft_document_type_rcd)
go




ALTER TABLE aircraft_identifier
	ADD CONSTRAINT aircraft_identifier_to_aircraft FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
go




ALTER TABLE aircraft_identifier
	ADD CONSTRAINT aircraft_identifier_to_aircraft_identifier__type_ref FOREIGN KEY (aircraft_identifier_type_rcd) REFERENCES aircraft_identifier_type_ref(aircraft_identifier_type_rcd)
go




ALTER TABLE airline
	ADD CONSTRAINT airline_to_airline_type_ref FOREIGN KEY (airline_type_rcd) REFERENCES airline_type_ref(airline_type_rcd)
go




ALTER TABLE airline
	ADD CONSTRAINT airline_to_address FOREIGN KEY (address_id) REFERENCES address(address_id)
go




ALTER TABLE airline
	ADD CONSTRAINT airline_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE airline_base_airport
	ADD CONSTRAINT airline_base_airport_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airline_base_airport
	ADD CONSTRAINT airline_base_airport_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airline_contact_method
	ADD CONSTRAINT airline_contact_method_to_contact_method_ref FOREIGN KEY (contact_method_rcd) REFERENCES contact_method_ref(contact_method_rcd)
go




ALTER TABLE airline_contact_method
	ADD CONSTRAINT airline_contact_method_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airline_identifier
	ADD CONSTRAINT airline_identifier_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airline_identifier
	ADD CONSTRAINT airline_identifier_to_airline_identifier_type_ref FOREIGN KEY (airline_identifier_type_rcd) REFERENCES airline_identifier_type_ref(airline_identifier_type_rcd)
go




ALTER TABLE airline_language
	ADD CONSTRAINT airline_language_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airline_language
	ADD CONSTRAINT airline_language_to_language_ref FOREIGN KEY (language_rcd) REFERENCES language_ref(language_rcd)
go




ALTER TABLE airline_link
	ADD CONSTRAINT airline_url_to_url_type_ref FOREIGN KEY (link_type_rcd) REFERENCES link_type_ref(link_type_rcd)
go




ALTER TABLE airline_link
	ADD CONSTRAINT airline_link_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airport
	ADD CONSTRAINT airport_to_city FOREIGN KEY (city_id) REFERENCES city(city_id)
go




ALTER TABLE airport
	ADD CONSTRAINT airport_to_airport_type_ref FOREIGN KEY (airport_type_rcd) REFERENCES airport_type_ref(airport_type_rcd)
go




ALTER TABLE airport
	ADD CONSTRAINT airport_to_timezone FOREIGN KEY (timezone_id) REFERENCES timezone(timezone_id)
go




ALTER TABLE airport
	ADD CONSTRAINT airport_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE airport_facility
	ADD CONSTRAINT airport_facility_to_airport_facility_type_ref FOREIGN KEY (airport_facility_type_rcd) REFERENCES airport_facility_type_ref(airport_facility_type_rcd)
go




ALTER TABLE airport_facility
	ADD CONSTRAINT airport_to_airport_facility FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_hotel_link
	ADD CONSTRAINT airport_hotel_link_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_hotel_link
	ADD CONSTRAINT airport_hotel_link_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE airport_identifier
	ADD CONSTRAINT airport_identifier_to_airport_identifier_type_ref FOREIGN KEY (airport_identifier_type_rcd) REFERENCES airport_identifier_type_ref(airport_identifier_type_rcd)
go




ALTER TABLE airport_identifier
	ADD CONSTRAINT airport_identifier_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_link
	ADD CONSTRAINT airport_link_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_link
	ADD CONSTRAINT airport_link_to_link_type_ref FOREIGN KEY (link_type_rcd) REFERENCES link_type_ref(link_type_rcd)
go




ALTER TABLE airport_runway
	ADD CONSTRAINT airport_runway_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_supplier_link
	ADD CONSTRAINT airport_supplier_link_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_supplier_link
	ADD CONSTRAINT airport_supplier_link_to_airport_supplier FOREIGN KEY (airport_supplier_id) REFERENCES airport_supplier(airport_supplier_id)
go




ALTER TABLE airport_terminal
	ADD CONSTRAINT airport_terminal_to_airport FOREIGN KEY (airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE airport_terminal_airline
	ADD CONSTRAINT airport_terminal_airline_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE airport_terminal_airline
	ADD CONSTRAINT airport_terminal_airline_to_airport_terminal FOREIGN KEY (airport_terminal_id) REFERENCES airport_terminal(airport_terminal_id)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_address FOREIGN KEY (address_id) REFERENCES address(address_id)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_booking_source_ref FOREIGN KEY (booking_source_rcd) REFERENCES booking_source_ref(booking_source_rcd)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_external_system FOREIGN KEY (external_system_id) REFERENCES external_system(external_system_id)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_agency FOREIGN KEY (agency_id) REFERENCES agency(agency_id)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE booking
	ADD CONSTRAINT booking_to_financial_costcentre FOREIGN KEY (financial_costcentre_id) REFERENCES financial_costcentre(financial_costcentre_id)
go




ALTER TABLE booking_contact_method
	ADD CONSTRAINT booking_contact_method_to_contact_method_ref FOREIGN KEY (contact_method_rcd) REFERENCES contact_method_ref(contact_method_rcd)
go




ALTER TABLE booking_contact_method
	ADD CONSTRAINT contact_method_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_document
	ADD CONSTRAINT booking_document_to_booking_document_type_ref FOREIGN KEY (booking_document_type_rcd) REFERENCES booking_document_type_ref(booking_document_type_rcd)
go




ALTER TABLE booking_document
	ADD CONSTRAINT booking_document_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_event
	ADD CONSTRAINT booking_event_to_booking_event_type_ref FOREIGN KEY (booking_event_type_rcd) REFERENCES booking_event_type_ref(booking_event_type_rcd)
go




ALTER TABLE booking_event
	ADD CONSTRAINT booking_event_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_flight_segment
	ADD CONSTRAINT booking_flight_segment_to_flight_segment FOREIGN KEY (flight_segment_id) REFERENCES flight_segment(flight_segment_id)
go




ALTER TABLE booking_flight_segment
	ADD CONSTRAINT booking_flight_segment_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_identifier
	ADD CONSTRAINT booking_identifier_to_booking_identifier_type_ref FOREIGN KEY (booking_identifier_type_rcd) REFERENCES booking_identifier_type_ref(booking_identifier_type_rcd)
go




ALTER TABLE booking_identifier
	ADD CONSTRAINT booking_identifier_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_passenger
	ADD CONSTRAINT booking_passenger_mapping_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_passenger
	ADD CONSTRAINT booking_passenger_mapping_to_passenger FOREIGN KEY (passenger_id) REFERENCES passenger(passenger_id)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_flight_segment FOREIGN KEY (booking_flight_segment_id) REFERENCES booking_flight_segment(booking_flight_segment_id)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_passenger FOREIGN KEY (booking_passenger_id) REFERENCES booking_passenger(booking_passenger_id)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_passenger_event_type_ref FOREIGN KEY (booking_passenger_event_type_rcd) REFERENCES booking_passenger_event_type_ref(booking_passenger_event_type_rcd)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_passenger_ticket FOREIGN KEY (booking_passenger_ticket_id) REFERENCES booking_passenger_ticket(booking_passenger_ticket_id)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_passenger_seat FOREIGN KEY (booking_passenger_seat_id) REFERENCES booking_passenger_seat(booking_passenger_seat_id)
go




ALTER TABLE booking_passenger_event
	ADD CONSTRAINT booking_passenger_event_to_booking_passenger_baggage FOREIGN KEY (booking_passenger_baggage_id) REFERENCES booking_passenger_baggage(booking_passenger_baggage_id)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_special_service_request_to_service_special_service_request FOREIGN KEY (service_special_service_request_id) REFERENCES service_special_service_request(service_special_service_request_id)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_special_service_request_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_service_request_to_service_request_status_ref FOREIGN KEY (service_request_status_rcd) REFERENCES service_request_status_ref(service_request_status_rcd)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_service_request_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_service_request_to_service_car_rental FOREIGN KEY (service_car_rental_id) REFERENCES service_car_rental(service_car_rental_id)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_service_request_to_service_type_ref FOREIGN KEY (service_type_rcd) REFERENCES service_type_ref(service_type_rcd)
go




ALTER TABLE booking_service_request
	ADD CONSTRAINT booking_service_request_to_service_ferry FOREIGN KEY (service_ferry_id) REFERENCES service_ferry(service_ferry_id)
go




ALTER TABLE cart_product
	ADD CONSTRAINT cart_product_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE cart_product
	ADD CONSTRAINT cart_product_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE cart_product_price
	ADD CONSTRAINT cart_product_price_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE cart_product_price
	ADD CONSTRAINT cart_product_price_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE city
	ADD CONSTRAINT city_to_country FOREIGN KEY (country_id) REFERENCES country(country_id)
go




ALTER TABLE city
	ADD CONSTRAINT city_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_address FOREIGN KEY (address_id) REFERENCES address(address_id)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_nationality_ref FOREIGN KEY (nationality_rcd) REFERENCES nationality_ref(nationality_rcd)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_gender_ref FOREIGN KEY (gender_rcd) REFERENCES gender_ref(gender_rcd)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_title_ref FOREIGN KEY (title_rcd) REFERENCES title_ref(title_rcd)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_client_type_ref FOREIGN KEY (client_type_rcd) REFERENCES client_type_ref(client_type_rcd)
go




ALTER TABLE client
	ADD CONSTRAINT client_to_passenger_type_ref FOREIGN KEY (passenger_type_rcd) REFERENCES passenger_type_ref(passenger_type_rcd)
go




ALTER TABLE client_contact_method
	ADD CONSTRAINT client_contact_method_to_client FOREIGN KEY (client_id) REFERENCES client(client_id)
go




ALTER TABLE client_contact_method
	ADD CONSTRAINT client_contact_method_to_contact_method_ref FOREIGN KEY (contact_method_rcd) REFERENCES contact_method_ref(contact_method_rcd)
go




ALTER TABLE client_event
	ADD CONSTRAINT client_to_client_event FOREIGN KEY (client_id) REFERENCES client(client_id)
go




ALTER TABLE client_event
	ADD CONSTRAINT client_event_to_client_event_type_ref FOREIGN KEY (client_event_type_rcd) REFERENCES client_event_type_ref(client_event_type_rcd)
go




ALTER TABLE client_link
	ADD CONSTRAINT client_link_to_link_type_ref FOREIGN KEY (link_type_rcd) REFERENCES link_type_ref(link_type_rcd)
go




ALTER TABLE client_link
	ADD CONSTRAINT client_link_to_client FOREIGN KEY (client_id) REFERENCES client(client_id)
go




ALTER TABLE country
	ADD CONSTRAINT country_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE ferry
	ADD CONSTRAINT ferry_to_ferry_type_ref FOREIGN KEY (ferry_type_rcd) REFERENCES ferry_type_ref(ferry_type_rcd)
go




ALTER TABLE ferry
	ADD CONSTRAINT ferry_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE ferry_identifier
	ADD CONSTRAINT ferry_identifier_to_ferry FOREIGN KEY (ferry_id) REFERENCES ferry(ferry_id)
go




ALTER TABLE ferry_identifier
	ADD CONSTRAINT ferry_identifier_to_ferry_identifier_type_ref FOREIGN KEY (ferry_identifier_type_rcd) REFERENCES ferry_identifier_type_ref(ferry_identifier_type_rcd)
go




ALTER TABLE financial_adjustment
	ADD CONSTRAINT financial_adjustment_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_adjustment
	ADD CONSTRAINT financial_adjustment_to_financial_adjustment_type_ref FOREIGN KEY (financial_adjustment_type_rcd) REFERENCES financial_adjustment_type_ref(financial_adjustment_type_rcd)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT booking_transaction_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_fee FOREIGN KEY (financial_fee_id) REFERENCES financial_fee(financial_fee_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_tax FOREIGN KEY (financial_tax_id) REFERENCES financial_tax(financial_tax_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_fare FOREIGN KEY (financial_fare_id) REFERENCES financial_fare(financial_fare_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_payment FOREIGN KEY (financial_payment_id) REFERENCES financial_payment(financial_payment_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_costcentre FOREIGN KEY (financial_costcentre_id) REFERENCES financial_costcentre(financial_costcentre_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_adjustment FOREIGN KEY (financial_adjustment_id) REFERENCES financial_adjustment(financial_adjustment_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_service FOREIGN KEY (financial_service_id) REFERENCES financial_service(financial_service_id)
go




ALTER TABLE financial_booking_transaction
	ADD CONSTRAINT financial_booking_transaction_to_financial_booking_transaction_type_ref FOREIGN KEY (financial_booking_transaction_type_rcd) REFERENCES financial_booking_transaction_type_ref(financial_booking_transaction_type_rcd)
go




ALTER TABLE financial_car_rental
	ADD CONSTRAINT financial_car_rental_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_car_rental
	ADD CONSTRAINT financial_car_rental_to_service_car_rental FOREIGN KEY (service_car_rental_id) REFERENCES service_car_rental(service_car_rental_id)
go




ALTER TABLE financial_costcentre
	ADD CONSTRAINT financial_costcentre_to_financial_company FOREIGN KEY (financial_company_id) REFERENCES financial_company(financial_company_id)
go




ALTER TABLE financial_coupon
	ADD CONSTRAINT financial_coupon_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_coupon
	ADD CONSTRAINT financial_coupon_to_financial_coupon_type FOREIGN KEY (financial_coupon_type_rcd) REFERENCES financial_coupon_type_ref(financial_coupon_type_rcd)
go




ALTER TABLE financial_currency
	ADD CONSTRAINT financial_currency_to_financial_currency_type_ref FOREIGN KEY (financial_currency_type_rcd) REFERENCES financial_currency_type_ref(financial_currency_type_rcd)
go




ALTER TABLE financial_currency
	ADD CONSTRAINT financial_currency_against_financial_currency_ref FOREIGN KEY (financial_currency_against_financial_currency_type_rcd) REFERENCES financial_currency_type_ref(financial_currency_type_rcd)
go




ALTER TABLE financial_fare
	ADD CONSTRAINT financial_fare_to_financial_fare_type_ref FOREIGN KEY (financial_fare_type_rcd) REFERENCES financial_fare_type_ref(financial_fare_type_rcd)
go




ALTER TABLE financial_fare
	ADD CONSTRAINT financial_fare_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_fare
	ADD CONSTRAINT from_financial_fare_to_departure_airport FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE financial_fare
	ADD CONSTRAINT financial_fare_to_arrival_airport FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE financial_fee
	ADD CONSTRAINT financial_fee_to_financial_fee_type_ref FOREIGN KEY (financial_fee_type_rcd) REFERENCES financial_fee_type_ref(financial_fee_type_rcd)
go




ALTER TABLE financial_fee
	ADD CONSTRAINT financial_fee_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_ferry_booking
	ADD CONSTRAINT financial_ferry_booking_to_service_ferry FOREIGN KEY (service_ferry_id) REFERENCES service_ferry(service_ferry_id)
go




ALTER TABLE financial_ferry_booking
	ADD CONSTRAINT financial_ferry_booking_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_hotel_booking
	ADD CONSTRAINT financial_hotel_booking_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE financial_hotel_booking
	ADD CONSTRAINT financial_hotel_booking_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_type_ref FOREIGN KEY (financial_payment_type_rcd) REFERENCES financial_payment_type_ref(financial_payment_type_rcd)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_accounting FOREIGN KEY (financial_payment_accounting_id) REFERENCES financial_payment_accounting(financial_payment_accounting_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_bank FOREIGN KEY (financial_payment_bank_id) REFERENCES financial_payment_bank(financial_payment_bank_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_voucher FOREIGN KEY (financial_payment_voucher_id) REFERENCES financial_payment_voucher(financial_payment_voucher_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_card FOREIGN KEY (financial_payment_card_id) REFERENCES financial_payment_card(financial_payment_card_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_cash FOREIGN KEY (financial_payment_cash_id) REFERENCES financial_payment_cash(financial_payment_cash_id)
go




ALTER TABLE financial_payment
	ADD CONSTRAINT financial_payment_to_financial_payment_coupon FOREIGN KEY (financial_payment_coupon_id) REFERENCES financial_payment_coupon(financial_payment_coupon_id)
go




ALTER TABLE financial_payment_accounting
	ADD CONSTRAINT financial_payment_accounting_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment_bank
	ADD CONSTRAINT financial_payment_bank_to_financial_bank_account_number_type_ref FOREIGN KEY (financial_bank_account_number_type_rcd) REFERENCES financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd)
go




ALTER TABLE financial_payment_bank
	ADD CONSTRAINT financial_payment_bank_to_financialcurrency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment_card
	ADD CONSTRAINT financial_payment_card_to_financial_card_type_ref FOREIGN KEY (financial_card_type_rcd) REFERENCES financial_card_type_ref(financial_card_type_rcd)
go




ALTER TABLE financial_payment_card
	ADD CONSTRAINT financial_payment_card_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment_cash
	ADD CONSTRAINT financial_payment_cash_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment_coupon
	ADD CONSTRAINT financial_payment_coupon_to_financial_coupon FOREIGN KEY (financial_coupon_id) REFERENCES financial_coupon(financial_coupon_id)
go




ALTER TABLE financial_payment_coupon
	ADD CONSTRAINT financial_payment_coupon_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_payment_voucher
	ADD CONSTRAINT financial_payment_voucher_to_financial_voucher FOREIGN KEY (financial_voucher_id) REFERENCES financial_voucher(financial_voucher_id)
go




ALTER TABLE financial_payment_voucher
	ADD CONSTRAINT financial_payment_voucher_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_type_ref FOREIGN KEY (service_type_rcd) REFERENCES service_type_ref(service_type_rcd)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_special_service FOREIGN KEY (financial_special_service_id) REFERENCES financial_special_service(financial_special_service_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_hotel_bokking FOREIGN KEY (financial_hotel_booking_id) REFERENCES financial_hotel_booking(financial_hotel_booking_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_car_rental FOREIGN KEY (financial_car_rental_id) REFERENCES financial_car_rental(financial_car_rental_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_booking_service_request FOREIGN KEY (booking_service_request_id) REFERENCES booking_service_request(booking_service_request_id)
go




ALTER TABLE financial_service
	ADD CONSTRAINT financial_service_to_financial_ferry_booking FOREIGN KEY (financial_ferry_booking_id) REFERENCES financial_ferry_booking(financial_ferry_booking_id)
go




ALTER TABLE financial_special_service
	ADD CONSTRAINT financial_special_service_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_special_service
	ADD CONSTRAINT financial_special_service_to_service_special_service_request FOREIGN KEY (service_special_service_request_id) REFERENCES service_special_service_request(service_special_service_request_id)
go




ALTER TABLE financial_tax
	ADD CONSTRAINT financial_tax_to_financial_tax_type_ref FOREIGN KEY (financial_tax_type_rcd) REFERENCES financial_tax_type_ref(financial_tax_type_rcd)
go




ALTER TABLE financial_tax
	ADD CONSTRAINT financial_tax_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_voucher
	ADD CONSTRAINT financial_voucher_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE financial_voucher
	ADD CONSTRAINT financial_voucher_to_financial_voucher_type_ref FOREIGN KEY (financial_voucher_type_rcd) REFERENCES financial_voucher_type_ref(financial_voucher_type_rcd)
go




ALTER TABLE flight
	ADD CONSTRAINT flight_to_airport_arrival FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight
	ADD CONSTRAINT flight_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE flight
	ADD CONSTRAINT flight_to_airport_departure FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight
	ADD CONSTRAINT flight_to_aircraft_type_ref FOREIGN KEY (aircraft_type_rcd) REFERENCES aircraft_type_ref(aircraft_type_rcd)
go




ALTER TABLE flight
	ADD CONSTRAINT flight_to_aircraft FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
go




ALTER TABLE flight_event
	ADD CONSTRAINT flight_event_to_flight FOREIGN KEY (flight_id) REFERENCES flight(flight_id)
go




ALTER TABLE flight_event
	ADD CONSTRAINT flight_point_date_time_to_date_time_type_ref FOREIGN KEY (date_time_type_rcd) REFERENCES date_time_type_ref(date_time_type_rcd)
go




ALTER TABLE flight_identifier
	ADD CONSTRAINT flight_identifier_to_flight_identifier_type_ref FOREIGN KEY (flight_identifier_type_rcd) REFERENCES flight_identifier_type_ref(flight_identifier_type_rcd)
go




ALTER TABLE flight_identifier
	ADD CONSTRAINT flight_identifier_to_flight FOREIGN KEY (flight_id) REFERENCES flight(flight_id)
go




ALTER TABLE flight_schedule
	ADD CONSTRAINT flight_schedule_to_airline FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
go




ALTER TABLE flight_schedule
	ADD CONSTRAINT flight_schedule_to_aircraft_type_ref FOREIGN KEY (aircraft_type_rcd) REFERENCES aircraft_type_ref(aircraft_type_rcd)
go




ALTER TABLE flight_schedule
	ADD CONSTRAINT flight_schedule_to_departure_airport FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_schedule
	ADD CONSTRAINT flight_schedule_to_arrival_airport FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_schedule_identifier
	ADD CONSTRAINT flight_schedule_identifier_to_flight_schedule FOREIGN KEY (flight_schedule_id) REFERENCES flight_schedule(flight_schedule_id)
go




ALTER TABLE flight_schedule_identifier
	ADD CONSTRAINT flight_schedule_identifier_to_flight_identifier_type_ref FOREIGN KEY (flight_identifier_type_rcd) REFERENCES flight_identifier_type_ref(flight_identifier_type_rcd)
go




ALTER TABLE flight_schedule_segment
	ADD CONSTRAINT flight_schedule_segment_to_departure_airport FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_schedule_segment
	ADD CONSTRAINT flight_schedule_segment_to_arrival_airport FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_schedule_segment
	ADD CONSTRAINT flight_schedule_segment_to_flight_schedule FOREIGN KEY (flight_schedule_id) REFERENCES flight_schedule(flight_schedule_id)
go




ALTER TABLE flight_schedule_segment_rule
	ADD CONSTRAINT flight_schedule_segment__rule_to_flight_schedule_segment FOREIGN KEY (flight_schedule_segment_id) REFERENCES flight_schedule_segment(flight_schedule_segment_id)
go




ALTER TABLE flight_schedule_segment_rule
	ADD CONSTRAINT flight_schedule_segment_rule_to_flight_schedule_segment_rule_ref FOREIGN KEY (flight_schedule_segment_rule_rcd) REFERENCES flight_schedule_segment_rule_ref(flight_schedule_segment_rule_rcd)
go




ALTER TABLE flight_segment
	ADD CONSTRAINT flight_segment_to_flight FOREIGN KEY (flight_id) REFERENCES flight(flight_id)
go




ALTER TABLE flight_segment
	ADD CONSTRAINT flight_segment_to_departure_airport FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_segment
	ADD CONSTRAINT flight_segment_to_arrival_airport FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE flight_segment_event
	ADD CONSTRAINT flight_segment_event_to_date_time_type_ref FOREIGN KEY (date_time_type_rcd) REFERENCES date_time_type_ref(date_time_type_rcd)
go




ALTER TABLE flight_segment_event
	ADD CONSTRAINT flight_segment_event_to_flight_segment FOREIGN KEY (flight_segment_id) REFERENCES flight_segment(flight_segment_id)
go




ALTER TABLE passenger
	ADD CONSTRAINT passenger_to_passenger_type_ref FOREIGN KEY (passenger_type_rcd) REFERENCES passenger_type_ref(passenger_type_rcd)
go




ALTER TABLE product
	ADD CONSTRAINT product_to_product_became FOREIGN KEY (product_became_id) REFERENCES product(product_id)
go




ALTER TABLE reporting_roundup
	ADD CONSTRAINT reporting_roundup_to_reporting_roundup_type_ref FOREIGN KEY (reporting_roundup_type_rcd) REFERENCES reporting_roundup_type_ref(reporting_roundup_type_rcd)
go




ALTER TABLE service_car_rental
	ADD CONSTRAINT car_rental_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE service_car_rental
	ADD CONSTRAINT service_car_rental_to_address FOREIGN KEY (address_id) REFERENCES address(address_id)
go




ALTER TABLE service_car_rental
	ADD CONSTRAINT service_car_rental_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE service_car_rental_link
	ADD CONSTRAINT service_car_rental_link_to_service_car_rental FOREIGN KEY (service_car_rental_id) REFERENCES service_car_rental(service_car_rental_id)
go




ALTER TABLE service_car_rental_link
	ADD CONSTRAINT service_car_rental_link_to_link_type_ref FOREIGN KEY (link_type_rcd) REFERENCES link_type_ref(link_type_rcd)
go




ALTER TABLE service_ferry
	ADD CONSTRAINT service_ferry_to_ferry FOREIGN KEY (ferry_id) REFERENCES ferry(ferry_id)
go




ALTER TABLE service_ferry
	ADD CONSTRAINT service_ferry_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE service_hotel
	ADD CONSTRAINT service_hotel_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE service_hotel
	ADD CONSTRAINT service_hotel_to_address FOREIGN KEY (address_id) REFERENCES address(address_id)
go




ALTER TABLE service_hotel
	ADD CONSTRAINT service_hotel_to_product FOREIGN KEY (product_id) REFERENCES product(product_id)
go




ALTER TABLE service_hotel_image
	ADD CONSTRAINT service_image_to_service_image_ref FOREIGN KEY (service_image_type_rcd) REFERENCES service_image_type_ref(service_image_type_rcd)
go




ALTER TABLE service_hotel_image
	ADD CONSTRAINT service_hotel_image_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE service_hotel_link
	ADD CONSTRAINT service_hotel_link_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE service_hotel_link
	ADD CONSTRAINT service_hotel_link_to_link_type_ref FOREIGN KEY (link_type_rcd) REFERENCES link_type_ref(link_type_rcd)
go




ALTER TABLE service_package
	ADD CONSTRAINT service_package_to_service_hotel FOREIGN KEY (service_hotel_id) REFERENCES service_hotel(service_hotel_id)
go




ALTER TABLE service_package
	ADD CONSTRAINT service_package_to_service_special_service_request FOREIGN KEY (service_special_service_request_id) REFERENCES service_special_service_request(service_special_service_request_id)
go




ALTER TABLE service_package
	ADD CONSTRAINT service_package_to_service_car_rental FOREIGN KEY (service_car_rental_id) REFERENCES service_car_rental(service_car_rental_id)
go




ALTER TABLE service_package
	ADD CONSTRAINT service_package_to_departure_airport FOREIGN KEY (departure_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE service_package
	ADD CONSTRAINT service_package_to_arrival_airport FOREIGN KEY (arrival_airport_id) REFERENCES airport(airport_id)
go




ALTER TABLE service_package_promotion
	ADD CONSTRAINT service_package_promotion_to_service_package FOREIGN KEY (service_package_id) REFERENCES service_package(service_package_id)
go




ALTER TABLE service_package_promotion
	ADD CONSTRAINT service_package_promotion_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE service_package_promotion
	ADD CONSTRAINT service_package_promotion_to_booking FOREIGN KEY (booking_id) REFERENCES booking(booking_id)
go




ALTER TABLE service_package_promotion
	ADD CONSTRAINT service_package_promotion_to_client FOREIGN KEY (client_id) REFERENCES client(client_id)
go




ALTER TABLE service_special_service_request
	ADD CONSTRAINT service_special_service_request_to_financial_currency FOREIGN KEY (financial_currency_id) REFERENCES financial_currency(financial_currency_id)
go




ALTER TABLE service_special_service_request
	ADD CONSTRAINT service_special_service_request_to_service_special_service_request_group_ref FOREIGN KEY (service_special_service_request_group_rcd) REFERENCES service_special_service_request_group_ref(service_special_service_request_group_rcd)
go




ALTER TABLE service_special_service_request
	ADD CONSTRAINT request_service_special_service_request_to_service_special_service_request_requirement FOREIGN KEY (request_service_special_service_request_requirement_rcd) REFERENCES service_special_service_request_requirement_ref(service_special_service_request_requirement_rcd)
go




ALTER TABLE service_special_service_request
	ADD CONSTRAINT reply_service_special_service_request_to_service_special_service_request_requirement FOREIGN KEY (reply_service_special_service_request_requirement_rcd) REFERENCES service_special_service_request_requirement_ref(service_special_service_request_requirement_rcd)
go




ALTER TABLE service_special_service_request
	ADD CONSTRAINT service_special_service_request_to_service_special_service_request_operation_rule FOREIGN KEY (service_special_service_request_operation_rule_rcd) REFERENCES service_special_service_request_operation_rule_ref(service_special_service_request_operation_rule_rcd)
go



                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortReferenceData",
                Description = "Port Reference Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'airline_identifier_type_ref'						,'Airline Identifier Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'flight_identifier_type_ref'						,'Flight Identifier Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'airport_identifier_type_ref'						,'Airport Identifier Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'date_time_type_ref'								,'Date Time Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'passenger_type_ref'								,'Passenger Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'contact_method_ref'								,'Contact Method'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'booking_identifier_type_ref'						,'Booking Identifier Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'address_type_ref'									,'Address Type'									,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'booking_document_type_ref'						,'Booking Document Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'booking_source_ref'								,'Booking Source'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'booking_event_type_ref'							,'Booking Event'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'aircraft_type_ref'								,'Aircraft Type'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'flight_schedule_segment_rule_ref'					,'Flight Schedule Segment rule'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_adjustment_type_ref'					,'Financial Adjustment Type'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_currency_type_ref'						,'Financial Currency Type Ref'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_fee_type_ref'							,'Financial Fee Type Ref'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_tax_type_ref'							,'Financial Tax Type Ref'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_fare_type_ref'							,'Financial Fare Type Ref'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_payment_type_ref'						,'Financial Payment Type Ref'					,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'aircraft_body_ref'								,'Aircraft body'								,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_card_type_ref'							,'Financial Card Type'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_bank_account_number_type_ref'			,'Financial Bank Account Number Type'			,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_voucher_type_ref'						,'Financial Voucher Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_coupon_type_ref'						,'Financial Coupon Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'service_type_ref'						,'Financial Service Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'service_special_service_request_requirement_ref'	,'Special Service Request Requirement'			,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'service_special_service_request_group_ref'		,'Special Service Request Group'				,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'service_special_service_request_operation_rule_ref','Special Service Request Operation Rule'		,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'reporting_roundup_type_ref',						 'Reporting Roundup Type'						,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'financial_booking_transaction_type_ref',			 'Financial Booking Transaction Type'			,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- mark
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'airport_type_ref',								 'Airport Type'									,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'airline_type_ref',								 'Airline Type'									,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'link_type_ref',									 'Link Type'									,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_reference_table(default_system_reference_table_id, default_system_reference_table_name, default_system_reference_display_name, default_user_id, date_time) 
	values (newid(), 'service_image_type_ref',							 'Service Image Type'							,'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Airline
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('AC2', 'Airline code Short', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('AC3', 'Airline code Long', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('IATA', 'International Airline Transport Association Code', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('ICAO', 'International Civil Aviation Organization', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('DOTEC', 'Department Of Transport Entity Code', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airline_identifier_type_ref (airline_identifier_type_rcd, airline_identifier_type_name, user_id, date_time) 
	values ('DOTCC', 'Department Of Transport Certification Code', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Flight identifier
insert into flight_identifier_type_ref (flight_identifier_type_rcd, flight_identifier_type_name, user_id, date_time) 
	values ('FN2', 'Flight Number Two', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_identifier_type_ref (flight_identifier_type_rcd, flight_identifier_type_name, user_id, date_time) 
	values ('FN3', 'Flight Number Three', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_identifier_type_ref (flight_identifier_type_rcd, flight_identifier_type_name, user_id, date_time) 
	values ('MATRI', 'Matriculation', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Airport identifier
insert into airport_identifier_type_ref (airport_identifier_type_rcd, airport_identifier_type_name, user_id, date_time) 
	values ('AC3', 'Airport Code Three', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airport_identifier_type_ref (airport_identifier_type_rcd, airport_identifier_type_name, user_id, date_time) 
	values ('AC4', 'Airport Code Four', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airport_identifier_type_ref (airport_identifier_type_rcd, airport_identifier_type_name, user_id, date_time) 
	values ('FAA', 'Federal Airport Association Code', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airport_identifier_type_ref (airport_identifier_type_rcd, airport_identifier_type_name, user_id, date_time) 
	values ('IATA', 'International Airline Transport Association Code', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into airport_identifier_type_ref (airport_identifier_type_rcd, airport_identifier_type_name, user_id, date_time) 
	values ('ICAO', 'International Civil Aviation Organization', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Date & Times for flight events
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('CRE', 'Created',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('PD', 'Planned Departure',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('PA', 'Planned Arrival',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('ED', 'Estimated Departure',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('EA', 'Estimated Arrival',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('AD', 'Actual Departure',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('AA', 'Actual Arrival',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('CO', 'Check in Open',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('CC', 'Check in Closed',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('CR', 'Check in Reminder',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('LOI', 'Loading Inn',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('LOO', 'Loading Off',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('BO', 'Booking Open',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('BC', 'Booking Closed',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('BOAO', 'Boarding Open',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('BOAC', 'Boarding Closed',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('DP', 'Dispatched',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('TO', 'Takeoff',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('RE', 'Reset',						'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('TD', 'Touchdown',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('FF', 'Flight Flown',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('ADL', 'ADL',						'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('PNL', 'Passenger Name List',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('PFS', 'PFS',						'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('PRL', 'PRL',						'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('CA', 'Canceled',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('LOC', 'Locked',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('AC', 'Activated',					'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('IA', 'Inactivated',				'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into date_time_type_ref (date_time_type_rcd, date_time_type_name, user_id, date_time) 
	values ('APIS', 'Advanced Passenger Information System', 
												'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Booking identifier
insert into booking_identifier_type_ref (booking_identifier_type_rcd, booking_identifier_type_name, user_id, date_time) 
	values ('RL', 'Record Locator', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_identifier_type_ref (booking_identifier_type_rcd, booking_identifier_type_name, user_id, date_time) 
	values ('SL', 'Sender Locator', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_identifier_type_ref (booking_identifier_type_rcd, booking_identifier_type_name, user_id, date_time) 
	values ('BN', 'Booking Number', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_identifier_type_ref (booking_identifier_type_rcd, booking_identifier_type_name, user_id, date_time) 
	values ('TOL', 'Tour Operator Locator', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Booking event
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('CRE', 'Booking Created', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('UPD', 'Booking Updated', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('CA', 'Booking Canceled', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('BR', 'Booking Re-booked', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('BH', 'Booking On Hold', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('BS', 'Booking Split', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('BC', 'Booking Confirmed', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_event_type_ref (booking_event_type_rcd, booking_event_type_name, user_id, date_time) 
	values ('BES', 'Booking Email Sent', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Booking contact method
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('Email', 'eMail', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('PhoneL', 'Phone (local)', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('PhoneI', 'Phone (international)', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('Home', 'Home Phone', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('Business', 'Business Phone', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('Fax', 'Fax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('Mobile', 'Mobile', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('MobileSMS', 'Mobile SMS', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into contact_method_ref (contact_method_rcd, contact_method_name, user_id, date_time) 
	values ('MobileMMS', 'Mobile MMS', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Booking document type
insert into booking_document_type_ref (booking_document_type_rcd, booking_document_type_name, user_id, date_time) 
	values ('TTY', 'Teletype', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_document_type_ref (booking_document_type_rcd, booking_document_type_name, user_id, date_time) 
	values ('ESRD', 'External System Raw Data', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Booking source
insert into booking_source_ref (booking_source_rcd, booking_source_name, user_id, date_time) 
						values ('IS', 'Internal System', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_source_ref (booking_source_rcd, booking_source_name, user_id, date_time) 
						values ('TTY', 'Teletype', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_source_ref (booking_source_rcd, booking_source_name, user_id, date_time) 
						values ('AG', 'Agency', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_source_ref (booking_source_rcd, booking_source_name, user_id, date_time) 
						values ('TO', 'Tour Operator', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- passenger type
insert into passenger_type_ref (passenger_type_rcd, passenger_type_name, user_id, date_time) 
						values ('AD', 'Adult', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into passenger_type_ref (passenger_type_rcd, passenger_type_name, user_id, date_time) 
						values ('CHD', 'Child', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into passenger_type_ref (passenger_type_rcd, passenger_type_name, user_id, date_time) 
						values ('INF', 'Infant', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- flight schedule segment rule
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoMonday', 'Not on Monday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoTuesday', 'Not on Tuesday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoWednesday', 'Not on Wednesday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoThursday', 'Not on Thursday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoFriday', 'Not on Friday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoSaturday', 'Not on Saturday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into flight_schedule_segment_rule_ref (flight_schedule_segment_rule_rcd, flight_schedule_segment_rule_name, user_id, date_time )
										values ('NoSunday', 'Not on Sunday', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft body
insert into aircraft_body_ref (aircraft_body_rcd, aircraft_body_name, sort_order, active_flag, user_id, date_time) 
	values ('NB', 'Narrow Body', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_body_ref (aircraft_body_rcd, aircraft_body_name, sort_order, active_flag, user_id, date_time )
	values ('WB', 'Wide Body', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft configuration
insert into aircraft_configuration_ref (aircraft_configuration_rcd, aircraft_configuration_name, sort_order, active_flag, user_id, date_time )
	values ('CA', 'Cargo Aircraft', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_configuration_ref (aircraft_configuration_rcd, aircraft_configuration_name, sort_order, active_flag, user_id, date_time )
	values ('PA', 'Passenger Aircraft', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_configuration_ref (aircraft_configuration_rcd, aircraft_configuration_name, sort_order, active_flag, user_id, date_time )
	values ('COA', 'Combi Aircraft', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft compartment
insert into aircraft_compartment_type_ref (aircraft_compartment_type_rcd, aircraft_compartment_type_name, sort_order, active_flag, user_id, date_time )
	values ('PZA', 'Passenger Zone A', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_compartment_type_ref (aircraft_compartment_type_rcd, aircraft_compartment_type_name, sort_order, active_flag, user_id, date_time )
	values ('PZB', 'Passenger Zone B', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_compartment_type_ref (aircraft_compartment_type_rcd, aircraft_compartment_type_name, sort_order, active_flag, user_id, date_time )
	values ('PZC', 'Passenger Zone C', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_compartment_type_ref (aircraft_compartment_type_rcd, aircraft_compartment_type_name, sort_order, active_flag, user_id, date_time )
	values ('MCD', 'Main Cargo', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft identifier type
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('IATA', 'International Airline Transport Association Code', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('RG', 'Registration Code', 2, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('ICAO', 'International Civil Aviation Organization Code', 3, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('FAA', 'Federal Airport Association Code', 4, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('DOTEC', 'Department Of Transport Entity Code', 5, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('DOTCC', 'Department Of Transport Certification Code', 6, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_identifier_type_ref (aircraft_identifier_type_rcd, aircraft_identifier_type_name, sort_order, active_flag, user_id, date_time) 
	values ('MSN', 'Manufacturer Serial Number', 7, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft document type
insert into aircraft_document_type_ref (aircraft_document_type_rcd, aircraft_document_type_name, sort_order, active_flag, user_id, date_time) 
	values ('AC', 'Airworthiness Certificate', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- aircraft type
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A318',		'Airbus A318','Produced in European Union, Seat capacity approximately 107', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A319',		'Airbus A319','Produced in European Union, Seat capacity approximately 124', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A320',		'Airbus A320','Produced in European Union, Seat capacity approximately 150', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A321',		'Airbus A321','Produced in European Union, Seat capacity approximately 186', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A310',		'Airbus A310','Produced in European Union, Seat capacity approximately 212', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A340-200',	'Airbus A340-200','Produced in European Union, Seat capacity approximately 303', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A300-600',	'Airbus A300-600','Produced in European Union, Seat capacity approximately 264', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A350-800',	'Airbus A350-800','Produced in European Union, Seat capacity approximately 270', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A330-200',	'Airbus A330-200','Produced in European Union, Seat capacity approximately 293', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A340-300',	'Airbus A340-300','Produced in European Union, Seat capacity approximately 295', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A350-900R',	'Airbus A350-900R','Produced in European Union, Seat capacity approximately 310', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A340-500',	'Airbus A340-500','Produced in European Union, Seat capacity approximately 400', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A350-900',	'Airbus A350-900','Produced in European Union, Seat capacity approximately 314', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A330-300',	'Airbus A330-300','Produced in European Union, Seat capacity approximately 335', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A340-600',	'Airbus A340-600','Produced in European Union, Seat capacity approximately 383', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into aircraft_type_ref (aircraft_type_rcd, aircraft_type_name, description, sort_order, active_flag, user_id, date_time ) 	values ('Airbus A380',		'Airbus A380','Produced in European Union, Seat capacity approximately 853', 1, 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- address type
insert into address_type_ref (address_type_rcd, address_type_name, user_id, date_time )
	values ('Primary', 'Primary', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into address_type_ref (address_type_rcd, address_type_name, user_id, date_time )
	values ('Office', 'Office', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into address_type_ref (address_type_rcd, address_type_name, user_id, date_time )
	values ('Private', 'Private', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial currency
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('USD', 'USD', 'United States Dollar', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('NOK', 'NOK', 'Norwegian Krone', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('SEK', 'SEK', 'Swedish Krona', 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('EUR', 'EUR', 'Euro', 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_currency_type_ref (financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, decimal_count, user_id, date_time )
	values ('THB', 'THB', 'Thai Bath', 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial fee
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Booking', 'Booking Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Ticket', 'Ticket Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Agency', 'Agency Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('SSR', 'Special Service Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_fee_type_ref (financial_fee_type_rcd, financial_fee_type_name, user_id, date_time )
	values ('Payment', 'Payment Fee', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial tax
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Booking', 'Booking Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Ticket', 'Ticket Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Agency', 'Agency Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('SSR', 'Special Service Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_tax_type_ref (financial_tax_type_rcd, financial_tax_type_name, user_id, date_time )
	values ('Payment', 'Payment Tax', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial fare
insert into financial_fare_type_ref (financial_fare_type_rcd, financial_fare_type_name, user_id, date_time )
	values ('STD', 'Standard fare', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial payment
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('STD', 'Standard payment', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('CASH', 'Cash', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('CARD', 'Card', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('COUPON', 'Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('BANK', 'Bank', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('ACC', 'Accounting', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_payment_type_ref (financial_payment_type_rcd, financial_payment_type_name, user_id, date_time )
	values ('VOU', 'Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- default system_setting ref
insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	values ('BCC', 'Booking costcentre', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	values ('BCU', 'Booking currency', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into default_system_setting_ref (default_system_setting_rcd, default_system_setting_name, default_user_id, date_time) 
	values ('EURL', 'eMail URL', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- default system_setting
insert into default_system_setting(default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time )
	values (newid(), dbo.ref('default_system_setting_ref.BCU'), dbo.ref('financial_currency_type_ref.USD'), '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into default_system_setting(default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time )
	values (newid(), dbo.ref('default_system_setting_ref.BCC'), dbo.ref('financial_costcentre_code.IC1'), '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into default_system_setting(default_system_setting_id, default_system_setting_rcd, default_system_setting_value, default_user_id, date_time )
	values (newid(), dbo.ref('default_system_setting_ref.EURL'), 'http://localhost:1301/', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

update default_system_setting 
	set default_system_setting_value = 'https://NorSolutionPort.azurewebsites.net/'
where default_system_setting_rcd = dbo.ref('default_system_setting_ref.EURL')

-- financial adjustment type
insert into financial_adjustment_type_ref (financial_adjustment_type_rcd, financial_adjustment_type_name, user_id, date_time) 
	values ('RR', 'Rounding rule', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial card type
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('Visa', 'Visa', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('Master', 'Master Card', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_card_type_ref (financial_card_type_rcd, financial_card_type_name, user_id, date_time) 
	values ('AmEx', 'American Express', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial bank account number type 
insert into financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd, financial_bank_account_number_type_name, user_id, date_time) 
	values ('SWIFT', 'Society Worldwide Interbank Financial Telecommunication', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_bank_account_number_type_ref(financial_bank_account_number_type_rcd, financial_bank_account_number_type_name, user_id, date_time) 
	values ('IBAN', 'International Bank Account', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial voucher type
insert into financial_voucher_type_ref(financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time) 
	values ('FV', 'Flight Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_voucher_type_ref(financial_voucher_type_rcd, financial_voucher_type_name, user_id, date_time) 
	values ('DV', 'Disruption Voucher', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial coupon type
insert into financial_coupon_type_ref(financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time) 
	values ('MC', 'Meal Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_coupon_type_ref(financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time) 
	values ('LC', 'Lounge Coupon', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial service type
insert into service_type_ref(service_type_rcd, service_type_name, user_id, date_time) 
	values ('SS', 'Special Service', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_type_ref(service_type_rcd, service_type_name, user_id, date_time) 
	values ('HB', 'Hotel Booking', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_type_ref(service_type_rcd, service_type_name, user_id, date_time) 
	values ('CR', 'Car Rental', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_type_ref(service_type_rcd, service_type_name, user_id, date_time) 
	values ('FE', 'Ferry Booking', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- service special service request requirement
insert into service_special_service_request_requirement_ref(service_special_service_request_requirement_rcd, service_special_service_request_requirement_name, user_id, date_time) 
	values ('N', 'None', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request_requirement_ref(service_special_service_request_requirement_rcd, service_special_service_request_requirement_name, user_id, date_time) 
	values ('O', 'Optional', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request_requirement_ref(service_special_service_request_requirement_rcd, service_special_service_request_requirement_name, user_id, date_time) 
	values ('R', 'Required', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- service special service request group
insert into service_special_service_request_group_ref(service_special_service_request_group_rcd, service_special_service_request_group_name, user_id, date_time) 
	values ('None', 'None', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- service special service request operation rule
insert into service_special_service_request_operation_rule_ref(service_special_service_request_operation_rule_rcd, service_special_service_request_operation_rule_name, user_id, date_time) 
	values ('PRO', 'Programmatic', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request_operation_rule_ref(service_special_service_request_operation_rule_rcd, service_special_service_request_operation_rule_name, user_id, date_time) 
	values ('MAN', 'Manual', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- service special service request status
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, user_id, date_time) 
	values ('NN', 'SSR has been requested', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, user_id, date_time) 
	values ('PN', 'SSR is pending confirmation', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, description, user_id, date_time) 
	values ('UN', 'Carrier is unable to fulfill the request', 'The SSR in this case will remain in the PNR as evidence that the service was requested and declined', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, description, user_id, date_time) 
	values ('HK', 'SSR has been confirmed', '', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, description, user_id, date_time) 
	values ('OTHER', 'Other', 'A carrier may send a different status or choose not to reply to an SSR with an HK message, which means that the SSR status will always remain as NN. This status is allowed on some SSRs with the assumption that the supplier has received the message, and that the service will be provided', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_request_status_ref(service_request_status_rcd, service_request_status_name, description, user_id, date_time) 
	values ('REM', 'Removed', 'Service request removed', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- passenger events
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('CIFS', 'Checkin',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('COFS', 'Checkout',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('BOA', 'Boarded',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('OL', 'Offloaded',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('TI', 'Ticketed',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into booking_passenger_event_type_ref (booking_passenger_event_type_rcd, booking_passenger_event_type_name, user_id, date_time) 
	values ('UTI', 'Un-Ticketed',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- client event
insert into client_event_type_ref (client_event_type_rcd, client_event_type_name, user_id, date_time) 
	values ('SIM', 'Sent Introduction Mail', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into client_event_type_ref (client_event_type_rcd, client_event_type_name, user_id, date_time) 
	values ('IMC', 'Introduction Mail Confirmed', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into client_event_type_ref (client_event_type_rcd, client_event_type_name, user_id, date_time) 
	values ('PMS', 'Package Mail Sent', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into client_event_type_ref (client_event_type_rcd, client_event_type_name, user_id, date_time) 
	values ('PSV', 'Package Site Viewed', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into client_event_type_ref (client_event_type_rcd, client_event_type_name, user_id, date_time) 
	values ('PO', 'Package Ordered', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- nationality
insert into nationality_ref (nationality_rcd, nationality_name, user_id, date_time) 
	values ('MA', 'Mars', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into nationality_ref (nationality_rcd, nationality_name, user_id, date_time) 
	values ('JU', 'Jupiter', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
	
-- gender
insert into gender_ref (gender_rcd, gender_name, user_id, date_time) 
	values ('M', 'Male', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into gender_ref (gender_rcd, gender_name, user_id, date_time) 
	values ('F', 'Female', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
	
-- title
insert into title_ref (title_rcd, title_name, user_id, date_time) 
	values ('MR', 'Mr.', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into title_ref (title_rcd, title_name, user_id, date_time) 
	values ('MS', 'Ms.', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
	
-- client type
insert into client_type_ref (client_type_rcd, client_type_name, user_id, date_time) 
	values ('P', 'Private', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into client_type_ref (client_type_rcd, client_type_name, user_id, date_time) 
	values ('B', 'Business', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- reporting roundup
insert into reporting_roundup_type_ref (reporting_roundup_type_rcd, reporting_roundup_type_name, user_id, date_time) 
	values ('Bookings', 'Bookings per day',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into reporting_roundup_type_ref (reporting_roundup_type_rcd, reporting_roundup_type_name, user_id, date_time) 
	values ('BP', 'Bookings Passenger',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial booking transaction type
insert into financial_booking_transaction_type_ref (financial_booking_transaction_type_rcd, financial_booking_transaction_type_name, user_id, date_time) 
	values ('ADD', 'Added',			'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into financial_booking_transaction_type_ref (financial_booking_transaction_type_rcd, financial_booking_transaction_type_name, user_id, date_time) 
	values ('REMOVE', 'Removed',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- Airport type
insert into airport_type_ref (airport_type_rcd, airport_type_name, user_id, date_time) 
 	values ('CA', 'Civil Airport',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- airline type
insert into airline_type_ref (airline_type_rcd, airline_type_name, user_id, date_time) 
	values ('SC', 'Scheduled Carrier', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- link type
insert into link_type_ref (link_type_rcd, link_type_name, user_id, date_time) 
	values ('WS', 'Web Site',		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into link_type_ref (link_type_rcd, link_type_name, user_id, date_time) 
	values ('SM', 'Social Media',	'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- image type
insert into service_image_type_ref (service_image_type_rcd, service_image_type_name, user_id, date_time) 
	values ('PI', 'Product image variable size', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_image_type_ref (service_image_type_rcd, service_image_type_name, user_id, date_time) 
	values ('ISP', 'Internal Stock Photo', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- language
insert into language_ref (language_rcd, language_name, user_id, date_time) 
	values ('en-US', 'English', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into language_ref (language_rcd, language_name, user_id, date_time) 
	values ('nb-NO', 'Norsk Bokmål', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into language_ref (language_rcd, language_name, user_id, date_time) 
	values ('th-TH', '???????', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- ferry type
insert into ferry_type_ref (ferry_type_rcd, ferry_type_name, state_rcd, user_id, date_time) 
	values ('SF', 'Car Ferry', 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into ferry_type_ref (ferry_type_rcd, ferry_type_name, state_rcd, user_id, date_time) 
	values ('LO', 'Lorry', 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortProcedures",
                Description = "Port Procedures",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
if object_id (N'dbo.add_airport') is not null
	drop procedure add_airport
go
create procedure add_airport (	@country_name nvarchar(240),
								@city_name nvarchar(240),
								@airport_name nvarchar(240),
								@iata_code nvarchar(240),
								@icao_code nvarchar(240),
								@user_id uniqueidentifier, 
								@airport_id uniqueidentifier out
								) as begin

	declare @country_id uniqueidentifier set @country_id = newid()
	insert into country (country_id, country_code, country_name, user_id, date_time) 
		values (@country_id, @country_name, @country_name, @user_id, getutcdate());

	declare @city_id uniqueidentifier set @city_id = newid()
	insert into city (city_id, country_id, city_code, city_name, user_id, date_time) 
		values (@city_id, @country_id, @city_name, @city_name, @user_id, getutcdate());

	set @airport_id = newid()
	insert into airport (airport_id, city_id, airport_name, user_id, date_time) 
		values (@airport_id, @city_id, @airport_name, @user_id, getutcdate());

	insert into airport_identifier (airport_identifier_id, airport_id, airport_identifier_type_rcd, airport_identifier_code, user_id, date_time) 
		values (newid(), @airport_id, dbo.ref('airport_identifier_type_ref.AC3'), @icao_code, @user_id, getutcdate());

	insert into airport_identifier (airport_identifier_id, airport_id, airport_identifier_type_rcd, airport_identifier_code, user_id, date_time) 
		values (newid(), @airport_id, dbo.ref('airport_identifier_type_ref.IATA'), @iata_code, @user_id, getutcdate());

	insert into airport_identifier (airport_identifier_id, airport_id, airport_identifier_type_rcd, airport_identifier_code, user_id, date_time) 
		values (newid(), @airport_id, dbo.ref('airport_identifier_type_ref.ICAO'), @icao_code, @user_id, getutcdate());

end
go
if object_id (N'dbo.add_airline') is not null
	drop procedure add_airline
go
create procedure add_airline (	@airline_code_short nvarchar(2),
								@airline_code_long nvarchar(3),
								@airline_name nvarchar(240),
								@user_id uniqueidentifier,
								@airline_id uniqueidentifier out
								) as begin

	set @airline_id = newid()
	insert into airline (airline_id, airline_name, airline_type_rcd, user_id, date_time) 
		values (@airline_id, @airline_name, dbo.ref('airline_type_ref.SC'), @user_id, getutcdate());

	insert into airline_identifier (airline_identifier_id, airline_id, airline_identifier_type_rcd, airline_identifier_code, user_id, date_time) 
		values (newid(), @airline_id, 'AC2', @airline_code_short, @user_id, getutcdate());

	insert into airline_identifier (airline_identifier_id, airline_id, airline_identifier_type_rcd, airline_identifier_code, user_id, date_time) 
		values (newid(), @airline_id, 'AC3', @airline_code_long, @user_id, getutcdate());

end
go
if object_id (N'dbo.add_flight') is not null
	drop procedure add_flight
go
create procedure add_flight	(	@airline_id uniqueidentifier,
								@departure_airport_id uniqueidentifier,
								@arrival_airport_id uniqueidentifier,
								@from_date_time datetime,
								@until_date_time datetime,
								@user_id uniqueidentifier
								) as begin

	declare @flight_id uniqueidentifier set @flight_id = newid()
	declare @aircraft_id uniqueidentifier set @aircraft_id = (select top 1 aircraft_id from aircraft)
	insert into flight (flight_id,  binding_flight_id, airline_id, aircraft_id, aircraft_type_rcd,			   departure_airport_id, arrival_airport_id, from_date_time, until_date_time, comment,	    date_time,     user_id)
			   values (@flight_id, @flight_id,		  @airline_id,@aircraft_id, dbo.ref('Bombardier CRJ-100'), @departure_airport_id,@arrival_airport_id,@from_date_time,@until_date_time, 'no comment', getutcdate(), @user_id);

	declare @flight_number nvarchar(4)
	set @flight_number = substring(replace(convert(nvarchar(30), rand() * 1000), '.', ''), 0, 4)

	insert into flight_identifier(flight_identifier_id, flight_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
						  values (	newid(),			   
									@flight_id, 
									'FN3',						
									@flight_number,
									getutcdate(), 
									@user_id);

	insert into flight_identifier(flight_identifier_id, flight_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
						  values (	newid(),			   
									@flight_id, 
									'MATRI',						
									'XHUAGI',
									getutcdate(), 
									@user_id);
	
	insert into flight_segment(	flight_segment_id, flight_id, from_date_time, until_date_time, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number, date_time, user_id)
						values(	newid(),		  @flight_id,@from_date_time,@until_date_time,@departure_airport_id,@arrival_airport_id, 1,						 1,						getutcdate(),@user_id)

	-- flight created
	insert into flight_event(flight_event_id, flight_id, date_time_type_rcd, new_date_time, date_time, user_id)
					 values (newid(),		 @flight_id, 'CRE',				getutcdate(),	getutcdate(), @user_id)

	-- flight plan to depart
	insert into flight_event(flight_event_id, flight_id, date_time_type_rcd, new_date_time, date_time, user_id)
					 values (newid(),		 @flight_id, 'PD',				@from_date_time,getutcdate(), @user_id)

	-- flight plan to arrive
	insert into flight_event(flight_event_id, flight_id, date_time_type_rcd, new_date_time, date_time, user_id)
					 values (newid(),		 @flight_id, 'PA',				@until_date_time, getutcdate(), @user_id)

	-- flight is open for bookings
	insert into flight_event(flight_event_id, flight_id, date_time_type_rcd, new_date_time, date_time, user_id)
					 values (newid(),		 @flight_id, 'OB',				getutcdate(),	getutcdate(), @user_id)
end
go
if object_id (N'dbo.FlightEventOneIsLast', N'FN') is not null
    drop function dbo.FlightEventOneIsLast;
go
create function dbo.FlightEventOneIsLast (
	@flight_id uniqueidentifier,
	@first_date_time_type varchar(240),
	@second_date_time_type varchar(240)
	)
returns bit
with execute as caller
as
begin
	declare @first_event_number int = 0
	declare @second_event_number int = 0

	set @first_event_number = (
        select
			coalesce(max(fe.flight_event_number), 0)
        from  flight_event as fe
        where fe.flight_id = @flight_id
			and fe.date_time_type_rcd = @first_date_time_type
		)

	set @second_event_number = (
        select
			coalesce(max(fe.flight_event_number), 0)
        from  flight_event as fe
        where fe.flight_id = @flight_id
			and fe.date_time_type_rcd = @second_date_time_type
		)

	return case when @first_event_number <= @second_event_number then cast(0 as bit) else cast(1 as bit) end
end
go
if object_id (N'dbo.BookingPassengerEventOneIsLast', N'FN') is not null
    drop function dbo.BookingPassengerEventOneIsLast;
go
create function dbo.BookingPassengerEventOneIsLast (
	@booking_passenger_id uniqueidentifier,
	@first_booking_passenger_event_type_rcd nvarchar(240),
	@second_booking_passenger_event_type_rcd varchar(240)
	)
returns bit
with execute as caller
as
begin
	declare @first_booking_passenger_event_number int = 0
	declare @second_booking_passenger_event_number int = 0

	set @first_booking_passenger_event_number = (
        select
			coalesce(max(bpe.booking_passenger_event_number ), 0)
        from  booking_passenger_event as bpe
        where bpe.booking_passenger_id = @booking_passenger_id
			and bpe.booking_passenger_event_type_rcd = @first_booking_passenger_event_type_rcd
		)

	set @second_booking_passenger_event_number = (
        select
			coalesce(max(bpe.booking_passenger_event_number ), 0)
        from  booking_passenger_event as bpe
        where bpe.booking_passenger_id = @booking_passenger_id
			and bpe.booking_passenger_event_type_rcd = @second_booking_passenger_event_type_rcd
		)

	return case when @first_booking_passenger_event_number <= @second_booking_passenger_event_number then cast(0 as bit) else cast(1 as bit) end
end
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortTestData",
                Description = "Port Test Data",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch {
                    Script = @"
set quoted_identifier on
go
-- airports
declare @airport_norway_id uniqueidentifier 
exec add_airport 'Norway', 'Oslo', 'Gardermoen', 'OSL', 'ENGM', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airport_norway_id out
declare @airport_thailand_id uniqueidentifier 
exec add_airport 'Thailand', 'Suvarnabhumi', 'Suvarnabhumi International', 'BKK', 'VTBS', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airport_thailand_id out
declare @airport_cnx_id uniqueidentifier 
exec add_airport 'Thailand', 'Chiang Mai ', 'Chiang Mai International', 'CNX', 'VTCC', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airport_cnx_id out
declare @airport_sweden_id uniqueidentifier 
exec add_airport 'Sweden', 'Arlanda', 'Arlanda', 'ARN', 'ESSA', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airport_sweden_id out
declare @airport_usa_id uniqueidentifier 
exec add_airport 'MIA', 'Miami', 'Miami International', 'MIA', 'KMIA', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airport_usa_id out

-- airlines
declare @airline_sa_id uniqueidentifier 
exec add_airline 'SA', 'SAS', 'SAS Scandinavian Airlines', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airline_sa_id out 
declare @airline_nk_id uniqueidentifier 
exec add_airline 'NK', 'NKS', 'Spirit Airlines', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airline_nk_id out 
declare @airline_dd_id uniqueidentifier 
exec add_airline 'LX', 'SWR', 'Swiss', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', @airline_dd_id out 

-- country
declare @countryUS uniqueidentifier
set @countryUS = newid()
insert into country (country_id, country_code, country_name, user_id, date_time) 
	values ( @countryUS ,'US','United States', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate())

-- aircraft
declare @sol_aircraft_id uniqueidentifier set @sol_aircraft_id = newid();
insert into aircraft (aircraft_id, product_id, aircraft_name, aircraft_body_rcd, aircraft_type_rcd, aircraft_configuration_rcd, user_id, date_time) 
			 values (@sol_aircraft_id, null, 'Sol', 'NB', 'Airbus A310', 'PA', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
declare @froidis_aircraft_id uniqueidentifier set @froidis_aircraft_id = newid();
insert into aircraft (aircraft_id, product_id, aircraft_name, aircraft_body_rcd, aircraft_type_rcd, aircraft_configuration_rcd, user_id, date_time) 
			 values (@froidis_aircraft_id, null, 'Frøydis', 'WB', 'Airbus A350-800', 'COA', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
declare @tor_aircraft_id uniqueidentifier set @tor_aircraft_id = newid();
insert into aircraft (aircraft_id, product_id, aircraft_name, aircraft_body_rcd, aircraft_type_rcd, aircraft_configuration_rcd, user_id, date_time) 
			 values (@tor_aircraft_id, null, 'Tor', 'WB', 'Airbus A380', 'CA', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial currency
-- SEK
declare @financial_currency_swe_id uniqueidentifier set @financial_currency_swe_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_swe_id, dbo.ref('financial_currency_type_ref.SEK'), dbo.ref('financial_currency_type_ref.SEK'), 'Swedish Krona',  
			1, dbo.ref('financial_currency_type_ref.SEK'), 1, getutcdate(), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- EUR
declare @financial_currency_eur_id uniqueidentifier set @financial_currency_eur_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_eur_id, dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro',  
			1, dbo.ref('financial_currency_type_ref.EUR'), 1, getutcdate(), 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro', 
			1, dbo.ref('financial_currency_type_ref.USD'), 7, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- THB
declare @financial_currency_thb_id uniqueidentifier set @financial_currency_thb_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_thb_id, dbo.ref('financial_currency_type_ref.THB'), dbo.ref('financial_currency_type_ref.THB'), 'Thai Bath',  
			1, dbo.ref('financial_currency_type_ref.THB'), 1, getutcdate(), 4, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.EUR'), dbo.ref('financial_currency_type_ref.EUR'), 'Euro', 
			1, dbo.ref('financial_currency_type_ref.USD'), 40, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- USD
declare @financial_currency_usd_id uniqueidentifier set @financial_currency_usd_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_usd_id, dbo.ref('financial_currency_type_ref.USD'), dbo.ref('financial_currency_type_ref.USD'), 'United States Dollar',  
			1, dbo.ref('financial_currency_type_ref.USD'), 1, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against NOK
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.USD'), dbo.ref('financial_currency_type_ref.USD'), 'United States Dollar', 
			1, dbo.ref('financial_currency_type_ref.NOK'), 7, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- NOK
declare @financial_currency_nok_id uniqueidentifier set @financial_currency_nok_id = newid()
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (@financial_currency_nok_id, dbo.ref('financial_currency_type_ref.NOK'), dbo.ref('financial_currency_type_ref.NOK'), 'Norwegian Krone', 
			1, dbo.ref('financial_currency_type_ref.NOK'), 1, getutcdate(), 1, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
-- against USD
insert into financial_currency(financial_currency_id, financial_currency_type_rcd, financial_currency_type_code, financial_currency_type_name, amount, financial_currency_against_financial_currency_type_rcd, equals_amount, valid_from_date_time, decimal_count, user_id, date_time )
	values (newid(), dbo.ref('financial_currency_type_ref.NOK'), dbo.ref('financial_currency_type_ref.NOK'), 'Norwegian Krone', 
			7, dbo.ref('financial_currency_type_ref.USD'), 1, getutcdate(), 2, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- financial fee
insert into financial_fee (financial_fee_id, financial_fee_type_rcd, amount, financial_currency_id, user_id, date_time )
	values (newid(), dbo.ref('financial_fee_type_ref.Booking'), 5, @financial_currency_usd_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- company
declare @financial_company_id uniqueidentifier set @financial_company_id = newid()
insert into financial_company(financial_company_id, financial_company_name, user_id, date_time )
	values (@financial_company_id, 'Internal Financial Company', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- costcentre
insert into financial_costcentre(financial_costcentre_id, financial_costcentre_code, financial_costcentre_name, financial_company_id, user_id, date_time )
	values (newid(), 'IC1', 'Internal Cost Centre 1', @financial_company_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

-- service special service request
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'BLND', 'Traveler is blind', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'DOCS', 'Passport/travel document information. Includes APIS data', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'DOCA', 'APIS passenger residence address information', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'DOCO', 'APIS secondary document information', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'CKIN', 'Associated with an activity related to passenger check-in, such as a request for residency data', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'DEAF', 'Traveler is deaf', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'WCHC', 'Wheelchair is needed -- traveler is completely immobile', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'WCHR', 'Wheelchair is needed -- traveler can ascend/descend stairs', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'TKNM', 'Manually entered ticket number for carrier notification', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'INFT', 'Infant traveling in lap', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'CHLD', 'Child traveling', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'FQTU', 'Frequent traveler with upgrade and mileage accrual', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'FOID', 'Form of ID. Universal API supports all forms of ID, except Credit Card', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into service_special_service_request(service_special_service_request_id, service_special_service_request_group_rcd, service_special_service_request_code, service_special_service_request_name, service_special_service_request_operation_rule_rcd, request_service_special_service_request_requirement_rcd, reply_service_special_service_request_requirement_rcd, inventory_controlled_flag, user_id, date_time)
	values (newid(), dbo.ref('service_special_service_request_group_ref.None'), 'TWOV', 'Transit without visa', 
	dbo.ref('service_special_service_request_operation_rule_ref.PRO'), dbo.ref('request_service_special_service_request_requirement_ref.O'), dbo.ref('reply_service_special_service_request_requirement_rcd.R'), 0, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());


-- timezones ( https://en.wikipedia.org/wiki/List_of_time_zone_abbreviations )
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ACDT) Australian Central Daylight Savings Time', 'UTC+10:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ACST) Australian Central Standard Time', 'UTC+09:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ACT) Acre Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ACT) ASEAN Common Time', 'UTC+06:30 – UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ACWST) Australian Central Western Standard Time (unofficial)', 'UTC+08:45', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ADT) Atlantic Daylight Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AEDT) Australian Eastern Daylight Savings Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AEST) Australian Eastern Standard Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AFT) Afghanistan Time', 'UTC+04:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AKDT) Alaska Daylight Time', 'UTC-08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AKST) Alaska Standard Time', 'UTC-09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AMST) Amazon Summer Time (Brazil)[1]', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AMT) Amazon Time (Brazil)[2]', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AMT) Armenia Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ART) Argentina Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AST) Arabia Standard Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AST) Atlantic Standard Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AWST) Australian Western Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AZOST) Azores Summer Time', 'UTC±00', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AZOT) Azores Standard Time', 'UTC-01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(AZT) Azerbaijan Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BDT) Brunei Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BIOT) British Indian Ocean Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BIT) Baker Island Time', 'UTC-12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BOT) Bolivia Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BRST) Brasília Summer Time', 'UTC-02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BRT) Brasilia Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BST) Bangladesh Standard Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BST) Bougainville Standard Time[3]', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BST) British Summer Time (British Standard Time from Feb 1968 to Oct 1971)', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(BTT) Bhutan Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CAT) Central Africa Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CCT) Cocos Islands Time', 'UTC+06:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CDT) Central Daylight Time (North America)', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CDT) Cuba Daylight Time[4]', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CEST) Central European Summer Time (Cf. HAEC)', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CET) Central European Time', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHADT) Chatham Daylight Time', 'UTC+13:45', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHAST) Chatham Standard Time', 'UTC+12:45', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHOT) Choibalsan Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHOST) Choibalsan Summer Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHST) Chamorro Standard Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CHUT) Chuuk Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CIST) Clipperton Island Standard Time', 'UTC-08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CIT) Central Indonesia Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CKT) Cook Island Time', 'UTC-10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CLST) Chile Summer Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CLT) Chile Standard Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(COST) Colombia Summer Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(COT) Colombia Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CST) Central Standard Time (North America)', 'UTC-06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CST) China Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CST) Cuba Standard Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CT) China Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CVT) Cape Verde Time', 'UTC-01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CWST) Central Western Standard Time (Australia) unofficial', 'UTC+08:45', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(CXT) Christmas Island Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(DAVT) Davis Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(DDUT) Dumont dUrville Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(DFT) AIX-specific equivalent of Central European Time[NB 1]', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EASST) Easter Island Summer Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EAST) Easter Island Standard Time', 'UTC-06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EAT) East Africa Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ECT) Eastern Caribbean Time (does not recognise DST)', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ECT) Ecuador Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EDT) Eastern Daylight Time (North America)', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EEST) Eastern European Summer Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EET) Eastern European Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EGST) Eastern Greenland Summer Time', 'UTC±00', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EGT) Eastern Greenland Time', 'UTC-01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EIT) Eastern Indonesian Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(EST) Eastern Standard Time (North America)', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(FET) Further-eastern European Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(FJT) Fiji Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(FKST) Falkland Islands Summer Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(FKT) Falkland Islands Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(FNT) Fernando de Noronha Time', 'UTC-02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GALT) Galápagos Time', 'UTC-06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GAMT) Gambier Islands Time', 'UTC-09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GET) Georgia Standard Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GFT) French Guiana Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GILT) Gilbert Island Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GIT) Gambier Island Time', 'UTC-09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GMT) Greenwich Mean Time', 'UTC±00', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GST) South Georgia and the South Sandwich Islands Time', 'UTC-02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GST) Gulf Standard Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(GYT) Guyana Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HDT) Hawaii–Aleutian Daylight Time', 'UTC-09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HAEC) Heure Avancée dEurope Centrale French-language name for CEST', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HST) Hawaii–Aleutian Standard Time', 'UTC-10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HKT) Hong Kong Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HMT) Heard and McDonald Islands Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HOVST) Khovd Summer Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(HOVT) Khovd Standard Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ICT) Indochina Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IDLW) International Day Line West time zone', 'UTC-12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IDT) Israel Daylight Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IOT) Indian Ocean Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IRDT) Iran Daylight Time', 'UTC+04:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IRKT) Irkutsk Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IRST) Iran Standard Time', 'UTC+03:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IST) Indian Standard Time', 'UTC+05:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IST) Irish Standard Time[5]', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(IST) Israel Standard Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(JST) Japan Standard Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(KALT) Kaliningrad Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(KGT) Kyrgyzstan Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(KOST) Kosrae Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(KRAT) Krasnoyarsk Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(KST) Korea Standard Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(LHST) Lord Howe Standard Time', 'UTC+10:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(LHST) Lord Howe Summer Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(LINT) Line Islands Time', 'UTC+14', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MAGT) Magadan Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MART) Marquesas Islands Time', 'UTC-09:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MAWT) Mawson Station Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MDT) Mountain Daylight Time (North America)', 'UTC-06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MET) Middle European Time Same zone as CET', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MEST) Middle European Summer Time Same zone as CEST', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MHT) Marshall Islands Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MIST) Macquarie Island Station Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MIT) Marquesas Islands Time', 'UTC-09:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MMT) Myanmar Standard Time', 'UTC+06:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MSK) Moscow Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MST) Malaysia Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MST) Mountain Standard Time (North America)', 'UTC-07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MUT) Mauritius Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MVT) Maldives Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(MYT) Malaysia Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NCT) New Caledonia Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NDT) Newfoundland Daylight Time', 'UTC-02:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NFT) Norfolk Island Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NPT) Nepal Time', 'UTC+05:45', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NST) Newfoundland Standard Time', 'UTC-03:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NT) Newfoundland Time', 'UTC-03:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NUT) Niue Time', 'UTC-11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NZDT) New Zealand Daylight Time', 'UTC+13', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(NZST) New Zealand Standard Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(OMST) Omsk Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ORAT) Oral Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PDT) Pacific Daylight Time (North America)', 'UTC-07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PET) Peru Time', 'UTC-05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PETT) Kamchatka Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PGT) Papua New Guinea Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PHOT) Phoenix Island Time', 'UTC+13', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PHT) Philippine Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PKT) Pakistan Standard Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PMDT) Saint Pierre and Miquelon Daylight Time', 'UTC-02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PMST) Saint Pierre and Miquelon Standard Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PONT) Pohnpei Standard Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PST) Pacific Standard Time (North America)', 'UTC-08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PST) Philippine Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PYST) Paraguay Summer Time[6]', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(PYT) Paraguay Time[7]', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(RET) Réunion Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ROTT) Rothera Research Station Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SAKT) Sakhalin Island Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SAMT) Samara Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SAST) South African Standard Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SBT) Solomon Islands Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SCT) Seychelles Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SDT) Samoa Daylight Time', 'UTC-10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SGT) Singapore Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SLST) Sri Lanka Standard Time', 'UTC+05:30', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SRET) Srednekolymsk Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SRT) Suriname Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SST) Samoa Standard Time', 'UTC-11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SST) Singapore Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(SYOT) Showa Station Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TAHT) Tahiti Time', 'UTC-10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(THA) Thailand Standard Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TFT) French Southern and Antarctic Time[8]', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TJT) Tajikistan Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TKT) Tokelau Time', 'UTC+13', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TLT) Timor Leste Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TMT) Turkmenistan Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TRT) Turkey Time', 'UTC+03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TOT) Tonga Time', 'UTC+13', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(TVT) Tuvalu Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ULAST) Ulaanbaatar Summer Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(ULAT) Ulaanbaatar Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(UTC) Coordinated Universal Time', 'UTC±00', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(UYST) Uruguay Summer Time', 'UTC-02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(UYT) Uruguay Standard Time', 'UTC-03', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(UZT) Uzbekistan Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(VET) Venezuelan Standard Time', 'UTC-04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(VLAT) Vladivostok Time', 'UTC+10', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(VOLT) Volgograd Time', 'UTC+04', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(VOST) Vostok Station Time', 'UTC+06', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(VUT) Vanuatu Time', 'UTC+11', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WAKT) Wake Island Time', 'UTC+12', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WAST) West Africa Summer Time', 'UTC+02', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WAT) West Africa Time', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WEST) Western European Summer Time', 'UTC+01', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WET) Western European Time', 'UTC±00', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WIT) Western Indonesian Time', 'UTC+07', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(WST) Western Standard Time', 'UTC+08', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(YAKT) Yakutsk Time', 'UTC+09', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
insert into timezone ( timezone_id, timezone_name, utc_offset, user_id, date_time ) values (newid(), '(YEKT) Yekaterinburg Time', 'UTC+05', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

insert into product ( product_id, product_name, state_rcd, user_id, date_time) values (newid(), ' ', 'A', '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
go

                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript
            {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortTestDataAircraft",
                Description = "Port Test Data Aircraft",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch
                {
                    Script = @"
set quoted_identifier on
go
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E4000000580806000000E55F5B83000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF00004E5449444154785EED5D05781547DBA5EEF2D51D779762055A0A850285E2EE56DCDDDD25C420448827C408091A08AE41434820244890B8BB72FEF7CCCDC225DCCA27FD6B370F87D99D9DB599F7BC32B2B714807F0C0A0AF2909B97299B868F1B614449141616223F3F1F0505050AB9B9B9C8CBCB53282CCC475151011E3E2C94A2058F90939325C77364BB48CA674BAABB564A4A8A3A5FDB370483997F37B0E2545A948BFC82C715648411BF0524A5B64D729284241B89A891F121F241F92A7A98878C8C34454A96D7276456569622756151968296AF8FA732FE0ED0AF400DAC30ADD24A1E33C288DF0A5A467A5A24A4A6E849C2BCFC2C6466A58A079681ECEC5FF4C2505094FECF226449B0C2342DA6DB365CCE082334E82B756D9B644C4E4E2E76438B549E0E054AAEB273D224CD2D26EAE3E3B48CD9D98F2DA522E4C38C47FBFA782AE3EF0A5612DDD59CDC74D9355CC6082388A2C227BDA802650875DB54EACA5D55A9902D3B55129DF7450BC96394B38CCC64F0586656922AF7187475494EC698FAF93A3C95F177862E8634EC2A18F1C74113EE3F0B4A12B29021A3DE3E2D25FF5253938578292828CC5124A4DB4A77F6A11C23741D3B8FCF8B8979A0F68B7EC65D250C66FE5DA0B91A4C5951AC34FAF8DA7123FE1C78080A31A1B334258FFF7FA388BDA782C27CB176B9EC5DD5774F512A272B1B4505A49CEE2F27479E5D7699932FE49553C0C3143FE615AAD31F9F5F50F0F3326830F3EF0A5AC8C222C3AE82117F1C1E2AF78D44D460B8DCFF378A0A0A8594CA3C3E915F909F8D874512370AE1D8997A35240A5E9E8158B7DE013B7C4FC2C9E5204C4CDDE0EC16006B5B2F985938607FC0E147D7F9252FCD60E6DF150CBC197497CC37E28F0509490BC9B6F933B40F495890978F9CEC4C64676528D79360C74C4E4E8E785969CAE3A205DCBFF702DE7DA79E30A93CBE6F371D75EB0DC6AB6FD6C53B1F34C13BEF37C4B3CF95C68B2F7F2EC75F13D756AE6EE07EFA3098F95787D61D5D324F374E6424E49F0D7F369755032D616101AD37AD64811090E38E0F5104B19C9273F2D40D346B36182FBCD008AD5ACFC7A0C1F668D37E0D9A7D3B050D9B8E46FD86C350B56637D4AADD112FBFF2A93AA7D8D135783FC260E6DF1B7F9E063742873F1309F595B98E90EC11D50D97B133A748E2C11CE1E7B1131168D26C103EF9EC4794AF3C1CB51BCCC2B4B947D1E49B5568D97631BE6E3D0F15AB0C42C3C6A3D0A2E5703CFBFCC78A90BCEE2FC160E6DF15BA863712D2889F87F2A4F2759D38F979EC35CD10ABA6EB45E578627E7E2142C3B33178D80A71451BA35AADB168D16A251A365F8E09330EA142ADE9A8D37806BE6AB9101F7CDA034D9B4F41D5EA5D85909F224744EFD7486930D30823FE3FF167B2901A7233D9F1C201FF6CE41566213D3B0B997945C896476DFA4D4FBCF7592B7CDD6E05DEFA74049AB435C1FC75C1285F6F266A7FB554DCD43168D576193E2F3F002DBE9B8D522FD54085AACD1FC590B4B24C0DC160A61146FC7FE28F26A46E584C37799CD0F239AE5828AE6ABE1033295DACA30480891945A851B70F9E79F96B54AB370715EB2C44BF71BB3066DE41BCFE596F74E8638986CD66A179AB85A85A6F34AA36188A17DEA88BA973D6195D5623FE1AF8B359C87CBD01FDBCA287884B4EC7F5DB31B8179783AB1109B0B2BF8697DEEA8C373F1C8AC51B22316AF661BC5F65182A341E8FEE23AC50BBD174346A390FB59B4C40E9EA3DF071B9AF119352085E2B27FF97C7C10D661A61C43F118C1F7513C71FE7C52565E34E7426C2EF64E042683CEE25006EFEF7D07BC4567CDFD30CF3D69E47CBCE9BF066D9FE68DBD71C2DBAAE44A57A1350B6D60854A83318AFBCDB4808DA09BAB93D4FDECF100C661A61C43F0D1A1939DE5820CE65767E11E293F3109F02F41E30075F7E3500A13781B3C159B8FA00387FB3004B36ED4395863FE1DD7203D0B4DD1A7CDFD706355A2C42AD66B351EBAB29A8527F305E7DB70EFCF69D41AEC48DD9B919C8CE4B35AEF630C2889250BDA97A431CFAF9D985B9884DC9C2F9E0FB70F7BE80CE3D16E2DBEF67C1C53B12B7E3813B9940E0A5180C1CBF069F56E98AD25587A349AB35F8B6D316D4FD7A154AD71C872FBF9981F73E6F83FA8D3A2343B8979B4F1BC9FB650B215324364D93ED27EF4D3C956184117F773066E5B8A26E2AA56E51315376E264E7A4233A2519099945424CE0F4F96C4C9EE18D763FAE4697BE6630B50D818D6718969B05E087DE0BF075DB19E833C8161DBBDBA066A385F8A2FA6494A9351E4D5BCD41A9E7AA62EEBC4D505C7C58808CD43814E4A620BF28D1484823FE99600FAAB6C84083464842D7A1A49B89C37DAEDC08B919892B371EE04E0C7022281FAB3604A1630F4BFCEBD33E285B7D14AA379C856F7F5889E163B761E9AA23D8607A057D07BAA17495F1E2A64E458D46B351AEFA50BCFE7643840447EB061F1FCA7D0AD225CD1242C62B2BC9672989A7328C30E26F038E53C8BFDCEC273B6A8842B15824636E41A6F0A540C58CE9E28A66E502CB5679A257FF2558B9E12036589CC3ECA587D0B6E726BC5761304ABDD3112F7ED41ED59A8DC38C557BB07AEB658C9B7B109DFA3BA17AD38518316D377A0DB1C1FB653AA143D7098AEAB9F93978480B9CFBEBDF7332986984117F69E846E0D56A0D12B220EF490BA9E247BAAAC5F367738B7290954772026327CEC1CB6F3412665417377415966F380933FB502CB33C853E13B7A079B759F8B4E6007C56B30FBEEDB6105D8658A076F37968DA763D464DDF8F89F303F0559B7978F6B586D8B26D3F72E5D60949F16A0A5E015DE22CE3B08711FF303C54419B6E5D636181B8A1F9BA0505FC4015576B28F7516C574E6E861AF8A7054BCBCA5653DBA6CD5E8806CD47E1D5F75BA14EB3491832C109ABAD82B0E77C1A0E87A7E3E0B5586CF38DC0D8F92E68D67116DE29D7032FBDD319EF7C3E088DBE5D8226DF2DC41BEFB7C627E5DAE26E0CA7A1F38F5373F22596CC44C9C5CF256130D30823FECA28CA332CF4B4865ACCC8F58C2428575F64E6142AEB480F373E3907EE7BC3307CCA667CD56E065A775F891133DD60E91502DFA07BB89850800BB781D5D647D1BECF12546F3206DD066CC58889DE183AD6155F7E3D05A52BB4C7C2658EA0A79C929AA9E6C1D242EA96983DED3EEBC360A61146FC55A13A717245F0C505A585D4F2D95943A8359762A50A0B1FAA55FED1B159D8EE7518874F5C43423A902A063441F2C3620013C733E83BCE063F0CD884AE23B7A0EDC055E835D1023F0E5E8B76BD17A3EB907598B72A001EFEC930B1BC82B1535C51BBE150D46BD80551F7E41E729DE4E4544546CE89E5BD6991B567320483994618F15705E3C6DC0C8909699984985C684CB735273B5D7D243B2B3B4D2D344E4CCC54A1A69F7F302A57EF8497DEA88B8E3D66C3CEED0C7C8FDDC0C9B04C6CDB790D3356EC45E7219B51A1C1443CF74167FCABC240947AB339DE29F323DAF75C81FE236CD07BE056B46EB7181F7FDE1ECFBC541503874C411E7B738490A929FCC81563D62CB196F1C82F7AFCF5394330986984117F45908C44765A2E3253B24003A99652150933D4078D8B909E91AC5C530ED6AF5DE78EAF5A8CC62765BAE383CFBBE1D38ABDF1DA876D51A7C544F41EB91983C6D963D82417F41D6D8F969D57A35AD319285D7B2C6A3499840E3DD761E21C5F8C9EE88996DF2D41B98AFDF1D26B75D1A9FB04DCBC29E655EE9197938BECAC34718DD39585145521786CB50DC160A61146FC15A111921F8528C82611E59F582AF5412A21257B57A3A26E434246844726A177BF05F8F48B2EA8D5600A9A7FB7022FFEEB47BCF27E17BCF5E15094AE3C1115EB4CC2D71D9663F07847B1940158B8E124064F7487FBAE5438FBC461DAFC7D983C73B7B8A85351B5DA604C9F658D90EB898A8CB9B9ECC4D17D2B886B2AF9D90FC6AFF9424AFD672E0983997F36941CD835C20843A0452CC823F168117546517D49BC2006A979B148CD2F406C0670E8742C16ADDE85813FD9A1536F4B74E86E81369DD6A34B2F0BB4FE7E395A7531152BB950A1719BE5F8A1EF66F41BE3805E3F6DC55AEBF398B3DC1F3D076F42B7BE2668FECD4CBCF26A53F4EC390B1969C0BD7B49E0671E535363E591246695B83547DC64A6B9397273D5C36BF8F909839946FCB96068B689114F831FA762DC58545484CC8C3C3C140BA97A38918EACA27421251071F721966F3A8E5EC3ADB168C305CC5E711EC326EE47B7416E18336D3F068DDA8E1E83ED3170B427068DF1C280511EE835D4115D0658A1FBE0AD68DB7D2D6A351E8D4AB506A1D48B0D51EAD9DAE8DD77112E5F8E475C6C2E2223EFCBA3E48A854C55930174431DBAA1968CF46489671F2FED320483994618F15781B65C8AEE203FF15950988D4CB148B490FC4C235DC75C7EC0580A1D3F7B1B652A7644958633D1A8CD6A741AE482A15302317AF6290C9E7400ED7ADB62D8643F4C98E98731537D3062BC17068E74C18011CEE8D4D3422CE9467C527E20BE6A350D15AAF7C12B6F3644FB1F27E2E6ED6C648B277AFA74B0BA277B5555CFAAB28AFC52BEDC5D08999E96A4D25F52AE06338DF863A1BF268FDB25D7E819F12474638B8CCD886C2424C788652C12F715888D4912B7B50067CE87A24EFDAEA85ABD3F3E293303D5EA2DC517D566E0F58F86E383B293D0AE87037A0FDD8E06CD17A0C6978351AFE92854AF3F144D5B4EC7BB9F7446A9979A8B356C88D7DF6D8BFA8D46CA7635346AD617F7620BD418E6F90BC1B8753B4A0DA5A4A625A8DFF9E06475F6EAAA49EBD999EA4BE7FCB52C4384D4F29EC8FC33E39FEAB2698454D3BD04F9C5B34EFECAF8B5C171ED5D0943C74A7E499CD3E00A0A39009F21D6300529994948CFC8416C6CA6FA907166563EDEFBA01C4A976B892FCA74419326B3F1D2AB5FA37ED3E142C0E168D1760A9E79B9015E7BBB215E78B50AE62EB642B73E53F1DEC79C42F705EA34E88345CBB663C51A6F34693E58C85815ADDB8E447844AA9A8973F96A28CE5D08425656867A66DD78E793EFA86B47DA69B1A07F6542F241F9229C55F14F25E5DF0D14D65F236549B0ED2903BA1F4CD57DDE5F9797AB7E8B91638C79F999AA13478EE27AC41D24C4E72223A30855AAD6445C22C90A0C1EBA162F3E570FFDFACE51ABF833252F4FACDAD2553678E3AD2FD4F4B934D179CC77F30EC4AB6F9543AA90FACE833C6448FEB2D536E8D96B2AAC6D76223E310FD13189083A7F0E1191D7D4EF7C3C7A5E3DAF863DBFDA17D019E36AF9866030F38F022B9860A56B0424344232E57EC9F3FE6CD0A6686982F7EF822E0EE75952C8A8FDB56B71BBE4BDFE8A5013BBE57D74AE6689637AED5B725B9383FC427113F3A59E0AF215B82F9C52607EC09183E07C7276EA7CF34D7B54AD564359324EF4B6B10FC4CBA5BEC1BAD57BB06295036AD4FD0E11B70BB175EB21DC08CFC585735128F5CCCB387CEC1C4E9E0EC1B4194BE5FAF200A5DEC0E2A51BD56A90734137101D9D2EB2088486DDC0C9932771E7CE2DF03BAEFABDA8FA33857E2B0C66FE11D02A9B1FA3E504606E972CF357813EB94A4213C65F0349C91E42FD6BFE9D086988943A37F5B112FEAD0AB8A0F0A1C46C05884F48114B754775E0DCB9978816CD3BE299675E13D2E662E3A67508BA148A23C7C344EAABE1A5D72AA0D48B2FE35AD41D24E7405CD64F902527AE37B5C4F3CFBFA92CEBCE9D81C891263037B797735E4144C43D796E20242442641408BF7E0BA74F9DC78D1B91C8CDE612AB9FB77E25579CFC1C0C66EAE3B75488867FA72CA734E9EFD3ACEBA7391C582D8E1558E1DAF6AF413566910E258F519396CC237EAEFC7F032DFED13A64B4FD5F828A3F8ACB977C9E9CBC5CA5FDF5F37E2F68CF50123F97FF9F425F5EF8EEECF0E06F2C92881CBAE0F127CB14EA1476A17850347FC5F949E2535EBE7A0D41172F0819C58D9553CA95FF52A4FB6D8C9F3817B90F1F62E5FAB5387F391C0F62F350A1C6D7884AC844FB9E5D51EAB5E791256AE1C4852B48C8CCC39829D3F163AF3EAA7B68D84F931093908D1DFE07D1B5477FDCB9FF00D7226EE072C80DDCB87917A7CF04E1F8C963484DD7FD06243B7098127C076D9BF8AD06C660E66F012B46BFB2FE5DFCDAB9FA042421D953962735CD7C9ECB17FC6FEEFF7B437BB692E95F05BA4E88A709C83C2EEE254A1ED35050443752CE97B4E43143601C4842F2B7FBF9EBC4AC2B7A496AA9945E39E693A8B9A258B3444125A6A62134FC06EEC5C42B97345B82414ECAF9B2D10F78F6F9CFD1B3F764352B8713C62F5FBBAD62C63489077B0D9C8B14C9934D6449F9F357A3F0DCAB9FC1CBEF982A932B793B779D46F59ADFA25B8F31EA9AB7A352111B9F8D73174371ED4614EEDD8F43F095ABB81A168AEC5C5E89CFA77B5FFDB666F8A56DFF1618CC3484928C2F29608604CE90E5A195E2EFE9E9E73140CFE6408EB6CF99167AC7099291A42C99FFEF80D7D5AECD54758D1BB8D7EF01FD7AF8356B9C2DF59391998DF40CC692BF4DA8FF1330FEA2E5655AF2983E58A6649E3EF83E6C57E2D7AEA56442EA9CEDA9EDF3F788D90AEA676C84E8F404B8CF6359E2336A8A98754119484CCD40727A066EDFBB8B4B2157909C99A9DCD44C79CC6E3D474B0C58099F976D8B8AD53AE3F48524FCD06D224A3DFB19DA779980F94B5DF0DA5B5F63D0F07598B3701BC64CDC888A553B0913CAA34DBB71E8F0E3380C1DBA0C5F7CF18DE47D81575FAB86A3476FE2EAD5445C0D8D4178443CC2C26EE1E6AD7B42C83044C933FC2F3D078399BF06928F04356486D5B1FF42C8A97512935254E597745399C76B6BD0F2FF9BFBE9939C0DAF7F6DFDEB967C96DF130989C9D2E0771075F7FE1384FC3DC9A90F8D2CDA361584B6FFBF82F62EAC7FD6B2226A31B1B57DA69C17CEFBE7E53F4452723A2E5C0C4190B897FCE4469E9449CDD691F17E7C2EBAF614E2952A8DE6DFCD409B4E0BD1B2DD1CBCFC660B947AAE36DA749C8D17DF68828F4A7744B90A43F0F22B2DA56C7D7CF64517D4A93B1A5F7E3916A5CB74C6E7A5BFC7071F34433521F30B2F54868BF30944451520342C41E2C5EBB87CE9368E1F3F87B3419770FEC225C4C6728ADCE3A10C4E66D7B78AFA1C3164B44AC260E62F213D3D5DFDE8082FAEFD5E9EFEF192242D29C89A90EB5B27A66C180AA297F70E041E3D810BC157C55FBF255A301AB18929CA2DB9712B0A11B7EF22ECC64D758CE0766878E4A3BCF09B771079274AD25BCA9D09B9761D57AF87E37AE44D39FFB63A161C1A862B618C392EC9BD8EE154D039393F4295B975F79E5C27526D332FE2F61D759E769CD7E533109177EE29DC8CBAAFF078FFAE02EF45F01ADA7508ED5CA67C273E33A1BDDFD90B97B13FF0080E1E392ECF1EA1EAE04A58B8C44021F23E3754DE2FA1649D30D5F2791F1EBB1EC9678952C7798C791A588EF7B97825542C50D8136509FDB2FAE079847EDDE8EA43573FC4ADBB0FD4FBB07CD48358757DD611DB48573F37E55D4365FF9AC8C0159C3E775EC58791B7EF23263E0D19D922372236B7A2A21123724197342903E8D26BB2487379B46A3B0355EA4D44E53A6351A6EA70D46C3819751A4E41F9AAC3D0F0ABA9A8D56014EAD79B86060DA6A046CD91A853671C1A379C894F3EEE81C68DC7A051C3C178E6D9B2A858E95B9C3E7D5B75E29C090AC79E3DC770E952B8E01A0E1C94B6093C8CB367CF223AFABE8A7DD927922E969BDFEFD1E25F86751919198A2794F3DF0283993F075AC5989818CD323EF2F395552C7669F509C9FE19DDF00B35619158BE34C4C426AA066643B171B84D6123D8406CD0849474A4CB8B65E61628E4480B24A767E17E6C021EC425AAE3745BE293E57A09C98F101D9FA4C8CB3204494CF03C1E637A373A4EA5DAF97C061E4B4ACB54C7589E0273E77E8C3AC66722B8ADE531D5F2794E4968C7789D92E732EFF6DD18050A1571F3CE03056EAB635286F542E1E7797C175E47136896A580FE1CC22385E406C08E08826578AF0871BB42C2227039E4BA4A3976A71D671A167EEBD1FE95D01B08BE1AAE9EEFEE8378853BF7E41D8BDF8365783D96E7B5AE5E8B54A9B6ADED33657996E3BB69EF48325219463DA0024E90F64E434A46A66AA3F8A4742449209898928BB8C42C21660A92D3C4D516B2C4A5003DFA4DC7F3AFD446D9CA7DF0D67B9DF0FAFBBDF1EE6703F0C6873DF0FA7B3DF0AF0FFAE21DC9FBD7FB5DF1EE473FE28D37DBE05FEF7C8F175F6C86575F69858F3FEA8E37DF6C8DEAD5BA0B19CBA051E3F6B0B1F3564BB4D8391A179FA8BC365AEFC28745484E4E46646424AE845C14CB198C7B776F212E361AF1B171C814573A3A5ADAF5D62D4546FE9198E400F16B31A5C14C0DFA2696DB647E424282680489BF8478C5D6511152BB115312284BDE842421C1A805096A4E0A3E09C594E342743D3272F2919A99A32A9879E43053E66BC44CCBCA9506CA56DBA9597948CB9673244D91C0213D478E17EF33E5393C5723349F8529CF6703F35A7C4682CFC167E01A399294E7A5F17C751F5E3B5F6D338FDBFCD195C4B42C24A4CA7B08E2533254CABCA4F46C2467E408B2E5B94480E4DABC46825C57DBE7F92999F952264FF673E4983C534A9682B69D98928994F41C11429DF0C526A4AAEDE434392EC2C9416E0DB109E94F434C06AF45C425672AF0BA4C1FC4A72A4B93902CCFAB843C5B81DBCCE3B1E8843479CE5C797689D7E419794E54B428394999CF721AF4CFD79099F3507DBE82697A96D4BDA4B46C6999056A9F75C6B68A1505CDF662FDB06E68F198DEBA7F1789E9A94817598A1759E17D1353F34446C41AA6152A052A4DA12CE5A4691B51EA859A42C67E68DD7E05AAD79984AAF566A24ADD29A8546B3CAA4A5ABDF62CD4AA3B0BD56B8C43FD869257A3173EFCA415DE7CEB2B346C380A2D5A4C4295CADDF0EE7B75D0B0C9F76A0C92CB2829FDECB0912046A25B09978AD8134CAF4E88A9866D28F31C3317794E8C41E8D5CBD8EBEFA78CD3952B5770E6CC196CDFBE1D0B172EC48103071E19AD5F82C14C0D4F583BDDC51E919066B898842A2F292949B9B2F4A9A92DA93DA945E312D354EF179191AD9BF747218D4D4A45B6D428914542C875780736080942826AC4A575245908E667085BB384414C4946FE4C18531D19729E223AA1119AD72441B5E3BC26B7494E6EF319785D7954754DED5EBC0741D269F7D657025A39BA50DA3E9505533E93B6CF63BC7646EE4325F02426859CD0089A9A918BAC5CB99F5C8C04D459045D3E8949A1D607055D1FBC06494F68D7E57D48CAFB62521EC492E4E9726D512A42AA94745140C58461DEBDD864750E9F8F64E03959D2409CD142B26B24D488486B45F03A04F3B9CF63DC669EB6AF8ECBB5F969FDBB3109EA9A3189A9727DD66D96CACF1517303A311E99227F6C0F3E776AA64E693E88CB523F5A4332CE9AB311CFBE5815EF7CD0063F76DF80D21546A2668359A8F1E51CD46C341D759BCC44DD8642C63A7324269C86AF9ACDC373CF3745EBB6A33077C136D86C133734381FC78F2563C91257F4EA3B165E3B773D226372468AD447B4C86EBA22654A4A12E2E2E21079F31A2E5E3A8D03817EF0F57585BDBD251C1CACE0B4CD06B3A74FC3840913D0BD7B7745C465CB96A177EFDE707575952B3ECDB192309849686C566363A20DF840FC9D3C3E203FD6430DC17197E4E44479A9CB126C5F46A608275D527E528FEE467A768E58A414C4254903A78AE68D4F10AB99F8C835A3EB15753F4E84828D2C1A52048F96E17E5C9212740A3109A02FECB4466C34FE221109A34FCCC744A0D6CDC6EDFBF1888C8A511A9FD6E1CE8304758CE75301F01A240B858182C17C0A85A6D949009296CF9C9D4FAB4BAB938854B18604E74B66C93D89646A7DC963E74362AA687A795F2A02923C5DA499D62C219916244FBD03AD04DF99842309525244B093B345DBB29B5EDC222103D3A44C219CE8BDFB09198849CEC58344B19289B9888E15322589A0A71622EA5E0A92520A541EBBE6E3D3F254F9BB71F2DEA9B9725E36A293848C92C775BB69720F0E8627C90EF34956D605952715262DFC6D7123EF3C88534A94CA94844A4FCF5783E3313142E8D85444C7098AADA922B75C9FEFF1203E59B50BDB8E9E0349AC79045444542A1478D62F152195323D08958A524F11AB9421EE611215B7909175112D9E4DE483FB628F581E58B4C20EA59EAB8B325546A245DB5578EBC39E682484AB2116B25ADD9F50BBC158D4AC370E55AB8D479D5A33D1A8C16C542ADF1FA37E3213120521F2463ACE9E9298F09CC4CA67AEE2D8E1338895F7BA1A1281A8F8189CB87006FEFB77E3C4D9E3B870F92C3CBD9CE1E2620D27272B39DF19EEEE76B0B6DE84CD9B3762E386D558BF6E15CC4C3760E58A65080C0CC4891327909898081313130C1C38104141418A4FBF06839925C1AEE83C2E2951332B745F78E600EE7D712DC2C3C3C5AC533073457344E14174BC3452B2902A5109B7CEC5D3B92377240EE23E0594C48B8E4B568D428DC4862731B94D62501DD02231254850A61A71B4E36C78A624AB46321E2331E912510B533048586A620A19CF615996E3B5080A04053193D6530ED045D52C38CBB16B3D4D3C016E936414289295D695904750969C791C88E6797471595EB356DC66B954917A6E5381F0DEE9423C5A0E5A282A83940CBA6542608999D2B274F717EECBF5A55C86EEB8BAAEA404BBFBE5959415617982F9FC821A53797D95F2979C584E2E8B68B15C724B88DE5175CA3A619BDC8B4E903A1497569406F3D82674996FDE899198F28E7A6FCEE9A0F5669DA7CBBBF37D5867CA0BCACC7B44467A046C1BBE1F91964D6F41F79E0F62C5A39297E7FDB4B6A1EBAAEA235FDE3F3915E151F7704B62F204B68BDCEBB6B8CDF4C9264D5F85975FAF8D8AD586A04B6F1B5417B295AF3E0ECD5A2E458346F350B7F104346E3E4D48390E0DBE9C8E268D17A07EDDA9A852B13FDAB79B0A9F1D4711B0FF2C0E0706212CE406CE9DBD28388FD0D06B3877EE02ECB73BC3C3D70B5E7E3EF0F1F786C566536CD8B8067E3BBDB06EED0A989B6DC066CB4DB0B3DD0267273BB8BB3961EF1E3F5CBC7056087D09FBF7EFC7CC9933B168D12221AD352E5EBC284F2D6DA4E771FE1C0C6696040779999298DCE6671082832F81F3F7D8C9C35E5276E02448A5D24AA6D11D930610D9D20DB40AE2C462DD894952FB22A74AE352C3DE8F11EB29C2C198832935746C6A3AD2F2C4E209B2A481123345EBA76722A3402C46560EE284E06CA434C686BCAF6C5328A8513384086962CDF8D1BDD8B454C467C8B5649FF7E5F6AD98E86232E862420A2363445A49BAD21488CC2221A5F203A49C3C0305848E3AF793E53C3E13EFC73CA67C061ECB2E7E5FE6B10CCB66C8BBF2FD75752004938D0C3946A4C9FB50A09384ACEADA22AC740D53D2C49DCE927A106B979A2E1637391FF7A3C57D172BC8FC1479C868B1AEC23F65EDE245A93D10E2703F4E4845F253F8953512EB159398AEDE93DBC16191B814760B2137EEE2D68324151BF2F8FD1851A0C5968BF5C37AD02926511A92125A2CC8E7E43373664BA23C30EF1F2B2E7562F1F3F33C9295F7E4B59827FF54CA67E03DE82A33BD179DA4CA339F65E9C9B02E283BB763E2143159CFAC47E62F5BB3152FBF5603CFBDF0257EEC668A729526E2F577FBA043377321E83854AC3216556A0F43A59A4350BDEE0854AF390A952BFF844A1586A176CD41E8D17D1E6CEC3CB075AB33162F5A0E6BABAD42AA6DB0B5D90C0B4B13B8BA39C07CAB256C256FFFA100EC0BD88B80830770EAD429216D10822F5DC6D52B210809BE82D090ABE2EE1E8193A33D562C5F8AB16346A26F9F1E72EDADB87EFDBA8A37B5502F53143AF37E8D9406337F094929C998346912A64C998243870E61E74E7F79912D387EE28CEA458D1377E58E987EBA4BCA1D12C9A4267E90C8DFD88B55952AEDA88480AE0CE3034D7008BA35241FB5231B22592C2F09792F214909F59DD878955220A2E5FC14113C82C2A0E591888959120B2526E04E5C2CD20B283C19B819FD007713E21F090B2D36AB8BD6344A2C3BB7695579FD1BF7EFE1664C2C52381C230F9C2A27C40A9BEE4AEC95241244C1677A57AC078F474ABC2C4608D7C40DE7CAF4072270ECECA6258A930A887C20022FC29C20D6214EDE8748966B93989A60F33DF80EF20A881512F2D77A89A8D87425A07249290384DF8F45B4B882B7C4B5BF2BCF7B5BEA3C4DEE1D7AE7BECABF2BF78AB825EF2A295DE5C8DBECCD8D55B1A372C745592A4B25F7D3AC729A3C032D9CE8075CBA720D1EDE7E70F5DCA1E67FB2BD48DC4B219188BC2331D4DD6444C56522EC4E3C221E889B772B16C1110F10762B0EE7826FE27CF035059E7B39340227832EE2C29530D90E47C061BA80D760E7E0AE9ECBC1D91BA1E177E1E5BB1F672F8461E55A739C0BB9258A3319D74406E224F44915851812118D93E7A2F0CC8BE5D1B5C7228C19EB80C64D66A3B2B8A4B5EB4F410D714F6BD61F8FFA4DA64B1CA95BCB58A15A5F54AF350CB56A8F42F972FD50A6EC8F78EBADFA7072D9895DBB0E61ED9A8DD8B4D104F3E6CEC4B4A913606AB61EABD72C83B995993CE7015CBC7C0197AF04E3F6ED28444BFB865EBD817DBB0F0A791D3173C65C0C1E341C2346FC04737373848404ABE5573A1524F295275EA49050EBF0D4FA58E4CF20AF343CB1C393C9602E6F494949939841F75B04A969E24A8A36675ABE42254C9B36036BD7AEC7C00143E56516C172B33556AC5C8BA8BBD12A96221949C028893318BF246614A8ED0B5723154919775CBF790FE1B7EEAB384F478E040C19394E69C8E51BCC705B5C9A1F7AF4C5A94B573179CE4295AE34B1C0A5EB3761E7E68BC05397E0BDE7304CAD9D71342844E585DF4DC0F4052B8B899C27E44D50D68A563356DC21BA3FB4AAB45EDDFA0D149227E3EB363F88A288D6592839D073C00898D96E53A424096D5CBCE0E17F10DBDCFCE0B5EB30426FC6C356EE1570E202CCEDDC703EEC361CBD760B81933073F11A488887190BD6E241522EC64F5F240A211DFD868FC79588BB98BF623D761F3A8EE526A630B1B6C5BC95ABB1D9D1199BED5D3069F6025839BAA977B5F3DC85C90B56C0D6C30F1DFB0EC5A990707419381C27AE84A2FF98F1382DDA79C8D871387539181367CFC1F10B17317DE122214524D6596EC691E367B0DD6B277C76EEC189D3E71178E42476EF0BC40EBFBD2AF5F3DF872D567670747257793B77ED87A7CF6E6CD8B4059DBBF5C5AB6FBC83E75F7A1DA59E7D5959AF965247078F9F43CBEF3B63C79E4398396F2396AFB3C3BCE5965869E68479ABB660BDA51BAC1D7761C498F972DF004C9DB1105E3BF660F2B4B9D87FF028264C9EA1C697A7CD9A8BE0AB11183C6C8CF28EFA0F1AA5083971EA3CF8EF3D86054BD6C3DCC64DE2B80C9C15C57026384CB5C56A1327B556B1469D9EF8B1EB7CF4E8B5068D1A4F46A52A62096B0D41BD263FA162CD7E285763003E2EDF1D956B0F10577610EA341A819A7586A19AE47FDD7214BE6E3558A4FE6D7CF17975586D7684F5966D983E75064C366C84959595B284172E9DC7D5B0109C3A731A6E6EDBB17AF55ACC9E351FC3868E42BBEF3B61CCE889E2B2DA205C64318FAE44317738ED8F6392DA3007F398129A65FCD5610F9A54FD138BB7E5E29C5BA84BA3250EBB75FB1EB82AFAE2A5105CBA781577A362B06F6FA098ECD3B82A9AEF60E051D5C9715BB4F4CDA87885906B77107683E38D72BE404DEE1501BD267991B7A9B1D32486941791464F492FC0F94B62D2E59E3E7B8E2B373024225635869DABBF22D9BE23178464593872FA1AAEDF4E51EE1F7F62FAF2B5181C387605D76E25ABFCAB11F71E2903BA658C93EEC5A723F25E02AE844729029E3C7F45599DE5EB2C95E5B92FEEE1E193C108BA7C4BC85B80D3976EE82CE5DD142C5861261641AC5AAA587779D655A676A2B5214408C78EFD2771ECFC75650DC74E5FAC9EF37850A45C3F121B2D5DC525052284ACD7C5425DBD795F347F228224560913ED7FFCE2656505685D77061C96674C45E0892035F179F7E133B8199B8CEDBBF641C246B8F8FAA9D4272040E9E02327CFA8F4D4B98BCABDF4F4F5C7B5C8DBF0D8E1875342425B3B27AC5CB51E0BC52D1B377E0A264C9C86010387A1E5B76DF16DCB3668F9CD7768DBA603BE13346FD14A84B69142A5AA758488AF8864BC84175F795B59524B5B17F55EDBDC77887B9A8F63A72370E3760682AED02AA6E1CCE57BB8722309F7E38AC4B284205D62D84B5722549B9E3D1FA2FA074ECB7352B238E9811D392427F74F9DBDAC3CA4A3272FE2F6BD6485BB7119B8119520EDA9F3A84C377BE0AD77EBA07BCF7962E53AA2CE9783D0A8C91871458580E5BACB73F7417521EAE7953AA26A8321A8DD74142AD4E98DD2557EC4E7157F40B55AFD50A7FE407CF07153BCF2462554ABFE35A64C5E8A8301A771E8C009EC160575E6D4391543065F0E85BBBB3BE6CC9983E1C38763F4E8D158B56A8DF204CF9E3D274FF3348934706184FEA209FD618E5F23A28627584C90C99C5BCAE1967C711542AF864B039F13EB172364BCAA662EA4492C949D55809B917791252E16E3474E694A911884F3FBEEDE8D57B876ED366E3056B915ADF643436F2255CE0DBD1EA596C7DC8F49C58D9BD1B8127A4BF540928C5785C4A327AF8095C31E890D45F0CEDCC4F0718BA5E133306F9915CCAC7DB17A9333A6CEDD80AB912998BBD412B3179B63F97A7BB14C9BC4EA3D449FC19344939F82B3E7014C99BD1A0EEEFB60B6D50333E6AFC7DC25A6B2EFA71ADA6A9B27BEA8504F5CA17035B1F8EDF7AB48107F0A4DBFEE867A8D3A88C59E83D11396A0ED0F839455903009EEDE47F0C2EBA53153EEB5C1C21DDDFA8E172BDB47AE6B818EDD7FC2D0D1F3D0ABFF24B4E9300815AA36C3A9F337209E384223A345C0A271533C824BE111B8139F88DB71094278712DE35270EECA75E5BE73C8212D4DE2E73471212528CD126196A6C0E5E010957232739C9C6767670F1717374C9F3E132BC5D20E1B36020B172E46FFFE03C59D9B88BEFD06A14FDF8118367C14FAF51FACC0ED397317628E58A915CB562BEF869ADFC2D21A3E3E7BA4EE6FA9F83E5C9496BBA71F56AC36519D40672E5D53440C96F6BE2CCAF4DC25797E8969CF5FBDADDCD5F3617770363812C1D7EE89121684721202271EC4A8C9D817C5CA711C9A930038FB8633A4387369EF81436A82C89E038771EE729872592344516FF7DD83A3672EE3C8A9AB98386D153E2FDB4224B51CFA0F5C891A6205CB54E8A656FE972DDB0315CA7543AD3ABD50B9661721E48FA82096F1B3CADD51A95E6FB1963FA27CF51F85C0FDD0E8ABC1F8B44C0B41438C9FB008A74F85493C7803DE1E3B616B6D079BADD6983B772E5AB56A85DE3DFB48FD2C87B3A393EAB4D4B99E8F89A6818B8ED5879829B8258EFDA77862872CE6D4385AC6070F62D43AAF4381C770585C9EB06B918A54870F9FC659A9AC2BC1E1B82C0D152631C27DD1F0D4CA2C73E9F255D13261CADFA625E5F11011B6CB5C8B76F8246E84DF9646921843AC619034000761038F9C551A354C5C174B2B470C1FBB1CFD87CD17F7562C83D7290C18BE0041C109183D690D162CDF86F5165E58B8D24EAC58347A0D9A21EEE42121A93B36587A63CFA150F41E34452C6401028E5E15724EC5CE7DE78490DE983A673D7CF706E1E6BD1415A37DF9553BA981B711782C14078F86A2738FD168D6B217868F5A0A0F9FB368FDFD10C91B0B130B4F74EC3A5248DA1E4D5A7491E38BD5B1EAB5BF47C0A16BE8D9772A9E79E10B1C3C128E26CD7BA27EE34E68FFE3083CFBD2A76A26C981A317704984F6F4C530798F6BB8107A5D5CDA545CBA7603C1E191CA0A69C333EC74093D1786EB174549387AC2C7D90B6612EBCC9E341573A74C45D776EDF1D3889118326830860F1D8669923765D264F4EAD1131DE498A3BD03FCC50DDD255AFFE489B3D24E22E867241612657A4994E6F97397713D2C1C37851C3723EEA8FC2B21D7D530063BDA4E9EB9A4946848D84D9C3977457938C783AEE0885832BAE9FB8F9F97363B2DF16108F68B953B7EE1128E9EBB8063411770E8F8691C174B7320F02C8E8BB7B14FACCF91E341E20EFBE3F8E920891377E2C0E123F0F1DB8923278EC3469EF5D8A9B3B0B677C68123A74419EEC7EEFDC744193BA9BA9ABD7023FEF57E1DBCF1767D346E3A0CCD9A4BFB341F8BBA0D7E42E9323D51BE7C1F346C3012356AF5C2879FB546A55AFDF15E99EE2857B32FBEA8D61915EB7446859A9DF071E956F8E093E6F8E0D3C6983C630DBC771C4440C009AC5EB50113C74FC2C811C3D0AF6F4FFC346A187C777AE1E2F94BC8CE149F80DF7215D271150A63C3B4F4442425C722332345FDB45C5666BAA4D98FBE06A00FFDCE9B925EE82FE1A90CCEC5A3653C7A542ACCC60E57AF86E1E0C14362C63D70E2C4299C3E2D8D1C122A6EEA35041C0814B21EC3FE80836A0EEAC95367D41AB123474F62EFBE83D8B3F780DA3E260DE5E6EE8575EB37E1CC5969BC6341E2EA9E81BBAB27B6BB79E0E2852B382D71A089A59071FC3C2CD9E08A8E7DA6E26C680A16AD75C3B485B60838F900DD062CC292753B30738923566CDA81436763D0B1E77438BA9F114B688945CB9DB0C16C27FA0F9E8BABD733E0B2FD04468D5B291A390E0E2E476062BE030B97DA61815CCFCCDC57DCB5A1F8BEFD3074E9364E629209A859BB0D0E1E0AC1A04133F1F6DB5530759A589EE1B351A56A73ECDE7306D9D2463F8D9A23AED2D7D8B8D14D2CD1227CFC492D69D099982396B85CD9BA58B5D24234EC5838D8FBE1A7913394A771F0E029DCBD17ABBC07CED9A55BCF95E674F3FD77EDC1F6ED9E58B16215962E5D8E19336660DAB8D19839711C7AFDD81163860AF1FAF7C50421E1D431636165229679D95298AF59AD70EED8719C0A3C821BD24ED78243111E720D278F9FC2896327E1E3B54334BF2DEC6CB6C1C2CC125B2CAD44F3AF94786913962F5D81258B960AA1A763D284C92A8E9A3D730E365B6C81EFAEDD62AD2EE2C499B3D8B97B0F4E9E0D829D588B83478E2A52914CFB0E1E9072FE70F3F49272E77048EEB757DCEE43474FC1D353082831E7CE9D071018785AC5AC6782CE4A6CE98183877789BCEC96B8D55BCAFB4B4CBB137B0FEE83F7CE5D08089473BD034479452BEFA355BB61E83F6431E62D72453FB18E93A76D13F75462C39A0351B1726F890BFBA372B51EA852A3AB5AB151BF716F54AADE0155EA7741F586DD51E3CBAE2857F53BBCFFE997A8DBF0070C1E3117E6969E3037DD869912DF0F1D321A0BE62F859383332E8BD5E66AFFFCBC2CD53BCA59692495363D549F602541B269D07753FF133C95C195CDFCD0EC962D5B3172E42878787861DFBE003888D62229B9EFE8E8ACC8BA64C932CC9A3507B367CF557E368FEDDDBB5F0999CF8E9D2A3D20640E3C74049E5E3E9825E5C64F9824988A4912D38CFE690C562E5F85A36281F7EC3F82E9F356A0C78051B074D88D6F3B0E11D2B961C8B8259838C7040B5639E0FBAE22E89E2730E0A74598B5C41A96F6FBD1F6C791983CDB045D7A4DC4B235F6D86CE38716AD7A61FC9415E837789A34C26C986DF152DBDD7A8F4387CEC3E1EE7118BBF69C437048ACC4371021BA229AFD9A58EA6078FB1E561A9E83ED04B5FCA9B36229C2EFC0DEC9433DE7E1E317E1B747C8B4FBA872BFA9FB82832370EE5C88341C101B93873B12CBC6446762C78E03D8BFFF28369A58C06E9B1356AD5E8BC9D36761D6BCF998375FDCC7B9F3B17ACDBA4775C9D865F182D9D8B461B54AAD379B63F5F225D8B47E0D962D5A88A38107B1CB7707824E9DC485B367704504E9C4E1E370112BB376C51ACC9B395F116CA6DC83AEE9985163316AE46855D724DDFCB90B3063DA4C4C9E38057367CF53F5BF758BB528C7ED0A3B2506DDB56737FC846CCEAE2EB0D86C893DFBF60A51BC70E8C861ECD8E92BFBBBE59813BC7CBC6167BF4DB5AD87A7379C5DB68B62DE097B0757E5027B78F8C1CB6B175CDDBCB07BEF1E296B0D0F6F67516E3B6163BB05FB849856D696EABA3E7E724D375F44DE4AC094996BF179B9C62A6E2C5BA1AD58C721F8FC8BF6F8E8E3EF50B65C67942BDF0D952AF7429DBA8350B96A577CF0510B54A8DC1EF5BEEC29D6B31B3EABF82DCA546D8332955BE2B57F55C5AB6F9547E76E23B16CE516ACDB602BAEFA52AC5CB14EF581A42467A80F2AEBBE7543D7B34875CAFC9C45E331928E04D5F0DF92501F4F65E46449C023CFB27FD73E2C983D1FAB96AE84D90653788B85737772839BA32B7678FB8A7FEDA2B42F352F35B0B7A70F7C7D76AA06F5F1F111EDB813DEDEDEF0F7F71792EE15C1DC21A47650C73CA5F198D247A78BB567CF3EB8B87A88855B8BB5A65BE1B1F32816ADDC0C0B5B0F986C7181F7EE63D864E58C35A6B6E2929EC562F6EA993BC3DE7D37662E5C2744DC82A5AB2D240E3C242E641096AD32C3CCB92BB0668315EC9D77C07A9B07E62E5C83D9F3C50AAD3455DF4AF1F4DE2F71D22E58D9B8884BB517FE7BD80BB95FB9695366CDC0D1D327E1EAE581F5661BB1FBC05EAC31598723A78FE0D0C9436A8CCADA611BCE5E12174E08C215233BFC77296F61EEBC059839630566CD5C2E719E07C68C99A6C83876DC2445BC2EDDBAE2CB264DC5B56D81DEFD078865EE896E3DBAA377DF3E6ABA156775F4E9DB1D269BD6AA31B1D3678E497C7E160FA2A39090182356F682B87F679415B31725C9F8D16A8B2D56AF5C27B1903DECAD1D95F5DBB8DE04A6266658B460B1B27C24E314717BE9A2CD9C3E03CB962C557193FF4E3F041E3888FD7BF7C1C37D3BAC366F81FD365B383B3960A7AF0FDCDD5CB067B73FBCA52E3C3DDCC5F2DB49E811081767471C08D8071F6F4F697B2FECF2F3879787A7C8860FB6BB7BC3C9D15DCE3B806D76CEF0DB290A9A32E12756719F9F28747B21AA07F6EEDF23CA713B9C9CDD45E91F81DBF6DD827DF8F8F38678E1950A68D8A4373EFCF86B9429D7018D9B8C1032769218B20F2A54ECA2F22A571597B4D20FA82AB16285CA6D50A34E47BCF3417D54A8D65AE2CEA678F3DDAA78F783AA6A7EEAF4994B616BEB2272B81767C48B0B0BBBAE4233FEE5E78A3BCA050BF149C863105D821325A14FC6DF9590BC706A6AAA3CE143E467E5E1CA85604C193F1903FB0CC086D5EBE168EB00CB4D1630DF68063B2B5B78B979C2835A51523FD18CCE6201AC2DB7C2491AD35B1A8AA9AD2DA71BE9F677EEDC2156D655ED737BB734F4F6ED6E8AACB4A84E6EEE627D4EC1D97DA7B89B7EF094E0DE79BB37F6894BE6E2E989BD81818A24FEE20EFBF8EFC5E113675487C09E804071A34E2BB769F77E11AEC043E202F929B78B9D088C5B020E1D56A030FBEDD92B31E20E1C3D7902EE5EF2EC62111C5C9C85584760261661D7815DE2326D80ABB7ABC4A10192BAE0E8992370F67492985634FCC15D58B57125F61DDE07332BA98F2D9BB17CF51A6CB2B0548A65E54A339C3A7519C3868DC5E2252BD1BD471F74ECD419A59E7D0675EBD7C36B6FBF8E773E7C179F96FE4204EF65947AA6145E7CF925BCFBFE7B68DEBC39EA7C590BB5EAD740F92A65F169998F51BAC217A852B3B2E4D5C4909143D173F0108C9F390B8BC5DACE98BB50C86B8969536763F58AF5D866E384F16327284BB870FE22E5A25271FAF9FA0BF10E2985B97387AF828F97B7221089C4FD03FB0354EABF4394ABD4CB3EB1923E4218C27BBB3B3CC462BA3939CA712F585998AA32DBA5DE98B7C3D303AE8E0E70168BE9EFBF5B7538EDDF7F40753E51393B3B0B31FD7CC57DF511777F238E1C39024BCB2DCA6DB7B0B0C58103A771E278309E7BE13D54AED25AC8F70DAA55FB01B56A7547ED5A3D51B9522734A8DF0F5F36E88FFAF57B497E5754A9D21EB56A771274148BD94AC85B4FEAB1343EFCA8262A566A2AD7698A3E7D468841382CA14291220E8725384F2B2F2F47F6F3D4F820C948F9CFCD2E400E672F147381F3B5D9A742E8F792F298210BFA3F7359F52FCEC1CB829C5C71A7E5C212FFA42424C2D2D40CFD7AF5C668896336AC590BD30D1BE1B4CD5E1AC2591D5BB3622536AE5DA7B6CD19E36C58272EED56A97073454807B1266BD7AE968610528B76B4B1DEACF21469A5415DDC5C954BE4EAEEA61ACD5FACB3ABDB7669BCDDD82E0DEDE5235A7887B88BFBFCE1EBEF2565745698DDD35E5E5E72BE333CBCC4DDF2F755DB7EBB84E0BEBA73DCB63BCB759DE4B89BB84D7EE266D2E5F217B76CA772998E1E3F249A7A97B8625EAAEC854B41C8955842874285A48C3435C440DC8B8B4162562A7224D04FC9CA40684404AE5CBBA13A3A38C6C79EC996AD3BE0B3D215D0B4F9B76209BF41A56AD551B5660D346BD91C556B55432D215CC7AE3FA046DDEA8A9C1F7EF6115E7FF30D11C6E715615B7DFF2D5AB76B25842C8757DE7C154D5A34C5CA75AB7031E492281A5FEC3E7C147BC41A1F142544A574F67C30CE09CE9F0B4660C0519C9058EFF2F90BB818744EA521972E23541413DDDBA05322F8723C409492A72840776717219293104E2C965879B6A99FD4A9B79B1B3C5DC47B28868FD435F3B63B39C15F3C1F37F176768A9264FE8EED52F7B2EDC5767071849B94E3646AB68F87585537B1B2AEAECEE219792AECF6DF234AD945ACAD2BDC5C7C71E1FC0DB1F2EEF8F4931AA851BDB92257B5EAEDD0B0514FB46E3D5294D410D4AEDD45EDD7A8F903BEFEA63FAA566F2D31E47762219BE3CDB72BA2D4731FE0838FAB61C2E42562A1F721FA4186CE031519D659427145F905F342DDEF34EAE60E3D49065D47EA937986C8F77384FC5F40FDF7D417B10A0A91CF1E0C8E67C80BE56666E1D2B9F308140D3A6ED4684C18371E53274F911865B61A50751072D2F5B4B7DBA65C9EAD569BA5822D61666A824D261BD4365D1CBA40DCB6DF668DCD9B2D606D6B03ABAD36B0DC6C2504B611F7C606AE2E0EF014E1E0F5E82679796E57AE9297A7B8CBAE8EF0DDE1F94880A8B1194FF989B5F5F1DEAEE6137A798BE0F88880887BC458658710935A59CB771372BA7938897B2AD7D9EE087B475B719B5C046EB0DD6683B3E774E37B9CD3CA94931674FBBAD51E9C14CEC9051C97E30C1F1EE3CC1FCE78C99630841EFF06530B74ECD2156D3BFC800E3F7642DF81032486ED8F2E3DBBA27B9F6EF8EADBA668DFA51D2A562B8F37DE791D9F95FD1CA5CB96C1C79F7E827A0DEAE3D9E79F5356B3569DDA707476522BE6E531107E2312C929696ADE27E789728E6942621AEE443D40D49D07B816168188F05BB8197E03572F07AB363B29EEF46EF116BCC41DB5B7B155F546D251A1DA89CBCABA2431778AA5643917074778B9927C52EF62E5B494F0F5F012E2792BECF2F155FB3EEE1E8A9424AA979090DB6E423E0FF17C1C1D6CA5ED5C55CAE965AE427E863A74A569C90F069CC49E5DC7B0769535FAF799805A355AA24DEB3EE8D06118DAB71F8E66CD7AA37AF5B6A858B1A558C4EF51A66C433CF7FC47F8EC8B9A78FEC5F7457ADF44D9F27524CE7552530C29C584FAFE955458BE341EFB433860AF7EE3A388AD46D6E94082CA9F9279FD9E52BAA1DA7649FC5E44D4F05446167B398AB78B6FAEFE74EBC0A0165F1E3E7C5808B519E3C68DC3C89123316DDA34AC58B142ACA134806840C6868C47E80A31BE203867908455C784484ED2F0CED2C81E1277B287CD471A58114FB4ACCB36B19EA265D9C0140E5DA3B3F1A9B9C5BD921885D825712B0583F01317D4CFC75B08EBAD84814466ECC3FD1D3E5E0A8C771479C57292ACBEA220E83AD3A5A2C56567D59D3B77D5743D86F809FCA68DA40AF2FA9C9EA75B7591A9E65672C241B6B4A336899ACBBA5863B60EF6F8FE870E68D3BE1DFA0CEC8B6EBDBBA35DA7EFF1D5374D51BB412D94AF5E06F5BFAA83EF7F6CABF21B376F823215CB2A12BEFAFA6B28FD7919B4FFBEA328BD19D82AF1A1B9E966CC9FB3180BE72DC592852B946BBA4E2CB185A915B6BB79A95E4237177755A7EEAE52A702675168241B532B71A5CD369A60D9A2C5CABB3137D928E97AF16836C1D66A0B1C4431D2DDF4120F852EA8979B373C5DBD14BCDD7D241CF1C70E0F5F954F38DA3A61BBB3284D0961088DDCF636129E6CB393FA1705E7268ACF555C58671B95BABA881295F6F29076B3DA6C8380BD47C48287C3DED6172D9A7641D58ACD50BE6C23D4AE49EBF835DE7DAF2AFEF54E653CF3EC8722A5EFE0B5373E1385551983868EC5762F7F045DB88AD0EB37D5743F5289E3A55C079B2DC4A2AC12BAA582BA8E1AAE58E26F7C708104BF792B7F4FC8FD7FF20DD5DF034FECB043E7FEDD07CA77D6F2B8F2B9785F99699A6B52931F1FBA1119A17ADD3648032F59B6148B9688D02C5EA4ACE66611822D969B45A0AC9466E4B6A5B9056CAD6DE06867ABF2B6D93B63ABAD23B658DB0BC1C54A4A2CB66DAB259CA58C8B6873575B718BED84C0F6EE70B571C6F66DE262D989C06D13C1B17385B7A35849075738586F83FD56BB476E3489BFCDD64E290117D92798475068E93EB153812E15631DC2C9D10DE6665B101F97A2C8989A978BBBF1896A7273545CA26E12B9B43CE79A92889C3CCFBC18B158891263F0DB2E7461F9C9267BB1F2B4866D3AB445DB1FBE47C3AFBE5464AC56BB2AA6CC9C8CAFDB36C5F79DBF43973E9DD0E49BC62A36A42B4BB776E32613B83AB8E3C2994B38733C080E6249CC3788D7612EEF63211E88992DEC2DB7C1C6C206A66B4DB176F96AAC5EB60ACB972EC3BC3973316FEE6C2C59B0F0516841326E3693D041EAC246DAC241EA85C4615D337511E541321224136167ED082B4B5BD858D9C3D26CABDA276CB73AC0C5713B1CECC40575F210CF88752B6EA93B87AFC432BAB8AA76A545DC6667057B7B79EEADA60A36D656AA03D07CD316F8FAF8C3DDC507B3A72F43D9CFEAE1F597CBE25F6F5442F9D28DF17C2912F06D7CFC513554ACD010EDDBF5138FCA5BE2B842B5CA84B2C7C50C4CF9BD1FA65CC99F999DA53E8EC505C5EA53928539CA2A92AE6A61B1B40B21CEA69CF158E6194FAAEFA96A1F38D6FBD0F11F817FCB04F3451393628B4D3D8999AFD645C6C646E3FAF5309C3E7D5202740BD595CE0E0576BB335DB766BDAE31C495DBB4D11466EB37C162A319B6985A8A9059C176B3C499422A673B893F1C24661121D94E4DCB2E75D926B8CD3C754CE24F777B3BB86D137753520F7187B8ED2A2E2FB7DD9DB6C1CDD10E2EF6367016F778BBB33D7C446B7B08511C6DADE0646309DB2DA622F8B622A05B9510B2C771D32633DCBA75474DE5E37A484ECCE6B228AEDDA47BC8F4C2E55084DEBA899BA2B8380FF7EEFD54514CB1B87F3F514D2FE417F576F9BA88C0AF176BB555AC823CB79BB5D4CB6A989AAEC0ECD9E3317ECC102C5F325794873CABB8A4B4585C697E70DF6EEC9318977560B67EA3D4D126B8DACBFB8A3BE8602364B2D90227BBADF2EC16C5DB5B84505BC4224A3D38D9AAF7F4F574879FBBB88E122278495D78325677923040523776B0493841386F95738524DC7690F0619B859910DD1C8E0C2F1CA4EE04CEF6B60A5C786B2FF7B7B592F6DA6C2E9695443755D86C6682AD9666F2BE16B0D8B4016B562CC5AAE58BB061ED0AB1E2CBB0C5C204A61BD708C137A9D4C274BD22F2A40953F1FEBB1FE185675FC12B2FBE814AE5ABA161FDA6D8B8CE02BB76ED5173A9F9C7F8AFF82B856A1A27679171A130C11FB061C70CD30C89F3D951436BC88E1BCD32328F1D321C57D4FE28F3BFB7EBF99FE2A98CE22F023C95AF8FEC1CDDEFB5D3F473160351726A517C6C022E9CBBA88642ACAD6CB061DD4645D4654B96AB6114F6D45A9898AB94FBA6425282DB16EBD7C26CED6A05F3756B14B47D1EDB2AB1E9E68DE2726D5807AB4D1B616DB60936E6A62A55C7444808B38DEBC452B0C369951216E65198CC36C8BEC93A6C31936D29632AD7303735C3DAD5BAF1C0C0C093EA6346D7AFDF1192DDC7E5E030444446E19290F1C0C1A33874ECB89A9BC9592D67CE5CC189131771FAD44504EC3FA426526C315F8B154BE7C0CDD91AFBF7881BEDED0C73F33558BD7AA1B8FBBBE1E12656C989D6C8064B172EC0E0FE03B05C3C0BD30D6BD5B35A995928D8586E11526EC48AC50B144CE498F946797F21C2568B4DF2FCEBE59DD6C83B49BD98ACC166D30DB011C2D898B31E84D0EBD7C064D5726C10926C5CB94CEA7135B698082184588E5B8598D6E2AECAB62DAF4792491D313597325BE41A241F53D691899CCB947548F2918CAC4BD62B5396631EC9C932242FF35856AB7F5E97F974AF2DCD3763F5CA353872E838F23919574C5D466A0EB8D28FC4E31FE33F7E1E941355F8C754EBA0615CA81152239FF65D579290DF7A65CA1518ECA82429191BFE527CF867C0133BD41A24A44ED33C595007DD8B6B969115F278867BCEA3E5264F9EA383E60E878684E1E49113381C7008BB7D77A96113071B7B11246B3564C294AED4564B8B47B10EC16DE6A963E6E6305D27645BB50AEB57AE14B76DB94AD7491CBB6CC10235884E41A0F5A370AC5CBA48047F9E1A60A7606D5CB71266266BD5B6C9BAB55827443735D9A42C78ED9A75547C46B76C87C42ABBFDF6C36BBBAF102B10FEBE7BE1E9BE037BF71CC0E14327D4389BEF8EBD526EB7906E173CB77BA99ECD6183FBA1EC171F8BD6FF02552B95C5E79F7D8806F56BA14EED6AA856B5023EFAF01DBCF8C2337846AAFFF9679F43D9D2E5307BE62CD5A96527566CEDCA158AA89C08B06ED5CA4764A05093B4B4426B572D152BB40CEBD72CC69A950B048B541EDF71A328A10DAB57289849792B12940492F349EAE58B38BE2CE5E53AEB85B0C43A212CA1F6D7ADC29AD5CBB16AE552956E582FF5B369BD5A11AF83583D51621654826269E98EB2238FCFCEF14BBF9DDEA29C76E3C8E1036AC1EECDC8EB484D4950BFB75F5498ABC8A7FF0334046788A939A1F44145C6A8E0D3D252C4554D5572A6114C933FBAA3340ABACE9AC7BF7FA2DF51F357C4133B24936EE98852434F1C2334D7802FCF7D569AF6135CDCD7C66A483E0EB0FED6DF3320589603B43C2F3E2E06F7EF454943DEC08DF06B0ADC661E8FC5DEBF87F0D0AB6AA6CAB14381D8BF7B170E05EC57DB017B76E3D2C5F3888C08C7BDBB7770FD5AA85A44BA77CF2EECDFB747887410070FEC5508D8BF570D721F0C38A0705EC8F455936662A9C57DB37610B7D75D0DB46F3615D74E08CA74FDAA8D12B3AD154B652902BE4581E537AD3311E2AC57BD997D7A7445B54AE5D1B4617D21626D7CF8C13B78FE3921DF0BA5F0D2CBCF2962CE993D5D2D70E57BA726A721333D0B7131E2FACA3B465E0FC5ED88EB488E8F41666A92DA3F14B057DED30FC70F1FC49183F2AE870370FA4420CE9E0AC4C963FB71E6E421D9E69047208E0506E0F8A103A2F8E458314EC879CC23CE9F3E818B674F21F8FC595CB910A4C06D0D41674F4A9D1D92BA0AC0A9934715A96EDD0C57B8112ECF762B52D56D5262BC9ACBC9F6E3AF3D95EC1829B99F23F2932E24E3AF08EB1F2331D353D3144133D2D2912CEF9C9523642BFEFA39E3C29C3C2160BE583EC963E84432324E2401E9B1D15BD3FF19388DC0DA478C29DB3F672CFE4C3098F94B20F9F42D28B7B54EA0DFFAC2AC78ED373C4A423F5FDF0DD6DF26F41B547F9B025252104A82CF9CAFF70E4476A64EB38E1C3E0253C74FC6D2F98BB16AF12A4C193B0513474DC2EA256BB068F6624C1A351553C7CEC0F40933307BCA6CCC9B3107B3A64CC39C1933B170EE3CB168ABD1B05E5DBCF8EC3378F69952CA0A7EF6E9C7F8E9A711F0F7DFA9BEB690919E54FCC32C3A8BA0421E490B448874CA50D7D140C165AA81D645FB8525FE5CB63877E29DD06D1325F9906D50DC41A1F75EC4AFD58706962B59D6D0B9BF763DFD9F6233B4AF4F1A2DD5D61012FC711C7E9D42EB88E136C163242589A759445A488D889AE7C6729497FFE517C5FFBF6030F3B7C0D0CB32E02E995712FA154FFC2F34D77F73BEFE0C0C62EEEC3998306214268F1A8BB9536662D4C09118D16F18E64D998BE942C4F1C32660E24F533066D858C1188C1DF113860F1E84A103FB61409FDEE8D9B50B6A54AF8AFEFDFAA871D46CF120A800344546378C44227948B8DC9C2C9DFB26F5C955043AD2897250422B822FA9CECD2309444815E15447BF80D761C8C085E4A2608ACB9230BC5E4922103AD23F995712FF0E0975CB8F1EBB9EFAE07B6928798CD09721B6A17E7CC763ACB3928AF8EF0E8399BF55C07F690A51C9BCBF026825A74C9888D62D5AA049FD2FD1F5874EE8D5A507FA74ED83A142CADE9DFBA16FD701E8FE431F7469D71D3FB4698F36DFB6C477DF36C7B72D9BA179B3C6E2A2D6C596CD668A5C240E35373538B799721CAC0899C82B4815ED9E55ACD129D02CCB6D7EEF93BF67C18EB3343987334BE49CE2EBD09AE82C82AE1C09A9482984E4C037CBC9DF53EFF6DF4EE9D2F0DF12E43F950D7D65FF5795AFDF028399BF86FF55E3FEB7E0EF3F94CCFB775050F850ACD6E37729126DBF6AD9720CE9D70FED5AB5429F6E3D1421BB76E88AEE1D7BA075B3B668D9A4353AB4EA8C61FD4662AEB8ABEC68D9E5EFA32681F34BD657AF5E418EFA59325AA96C24A7C421233359118B9FD12C7898838CAC58A467C615138AAE177F2F9164923242D4C70413EB69609A972E861797AC50DCD522CEC32469B599288FCBFD5EF85F10C2A022574DF164DE6FF1BAFE4E3098F94F05DD242DAEC9CBC9454E56B6FA343C3B1A98C63C8856CB7418F3D10DA3FB58509051EC324A3CC7DE3E5D0CA756F5C7C7C7CB7176C5F39A9CDCCC63458F3A24482C829D14E919C98FCAE888AAB396BF44B292D68AD656678D9F2CF7BF56A0BA1FB8FADF5FD70823217F112AB6637CC49F60927FEA5772F90D1376CD338FAE26DD49B1641A191913F28FF110AD00C1DF78D0C8A8A51A482AF65493A41A41694D49441DE89A3E764375E73FFDACFA2819A7FF9E602F273B564AE61BF19FC160E63F192488D6F1C18E0C823DB2EC20D1F5CC16E97A45854FBACE0A890DF3B3858819AA2CBBEF6911B9AC87CB767473809F24A26EC2B3CECCE87E2989DBBA1893A98E94862DA3E6EA69965C23A8B6AF8F926EA12137F13FC563EB2C8A4714079F593B66C47F0E8399FF5450C808FD611DEED38251E075DF56E1742CE5AA69BD828A74C5BDB5C5434045EA1C8EDB6AD3B874DBBA0FE7E6E614A99508DA6C2E9621B13232538A5D544EFFE24A859F2710276430D59E5523A4768EBE3BA9F55E96EC51FE353C26DDD3D08DFDA53F72AF19EBFED507E5FF0C3098F94F07C94181E72C116D5AA04654128B8BB829F8BADFCAE4CCA602646672CA569EEC73CD9D6E6233AD1D89A25D8B2453E4A0D1943F9ECBEBF07EEADA22E4C5EEA9FAE3318D443C8F33A172C425A6E033E6E47DB8CFE3DA5830CBF39EBC1FF7096EF31E9999BA85B8BF052C4F94CC27F88C7CBF7C899FB3B29391961E2FD9FF1ED98D300C839946E8A01BC71397B238A54BCA8907F912EF29B2E58AD0E6152A17564DFB92B852B9B8052409AD4B3E9292E3D4E47B1286A4229935618F8F8F5564E5B6467C5A4B4E5FD4C84805207FEA7948409221332B457D018DFB3C9F64D6BE8AADB3DE3A8BACCE916BEBC859A4C8FB7324FBADD0594DDDF4B5EC9C3445CACCAC24C9E3FE6F27BC11866130F39F080A1A8595D6855F1ED3F273B2D391101FAD3A6C38E8CEF9981C66282CCC54FB8C2339E54F174F8A3B9BCBF9951942C468E5D2A99850B9A405EAB735D3D2C495CD4D424E5E3252D338F421F753D65437619AA46579CDD5250175446439FEEA5682726B73F37453C5D4F316BBAB0463538D34242AAF49709FE5788C6427B4734A423736AADBE6FDB94F2805A09491BC95D45574CC5DC9E34C19DD6C998888701E7AEA7A25F14BF7FEA7C360A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060A6114618F1C7C060E65F1D0F918E87E0D7A9F93532DD6A7BFDD9274618F16785C1CCBF3A8A1421B3048F3F8644942C6784117F3618CCFCAB83DFACE1B220CEFF2411D5DC5035D9DB7079238CF8B3C060E65F1D3ACBA8B38A5C4541180969C49F1F28F57FD70EF79E929904FC0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A300-600'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000C50000004D080600000016DBA045000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000043DC49444154785EED5D075816C7D6C624C67BD3138D4934F62EF6DE2BB6D87B378888BDF7DE15150441AA48EFBD234D5094AA52445010E920BD77E4FDCF19FC1224DCDCE4DE949BFCF8F832B3B3FBEDCECE9EF29E99D9592900CD6846331AA0C9C26634E3FF339A2C6C4633FE3FA3C9C26634E3EF82AA8A4A4A9ADED71095953F1EF7939DCD68C6DF01A525F9A8A92EA7ECDBE51555E5282D2F41456D390A4AF39193F70A7905D928292D10282B2F7AFB07CD68C65F0565A55560342EFFA528AFA943551D504B1B95D555282C2EA05C0D5ED75634FD836634E37F1D458565282EFAA9276054D7D4973F8A788ACBCA3AD0D57381B94500AEA93940DFD8173AB7DCA1AC6606431357A8DE3084AABA1EE62F588AD2D2721417367B8A66FC4551515E8BF2B26ACAD66F575696A3ACAC44D09F82C26C78FB0762EA8CC514207C892FBF1E8B6123BEC737DFCEA0ED9E78E7FD7E78FF9FBD29DF1E2D5B75A6F40B8C1C21836A0E2B5E37B848339AF157416565352ACADE0EA00B4B72416C48A0B0B016B2DFEFC2071F7543976EB3B06CD515CC5D7405C3C7ECC7B8C9473076C2018C9BB81DE3C7EFC2E0FEDFE31FEFF581AD95975008A6506F5DAC19CDF82BA186F8BF48EB2A48195EA3BA06C8CEADC19AB57BF065DB61A414433077E119AC9333C0D849673165C665CC9CA784AF3AACC48851DBD0A7CF5AB46D3D05AD3F1D047234A8AB7D8DBCFCACA62FD68C66FCAFA3B8248F926A94125DCAC9CB45417115222253A1A46C85162D7AE0E34F2761E2942358BA5A07E3A65DC1381965F41C70106D3AC862E20C450C1CB80DC3866DC547FF1C864D1B4F50804D01774519EAEA6A9BBE60339AF1BF889ADA52D4BC2E466D5D092AAAF251FDBA5C7888E72F92919D570745252B8A0FFA60E67747D1AEF32AF41AB8036B15ACB0689D39068E3D8709B3AF63F29C6BE8D26F2BBA7695C388115BF1CDD763F02C369D4E0F118FD4D434D3A766FC45515E5588A2927CC42726A184589491D91DBCDBAA1F264CD9838F3E9541F7015BB079BF2314F63BA143FF6DF8A2AB2C46CE388701E30FA253BFF5183E7C0FFEF9C1284C9FBE8E4E07A9D2D26291161717377DC16634E37F093CDA5C5E5E2A2C7951719EE0FDB984DABAD7484ACD464A6635821E6651202D8B773E188DBE833762D1F73720BFDF1213175C4487419B3170EA618C9F77167DC76CC38071DBD0ADC752F22A1D6168EC4097A06B54958A94F1930A34A319FFEBA8AAAAA1A0FAB518787B18F182142205418F73B0EF9821A4FE391432F38F63EF5937CC5C71155FF65C857E93F661DA4A250C9D76085D07ADC7C0F13BF165BB3168DB7E009DE1C7F35694D58F6FBC75B16634E3AF80D2922AD1F5BA70C95AA86998E37962053CFD13E0753F1307CF5A6289DC65ACDEA64F74E918BEE8B61C83A71DC6B8B967D06BE436F41AB61923A61C448B561D70ECAC129D055245A51CB413252BADEFCD6AF2A2CD68C69F89A2A22294961451F6C7B29292320AA853111D9F8E5C623A372DFCF069BB5158A9A0888088623C882E41F0F30AF83C2CC4CC65E7D075A43C3EEBB40C43271DC2B4E597D169C4767CDC6303864C3D822F3A4F83D43B5FA040380652B2AA32B06254549688EDB72AD38C66FC5968384BB531AA4968ABAA2A50585A86ECE232E4965563B48C2CE6AD3E8165728AB8611888C47CE0C1D30A78879660E2DC9368D96E063EEDB81C33975C13B144BBC19BF0EDE0DD4229A45AF5C5049945282AA3B33771BD9F1434A319FF4BA8E2691BF9D92828C84349453559F75A528A5A1CB9688513979D3077C505528E0BB86E701FC7AE3861DDF69B983CEF02A6AF52C28C65D7317D8132FA8EDE8D5EE30EA0D7D8A3E83D7C2B5A7C38004E6EFE74FAFA6B94570AED10F992A2E6DEA766FC0FA0AAAAE9D9AEAFAB4B504B025B5A5C8294946C443D4D836FC07358D8071365AAC5C8A9FBF06DEF55E8DC7F153EFA662A64169FC4188A2396CAEAE3A27628AEEBC561ECD4F3F8A4DD12F41D73005D87ECC6BB9F4E4677E999A89F25C28380449D4A0A459E515A5AFAD38A34A3197F04AA890E35CC5794970A54F17C0B2A2B2FCF4546C64BA4A7A68939495ADA76E8D5772E96AFBB82D397BCB1EB843D36EC36C584D9A7F065B70578AFF5380AA265D19368D2898B4150BE158923E7EEA277FF5D983A5711BB4E7A62FCAC0B449D86C3C4F20E6A6AEB50525A4E0A513F3ED1106F6D34A319FF0B6025494D7B81575969623E93A6B6055AFEB32749AB34C6CA1C83C21E07EC3FEF86EB46D138ACE889D9AB2E60C4F4ADE831640D068CD909E9E1FB307DD9654C9EA5883113CF4061BB25D66C322085D9824FDB8C415A46095EBFAE4145459918FF687CFDB7369AD18C3F123CD788C14A5023E66DD797B3B7088B084554CC53904EC0D3EF1196AC3E84C1E337A0F3A0F5909EB81F3B4E39C0C02109EE4165707990039780341C386789F9AB95D1A98F02BEE9B5021F7FB918DD7A6DC2D2D51A901EB60D2D3F9A84956B4EA0964F5A5725DECC63EF24B9AE046F6D34A3197F245820EBC862333FE27C5969318A8B0A90929C087E5382DF8CCB2FAB4136319C8088541CBC6482692B4F62ECA2E358BE45074795BC60E69E82F064203CA90E2EF7527159E301864D388221938836115D92997601CBD7DCC037DD56E08B76B311FC308BCE0C5456169242FE943A71D7EF5B05CD68C61F01F60A151515282DE30097AC75552E8A4AB3282525A112DA0577BF97D034F087AB4F1292728017B98063E04BDC74790AF953D6F84EF63A86CF398C390A57217FD200DBCF9B63E5F61B98B3EA3296AED7C0DE335EB8AEFF14CA5A0FA1B0530F5D7B7F0799596BC52878597925788E13D7A5293459D88C66FC9E607AC47CBEA6B69C7C443151A42264E4A680FBA0D86FE8E9BBA053EFF9F8E8CB4998BBEC0C8E29DAC0C4350A0F93EB60EC938C2337EE62F90E3DF49CB8199F4BCF43CBCE1320F5D940BCDF6E22BA0C5A8D550A9AD87DDC1DBB8E3A62F6524574EDB318ADBF1E2146BF4BCAF90A3FD68595B3A4A47ED04E821F32CD68C6EF89A6969A292ACA42755D21F24AD2915998033EC2C0EA3EBEE932131F7D3D075F755E8EAED27290FA780CBE955E84459B953173FD15AC3B6C8519DFAB60ECE253183C773F7A4C94C3D78316417AB20226CC3F8AD55B3421BFCB025DA465F1E957D3D0A29534264E5B8BA7CFD3E80A6FD7A121CACAEAC72B9ADCD98C66FC9E9058E69AEA328E2690999F89CCE2722411451A384E015D07CA437AC441F418B417DD06EC44A77E1BD0BEDF0AB4EBBF1C23E79EC494952A98BD5E174BB71B62D55E637C7FC8045BCFD860DB492BEC3BEF8C2D07CCA0B0C3083DFAAFC1E8C99BF1DDFC1D30307313D7E4E56D3895284043F01805A76F1536A319BF357860AEA080978FA9DF66BA22C973CF53E8C330419B52F381F96B4E61F3016B2C9133C2B20D5698BA4093ACFD6E741FB41D7D466E46DB5E4BD171C8467CD14B1693976862F1268A23765842EE903D8E28FBE3B46A008E5FF6C51A859BE8356015BEE928831973B6E24E402C4ADF0CD6E59347E2F4E7D06461339AF1DFA2BAF26DEECEA8AAA8465E0E493FE50BF2F2E1E6EA891A3A2C26BE009B76A8E0F4554F4C5F7015CBE58CB1E07B43ACDD6A8F151BCCB06EB309E4771B62B9FC754C987D1AB2BBAC317B9501662CD3C12279636C39E28AE50AB73074D27EB4EFB102D243E521F54E0F2C5ABE1F7EF79F2139BD0849A9AFC4757F099A2C6C4633FE5BB002342E6B88AC577962A43A3B1B9830411E4386C94366D669EC3DE68A6DFB1D20BFCF1EF3576963E50643C86E35C0CC05A7F0FD562D6CDD6F852DFB1CB15AC1141B76DA92F268A3DF38F226433660B4CC1E74E9BD082D3F1884390BB6C0C93D14390535C8CA7D7BC6EDBF439385CD68C66F85D2E2B29F2C471315F144AC4513F3341DDFB61F8B775B0CC2EC39E7D1A1D32ACC9A7711A3271DC2C2F51A9834F73C56CBDFC2D1336E984341F5945907B06DAF3916AFD1C2EC654A68DD7109DEFB7C1A7A93428D9DB1076D3A4EC1475F0C41AF7EDF212EA11055B580DB6D3F24F2549137D7FEB9AE58099A2C6C4633FE5BF0DA4C0DB7B99729AB20198F9F840B618D7B017CD3610C3E6FDB1763C6AF41BF7E72E8DD6B3D5ABC3304FFFC6004DAB79B8E5E3D17A075EB91F8E4F341E8DB7F0E060F5B8C162D7B43EABD3E18366615FEF1C9207CD27A2C7AF45D82612365F16EABBE68FBED08F807C58167A23F7AF414A1611128AFA8A7728585854D4EEB688C260BFF08340CB89AF1F740C37722F2F3735158580C7E7594B773F2D349194AF09A3C447C7C26DA771882B5EBB7A38CA2ECDBDE0F4912BFC23499DD387FCE013574CCE3C7A570757D86EE3D6468DF375055B381BBD7137CFEE5206CDFAD8CB0C84CA453CC6C6CF18002EA71A42C5DD17FF077B81F1A8772523A2FAF7B080A7E84EC9C1F67C0FE523459D88C66FC37282F2F7F3385A2462C30F6FCF9737077671D093BF78476ECD01F1F7CD45E8C2ED311C8CEADC4471FF647FFFEB3C00E4666DA4AD858879055070C0C3CE0E41C2426063AB93EC0BBEF7F03626450D53486B5E31DA4BFAA41A7AEC33168A80C6CEDBDC539135333E0E9E587A827CF68EBEDBAF1A021A37179433459F847E0FF93A7E095EC24ABD9FD9DD1F8ED395E0E3F252919810F42514BC25E5C58877163E7E2837F742441BF8F626232878E280A8197969E8616525DD1B6ED10ACDFB01B115159F0B8FD085F12BD3235F340C6AB0A2C59B601172EA9A38602F496AD5AA3579F11282A01162C5A0F531327BCA6723FFFFB887D16870781A1888B4FFCA13E393939C8CBCB13D34B2465FF0A4D16FE11C8CDCDA5A43ECF96850774B8C28D5F38A9AEAE04A361D95F01556F56BEE6B49A14A2FCCDFBBF9CE7F4D7E0AFA05485C53FF6F0F0D2F6BC685960D05D444444895E265E5669D9E29D7857AA3D3AB61F815AF21A3B769DC4BCF9F22079C5F4E9721840718394D4D758B14A01092995C8CCA29349B5468FDE63514AC67DC6AC65B0B1F11073A3A4A43E214A65843252ACE0A0581416BCC66DF7BB7899900EBF3BF749298291C1277853A7866325FF0E4D16FED66041672B220197351C51FC576F5EFD37E055A87F0E8D8FFFAD51595D2FC4FC91104EF995C7B28A52F1C110DEFE3BA0A0A810252495155564B86A6B48F12BC4B71E325E6522303800AC284C99D2D2ABB174C9417CFCE110B46CD90BAE6E91A8249E131B9725C094E9F46953E81BB98AB94F4386CB20310D78F2AC9C628821D8BAF3AAF00E4386CE80FFBD48E4E6D760D5EA5D080E4940467A05820263F02AB30CC1814F90109F015FEF403C8B7B4E676ABADEFF0E4D16FE11C8CFCF17DE815D1AAFDEC06592B4B11BFEAB81854392E7754E25F9BF33D232D2F13C3E4E2844726A8A10EE4A12E407214F499817E2DDF706A153E779183A7C0DB2F3010B7B7F0C19350F2BD69C41122980C2F68B387EC600E1D1C528A5DF05841562C2F46D906A290D43D350BC226FC28B9775EA320A5EDEE1449172919B078484C5E18EFF434446C6232AEA05E2E252E0ECEC859CBC6CAAC1DB756443CC72D7B8BC319A2CFC2DF0EFAC7F53DC2E35359582ABDFDF8AFFDE28ABA8BF87FC822244464583DF0396ECFB3B4062B4F20B0B10F7221E2969A948487C89F8841714279408C528254F101D9F8A6163BE43AB0FA4D1BBEF6A8C1EBB130387ACC690914BD0AEF31492BEDE68F5E1588C9B78102DDE1B8B0F3E1D8D1ED2B3D19282EE8FDB4E46EBF6B3F0695B19BCF3FE508C182D8796FF90C6F4EF3641AA453B58DBF9E071D44B4202799B64443D8DC3E3C818DCA7F8E5EEBD20513F89976E885F225F4D16FE1A48BADC186565FF39EFCDCECA87AFCF5D84863C46159B182A2B29AD426111D19DAA3A9495D720BFA014E515DCBFD0F4399A02CF9DE7342B3B97CE53F396804AFAAF45BEBAFE9ABF14E5FC064C13E53C905B3F980B291E34F2BAE34796502CE02B959D5FCF6BCB39B2A4B4E0CDFBC1BC5D51537F5FC5E53F1A933251253A674D1D4A2BEBCB2B1AF5FF3786E47E1B83294EC3EDC6D3309A9A96F1AF90F8321529A9E9080D0B4762523A8A8A2B505C568DF4AC6CE414E6A21A55088FCCC0B4E9F2F8E4B3911837610FC68E3F88DEFDB6A0475F79BCFBC164741BBC0E53E79F81F4889DE24DB9BE4376A3E74005F41A228B763D17A0E7B0F5E83B721B068CDA87AF3AACC69419A7D0B9C77C48BDDF11C696EEC8CB294768F013B8BBFAE1AE7F301C1DDC101BF3028F1E46223EEEC700FB3F4193858CC614E6B7E0FDA5A434B97905C8CEC9C3CBC454E29A59D4B899D4B069629B7B0E1E3E8A14E549C919E42213683B0A6174A39C4646C52226966EFCF11344443E115698D3E8A7B174CC63D1EBF0E871049EC63C13E76184474413F77C24D2C7E14FE8B80891E773F0F9787027E2091D1F4EC751FEF1935804D2C3E64F437159181D1742D767703E94EAC179DE174EBFBF47964952C6FBB93C20300C914F9F2130F4119CDC6E23F86138A2629EE37E70181E45462328EC31421F87232C3C020F2322294FE77F14518F37D7BA1BF250D423E431DD7F049D97F088F27CBF8CD0B047E25EB90DC229987DF888EAFCE6DE793B2824980433028FC21F232838541CC7C770AF0C0B7338D795EE372498DA86F21154EF07F743041ED3FDF03192B68A8C8A11BF0B0CA2FBA27C6ADA2B3C7B9180CC9C5C1494949342D7E1555E1132730B515AF59A008C1EB71AEF12F5E9D0693EBA765F8BB6ED96A34BAF8DE421D660E0A83DF8ACC3427CDE7129A45AC9E083368BD073D00E74ECBD169F7F3B0B9F77988AB6DDE68A553AFA8DD8867F7C3A9D247530BEED3C0DD60E0FF0903CC4B39864383978D13D3CA1403B1C66A6D65057D3C6DE3D07914C8A9A96CE72958284974942E6E2E213F02AEBDF4F06643459F89F80AD305BA9BCFC425109AED4CBC4645199E7712F449E2BC916869522E1650A7901E27805252828E4C573AB51525A890A8AC06AC942F2000E1B6FB6BA6C95F9E59032F2209CCF258F9157480A56502EBE4BC0794E79BBA8B4E6079456D4D1F1404E7E9948B92CBFA812D979A5282CAC4429F978FE6D7159AD404E61394A2AE9FC451522CF69764199006F67E597D2C32F1129D72183BC5B3E79B2BCC232E2BC85C25A66E7150B149317620129A2FBE2B484EE2B97EE37AF98CF5B8694F46CF15BFE5D4E3E9D3397684756210A4BAA91995D8482D26A712DAE03A705648DF99A99D905E2B7C9E9AF9053502CFAE439CF6B22712A417E71195E24A5222BAF9084371FC96959E25A7C1EFE7D5A66BE005F93AFC7487FC5E7CEA5E38A858067E41420890C14A769597948A760209E0C18E79333B2905F5A8A68A24C010FC39040D7649E40CD891973379000CF4787CE8B892AED41A76EB4DD6503BAF7DB818FBF5C820E3D36A093F426B4EDF23DA4871D40FBEE1B493116E2B36FE7E1937653D065C03C48BDD71352FF18888F5A4F26859A256897B97510A839504DB251515E27C00EB0869D273B6E515E23B6F9FB75927F1919AF50405496994C717129929353F1E2C50B317E929898F8936EDAB704FB3F45115D289D2ECC421F13FB1CC92969623BF35536097E09D843D4D4D24DF06799083CAA19F7321945659562B0851F203BEFC2D20AF170D3B372459EAD506E6189D8CFF9ECFC2221084C31783A4D6149AD10F682625618D0C32C2545A0F3155593A012F5A2FDBCAF8822B79CFC0AB14DA721E1AD4335351C2B094F39E0B4B08C85987E5B524502FD5A0865112FBC454F81CB5859F8182EE3E3B8EE5C2FAE2F83EBC575E47A733E339794839489CFC3F9F4EC4221DC9C4A148ECFC7FB73A9AE7954E757B96562D5BA4CA206F9546F9EEE9C915D426575A44C953FFC867F9F57440A9A5B20C079BE66525A269806B222B0A23252337284C16043C048CDA0DF503B6512D2B38AC5B5399F42E55C0706E753B2F3904BF792416D9E4EE7132BF3D13683F7A5B1F12BAFA0948E2B2F130A919A5307B9CD8AC4F97B61E0D0BD183BE934FA0EDC836EBD7662C0F0631834F2187989231834E6307A0FDE8BAF3A6FC0F009E73064EC7174959647FB9E8BD1BAF3248C98B606078E6BE39A8633868E5E89CFDB8E206F9A239E756C7C063D4732BED4A6AC0425D42ED56428997EC7505CC1D4DBEF4E00EEDFBF0F777777E8E8E8E0C8912302FBF6EDC3A64D9B202727875DBB7689EDCB972FC3DBDB1BAF5EFD388BF62702CE60AAC4831D9C728F50E33E5E0E565E91B5887DF68294205EA4BCCD56BEB8A442087D19491B77BBB1564B0487859A8589DD2D5B3CB67CEC0D9EC4C40BABC9D68C9584E96D29FD61E1E707CEBF919C8795847F4F06971E7EB99826C0F942127CCEB30071A8904DFB583918AC18AC14E9AF8A844270E3B24566AFC10AC14AC002C70687858F9C86103E5604E115689F500452083E96DF682CA43ABD22616164D17D719A4782534427AFCF570AE165856265902888B0FA94B2C0B350729D5333C9CBD03DBCCA25052C7E4D6925D25EB13280AC7EBE68C7E8676444E8FA2F53B3C81ABF269A174375A176A5764A2323C27560EBCD690109EE8BC40CA28571C20372CAC6800D406C1C798F9C0AD0AD2333BF5CE05501097F1E79BB376952660152738B904737CAA0E643262958360B236DF3B295B9C40A1232B3905648DE8DF6BF482FC584991B20D57220FA0FDD48F1C33EF41F7614BD06EC479F410709FBD14D7A3B7AF4DF8EAEFDB662CC9473E8475EE29B2E7244A9D661C8E81D58BFF53A340D3D61EF150A1BC700D8BB048A6E5A2FDFC7080C8E454252966015D1314F1170F73EEC6D1D6067630F6343336869E8E2DC998BB8AE720337D4B4A0A2A22270F5EA55282B2B0BE157535383B5B535141515D1A64D1BD8D9D9D1137F5BF67FD162680D6715B236B1DB4948A0889F148129502E7149A641AC108C2C72B15CF6EC4522591C8A0DC87AB11BE7FCCB9474A12C2CE0EC82995A30EA85AC0A1C43735A4012C3D64042974A69073D7FB1CDD68F29000B270B2CA72C2C120BCF793E1FD32DA6600C3E172B1BD306C979994AF079D35FE589E3F3499999E614939696D08FB85E544CE764A5A140984EC0D4272BBF98849DE81BE5392DA39BE1FD7C3C5324DEE63C7FB8931589EBC4CAC5BF975033AE2BC9AD78C87C5F2F93B3C1F1310B2B8FF2F2B48702F26A6CB539CD268526638F1C5234D261A11492B6E23A737B717DB88CEB14139F281480E963E8A368A1206C24D83848BC6701518F7C8AE453B2883A9162908D401ED149568CDC12DA4F6D944C862B813C0DD91191CF20231616FD1C51F149882156F08CE2BE3CBAA757C57590DD7C0AAD3E1D8ACE3D97613005CFFD861E418F7EBB8532F41EB44728433F0AA6070EDF8701C3F612BD5A8BE1A30F9247D98D0183B660FDC61BF0F04D40F2AB6A04863FC3B3F8340485462230F031BCBCFDE0E3EB07330B7312F0AB505256C435256568DED0809989296EEAE8C1C8C018DA9A3771F1FC65A1185714AF42F5DA7568A86B42474B97E20F67DCF1F1C383804018EA1BE1C68D1B44A1EBE74535F4128C1F328C86036A8DA7D8666767E3C99327484A4A122793586C1670B6E60CB6EC5CCE607AC49E21ED558E5008CE33D7A567255C3C3F4C16BA440ADAD8423357E56D0ED8E87988E54DF8214B049385917FC3E52C7C242364C1C8E2BEAE455135791472E159C5A4A0443219CC77F9B785E4D5CA6BEB8F2F22EE585C494A514374AB8AA85C0DFD96CA72C81BF231E944054A6AD93A12E7CFCE452951BE3CA27EF924B1DC1354504134AA86EA40E7627ECDCAC475E2941581F937D78D05338BDAA390AC38D30E4E59D9988ABCA2B6E17D4CF7D85B95949350939032C5137490CA73F2AA8432C7C4278B7B080C8B14D76441CC26AE1C4B9C388F4EC0B486CFF992DA97290D778332B7E734F64592A807B72BB7272B23A7513189829225A5E708E54C487925F26C4CF81809B59328C8CBF43C112770CACA12119B585F564D4C80EA9453025C56B1C0676D47511C301873179C83F4808DE8D56F3BA407ED168AD06FC84EF419B885A8D4160C18BA037D066C461FE9759834F910860DDF86AE5D9760F9CAD3B8AE610F752D63DC20213737B72498C3C8C80066E6867072B686A393158C8C7509B4DFCC0436D696E415D4616A6C0277570F78DDF6C66D776FF2204E70737117DB9CDA58D992C2E84045595528CA93C8688A2FEA659DD990443924107F9AEA594A4949F9A12C3A3A1A3E3E3E888B8BC3EBD764ADF3F2046F658560CBCFC2CE82CF3487B799FA64D0436205906CF3B11C2B90CC084521432504A5804C25F35189E0F0C32EA2DFB030B082B0B03138F0E387CAE5A297E3359515E6914B27AA524E0F392B8394830263DA26028784D4449454952132F6092A5E57E1655A12291F59DDC25C812A52A6D4AC4C71BEA86731F480EBF032334D9C97CF93535A220431B3B000F169A9789E922C82CAA42C0ADA2A3900A7588914823D0C07CE6CAD392065A565256161E57B640ECE42CAE0324E599838C8A55B165FE2A1DB26EA48424D0DC1CA9245B1055B7A8E05D8BBB062E510FFE1C79853568EE23AF246744026C5117C2E6EB3246A53AE6F3C05DEDC96DC6BC5F7C6F561C373F1EA7552900CB1CDF48D8D0C1B1D6E4BAE3FDF0BDF13DF072B5302792F2A12B434A7A092BC3D1BB60A0AEC7305DDE37B4BCD2EC5BEC34AF8BAC358B4EF38030307AFC7F051DBD05B5A163DFB6D268FB093E8D34652828DE83778337AF79747BF019BEAD17F35860E9643FB6FBE439BD61389EB5F86BDC37D68681BE0E0D123B8461E41EDBA3279860BB870E1085454CFE2FAF50B387FFE28B4B555E1E2EC88C888C7887B4EB42AFE85F000BEDE776061660D835BC6B875539F1446437811172757249191A67F5265CC23DFC87563B0E1E75ED71F0A1A2FF32181A3A3232E5EBC881B1A5AB87255196AEA1AB8AA740D86A61678121B27024BE6B1F974B172326F6C55B328B8E6603B8F1A5EF4EA506366107F4E48C9402629143FAC9C923244C525088578F4F49978A0F742C2C5434EA56094797D5A0E790DDA66CAC0AB4DF331CF12D3EB85B5889484D2B8F464A10425B544255E57A29C44BFB28E3C481DD19BB23C1224B290A40C8555E542D8F9D381FCFB92DA0AA2047C2EB2F4F49BD8A478914FC9C9A05FB0B72821DA50239420B380027CBABFC40C1264FA2DF371F622CFC962B3C0F2F952B38B459A5D44C13BA5CFA95E2574BE3412347E0C69DC0614D4F2FDC667BC422E51A0A724A43CBBFFF1F3C437E5B9C8248A9441969AC1BF0B897826DA2BE4510C880DE1514C8228BFFB30025964EDB22B0A11FFEA25DD67251E3E8FA26B521BA566D21DD52B8E8AB611A45AB5C5F60317F1F8693A28A441E4D39728CCAFC2F3D814312D223D351F4E4EDE448B3361626287D4D43CA81147E72E6A4D1D7D7878F909CA79F77E189CDD7C84B17B1C9D864B4AC6E837708178FF61C5AA2B9093D740FB0E73D1BDD71252105680EFD17FD05AF4925E819EFD57A2EF2059A25472E83D5001BD8729A073DFB5F8BAF37C7CD5693A662FDA89B35734A06BA20F152D45282A5FC2A1E307B0FFD06E9C397B94E2812B3037D185838D21C2C3FCF130340C9E1EB761696E415E400B972F29126D5285B9A9191CECEC1112145CBF0E6D13325D5D59FFDE78E3813C89F7F8C9081F6F4BA893BFBF3F69E905B8B9B9C1C2D21A3367CD86FCC64DD0D125F7656D47C15F3C591876BB441748315232B349D05F08EAF13C218938733A9E5280184BFC907B34D84D331D29AB7B0D0B27679CB9AA44C20B286BE9A0A0AA06C72E5C12E9A1D3177037341C06967670F1B92BF226E41283236370E0E43912F03A9C57D1C0138A69AEE9DC12C73C7E16872B3734E117148A6BE42A93B3B3B069F72E216CEB14360BC13E78F20C3C29407370F7C1BE632711F9FC0596AD5B2F8478DBBE83C26BF1314FE25FC2DCDE116EC46359F099F230A74FCFAD177C45152D21947A1636088A7A06F7BB41B8AE678C80C7D1D875F434FC42A2A04A6DE4792F08EA7A66B072BA03030B575838F8C0C33F04C7CE5FC5E3D81798327B81E0EE3273172191629BF55B77C1C6D513975435B0E7F869B8DD09C09A0D5B101E1D87156B37208CAE25BB65271EC6C6E3C41535783C08868E850574AD4C61E1EE84C364BC1E532C377B852C6E995AE3DB6EFD89D2B481D43FDAC3F7411CAE6958E08AAA3E0E9EB844F4C30E172F2843E9AA3A29820DB66CD9032B2B27AC97DF26B8FCDE0327E1E3178C8347CE425DD340F458853C7C8AD8E7E9484CCE230F71153DFA4C21A15F88EFE61C2085B881454BCEA367EF1518325C0E03877C8F2EDDE7A3679F45E42596A3E780A5E8D67709BA4BAF44AF81B268D77D257A0C94C7E0D15BC5BA4C2D3FE84DDE650C2E2A294143EF068E9E3A822DDB1470E0D05EDCD4D32419B44380BF271CEDCC616765884B172E52FC704128839686A65090CCF40C21B78D515E5A86E2C22234B5CC0E43C29424E95B3B595358219826C5C7C723202000AC18DC8FCB330E1D9D5C10FFE2A518677842168BFBB899833E8D4B12AE997B4642226210FB324DB86F5682A72FD2F03C299B02A862A22059C2CA31FCC31EC1E58EBFC82B6BEB91652C83AD872F8AC9659FBB7683AC7C1DEE8645E349420602C84AB2A01552F0E1E815408A03B8FA472025BF0E5E813194D622E0613C095C38716E404DCF5208AF96BEA5F032DBF79D10FDDB9E7E61C8A5A0F0ACA22694D54D504086E1E86955A256A550D130A3F80350D7B1C293E7595052D387A9B5BB3886CF1516F50266B6EE825F2BDFD083D7FD08044526501D9FC2DCD113BE4111C8216F666CE78258F28886A67678F62213F6CE77F0282211BEFE9170F508444C1CEF73447246364E9EBB24E8CC9E8347455C7555F506C222A2E17B2F100FC223919A930F2B7B67D121E0EAE12382786B67371157E8DBB8C2272412B65EBEB86E60004D53539C54528199B317A4474DC6F0B13320D5E273A110D66E21C8A276B1750B84CFFD70583A788A01BB3032369E5E77C4C0E96D4F5F31E6C1838D3CAEE1E6790F4944E9EEDC0BA3FC7D040445E111DD2F7F636EF9AA2D68FDF500FCE3A35E1835761DA64EA398A1DF4A74E9B6183D7A2F45D71E0BD0B5E71CF4E9BF087D072C44B73EB3D1437A2E05DB0BD1A5CF02528CA5E8D86335A4076F44872E0BF155BBA9183A62292E28EA88C153532BB2F64EF6B0B1B3167070B481A10105D1674F61CFCE2DB874FE14C50DD4BE31B1D46A6F0B388397EE6F5CD6106525A58226352E97E0AD8D8C0C12EC972FF1F0E143701CC1DF14E61F73596A5A8658BA9C9EA118A04BCDC813BC9895218C148183C24472FFD194C6256722203442500A568A6812EC67C4518323E39044415E0859BE4CE2AAF924094F1273F0FDB64370BE138A87CF32683B0F723B8FE37E7832D46E3960C7E12B50D8730E9BF75D40746211BC1EC462C9F77BB0FFAC1E64B75F849953089E265761EEF2DD088BC9C583880C1C38AD0967CF3078DD7D82FDC79471F2821609B205511BE2C824D41F7ED1030A5B2F105706F61D52C3879FF6C5B94BC6D8734015B2F2A7B0FFB03A3DCC5938764A9BEEAB084F9EE562DE62050C1A311D26569E98396F0D962CDF0AF94D47316FA11C59C4A1387D5E45F4F747C52608BAE37DE781E8FD7918FE4C04D22F125F213C2A5EF40271502DE95593F4B0717CC129539397C944AB28F334EE25AC3868A4E0F1F4998B82CAAC9695C7E6DDFBB0803CC79C556BB1485616A366C860B1DCF758B77D3B36ECD94F5E44159F7FD50DEF7DF40D3EFCB20B02A392109D446D4375E1DEA344327021212148CFCC80CF1D5FBC4C4A84BB97271E474592F00722282C140E14B87AFB93517C10022FBF07F0F40D84D79D106CDD7914EFB66A8DCFDA0CC4F0D1CB307BDE1EF4EDB7189FB79948CAB0082346CB137D5A445E643ED1A60542317AF62325E93D079D7BCC461752961E7D1760E84879C8CCD88BCEDDBF2329EC0485CDA788D625C12FE03EEC5DEC60694D1E504F8798CA391C3B4631C5352504DCF3477646FD9419C9471BFF5BB07C73E8C0748A270B8A9842124B70FF6C7070B040686828222323111111217A9C584178249A07E6782A010F9D47C7BE14DE22E269BC4068F853DC0D7E8C20A210E1312F60EFE68BC8672F85CB8F789E84A8F814411D22E2D270FBDE4324E7026EFED1D876F00A8E9CD785DC8E7364698113970C85800747E561D7911BB8A86A03679F58EC3BA10D53FB10A8DFBA8DC56B0FC33B240D4BE44EC03B9029941B16AE3D243C8992A61396AF3F4E56FE1E64154E4261FB59CAFB93F52F107C7AC0B0EF307AE252F41F30972C641D8C4DEE61EEBC1D08B89F8A0F3F9286C2A68B3874580B4A4A8E9832451EAB579FC02D7D1FDCF18BC7B90BFAE83F703A2E5DD6C7F143D7F0E5673D317ED41CECDE7E02674F2A21E6C90BC446C723323C5A8CEA2711F54A4D4F13C2C7DF41E0C9723C792EAF209FAE17088FDB5E3031358796B62EB6EFD805B90D1BB170D112CC98F91D29DE3CCC5FBC041B89FA9D39730E9A9ADA540F43F23C2E70203A7BFBBE3F3C02FCE0F7F001029F84E2515C24829F3EC6E3B818BC7895267AA1464C980CA996ADA061688CC88404F2AE77E0171C007B0F6738B938C2C3D31D760EB670F3728785ADA5485D6EBBC2DAD196689C031DE74ADEC515FEC1A1F0BD1F8A03C7CFE3DBAE03D0FA9B1EE4853AE3DB4E933073F64E4C9CBC9968D44A01E9012BD1A9EB6CF4EAB78468D36A74EDB59002EF65E45114D0B7FF3274EE368782F1F5E8D86592585EBF6BF7F1D0BE698F07C191D0D537A0B63D8F3DFBB70965B87CF912ACAD2D919C9C28DEE0638BFC5B29C3CF41FC61C5F0F3F383BDBDBD188778F0E081A04DDCE3C4E53C32E8E4EC0A5FA23B3C8FC6D9C58DDCF91DB87BFAC3F30EB95652061FE2D5AE9E7E70F3B9075B174FA2029AB071748733B977F73B774599E2756DD8BBDFA5B22061D1D5F55D71E88C2E8E5F34C01A85538849AAA138C35C083DE90E29C75E1C39A78F03A774316FC53EDC7B9889A3E70DB07EDB45E859DEC3A27587C95384E1FA2D37ACDD741AF1E975E29C5BF65F41544C018C2D7CA1AA61839DFB2EE3E03115DC3276C780A133B063EF4574EA32064B49F9060C9A85E12317E06EC00B8C18B51097AF9AE29DF73A60FC84B524AC1E70757B828B974CD0B9EB58E2CCDB705DDD121F7DDA1572ABF64057CD025E2E0FE0EB1E085F8F005416D7A2BAAC16B164087CFDEEE041D07D189B1AE08AF2455CBD7601070EEFC1DEFDBB3079EA04C8C84CC74C12FEC3878FE2DA3555DCBC790BD7AFAB53407903CED4D626169682AE868484114D788ED8A7CF104B4689E736453F7B8EA81764AC5E3E15E9A35832469164D0A24244996FD01DB2BAD1B876430D3316CCA6D8C788E21E6F18D998C0D0C290BC803DDC48E0ED1DEDE07EDB8D9E932DDCBD3D44EAE0E6046D7D5D78DFF7A3A0D7102EDEBEC2C831051D326A3ACE5CD2C289B31AD8BCED1AB66C57C18E5D1A983D779FF00CED3ACA90D79C2B047FE0B035D4D66BD1BED31C7CFCD978B4FD663A060C5C8D71133662CC3839F4EA3D1EA3C7CCC3B9B36A3032B2818AAA1A2E2A9EC395ABE770C7DF8DA85D200A0B78AE122903A1B6B65A0C26371C36F8BD20FE646565414343438C00DEBD7B17DCE3E4E4E404575757787A7AE2DEBD7B62F0C4802C0EF73E9D3C75066A14CCDE343086B98D3D59176FE16AFDEE07C1C3EF2ECCEC1CB07BDF611C3E7E0A878E1DC7EE830749284F12773E0E6B276F0484C442DBC8195BF79DC7AE435770941A79E6820DD033F5C40AD90314F42A52901B81A56B77E38A9A99D83F76EA328444A6618DFC21EC38A0884B4487D66C3A066D133728695961D1DA5D30B2F2C1B6FD17B0F390224C2C7D7045C504874FA862BDC2116CDE7912418F1288FE78203DA70AFE01D170710F8291A91B51145FC43CCFC6BE839788F68423EC7122C501C9887F998794F452B8DD0E227A1148F48862ABEC32843F7989A497B9484B29C45DBF8770B4F78483DD6D9C3D7319AB57C94261E336AC91DD80D9F31760F18A25A494DBB1FFC85E6CDDB51932B3A6E1E295CB387AFC18799EF3C4996DC594EB172F13505A5E86AA9A6AF1D20EBF9FC006EA554626129EC72126EA099C1C1C2918B682DA0D7568DFD2829ED12DA869A9E3C499D33875EE2C94D5AE9111B80E3B675BB890850F78700FDE777DE14CD65F8738B97FE07D18199BC2D0C844D01356085B273B583BD8084F616C690A7B5747D83ADBC3D0CA1EBE818FE015F010BB0E5EC4E75F4BA343B7F1D8BCE30A66CDDB8E91A3653176FC060C19B60A1D3A4D43A76E33D1BBDF22A2456B85C768FBED0474EC3E1323C6AEC7CA3517B066DD0532065B3060F022F4EE3303FD7A4FC4CE6D276169EE0A5D1D23610C0202EE120B79868A4AEEE8A946DD6B9EC2518ADA9A0A2AFBF938E1B784F8C381B4878707CE9E3D8B53A74EC1C5855CB403B94FF21C96969662389C3D85A99905CCCC2D45A31A9898C3CCCA168E149831EC2800B47771872351021FA20656D6648DDC6F53A0769702B5DBF0F6F3A763DC45C0E6772F928261736CDD7F122715D5A0616085951B7611F53186DCF6C3E41D547041459BACFF6ED879F84345C798F66F878195337989FD90DF7908FB4F5FC38E23976060E389B35775317DC11AEC397609F397CBC3D8DA03BA06CE58B6663BD6C9EF27ECC5816397E1E11B022B472F98DB79C09682637D631B7878DF27B76D016B7B0F115CF29C239E2AF2342E41CC4EF5242F67606A010F1F3F122057A1DC874F9C266E7D4860E69CA598BF641514B6EDC186CD3BB1FBC0111C39799628C009EC3F74121BB76CA5727921ACCF5FC6899881638EC2E202A2556988880A87B7AF9780ADBD0D0C8CF46165632984D6D2D25C0C50797B90A726E5F1F723AFEBEE8AB047A144E7EE22302804EE1EDE224836B7A07BB9ED23BCB8BD8313F4F4F4C533F5268F6564664A4AED2D82751B6B67383B7AC3D9D505CEEE6E70707186B1B919CC6CAC88665A42DFD418AE5EB7E1E0711FF7429EE3FC557DB4FCB01BDEFFB00F468D5B8F0F3F194981F13411477CD37E0ADA77984AE964480F5C82C1C35761C09015982CB303D3E76EC17899F518471474D0B0E5F4BBC1907AB72B3EFEB437495D5B8C1FBD0826866E0824E3E4E71B8C18A2E02C8B125455F10B6795E0F5665931AA286DB8FFF7C40F190E32982E9D3B770E070E1C10C3E886C4F11CED1D70EBA69E1839E42175DEF6F6A40748DE8015C5CEDE1196563602122B64634B96865257370FA1487C2CE759A1ACAC6D058C2CEDA1A56F0A3B572FD1457AD3D812EEBE01E4DEED047FB57620B76EEF22A666F3546C1B076731DCCFD3972DADEC604A0AC9021BFD3C410483968E2EA490DEF0E0F7731F46D17E3B5CD7D48591392BAE37F1657FF8DE0D25457686A5AD1B3C7DC8A359DA91C7088681B10554D57561EF741B7A06E630B77224C13F237A852E5F5383BAF64DB290BB31691A59BE71E3D0BE4B1748BDF30E3E6BDB161F7CF6193E69DD968247EEFE6C45E5EFA3E5079F40EAFDF7F0FE471FA073CFEEE8D4A31B71FB77D143BA0F66CC9D8DEB5A1AC4DBED1116194EDE2B0C810F4391989E8A172949888C7D8AB8248AD79EC79295F7838BA78780BDABB3C04D2303EC3B720867CF13E7BE7A057AFAB7283EA0B6F1F1263AE440CA642582675B7B3B523043B18FCB9C5D9D606E69066B5B2B114FB8BA39C0C1C916AEEE2EA2BBDDD4D246DCB71705D41A5A26B8171C839DFBCFE3E32F7A9217984071C04A7CF9D50448F75B818E9DE6A277EF351838703DC68CDD86A932BB450FD4C8D1DF53FC308FE2852974DC7768F3E550BCDFAA1BDE79E75B7CF26977F4959E886D5B8F2324388E44EEA7C2D8106565257FDABBF93F29080A0AA2A04E13674E9135DCBC05870F1E828E96B61824E194FB8655AFA99025D28396969600E70D0D0D616A6A0A636363DCBA754BE4D9D5F3642C9E886563438D2E86ED8D0458A84DE841387B78092B6C65EF44BCF60ECCAC89E7526A4F9EC72F20105A37C972DAD9E3EEBDFB42C15CC9BA3D7CFC48D0031BA2131EDE3E70F1B84D96BFFEF73E77EFC3F7DE03A20CB791949181CABA3A318583AD338F88F300237783B2C52EA9A89F135549411C4F43E191F780A050521A07285F57C3CEBDFB3061CA54F492EE4BB46004A407F5C3909143B170D92274EBD51303870EC1B45933B174E52AF21873F1C917ADD1EAC38FF0CEFBFFA4F403A213D298B3603EA64C9F866F3B7722856981F7FED10AEA5A9A747F4EF0F1F7A37BB0879EA101DDA32DEC9C1C299630275AAA4F9ED85858782EF7F4F5C1839060DC7D705F587EFFFB0182DEB21737313181999999685F6E6FCEB397E73890DB99A93097595991973733A16D7B62001448DB92A73737121EC9DCD2823C0C291E190557F2CCDE778288EA5DA0786014BEFE7624BAF79A8E41E401860E5F878183D660F294DD183592A8D3E0B5E8D9632EFAF65D80AE5D65D0FEDBB1A430E3F1C187BDC83374C1C021D3B079CB3152C27BC8CCE2EFCB51633790351E3F68D87D5A4E8AC0906CFF59107F983E351CC4E360263438440C906CDAA880E3478F8901129E80C51E444FF726D4D554A1A9A10EBD9B3AB8A5A70B1D6D4D6869DE80060577D755AFC1CC94AC14056E76C455198EC45B8D89036B69AAE1A62E09055935E6D33CC98B1F0AA7D6B636302557CE96CD92F2FCF0CD2C4CA9CC047E77EFD083B327AF6349D4C18BBC863B51068A69087676C489AD886AD859C38E84EC1609951DF1E272E2A2B514A4E59714A08C787A6E610129408D5004E6EFFC3A25F70EF17BD43CF6C2D3DB79862F7774F031FC1BE6EC03870D221E3D136BE5D660E6DCE94497E662C9B28558B66231059933D147BA373E6FFD19DA7EFD25FA0F1C80366DBFC4B71D3BA077DF3E442DDA41AA85143EFBE2731C3A72182161A1E215CE9867B1228E781A1B83A8E827E275CEECDC1CF062005939D9A2978A6783B2D577BFED41F7EF2F0C02B79B3F51D23B4487ECACACA1A7AD03751555DCD2D115DB4E64405CC858D85BDBC0C4C0101E2EAE70B0B18533790E3B2B4B41C32C4D4DA0473189B189BE68376E6F53332BDCD237C12D43F69A7AF8EAEB11F8A2F5104C9A248776ED26A003D1A4A953B6A253C7E9E8DA6536BE6C330C2DA43AE3837FF6469B36834892BE22B4C1D8710B7055495FBC97C15356B8CB99DB92DB94EF8D177460F0601A2B058F2EB3CC31249FF8927C215502F6181C647377E9CF8D2FFC56107FB8F7293D3DFD275F7461444545E1FCF9F358B66C19E4E5E545CCA1AACA0F4113E6C606B021A1B5A38675201E6C4DC2CB7071B08585A9016E6AAB0BE8E9DC80B1812E1C49A019B656A630A1FD169626F4300C8560F3008D93B39D107C5737475210A25DF656C4B56F8B1E1C43A39BA40844A9C8C219E8EBC0CBC3113E9E441B3C9CE1E64A54808E75777382270595068637E1449EA4BCBA4A3C90625200F60645653CD5BC9ACA6BC43B1EFC52134F75E73741F90D515E4DAE821F223DC0E7712FC5988C9FFF3DA20632983643062B572FC3CCEFA64166C624A20D433178485F0C19DA1FE3C68FC4F419933165EA04DA1E80D66D3EC5279F7C82F7DE7B0F2D5AB4C0A851A3C4CC80478F1E89C967DC71C17427802C3F2F451FF9244ABC25C7E097FF935292F138225C2881A6B616AEA9AA404B475B4059E51A2E5D5684BEB62E4C6E19C0CCC0081A2AD771F9DC055CBFAA0C638A259C6CC8DB3A52EC4034D68DE20BA39BB7604E9EDCCC809E17790D5BF2D86C5CAC6DCCA1AFAF478A4141B68919B4B4F5E859D8E2BD569F90D51F856EDD2711E59941F7390F9DBB8C47CBF7BB0ABCF36E27BCFBDED7E8D1730C64D7EFC3B1134A38724C112EEE7ED46264F1859CD7CB8F4411F87DE9A2E23C51CE5F306AD88B54CADFBA2BFE71525EF59BE581FE2C34592841C389823CB8C16318FCD2C6E9D3A7B177E7361C39B017674F1E83AAD265E86A92026891F0EB934092C5BECD82CDC24EC26D667C0BB7743560490A60C52E9B520B7363D8DA58080FC279067B12869525D1305204DD9BA478740E562056046B52268639FDDEC6DC10B61646B030D68383B539ECACCD606AA427AEC95ECAC6D649083AA3B4AC1A0505649D8AABC5DB766565AF91995980ECEC522AE36DA25225AF91965688A2A2D764958094945CF122928D8D0B29C024A20C32E415E6608ACC644C9E3A0953A68CC2F4E9E33075EA584C9E3C9AF213304D6622A4FBF640BB6FDAA06F6F698C193516F2721BC9D39E20DA7909FBF6EC274ABA0D8A172FE3C2B9F362AE0ECFDBE1988DA9A99AEA75919A18D13D8829D1BAD050E7F703D48597E663D589D6B107BF7AE1122E9D3907A58B8A5057568181CE4D589B9AC382623956829B1A5A42715849B4AEABD37EF2E8447519DA4467D5D5AE414DFD9A988A6D6B4B14CDCB077BF71DC2471F7F8E4E9D7B90428C20E9A0D8E89DCF45FA459B2E18336E1656AFDD42C6CA0BD151093FC8C6CFA1BCE24719AA6AF0EDEC86A8F7044DEFFB33D064E1BF03BBBDBCAC0CDCF5F522F74D94EACA255CBD745EE0D2B9D33879F410D454AE405DF52A4CC86A9B939BE6549F849CCB35D49405E5D2D5A10777EBA6A06026C686B0B43023E520CF636B2DF831F77A99981891F2589127B0150AC39E88BD9289BEAE50062B520033C35BB030A1DF9B1AC18C824B2D757E99C459AC18979F5F2EBED6FFEC590A79C30252862212FE7C2427124549CAC1AB8C2264A41520E9650ED2530B91995E8CACCC324A0BC11FEEB4B773C3BEBD87C454663608478F1EC606F9EFB17D8B2C4E1DDF87DD3B14B068FE4CAC5ABE0097CE9FC0954B67A174F93C743574A85EA654477B525C73981A9017258A6267497CDEDC1A3644759C290EB2B624EA624C710129012B83B1A1110C6EE9435FEF96E8E8E032DECF29C3CAC2524C7873B4B6154A606E682C849F954002560A56126DB51BD0D3D416A9EE8D1BD051572705B90EC5B36771E5F205D1EE3C38C62FE04C99328502E2F7C80BB4148AD1BD573F6C50D8060DED5BB8171822DE2AE467CFD3ED393E63372A59B482E9371B4DC97294BFB4A7A8E167821BA2BAEA8FEB696A0A4D164AC04150613EF1F0F29FD762FECC6B4870A0E83E64E13620977C5D5509A74F1DC3D93327A0AA7255C4129C5E563C4F71872A09D84DA2615446D0A687CA5D88064405B4B47470E3862694AFAA9255D4C4D5CBD770F9D215A85C21CBA64C9694621B017AC07A9A9A0237C9BA32B7D6A758474B439B7EA344D7BB295676781245DC3D3E09F171494849CE14E9D3E838B18F5FD2E7394051913178FC885FDE7F8AC00761F0F6F2C7FD8060BC7A952D025556CCC4A438444486502CF088E2823B08BCE789E0005F04DDF3C1E390004AEF90B01BE3E8813DB8C602A7A90B5F0F6F18EAEA434D89E22FD51B64D1AF93709247A0ED6B57AE928755C6958B6C5014A1764D05DAEC0D085C7E83BC86267B8837E0B841E5AA9200E7AF2B5FFB01BCAD4B5E84C1BF6570195F8353FEBDAEA606B59326B5918E301A1CF7295DBD2C70E8D021ECDCB9939E83365E24FCFC4A183C86C2B452045FF4BFA911E6FF44A8F99BD68DCBFE2C3459F8DF8083A5BCDC6CF8787B8AF92A17CE9F85A1C12DA24976448B381ED013D0D5D12717AE0565A5EBB8A14E827C4545E4D5481134354849740CA1AD41B44293A80041E70659434D3D014D154D61FDAE292A0945D1208163A5B9C6BF57D5106F5EC9C9C9D283DE4E0F5A13BEBEBE62849E531E2DF6F4F416718B15512EFFBB3E54EE0D0F0F3711B0F331818181080D0942705000E4D6AFC18001DD31556604868FE889458B275360DD1673A64DC48635CBB07ED5122C9F3F0733268EC3C881FDD0A3433B6C965D07958B57A14BF772F9F405289E22434075D3A3FBD4545683A1969EB0E03AEA1A22656BCFB101C708A6FA863FEC63B0E5D72523516FEDEB53D52B4AA2C383A91543991445891480678C9E3F7B4E6C4BDE4C630A664401371B2C6E7F7E0E9EB7DD11F3F4094A4BEA179FFBB5E0F7ECCBC960563552889A8A52D451FCD0B0ECAF88260B7F09243D013C678ADD67E3FDEC4AF95B008D57782E2CCC27FA9282E7B1CF10151189B09050D1D3C569E0FD07F0BACDA3C3F6A2AB91C15DBBDCA5686161212815773D32076670D7A3649051029EE6CEA3F2DBB76D81CCD4C950BC748168970151052D014B0B1341C36E19109DD0BD21024D43124A9E66614081E84D3D2D5CBE721E274E1E117DF99BB7ACA760B31BC51463D07F404F74E9FA2D468D1E86EEDD3AE2BD77A5D0829AF09FFF78175F7FF505162F9A4B546B0729B612511D53A23AFCC20B09B9EE2D589A5B8932F664FCE28B8A8A3214152FE2CC99533875EA044E9E3C2ED2B3674FE3E2C5F34469AEE20A09BF921279038A09D8834ABC29D7D78402633B3B07BA5F0FDCB9E32FA68384863E44787824121393919D998F82DC1294F33BB10DDA9FF14BAC7245397751D4E7F95B13BC3A06CFA0E6F1833F62D9D13F134D16360607DC2CF8DC63C03D540C9E415BCBAF793608C619FF4A49FE68B045DC40DE82E3166D2D0D41E5CE9D3D49DB1A44192EE1F889033879EAA89874A64C81EA050A5CB987E81229D1A9D3C784C0BAB83A60D9F28578BF95D41BB4402B5200296AB6AFDA7E819933A68AF36567A58BA9088DEBF0BF8CF28A6254569536394056552908D25B65FF9FD064E12F010B3E2B4463A568AC10DCABC0D6A5845C35A70DF7FD9E608AB062F9521C3CB00F0A1B37100D5A8B8DF2B2D8BB67074E1C3F8C1D3BB7601B79933D7BF660EFDEFDD8BA6527B66FDF29F8F5B163C7C4F227C78F1F47A74E1DD096BCC042F202870E1D108366ACF892EB348CB7F8E3861C8749FADE996F37EC8797A0A9B23F1ADCEDC90171BD47E78FBDFFB594FAF7449385FF0AAC004C997EAE01FF88C1955F028E69E6CC9E05D9EFD76293823CF6EFDB2514E2FB75ABB079D3066C64459193C3E6CD9B29F6D84DE956C8CACA61DD3A59019EC53A61C2242C5AB488A849FDDAA44D2127EBA70B28FF9A25281915153CFBB382DAF5B751969F9B1EC16304F5F8CF95A0B121FCBBA1C9C2DF1B7F84557220FAD4BFBF34468C18869933A763D2E47158BE6231162C9C83D9736660C1820598366D1A264D9A80C993279312C8D07133B170E162AC5CB91AAB577D4F54EAB2189B919CB3DEA2BEF1026FD2866BE9FE99F835FDFCFF1F3E20F3DFA0C9C2BF0398165858985170AA8B6BD794B0759B020E1FD98FFD07768BF4C8914322A0D5BBA50D4F2F373C890E477A7AAA08266B6A78FEBEE0D5A8ABAB2345F8B1B3E0CD728C3FB9DE9F8D3F7B14F8EF84260BFFEA6021E61E927AEBF95AA0F635F7AF5783034C9EBCCDFB5ED75511CA05EA179EA92625A8151F1AE17FECD1EAA9480D7E4EE87E0D9D681C9037FC4AD12FB5E04D1DF76BADFFCF51ACFFEF68B2F0AF88860FB9BECBF03559FCAA37424E2081672560019728082B017F86AAAC221B95D505147816A3A8A8402C19CA6B0071973207A3A565BCAFF4671583F16BA72A48F87DE372C6CFEDFB3DF06B95EAEF8C260BFF2AA87D5D4F6BEADFD4FAB19C8599158115851584F32CD4752823252001AFAD7FCD915780E273D4D695A0B43CE75709212B53E3B286A84331AA6A0AC5F925654D59671646EE1A6D5CFE73F8A5022CA17A7CEF92B286E015BA1B9735E32FAC148D05A361AF5739AF3D49FF9806716CC034882955ED6B9EB65C40EA504FA1AA6B48496A9B161816E6E2923CE4E665A2ACFCC7915FC9ECCED76219B37A2E2FA14F0D695475ED8F9F916A585749BEB12234BE1FDEFEB939446FDFEF2F53E6C6D76846D368B2F0AF8A4A5E07F24D9E059403E6B7FFB12294080BCED489059F95A4A22A5F94317DA27FE2F7BCAFA4F45F7FAFEEE73C055BE67AC56341E42F31FDA800FF8A824904FB3FE9EE6C386ED214249EF45F798C66BC8D260BFFAA60819208556151AE98A32F02EAD735229EA8ACE2C1430AAC49602BAB8A7E08B0C99788943D095BD39252FEF400512FF19E30096C45D15B56BBE1DC7F4659F9DBDBAC08F58AF7639904F581FE8FDB8DDF6191D4FF9758FFC60AD478A1E086685847F690927C7D9BFC785C732FD65F5429041D22EBD730182D2A66AB5E8D82C2FAAF629657BC099CA99C8F61C12FABC8A5945778AD7F299E630A168A7A5AC1FCBA5E79F20B28F026859058567E398683F38282FA976444AF14094F71493D45629AF5735698A90EBF03CF429B9393F5A607EC6D0AD418BCC20AA78D8F69A82C92AFC9727D78EA362F7CCDDB4CF11A2A5FFD4A183562450CAE2753422EE77B2C2DABFF8D04CD4A01A9FF03ECA1A195B628BB7B0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A310'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000C50000004D080600000016DBA045000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000043DC49444154785EED5D075816C7D6C624C67BD3138D4934F62EF6DE2BB6D87B378888BDF7DE15150441AA48EFBD234D5094AA52445010E920BD77E4FDCF19FC1224DCDCE4DE949BFCF8F832B3B3FBEDCECE9EF29E99D9592900CD6846331AA0C9C26634E3FF339A2C6C4633FE3FA3C9C26634E3EF82AA8A4A4A9ADED71095953F1EF7939DCD68C6DF01A525F9A8A92EA7ECDBE51555E5282D2F41456D390A4AF39193F70A7905D928292D10282B2F7AFB07CD68C65F0565A55560342EFFA528AFA943551D504B1B95D555282C2EA05C0D5ED75634FD836634E37F1D458565282EFAA9276054D7D4973F8A788ACBCA3AD0D57381B94500AEA93940DFD8173AB7DCA1AC6606431357A8DE3084AABA1EE62F588AD2D2721417367B8A66FC4551515E8BF2B26ACAD66F575696A3ACAC44D09F82C26C78FB0762EA8CC514207C892FBF1E8B6123BEC737DFCEA0ED9E78E7FD7E78FF9FBD29DF1E2D5B75A6F40B8C1C21836A0E2B5E37B848339AF157416565352ACADE0EA00B4B72416C48A0B0B016B2DFEFC2071F7543976EB3B06CD515CC5D7405C3C7ECC7B8C9473076C2018C9BB81DE3C7EFC2E0FEDFE31FEFF581AD95975008A6506F5DAC19CDF82BA186F8BF48EB2A48195EA3BA06C8CEADC19AB57BF065DB61A414433077E119AC9333C0D849673165C665CC9CA784AF3AACC48851DBD0A7CF5AB46D3D05AD3F1D047234A8AB7D8DBCFCACA62FD68C66FCAFA3B8248F926A94125DCAC9CB45417115222253A1A46C85162D7AE0E34F2761E2942358BA5A07E3A65DC1381965F41C70106D3AC862E20C450C1CB80DC3866DC547FF1C864D1B4F50804D01774519EAEA6A9BBE60339AF1BF889ADA52D4BC2E466D5D092AAAF251FDBA5C7888E72F92919D570745252B8A0FFA60E67747D1AEF32AF41AB8036B15ACB0689D39068E3D8709B3AF63F29C6BE8D26F2BBA7695C388115BF1CDD763F02C369D4E0F118FD4D434D3A766FC45515E5588A2927CC42726A184589491D91DBCDBAA1F264CD9838F3E9541F7015BB079BF2314F63BA143FF6DF8A2AB2C46CE388701E30FA253BFF5183E7C0FFEF9C1284C9FBE8E4E07A9D2D26291161717377DC16634E37F093CDA5C5E5E2A2C7951719EE0FDB984DABAD7484ACD464A6635821E6651202D8B773E188DBE833762D1F73720BFDF1213175C4487419B3170EA618C9F77167DC76CC38071DBD0ADC752F22A1D6168EC4097A06B54958A94F1930A34A319FFEBA8AAAAA1A0FAB518787B18F182142205418F73B0EF9821A4FE391432F38F63EF5937CC5C71155FF65C857E93F661DA4A250C9D76085D07ADC7C0F13BF165BB3168DB7E009DE1C7F35694D58F6FBC75B16634E3AF80D2922AD1F5BA70C95AA86998E37962053CFD13E0753F1307CF5A6289DC65ACDEA64F74E918BEE8B61C83A71DC6B8B967D06BE436F41AB61923A61C448B561D70ECAC129D055245A51CB413252BADEFCD6AF2A2CD68C69F89A2A22294961451F6C7B29292320AA853111D9F8E5C623A372DFCF069BB5158A9A0888088623C882E41F0F30AF83C2CC4CC65E7D075A43C3EEBB40C43271DC2B4E597D169C4767CDC6303864C3D822F3A4F83D43B5FA040380652B2AA32B06254549688EDB72AD38C66FC5968384BB531AA4968ABAA2A50585A86ECE232E4965563B48C2CE6AD3E8165728AB8611888C47CE0C1D30A78879660E2DC9368D96E063EEDB81C33975C13B144BBC19BF0EDE0DD4229A45AF5C5049945282AA3B33771BD9F1434A319FF4BA8E2691BF9D92828C84349453559F75A528A5A1CB9688513979D3077C505528E0BB86E701FC7AE3861DDF69B983CEF02A6AF52C28C65D7317D8132FA8EDE8D5EE30EA0D7D8A3E83D7C2B5A7C38004E6EFE74FAFA6B94570AED10F992A2E6DEA766FC0FA0AAAAE9D9AEAFAB4B504B025B5A5C8294946C443D4D836FC07358D8071365AAC5C8A9FBF06DEF55E8DC7F153EFA662A64169FC4188A2396CAEAE3A27628AEEBC561ECD4F3F8A4DD12F41D73005D87ECC6BB9F4E4677E999A89F25C28380449D4A0A459E515A5AFAD38A34A3197F04AA890E35CC5794970A54F17C0B2A2B2FCF4546C64BA4A7A68939495ADA76E8D5772E96AFBB82D397BCB1EB843D36EC36C584D9A7F065B70578AFF5380AA265D19368D2898B4150BE158923E7EEA277FF5D983A5711BB4E7A62FCAC0B449D86C3C4F20E6A6AEB50525A4E0A513F3ED1106F6D34A319FF0B6025494D7B81575969623E93A6B6055AFEB32749AB34C6CA1C83C21E07EC3FEF86EB46D138ACE889D9AB2E60C4F4ADE831640D068CD909E9E1FB307DD9654C9EA5883113CF4061BB25D66C322085D9824FDB8C415A46095EBFAE4145459918FF687CFDB7369AD18C3F123CD788C14A5023E66DD797B3B7088B084554CC53904EC0D3EF1196AC3E84C1E337A0F3A0F5909EB81F3B4E39C0C02109EE4165707990039780341C386789F9AB95D1A98F02BEE9B5021F7FB918DD7A6DC2D2D51A901EB60D2D3F9A84956B4EA0964F5A5725DECC63EF24B9AE046F6D34A3197F245820EBC862333FE27C5969318A8B0A90929C087E5382DF8CCB2FAB4136319C8088541CBC6482692B4F62ECA2E358BE45074795BC60E69E82F064203CA90E2EF7527159E301864D388221938836115D92997601CBD7DCC037DD56E08B76B311FC308BCE0C5456169242FE943A71D7EF5B05CD68C61F01F60A151515282DE30097AC75552E8A4AB3282525A112DA0577BF97D034F087AB4F1292728017B98063E04BDC74790AF953D6F84EF63A86CF398C390A57217FD200DBCF9B63E5F61B98B3EA3296AED7C0DE335EB8AEFF14CA5A0FA1B0530F5D7B7F0799596BC52878597925788E13D7A5293459D88C66FC9E607AC47CBEA6B69C7C443151A42264E4A680FBA0D86FE8E9BBA053EFF9F8E8CB4998BBEC0C8E29DAC0C4350A0F93EB60EC938C2337EE62F90E3DF49CB8199F4BCF43CBCE1320F5D940BCDF6E22BA0C5A8D550A9AD87DDC1DBB8E3A62F6524574EDB318ADBF1E2146BF4BCAF90A3FD68595B3A4A47ED04E821F32CD68C6EF89A6969A292ACA42755D21F24AD2915998033EC2C0EA3EBEE932131F7D3D075F755E8EAED27290FA780CBE955E84459B953173FD15AC3B6C8519DFAB60ECE253183C773F7A4C94C3D78316417AB20226CC3F8AD55B3421BFCB025DA465F1E957D3D0A29534264E5B8BA7CFD3E80A6FD7A121CACAEAC72B9ADCD98C66FC9E9058E69AEA328E2690999F89CCE2722411451A384E015D07CA437AC441F418B417DD06EC44A77E1BD0BEDF0AB4EBBF1C23E79EC494952A98BD5E174BB71B62D55E637C7FC8045BCFD860DB492BEC3BEF8C2D07CCA0B0C3083DFAAFC1E8C99BF1DDFC1D30307313D7E4E56D3895284043F01805A76F1536A319BF357860AEA080978FA9DF66BA22C973CF53E8C330419B52F381F96B4E61F3016B2C9133C2B20D5698BA4093ACFD6E741FB41D7D466E46DB5E4BD171C8467CD14B1693976862F1268A23765842EE903D8E28FBE3B46A008E5FF6C51A859BE8356015BEE928831973B6E24E402C4ADF0CD6E59347E2F4E7D06461339AF1DFA2BAF26DEECEA8AAA8465E0E493FE50BF2F2E1E6EA891A3A2C26BE009B76A8E0F4554F4C5F7015CBE58CB1E07B43ACDD6A8F151BCCB06EB309E4771B62B9FC754C987D1AB2BBAC317B9501662CD3C12279636C39E28AE50AB73074D27EB4EFB102D243E521F54E0F2C5ABE1F7EF79F2139BD0849A9AFC4757F099A2C6C4633FE5BB002342E6B88AC577962A43A3B1B9830411E4386C94366D669EC3DE68A6DFB1D20BFCF1EF3576963E50643C86E35C0CC05A7F0FD562D6CDD6F852DFB1CB15AC1141B76DA92F268A3DF38F226433660B4CC1E74E9BD082D3F1884390BB6C0C93D14390535C8CA7D7BC6EDBF439385CD68C66F85D2E2B29F2C471315F144AC4513F3341DDFB61F8B775B0CC2EC39E7D1A1D32ACC9A7711A3271DC2C2F51A9834F73C56CBDFC2D1336E984341F5945907B06DAF3916AFD1C2EC654A68DD7109DEFB7C1A7A93428D9DB1076D3A4EC1475F0C41AF7EDF212EA11055B580DB6D3F24F2549137D7FEB9AE58099A2C6C4633FE5BF0DA4C0DB7B99729AB20198F9F840B618D7B017CD3610C3E6FDB1763C6AF41BF7E72E8DD6B3D5ABC3304FFFC6004DAB79B8E5E3D17A075EB91F8E4F341E8DB7F0E060F5B8C162D7B43EABD3E18366615FEF1C9207CD27A2C7AF45D82612365F16EABBE68FBED08F807C58167A23F7AF414A1611128AFA8A7728585854D4EEB688C260BFF08340CB89AF1F740C37722F2F3735158580C7E7594B773F2D349194AF09A3C447C7C26DA771882B5EBB7A38CA2ECDBDE0F4912BFC23499DD387FCE013574CCE3C7A570757D86EE3D6468DF375055B381BBD7137CFEE5206CDFAD8CB0C84CA453CC6C6CF18002EA71A42C5DD17FF077B81F1A8772523A2FAF7B080A7E84EC9C1F67C0FE523459D88C66FC37282F2F7F3385A2462C30F6FCF9737077671D093BF78476ECD01F1F7CD45E8C2ED311C8CEADC4471FF647FFFEB3C00E4666DA4AD858879055070C0C3CE0E41C2426063AB93EC0BBEF7F03626450D53486B5E31DA4BFAA41A7AEC33168A80C6CEDBDC539135333E0E9E587A827CF68EBEDBAF1A021A37179433459F847E0FF93A7E095EC24ABD9FD9DD1F8ED395E0E3F252919810F42514BC25E5C58877163E7E2837F742441BF8F626232878E280A8197969E8616525DD1B6ED10ACDFB01B115159F0B8FD085F12BD3235F340C6AB0A2C59B601172EA9A38602F496AD5AA3579F11282A01162C5A0F531327BCA6723FFFFB887D16870781A1888B4FFCA13E393939C8CBCB13D34B2465FF0A4D16FE11C8CDCDA5A43ECF96850774B8C28D5F38A9AEAE04A361D95F01556F56BEE6B49A14A2FCCDFBBF9CE7F4D7E0AFA05485C53FF6F0F0D2F6BC685960D05D444444895E265E5669D9E29D7857AA3D3AB61F815AF21A3B769DC4BCF9F22079C5F4E9721840718394D4D758B14A01092995C8CCA29349B5468FDE63514AC67DC6AC65B0B1F11073A3A4A43E214A65843252ACE0A0581416BCC66DF7BB7899900EBF3BF749298291C1277853A7866325FF0E4D16FED66041672B220197351C51FC576F5EFD37E055A87F0E8D8FFFAD51595D2FC4FC91104EF995C7B28A52F1C110DEFE3BA0A0A810252495155564B86A6B48F12BC4B71E325E6522303800AC284C99D2D2ABB174C9417CFCE110B46CD90BAE6E91A8249E131B9725C094E9F46953E81BB98AB94F4386CB20310D78F2AC9C628821D8BAF3AAF00E4386CE80FFBD48E4E6D760D5EA5D080E4940467A05820263F02AB30CC1814F90109F015FEF403C8B7B4E676ABADEFF0E4D16FE11C8CFCF17DE815D1AAFDEC06592B4B11BFEAB81854392E7754E25F9BF33D232D2F13C3E4E2844726A8A10EE4A12E407214F499817E2DDF706A153E779183A7C0DB2F3010B7B7F0C19350F2BD69C41122980C2F68B387EC600E1D1C528A5DF05841562C2F46D906A290D43D350BC226FC28B9775EA320A5EDEE1449172919B078484C5E18EFF434446C6232AEA05E2E252E0ECEC859CBC6CAAC1DB756443CC72D7B8BC319A2CFC2DF0EFAC7F53DC2E35359582ABDFDF8AFFDE28ABA8BF87FC822244464583DF0396ECFB3B4062B4F20B0B10F7221E2969A948487C89F8841714279408C528254F101D9F8A6163BE43AB0FA4D1BBEF6A8C1EBB130387ACC690914BD0AEF31492BEDE68F5E1588C9B78102DDE1B8B0F3E1D8D1ED2B3D19282EE8FDB4E46EBF6B3F0695B19BCF3FE508C182D8796FF90C6F4EF3641AA453B58DBF9E071D44B4202799B64443D8DC3E3C818DCA7F8E5EEBD20513F89976E885F225F4D16FE1A48BADC186565FF39EFCDCECA87AFCF5D84863C46159B182A2B29AD426111D19DAA3A9495D720BFA014E515DCBFD0F4399A02CF9DE7342B3B97CE53F396804AFAAF45BEBAFE9ABF14E5FC064C13E53C905B3F980B291E34F2BAE34796502CE02B959D5FCF6BCB39B2A4B4E0CDFBC1BC5D51537F5FC5E53F1A933251253A674D1D4A2BEBCB2B1AF5FF3786E47E1B83294EC3EDC6D3309A9A96F1AF90F8321529A9E9080D0B4762523A8A8A2B505C568DF4AC6CE414E6A21A55088FCCC0B4E9F2F8E4B3911837610FC68E3F88DEFDB6A0475F79BCFBC164741BBC0E53E79F81F4889DE24DB9BE4376A3E74005F41A228B763D17A0E7B0F5E83B721B068CDA87AF3AACC69419A7D0B9C77C48BDDF11C696EEC8CB294768F013B8BBFAE1AE7F301C1DDC101BF3028F1E46223EEEC700FB3F4193858CC614E6B7E0FDA5A434B97905C8CEC9C3CBC454E29A59D4B899D4B069629B7B0E1E3E8A14E549C919E42213683B0A6174A39C4646C52226966EFCF11344443E115698D3E8A7B174CC63D1EBF0E871049EC63C13E76184474413F77C24D2C7E14FE8B80891E773F0F9787027E2091D1F4EC751FEF1935804D2C3E64F437159181D1742D767703E94EAC179DE174EBFBF47964952C6FBB93C20300C914F9F2130F4119CDC6E23F86138A2629EE37E70181E45462328EC31421F87232C3C020F2322294FE77F14518F37D7BA1BF250D423E431DD7F049D97F088F27CBF8CD0B047E25EB90DC229987DF888EAFCE6DE793B2824980433028FC21F232838541CC7C770AF0C0B7338D795EE372498DA86F21154EF07F743041ED3FDF03192B68A8C8A11BF0B0CA2FBA27C6ADA2B3C7B9180CC9C5C1494949342D7E1555E1132730B515AF59A008C1EB71AEF12F5E9D0693EBA765F8BB6ED96A34BAF8DE421D660E0A83DF8ACC3427CDE7129A45AC9E083368BD073D00E74ECBD169F7F3B0B9F77988AB6DDE68A553AFA8DD8867F7C3A9D247530BEED3C0DD60E0FF0903CC4B39864383978D13D3CA1403B1C66A6D65057D3C6DE3D07914C8A9A96CE72958284974942E6E2E213F02AEBDF4F06643459F89F80AD305BA9BCFC425109AED4CBC4645199E7712F449E2BC916869522E1650A7901E27805252828E4C573AB51525A890A8AC06AC942F2000E1B6FB6BA6C95F9E59032F2209CCF258F9157480A56502EBE4BC0794E79BBA8B4E6079456D4D1F1404E7E9948B92CBFA812D979A5282CAC4429F978FE6D7159AD404E61394A2AE9FC451522CF69764199006F67E597D2C32F1129D72183BC5B3E79B2BCC232E2BC85C25A66E7150B149317620129A2FBE2B484EE2B97EE37AF98CF5B8694F46CF15BFE5D4E3E9D3397684756210A4BAA91995D8482D26A712DAE03A705648DF99A99D905E2B7C9E9AF9053502CFAE439CF6B22712A417E71195E24A5222BAF9084371FC96959E25A7C1EFE7D5A66BE005F93AFC7487FC5E7CEA5E38A858067E41420890C14A769597948A760209E0C18E79333B2905F5A8A68A24C010FC39040D7649E40CD891973379000CF4787CE8B892AED41A76EB4DD6503BAF7DB818FBF5C820E3D36A093F426B4EDF23DA4871D40FBEE1B493116E2B36FE7E1937653D065C03C48BDD71352FF18888F5A4F26859A256897B97510A839504DB251515E27C00EB0869D273B6E515E23B6F9FB75927F1919AF50405496994C717129929353F1E2C50B317E929898F8936EDAB704FB3F45115D289D2ECC421F13FB1CC92969623BF35536097E09D843D4D4D24DF06799083CAA19F7321945659562B0851F203BEFC2D20AF170D3B372459EAD506E6189D8CFF9ECFC2221084C31783A4D6149AD10F682625618D0C32C2545A0F3155593A012F5A2FDBCAF8822B79CFC0AB14DA721E1AD4335351C2B094F39E0B4B08C85987E5B524502FD5A0865112FBC454F81CB5859F8182EE3E3B8EE5C2FAE2F83EBC575E47A733E339794839489CFC3F9F4EC4221DC9C4A148ECFC7FB73A9AE7954E757B96562D5BA4CA206F9546F9EEE9C915D426575A44C953FFC867F9F57440A9A5B20C079BE66525A269806B222B0A23252337284C16043C048CDA0DF503B6512D2B38AC5B5399F42E55C0706E753B2F3904BF792416D9E4EE7132BF3D13683F7A5B1F12BAFA0948E2B2F130A919A5307B9CD8AC4F97B61E0D0BD183BE934FA0EDC836EBD7662C0F0631834F2187989231834E6307A0FDE8BAF3A6FC0F009E73064EC7174959647FB9E8BD1BAF3248C98B606078E6BE39A8633868E5E89CFDB8E206F9A239E756C7C063D4732BED4A6AC0425D42ED56428997EC7505CC1D4DBEF4E00EEDFBF0F777777E8E8E8E0C8912302FBF6EDC3A64D9B202727875DBB7689EDCB972FC3DBDB1BAF5EFD388BF62702CE60AAC4831D9C728F50E33E5E0E565E91B5887DF68294205EA4BCCD56BEB8A442087D19491B77BBB1564B0487859A8589DD2D5B3CB67CEC0D9EC4C40BABC9D68C9584E96D29FD61E1E707CEBF919C8795847F4F06971E7EB99826C0F942127CCEB30071A8904DFB583918AC18AC14E9AF8A844270E3B24566AFC10AC14AC002C70687858F9C86103E5604E115689F500452083E96DF682CA43ABD22616164D17D719A4782534427AFCF570AE165856265902888B0FA94B2C0B350729D5333C9CBD03DBCCA25052C7E4D6925D25EB13280AC7EBE68C7E8676444E8FA2F53B3C81ABF269A174375A176A5764A2323C27560EBCD690109EE8BC40CA28571C20372CAC6800D406C1C798F9C0AD0AD2333BF5CE05501097F1E79BB376952660152738B904737CAA0E643262958360B236DF3B295B9C40A1232B3905648DE8DF6BF482FC584991B20D57220FA0FDD48F1C33EF41F7614BD06EC479F410709FBD14D7A3B7AF4DF8EAEFDB662CC9473E8475EE29B2E7244A9D661C8E81D58BFF53A340D3D61EF150A1BC700D8BB048A6E5A2FDFC7080C8E454252966015D1314F1170F73EEC6D1D6067630F6343336869E8E2DC998BB8AE720337D4B4A0A2A22270F5EA55282B2B0BE157535383B5B535141515D1A64D1BD8D9D9D1137F5BF67FD162680D6715B236B1DB4948A0889F148129502E7149A641AC108C2C72B15CF6EC4522591C8A0DC87AB11BE7FCCB9474A12C2CE0EC82995A30EA85AC0A1C43735A4012C3D64042974A69073D7FB1CDD68F29000B270B2CA72C2C120BCF793E1FD32DA6600C3E172B1BD306C979994AF079D35FE589E3F3499999E614939696D08FB85E544CE764A5A140984EC0D4272BBF98849DE81BE5392DA39BE1FD7C3C5324DEE63C7FB8931589EBC4CAC5BF975033AE2BC9AD78C87C5F2F93B3C1F1310B2B8FF2F2B48702F26A6CB539CD268526638F1C5234D261A11492B6E23A737B717DB88CEB14139F281480E963E8A368A1206C24D83848BC6701518F7C8AE453B2883A9162908D401ED149568CDC12DA4F6D944C862B813C0DD91191CF20231616FD1C51F149882156F08CE2BE3CBAA757C57590DD7C0AAD3E1D8ACE3D97613005CFFD861E418F7EBB8532F41EB44728433F0AA6070EDF8701C3F612BD5A8BE1A30F9247D98D0183B660FDC61BF0F04D40F2AB6A04863FC3B3F8340485462230F031BCBCFDE0E3EB07330B7312F0AB505256C435256568DED0809989296EEAE8C1C8C018DA9A3771F1FC65A1185714AF42F5DA7568A86B42474B97E20F67DCF1F1C383804018EA1BE1C68D1B44A1EBE74535F4128C1F328C86036A8DA7D8666767E3C99327484A4A122793586C1670B6E60CB6EC5CCE607AC49E21ED558E5008CE33D7A567255C3C3F4C16BA440ADAD8423357E56D0ED8E87988E54DF8214B049385917FC3E52C7C242364C1C8E2BEAE455135791472E159C5A4A0443219CC77F9B785E4D5CA6BEB8F2F22EE585C494A514374AB8AA85C0DFD96CA72C81BF231E944054A6AD93A12E7CFCE452951BE3CA27EF924B1DC1354504134AA86EA40E7627ECDCAC475E2941581F937D78D05338BDAA390AC38D30E4E59D9988ABCA2B6E17D4CF7D85B95949350939032C5137490CA73F2AA8432C7C4278B7B080C8B14D76441CC26AE1C4B9C388F4EC0B486CFF992DA97290D778332B7E734F64592A807B72BB7272B23A7513189829225A5E708E54C487925F26C4CF81809B59328C8CBF43C112770CACA12119B585F564D4C80EA9453025C56B1C0676D47511C301873179C83F4808DE8D56F3BA407ED168AD06FC84EF419B885A8D4160C18BA037D066C461FE9759834F910860DDF86AE5D9760F9CAD3B8AE610F752D63DC20213737B72498C3C8C80066E6867072B686A393158C8C7509B4DFCC0436D696E415D4616A6C0277570F78DDF6C66D776FF2204E70737117DB9CDA58D992C2E84045595528CA93C8688A2FEA659DD990443924107F9AEA594A4949F9A12C3A3A1A3E3E3E888B8BC3EBD764ADF3F2046F658560CBCFC2CE82CF3487B799FA64D0436205906CF3B11C2B90CC084521432504A5804C25F35189E0F0C32EA2DFB030B082B0B03138F0E387CAE5A297E3359515E6914B27AA524E0F392B8394830263DA26028784D4449454952132F6092A5E57E1655A12291F59DDC25C812A52A6D4AC4C71BEA86731F480EBF032334D9C97CF93535A220431B3B000F169A9789E922C82CAA42C0ADA2A3900A7588914823D0C07CE6CAD392065A565256161E57B640ECE42CAE0324E599838C8A55B165FE2A1DB26EA48424D0DC1CA9245B1055B7A8E05D8BBB062E510FFE1C79853568EE23AF246744026C5117C2E6EB3246A53AE6F3C05DEDC96DC6BC5F7C6F561C373F1EA7552900CB1CDF48D8D0C1B1D6E4BAE3FDF0BDF13DF072B5302792F2A12B434A7A092BC3D1BB60A0AEC7305DDE37B4BCD2EC5BEC34AF8BAC358B4EF38030307AFC7F051DBD05B5A163DFB6D268FB093E8D34652828DE83778337AF79747BF019BEAD17F35860E9643FB6FBE439BD61389EB5F86BDC37D68681BE0E0D123B8461E41EDBA3279860BB870E1085454CFE2FAF50B387FFE28B4B555E1E2EC88C888C7887B4EB42AFE85F000BEDE776061660D835BC6B875539F1446437811172757249191A67F5265CC23DFC87563B0E1E75ED71F0A1A2FF32181A3A3232E5EBC881B1A5AB87255196AEA1AB8AA740D86A61678121B27024BE6B1F974B172326F6C55B328B8E6603B8F1A5EF4EA506366107F4E48C9402629143FAC9C923244C525088578F4F49978A0F742C2C5434EA56094797D5A0E790DDA66CAC0AB4DF331CF12D3EB85B5889484D2B8F464A10425B544255E57A29C44BFB28E3C481DD19BB23C1224B290A40C8555E542D8F9D381FCFB92DA0AA2047C2EB2F4F49BD8A478914FC9C9A05FB0B72821DA50239420B380027CBABFC40C1264FA2DF371F622CFC962B3C0F2F952B38B459A5D44C13BA5CFA95E2574BE3412347E0C69DC0614D4F2FDC667BC422E51A0A724A43CBBFFF1F3C437E5B9C8248A9441969AC1BF0B897826DA2BE4510C880DE1514C8228BFFB30025964EDB22B0A11FFEA25DD67251E3E8FA26B521BA566D21DD52B8E8AB611A45AB5C5F60317F1F8693A28A441E4D39728CCAFC2F3D814312D223D351F4E4EDE448B3361626287D4D43CA81147E72E6A4D1D7D7878F909CA79F77E189CDD7C84B17B1C9D864B4AC6E837708178FF61C5AA2B9093D740FB0E73D1BDD71252105680EFD17FD05AF4925E819EFD57A2EF2059A25472E83D5001BD8729A073DFB5F8BAF37C7CD5693A662FDA89B35734A06BA20F152D45282A5FC2A1E307B0FFD06E9C397B94E2812B3037D185838D21C2C3FCF130340C9E1EB761696E415E400B972F29126D5285B9A9191CECEC1112145CBF0E6D13325D5D59FFDE78E3813C89F7F8C9081F6F4BA893BFBF3F69E905B8B9B9C1C2D21A3367CD86FCC64DD0D125F7656D47C15F3C591876BB441748315232B349D05F08EAF13C218938733A9E5280184BFC907B34D84D331D29AB7B0D0B27679CB9AA44C20B286BE9A0A0AA06C72E5C12E9A1D3177037341C06967670F1B92BF226E41283236370E0E43912F03A9C57D1C0138A69AEE9DC12C73C7E16872B3734E117148A6BE42A93B3B3B069F72E216CEB14360BC13E78F20C3C29407370F7C1BE632711F9FC0596AD5B2F8478DBBE83C26BF1314FE25FC2DCDE116EC46359F099F230A74FCFAD177C45152D21947A1636088A7A06F7BB41B8AE678C80C7D1D875F434FC42A2A04A6DE4792F08EA7A66B072BA03030B575838F8C0C33F04C7CE5FC5E3D81798327B81E0EE3273172191629BF55B77C1C6D513975435B0E7F869B8DD09C09A0D5B101E1D87156B37208CAE25BB65271EC6C6E3C41535783C08868E850574AD4C61E1EE84C364BC1E532C377B852C6E995AE3DB6EFD89D2B481D43FDAC3F7411CAE6958E08AAA3E0E9EB844F4C30E172F2843E9AA3A29820DB66CD9032B2B27AC97DF26B8FCDE0327E1E3178C8347CE425DD340F458853C7C8AD8E7E9484CCE230F71153DFA4C21A15F88EFE61C2085B881454BCEA367EF1518325C0E03877C8F2EDDE7A3679F45E42596A3E780A5E8D67709BA4BAF44AF81B268D77D257A0C94C7E0D15BC5BA4C2D3FE84DDE650C2E2A294143EF068E9E3A822DDB1470E0D05EDCD4D32419B44380BF271CEDCC616765884B172E52FC704128839686A65090CCF40C21B78D515E5A86E2C22234B5CC0E43C29424E95B3B595358219826C5C7C723202000AC18DC8FCB330E1D9D5C10FFE2A518677842168BFBB899833E8D4B12AE997B4642226210FB324DB86F5682A72FD2F03C299B02A862A22059C2CA31FCC31EC1E58EBFC82B6BEB91652C83AD872F8AC9659FBB7683AC7C1DEE8645E349420602C84AB2A01552F0E1E815408A03B8FA472025BF0E5E813194D622E0613C095C38716E404DCF5208AF96BEA5F032DBF79D10FDDB9E7E61C8A5A0F0ACA22694D54D504086E1E86955A256A550D130A3F80350D7B1C293E7595052D387A9B5BB3886CF1516F50266B6EE825F2BDFD083D7FD08044526501D9FC2DCD113BE4111C8216F666CE78258F28886A67678F62213F6CE77F0282211BEFE9170F508444C1CEF73447246364E9EBB24E8CC9E8347455C7555F506C222A2E17B2F100FC223919A930F2B7B67D121E0EAE12382786B67371157E8DBB8C2272412B65EBEB86E60004D53539C54528199B317A4474DC6F0B13320D5E273A110D66E21C8A276B1750B84CFFD70583A788A01BB3032369E5E77C4C0E96D4F5F31E6C1838D3CAEE1E6790F4944E9EEDC0BA3FC7D040445E111DD2F7F636EF9AA2D68FDF500FCE3A35E1835761DA64EA398A1DF4A74E9B6183D7A2F45D71E0BD0B5E71CF4E9BF087D072C44B73EB3D1437A2E05DB0BD1A5CF02528CA5E8D86335A4076F44872E0BF155BBA9183A62292E28EA88C153532BB2F64EF6B0B1B3167070B481A10105D1674F61CFCE2DB874FE14C50DD4BE31B1D46A6F0B388397EE6F5CD6106525A58226352E97E0AD8D8C0C12EC972FF1F0E143701CC1DF14E61F73596A5A8658BA9C9EA118A04BCDC813BC9895218C148183C24472FFD194C6256722203442500A568A6812EC67C4518323E39044415E0859BE4CE2AAF924094F1273F0FDB64370BE138A87CF32683B0F723B8FE37E7832D46E3960C7E12B50D8730E9BF75D40746211BC1EC462C9F77BB0FFAC1E64B75F849953089E265761EEF2DD088BC9C583880C1C38AD0967CF3078DD7D82FDC79471F2821609B205511BE2C824D41F7ED1030A5B2F105706F61D52C3879FF6C5B94BC6D8734015B2F2A7B0FFB03A3DCC5938764A9BEEAB084F9EE562DE62050C1A311D26569E98396F0D962CDF0AF94D47316FA11C59C4A1387D5E45F4F747C52608BAE37DE781E8FD7918FE4C04D22F125F213C2A5EF40271502DE95593F4B0717CC129539397C944AB28F334EE25AC3868A4E0F1F4998B82CAAC9695C7E6DDFBB0803CC79C556BB1485616A366C860B1DCF758B77D3B36ECD94F5E44159F7FD50DEF7DF40D3EFCB20B02A392109D446D4375E1DEA344327021212148CFCC80CF1D5FBC4C4A84BB97271E474592F00722282C140E14B87AFB93517C10022FBF07F0F40D84D79D106CDD7914EFB66A8DCFDA0CC4F0D1CB307BDE1EF4EDB7189FB79948CAB0082346CB137D5A445E643ED1A60542317AF62325E93D079D7BCC461752961E7D1760E84879C8CCD88BCEDDBF2329EC0485CDA788D625C12FE03EEC5DEC60694D1E504F8798CA391C3B4631C5352504DCF3477646FD9419C9471BFF5BB07C73E8C0748A270B8A9842124B70FF6C7070B040686828222323111111217A9C584178249A07E6782A010F9D47C7BE14DE22E269BC4068F853DC0D7E8C20A210E1312F60EFE68BC8672F85CB8F789E84A8F814411D22E2D270FBDE4324E7026EFED1D876F00A8E9CD785DC8E7364698113970C85800747E561D7911BB8A86A03679F58EC3BA10D53FB10A8DFBA8DC56B0FC33B240D4BE44EC03B9029941B16AE3D243C8992A61396AF3F4E56FE1E64154E4261FB59CAFB93F52F107C7AC0B0EF307AE252F41F30972C641D8C4DEE61EEBC1D08B89F8A0F3F9286C2A68B3874580B4A4A8E9832451EAB579FC02D7D1FDCF18BC7B90BFAE83F703A2E5DD6C7F143D7F0E5673D317ED41CECDE7E02674F2A21E6C90BC446C723323C5A8CEA2711F54A4D4F13C2C7DF41E0C9723C792EAF209FAE17088FDB5E3031358796B62EB6EFD805B90D1BB170D112CC98F91D29DE3CCC5FBC041B89FA9D39730E9A9ADA540F43F23C2E70203A7BFBBE3F3C02FCE0F7F001029F84E2515C24829F3EC6E3B818BC7895267AA1464C980CA996ADA061688CC88404F2AE77E0171C007B0F6738B938C2C3D31D760EB670F3728785ADA5485D6EBBC2DAD196689C031DE74ADEC515FEC1A1F0BD1F8A03C7CFE3DBAE03D0FA9B1EE4853AE3DB4E933073F64E4C9CBC9968D44A01E9012BD1A9EB6CF4EAB78468D36A74EDB59002EF65E45114D0B7FF3274EE368782F1F5E8D86592585EBF6BF7F1D0BE698F07C191D0D537A0B63D8F3DFBB70965B87CF912ACAD2D919C9C28DEE0638BFC5B29C3CF41FC61C5F0F3F383BDBDBD188778F0E081A04DDCE3C4E53C32E8E4EC0A5FA23B3C8FC6D9C58DDCF91DB87BFAC3F30EB95652061FE2D5AE9E7E70F3B9075B174FA2029AB071748733B977F73B774599E2756DD8BBDFA5B22061D1D5F55D71E88C2E8E5F34C01A85538849AAA138C35C083DE90E29C75E1C39A78F03A774316FC53EDC7B9889A3E70DB07EDB45E859DEC3A27587C95384E1FA2D37ACDD741AF1E975E29C5BF65F41544C018C2D7CA1AA61839DFB2EE3E03115DC3276C780A133B063EF4574EA32064B49F9060C9A85E12317E06EC00B8C18B51097AF9AE29DF73A60FC84B524AC1E70757B828B974CD0B9EB58E2CCDB705DDD121F7DDA1572ABF64057CD025E2E0FE0EB1E085F8F005416D7A2BAAC16B164087CFDEEE041D07D189B1AE08AF2455CBD7601070EEFC1DEFDBB3079EA04C8C84CC74C12FEC3878FE2DA3555DCBC790BD7AFAB53407903CED4D626169682AE868484114D788ED8A7CF104B4689E736453F7B8EA81764AC5E3E15E9A35832469164D0A24244996FD01DB2BAD1B876430D3316CCA6D8C788E21E6F18D998C0D0C290BC803DDC48E0ED1DEDE07EDB8D9E932DDCBD3D44EAE0E6046D7D5D78DFF7A3A0D7102EDEBEC2C831051D326A3ACE5CD2C289B31AD8BCED1AB66C57C18E5D1A983D779FF00CED3ACA90D79C2B047FE0B035D4D66BD1BED31C7CFCD978B4FD663A060C5C8D71133662CC3839F4EA3D1EA3C7CCC3B9B36A3032B2818AAA1A2E2A9EC395ABE770C7DF8DA85D200A0B78AE122903A1B6B65A0C26371C36F8BD20FE646565414343438C00DEBD7B17DCE3E4E4E404575757787A7AE2DEBD7B62F0C4802C0EF73E9D3C75066A14CCDE343086B98D3D59176FE16AFDEE07C1C3EF2ECCEC1CB07BDF611C3E7E0A878E1DC7EE830749284F12773E0E6B276F0484C442DBC8195BF79DC7AE435770941A79E6820DD033F5C40AD90314F42A52901B81A56B77E38A9A99D83F76EA328444A6618DFC21EC38A0884B4487D66C3A066D133728695961D1DA5D30B2F2C1B6FD17B0F390224C2C7D7045C504874FA862BDC2116CDE7912418F1288FE78203DA70AFE01D170710F8291A91B51145FC43CCFC6BE839788F68423EC7122C501C9887F998794F452B8DD0E227A1148F48862ABEC32843F7989A497B9484B29C45DBF8770B4F78483DD6D9C3D7319AB57C94261E336AC91DD80D9F31760F18A25A494DBB1FFC85E6CDDB51932B3A6E1E295CB387AFC18799EF3C4996DC594EB172F13505A5E86AA9A6AF1D20EBF9FC006EA554626129EC72126EA099C1C1C2918B682DA0D7568DFD2829ED12DA869A9E3C499D33875EE2C94D5AE9111B80E3B675BB890850F78700FDE777DE14CD65F8738B97FE07D18199BC2D0C844D01356085B273B583BD8084F616C690A7B5747D83ADBC3D0CA1EBE818FE015F010BB0E5EC4E75F4BA343B7F1D8BCE30A66CDDB8E91A3653176FC060C19B60A1D3A4D43A76E33D1BBDF22A2456B85C768FBED0474EC3E1323C6AEC7CA3517B066DD0532065B3060F022F4EE3303FD7A4FC4CE6D276169EE0A5D1D23610C0202EE120B79868A4AEEE8A946DD6B9EC2518ADA9A0A2AFBF938E1B784F8C381B4878707CE9E3D8B53A74EC1C5855CB403B94FF21C96969662389C3D85A99905CCCC2D45A31A9898C3CCCA168E149831EC2800B47771872351021FA20656D6648DDC6F53A0769702B5DBF0F6F3A763DC45C0E6772F928261736CDD7F122715D5A0616085951B7611F53186DCF6C3E41D547041459BACFF6ED879F84345C798F66F878195337989FD90DF7908FB4F5FC38E23976060E389B35775317DC11AEC397609F397CBC3D8DA03BA06CE58B6663BD6C9EF27ECC5816397E1E11B022B472F98DB79C09682637D631B7878DF27B76D016B7B0F115CF29C239E2AF2342E41CC4EF5242F67606A010F1F3F122057A1DC874F9C266E7D4860E69CA598BF641514B6EDC186CD3BB1FBC0111C39799628C009EC3F74121BB76CA5727921ACCF5FC6899881638EC2E202A2556988880A87B7AF9780ADBD0D0C8CF46165632984D6D2D25C0C50797B90A726E5F1F723AFEBEE8AB047A144E7EE22302804EE1EDE224836B7A07BB9ED23BCB8BD8313F4F4F4C533F5268F6564664A4AED2D82751B6B67383B7AC3D9D505CEEE6E70707186B1B919CC6CAC88665A42DFD418AE5EB7E1E0711FF7429EE3FC557DB4FCB01BDEFFB00F468D5B8F0F3F194981F13411477CD37E0ADA77984AE964480F5C82C1C35761C09015982CB303D3E76EC17899F518471474D0B0E5F4BBC1907AB72B3EFEB437495D5B8C1FBD0826866E0824E3E4E71B8C18A2E02C8B125455F10B6795E0F5665931AA286DB8FFF7C40F190E32982E9D3B770E070E1C10C3E886C4F11CED1D70EBA69E1839E42175DEF6F6A40748DE8015C5CEDE1196563602122B64634B96865257370FA1487C2CE759A1ACAC6D058C2CEDA1A56F0A3B572FD1457AD3D812EEBE01E4DEED047FB57620B76EEF22A666F3546C1B076731DCCFD3972DADEC604A0AC9021BFD3C410483968E2EA490DEF0E0F7731F46D17E3B5CD7D48591392BAE37F1657FF8DE0D25457686A5AD1B3C7DC8A359DA91C7088681B10554D57561EF741B7A06E630B77224C13F237A852E5F5383BAF64DB290BB31691A59BE71E3D0BE4B1748BDF30E3E6BDB161F7CF6193E69DD968247EEFE6C45E5EFA3E5079F40EAFDF7F0FE471FA073CFEEE8D4A31B71FB77D143BA0F66CC9D8DEB5A1AC4DBED1116194EDE2B0C810F4391989E8A172949888C7D8AB8248AD79EC79295F7838BA78780BDABB3C04D2303EC3B720867CF13E7BE7A057AFAB7283EA0B6F1F1263AE440CA642582675B7B3B523043B18FCB9C5D9D606E69066B5B2B114FB8BA39C0C1C916AEEE2EA2BBDDD4D246DCB71705D41A5A26B8171C839DFBCFE3E32F7A9217984071C04A7CF9D50448F75B818E9DE6A277EF351838703DC68CDD86A932BB450FD4C8D1DF53FC308FE2852974DC7768F3E550BCDFAA1BDE79E75B7CF26977F4959E886D5B8F2324388E44EEA7C2D8106565257FDABBF93F29080A0AA2A04E13674E9135DCBC05870F1E828E96B61824E194FB8655AFA99025D28396969600E70D0D0D616A6A0A636363DCBA754BE4D9D5F3642C9E886563438D2E86ED8D0458A84DE841387B78092B6C65EF44BCF60ECCAC89E7526A4F9EC72F20105A37C972DAD9E3EEBDFB42C15CC9BA3D7CFC48D0031BA2131EDE3E70F1B84D96BFFEF73E77EFC3F7DE03A20CB791949181CABA3A318583AD338F88F300237783B2C52EA9A89F135549411C4F43E191F780A050521A07285F57C3CEBDFB3061CA54F492EE4BB46004A407F5C3909143B170D92274EBD51303870EC1B45933B174E52AF21873F1C917ADD1EAC38FF0CEFBFFA4F403A213D298B3603EA64C9F866F3B7722856981F7FED10AEA5A9A747F4EF0F1F7A37BB0879EA101DDA32DEC9C1C299630275AAA4F9ED85858782EF7F4F5C1839060DC7D705F587EFFFB0182DEB21737313181999999685F6E6FCEB397E73890DB99A93097595991973733A16D7B62001448DB92A73737121EC9DCD2823C0C291E190557F2CCDE778288EA5DA0786014BEFE7624BAF79A8E41E401860E5F878183D660F294DD183592A8D3E0B5E8D9632EFAF65D80AE5D65D0FEDBB1A430E3F1C187BDC83374C1C021D3B079CB3152C27BC8CCE2EFCB51633790351E3F68D87D5A4E8AC0906CFF59107F983E351CC4E360263438440C906CDAA880E3478F8901129E80C51E444FF726D4D554A1A9A10EBD9B3AB8A5A70B1D6D4D6869DE80060577D755AFC1CC94AC14056E76C455198EC45B8D89036B69AAE1A62E09055935E6D33CC98B1F0AA7D6B636302557CE96CD92F2FCF0CD2C4CA9CC047E77EFD083B327AF6349D4C18BBC863B51068A69087676C489AD886AD859C38E84EC1609951DF1E272E2A2B514A4E59714A08C787A6E610129408D5004E6EFFC3A25F70EF17BD43CF6C2D3DB79862F7774F031FC1BE6EC03870D221E3D136BE5D660E6DCE94497E662C9B28558B66231059933D147BA373E6FFD19DA7EFD25FA0F1C80366DBFC4B71D3BA077DF3E442DDA41AA85143EFBE2731C3A72182161A1E215CE9867B1228E781A1B83A8E827E275CEECDC1CF062005939D9A2978A6783B2D577BFED41F7EF2F0C02B79B3F51D23B4487ECACACA1A7AD03751555DCD2D115DB4E64405CC858D85BDBC0C4C0101E2EAE70B0B18533790E3B2B4B41C32C4D4DA0473189B189BE68376E6F53332BDCD237C12D43F69A7AF8EAEB11F8A2F5104C9A248776ED26A003D1A4A953B6A253C7E9E8DA6536BE6C330C2DA43AE3837FF6469B36834892BE22B4C1D8710B7055495FBC97C15356B8CB99DB92DB94EF8D177460F0601A2B058F2EB3CC31249FF8927C215502F6181C647377E9CF8D2FFC56107FB8F7293D3DFD275F7461444545E1FCF9F358B66C19E4E5E545CCA1AACA0F4113E6C606B021A1B5A38675201E6C4DC2CB7071B08585A9016E6AAB0BE8E9DC80B1812E1C49A019B656A630A1FD169626F4300C8560F3008D93B39D107C5737475210A25DF656C4B56F8B1E1C43A39BA40844A9C8C219E8EBC0CBC3113E9E441B3C9CE1E64A54808E75777382270595068637E1449EA4BCBA4A3C90625200F60645653CD5BC9ACA6BC43B1EFC52134F75E73741F90D515E4DAE821F223DC0E7712FC5988C9FFF3DA20632983643062B572FC3CCEFA64166C624A20D433178485F0C19DA1FE3C68FC4F419933165EA04DA1E80D66D3EC5279F7C82F7DE7B0F2D5AB4C0A851A3C4CC80478F1E89C967DC71C17427802C3F2F451FF9244ABC25C7E097FF935292F138225C2881A6B616AEA9AA404B475B4059E51A2E5D5684BEB62E4C6E19C0CCC0081A2AD771F9DC055CBFAA0C638A259C6CC8DB3A52EC4034D68DE20BA39BB7604E9EDCCC809E17790D5BF2D86C5CAC6DCCA1AFAF478A4141B68919B4B4F5E859D8E2BD569F90D51F856EDD2711E59941F7390F9DBB8C47CBF7BB0ABCF36E27BCFBDED7E8D1730C64D7EFC3B1134A38724C112EEE7ED46264F1859CD7CB8F4411F87DE9A2E23C51CE5F306AD88B54CADFBA2BFE71525EF59BE581FE2C34592841C389823CB8C16318FCD2C6E9D3A7B177E7361C39B017674F1E83AAD265E86A92026891F0EB934092C5BECD82CDC24EC26D667C0BB7743560490A60C52E9B520B7363D8DA58080FC279067B12869525D1305204DD9BA478740E562056046B52268639FDDEC6DC10B61646B030D68383B539ECACCD606AA427AEC95ECAC6D649083AA3B4AC1A0505649D8AABC5DB766565AF91995980ECEC522AE36DA25225AF91965688A2A2D764958094945CF122928D8D0B29C024A20C32E415E6608ACC644C9E3A0953A68CC2F4E9E33075EA584C9E3C9AF213304D6622A4FBF640BB6FDAA06F6F698C193516F2721BC9D39E20DA7909FBF6EC274ABA0D8A172FE3C2B9F362AE0ECFDBE1988DA9A99AEA75919A18D13D8829D1BAD050E7F703D48597E663D589D6B107BF7AE1122E9D3907A58B8A5057568181CE4D589B9AC382623956829B1A5A42715849B4AEABD37EF2E8447519DA4467D5D5AE414DFD9A988A6D6B4B14CDCB077BF71DC2471F7F8E4E9D7B90428C20E9A0D8E89DCF45FA459B2E18336E1656AFDD42C6CA0BD151093FC8C6CFA1BCE24719AA6AF0EDEC86A8F7044DEFFB33D064E1BF03BBBDBCAC0CDCF5F522F74D94EACA255CBD745EE0D2B9D33879F410D454AE405DF52A4CC86A9B939BE6549F849CCB35D49405E5D2D5A10777EBA6A06026C686B0B43023E520CF636B2DF831F77A99981891F2589127B0150AC39E88BD9289BEAE50062B520033C35BB030A1DF9B1AC18C824B2D757E99C459AC18979F5F2EBED6FFEC590A79C30252862212FE7C2427124549CAC1AB8C2264A41520E9650ED2530B91995E8CACCC324A0BC11FEEB4B773C3BEBD87C454663608478F1EC606F9EFB17D8B2C4E1DDF87DD3B14B068FE4CAC5ABE0097CE9FC0954B67A174F93C743574A85EA654477B525C73981A9017258A6267497CDEDC1A3644759C290EB2B624EA624C710129012B83B1A1110C6EE9435FEF96E8E8E032DECF29C3CAC2524C7873B4B6154A606E682C849F954002560A56126DB51BD0D3D416A9EE8D1BD051572705B90EC5B36771E5F205D1EE3C38C62FE04C99328502E2F7C80BB4148AD1BD573F6C50D8060DED5BB8171822DE2AE467CFD3ED393E63372A59B482E9371B4DC97294BFB4A7A8E167821BA2BAEA8FEB696A0A4D164AC04150613EF1F0F29FD762FECC6B4870A0E83E64E13620977C5D5509A74F1DC3D93327A0AA7255C4129C5E563C4F71872A09D84DA2615446D0A687CA5D88064405B4B47470E3862694AFAA9255D4C4D5CBD770F9D215A85C21CBA64C9694621B017AC07A9A9A0237C9BA32B7D6A758474B439B7EA344D7BB295676781245DC3D3E09F171494849CE14E9D3E838B18F5FD2E7394051913178FC885FDE7F8AC00761F0F6F2C7FD8060BC7A952D025556CCC4A438444486502CF088E2823B08BCE789E0005F04DDF3C1E390004AEF90B01BE3E8813DB8C602A7A90B5F0F6F18EAEA434D89E22FD51B64D1AF93709247A0ED6B57AE928755C6958B6C5014A1764D05DAEC0D085C7E83BC86267B8837E0B841E5AA9200E7AF2B5FFB01BCAD4B5E84C1BF6570195F8353FEBDAEA606B59326B5918E301A1CF7295DBD2C70E8D021ECDCB9939E83365E24FCFC4A183C86C2B452045FF4BFA911E6FF44A8F99BD68DCBFE2C3459F8DF8083A5BCDC6CF8787B8AF92A17CE9F85A1C12DA24976448B381ED013D0D5D12717AE0565A5EBB8A14E827C4545E4D5481134354849740CA1AD41B44293A80041E70659434D3D014D154D61FDAE292A0945D1208163A5B9C6BF57D5106F5EC9C9C9D283DE4E0F5A13BEBEBE62849E531E2DF6F4F416718B15512EFFBB3E54EE0D0F0F3711B0F331818181080D0942705000E4D6AFC18001DD31556604868FE889458B275360DD1673A64DC48635CBB07ED5122C9F3F0733268EC3C881FDD0A3433B6C965D07958B57A14BF772F9F405289E22434075D3A3FBD4545683A1969EB0E03AEA1A22656BCFB101C708A6FA863FEC63B0E5D72523516FEDEB53D52B4AA2C383A91543991445891480678C9E3F7B4E6C4BDE4C630A664401371B2C6E7F7E0E9EB7DD11F3F4094A4BEA179FFBB5E0F7ECCBC960563552889A8A52D451FCD0B0ECAF88260B7F09243D013C678ADD67E3FDEC4AF95B008D57782E2CCC27FA9282E7B1CF10151189B09050D1D3C569E0FD07F0BACDA3C3F6A2AB91C15DBBDCA5686161212815773D32076670D7A3649051029EE6CEA3F2DBB76D81CCD4C950BC748168970151052D014B0B1341C36E19109DD0BD21024D43124A9E66614081E84D3D2D5CBE721E274E1E117DF99BB7ACA760B31BC51463D07F404F74E9FA2D468D1E86EEDD3AE2BD77A5D0829AF09FFF78175F7FF505162F9A4B546B0729B612511D53A23AFCC20B09B9EE2D589A5B8932F664FCE28B8A8A3214152FE2CC99533875EA044E9E3C2ED2B3674FE3E2C5F34469AEE20A09BF921279038A09D8834ABC29D7D78402633B3B07BA5F0FDCB9E32FA68384863E44787824121393919D998F82DC1294F33BB10DDA9FF14BAC7245397751D4E7F95B13BC3A06CFA0E6F1833F62D9D13F134D16360607DC2CF8DC63C03D540C9E415BCBAF793608C619FF4A49FE68B045DC40DE82E3166D2D0D41E5CE9D3D49DB1A44192EE1F889033879EAA89874A64C81EA050A5CB987E81229D1A9D3C784C0BAB83A60D9F28578BF95D41BB4402B5200296AB6AFDA7E819933A68AF36567A58BA9088DEBF0BF8CF28A6254569536394056552908D25B65FF9FD064E12F010B3E2B4463A568AC10DCABC0D6A5845C35A70DF7FD9E608AB062F9521C3CB00F0A1B37100D5A8B8DF2B2D8BB67074E1C3F8C1D3BB7601B79933D7BF660EFDEFDD8BA6527B66FDF29F8F5B163C7C4F227C78F1F47A74E1DD096BCC042F202870E1D108366ACF892EB348CB7F8E3861C8749FADE996F37EC8797A0A9B23F1ADCEDC90171BD47E78FBDFFB594FAF7449385FF0AAC004C997EAE01FF88C1955F028E69E6CC9E05D9EFD76293823CF6EFDB2514E2FB75ABB079D3066C64459193C3E6CD9B29F6D84DE956C8CACA61DD3A59019EC53A61C2242C5AB488A849FDDAA44D2127EBA70B28FF9A25281915153CFBB382DAF5B751969F9B1EC16304F5F8CF95A0B121FCBBA1C9C2DF1B7F84557220FAD4BFBF34468C18869933A763D2E47158BE6231162C9C83D9736660C1820598366D1A264D9A80C993279312C8D07133B170E162AC5CB91AAB577D4F54EAB2189B919CB3DEA2BEF1026FD2866BE9FE99F835FDFCFF1F3E20F3DFA0C9C2BF0398165858985170AA8B6BD794B0759B020E1FD98FFD07768BF4C8914322A0D5BBA50D4F2F373C890E477A7AAA08266B6A78FEBEE0D5A8ABAB2345F8B1B3E0CD728C3FB9DE9F8D3F7B14F8EF84260BFFEA6021E61E927AEBF95AA0F635F7AF5783034C9EBCCDFB5ED75511CA05EA179EA92625A8151F1AE17FECD1EAA9480D7E4EE87E0D9D681C9037FC4AD12FB5E04D1DF76BADFFCF51ACFFEF68B2F0AF88860FB9BECBF03559FCAA37424E2081672560019728082B017F86AAAC221B95D505147816A3A8A8402C19CA6B0071973207A3A565BCAFF4671583F16BA72A48F87DE372C6CFEDFB3DF06B95EAEF8C260BFF2AA87D5D4F6BEADFD4FAB19C8599158115851584F32CD4752823252001AFAD7FCD915780E273D4D695A0B43CE75709212B53E3B286A84331AA6A0AC5F925654D59671646EE1A6D5CFE73F8A5022CA17A7CEF92B286E015BA1B9735E32FAC148D05A361AF5739AF3D49FF9806716CC034882955ED6B9EB65C40EA504FA1AA6B48496A9B161816E6E2923CE4E665A2ACFCC7915FC9ECCED76219B37A2E2FA14F0D695475ED8F9F916A585749BEB12234BE1FDEFEB939446FDFEF2F53E6C6D76846D368B2F0AF8A4A5E07F24D9E059403E6B7FFB12294080BCED489059F95A4A22A5F94317DA27FE2F7BCAFA4F45F7FAFEEE73C055BE67AC56341E42F31FDA800FF8A824904FB3FE9EE6C386ED214249EF45F798C66BC8D260BFFAA60819208556151AE98A32F02EAD735229EA8ACE2C1430AAC49602BAB8A7E08B0C99788943D095BD39252FEF400512FF19E30096C45D15B56BBE1DC7F4659F9DBDBAC08F58AF7639904F581FE8FDB8DDF6191D4FF9758FFC60AD478A1E086685847F690927C7D9BFC785C732FD65F5429041D22EBD730182D2A66AB5E8D82C2FAAF629657BC099CA99C8F61C12FABC8A5945778AD7F299E630A168A7A5AC1FCBA5E79F20B28F026859058567E398683F38282FA976444AF14094F71493D45629AF5735698A90EBF03CF429B9393F5A607EC6D0AD418BCC20AA78D8F69A82C92AFC9727D78EA362F7CCDDB4CF11A2A5FFD4A183562450CAE2753422EE77B2C2DABFF8D04CD4A01A9FF03ECA1A195B628BB7B0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A318'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000BA0000004F08060000005C51DF5B000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF0000300849444154785EED7D07605445F7FD8604084DA589051441A548EF08085215F4433F1451400105514AE84540BA58104441A5888020D2A57708BDF70E818424A4F764B3BB69E77FCFBC9DB82C0FA4F8533FFE3B7A32EFCD9B376FDE9D3377EE9D997D580078E0C17D0FD3440F3CB8DF609AE88107F71B4C133DF0E07E8369A2071EFCDDC8C8C890C8FCDA5F01D3440F3CB8DF609AE88107F71B4C133DF0E07E8369A2071EDC6F304DF4C0837F0AFF574EA969A2071EFCD5C8CCB243230B8EECE38C4C9B02F390E4696969F8BF20BB69A2071EFCD5C8C8B40AB153AF03D388F48C14C9E221BA07F701D23385C4E956D8ED09722A64B63B807439CC92282315A9762BD2326CC8840DF6F424A5F5795F7858B08AEF15A6891E7870B7484F277BAF4F73381C70A4A7213D4B882C9ADC962A1A3C53FE97AC54DE8E348164B44B9A4DCEAD76234DDFAF4D9B7B8169A2071EDC29CCCC0D4D7A5ECBC84A571A3BC59A0051EE08094E41F7EE6350B05025E47BE859347DA53F9EA9D00E8F166F8DC74BFC07B9735541FEFC6531F1AB99AA8C7B8569A2071EFC95A046B7DA688EA4C39EE640BA68EE254B0FA2F6F35D61C9591D965C55D1F4CDB128FCE4DB78B4E407F0C9DD52985905858B55437C9261C2DC2B4C133DF0E06E4152BB6BF7C4C4446488AD92644BC6990B0198F3CB3A346ED65B485E1F390AB44289E7BAA3F15B93F044E581285B7D3C8A16FF18169FFAA858B525AC8E0CE92062CBB8947737304DF4C083BF129C497164A5E1DCA58B58B66A037AF69B887C851B0BFB1AA350E91E68D86616DAF458891C0FF7C43355A7A1E023FD913B5F4B3C5DB699DC6E5EE69DC234D1030FEE04D4E0D4E4AE69B4CF5D35FBC1A347B071EB365CBD96801C799E8525777DD1E4FD50A8EC000C9E720596A2ED50AACE5728597912AA486CF1A9859D7BCE3AEF4FCD2EE76E619AE8810777024D68C6A9A9A90ADA84A1368F89894140D0555C0A0C46AAD8E74D5EE921664B3D580ABC895EE34EA3EE1B0BE05B7A004AD69806DF22A390E7C15EB0E46888E818166BFECC3B8569A2071EDC2DA8D7E97482767516675B807381A998387D290E9FBB8C386B26B6EC0C45DD16E350A2EA27F868C45EF83ED60525EB8D42CD5673C431FD00B91F6C879AF5DAC39E9505AE9EEAB2EF05A6891E787027D01A3D39C50E5B7A9A103D0DC848C6853327B166DD4E1C3F1F8B32353BE0EB1F97E34C60101225F3F69349E836742B8A96E90F4B9E97F154FDB1A8D4F847E47B6400723ED006DD7A7DA9CA8C8D8B4446DA8D73F3770AD3440F3CB853643932C55C11BB5C4EA885D36C71387EF800366DDD8B0E1F0C86256F1DF41FB50C474E6721564CEE6381C07F3AFF2A247F033E05DF4489DAA3F158A571F079A81B2CDE8DB170E90129C9FC597703D3440F3C7087762E35DCAF233D03626988363796F423C30271F2C43165C48C183F0B4F3F3F08551A0DC39B1D6761F9BA2CF41EB113559B8C45B3377E40EFC1BB51E6C549F02ADC1516DFB7E0EDDB10970353C06D03F6B47B5F15254C133DF0E06E909E9E89649B1D1151E1D8BD7B27D6AED9848858E0444006067C1908EF875F136DFD0C1E78A2111EABFC0E5E7E771A7E58148D31932EA2DACBD351BCE23054AF3F1A858A36429AF4A5F44CBB5A68727FCEDDC034D1030FEE1469768768F22C44C625E25C4020468E1A8FC64DDEC4C77DA662EC147F741ABA05E51A0C814FE117C48C790E5EC59AA34DF725F868D83EBCDF77131EAB3A128D5E9F8E0E5D67A36EFDF66A64C8820D29366E02337FE69DC034D1030FDCC1E9424E15BAC3D58C098F894750641CA6CF5B049FDC0FC3E2F314EA371F8C5E2336E38B5F4E63FAB24021FD4EB4EB3E1D2FB4F916C52A7D2A367A07580AB485A56027B468F7137CF2D7C3F215BB90AA34790A521D09DCEB98FD8CBB8569A2071EDC0E5C49CEDD89D3E7CE4744B2033B0E9D41990A8DF0D27FFAC192AF095E7AFB670C9F7A1A47C380F08C4C44CB0DBFF9C7A06DDF35285C71088A55188697DF5B82FAAD26C2E2F51C8282E325875D468818A46725673FE35E609AE88107AEA023CAFF6CE9342884E06A11D4793DCBD0EC2B366E1092DBD4D4218D8DCB2919183B630BEAB41E8B671A0C4383B693D167F45A2C5A1D8AE59BE33164D241BCD46D291A755C82D13362B0782550BDEE4094ABDC1AA9DCBE2BDADC911E8B8404E91DFA59F700D3440F3C70053537270E6D76B5495CA539D2ACB00B6CE91908B81A8EE3A742D1B9DB704C99B1085176202A2B035CD8BC24ACEF3CF037D47EE52BE47DBC8D982A62A3E7A8034BAEA62854CE0FEDC53EEF3DE6105ABE3E4DD85803652AB610A267897D9E0A9B8325DC670B46A653561EFC6B40AD6DB53A7FDB99958E247112E3EDC9B8782D1A472F44A34FFF316293E7478EDC4FA3DAF39DD1AACD38F41EB21A83C7F863F8678178E5FD4578B26A7F3CF4F8DBF079F0553C5B73085A75988B1E9F6CC50BD2092C5E35E5FE72F01B30C1B0C885E8494911C8CAF4AC8C7AF037C39A9C2ACEA7B1F219991C85E08404EC3D178E9EC37F8257EEE704B561F116E47A030F171F00EFFC6FA374C571A8D5782AEAB69E87161D17A1EBE0EDF8715122662FB561F4E4B3E8DA67398A967A0BCF546A8D3E43262336515C4F76A4944879A41D29C9B4D7CDEB7327304DF4C00357E8D1D69EEA406666266C19A9387EE90C769FBA8829F3FCF154F5CE285B63B898256FA366833912B783C5B7394AD71E044BFE26A8D8680C2A359F8DD73FDE06BFCFCFA3DF84F3E833F2381ABD32158F97ED281DA322FC867C81252BB7AA05A6B474EE56A42617FBDF719F2F18794C997F0FD8164989A259334597A789AD2E36F4D2B59BC4A93C8ADE237E43A3D7BEC29BDD97E1CD0F76A145DBB5F8A0FF517C34FC10EABC320D5D06EEC60B6DBE47EBF7D6A055A79568F2CE625469F63DF23CFC012C399B4AA7A806DF62156095E63E7DE1B29A3F4F4E89174D1E2724B7CA99799DEE14A6897F3768FFB9A7D1D3E7DCAD9EBF75BFEEC1DF0743E9A423F0F215B5C6BF78F13A38242E5CBC019AB41E8BF7FBACC12B1D16A1C7B003A8DE68365ABEB5163D879E419D6673F17A97C568D97E0EBEF8EA0CEA36F912B98AB4479EA21D51F4918EF0A25DEEF50848E7647B0666FE3C4F1C503B32D21D903FD2B132909AF2D790DD34F1EF0485C8FDCB562B3F85202FE9D1E4FF08D414A2DB8F255C91C56FB1A46760E3FA9DEAC7CDDE399F80254779F81478098F97EE899C85DF8125F77FC41E9F88D7C516AFDA70380A957C1595EAF9A158A90FE063791EDEDE2F225FE1D7F1F0E3EDE125E70FE4AA8C6BC1B16AAE3C51CCA2351B36CAA32418CBA2488A33ECF37F74F7A299402828F7345764A4654A647E8DB81D92DB6CB76FB3B997C7DD75FA98FB32F4F1EDE276EA772BDCEBFDB703D75FFADCEA7974F854AC66C83962A6232BCBF8A104D3D535D1AC19622FA7A4C48883E8C0CF731620E04A145E6AD919259E6C8646CD3B2167DE2AA2954BA07B9F6918336125DEEA381A5EBEA58459A5316ACC5A3C51F275392E85CDDB63D0AEE378787957970E521A79F356C2DC5F5688CD2FCA5BCADEE1BF0D8909718AE099621A912B9A2F99E200EB3ADD2D4C13EF0477D378D40C846B9AB39CEB348A16BA6E3C5792A7A4185F7732C39DD4C98CF0AEF76B4DA7CFFF97E04A7A7764135D6212DD6ECC912BA22527D960E70756E438D5CA95C974FCB678A1388940D9E76AA06BD7D148168BC27F579890F6119C3C978278699A24B9CE166AF5DF0FB06ECB69483142FC1EB049394B579E805DAE2F59764A58F728264CF845467121B3127F1A7E5DF08B7A96F435A44946C6A929B7AFD4FE0CA68977839B9181C27625A83BC109BBCDAA084EF017E3B76C202709DDC9CC735D07F76BC4DD687057DCECFD5CEB63F65C0DD7FB5DB5A69906665E9D87B1D9B38DE75DAFE9984F83E7AEF52179F431E1FADC342E750A196916C7C5268B1328A9729ECEE225FEF6DBA9080E0EC5ECD9B384310FA95F0D8584DA9124BAC6E2FD20BC7D1F478317DFC516FF0B888877E08D77DBC22AA3019FF8EA6B9D555CAE42035C0D4EC196AD27D1A2795B8829AE1C5B96CF19969F66CD9058DA88CF7518E909715C67FDA3CEAEEF732B599BC134F17670B30751C8B4B5DDD3355C1BCDE1B0DDD058BC57E77125C4BD42D749C72C5B8F0A3C76AF873BCC0849B8BECFBDE256EFEBDE5159DF3FABB306158D3603148924766FBFE4A434219FCAA302DF373C220A478F9DC291A3A714292D5E1631318E2A6E3668F81FB5B0E395F30178E5CA2FD78A2045446B157958BC73E3F7D55B6093EA592CB9111412C1091B2425DB70FEDC65F59C74F166F9C52E2E085D387B0C2B562C9367920F59122B994AFB5CFFA3685759FF6D4427F8300DD7347DEC0AD57B4DD2350202AE8836BF71030FEFBB9936A687CECDF984FB35F7B43F3BFF33DC8960D92046E7B9FE1E92479359E7D1D708D7CEA4A1CBE0B5EB1BFA8F7BD3336CD75D2358B67B1AC1726EE62BA573B643CC88146B2CE293A271ECC4712C5CBC025C10F5F6F14591C24FC1218CA5B9919C2A668790B75DFB0F14E15F6BDB16974302457B0BD1735894164FB266E091474B60E9F22568F7561B21B538BBE9365C0BE5F714D371EAE451D1DC36F86F5D87B0B05045741DF8230EB67B5ADA1F4AF37678763398269A8182736F188D9B3DD435DD75E874D8ECD9BF03A4D9121B13851F7F9C8143878EA834BEA05E6E76ED20A976234DC71A246D1AC75D973433A449B9A936834C3C666C77755033851C4EF0972D8CF5B5BF0A5A2624A13BB1CD88E90AB39192AB94EA379A6EE9CEB6BAA1B3B93E23CDEAF2EE4228873D19D7C20370E8D80E6CD8BC0AE703024133F98992B585294531E1F35FC17D5D164B71D479BE0DA26280D6AFF5C6B41F962BED7D55F85BB86825B99E476427664BAB3E62A674531D21F0CA455CB97C499C4F4E1766223A3AC4B91864C7AA954B555A4A72A2B2CD3964B87746BEC7AD14C19FC134D11D1430873F35044AC13723BCEE0CCCC329435D09F706B2268BF3121B87B0D06BF0DFBE158B172DC437DF7C8BF9F37FC5C68D9BB163C72E1C3D7A1C67CE9CC3C18387B177EF7E045E0DC2E6AD5B70F2F429F8EFDC81DD7BF7E0D091C33870E820B6F96FC7966D5B55FA8E5D3BB1FFE001ECD9B717FB0EEC57E7C4C9536770F8C8316CDABC15A74E9FC5B1E327B147CADDBBEF004E9C3C2DF7ECC1F61D5BB06B8F3FF6EEDF957D7CE0D05EB97F9BD4E320F6ECD92375D9AB8EF7EFDFAFCEF7EDDB271DF410B66CD9826DDBB649DDA56EBB7763D7AE5DEA9869BCC663DEC7F4EDDBB7AB73C63B77EE54656EDEBC59E5651ACB653E9673F8F061757CFCF87175CFD1A387A51CA9F7DEDDF20E87B0FFC06E312F0EAA6B070E1C50F53979F2A43A671D57AC588165CB96E1F4E9D32A8D651E39741497CE0660CD8AB5D8B56D374E1E3A85A9DF4E13C22DC3A580D358BB6105D2B244D908AF1ABDF89EB0A40C0A166E829CBE35E5B83272E6AE22712DF8E6E1795D410D7879579098E72F204FCEC6C89DA331727935411EDF6A92960793BF9EA49C4C8E18B1D17112A7AA11273A264CDE7DA3D2F60EBBA489694592731596303AA0F1F90C575F4F833C734F338369A22B48DCA4A424B5F4AB49AC09EFDAC3F439F331E8987929780A77D386CDD8B269B3C41B71F4F01145740E63D614F57329B93F1D0909494816979EF65984D888616111EA3C3139097109F1A0360F8F94346B8A689468A5C933A451B81F9AB0DA52D5F7FD5252ADEA9CE60DF3D0DEE4906B4DB523F45A3822451D51AB07875C8383E691D88A89C9716A479EBCA9949FA07EC6C5F3A89870D571E3E2E2A47E09EA9832E1797272B23A67A311BAB3EB73CA85B2888EE62E6CD15FD2E9E3E3E3B3F3110C2C8779799D69F41F882C19C3F95D1486A8A808B9CE6727203E41DE3D5D8EA5CE9959624F8787ABFCAC9791374A3D9775D4CFE435961D191E057BB20397CF5F4152743262C3A40CA9C6FEBDFB10743540649C0C9AF2A3C7CE40CE5CD550AB666FD4AC351475EB0D419DBAC351BFDE48D4ACD91FE59E1D886A9507A06CE9FE28F5F41B78A6547F3CFBD4403CFDF43B285BB603BC2D4D8461E5316AC22869FFE3CAD7647D13138C6FA2B32D82AF5D514A2A213E566A9D99ADD199D7C1618207022D4F09D9DCE47BC5C6F2BE3FD26E06D3445750F85CCCA1C019283C9E33F0C1BAA1994F070A95DA64F5EAD5F0F7F7172D74144157AE2A01B3F259C2B898A868E9BD69080DB98AE3C78E2807252951C81D1E23BD5B9E238FE313D53BCB9F94D44435DF9A90142BAF9D26E037F9E428436CCEAC74589365D4907C31D1092A4E1175E49072289A24D10CD450446C227FB122DA234BC8E4B04A29D2B9ACF18AE8FCDA2BBF49E248E7BFCA204217C4C445AB8EC44019E80ECCA0CF49266723285211ECF44E6757E523F1B48C487AE6A7DC788DF9359975C7E0BDA1A1A12A8D32E61C37ED72DAE31952579B90D1F8E609D30CF96B22EBC0264B1532315C0B0F561D9EAE89DD2A0E1F15A1641591C296404D99890332AA39A4F3B096AB371C42B396FDF05C958FD1A4C524BCF4CA44346EFE998A9B34FF028D9A7C8E179B4D44ED7A63D0BDE75A346C3216356A0FC74B2DA7E2F5D7A7E3F9E787A07AADF7D0A65D4FF5496812322C2C0C57AE5C51F22247CE9C39A346218E681C71366DDAA446208E3C972F5FCEE619E5E14A72A75CB3F9A98F6F05D34477F0217C181B861A9A8D43388792EC0A51AB90D86BD7AE55432EA70A751E924FD95D1273788A8A100DA7D2E40584C9972E5D568D42AD6E133B9A7B9FE5B2105BEC36A384ECC07A848826666063D29EB726C8CBB311B9F1480C49A76D0FDAE0BC5F23365E34B9740E9238363E4A62D1C2421E760963C184B33E6C1A8E602489416C924E939C8D46226B725216D4F4AE242379B5DC743E06360C1B8AE92C83F7E872798DE07D2C53A7518EAC07EBA7623254EA6B95CE4FC22BC6F28AB31CCA87218A46B404CAC7E96F48BDC4FF70CE914BCF970764225346BDE0E020F50E7CECA2A55BD1B44537F41BB4002F361F851A7587A15AAD41A85E7B30EAD41F8616ADBE44E5EAFD51ADF630D46BF8398A3CD24511BF45CBC9A8576FB438A06F8B7953079D3F180B1938A4A6868C74D0EFC8FAF2981D39222242C9F8C48913CA9C5BBF7E3D7EFAE9277CFFFDF758B26489E253404080EA24BA0C3DBABA76829BC134D11D6C0C6D96689233CDF900040606E2DAB56BCAFE3B7BF6AC6A642D6CC6CCCF8FBEA724D9909AE2101B2D015703838DF952B68DC8802FC8F2F8028A046276D044A1A3191317ABF292C089F132344BFE64D1FE3151F1D9435D9A90274B4C167B8A34BC724C33111911A6EC3B1E2726C60BC138AC0BC163A3A503A488C9621593264469483A4ABCA656E1D8268288B07035EAD0A760A090758319E43304CEFA525BE9C077D69D9F9D42CB828DA9C9A84D0CDE4F59B25C96C9BC943565C8C0918081F998C63CE1E1D744569C8591112E3146FDBE92F2D71D2D282848C531311C698CE73128C22B82513E9C01E148C077134521F5E5238382D250B64C6B5872D4C488911B50B9466F54A8D61B556A0C40DD06C351B3EE2094AFFC91107F20EA371C83AAD547A049B36F51BFFE3854ACD41755ABF642970FA6A2EF80EF70F85890EA82B64C65E22A2D1E1C1C9CADC9E94FB0DD4970CACF55A6549A4CE3FB935F942395E837DF7C939D8F32645E09A6BC758569A22B28180A9EC7CE58094B371E053C7FFE7C9C3F7F5E4107DDF3B4D65264E4ED127321822606E74C19D800369B55C19836A3D60222A3A971A52CB1CDD581202549882C230035379D1B768090AB32C48B796115B344152EC70EB1E133383B23C77474682EB15C7AFA6AD390D233727F9A9032C5307738E290D4C9896202F09F1E91349A587131B14A0B878484A877A770B596D64267E0E8A589CC462231B56DAEC9ACCD195E637EA78DA9CA611E7DBFEE288C0D72AA53B7204E9B74646A7A96A59FC1633D174DADCE7B1D760A9081B2B5890F122171B2FA154F4A6AA432578243EC68DEAC2FF2E77D194F97EE8A3E7D57E2F5B6DFA064997751A9EA0054A8E2A7885EA7C16054ADD90FE5CAF742B9727DD1B4C9649428DE45D8F4026AD6FE10BF2EDE8733E7C3B1E7E011ACDFB20EBB0FFA2B53F6DCB973888C8C54D0EFA7DF993C6147B870E18272EEC9252A062D5FBE173BF0840913D439654248D0334CA6FCD5304DBC1958302BA4B5112BDEBF7F7FF4EEDD1B4D9B3645850A15D0AF5F3FBCFCF2CBF0F6F6C6279F7CA2F229ADE5C8528A96A02D4E6DC3C00659B56A8D90E8AABC302B6ED8BCB1F171CA79BC1A1C4ABE290D7CEEDC19753D3A3A525ED2F8882505C3407387B3330C7462B599141C14A262768ACB9702E4763991FF13D486A14C04058AC96415475064157839387B843871ECA4D139E4983BE88E1D3BA6CA26D929743EFBC811351DAACED9780CD4509ACC940F031BE2EA55BE5FA6F25718284BA631E6BDFA1E128281E573B6C5D0B4A26AA51E945D42BC91EFECD9F392AE1A18172F5E54CF60D0F5F0F7DF994DF62B5744C3CBFD0C070FED91BF29E278CBA890C95F77D21F11E75B74C2F4E99B912B67433CF56477BCF0C26778ED8DA9E8DE6B214A94EE882784F8CF94ED81A7CB7657A858C90FE59FEB8DE7CAF7116775187AF6582866C67E1C3C188324E170AA98A489A9F1B0DA65D445AAF10E12282B767E8276F8BA75EBA4FD57E1D75F39E3B651697A925C2B52F28DB2E07DB416860E1DAA4C164DF2DB8569A22B5C0BD4F6361F4A82BDFFFEFB285CB830860F1F8E7CF9F22167CE9CF8EAABAFF0E9A79FC2CBCB0BAD5BB7561522348188F8D804836842BAC4F804FC347396F4E6586990005576A74E5DD0B051631992D3E19BE7019C38790E4B57FD8E82C58AA90F4FB678F5553491CEC49A597C72ABE1B177FFC1A8F9FC0B2AADF023C531F5875908080C458E9C79D51E8D3AB5EBE3FD2E1FAAE7972E550683060D1172A5C2D737AF22CC92C5BF236F9E07D575122A470E1F6CD8B04109F9975F7E511D97C755AA5441B76EDDE429F26C253E60D4A8512854A8906A9402050AE0BBEFBE535A3557AE5C8A80D5AB5747870E1D14D1292336E6F2E5CBE1E3E3A3EE2F52A488BA87C4F7F5F555C4E5104F1952762C974EE40EFFBDA23D5FC2B2A52B913B573E4C9AF48D10C22EF5C8A1CAE9D2A50B6AD5AAA59E53A85011CC9B375FBD63EEDC79A48358F1F5D75F0B394BC36A8B94D74C464858A0EAF7F25AE8D26DA4D8E5FD50A9A21F9E7C524C93EA83D0B6FD3474EC324B88DE59C8ED27E6CA4854AE3A1C55AB7C2AE41E2DF12054AED81B458BBC86CE9D2662F6EC9D38793A1251B12908B872499E6117457511878FEC5153A79C4225B157AE5CA9CC10766ACEC8B1BE549ED4DE9431CF1993ECB4CB29AF59B366A969574ED152A64E2EAAE9C5BBD2E87C00C16316C09E982D6CA9008F39D73B73E64CD5203A309DDA8E15A3A6D3F63A03CBA376D4E6001706684218BBD2A46C7B4AB65D49CDFCCBBC8558B37693BC003070E00879367026300223BFF816F1723CFD976598B3788DDA40D4BEAB1FC21333B169DF71FCBE752F6225F19B19F3B175CF7124C9FD83867FAEBCFE59B3E68B57BF53356A9FBE83B067EF219C3A7D019F8E1CC72AE1D0D133183761122E045C55C3F8D011A3B06BDF7ED14C0EACDFBC0923478E54EF4807891D801D72C080014AE09C2D58B870A112386392980D3776EC582909CAA16243F39E9F7FFE59C9888A8265314C9E3C59353265FCE38F3F3A9DC22C8C1933465DE731F786CC9C31075E965C28F670710C1E341CA121FC4D25D0FDC39E4AC674E0162D5AA4EE9939F327AC5DBB5E1DF7EAE5A766BBF6EFDF8BC9533E939464A43AE2D40F9B693D8E1FFF332C5ECF8A5C16A26CB99E28239A3B57BE2668F3F6D768DF6906BC72B54499E706A072B5D178E6996178B8B068F232C351B15C7FB1E73BA36AE5CE6ADBEEDBEFF446BCB4C5858B573063C68F98BFE06751200B7060FF6EF5BE743A192827CA9281FCE239B9A5CFD9E169BEF05D380BE31CED6EE02A4199B9A799E1860457A233D61562E3D01667E3D039D08179742760D05A9F410F57468F33EC63DACBC15703C57C895504A78D2C3944109794ADAE582760FD57AEDC2C0D3F4F117ED4D7B3B1DAFF04A6CE5DA58EBFFC6131AE4467C9F11C7CFAA560D24C1CBC188E8F867E26CD088C9DFC138262D2307CFC548CF96A0696AE10ED2CE9FD078D44A1A24FA8E3AFBFF901556BD4439BB61DF1FE877D50A25459BCF46A1BA438A443CBF564A90463793BF96B0CA3AE0EA9361328039DC6C6D4B2A023C57B785DA7B90EC91CA2798D260EA7D7E8EFE8192BDAA7DA41AF54A9928C3605E1E39D4F346E4D433EB4B9E57F9A8104CB27589E31E5CB09012D7F795BC9CB5FEC646425CADB24091C6A3573DBB6F3327A3D0BAF9CD5306CC43A3CF3EC87A8DF68047217688066AF7C822EDDE7A170B14E629F0FC5238FF744F1C787A061BD5978AC685F14C8F3265A341D06EF1C15D0CB6F386829510A070E1E96F758ADCCC2F838F111944233E4A4A1038F699E514992DC346338CBC277277F34A838B416D7A06C9CFCBC8EC366507F0C225E7F41139C81C26725B433C646D50DC79815611ACBA1DDC521891E357B2683BA4779DE461C131D8EC4043A738633C8B46BC191888D110792C212699D3C7D15ADFFDB1943474E56BF6679ADD360C4887C1ABCDA0D0BD79FC0C07173B1EFAC15833F5B80259B2EE1D329F31028AE43AB0EBD112BF99BBEF921D6EE3E8771DFFD8A3153E663FDB61388911E60C9510416EFC258B4721BCA576B80AEBD07A375BBCEE8E1D707050A1642B3975BC22EA30F9B2229D5A6B0E7C041BE46B69D4EB252160CBA33F3FDD910BA11B5B34567938DC4A19A64A62C390270542478CE554F1E73F681E519B313E29BC87B7065D8CFAF2F1E2CF0387C723C88B2CF56A7CE501ADE966A109832A32C8DA951B92869A95663312AF45A909C8AEC99874D96251D8FFF90AD1C1E3C1C821C963AC899A38574A4D6F8E28B7D78ACC46BC8F3401D78FB5643ABD7C78A49B34008DE09F91F7D0F4F94192466CC303C5972382A551E23A64B3F615005D4AEF316C242C39579CA9183EB25F1B149CAEFE133B9814BF38581B2E2A84593841A9B23117D1797B586EBB8689646DC2CDD0CEA8F6BAF701D0A58190E399CC0A7F3A01B91810DC93436BAF31E657ED096EADBB7AF1A76391FAAEFA13621A13333EC42E8082427D1194D57E78CEDA9E22C0604AB46BA7C391C3D7A0DC5C8B193D1F1FDBED8BCE318BAF88DC4892BF168D3A92F4E0AA3DBBC3710FB4FC7E0EDAE233169C61A0C1E3F073F2DD90BBF4FBEC7EA6D173178CC6C9CB9928E45AB8EA1D7A0EF3073EE0A6CD876180B968850CF04E2AB6FA59E4346212AD1861DFB8F62F7FE039832ED7B6CDEEEAF4890200E281DAAB8A46435C45346BA5333E88E4D93432B009A6CD4D2ECE8345FA8997FFFFD7765B6B0E393C0CCC70EA1CD1306A7A2712E0C65296DCE112E2E2E41399DCAA9149ED4908EE965F1CDD6E69111B106B125709A9133307A54341486B881A99C464D41567A0A9253C21016795E2EDB11121D845A75DB898F530A152B7787459C50BF014B51A6C2FBC28A6AC85FF025BCDB7516AAD6EEAFBEC1F2C853BD51EC093F3C53FE53E42BD0094F3CD10D8F177F434C96E7C4B1950AC833699AD2FFD2130169DC0D2931EB4EBED0D4A5C34972735B0489CE052433454B903B7742E65B41FDD1446723BA34A6854329871206DD286C24DD303AE8C66760C59897D0BDD8C8CF97CE501BB8F6ECDE89A54B1661E1AFF3B160FE3CAC58BE1413274E12ADB603D61407F61F388AB9F397A86D9FEB37EFC5AA753BB062C3761C3D1784DF37EE946612BB77F6124489069F306936E62FD98C73979371362009F317FB63F088EF70FC4C344222C48E1E3A193FFDBC0E672F042B0273B84EE50C901C13DC8DC77513B50D400C563A67DC1A10176F2C54115CBCD2334D6C186A1F0EAD7A458FA426B9D7AC59A346343628E78A19D8C09403E541F38F9D829A8BDA5BCF27732FCAD6AD5B55A79832658A72B8B82046AD6EECE0939A4A452E5D0CC267E3BF5433A80CB45DFFD094464C1F47CFB6F01A67A7D4B4AD2349140D6758A4BDA4B85ACFBF27242F21C4EE8D879F7C07F90BBF85D9BF86E2D06960C9DA082C58110A7179D0F2F51F84E8AFA17C9571F0C9D31E790BBC83E62F4F14E6D4824FAE0AD8772048D9F9DAFF22A8D9B920187E2D021161D1D8B461AB527A9411FD36E7D4B3E29E3B91DDCF6FD609EE14AA606A64929D8DA1350E353535104D16DD58AE81F9580967C59466E33DBA13B02C96C37CBCD7D882C9328CE9C180808BB874E9829A69E11E0E362EF371462F2C9CB302061109EE0562D351C32A074A8ED5A29EC4242ED79DD4B1F31AEFD52BABCE5D8A2A90040C467D8C05172EBE701E9A2BA831B1F1888A8EC5F113A770EEFC45B50F869BBEB8F98B04A736E22C014D18929D8B1A2435DFD33D68F9B183700685C4E668C7191C9A2EDA2E27F13912EA3508128179B952CC29C2D0D030B1DDC3A5CEEAB2D4D5888D6955439ED4E424339FC9C0EDCECCC7750AFDCE5191A132AA1A726AD67C80B47C59E4CAD30E55EA7E825C0F7446F167FA205F91B761C9D31C058BFF17798BBE8A020FBF85FC45C464293D18B97CDBA3D4D37D51BC4447B9B7321E2A5C03DF7DBF489486B38D44D951A634573992AD5BB7014B972E177949CF31211EC1FCAEC4E63965C6D18EEFC232B51276EF00770AF5870F604C9292B0DABE64CF634F64207139B4BA3A5B6C60ED24680DCECAF19C6530AFB36C394E540D4252E9A56C820B447AA99D2B97DCACC5250D6AD8E8983821A06825F58E7C61A351998F31CB34CA0262E242E4DE28F5E11B9B234E1C457178F9A5A72C7AEC5635D3A39F999C94A036FD1F39BC1FB366FE80E5CB16C98832119F7FFE39162C5880DF7EFB4DCD2A71368431ED6B929A64E73B31E80E4EAD7AE9D225659AD04459BC78B16A6812961A9E33347AA666E9D2A5CA0CD4D36B942DB53C3B0267A9A8E9593E9DFDAB5743D45A43B8747A6A75B60B17A928637650EEDFE6BA039506DF89C4D01D4E2F42A9FB12AC6AC99F76BA74678C1C39575ABD38F2E46F838A3585F03E6FC22BEF5B285DC14F34F7CB72DE020F147B07B90AB491F357C46F6987924FF78097570B54A9D21B4F3FDB56EE7F129F8C98085A286CAF556B568A1258AF46258E50ECFC8699668C46068CD575093790F05E497C3B507FF4835C2BC2346A166A1F125E372C894C1233661A094E5B9D693A0FD358161B8D44E03197D235B8BF85D38DFC591D873CBB387CDC70141C1AA2365071F7A1D2EAA2952824FE28832382EE2C243D77EF31A66DCA1D713CE6C20777F271071E37F8F30398A956129C5398A958B776358E1D3D8CD5AB7EC7B75326E3AB2F3FC7CE1DDB3177CE6C35BFCB4D68740E6992E86DB67414993E67CE1C45E01F7EF841CD3E91A8EC1C343798CEFB66CF9E8D69D3A629E78ADA9A9A5ABDBBA195546313DAE9A27C485E9A8824C9A953A7545E92995A9944E1CECDA0A0603966DB640A81B8CF864EAFB10ACAFC2C8F0A879D814A8372626019761BB735C8B305B366ED1447BCA438B5AD50B3D66069FDFFA2F8933DF160D1CE28F4583B3CF4E81B2855B60B7C0B344391475F4399F29D91D3B72172E67A013EFC179E2DA5E1ED5312AD5EED807D078FA9F65ABF719DAA0B579BDD3F36C4453AF79FC36938B9927D4E39E934BE933E66ACB5FABDE086041298B1D6EAD4145C68E0643D1B85C2652081D96B795DAD648A16D15A9CC4675E0A9FE0756EC98D0C8F50CBE94909896AA188C75C38E279724AAA321D686AB071939252A43CFA03DCD494AC367745C7C6A86D018CF9AF2A44C544AADD85C1A157D5964FFEA88226480A1D32091CBAF9630EAEBC7255F4C0BEFD3871EC388283AEAAA5FDD3274FE1C2B98B3879FC1476EFDCA5B6A9EEF4DF815FE72FC0D2C54BB077F71E6CDEB8496D2DA68626F1E9B35073D399A216A622E02840B386C74C633E929D9D80DA9C260B47097606CEAEF03ACBA066A71944F2B341F548C9C0BA53D404B53A49AC475BCA9A6007A11D1F2B72A3CCD81E31E203D11CA34974F182F11D16EA8601037E43AEDCDC2FFE120A166C8D92257AA254A9EEC899BB299E2AFD2E4A971393C4AB0ABC7D2B4967784A75088BA5040A16AA8A766D8761C0C02FB062A5BFC8DB30096962B22EACBB841B784485A68F6DD67FFE3326D79D38873E75CC1EA6B531036D4A7ACB6C30DAA9243409AC9D2B82C7B4D1B8CF83433D351A9D331E474746A94D52E1D7C2D4715444A43A26981E285AEB5A5804022E072A478CB6291B38F07210AE8584E1C2E52BB826F785CA7D17AF042222265AE2CB2A8E8E8FC39560216F42BC38971CA6A521646488888A448F5E3D556368ADCAFDEE0CE4949A962399E4582FF7DBACC6F74BB8EC7FF6F4196C5CBF013BB6FB2B82528B53DB939C7446B9D24782D38F21A8FD3912504E3453A8A5391343B96A126B1384332B8C79CD4916554712422B133A95DAC6663AE7ED39CAD2D4898CA432891345C30596104578CA991BD6E2E262949D6B4BE5742EB076B53F9EAF2FA689A52EF2E56F8C8A153F92E3AA8232F0CD575E085E4C08FEAC9C3F8167CBB7402FBFCF3163E60AECD9CD6D10F270A90E4D49D68A8A881BED58476374527B7EB23F49E1FA690AB3EFB1DC4A43FF5F7606D3440D56882FE3DA6B496436309D2ADA9D1C6EA9BDA8C948009ED36625C1497C7606DA9C041B8836293B0D9D2FED90F198761D1D2CA6517B123A1FC14EC37B7559FA19B49B9997CE21471D9241938A8DCDE57976423DCCB3F36AD2338DD0E42274E0319F337DFA7445589A2FB4B9794CDB9ACFA266D65A9DDA9A79A8F1398B42D9B0FEAC371D6D129E75A48CF81E4CA746D6FE0CEBCA98601DF548C874D68FE77C5796494543396BF990E0B4D92F5C38A7CAA79220F1CF9EB988C3878E23A74F5E69E962F0F22E2EF1E342EC27252E8EDA75DA0AA1D763D1E2BD387AE222226344438BE848372A0C7BA6984862D78B01A864A2F940F96AB949B88137FF469826DE0E689E90986C400ED12401B51B8FB94187C3F5DCB973D5F0AC97729987A4E0B04D82F05E6A41DAB8048F35F1D9883C66C3F11A35A926181D3F82042248386A58BD7742E7A3D6A4E940CDC946610391484EF34C8D569A5C249C61E31A4E131B92E9D4CCECC81CC968C7F35D688BEB850E3E877560FDE88871CA90CF65792406639295E5D2CCE333F87C6DE291CCD4D2242BEF63A76467E5B1364FF86EEC241C553862F039941D6540F9B2637125922B8AEC98ACDFA2454B3079D2771837F673346BFA32FA0E1C825F7E5D82CB41E18AC89C12CC9EAD123DE6148985CE3F67ACF84BAE54BBF16B2B929D8132E43B69C2F3DD08E7A86FCA937F0B4C13CDA09DD03F7B296A1E360EC94AA292BC1C01487236041D39CE647CFBEDB76A6F3117963EFEF86374EDDA556D96EADEBDBB3AEFD9B327FAF4E983810307AA1D6BDC28C6983B22870D1BA68E190F1E3C18BD7AF552E943860C5131EF1B3468907A06EFA78624714974128CEFA13512DF8BE03963128DEFC86B1C91B4D666E7E4FBB023CF9B372F9B64DCC74247954E2AC1636A75767A760A7634E667C720788DA302353EE541A540797053171D59C65F7CF105468F1E8D71E3C661C48811F8E8A38FD40E513F3F3F35427DF9E5974A767C36EF656764076047A7A6A7FC75D05BA1F92B24EEBFE72C15894A5910FC591E77864AB8A12D4962CA84A4D60427FE9734B98669E29F8164A19622212804A6E9D80C14967BDA5F096A4AD758839D8E8B39D49AD4EAD49C1CFE69425163122433CD20BE138FA94D999764612725296922D13CE2FD1CC5581EF3D37C1B3F7EBC2232353E49CB8E4CE79420C9B9498BA31B3B0047386EFA22C9494C96CFE7B1E3B99287F222C9F448C334AD455D83D6AA12D47D5AE332DD297315D4B1F09DB35BDC099D66CB8283FF28BF3C92CBF312D4FDF44D5CED6AE3379BC6F1FF3A6E48B8596FA55674152AC1BC2493AB96BF15E1DDA135867BFADDC29DE8242E353003494D92338D5A9B0E33894B5B999A9A6426E96897EB51892609D378CCBCECDCCCAB3BFA8C19339439C367B9E3CFB41EAFBBCBD30C24AE3EA69CF98EBC4FA7BB3EC7797C5D30EC697164C3A3101D1907F5253A725C9A8CE02FEC9CBFB253DF5AE4A748089EDF0C7C8E6BBDFEEC5DFF0DB821E14E2BED4EEC3B21FACD40F2539BB1516FB73CDE4382EA73E77D4A5B73DA8DB63B894BCD4CC2D3B4E2353AD7DAD12589E91493D4CC475B9824A7BFC0739A2B34C16833D304A1C6D664E5F358073302BA12FA56F2BDD9B5DB69133E57CB8BC79C77E79A43023FDC496673D77E965C4B3388CC5F6819DA9BD732D53CB804F3B25DB43EA19FE19AF66F8769A219286C4380B767A351FBB86AFABF03AEA463CCCEC22941129764A50347E7563BC0243EA70549703AB074F818B32330EFD4A95395F34C93842B9EBC8F1A9FE5B27C8E720CB76A7477596939BAA699E16E64A74747D7F2B9802635543B1615D99DE91ABC9E9179E3C8723B6DFCBF04D3C4DB8526D43F0DD6C3B52E9CD9604C4D4E87904E1A094CA798C4E5EC05D3F4D4A09E2A24D13945484792332ADC6065EC29119DE79CB16170258126BD2B5C8966669ADD8AECBC76AF24CBD073DA8AE4FC9A9711FFD9D7CCF87347F7B4FB05A689AE70153A97D8F5F1AD484E0F9F715ABA4102E3FB23EE79FEDC3EBD13F08338EE69044D96C993BFC6679F7DA63069D224B574CF190E82FB59385BC3190ECE9A7026830EA5EE007C7FBEABFA392B7920E0D708E8D8E96798C158B237BFF66F00DB921D803F9426DCAFDF6F304D7487ABF6717E08F23ABBF3DF00EEDE734FD3E0F7BE19346919F4742363066787BE2ED0E96450FE428A03294956F5C302925DCD60B8AC0212CE1F2B5FF76CB3B47F03FE20BA4176F7EBF71B4C1309F7A1550F87B78273B9DAF4DA9F417D54C7245DC3F8268BF93577386DE7EBD24856125B139A363049CE58696CB946678EEFADAFF11E1E13D4E224B886D9F2B62BF80B1FC686B5609EE79F862BD9DDAFDD6F304DF4E0FF1F1864FF778E3A7F254C133DF0E07E8369A2071EDC6F304DF4C083FB0DA6891E7870BFC134D1030FEE3798267AE0C1FD06D3440F3CB8BF00CBFF039D8DE6003B4B2FEC0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A319'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000D500000047080600000090EE02CB000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000033BE49444154785EED5D077C14C51E3E08310A48912ABDF72A4A1314A90A881401692A36AAA08228D24504459FA2A2481150AA20A0D400A127F4404820210921408014D2EF2E97FABDFF377B931CE14045407DEFE6972FB33B3B3B333BF3AF33B37B26002EB8F03F87B44CAB44CEAFDD6D384D74C105176E1F4E135D70E1DF86D4D45410D7A5A5645C774EA467A464A7C5C6C6C06ACDD168365B9A3AB6D96CD969B703A7892EB8F0BF00ABD92291719C9E66832343E5862323A5A4DC3CDF1F81D344175CF8B722C36641569AC114B69464151369E9C948CD30CEADE916A4A61B4CE48C811CB5D7EDC069A20B2EFCDB404D946AB32225251E19E95685DC7952326E4C4B32E7301E4113D2C5542EB86007194B1F5BAD66759C68C961108BB858892A8B711E97649887C9C9C9484A8CCF4EFFAB709AE8820BFF764445C7C19A9A857317A271392605D784C7A21381B0880444445BE17B2A04B3667F2559AFBF2FF764C7EDC069A20B2EFC1B6111F728291308BE90885F7E3D86BCEED56072AB045381BA285DB31B4C855AC1749FC4793B229FC72342FD1E48488C915B73CA888931CEFFCA6485D344175CF837E1DAB56B12C1141D978A0B91E9D8E37D097DFBCF14EA6E2E6886FACDC6A24BFF05A8D8783C8A961F86C2A507218FFB2368D0B825D2ED7E96D5624CA727268A3A93D86C36CCC7DB81D344175CF8372220F43CB679F9E3C55766C194A7154A97791D268FDEE8F7C666D47EE20BB8971D85CA0D26E1C1522FC1CDA319BE98B30869A939D3EE19E929484A4A52E77FC50C749AE8820BFF54D89455661CA7A6190C9160B161DF315F9C0A0BC3941973E151A001AAD51286327541BD1633D167F8463C547F2C0AD71F83B27526A054A51172AD21F6EE3F8954DBF51AC96231CA7431950BFF97B87AF5B24430ADDDE8854DBBBD71293909F51A77103FAA2E3C0A76857BD141E8FECA3A747D7D154C257BA27A87A94A5399DCBA8A266B0CFA60BCDF19B4C6BA1D384D74C1857F321CB5C851DF736A56EFD0994BB862CB80A757B830CD63C8FF507F74EBBF1683DEDA8D07AB8E82A9F40034ECFC394A8B96CAE3DE158FB71AAECA70B69E45688D753B709AE8820BFF06586C99F0397A013EC7A3B1F3683802A392117A11E8DC731A2AD41E81295F84A251BBAF90A7F86094A8F52E5A775F0CF7FCDDE096AF3DBE9AE32945DC58A66B4ADD85FF6B2C5FB51E21E7D390AF60238C9A3C0FB192B8637F1012D28071D3B7A1CAA3E360F21033B0D460B4E83C0F0D9F9883BC6EED85EA1FC741EF68C9EDBCDCBF0AA7892EB8F04F40BA7D222237CC662B4E05F821EC6A1C267EBE1A0FD7ED8747DABE8B4DBBE291900184C7016B7645C154E419988AF640A986EFA1658FA5707FF81D980AF586297F035C89CAF199D26EB1D1F676E034D10517FE6EA439F83A2936FB46D834C3340B0D3F8FCD9EDB60CE025E18F1199EEAFD29BA0CF80EA3DEDF889D0762F0F5623F347E6A0ABABFBE0A75DACD40EB3EF3602AD14F18AA2F4A571F86E66D5E53E568586D1658536E7F6222379C26BAE0C23F019CEEE63A52565606CCB654A40A13855E8AC2464F4F58E5F860C0559C8800464D3F008F322F8A06EA0253BE26285FF3153CF7F2728CFED0172B7601C33EF446A12A43F048C7CFF160D9FEE8F7CA34D85898635D37D18AB703A7892EB8F04F42426232F8BAE1C9D321D8E9730287FC8250AC7C6D7C326F2BA6CE3D865727EC45CD5653707FD93E30156C02539EA6A8FDF8244CFA3A1483C7EFC6332F2F439B5EDFE18561EB51BBE99B58BC628F94E6BCAE3B01A7892EB8F04F408AC30EF3A8582BAC99C0DCA5BF0AD31481C9A33C5A3C3D0683C76DC6C74BAFE0A385417861D462347F7AA430D408546BFE1E2A3C361E794A0F100DD611F59E1C8F7AADDE83C9FD316CDDE58734871DED771A4E135D70E19F80D818634F5F52521A962EFF153EBE2158F1DB1EE47BB0024A54781C05CB74C1E3DDBFC6672BAF61D309E04C1C10292A6D9BAF05233FDC0153B1BE3015E9853C257BE3D9410B50B2DA6014AFF434AE29F7C9799D77024E135D70E19F845301E18A11E2C4EDA1E7131167C333BD46E2B1766351E789E9E8F0F24A4C9977125B7CCD088C05D67B5F43CFA1CBD0BAD7424CFB2E1C9F2CBC80CFE7878BC9F81ABAF79F0C4E77A4A52521C3D8F3E4B4CEBF02A7892EB8F077C39A64CCF85D8E88C6966D07B0F76020422E5A109F95021A85A2BCB07AF3550C9B7400F5DAFF0775DA4D44A9FA7D705FD98E285AE32514ACF2263ABFB401EFCC0AC0E439A7D1F8C98930B9B5C1D8298B614D079213AEAAF2EF069C26BAE0C2BD4666A605A9A9F1C84A9538593448460A7C8F9E42DCB554CCFE749E506A3994AFD00ADF7CB3019FFE6723BCFD13B0FD5816C67F7E0C8F3FFF19AAB51E07B70ACFC094B706F215EE80E2354788A65A81563D17A07CC3B725BD29F2E56F85C0331130DE9677DE8E3B01A7892EB8702FE0385940A652695C2F52B3DD9958B761277E5CE609937B45D1328D50B8641BA1D846A8506B10F297E98656DDBF40BB7ECBD073F8263CD977119AF5F80CFD5EFF0E23276CC2E78B62F0E9C2083CDD6F29EAB71E05B742ADF0DAC839C2B810A6CA428AFD736477034E135D70E15E2125C582E8982B729893161C128E35EBB721CE0C3C54B62D4CF91E45B93AC350B0EC40980AF71026138D544C8E1FE806B7F2C3F1D8B3CBD163C4368CF8C8079F2D08C7F439A198BB241EAF8CDC84D255FAC2E4D100EF4E998F03C72E214B18D622F69FF52EF95384D344175CB817B0D9AC48488883D99AF345A3645B3ABC8F06AA9DE7AD3A8DC553DD67E38DF776A37EDBB928DFE413B47C7E35DA0D5E8C628DC6E289FECBD0B2F70AF1A7BE46B7212B31608C17BA0C5C8B161D16E0C1122FA240C1E784C2ABE289B60370352105F1A2A5C850BAAEBB05A7892EB870AF60B36F3D22B80D89EF4609FDA3EF4B1FA37DB74FD0A0D54CF47C75079E7B6D377A0CF541FB57B6A1E75B9E7876E856747E75057A8FD8846E2F6D45D71757A079E7AFD44B88351E992C94DD191EF73745F3667D604DCB84457039C198A2D7D0DFFEBBD3709AE8820BF71AF1E6141C387C0CF1E25A152FD3484CBC2678FDCD3568F7DCF718FC9637BABCF80BFA8DDA8BC7BA2D41C7016B317CE221B4786606BA0D145FEAC9AFD0A1DB0231F3C42CCCD701956BBE2E5AAA03F2986A20FC7CA272D156AE5D85B3E743E408266A464BCAED7F83E2F7E034D10517EE05CC560B92530C6D7125261E9109C9E8D5FF15E4CD5F0A058A34572F1B9AEE6FA77C2753C13678A8EA00B8971C883275FB09E5568229EFA3285ABC8BC475E4BCBEA019CA557C5A18AA15F2E5AB851D9E616A7B536A1AF0E3F21F543DA9E9627226C58B4F75E7F6FAE586D344175CB89BC8FD5D88B8642B76ECF7C1B78B7E42C1E225116BB1A16EA3EE429DD5D1AADDDB58B9EE22A2ACC0E67D1130DD57097D064F03A7196C9940BD062D91CFFD61F89D4A548BBAAFBE3C49EE2B875D3B2F205DAE2749553162F61D3FE12B5773EAB4D93F0D7D37E034D1857F1FEEC41BAB771AFC7CB2E3B439778267C19AFD4D73FECA467C9C19BB771FC6966DDE428D0595A9664D49C78EED87E4BC14824E27805F66DEB9D3077E7E2158B36A3F32D2816143DF47A6643E1318A2CEB76CDE8F7DBB839121DDE0B9C50B99E95930BE589B865DBBB6C0DFFF30E2E38D6F5ADC6D384D74C1853B0D5B2AB5533A3885CE9092920ADFE3A7E07F2A488E813CF90AE0A34FBE4046562ABCBD4F20F86C8CF8444590CFAD04F2DF5F413116198E8CD7AC593B54AC545D31D5EE3D07947937FACD0F24FF832A537292D2421232919169C3DE7D3B8551E325BF15FC750FE26E0A21A789B78BDBFD5886FE1913FD5144C7B47F323830CE06876DFFAB3FC7F267408DC0EF81C7C5C5298271BC161BCB97CCAFCF7FAF70F9728E66484E4E84D99C443A071D9D2B9763C5443BA8D68DF2E6CD0FB7FB0A2045B48B7F40107C0E1E43427C266A546B81653F6E132A2D24CF0531F10285F91EC0E2A5EB84495251A44869142F5E4E319BBB5B218C18F1A6149F8594541B94BF664952BED3C1C33ED9EDB815EE14A3394DBCDBE0D73FF52F2B0407078BFADFAD8E5DB833888888C04F3FFD2487CEAFDF6BC4C5E508CB9347FD7060D7212C5EF43384F651F4A16A428545841184D7843BC68E9BAE261792453EBFFFFE57C89013A6D33F2233859C8F465CA291C64F8C0D79632C526C19381B1486CCCC7458D3CD62F0A54A199948CBCA446C6202BCF6EE81D9BED84BDABB99C0BB5382DC69E25FC59FE1F8C3870F63D5AA55D94CF6573E0DF57781CFCBEFC4E5D6141C407E9B9B1AF8AFFE3C8B33DCAC9F8F1C39823163C65C57E7DFA1F9E3E3AFD7929B366DC294F11390624E87D03BBA751F26145811F91F6C84B56B4F62C890D9725E0C2F0F9E82458B76239F7B557C30E17B9C389188E77B8F81C9AD24BEFD7E3BB6799EC6E4C94B70E8D045E4359540D72E03844133C587026212AF8A91992A8C956EBCD8181008BFD367148369C6BA15D8A7C4DFFE2D75120FCD8F5B3584CCE2C8303C5EB87021962C5982C58B17E3ECD9B358BF7E3D7EFEF9676CDCB811AB57AFC69A356BF0E38F3F62C58A1558B97225962D5B86E5CB97DF12CCAB6342DFE378CC9892DC118EF9741E473896C9FC3C5FBB76AD6AF32FBFFCA28E196FD8B001BFFEFAAB6AFBD2A54BB160C102219045D9CFC9E7E3B3F07E5D0F9F91D0EDC85D6F6EB02E96C1B6B03E82F5B12DAC9BD73FFFFC73551ECBE53DEC4FC62C533FB3637DB9CF09C73AF5B32F5B6660D5AA9FE559D64ABDBFC873AFC7BA751BEC31FB618DC2AA552BD4F34F99324509CE7DFBF629F38F93098B176F15EAAB8266ADDF44C9B23DE5B8098AF2432DA6BA6A9F9FC9540FEE1ECD545CA8E813C8EBCEB4AA285294796AC2FDBEA61297157FAB3CBA3C3D4899912C3BD11C2306603A1293939459B87EC3665C8A8854C777FA032F3783D3C43F02723325A13346623A2537CD909090109C397346A4CA21F8F8F860F3E6CDF8EDB7DFB07DFB765CBDAAB6DFAB40DBFFCA952BAACCB4B43425E15906E3848404C5B43C2703DF0AFCC07C7C7CBC8AF531EFD7C7CCA3CB7204D3F4355D168F739F5318303FCBE33935407ABA485E35AA62A6C831FB84F9F92C999974228CC0E7625B747B9887E5E998F7E93A3574DD1AEC27FD2CD48CFA38323212F461789E419B4902FB975AD2F1B9FF28989F6DD2EDD3F75BC4E64A4A623F274BB989323EB1D9888A8A41C4E570C427C448DD9771E1C2F9ECE7E7C404F30BBD63D54A4FB8DF5F1B2D9E7A07ADDA7F888A3586A35EC3B1E8D8F133B46C3D15751B0D47C34747A176BDD1A853FF2DE42FDC4931DE234DC7E0D126E371DF7D6D51B80837D796C58C99DFE24278A4AA2734988BBB69D2B6784445C6C26AC9C4FA759B101D4DF33313B6D49CED5077134E136F859B99114C27039C3E7D1A478F1E5520239D3A754A0D2E09C991C0C8944C23E1911074D07948B88E81444B62E1F55B41E7D58169FADCF13A8F599E2E53E721E1EB73C68EC7BCC6FC3C674C0662CCC0EB7C269D4FE7E5B9BE8781E9BC8FE93AF0BA63D98E75EBFB3518F47596939BA119581619C0B10E9E33E8BC3AE8FA74BAAE539F33D66DD0E5F3128B26D2C5D961AC037F57D798E963A2D11764EA6BD7E2D4754B02D0BBE76854A9DE1D5D9EFF1C95EB8D42EF412BD067D072B46CF5311A3F3619ED3A7E8D3EFD56A04DFBD9E8D0F93F68D7E94BF4E8BD108D9B8EC3A38F4EC6EBAFAD42854ACF60E2A4EF111543A19E8E90B3C122C443D587628E1D39AAAA3F79FC0CBE99331FDEFB7D70F4888F08F763080B0B53C2DED9A40EC131643AE932F7B53F0AA789CE702BD38E8DDCB2658B326DBCBDBD4532442BA6B0374C0D8C2608FE22383752464747CA5926AEC5C5E04CD069713CC5124EB7498A10A6481B1538AE820CE920DECD2B59E28C228B67C6E033B06C35F89297B7A48B179B9621C4A67209C130967F1A3C4F4D1323418AE11A0703CBA0A34B5BDF4E4FD96D4E4F4F9534D64130DDC8601096D106064702E7BD1A0C1C281298BE6E1FD0EB82D10683A039B80CD4148E6532B01CA9599E83311F40333C9943332EFD028B9A52E675065ED38CC15897A7EBCA5D37AF3B5E33EAC8612EFD3CBCA6CB239319215368204199F5972E4622439A1AE01781E1AF7E84DECFBD8B275A8E44934746E2A9A7A6A16EBD37C5ACEB81D6AD27A147AF4568D16A3A2A541E8AF69D3E43CD5A23F054DB0FD1FAC989A85CF545942FDB19552B3F83FAF5BA20813F7EC8F16295F26C5942285999A9E25B89B5A37ECD83FD234252183DF2EA4561EC081CD9B75BB007FEBE47F1CBEA553871DC17172F5EC4D9E05058AC77C6EF749AF84711101080AD5BB72A860A0A0ACAEE60828131CD060E0C198CA6CBA54B17784506C418ECB884585C8CB8A0988AFBB1E2CDB1D23FE94ABA65A4098BA5508A0BC410E71A86E690C47811793C94AA525329F939C886C437EA37EA2003938035232424254A3D56550C998A03429386F9780F172449187C1696C5A089C9009FD1A88B81C444F039798F5DF864DFCF67E7B3E860B425472369A6619BF5BD2C8B41331EB58C2660D6CF638B2559311599C6FE539C469BE4C1741E3E8FF14C56D546B69BB16E832E9F75F35C3310F3E8B6E8A0CF592EF3B3DDBC8781CFA7EF65FD3CA6B662FB4E05F84BBBA54DC287CF76198C42F73F8AFFCCDE8E6A55078A29F7AE30D54C346B36059DC4F47BA2F57454293B0CF56B8CC173CF7C81275A8C47F1A24FA36183FEA85FBF17264C588479F336A1438741A025C9721938CE19C2B59902FE1C8EC59CA034D3CE1D5B25F6C6FE7D5ED8B17D33E2E3A210111A8C28A1B7B8A82B387AD007277D4F288BCA73C776ECF4BA33B3D04E131D4135A98F1DD791D8C97460D9C18E83A1831E301202030780DA8B8CC53299CE3C5131D1381B122C439FA5D61644D6E1F2D508E33EF9BB18765EEE9641B426222939166936D1578A1B64A02D5287C424167EB5544949D12661E7B8CA4E06E4A00BC150D38816B289E426C30A092BC6A206E47D06A1C875BBD9C267D384CDEB090949D27EB94B8AD33E0599CF6A4836D5070C242E3E239F957D615F235204A8CD5F5EE73183F6292F5DBA6467821C338D81FDCA74F605C1FBD80EE33C4369FDD4D414550F9BC0F6C5C51AABA4FA990806FAABEC523D462C9BEDD2F5F298C1D16CD46D617F68739CF98D761842468F3303F371068EE3C04981CBA21DA44A49077AF41886FC0FD446B162CF60C1C2D3A28186A15EBDB168D470021A379A8C471B4D42DD9A63F0C4231FA151F5316856EF2D54133F6AD5D22308F28F4648D0259CF63F8303DE47840E52B073971796ADF8099BB76CC06F1B7FC12FEB564BBC0E9EDBB608231DC2F9B050D164D23F6A4B54BA682EB3D081151619A33051006428FF5327712D9A7D285A3DD5865D7B766B5ABE8E07FE2C9C266AB0233980EC703B01645F6BDFBE3DF6EEDD8BA14387E285175EC0F9F3E7D1AB572F74EDDA55A9531D74C773A018938014C348E003F0283E31215B7B9CBF2C5A4B089B81EA9C89C9624690D809E6E1FD94BE242C6A3E9A3A06F1889614696598887226CC7725820B90642C19D9AC34D8D45699CCECD921AD7128E9988F84CAB20CA234DAC18C163399D4602A127664A40C74C8399587264E545494029F57132A038FED03A582E335F607AF69C264CCFB192E5CA046379E9575305D9BD30C6426B653F7654CB43074628A5AFB216133704C18F473C4C6C6AB63C736680DA4EB65609B1CDBACDB4786646DE9C2BD8C35A8FD53A552BEF867BCC9C13C320ED29FD7E2CDF874F622947EB8B9986C7DD0E4B1B7F0F6BBBFA15EE331A851E76DD4AE3B0E75EB8C431361AAC71A4F42A39AE384A1DE47933A6F8AC6EA8FF9DF6CC189A3671114E88F4D9B56E1AD31C3B170D15C1C3BEE0DAF5DDB84C97623EC7CB0A2078654B541976660BAA29BAB572EAA7B3DB76DC2E21FE663EBC6DF10161CA284331BAFFB9693695FCFFD86455CC703B703A789043B9512D02EB1B3D74438DDDDB1634774EEDC192D5AB440BE7CF9A41413F6EFDFAF62E2D8B163CC6B0C820CBA26060E8E7D955D31EAF8F1E3E12D122328F8AC1A9CD38167D0E0912648B2A660C6C7B33068D04BF2C05968FC48539C3D170EEE646EDAAA95F2AF3E983C09933F9CA6CCC6FE03FB619BE726650A15295244EA04962C5E86FEFD5E52E65DB76EDDB171E3AFE0A7844B942AAEEA3AEE7B121D3B75511DBB60FE620C1D3292CDC2CC9933F1E5975FAAE3BA75EB0B71A5E3E489003CD7AD977D10805F7FDD2892B79792C89AD85BB66C8913274ED8EFABAB2668F88CD5AB575744CC29EE912347AAFC6DDAB4C1BA75EB54DE4A952AA978FEFCF9E8DEBDBB3A7EE79D77D4F43543850A15543FB24F070C18A0B4E3F7DF7F8FB163C7AAEB6E6E6EC24C56A458B33061FC4788B8188B216F8C421E93BB304C2A9E7DF659659EB31FCB9429A78868C78E1D6AFC189E7BEE39357DCEC0FA39EDCD3CE5CA9553696C67BF7EFDD4F18C19333076DCBBAAFF4A942AA998C86BF72EF4EDF7824A23C8D08CD344AEA5CA401D3B118E668FBF20745143EA9A86FA8F8EC05BE336E0898E1FA15ABD11A8547304AA541F89060DC6A146B53751A7D618D4AEF916AA577D0D050BB6C1F4E92B71FC4498AA273A96C25A2C8B749ABED4E206B3D372080A0CC5BEBD07D5B37286994B185CB2D153FCDBB76FC3858BE7947543C6A3C0D65A9B828553FEEC57094EF9E1CFC069A2662047D064E3EE87AFBEFA0A5F7FFDB52298CF3EFB0CB366CDC2BBEFBEABA6CB5F7EF96551E9F5D4B10E6CB83623C8A0972E194CC5C029D63801072129D9221268311A346EAA56C85F7F63385E7D6D1868E13DF4705584475B71E4CC15142B571DECCAD1E326A34EE316EA53C0050A1583D71E6FF532DAFD0F14524C3577EE52B47DEA39A91F78FCF17618FBEE7B524F265AB46C05B32555182010050A94A050C3D4C9B3D1EEA9AEEAB86387CE183BE67DC58C26533E1102571513E5CF5F30DBDC9B366DBA30EF438AC1C2C3C3D56C52FEFCF91501F2793D3C3CD42E11CE3491E8195E7FFD7545C81432C58B17574C4406A310624C826DD8B0A1CA5BA54A15C5588ED7B9D6F5C0030F88F6B980D75E7B0D5DBA745133AD55AA54C3A183C7F1D5970B902F6F6178B83F240C951FA34709D3493F942F5F11DF7EFBAD8C810579F3E6530C4EB3FDE1871F566DAD55AB16A64E9DAAD28B162DAA963B18582F898D8456BB766D25387AF4E8813E7DFAA8F6B8BBBBAB7CBC5EB1624575CC32A8AD399E1C8375EB0FA0FFA0C968DBE12D54ACFC3CEA371A82BC0FB4C607D3B6A27AA3A1285BFD65546B3012E5AB0D45FDC61FA062D53795F6AA5C6D04AAD592EB157A63E1E24310258C3DDE87B0F6D79FE1EF7F143EDE7B70C2F798089189F876EE7CFCF6EB56ECDE7500077D8E8A300B507DA4CD7706FA9FD4EC1C606D9970EC2222AEC0D3D353092C0AC4D0D0505EBA8EEE6F074E1335D8916CDCC18307D5C22263064A3276380984D0E60199519B130CFA3ACD48DE4346A4D9447F8466144364540C2E0AA3A58B24BD7C25523101797AD6AC2F8D15F1A0CB58B5D11B67A3809FB69EC2E235DE381E98844BE2AECCFFD113DE472F60FDA6438815937FEBF6E3B896908ED34157053158FAD3361C3E761E6B37EC547364877DFDD0BE7D5779A62C3CDDA937667FBA100BE6FD82991F7D8F2D1B7D306DF21C3CDEA2BD62A8C8ABF12A66E073E9D94AB5D6228153C4FA19ECBF68AE4C363E239F55F7099F5D9B5B3A669FF098C4C9A063FA644CA789CC81667F7317C2B66DDB94A0A23540A23877EE9C62588633A783F1D1F4D9C87F7F0919CD82285DB21AC68D9DA6FC2B821A8A2011858585AB7B2820D94606C67A49834CCAC067D0932BBC6EF7ABB3EB24E330F01AC1B6F199482F19999C52170D2EC5BBB9D544E52A3DD1F7852FD1B6FD243C54AA070A14E92402712DEA3EFA268A551C804A0D46A392F856A52B8F4295DA1FA04EFDB1A8515B98B0D2AB2859AA3B6AD6E82ECCB91FE7C32F62D9CA8598F1E124CCFA681AF6EDDA8D732161E24372EDD27005E82F334853D4335353B36FF5B3722CCE068761EF3E1FB16CBCD418D2ECA3BF29C1290FDC0E9C266AD014F8E69B6FB073E74ED530761C272BF42068062221D8B59B0AEC5CE6D744A4F3319D8B848E819DEF27D285D28D8C45D3F8D5C123C514E90F7EA96AF637CBB1FDC8257CB5D207AF4E58842F171EC09C45DE083827A6DA179BD0A5C7BBD8EC198AC53FF9A0579FF7206E059E68D7073BF70662C294F918F5CE6CACFCC54B7D32F8F1761D15E191D8460C9F88364F3C8F4D1B0EA34E8D2751AD520BBC37E65361AA4E080F132691FC642A4A33752203969A664660E0593571C140A9487356131B7D187DAC1985FD40226560FFB1EFD82FD4DE9C39657FB28FB92B62D7AE5D6A4704198AFE2A079CF75382F25E06128B365BFCFCFCD5B3D0E40A3A73092F0DE26FD916C28861EF893F29E32243C2FC6444AD65F58403DB679F78BA4118F298F5B21EC60CDADF633BA8991918EBEBBC8702983BC1696954AAD41C6E791B88D93C0B03062E441EF7B6285F65204A97E985212357A05587A92856E14594A9F9268A571E8D0A7526A37495096276BE812A9586A17E9DD1C8636A86968F0DC21E2F5F794E9B581897111E128853BE471114200240BA243D557CDF2CF1013368129AB30521BB8B4DA3894E0B8B337CB41EF6EE3B88AB91D714248855A6FA5262F5FC4EF9E0CF42FDB34BD5EC440E3CA5165522A5B01E50FA58EC584D30BC8F1D4F3FEBC30F3FC41B6FBC81B7DF7E1BDC7BC681E27D9AB1182811C2C3C3B2CB63A7A45833101D2584264DE084DD96DFF662FAD439F868C6F708BF9281F92BF660D5D6004C9FB7155FAD3E2C8CB5143FEF8DC6173F1EC3D4FFEC102D7601AB378489143B85D56B0260963E1A3C648A3219CE044398EA3B6CDC1A8C1F571E40C9728FA243A717D1B4F97368DAAC2B06F61F8D720FD743ED6ACDF1FED819A85CA69E986133D5809071280038289484040789CFCEE5034E4E684142A661DFE8193E0E22FBE6E4C9933870E000B8F44033835B8968F3EB6D4B641CFA5E2C939A41CF06EA490A066A25F621418D4073D3CB6B07F61FD82D847109C9E67835B9C271A005F078CB27C58C6CACEECD6100EE26308B50B0483E63FD8AFBF23815AF35AA66223DBED44E8CC928D44CFA592323AFA8744ED25020522B7134E3CD09628ADB14237FF0FEE7E0ABECC58B491F0FFA017D072E114A7B0A851FEE8BE2150660E01BCBC48C7F091E455F40855A6FA178A5E182A1285555CCBE1A6FA37C85C178A87827E47FB001366C3CA0CA5753E6C23CEC07D6CFF632CEA625093C663ADBCCF1F1F2F2CADEBDC331B00B946C3A77845DF0DD913D92EA9FBDC3B2132921D918CD3494426434DD6882D728E9A87D68AE90A898373030501119AF6BC662604C62F1F7F7578BC35284225C6507FB052A064BB565A155F38EF039E08701834662F5FADD787EE0681C3F1B8FD7C6CEC6A603E7F09F1FB7E3B3455B31F58BB518F9DE7718FAF69758B9F608B6EE081289F83EDE9B3C0B1F7D3A0F474F46A0679FD19838F57BCC9DBF0E1661368BC8821489850E90C89967A9533133FB51D2CE055E90673588C7DEECECC0F61AB1417C5A58F098CC400622C350DBD051E64238353D77965038914839D88C759FE83E626039B408F49A1F19887B0779EF279F7CA2F6D0B15CFA62BFFDB601870E1F509FF68AB97655119C63A06662D94A7388CAE2B621A941E52553D1C1E76B1894CECCC767623B086D65305D07A6F39C44CCC0EB0C19A216E2650C13CCC2AC729E268F356CD874E4C9531D4D9B0E4789927DD1F8B12998F27100DA3F3B0F4F3D3B17AD9F9E85F9CBAFE2BE22BD51BEE6281428311045CA0C46A9CA6FA0709981A854F91594ABD807A63C7570DCEF9ADA9DCE9716F9D525EED6D081FDA503DB45E1434D44C1456DCFBE275D4AC8A66B0DFBB35D47F7FAD831ED7671432134356896389A038E9DECF8303A302F898CF97487DBCB558144C40126B170E3E5E2C5DC68BA4839B9DF7DF79D224432A5F229E4365641BABB10110B8B9C2709CC329EFCC454649274B034E5528C0D2117E2D537B6D325AF28125C8C4840A0D8D91C7A82DFE08E4B4CC3C5CBD1EA5C5801C936B31C67C29A2E042595A9F6CAFD7C5354894409FA79C910246E9A6334CFE8DFD0C9D71B62E7CD9BA7089FBB48D86F6C3F050AFB484B533E3BD3B4994806644C66A1A6625FD35F253859C1CDA79C0CDAB3678FF2A1B496607B72CCB2545C8B8DC4B1E387107A2E48F2181A2E2D35C73424A319268D61B672DF1B67CCF4F283C18839E3A5195D8F1BDB9FFB1958361996E99CF4493227E2D255D15C929FC26AFAC7736172AB078F028FA342D5412850B80F2A541F835A8DA7A245873968F9F4D7A8D56C228A5519028F6203246F17B479FA4B7814EA89BC1E9DD0B1EBA742918DE0FE4043AC5C63BC0365956762CBE83319BB438C40AD439F93C29FC2C6CFCF4F2F215C47E07F076E4820F193489C310F039987D28C3E01079AF9D8E9C6601B3B0B38003485083EBC2E2B47BAE70C2607D6185CE631D64108CE06EA634EDDEAB511D6C9F1574EB8DC42A4D844D28A98E475065EB3A5C83F4930A6BD59AF4D98285E928438D312C506A7BA679D46FDDCA56149362BD38DAFA370773777959369E6CE9DAB62EEF4A629C189034E4B5332D2ACE3E0D2E4A569C6353A9AB9349B199329D89F9C229F33678E6246320CD32849699670D331351899866637C172B84996D77C7D7D559D5A8B91788282CE28F3CFFE7A857A4E3EAFC17C5CD4957E1221C25F08CC14B38CC8509F5696BE14C6629F18CC95634A690662E05891C138968C095EE3651E2726C729C1C4D9570ABE35EB0F09935481295F73346BF31E4C1E1D50A0785F98EE7B16EE45FBC1F4604F980A3F0F53811790A7D040E42938000D9A4E93FCCFA258C97E68D07034DCDC9E94F38A183FF92B36219B26F9A2E1C58BE1322E07559F53C0B12F1C5F82BC956977AF917DC0C160CCC6D10C21239071A841186B538F81D7742733E639EFB797A102074833A0D6622C878E219D6706431A1A129331FD83648B59EDDB63B91CF4146B9230083B2C0D296621A04CB1A9B9C82823C95D4B56B3982C5C98159A322789349526F0D502BEB363B30A930A6F7141D896922C0EBD45EAE04C96C1C0F429D8F6E0E050ECDAB917CB7E5CA9D62B686A4D9A34494D9173F068CA519B2A4757B40B636A2D6A326A135EA35FC97B790F4D10C6F49BA881788D603A1993655003925968F7D3546199349DC94C644E32374D6532A64ED3B37046DF533F1802C1E87BF1BB84C2C998BC4EF38E0BA2F4A33823C7FE335B8CCD726AA64CC0FEE5181AE360EC02E1BD1C2F3D961C3F7DCCBC8A7925709CB89EC89E3C79260E458AB71086688242A506A244F9D7E151B82FCA577F130F571DAE4CBCFB8AF58347F1FE2850F20D94A8341A156B8C459D06EF8BA9D80915CB0F449952DD91D7D4044346BCC7E2154DEEDC25BEA3F71E1C3D7610C78F1F550286C2CA6E4565D3AE33FC913C770BD9078E8DE060930018B4E462E71264324A5FCD6C6442A653A2E901A0B6D2F9794C301FFD32635B10F799A5AB72E867D1C7E235E6613BF4FDE6E444582D89488C8B428C486573623492E262901C1F074B82F80BE28365A488EE494E43BA554CBAC41458C43CB459B26095B4E8486142697E742467F3E440A056DCE5D0EFC4297CFBED3C21D8089C0FBBA4160FB9884AE262D05A95CFC567A59F49938D1A8A4CC60553320A198A4CC209095ED7262335114D3B321F1986CC430D45ADA6F3D0FCE53B589CACE0BDF4CB681A5253710CA82D798D410B2606A38D8620521A89C24DB475ACD8C29CF2E79A1403FB939A2C49B40AFD2F6A2DAED970A32B5F6F575F87B58F0DC7528F01639EB35C5A1B3C679D8C6362A2D43D9CA020439D088846C5EACF208F470B9428F33C2A579F2C1AAB2FAAD47C5FB4544FB8E5EF8962655E4695DAA351AEEA3014293500EEF9BBE1BE07BAE2FEFB3BA240FE767033351686AA854A0FB7C5C64D9E6CBA69FC84F7614B17DA1141C0F633CD111C17C7733BE35F97E7EF42F60125943EA65AA5994142A1F4E40C92661A0E2E099F0F411F821A8CD0EFF350AA12F41D08320EC16B94326420E2CA9548498FC1B598044445C6492CCC936045429C0C5CD4355CBD1C89A48444B5372B29915B70F88E8C9853D111CABCA1A9762542983B321E29E27425C8FDD197A2112E0C722D3A5E31526C4C9C30519A3A57429DF2C10ECFADDB3169C244632B9404BDA196A07944E2E3B1DEACA9AF91D0B4994486A1F9C77ED2CC4546631A4D143209B50DCFC9643411790F19895A8C828BCCCA7E629FD014E439B51241E622219388190CC236DE6932AC03436851EED1DC65FFC55E93FE93E7A5A0E07B443942304662D6C37EE77B56D12AE675D6CD98E3C831E258F21E1E6BA1C76B3CBE7C255C6DF1E2A23C97E94A95E57B4D0D51A9DA60E42FDC03858ABC8A5A7585A1F23D8D9A7587A2747931F9DC9A4B9E262ACEE3D60479F33D2AE77551A9E23318D46F32FAF71E838FA7CDC3E9936AAA3E9B26D3D27318C7913EFFE9709AA84162A074A539C8980E3B25279D7212024D144E5D72E6851DEEC84C345B984EE22043517513E7CE85A8327C7D4FAA818FB8148573A111080BBD8AB38117111C740EA7FD8370E1FC4585E0A010659E714DE8ECD910048505E074901FCE9D0F15C60FC6B990705C08BD8880E301080F0E53C28052FFF4697F110686D9C4E9DF8B17AEA8E97BE5558BC60A3A1388258B17C989989836C3BC4C4DA3D615F3935382C240CA7CB2AFC413DA0721C8589C64D16FFDD2CCD3FE15EB673B380B451F8C0C453352BF194C93917D490145CD40A2A5E062FFE9CDAA76CB41D5A33594B61A0C3F917B0C0D2DA5D2C8F77218139D800BE157E07BDC5FE2CB6A074B78B821E8E8C3D13721F8122163D64BEDC8EB7A0C19332FC79963AC998BCF742DF6B29AE0894BC8C4B3DD46C294B7213C0AB647F3D6FCDE5E7B396F8B42C5BAC0CDA3A930514D492B2B69E551B76167F4E9FF2E3E9AF113D6AE3922DAFAAA8CB919D157D3101B25429A53B376BA8B8B531B8E6FA0476AE3DC69FF445CA7369D4903A651729150C85CF415F8DA3589840443A79E3E0109879299F9A8DDC85064444A679D7EFCF87191C441083E1B86537E6770D0E798FA44D5A183277060FF51F81E0B947C7E52A6B1DDE4E8D1E38AF8682EF15E1E33A6694450AA6B479EF5900842438325DF11351B14107046D28F6197D73EA92710572EF36D624E331B3BC439F960ACD5702700FBC1F0B5C8402A9F8C33350061A7DD6C86A34FB270E17CACDFB0066BD6AEC492A50BB178C902310BF9FAFF326120AE496D120DB653ED3BFBF9E755D8B66D8B6A5F86683E322B35AE6662ED23717281BE25CD369A687C8B955A82E344ADA5AD05322303998B814CC867A290E398B0CF1C639A9BEC3BF613D39C81D79897F978CE71E3B85263521032EDE2A51035DEB366CEC57DEED504F591BF400BA581F895D8A20FB444817C8DF074DBA158BA703BBCB69F40C8D9ABD287D248E9C38C34114CDC1828C7B4128C0DB006AD99ED3FF4666860EE44C9B9F66FC20D8CC4730EE0CD6C540E2A25172518FD0A4E2BD3B12738BBC59932AEAB70532AC1592FFA06BCFEC30F3F0843F27B09FC7EC1CF58BE6C3536FEB615BF6ED882AD5B760A631D1602E45ACD3621C63D4AF29371899D3BB78B3FE3993DF3C698D7E9ABD0A4A20620D3331F199FFE0CCF3D3D7760D3C66D52FE0EACF99993069BE57E2F9587CC48C2E6009A2D096A9A9AF63BCD3FFA7E86496541423C5F25B7A88902123A41BF64EBD6CD387CC45BAD1931F63D71444CC0DDAA9D6BD7FE2CDAEB171112C79576E6A237EFD3CC43F38B0CC3FA59167D159A635C5362FD6436E63118D0583F62A0194E06D23E16359B1660EC036A470A3C9AA3EC1BF6933ED6FDA5C1747D4DC3E8430A02610839A7E0E1C654FA7F6A3674C942B5D1F9FEFB8AA274C9BAA855AB2D3E9838174B9679C1FEB9BD1B6846831B9A69D21336AB3C834D684DE2ECEBDC39CE5898C9B0106E2CE3DF00A789B70B0E36CD074EF952AA7130A8D5B89640E6E24EED69D3A6E18B2FBEC89EAE5EB8F007B54175F8F09178F9E557F0CA2BAFE1C5175FC6ABAFBE2AF18B3280833060403F0C1CD85FC5DCA93D78F06095DEBF7F7F9567E0C081EAF8A5975E52D779CCCDBD8C59DE071F4CC4F4E9333064C830552E67F63A75EA64377B689ED2FFE0BE436126612E6A094E60444789836F072700A81D48E8F44F78CF9E3DBBE0EDB357814C75F0D07E91F24795363A75EA2466CFFE449877ADD29CFBF7EF558CC685DBDDBBBD84B97F55C79B376F549A8CC2805A8DDA8CE9CB97F3232C3F2A02A730629B696EB21F274F9EAC76A9F379B9C9B567CF9EEAB9B8C6C5CDCE13274E541B78870C19A2FA807DC23E2278ACE12C8DE0AE7496C7753396C7594D8E218559F0D940E5AB3A8E3B3728F36B453635CB783D4D6870E1D6BE78EBF4FAFF129C26FE1EB476B3DBFD4EF310BF77FD5E80DA85929C4CCE4904323D03633AE7F4BBC844C1C14162329E10F3264C982D54F96157AFC488C9188D90E0F3CAAFA379C9F7B79897EB448181A711172F4EBC68B8A8E8CB6A868DDB78A89902024E89D658AFF2D17F317CC99362B206A8F299CE3C9E9E5B8569F855A91FD431CB3E7FFE9C02FD183E03413F83130F9C79A496CD6D495063313F4D359A679C34B16BB7EC3C770BC6848219A99906B3715D892FFDF1F8FF114E13EF256812E8E37B25C968B3FBFBFB298D433F84CCA22761FC03E8139E169C557E183F4D7CE4B0AFF81772CDDF5F4CC6638AF9381172E4C821848406E2A4DF31ECD92B26D30E3163C52424736CDAF49B9AB276AC531F3B822621CB22789CFBBA23B816A5D7B4725F2338E1419F8ABE262715725FBF1DDCCC0DC836D51CCC342E2EEBE3FF67384DBC1D68EDC541A0DDEF3818DA0FD0E78476421D99EA4E82F55313392366FA50642A6A0AFA8664263AE774CCFD4ED149A7637F087BF778C3C75B9CF743C7254F80D202274FFA2A3F898CF3EDB7DF60D9F225EA05496E70F539B84F9993ACC36010634A9EE77F06EC2BC7FEE3D203194A9FF3B9F4F1DF09C749863F02EE60CF9DF6BF08A7897F27B4C942075EA7DD29F03B175C00E50C1F1D61FA3874EEE92F704263CF9E7DD8E9B54DF9393CF7DAB9576DF8DDB3FB809ADCE004C09A35ABB17A35775EAC500C161B17E5D457203391A11D1D6EC7635EE333E676C81D278EF46B0937031768B510E37D8EF7DE2DD8A44DFC96C89FF9CD5CC7F5A6FF07384DBC9BB0EF02CF3EBF9924CF9D7E33D3D051A23B03FD254E3EE8F3145BB29AB2E6F18C19D3B3DF5E9E39F3137CF2C96C7C3CF34339FF18B3677F8E8913A662D2C469983279BAA47DAA6635172D32A6CD376C50AFC3DF509F46CE7A97F3EB7F64768B338EF6F7A0D41A0D6723E93B9189741EE25EF94E7F14B7A39DFF97E034F19F041252EE34479038B34DCF14637190E7246A1E3BC3CDFC9B5B213D839FDCBAB9C44D365F538BC7376A1E6EBBBA71CDC551AB389BD0A1C9973B4DE3661A8975FC9E90F9336059B94D51177E1F4E13EF15F8FE94952F3AF138FB0DCC3B67C23812037D12FB9EB8ECEBE6E45458CCDC6CEB7CA59EEB47B9D36E0667CCE478FE47408DE3A8851C998DA6A2236352031BE97FBE1E17EE2E9C26DE2B70D63539C970C03975CD98EB40D432C6DEBB9CBC7F44626A332F39C926CCCA9DD639CEBDFD87C06EB88730667FC96494CC394CAD199D9FF6722476F52DF1040B52AC393E0FBF95A08F09676DB5EFE153C764A09B3D8F7E76C73E209392B1B419EC68D212BAADBACC3B299C5CF873709AF877207B82427C1E9D46FC1953CD623508CD91D8357213B0FA8E9FC3B906273318532B287F8C3BB28D7BD53109DDAE1DAE630ABD5F4D13F39D226AADF1726BBEDF5B7E7031D5DF07A789771B9A20ECFBD74CDCAEC319B9A4E458F5FE0F194B1337998AC4ADD7708CD93BA39CDC931EB95F11484834FC1263C36C4EBA0699C3D1C9571F2D498D4326A851C830C66795B9C0AB271E786E303EDFA835B4179F87E98C6FA67D3472CF08E686FA8E8403C3DC2A2FDB430DCA9DEBB9AFB9F0F7C169E2DD84B3EDFC06E1A4AB97E978CCFD71B79A68A0A963988334A18CD71FF8BD0BC7498DC0207FF50A393FBC48E6484C8A45645484DA5FA7F3105CF37164D4D878EEB83023353D01678303C08F8D186F25E7043222F7E4B19D64000A03D641E4F6DBFE0A1C199EDA37FC7CCEAB11BCE6783D375C9AEAEF83D3C47B89847821C22C7EA547F954E0AB1A7C578812F8F79C70BEC56BBCCD7AE335BB8FA1369DF2351415B8333A13EA6BAE4989394447667424426A36BB16321855EE23DF732FACE2752983AF5AF07B1A0C646A6A0D470D4338FA746C0F198EDAD9D1B772062D50B49F941B76D335BB7FB4C6BC57BFBFE4C2AD00D37F01661A8A0048406A130000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A320'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000FB0000004E0806000000E6756060000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF0000423849444154785EED9D07981545FAF50724EA9A23A82022982362405104030AE6BCBA1851511410010554144450316300514090644272CE39E71C8638CC0C4CCEE17CEFAFFAD670192F88BBB2FBEDFE6F3DCF99AEAEAEAEAE74DE505D7D274652145144F17F001113A388228AFF3D444C8C228A28FEF71031318A28A2F8DF43C4C428A288E2DF83BC5CFB1B769E9D9DABBC827CE504176272F3F3DC3112F2F20AECB06F5A7E7E705F24444C8C228A280E2D8A93321271FF6A444C8C228A280E257EAF7D77EDDAA59D3B772A33335BB91939CACBCA564E46A6CB97939DA9ACCC746566A4A9B020470585393A9006DF1F2226461145148712103557F90559CAC94D2F226F4181D3EEB2880AB2B29499B2C7E2969E9BE1F2FB7B2CD1E5CFCE49576104C1B13F444C8C228A280E25728DA45946DC0C8782C26C4B86C0854A4C4851CAEE78E5671BC10BF3949AB25BBBE2B72B353D49F92614324C38E4649B3030B9F067B57BC4C428A288E2D0014D5EA81C8B42F26C6566A538AD5E6804CE482BB43423729E71DD8E39F95296C5C99D62DCE60E930B4A4BC95776965DB4F2F2F2B39497478EC8CFF38898184514511C7A1414669A299EA2C4DD71CAC8C852AE3119CEC6EDCA538B57DED1A34FB452AD3A0FA959EB4FD5E0BE966AF8C06BAA7DDB8BBAE4829B54A5D2A57ABFEBE7CEC72F5EEEFE1031318A28A23874C8CD0DCC6FCCF7C09437C29A1ADFBE35590BE66ED09B1D7B1B332B29E6B06A2AF5B74B55EDA28775F84937ABECF1B728E6F0EB55B6E49976FD447DD9FD7B570E3818DF3D6262145144716078B319BF19A241D83FB358969F9FAF02AC7023798161677C9AD6AC4BD6D7DF8C53B573EE56C972D72AA66C3DD5BCB58BEE6C3C54A79CFF9E4E38BBA34A577852E5CBDEAA1225AB68F79E542B606F99B807E1E7C51131318A28A2383804A467E34B00A7A5F7B9BE77534C4E4E40C6C0C776E9CACB37EFDD7CF0D1E36768EEA2EDBAB5613323F9653ABED27D3ABCE243BAEDB1DEBAE4A62F745CB54E3AFDA2F754FAE4A754FAB0BAAA54B9B6B90041D9C13ADDDE67EE0F1113A388228A834352D26E6565A739AD0ED0AE1919198ECC903B2B2B4B6871CE3333CD47CFCE76793867012E3BBF40C3468FD3B2B5DB7465ED071553E26C553CE741953AE14E1D55F569B5FF6C95628E68A4736A7DA3234F6BA773AFE8A47265EBE8AD8E3DECEEBDF528085918E169C51131318A28A2F86360C22724EC5246668A2370B0CA9EEB56C60B0BB1D10B1CD95353538B3439E721735B1939F9FAA6DF006D8C8BD7BAED493AF5CCEB8C91D575D2058D54E6D4BFABC1D30374F99D9FAB7CE59775FE35BD7462E53774EAD92D2DCF45FA75D84C8A2872270E061113A388228A83437A7A6A48A30626BC23BB99E9411AEFC3038DEE3479616168F5DCD24DAD2F59B1D9889EAE698BD669679AF4FABBBD1553B2AA4A56B85DF73C3F588FB79BA892A73FA9B2955ED299977EAC53CF7A53658F7E4865CA5DAA054BD62B3F781117B15E911031318A28A238386465B1BB0D933C58A4239E959DAADCBC0C0324378D6F840FCC7A1308E6A3C3F4D8D8042D5999A8D94B776BC0C805DA9969E4DF90A6FAF7BCA0736ABFACC75B0D579D877B2AE6E8BB75D18D1FAB6A8DF755E1ACD6C6D83ABAE0E2BBC42B76131DDE4A88C9E3857CB1BA1547C4C428A288E2E0909191E6480DD103E261AE437AB6B3A6293D23D9FC7423255B60DDAEB7426524A76BFAB4151A3064A162CAD5D090311BB53A4E9ABA748BE659A4E3E7B375D279CF2AA67C7D95A9F4A86ADEFAB12A5FF4962A9CF9A262CA5EA7C64D3A293D171F3D3D786ED802DD81BE928B98184514511C1CD0DCE12BF0C4F3F2D9B3CE1EF65CE5E46698E99ECE75F3D773B476ED7AED88DDAE11C3E6E8CE7B5E37F2D652A74F2769FE861CA5589E3DA6A0DFEBB14027567BDC04C14DE6BF3FA30A17B5D051955ED0912737524C99AB3574C44227523272E22936786EAE4992507C7F889818451451FC73700B6679D96E6F7B4E76BA5BA987ECACBC27A7A469EACC59DAB8769D264C9BA6060FB7D663CF8FD1D5F5BED13B9FCCD3921DD217BF2CD4ADCFF4D5D5F7F652851A1D744BA3C13AA29269F4320FEBC4339F316D5F537BCCEFDF9D99822831BFBD98260F99F5911031318A28A23878E4179A2F6EF0E785B9592AC837F33A3FCB99F1852A306D6F66FA8C855ABE72AB8BA3F7C7CEDBAE5AF53FD2B935BAA8D4310D55EAE4BAAA5EABA92E6FF8A9FEF1CA747DF5B3D4A2F32AD3EA2D755295B63AB55A531D79CACD4A31DF3F252BCDA86E42A538D9DDC260F8F95E444C8C228A28F68FDCC20279E414E42BBB204759466E8EB990AF3057F9E6C7E3BB6764A76843EC66AD5EB74DB3E66CD4973D47AA75EBE16AF7CE5875FB6E83EADD3B5095CE7B4331A5EA186AEAF08AF7EBB6C77F54C72FF7E8DD9EE96AD868B84EACDA4ECDDB2CD1D917B5D6D32F7C6DCF91F9EC99CA29446414AF5F94EC5144F19703A203D3EB457064E7B334CE0A780597A7C494746DD89AA6F66F7D678C3B4B95CE6EA4F61F4E54D377C6E9DD5E3B74DBDFFBEB9C1AAD74E2E98D55FEF8E775EC59CD75CA791D74EA059D745C955774F58D5FE81F4F0E5785D31FD5071F8FB0B2158370C92D087EDC625F44C91E451487044EC31BA18127BCDBCD5698AF8CAC54CD5DB84053E72C52AF7E23756A951BCCF73EDF34F8456AF8E4BBAAFFCC07EA3F79B786CE4AD6A485491A312D5EEF7C3A47D7DED5DD4C7AF3CFFFF688E5BD4D356A77D259E7BEA8D265AFD4DC455BECB18AC92BC88D923D8A280E35C25F6FF1E3905939990EB9F939CE77F79B68B66EDBA11EDFF5D7FA6D49DA9124FD3671A5DABCFDAD6E68D849152F7C56751FF95C6F7C354FE316256B678EC4672D4BB766E9C9B66355E3D64F7555C3EEBAFBA93E7ABDEB0C5539E7315D78D93DCA087BCD96971F257B1451FCDB509067DA3C375B8505790EC409B9260F56ADDDAA9DBBCD9FB7733B685352BE3626E7EBED6E8374E1754D74ED3D1FEAF25BDFD363CD06ABE9AB83F5FC2B83F458931F54F38E8F75C3C3DFABC99BB3356452BEDA769DACA34EBC55ADDB7DE57EC42217A7DD9E1DAC0B14AF5394EC5144F197A32027D7FD2864418E11DCCCF9C2DC1CA5272799092F65E7146AFDC604D5ABFF889E69D641E3E7AE52BC098078BBC69EBBF9EB0BF55AB7D93AA3461B55B9B8A94A1C719D624A5FA59872757458A5A774ED03DFEBA9763374E3435FAAF409B7BBF7F1DD3EFDC56DD7C90AD47B40F6C27DC91DFC02CEBEF5F4889818451451EC1FFCE044D1796EA13253CD46771AB5401B366E5672BA3469C612B578B58B11B8BC620E3F4D658FBA4935AFEDA42B6A7753F3B6A3D4AAE364DDF2F7EEBAF1E1AF54FDFAB774ECB92D1573D4A3AA78494735786CAA6E6B345C773E39402754FDBBF9ED97EAF4AAF514BB3343264308BFABD3C1206262145144712004DA94FDE83959E85AF6C6E7293D1B48EB6253F47A87218A39AC968E39FE011D7F5263953FF2693B7F4CE58E7D54279CD154E75EDD59773D3958B5EFE9E336CEBCF0D64A7D3A30CFB4FD367DD6AF505D7BC4E9C6FB3ED6B9573EA3F36B3EAC479E68E7BE7B4F4C4E11CF3D981D73C51131318A28A2D83F586DE7989D99A35CF3D1D33353946EC784B442FD36769196AD97CA1D7DB369F18EBAE4AA0E8A2979B799E74FE998535F514CF9071573E493A6ED1BA94CC5E6BAEEFEFEEAF04582F9EE3DF45CDB85EA3354BAEDC1FE3AA57A639D75C9E3C6D0AA1AF2DB422D5BB94B6999089502F3D9F3FE29C2474C8C228A28FE18108E8F5F78E1B66D4F92A62F8AD58E34BB704C5D3DFFDA445D7F57775D52EF5DBDDC79816E7CF007D57D70B0EA3CD853F73F3B4E373CF8BD9E7F63856E78B88FCEB9F653BDFEB1C5EFFE56A58FFFBB4E39F331953ABAB6B1B3923EEBF9AB96AE8E33B26FB247E242F0C3943946F65CB138E8EB72308898184514514486FB54352BD7B4AA9D59E055DBD8C9E3357EC65C6DD8253DFC4C575D79DB17BAE5D121BAFBA959AADF68A8EE787A8C6E7D6CBAAEBAFB7BB5FA68BDCEA9D5590D1E1DAC5B1E1AA867DACC3073BDAFCEB8A0B54A1FFD802A9CF9AC2A55BBD7FDD864F50BAF57A629EFB88454AD591B903DCBAC88FCDCBC3F4D741031318A28A2302D9AFF7B4241763E57E51F35F8DF76EFD5A7AF2365B963AA2AA6C419BAF886B754E7AE6FF550E369BAACEED7BACFC8DEE091617AAAD504D57DE8133DF4646FBD60F14BAF6DABA34F6EAA736AB45489320FE9A8E3EF55F5EA4D8D955554F59CEB949E13FC6CD59419338DECE61B14ABCB9F45C4C428A288622F20BD87FB670EE637A7A66539A6F7ED33C811BE4EBDDB4C1B1FAF9852A7A9FC09D58DF4758C5D97A874B9DB55A67C43952C5F43975FDD5C31658E52B923CFB76B67BBDD74D5CF7FCA7CFACB54B2546D9D744A7D4BBF50152A5EA10D9B93CC3930B29BD9FE5DBFDE6E834E517DFE89C5391031318A28A2D80BB439BFF51ED2F4729F961ADF9276672B3DB5402F367DC598544EFCD8EBE6AD993AEDC4EB54A644157DDE6D8CB2D9F762797F1AB040A5624ED69CE95BECB4D07D34D3A55B6FC5943B56471C7D999233A476ED7B18F14FD48C599B79A3A754BB39217997868D1EAE1C4B082C77C5F8053AE27F0611130F05F8CE975FF470087619B974FF83F9C5C1DE5F8E99FCCFAB505AF86784871A91FE8F5678DAFEEA1D8E4866E05F09AF6D8AA77B845F3BD475F9FF1591C6C98FA3FF69E770E08F17CAFC62B1E535D0A03939EC8133F39DFB2C292D25531BD6C569F9B258F5EE3BC6B4F8711A3B76A98C83EED768624A1EA9AA6736549A11FDE1873A69C2F81D668E4B8D9FFEC0BD3EAB58B986526D5A675A71BDFBFE12B803967EE1F957E89147FEA15C7B9EFF4476F3E6D55AB870BA3D3F5B8585992E2DF8E51B7EEA6AFF1B68222162E2BF0BBEB2743A3FB11BC4F3DCA24776EEDECFF7DCA6FFFC20EFBF93F0078BFD11E93F45B00309A2FFABA48F84F0BE6085BB285E10EC6DC73ECFC9C6482FFA278ACAC9CAD7DC394B3462C4046DD99A610C3A51679F5BC7ED597FA1E91BCEA47FA2710B95285BD669E9D75EEFAA3C4B6CD7FE2B953EFC4855A976916A5C59C7FD865CEFFE83ECFEB25AB16293CD7FA96B978F8DE896B9305F5BB76C74C49E30618432321294939362D7D25D1A1FD9002FB40E764C23261E6AA0D9FF482AF193BBFCFE76F1743708C5D20E16744E80036BC4705057C07DFE583C8F4778DD28FF5FA9EB1F21BC6C3EBC28AEA5207C7ABAFB39A4A2B4FFABA02F180F8E5E10F2ABB08448DADDC3FDE84CC071F1C392DCFB4DCF3E8ADD14AFE4E47C63CFC98A297DB412934D4BDB74FAF4AB2F9C767FE19596BAA4D6A57AA3E317E6C79796E9694D9FBBD27CF412FA69D83461305C5AA3A1DD7F8ACA94ADA0DF7E9BE8840444CFA220CB9F9C94A094E4040D1EDCD7CEB31DD90B0BD8831FCC41AC8DC0E208DAC7F18F1031F1CF229C38BE53E9445F213A2A2D3D4929A9BB959AB6C71A46E54C7B9B391217B7A3A8D23B76EC705F0CF972E2E2E2DCEF6C1F68400E25BC70083FA7AE5821BE8DE11D1D5E578EE43B9484F708AF03CF2CDE5FE1D7FF537DF99F846FBF3FF23351EBD7AFB568811B1F76C1017C61AEB3F73C33234F19E96E5EBBFFA13E7FC12C7DF5D557CE57CFB6E95AB66C65C5943A414D9B7FA174BB2DCD8AEE3B609CB20B0B3576D20A0D193AC9ADD06FD995A63D69D2C79FFFA2D5EB6D7E18AB79CA9EB41CBDDAAE934A963E5C2B562D37F7D62936E726049B760A9C2647B317B8EDB901D183BB83FFCF6EC1B52F9C7FB491791869EE1545FE197862177F180F01540873C3F917667EF85FDF0C7EA02FF8F95DAE517906A05FBF7EFAF2CB2F3D815C8509E1E507655B8F84CEC341798120F9FDB5BF0AC53BD0C3B7B978FAA180EF0F8EE1D64F5A5A9A1098292929AEEFC2FB2D1CFB4BFFBF8265CB9668C080FEDAB6CD7D1B1EBC3F0B2158F8B2F945DC2CB901037B6BFCC4A19A36739C724CCD3325AFBFFE119528514DE58FACA1DBEF6DA3B7DE1DA2238EA9655AFC28757CB7AF6EBFA3BD6A5DD344EDDBFFA6D16376E9867A4D4D835FA90F3E98A84E6F4FD133CF76D6F8711B8C7DA7EAAC33AF34A112903B3D354DC9BBD3DDFC870FF1093BB478C93C6565271B7F329591692604FC315E8593DD738E3847C6FE2F273B85853F884984E6F0082A04310B023F23A4D1019A3EC9CC1404C0F6ED5BB56AD50A0D1A34403D7B7EAD7973E66BF6CC395AB268A932D232959A9CA6AC8C6C174F4FCD70E76929E9EE3C333DC3A4709A21C53A2DD9212D2DE580802098B81E9004F09F3B00D7E92C8E9CEFDEBD5B0909092E8FD7DEDC47BACFCF3548969494B44F99582A203CAD38FC733D7CBDF6072FB9B9973A709E9C9CAC59B366E9975F7ED19021433470E040330F7FD3D2A54BB56BD72E978F3C941F1F8F199ABC4F99B4C1B7233C3D127C5E109EEEDB13E91A289E1E291FE7BECFFCF54879C2E391CEE913C682B66EDDBAD5B57FCB962D8A8D8DD5CF3FFFA8AE5DDFD5D4A953B567CF9E80647B92B47963AC664C9BA971A3876AC2D8619A346994B27212B57EE36225EC8E133FF97EE38D8F1A6BCED325973EA6A38FBB458795BD51A5CADD64FEF9453AAC34AFDBAA1978B57696A18A69EE7354E2B00B2C7E91E53957254A9DADD2652ADAF9313AE28893B56D7B7CE07F9B02CC4833B70BA16301253862E450A567041FD9F01F5FE14AA030F77210EBD8F32D3C1D4E1617EA45917F1614EA0B06C4791719A4059A1D331E422F59BA4033674DD5A4C9633572D46FAE31F317CCD6F809A3B561C33AEBF8442B120997A1B5ABD769DD9AF58ED0C97B8C44BB9395186FE432A2A724A51B52434836DF668F21318404570EE0FF7079245B1E0F26C181002198B44C0448BE73E74EA731B9463A13916B4C243FB9FD3DA46DDBB6CDDABBBD8864BE5C4F36F27970EE81B0F002E3406052532FCAC7D5A13EFCB711AE252626BA388132376DDAE4403DA827F5A33D9EFCDC435B78AEAF03E90782AF6778DEF0FA85E78D94167E2D525A38A81BA0BE1E3CD75FF7F5083FE74859B487BEA28FFC9CE49CB5979D3BB7BB3C8CC1EE049B37368F985B09BB12B52D76B5F2B2F961E72CA56726D8114D5BA8F6ED7AA844CC85BAF79EF775F5D5AD54F7866EBAE2EAF6BAAA5637C33B7AE4D15E3AA3CAD3AA75F5EBAA57E7135D55F36DCB7FB76EB9F113D5ABD751D5ABBDA0DAB55F57D952357444F98B3466D422F1752CAFEF9212113869DABE35B0CC080307F5338518EF4CFCE0872AE09A57A201FF827F52B1AFB58702FECB35BB078503B7E1C0261AC78D1B376ADCB8311A3C78A093A493264DD0F2158B4D926D76FF3183EF6EBD39CF3FA37724778B26810985FF54C032A69D625A99CC70DA9D0D0558FEB4973CF85AD9D6607EB6171F0720ED028917AC19F845363A0A7833C74B445F7F3AC74F083403E40875621181C84F3A930492919FC1611292D7B79F38E03AF7786DE59F097C3D78960779C2CF23813299C8BE6EFE79DC4B9C40B9C5F300EAC7FD04E294E7DB1B5EA703C1F757F176803F2A27FC1EF2464AA37E1EC59FE5413EFFACE2E71C69136DA7CD085FCAA2BD08826071B8C0E575FD6543CB16543E6C719AD5B4686A529C6237AFD3FA752BCD67CF374B739D1EB8B7836AD56CA5871EF85257D67C4377DEDD53B5AFEBA106B7F7D5F91774D61557BEA75BEB7FA5BBEEF85A75AFFF58352FEBA83B1B98597FEBB7AA56F525DD7273175D75F5CB3AB37243F5EF37CD2DFE65661468EB9678A5A7984B969AA3B86DDB4DB825BB7A2D5BBE48DFF4FA528306F7D398B1C33579CA78E182E07E2426629D21041146FBF2D10B40FA333C7D9F4C1EA109F2BB743ABD78DAA6ADDB446EDE1FEE318D3C77DE22FDF4F3AF9A3C758A36C56EB62B04A46AD0C100733E2171A7D3E61B37AE7715678030B1D6AE5D6B83C47382BC0C0203E088CF40D8A5ECCCAC7DD2822F80EC1AD719BBD03DD966E2BB34762378903F34F004E2043FF1E9641661B80A32326D02661B69ED56D2D939159F98A08D9B372971CF6E17A7DE1B366CD847AB12E847E0D3C289E79F1BEAD3A209ED4368A05CF0790894E5F3910EA1BD16A34CCAF6402312C2CB250FE790817B089449BA7F8E3F2784D799B0B77D7E9188F1B4383FDE6067803867C4396699FAF2D782DC85CACCE6C7184379AD6C9E13DE4E3F16E169BE4FA883AF178138F0E5107C3D7DBD097BFB2120BA8BD9E524D3A8B946689FB520C7AC49B306196316DC06FE3246A5CB9DABB73B4CD2DD46DCBF1DF1A02EBDAC93CE3AFB159D7CC623BABFD197BAE7815EBAE2AAB7757D9DB774DEF9ED7459CD5775DF831FEABA3A2D548B9F87BEEC699D71DA1D8EE89F7CD42358FCB32AF2DCF0B1E67FB667642004F7B6DBF70104C62ADBB275A3E6CD9FA51933A669E2C4F1E6A6C46ACD9A356EBC8B133C1C111301831DEAB888F63F5FDDF8F81E9B3843478DD2AFC34769E9CA35E6670403E9609D4505D0B04EB39A86C5EF484D4DB601457306A63E9D8FD40D266881BBCE3537A1AC2048EFBE1DB638AB9594431AF5F002C15D3301109ED70B067C7B8E2EAF052613C1D72F3C5014BF2DC6A4CCCDE3AF956B7F90F0C4E3E2772929C5A4AF9D3169298B7AD34794C704A33D7EE2711EFE0C068F6BFE3A56820F5EB313B8EEEFF3034EB93CC34F56D239678C809FDCFE3AD7288F72B04808BEACF0FA11C843DCD79FE0DBE1D381BFCF5B4A9EB8BE7FE81716B388F37B6D3E9E9D6BDADB503CDDB797E0FB0FF873DF46FF6CFA8810DE57042FA0BC194C7E841A6DF0EDF77D840B441AFF689147F9F6D29EF4B43D2E1F8ADE3C48C594AAA8EAE7DDA54E1D27A961FDEEE6B77F685AFC5D5D756D67D56DD05915AB3EAACBAE6CA7532B35D6CDB7BCAB2B6AB5D515D736D7E1475FA9B3CEBD55756F7A461D3AF4D3C517DDA1A79FEEE0F6D5D370DF0E02027BD3A6587B765027B47B7C7CA21179BB56AF5EADCD9B376BFDFAF5EEB87ACD724D9B3E4963C78EB63BB15CB6E8D75F7F56EFDEBD5D59D49D7E098D731167DD9FD0E01525FA01261ED6B9EE1A7108949115A4C59AA499B17081926CC0D3CCACA6BBDD009A64F2D2DE073A12F242727C2616CB42AFDDDC60F22C7C513F381C31EDDDFB6D33F959D1CFCC32D334CFCCB4B424233DBB8C729DCF4EA313E31302725BC08DA04CE007994027502B80C6A11D6868261F699C93EE565E6D62724E1B2077F0E382D95AB97A95D23282FFF2C17DF4C9F2E5CB8B265EF8A4027E50E97C4F3402529A405EEAE949CF396584C6C09541DC0F2247CEC9CF7DE18149139EE6CB2078D783E0C798B2083C833E27F06CDF6FF8FB1CE9CF952B573A92007F1F014118583D192ECED3E9AB3DC949AEBF88FBFEA25F893337E8DF943473E942F5A56FA8870FB48580CF4D606EF8F690172213B8DFF73DE9D48F72B8EECBA6EDFE5E3427C13F6BDDBA356E1EA274D8E1C962588699D7DB7716EAE8E36AEA8CAA77E8C24B9FD00D37BCAE962F0F5795B39AE89ADAEFA9CA39CD75E6F9CFA8C2998FE8B6BBBBABDECDDD54E1F4BFEBD42A77EBA926DD3465F63ACD5AB4560B975ADFAD31B7606BB2162E5CEDDCDB1933A798153C53BBE2B75BBB76B9B625C4271992B563479CF5F766ABD706775CB66C995B4CFCF1C71FD5A74F1F8D1B3FCA99F82929AC53ECA62556DF34F5E8D1C3B58936D30FA1F616F1DAFD21B1F8050F6EF23732C0FE9C2E4CB207F41D3258BD06FCA04973666BD4A4295A65D269E888911A37697291864FCF0C340A01C2B3D28834C2AFA6620013383939D524D7162B7FEF80B27B2ECBFC707E2000F33F3B2FDD913EDBD2AC3457168D4570382BC002CF6382F16C00897D3DFC24E39C89C835D2C80F988C09BB138BEE218D5F0EA51E7B92775B5A81D66D58EFB4BB2F9F0029FCC4A2C3E92F7FEEB5860F5CF7A46342A2897C7E4C6BD7BFA17B219A0FE4F165FBC075D27806E3431C30B9212F797916D7C2EBE1894DBA278D1F5BF2731F983973A6CBE3CF21607C7C9C3BDA63DC4690C4DD8C4DA8AFED0FFDBA236EA73B4F4E4D717D49DF734EFF720EC9FD1851AEAF8F174204DF1E4F642FDC203F797C7AB890F281FB08C5DBCD79E8D56D28D8589802C1DA44A9401AC638C5E4EED3CF74D331C7DFA61A57BEA2BAB7BCA5FB1FFC58AD5F1DAACA559F32EDDD49D52EB0F4865D75CD4D1D54EA88BB75D165AFA9EECD1D7549CD7FE8B50E3DB4333947938D178B562CD39C050BB574D90AA728962E9BA755AB176BE1A259EEC83BFC59B36668F2E4A91A34F027FDF0C3400D1A34A408DF7FFFBD23FA82050BDC02AB5FEB0A3810B8C8BD7AF5D4B5D75EEBDA471F318EA17E2CE2F23EC40E47D029416733F868212F3109ABD6AC56D3979BAB65FB767AB14D6B3DF7720B357FB5ADC64E9DAE57DBBFA9464F3EA5DF468E72838FF60304EEA772F8EBBE2CCA9D366D863363FC40AC58B142DDBFFCC24D86351BD7AAFFE01F8CEA795ABC6AB1FB30C0A69F468C19ADB11327B835838F3EFB5CBB76EF519A99EF1F75EFAE341BE0789B90EF7FF289B336D6995FDDFB871F5C9C4F06BFEDFBBDBBEFC75F87EAA7A1BFB9F880213F6AE6DC7945E5C525EE76F177BA76711F2E649A45C191C9CA7A045A7FEBF66D8EA0F411ED41022F5AB4C875F68811239C2F4FF8EEBBEFDC646462B29FC04F54366A1030CF860D1BE6E2B4BD6F5F764E055A8BB27FFDF557B79EE1C3BA75EBDC0420701FA61E61E8D0A1CE7FA32EBC7AF344204E209D5773948B90F16550F62873C5C8BF64C912F5EFDFDFA5633A12FC7CC0D54248135253D8AB2D9B80A94A4BCFD1DF1F794C4D5F6CE608BD65DB568D1D3FCE8DDFF091235C3F2104468F1DA36D3BB6BBF80F030738178049396EDC3857268267F8701BDFD0B3060F1EECD2274E9CE816DA08F40D04A62DD49F23F8E9A79F5CBB100AB491B650FF79F3E6B9FB7835B970E142279566CF9E6BD6D852733D827FAD4C9B121276BBF630E62FB7FC480F3CD84D871F798F2EB8A48DEADFF181EE7FF433B57CF5171D73C27DA6C19FD5D917B6D1D1151E54BDDBDFD771159ED0B575BA9A6068AD12A52ED4DB5DFA6AAB69E995EB576BD17223FAF22546D67936371638928F9F384CBFFE36403FFDD24F8387F47766F8B061233461FC144D9F3ED3F161CA946956F705AE0D90DC2B0104130A0FD26391A0E4860FFF4DAD5AB572EDFCD364075ECA73F48182B66DD9EA8858BFE1EDEA617E42BB4E1DF55C8BE67AEAB917F4F3B0916AF7E6DBBAE1A6FA7AEFC38F94921198C1F8BE5E9213300B19200604BF840662B6F8F0F3CF3FEB92CB2E75E4FCF9B761BAFDDE7B6596953EF9BAA79E7CBEA9D2F30BF5449317F4D388D18A4B4ED363CF3EAFB94B5629312D47773DF48896AFDFA4B55BB6EB92ABAE51A63DF4E7916374DB3DF76B8F39625FF6F84E75EAD57783DAA4690B7579FF63F1D5E06DB7DFA3C13FFD26F655D4BCAAB666CD5BA8F83D496A78D7DD5ABA7285233B9E3C663FA628ED993663BA49E4C94E1842E6162D5A987F667E994DC6A64D9BEAA38F3E729D7EC30D3768C68C19EE9D6FEDDAB5DD3BDF69D3A6A966CD9AAE7F21D74D37DDE4F23251EBD7AF5FD4EFB80877DD7597468E1CE9CA053F98E0BAE69A6B5C1FDE6B7DF3E9A79FBABC8D1A35D23BEFBCE3EEAD57AF9E233FA4E69973E7CE7544BEFCF2CB9D80428054AE5CD9118BCD4CF7DD779F2BEFF3CF3FD773CF3DE7CAE02D0381093765CA14576FB49F0BD6AF9327CED10927545299324729A64469DDD6E07627D8BBBEFF9EEADD74A31BEF3A756FD0D73D7BEC134720543AA3B2264E9EE49E41FFF0BA72D2A449AA55AB962B1E1FB46EDDBAAE1E2FBFFCB25E7FFD7527249F7FFE79BDF7DE7B6E2E9E77DE794ED02160AFBFFE7A2728A9E7D5575FEDAE77EAD4C9B58B36BEF0C20B6E7CAC897AF0C107F5E69BAF3BA2C7C66E5266865935C845BBF6C1270354A2F4F9FAEA9B353AEAB88755FDC2963AEB821774E115CDD4FACDD1E68BDFA933AB37D70597BF69267C639D7F791B33E95B1BD1DF72DFA41F794C6D532693949496AFE1E3866BD294F11A336EB413CAC3870DD580817D3572D42F9A3275ACA6CF98A0D973A669D1E2794E31242561E57996606DEDB51009CC0F76A16E8EC57FDFE8F6A58C1933CAAE044A92F1230F7384365B28E27351245C0A8426998B876E7085A07D98B0A3860DD7C6F51B0212DB9FDD2649538DB42BD76E3072A468F682C59A3A738E128D8494CA07F87E859B41A64CCA22D0F10416251213F7B84E67F71066E0B0E123DDFD33E62ED4C215EBDC96C41F474CD4069398186CDFFD385C2BB6C4BBF837837ED3FA5DA9C2B0193A768A32A8576681C64E9BEB7E7E373123DF5C0ED374165FB56E9B56AFDFEEBE44EAF241F7E0734253569DBA7CA22C6BEEFC45AB356DE602F7EC9973166AD4B8892E0FFFEA27C9CC4F4C313413ED41BBA381780F4F60A2A1DDE92FE25EABF4EAD5CB918EB633893D91212381FBC78E1DEBE298A9081002E3E20580F7C7B9973C63C68C7179D056E4271FDA6BD5AA552E9D0D360817061E61E0C792BA500682D697C11B0536E01030DD2993674124EA86DF485D83F64D56F7EE5FAAC16DF7A85C99E375D861471B416F544666AE76C6C5BB7E59BB7E9D7B23437CD1123359172F72F139F3E63A370981F07DFF7EDA9510EFFA6AD0A041AE3E101F6143983F7FBE233FF5183D7AB49B7B04AC00EA43F0F7016F05D0CE9E3D7BBA38E4F71A9FF2E81F02A6316F82D08AB88E8E2B36E0EF76FC468795BD50E75FFC98DE7C679A2A5669AC93AB3CA672C7DDAEB32F6DAA262D7FD58915FFAED3AB3653D5F3DAEAE2AB3BA892F9EEA58E78D4347D3B9D7976139D55ED5EDD7CDBB3FAFCEBEF3465E6248D1E17EC29F9E9C7C11A3278A05B4547C0B07D3CF8E967E602A01258297B79C18761D41DA58B82A40D53A74D342131D9E2735D7E7C77AC65F2D176FAC25B91168A385E44F4708467004C2C061A6DE23A39CFFC2534B68D1EB993D3CD17B623BFAEC92B2AAACD1E60D278259765890CB407010DC120F33FAB09346EFBB65D4A4E6251C5EA51688DB4F45EBDFBAB5EFD3B1C49D7C4EED1DF9F6CA664BBF0F0B3CDD573D070FDE385D65AB53D59AFBDFBB95EEDFC999ABDFE9E464D9AAB1E7D7FD23BDDBE72F73DFC4453B750F2C5B783F46CB3B66ADDB6B3B318264D5BA492658E33B37E89FAF41FAA134E394BED3B7CA0B3AA5F669ABFA1AEBDBEBE9E7DBE85D3FA0806084F9BBC09CF84457811200A8B2C04C8453FD2F904DA490875BE3BA2597D3A6627A1783E4C5A3F2690C00F26DA0DB292CE2420F8452C1FBC9BE08FBE6C8E940FBCC0C18D42AB4278040542076B0273F9DB6FBF75560747AC2DCCE6BE7D7BEB934F3ED3830F34D209C79DA1C34A1EA3EAD52F71E3E516EB0A0B5CBF70F40B9CC4BD3B8745E4D7440075A15EB4CFD7D3B795407FFA7402F5E69CA3175A04BF0A4FE05EEEF3C197E5FBD36AEACC61770C4E4D89CDD769275F297E4CE296DBDED2AB6F8C574C991B75D2998FAAEC090D74DD6D9DF5F48BBFAADC91B7AB72B5963AE9F497744A95A63ABD7A0B55A8DC5255AAB75183BB3E37565D6438558D9F7FC9E68B59AE3BD669F192399A3D6BAAD6AF5B65E39D11AA9BCDFFEC34B32E5057EC92632D291813B43B5A7DE5CAD58EE0F8EB708F31CAC874ED74DC84E42C780708C69ABEF3F3833C1E5E73BB133A2D3C0337202D91F24C263AD30D888D5036FF363635DD1DFD0AAC97EAACCA6E31D39CFF47CDB91F680619F3974A5169CA27E0A75BB1EE1FD5D311ACB359769B80496AF74637357EB183B65BFBA62F4D5493D73ED3DA54A9DEC32D3466419C9A75F8461B8C635D3E1BA6EEDF4E52FBB7FB6995B976ED3AF7D5CF6316B9FFC651E39A3B3461F6467DD16782DE787F887E19BBD8B904A757E547FD2A1AC17B69FC84F5BABCC6FD7AA36D2FB568D649DFF6FA458DFEF1A299808FDB64B2A1B0FAF0CE9D36A0E9C23B967EC3CCF5FD43BBFCC46352425A3FF13CC97C3AF9098C03E7A4039FEE8F8C0B79FC18F97402E980B4F0094F3EAC01340265E3E72394A82B2E01160844463B7EF3CD37FAF0C30F9DA61F3060804B47FB61FA938F3C109DEB8B1707160055484FCF34AD7EADF56349976655770BA0F413ABF12CD0417C16E42038695E8811E817CE115ABE0DC00B37F231F7FC5CA1EFD3529395633EB6DFF9C61B18BE4387B04C385EBF821DA63C38E79D3582D852AD5EB98ADF95E41616653EAFFBCD778B2E5FB1D3DC90B375F851B5754D9D0E2A59EE667DDE832FD56AEBB46A8FEAA4CA0FA8C1031FAA699B5FACAD757461CD572CED499D58A9892EAED955A7566EADB3ABB7D6996734D1E1E52FD5B34DDE76EE20ADE4736DE60B6D4591B91D6206FFCD7AA01E4D109AFFCDFBFD152B56994533C5AC99B1D60F49268C136C5CD3ECFEBD5C05F4895F88F5693C837EE418EAB3A2FC314CAC50C71725023A181F0293C9FB6D0C0A95CE33A963FDE3FC70C8CE312939557DFAF6D34BCD5AA8FEAD0DF4CCB34DF4DBB0114584075E9A135870205021EFA3AC5AB5C62A6AB9AC3A68F83E7D06E91FA6953FFCBCAFBEE93F523F8E9AA7F65DBED5AF5357EAA957BAA8FB0F63D5EC8DEE9ABED848FFDAA79AB3385ECF357B5FE366C5EADE46AF68C3F66CF519385A6DDEF850BB4D787EFEDD08F51F3A4FF73DDA44EBB7A5E8A9266DD4B96B0F7DFEE540DD777F13357DFE4D0DFD65BA4A1D76AC994152B76E5F6BCD9A5857677E2924D3AC10DC1126266612FDE609487FF9C9EAAFF909CD80B0B8E40707D39823DA9DB7106856481A1AB47D0405F7841398341FC2AF3399E953880DA931EBF1C9597483A05F7FFDB57B6D03BA74E9E2F6CE4366C0E21DE6393E25263CA4663D81348402561DE67068F238F278014D60CDA555AB36761DE192EA16DD10EEACC0BB053813F6FE5D3CEE0FFDE4036532A7BC1004F48917A6F42169B475EF7DF481B53DDB04456A9ADB6BC13E0AF7D3CE665DB2E594875147EAE4886E938A373AD9B96851C624C12915E61A9AFDB4CA751553EE62F73FD5CA1FD740575CDF5A8D9BF5D36147D651A963EC5AF96B746DFDF66ADCFC0795287B83CEBEE4059D56FD699D54E9599D796E5B1D7FD2B3BAE8A2D62A5DBA9E8E3FA186233A96607A4EB0BA4FA00DD423F8B1484B2B44F06CD3E245733569E2588D193D52A3478ED29225CBDC62218ACF424CE85561113743E3E02C72FA2DD42F4E59C355DF673EDDC36560E2F98B1E13264C70930509E127A19FBC4C7AB4FAAEF8C4A28D146E209904465CAFF949E3DCF9E95EABDB60D3F9AC4E631A061F6A2468E2C4C9360107DBF972234B96962C5EA156ADDB6AC9F235EAF96D7FBDF7E197666AFFAAFE4346E9BB41C33474DC2CC52664A9D3873DD4C7D23A7ED0534D5B7552974F7A6BF9863D1A3571A11ADED348AFBDDE59B3E7AFD0D051D3D4BEE3677ABC495B4D9B3DDFC9D2F4AC7CE766B8FADBD1BFF283D08C07E05A8A39F42E8F61F79E64471EC06217E6D5F8F1E39DE9CBEB3736D778423261E95BB42BBE33E426704EF07D4B7F232488730F939D7500E0DF8210A7DF10C0685B4C3BB77E6264C6FA42F3E266E1EF42643433BE2AA637477C5FF232AEC421366D608C59E9A60DE465251C01EF57AE7916D7791679D0FAAC64137C7F117C1C41E04D78401CE27BB707D27BEDC39CA3CD80B83F679ED1871C7D5ED2E94BCED1EA6CAA0A086E82C2506883E6B6BB328ED908025E47FACD608C479EF6A4C4875EDDEE0936595960EFD569956E34269CA78A673DA9332E784E4755B85BD7DEF2BA3EFD76A97A0E58A33E3F6D528F1FD6EA9B011BD4A8491F953DF216D3F87555E5DCE7747CC52775F4718FE9828B5B5B1997AB4CB94BB568E976E7FAE51899AD16450286909692AA0DEBD66BDEDCD91A3D6A98468EF85573E74CD7CE1D5BDCB66FB721CCDA68619FCF9169077D405FF8B4480809C988AFD3F7C9182AC8055637BD4667223251D158EEFDAA4D7B263EE61A713FB8A4397FCC227E412ECDCC3CBF9805D919700612ED0659F00BFBF5FB4123468C72D8B2655B91C0C015E03ECAC28C21A04DD8B29AC54E393B4F37B6A698184DB57E49B5EA239658C8A3255CCFCC321FD71C6EE2FC9A4842AA69632B1F61449D09BC5FE50EFE77569E0D4CB05E104C56BFB106D7C4B709CD09E9E87CB43C4446A3A261FDE4C40A82B4687C9F8F34426810FCA0BA73FA9A750C884DD9080EAC01C681453E088A9685C4DDBB77774060426488CB35040E80D4BCF6436B6382A3E501A485EC73E6CC71C4E588D6260FE5730F8447587CF1C5176E25FBB3CF3E732BDF1C3FF9E41367EA8F1D3BDEEAC66F0F40407C45DE10D0665E3FDA5899C99E9A9EE6C61D7861EFE708FDE1C90D7C7F107C9CB9467FF9FEF421B807A10881F6EE5708347F309E966CC48734D429D5BD5EDB18BB5699397C9391AB6DDB59C0B472ACFB6FBFB3954A1F7E8369F5063AA14A639539F91F8A39E276F3DBEBEA8CF39E53F9E3EFD631151F52C9231AEAF8D31E53E9A3EE55A9F2B7EBC48A8D7452C527F4B7A31E56CDABDE3426D5D031275CA9CD3B6C0E592333ACDDD985E99ABF68BA962E5B6882759CC68C1AAFC913A7B8751136D204B33440F0EE7C2F1781EF9FE2E91EF4157D13EAB38879C2B1CF098486D84C5A069F80F9E6FD290A258E8661101834D2C27D2EEE45BA3311E87CE25498EBC156D8407840022638D720B05FA8C3A46742603D10784620993DCCF2B0C1C6BFE1796C70C98490164FB7B2B6ED4E54AA49F8759B82D57E9E456052D2AD98563C20233DC7ADC2B2AD16ADC02EBCEC2C330973334D10B068C231DD845BF0C5959F70D49389C564E4E8DB8644A52F005A987B30ABBD16F7817CF41D5A8A051708887665B51D731AF319427A52D2FF08178E6859C8CF114DCB18A19D59A9264E1A6638E485CC901721401A0280F230CDB9461E888D16E79CFB49231F0283957C4C7E2626828C3631CEC17804AE0C81F1A60FFC9139445FD14EF272A4AF88D366E220FC7A789C72FDF570F874CAE09D38E01D337D49BD7826AFAD9877E929E60BDB703116EE8391944467C223C0F9962127DB1487CD81366DBE16FFA2A9CC91F7EA94335AE8F4F35BEBA84A2FE8F8535FD231273FA798B2F7ABF4910FA942E517CC9FBF5D7F3BDA085EE1799D72EA73AA5AAD99B1E7169D51B9B11DAFD431C7D6D6A75F0E76CA06EA8D183B4CBF0CEBAF854B666AC5CA25DABC71AB92769B65174C4717585C431015277A68AEEDC34DDA52FCE8E391CE23C1FDF1857BCD0341A64F9FEE342F131A6DE3350D1D8EF466E1203676ABDBC34B27B3C50F3F83735EA1B1AF9723F9980800023019BC70204088B8383E84C971F7927FC3864D66BEB281277825C4A20C9FC8EEDAB5D3B468AC12E3CCB4DDBE4D896E9BE12E5727DE7D679906E1D55862B299C029C1F7DA7CA7CCBE00B4251B3D769930D8B533517B12F9B17D7B7EDC6EF759236DA01E1CF9CE7E679CB52D29DEEA4B39A94EC05177041647DF26C004240D62A3CD6993176C04EAC739D779E508B101AFC3DE7DF75D75EEDCD969CFAE5DBB3ACD49DA6BAFBD6693B18D5E7DF555F7AEBE5BB76E0EBC368384BC1767430EAE10AFF248077EE51C731B8D8F86462BE3B363E27FFCF1C7EE19A45106D601F77DF0C107AE7CF22074203C422034811CA9183FE6021608A04FFD9A0364F5FD439F70F4EE88EF33DF07A413F7D7380F07E55186179A3E9DBCEE9C718F8F738B7309BB8CCC36C62CD6ED49B4F20CBBE3EDF936BE2814C8CE6B2E94C896AD71367FCC5AB579F5E3C0392A79D8C53AACF49D2A7F74631D57D1085DF211D3EA0FAAD259ED7542C59774ACF9E1D5CE69A5934F6DAC7287DFA72A555FD4D9D55F564CA9FA3AACECCD2A51B296CA96BDDA58545DF7DED75C6B63776ACEB2D99A386D92129376D83CDC62DC862FC62F23B93B98251A7CB969EEAF4BB04918FA4FACEEDF3F9B950AE7E84FFAFC8F08FC67E0FE84485E6436F030B409D29D0E46B232584C6A0600527B42434A48421A4425EE898F2FBE7DFB4E3731200003880F4A9CB2180C48E48504A63A663C0B2C9485A94879AC0DECB0E7ACDF1CABED36B80C321A393E2E98143C6FAF60497364673B2B75DFB16DA7FB4E19C2B160146792DD5B15DCE385D5D62D3B9590986CCFDAE3AE5347F2ECD8B1CDEAC7ABA9AD561F26F96637F1C2056030A9D8EECBBEE61DAE8DA4D18F940169D0E05E03796D4F9C3C3E84138B3C948F990EF9786F0C5121292BE79C03C889D080D498D9E4C1C487C81018D2E3CB436A409CFA2C5EBCD8BD6E43F363E2A3D1B110480FAF1FC113D9CF8122D2599B693FF544FB73A4FD8C37E90836FA81348E7EFD817838480B4FF7E4F6FDE88F45693BB73BB2C7EDD8E9BE87E0B86BA795B333DEE64482233A71F222AC972F5FA9CD9B766AC3FA4433EFA5C96337DBCCAFA623FF768F4EABFC92AA9FF7964E3FB3838E3DB9B1CEA8D65A55CE6EA9C38F7A48479FF090E5BB5EA5CBD631C100A96BA864C9ABCC5FBF44D52FB84357D77E403FFD3C4D4B96EED08EB8C07234FBC3ADF8F3A395857656C8FB2023BAFBBD5467981AC91966A7E15D8291DEAC45344FE8B5161ADFC2EFC80AD817503CED60E1FE40609FC0601298846CA16412315119303F01592D5CBF7EA30D40BC23331A9E0DFB8038691095EDAFACD432E80C3E8345996CE7A43C4C44E2101CC25226F9776E8F376DBC53EBD66E3269BC539B8CFC9B8DB46B366ED1F235C1C7018067B0EB8EBC713B12B46ECD46672EAD5EBFCE6DCFA43CCAD8BC891F93B0FBD7ADD586D8CDDABA6D9356AD5E66ED58E4B453EC5623B13D3776CB0E075F1FEA0F21203816055F1BC56E310B213499E90B2614E7B491BC7C2CC2AB2DC84080C0084D88862025D0761FB0A2C8C391EB9E605E08F823A63BA4066869884E991CD1CC6CC145C3938630F05ABF6DDBB6CE62F07E3EC280732C89F7DF7FBF68351EB781C546480BA9114C909A36313F9817BE6E087F8421E9B41BEB8B3EE05EFA93A35FC780A4C4B9CE917EA3FDC5D3780E71CAE2BEA0DFB7B8A3EFE3A2BC2674213C16DB8E6DDB4D399860D96863B13DCED2AC9C582B3F769BD3E808E86DA6D1137665BA1D720BE66E57C9988B54BE745D1D7BECC3E6739B195EEA318369F5987B55A6DCBD3AAC1CFFACA1968E3B851F85BC58A757B94597D478400D1ABCA8A79EEEA8DE3F8E57AA1116B7913528D67258CC4D34C1929C6B1663A109F964FE1163825D0BC8EE6C7BC0D2BF9DA3C5F38DD4FEF7E61CC8475921B2873E122B22EB8184C0C1A028121AC8F0B80B4C5AFC3C26112BBEF87F74BCF721593C62459D73BF3ACD2A2EFE281B333892077F1112041B04163992CE98C16EAF356E051E208139A72C80300094CB3388BB853DCBBB70E162A78556AD58A9250BE66BAD3D6BF1EC995AB76C89A69AE65A66F5586EF5D864C284F88259B3B4C4EA417CF5A2A55AB37899B69830583C7F81562C5BEE7CE1C54B97B8DD5E3C8F7A533E6D04C449A31EB4C56F72E09C36D166E280F6729D385A9AF2E83702A466028799682E0D3261E540329FCE3800AE532604457BA3B5DF7CF34DF70A0D93DC9BE71C3DF9B100D0EC7C09856FCE5A007DC7182060BDD0A54FA90FCFC54AF2DA13524164080639B9977622E088732FA4E75E08CE7831DE940759C9C339F7D00F5CA78F01FDE68FC5AFD357F4B5EF4BCEFDF803AEF173658B17DA782DB2B9B764BE962DB5BE5EB2C0D26D4E2CB4FC8B176AF5AA15767D817BAB307FDE6267426FDB92A5D32A5EA63225AED6E51737D1DFCADEA2538EBFDF58503B30C9CB9BF62E71814E3AF926DD72CB8B7AA3C3D74A48CA751C65C9362D3BDD14CF16B758CB22AF8518DEA1B3DACEAA7B5E6186523312430BBD80B50323B599EDBC29C84C37A49980603FBB1117F06681B709FE1F3502CA3D14288A84931DB30D9F9AA34F633232E1203C1A8255747C42B4BE5FE94528B048C4390B3F9C730F692C24D1F1800D039095D76D6CF61F378E05A94976DF544D9D3ADD99997ED10850169A87F258441A33966B535C590BE6CDD7D489133477FA74CD9E3C516B972E76649F6DF9269BDF39CBEE996E75E37C919174B11177FA38ABB395B164DE024D1C3B4E53274F71CF617BE7A42993DDB3FCB37DBB20AB277E785B59DBA0BDD42BFC9C3A734E7E880FC920AD5FDC448BEF5D70DABBE8451AF92012C4E39C00F1288F23139EFEC46240CB331E901BE2A3F9BD5667E10F0241500F480E21A90FA4C412F1249A3D7BB66B276346BA272544F40282323C4989731F71FAC42F0832760817FA84F2E84F8E807EE39A0769E4F37D189E87BEF4F98803F24C9F3A4333A64DD78CE993359DADA386695327BA7164B59BE3149B0B7CEFCD87278B162DD1A8911355B1C2D936E38F359CA6BF1D71A1CA95B950E5CB5EACEAD51BAA73D7815AB42C31F8F557D3AEBC3A4B4937AD6D7D9F959F6D1A7CAF560D2D1E075C09233BBBE53273CC050AF3C3C31158E0FBA6FD3B1131319CF8918016C03C43E232C06812348BD73A2C28612272CE44C42A4038E02F626A12C774E4B50FC203BF12F838AF7E38F2FED8BF43066CF60094C34214797E1C3C44FDFBF4D68FA4D9737EB17C7D7A7DAB9F2DFDA7418335EC975FF5E3C0411AD8CFF27FDFCF5DEBFF5D1F0DE8F3BD86FEF4B386DAF5EFFBF47565B1577BC84F3FBAE71F083C1F849F87D79F236635E96863FC6E7C52020443834272080D3087FD7A06F94823407EF22118BC8F8C2000080CE02D01C603C2D03F3C0FFFDB93279C4C5E9041480412201D41E2D3BCB0656C112AC00B76AC1AF2F01CC60697813863495FD06E9ECF02240B89081CDF57E4272FD7B036BC0BC1589297FB801F5BFA91FB887BB8BEEE3F50830658DF0FE8AFFEFD7AEBFBBEDFAADFF77DD4AFEFF7EADBFB7B75FFEC737DF0DEFB36D7BE55FBF66D5D1D1B34B85DC71D7F8AEEB8E3010DFD7584D6AEDB6CFDC8FA8891D94808A9B3CD24E77FABE5F3555921BF7BC046A04CE5E4BAFD1111B980690D78A5C73EF7C06CB7B8F9E1C5F3FEA71131D183C9C48403C48B5F0F071314AD85898F3663723101D038681B8400ABBD989F2FBEF8A25B69E6EBB0575E79C5AD38730EF84CCFA375EBD6BF03E9EDDBB77747BE606AD3CAD25BB5D41B6D5F53AB16CDD5A6E5CB7AF595567AFDB5B676FEB25E7EA9995A366BEECEBB757D4F9F7EF8913E7AFF03BDD7F95D757ABBA3DA593A7560F59BAFAA5E6ADECCD5C33F8FBA019E473E8EE4F5E91E3ECDB783BCDED446D342187C606F1E631AE39F4272D642E83B34A5F757F18931A1B9876B9002331DE1F9C61B6F14F9DD98E9900001DBAE5D3B778DAFDEFC2A3F75F0EDA0DF7C5D89D3FF3E8DFA02D2DE7AEB2D570ED7FC2A3D6D225FCB962DDDD77C5CE3398C41789F70A41ECD9B3777F98833FEE4E7AB33D2288374BE5EE35D3EF7513EF5251F799A35B371B37C94ED9FCDFA03F701CE79F6F3CF3F67CF7A491D3B7674EB4B2896EF7AF5D6F8B1C1AB4B0428EFE4D1CC1959A11FD070E445CD1AB9DD37E1367FF1B5C5F534233BDFE093877D211677BFDB1E79DE8723203CFB06C2F17BB31CE1C0B5E2E9871A1113C11F69F7834568512AE23510D2627FD9F3FE08EC605AB460A18698D6EFFDED777EE5D95D0B775BFE2AD07E3421A467E24160C88EC6C6AF85D86865842464F7AFB32038C4278EA04580A215D19CDE2CF63BDED0C0682FB420DA17531AED8999CF3979D1DC6870E0DD10C0FD5E6BB2228FB5467D781B83398FF94E1B582844006131A071710598C8E10B89E16B10C4116C686A04964FA78FB9C61117001701770C17C142C43EFC57403F1378C75E68E4466343723E40097D97EFF241527EC115CDCC7B6FFF510ABEB7CFF3DF8E88897F169188EA49EC8FFF291CE8BF5D62B1F8F81F592EFF0A7867CDF7D310085F18F2431CFC6116B12015FE288B7C10009F98B85F17E01C824354480FE1B09CD06298C2101B331BE100A108B427342E2E7802160F901470DDE7E75E5F8E27B35F57203DD46FBF2BD3DFE3CBC1F5400821DCC2AF11A75C2C1BD60EE807EAEE1503798887CAFE5D7FB2F0553C0DB0B8C58297FFDF0259ECA2CBA66DBC15C9751B6B5825678BB7FB7D85D0229B4768CB6FD1B959F545E7C5E751A485B443B9B8F657206262380EA49999142C201D88D0A1812F3AA73CB63B065B54F7CD7B28517C20C3115EC703B5F760E10507E5E2536382DF79E79D8ED8101E9F1452437ABF8009D959C803A4A18DD1AA10029263B63EFEF8E37AF4D1479D898D264618A03D2115DA93718044616E973B279D7679E2868750DB8B82CF535C30F03ACE13DE079E13EA2F47604F627F4E9CFAFB409D482BFECC48A4260F65EF8FF01EAC9B056B6711AEF118E3735A6AB68D03EFBCF92027CDEDB6E4525A56A6DB88E5F31F0CC27F68F560507C853D78D5161C7DFCDF858889FF0A3C59C20904FE0A12FD33EF198B7F1678A8407B8BB7D903B25F76D965EEB5184446D3A3A131B32132FE3C26348B62FE0D008280388281054D56A43D013942267F4EDF7AB211A80704F7E73EF8739F17F2E1C6784D0D1129CB9392C0E2216994C93DC411603E2F8174EA0228CB970FBCA0F18134824F0BEF331447A82EEE7C7FFD198E022B0610E72392A2575A59B9CACEB236D8E3D803CFD17DB7619EB9A9276599396FE2C4CE4CF988D5F64061D106D2ADC52E3F697C47C1F1AFC67F05D9FDE0174F272D3488FBA4FFFF06AC8A7F7583C2FE10DE2FDE7A993265921E78E03EBDF65A1B236E6FE777E35F4376BFDA8C394E3A0B99F8F71C797DC6C21B7134BD27207C01685A7C524FFEC0070DCC72AFD94967BBA6FB411037B9F0AD21A2BBECE2FE136342E811AE0C0F9EE349EB9F15941B6869FFA39FC1B32DEEB688413423973DD3FDE2AF3D824F5203CD18A6DD2D3DDC5C3E10FC0258F1F4FDC111D73FC7C2FEE6ED21877F1557F44A8E79010EBE2D7F052226FEAFE35011BD384266AF8BE393E28743E8279E78C2AD34B39ACE1B005697595D47F3437A16DE30D13181BDD6F5014DEB3F2E623273F4C443E3065F83EDF5D90342D25E7C5716D448B3B310203DF0A4F7C4E75ECA27503E71CAE208C209EF8509C740C0D933ED88FF0CE1F9D0C8695688EE8A0F5C0BF7BD798E697FF3AD435FACFDAE0FC31189ECDE4C765A3D37D877EEEB4EFFD37FC449231E3E26FF56FC8EEC1CF76DCBA146C4C428FE3540461F2FEE4684BEEE2B12044CC2BDA4F45A28205038F85D3ED201F7024F4048573C703D6465390100E1F7921E2DC7B7E201C92038E7903F0846DA3CF3C70DC43D209A5BA90E3DD3939D72B11AC29FE1B53A47BE6340AB3B0D5F10581A21A154D42F870AF451A4F87F044564F78890E71022626214078F480B7F7C90939A1ABCBFF5D8DF02E15E821B9D42DA87AFEC30C92110C4803CEC93F6C4E73C5CB3A3258903C8CB6FE8F3692E1F81403EFC729F1F721247F37BED1FDCB75793F33BFD4929890E2C68E1CFE641729BA0BCBEF2C28523F7513734BA77137C5DD1F6A4D3269EE981D0F02E4E7114D7DCBFC7BF9F247F25FEB87D870E1113A3F8F3E03B6A1F87D8FCDA0E6015D8A783704D0FA121A3270644F147C035EF874324AE7922A1E90382EDF54BD1D081E5C0795026087705A84F604207A40DD7D090DF6DD7B57BD94506884372C8CEB9237CD87D3C9F7A50575F77DF2E407DBD90E118D4251010E12675A80D45FD1419088AC0328AE2CF236262145144F1BF878889514411C5FF1E222646114514FF7B889818C5BEE0FF6A154F8B228AFF36444C8C625F44FAE5CF28A2F8EF8262FE1F34CE11EA198B4D370000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A321'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000EA00000042080600000059DB4ACD000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000035D949444154785EED9D077C5545F6C743B70056B080150B9675D50515B1EEDAD85D7BEF2EA8AC75715D7551298A9DBF5DB1AEA8D84090A28802221D915E43201008E93D79495EFAEF7FBE73DF8447F6D16C6B79F3C9C9DC3B77FA9CDF3967CABD2F41529C7E04AAAA2E53456548E17058B5B5B516143B5E9C7E7CAAA9AD506D5DA5EA5465B7B1E3FCDC2966609C7E382A2B0B9BE75CCCE771FAF1C903B561F82F896206C6E987A36A27C49D8BF93C4E3F3EFD5820ADADAE312FF6B31F9A6206C6E98720105A25801AD1AA31E2C4E9D74635353F0E786306C6695B28F6BC27980F1950AB6BF5630D5E9CFEF7545D5D6DDE7F8733E63FE4B8C70C8CD3F727805A274CAE6A55D7C4356A9CBE1FC50C8CD3F7A70D402D37A0969A1F3B5E9C7E99545B53A59AEA4AB398366854AED1A2F89BD2B4DF956206C6E9FB93076A4D5D91F9210B8A1D2F4EBF3C02A45595615584CB545454A48A8A0A0BDEF0BCAAAA4A6565658E98FA5455D5D413F7D171B7966206C6E987A3DABA72410DC3E3F4CBA11A0366FD759501ADCEFEAA4C7B5684555DB7615A132A2EA9BF2E364096D94551B84835AA507138D79255AB3C1C685A974F24EED650CCC038FD7054A7B00D507C8EFA6BA0AA0A9BCA1848D1A8F65F75B5D5761B80B8AABA5CA150B14265250AD7941B48C3CA2ECB556955B9C2B521F30BEAE3BAF8A6756BB761ED2266609C7E38C2FC0DE6AAB19FC7E9E7497ED5369A6A0D9800B4AAB2CC405AA9D250A12A2B4C0C97D799F92BD3AE52B90D75A8A246A5B5350AD554AAA2CED29A26CD2DCE547E51B6AA6AA2E7AE1B80BB258A1918A71F8EE240FDE513662A20AD66F1C869C16A1515E719784D2BD655AAA434642112E62E931C66ACA1CA4AD3A4D5AA34F0B24953516B1AB7BC5085C5057617E45B5B6B8077FCC17AC6E6411B33304E718AD3060AE693B50A5784545905B8A4CCAC1CE7B3B8FBCE7B9F6ACCF8057A79C824FD67D85CBD3F6291DE7DFF1B7D3A66A906BF3B5ACF3CFFAA0139D8538D062A90F653230FD80DCF36A69881718AD36F9D3075DD368BA9C4EACA1A371F05AC36339559B60E76E999A5EAFFC8B34A68D656071CF367B53EF04C356E73AA129AFF41098D8FD1AE3B9F6E7E3BA35D9499BB01A07EE5B78E33C82A75B425B0FE57409CE2F45BA286F350C0C9420F5469E6ABA1483555D52A2F638BAD5635765F6AF66D7E91F4FC8BC37470C70B0D8847ABEB5F1FD63E9DEF56EB836F51CBBDFFA6D6BB5CA1D6DB5DA0468D3AE8A28BFFEEE6AF955581562D2BDD3015AA5589E50A79B0C6811AA7386D3B55A15159A1B579649DE93CC3517E619D9E1CF89E5AEF749421A8B33A1C75B32EBCF103ED76D43DDAE1A07FA8D57EB76887D697AB59E36E6ADEFC487DF34DAA50A285451B1F7C21CF5A1537006AECF58CFF0A88539C7E8D84B68C7D5FE134A90FAFA8306D5A5DAEDCDC6CF72E715975A151B14A2ACA55629A342B4F7AE3AD293AE890BF1A7A0E326DFA175D7ADD501D73FA20B53BEA69B5D8AB9F5AED7DBFDAB4BBC59E9FAA3F9E7A8DCA0D9FA150AD0A8A0AEBCBD9D6830F3103E314A75F3B6D0067B95BBDAD3245C69B4E4178B58A8B0BDD0BFF85ACEE5A484E7E89D66757EACB49ABD47AB72E869CC374D0E157A9EBE9CFEAAA1E63D4BCED1D6AFFFBA7D5E6E047D5B8F58DDAFBC01E4A68DA496FBC3652ECC8842B6A5559CDE251A513049595D1DB349BA1C8AB74B11FC6294EBF11AAACB6C9269B2B3687AC354CD4D5D538309596BA5346623EC91EE9DAB422655BD455E9D2F957F45342B32E3AEBC26775FE651FE88CF3072B61C71B74D8892FA965FB7FD9F5A56ABCFDC9DAB7C39F5411264FB9FDD3601BA6D2E6B915EE38A1B998758A453103E314A7DF0AD5D4851C80702C24B1FD52531B767BA600174D3B6FEE4A3DF3DCFB7AF3BD2FB52A47FA78D21A1D76722F9D73F5DB3AA2533FEDDDF16EED75D87D467DB5EBBEBDD476BFEE4EE33ED07F10F8575E7EA14ACB8B55555BEAF23617B32EB1C82F2EC57C18A738FDDA091397955DE6A81C62E0B3562C165554963AB09696966BD5CA542525AFD7074327AACB2957EB9ABFF7D73A9B6F269749AF8D4ED18917BEAC5DF6EFA13D3ADEA1234E7A443BEF739B766DF7771D70E84D6ABEC3EF55684AB9C2901EAE2C8F6853E6BF652A0F9704ABCCCEFA8D5D3F4F6630BBB8311FC6294EBF56DA3037F554A5F2F27207545C5555853B855467F72B96A769755A815E7B6B8276DBFB2C9D73D9039A9654A0348BF7F1CC62B53CF4563373FFA21DF7B95E27747B563BB4EDAEFD0EED6566F1C9DAB1F5EFDC4A6F59B8DCCC5EC06ADAD47D12A6DA4CE9AD7F49A336AE51E3F45B2367DA56061A8A7B7C4CDC9292529B8BB2771A6859FCB2509DA64F59AE22D37AB31656EBB21BDED2915DFFA99D0E394B1D4EBD5CC79ED7479D2F7845AF0E0FE98F97BC69E0BC40871DDB4FAD77BD524D9A1DA7A210FBAD21852BAA545A1656564EB6CA2BCADC1CB8B272EBCDDF9ABA60D129E6C338C5E9D74A8095F7474B4B4B959797E75676432561151795ABB2A2D6CD5353D6ACD7B08F3ED72517F4D44D773FAD479E9DA18BAE1EA6361D4C83EED4D5E8689D70C963BAFFF9D5BABDEF42FDF9EA8F7552B757D5E58FCFAAD5AE97B8F969D894671DA78E584832AC159B3060BE0A48C3618E2106E784A3EBB6398A1918A738FD1AC81F1EF0EF7E06DB2F756692B2B25BEBCCD18A70ADD2D300AC546EF1A67E33534515D56AB2437B2534DA4F7B1EF32FDDFEC8643DF2EA32DDF5F8289D70EEFD6A79F0B9EA74EED33AF6FC97B553C7FBD578AF5B74CA056FAACBD94F688FFDCED3D0113315E62892CA9D5008E6C2C1AB6D98D95C6F2BC50C8C539C7EC9E4B515DB20DCA325FD33CC5D1677304B33B3D39C965B979A21C3A6162D5FE9DE7C49CD2DD5A0B73ED5A967F6549BA32E53970B7A9B89BB40E9F630A54CFA666D8D2EBD739012763E4B09BBDDA2D61DEED5F167BFA08496E728A1E9112AB7BC30AE3969545252F29DC1194D3103E314A75F1B6172321FADA832BFB6CABD6E869F98BC5C1535B5FAF2AB99CAC8ABD0BBC3C6A9C0705560D3C8E973CAF4B7BBC76AD7FD6FD1B1A73DA4275F5EAD2163B2F5EE27E53AE9CF2FEB77270ED283FF97AB475ECA56B7CBDED46EFB9DAFBFFF6320A70E0333B7AAD4CD87D1AA080B4E3A85422177FFDF8B5A9BA79881718AD32F8960FA4D313E5B21F86857A7698DCAC2A5CACACB55A599C095AAD63B4387ABD4B46042E3BDD4B4F561BAA9D773FA64DC5ACD5D2ECD5C2D0D7C67B1F6EF74B3125A9CA4845D4F364DFA27ED75E48DBAEFC939EA79D7429D73F11025343BCDD21EA312B3B633720B4C5B6758B14E93D79BBE10D780360ED438FDE668734C0F380129DF2DAAAC6111A7DA01140895866B3466E2570A59F2C6DB1DAE9DDAFED11071841AB7EAAA36075CAC7D0FBB5E5D2F7E51A75CFA9ACEEBF199FED0ED25ED7EF83D6A79C08DFAD3A58375D780053AE4777DD574C7F3D5FEA08B74CB5D8FB95971651D2BBD45EEE36798BD2C5CF9FA7C578A1918A738FD5A08F39653417C840CAAA835F3335CA1329B6F1616D72A355F3AFEB4BFE98863FFAE84EDBAE9B2EBDF568BDDCEB7EBD395B093CD39B7BB444DF7BA55DDAE9DA447DF28D663AF87F4DCFB591AFE95D4E94F8FE9E84E7769E7B66769E69C2C0752347545155F1FB43BB37F317799A762EEB235E4CDE0E83A6E0DC50C8C539C7E2914FD85C0FA30C3012BBC6CB73057CCC9CB3693B752E5D5A50A55D8BCD1C2DEFFF05395944957747F4C679D3B409DBB3EAA9163A596BBDFA4CB7A0CD55FAE7E45D7DEF1916EBEE70BF3BF50A7335F51B7AB3ED2D5778CD4E127DEA653FE7AB799BB1DD5A8D9E1CA34B04F9ABED8CD75AB229F6AE17769AA58A1B2FA449BBEDF956206C6294EBF146291C8839557C7200F54B65ECAC37C3501C0566B71E2A200A41F8D741F21DBADCDE14A68DA59A7777B4AFD1F4BD689A7BDAD8BAE19ABCB6E1C69A6ED8BBAE8A6C1BAEC9A61EA72CA6B7AE88954B5DDAFAF766E77ADF6E970AD21A7834EE87A8D264D4B74DA39B7A85485A57CC3B92A382FCCE66983BA42DB3A37F51433F07F4D0D4D03F7A6BDF934B2E152BBBFDE12C58A4BA732A05C6FEBDB0C3F247DD7C1DB5AF2F97BFFBB985EFEFDC958697DD8D6BCBAD5B02E9BA2E8E77C91DE5F43BCC8EDAFCD8835F0FD77B91565750EB0D9D9B9765BA1D973663AD377EDBAF52AABAC31CE6FAFC68DDBAB49E373B4D34E579A897B9C121A9DAB7D0EEEA54EA7DEAEC33BDDA284E6879986BD4827FDA9B73D3B4B8D9B9CA1662D4EB4B4C7683B9BD38E1FBFD4F2AE752F95E7E66439BFB020AF3ECCD79BFED9527BB74431037F4A8A3570DFA5510DF3D95C1EB1CCA56D7D91F7B742BE5F985BF930C8BDC35955E15EDFAAA90B7E08ABBEEF23070CB6F523D39B2298BE6198A70A0321DFD1E5DA9B9A95E11A252E5B1998BF56059A6086A8267E3DD3ED71366ED656DFCC4ED7715DAE52CB5627ABCD1E67ABD0B218F57996CEFCCBA34A68B297E62FAF529A61EE8A1E030C25BFD73FEF1FAC628B73CA693DB543CB03346ACCD74E3BF389968913BEACFF540B75CDC9CEAC076934F915DF86E15B4331037F2ADA687037032C88E7D18D6C68F76FAA0336373F7013FE18E1DB4ABE8CEF3A089EB6D4075B225FFEF7CD2716458F13C499551813B392BD497C6F86722C6F53A6DFB650AC8302D1F9569487DD9C93030CBCE8CDCF4C94959628CC2715AC3EB8E52BD29D493A7BCE5A55D4D599666CA1E12356A9B4A64E3367951902F65341499DAEBCF6DFEEB0C373CFCD5756698EAEFBDBC362B639F0E5511A3536C5017CE2E4D55A9352AB61C3BF54D8869C77BA01E6C205F32C262637FC1480359670F9590395CA6D8971784E03A086717D987FEEC3B7946743227EAC349B327961B81F0AC83F17F2ED8FD50FBE7F1A525544A3A239397A17AEAC7087CB392C1ECCFD58DCDC005618B5CC6997FFCEBF615834F9B18D1EE380770286DFE06FC8C7D5CF2A10E26B63562E1FC6E66D18D5556AD1E2B956DF0A2D5EBC5029AB4AAC6ED5DA6187DDD528612FA709AFBAA28FC286CCC676DFB869233DF5D47B06CC52BBEFA284ED13F4FE7BD3AC9D61B56D778201DC0AB378E75D78A3CC6A767352CEF0E615E46AE1C2F9EEEC2EE5679B262D2A2A70422C9A77A867A4DECE45DDD7B77F4B1433F08722DFB9DF87B665EEB82D8DA76E0DEB172BFD77FDB5EAADA9CBB60ED6FF82AA391B5B7F3E36387163BAC381124D1636B5E2C32BCDD604C4EE3531030C7D170DBCE86B88F6370C8BA66DE91FB42920ADA8E08B0D661057976AC498E1AA2AB3FCAD724D135AAAD5F67B68C9FC5477BE6F755289F802E8B97FBD4E4525856ADAA2A5CA6B2A347ACC2255AAD8E6AFAD5D3BBA9D7BA5CA0C74FB1D789856A7AEB1F6E65976E5D6CE1CADCF58A62953A65879566264FBA5A0A0C0F9B4CBB78D7644DAE25CD47DCCB6C4A298813F36453702A9E94DC72D91FFE56E3E40E5C3A2697383EE89380D3B6A539DB6358226BA1D3E6C6BC9978BEFF3D99A36C4225F3EFB763E0C6AD8367F4F39DB5267D24516F5227D17684F3707B42B3E85E9018B4681C9B72408A3CBE7689DBF8688EB9F7B33B2DAE6C4F8E5A5650A97950BD3D72F066276E6E566283D2D4573E7CDD217E3C799B60D2AD7A5F3596ADEA88D4EEBD25D612B66DFBD8ED7C37D072B546C0913F640073BB337BBA4D869CE4ABB43730E1BFEB1DDB7D49BAF8FB236D1B62A33B12D9101B5A830C7FDACC5FA75A9AA34D59C9591A9BA9A88C91FE988E8452F88F67CD7F18D19F87D09B5EF553F92A6E1266FF480711DCDA43003613E0E1AB5A8A8449999D94A4A5AE5C2F2F20ACCDC08F28F1E6CE6349405B3928F1F7C164458910C85CA1C7989179D8EF2FC7B82D4BDDCE6398545AC185A19D5966F65A96B13C48BBFBE5C7E5A0F3F9AD1FC33CA886E9F0FF314617CB7AAEDAFC98FF4A48B6EDB96C8971F30D286C51F5FB6F7B7254FDF6F5CA7A7A76BE5CA95EEA40D6561E20144D66F98AFAD5AB3DE4C496BAB69DFC2E222577F7E3489B45E78F876734D1E9E37B827FFDCDC5C07043FF60D89F9273E3FD6C43EA5036C799D812543D3A74D514E66AACD0D8333BDE410B67F8D1A1FAB46CDF6D581FBDDA8264DBA98E6ECA4D63B5EA584E6FB6BBFFD2F53630B4B68DC5E094D0F5142B3BD75C4EFAF57428BDD0D19FB5AFC766A91708086BD3B5B75749BE1BE8661321016E685959D5E2AF7C3516607035000CB33FF63523F3BA0D2B1D19DEB560323D22F1635AC3003C9EF4CA6A4A468D1A2459A33678E66CE9CA96FBFFD56C9C96BB464C932BB9EABA953A7BB34E9E999CACF2F744C949999A9C2C242C740BC5F483E9E09381152526CE1B94566921459BCE20858434A4B4BD3EAD5AB5DBD49C331AFFCFC5C4B53E416260A4C626666C17CC694C579CA2FC8763E0C4A3C7CEA9D9F9FEF00959D9DEDC046DED4C3D707E6E3193EF75C43393939CAC8C870BFA1491E10D7B48778B48934FE1961D1E4C3894799303AF5A15DB48532084F4D4D7561F42DD7F8BE7CD2B37D9193433D29A3C011D7846765E5D838D55A5B2A347BF66C7DFDF5D7AE5F69677AFA7A8B97ED80BA6A4DA6D6A5E5EAB9175FD5EB6F0C760A65DDFA54574F4C41CAF475A6AF1917EAC4353E63CA3520F5F5C2276D81F535546CFDBD6AE50AE5E5E42A7D7D9A32D33394B86CB9667F6373D0D5A9A64953B53E2559EBCD3CC5CD5FB45C7F3EEF72356F75BA99AD776B8FFDAED52E7BF4D0EF8F7D5EED0EBE416DDADFAAF687FC4D7FF8C393DA7BDFEBB4E32E7F51BB03AE55DBBDAE53C7236E502B4BD7E5B83BF4C90773549053A9ACB4324DF97ABAA64DFD4AF3E72ED28CC93395B8689556AE48526949A81EA48013CD0A785D98B50D5EDF94F0D95A8A19B835145D300CE6A526006D3899460331E1CEC848D3DAB56B356FDE3C37E893274F56666A86D252D35566CC506E52895CD9A4E6A7049C75E51A5F67A6CE06E954C5A7171197F447E41B1AF8C199CA603103D3CB4DEC2DA4A0900F5849492BD7B84580E2127EB3944508EB4893C0A5217E6EA042F9A16CF71379957561CBC54C727E8DCB34A9B39F8C9873F1753ADFC68869E7858E73110DEB0606868CF601344CCE357E44BBB97AFB76100E187816E953973FCFF9A60FBE2F2F4AE0B9B8FEB9CF9B7B08473CAE018477DCFBBCA31D530B08D0AECFCC0AC6A43A387EC739D6A2D2B00B6326C23A4ED36607A859D30E6ADA747F3DFDCC10AB8BF57951BEF5B96354D727B419C183F37D818BF8F5961575C7E107750F008026E36307B5EE3D4F1B1D93108579D6D741F3CC595FD4B1A76AFD6377B7DF3150AD5A1EA7534E7A56175EF8864EECFAA06EBDED6375EDFA904E38A1BF4E39E511753EEE3E9D77E14B3AF8F01BF5E773FBEBAFE7F5558B66C769EFB6E7E8C0F6E768E217ABCDBCB6CCAC8CE2E29009AE0CF7A94FBE7B4479F0436E4EA1162E58AA2FC67DE568C2F8AF9D5259BA74B1BEF8F2338D1C39529F7CF289962D5BE6048FC709EDC5DF5A8A19B825A2437D41BE637141256094C05FB46881E6CF9F6B955CA2050BE699E9B4C2C56300EAD355197359E7035472641982BE474A6D18041B786BA4B90424308C4C1D18F82A033173D760635B4E0B7887C6F2E5101FA98E033838C724C6A44579D966B2051FA0321675C7C0583071716C50C215C4AF7607AD691704480B0AF2EA81407F704DDDD0A630BF27CFA0DEACF3697C3F121EDD27D1BECF03E71919229D07A3BFA75CC6C0039CE7A4219C7AE1100AC4F5F109A77CD2F08C8F7AA145A9222F59D30BC565A52AABB2B83627E3BECC0425201DFAF178B569DB593BB53E4A8D1AED63B4972C8969724691E10BC0E8EB4F99D407A26E5803D41F4DEFC3A80FE4DB5D6E7D8E59192A32E160D971B0809F3B242C22276DCCB3DC8210755BBB3E4F0FF479491D0FBF405D4FBA557FBB61B88E39F61EBBEFA9ABAE794D471CF90F03EB005D71E59B3AA7DB936AD4FC28B53BF0543D38E0658D1C3B452B5666BBEF250DFD70AC5B6CA2216B53D29C7259B67C91162E9AA3CFC68ED494A913DDCAF2DAB5A9CACA34CB213FA4ECAC021777CE9C791A3D7AA43EFCF0FD7A6B26D2FFF518A22FA2EFB7443103B786FC60FBCEA7C301536161BE556CB5D33C797939C600C1D2B5072FA6DDE2C58BDD20D0C168CADC6C9BEF58E704836B80AF448CD9E09414A8D22458564EBA85572BC34C5196DC21EEF9383209CA4206721B3436D88BF9F45B24A392A262673251EEBAB59844B54A5993EC7C56095980A846039AA82E2ECAB3B9564819D9A95ABA7C896B5756860D9A3B6A6D5AA438D70135D0A61410681EE2310884051A3D60481F86C3E7DE4B540F44EFBC9643F3D02F30303EF10013F9FAFC616608E77DFA9FF898BA389F16F311471E5ED393872F8F38A4C59186320027A66EE4A0834206D2F44C33A739D85E6BEDB5606B9E4E38FE6C356DBCA79A34EAA83DF7E8A2D6AD3BEA6163769A8605C32A7146968D9BE54939106560A253EF68CB63DDBA75F57D451FF19C3ABB7E348B069E013CAC572050AB6B4A8DC2CE3A4BCB5CEBCEF2223CB2F36AF58FBB9F538BED8FD6F63B76D5D97FEE679AB4AFDAEE79A981F5361D7FFCDDDAA7FD0DFAE3E98FEBC0FDBBAB73A75E7AF5CDB16E844D7C68F5FA655AB07896FEF3D66BFA6AE2175ABA6481A64E99E980072FC30B1595C5360DCA506E5E9AD6A42419802D8E4DC9D0A49F7DFA8599E2F34C412DD1A449936CBA30CBB5C983943E4028D2E7B48DB0ADA598810D2956A674A697DC383A1AC660EE82E9C9620C808098D3051F340E069FB4300C0DC83190623EE090AC9894EB5257DB9D01B514909916A930D3B0A6C201977B246A4971BEBB666023F573731BD2539E1710E565C52E3D69AB4D2BD4980947BA602E53AD129B8B561933844A6D0E55946929C2661A1B68CB4B94BC22D1E218D3844B1C63D026E677D41D66C6D16E00021302009EE1D6AF5FEFEA437CE2A0553D73D26ED2780DEBD3D02F847BC0F18CB4302D83DC90C1A3F3F3DAC95B0B38AFC91927FAC931BCC5F1F571E51910F30B4D80549A26ABAA546151893163B5FB2817D383E05397EC97A2256BD5FF214EEA6CAF268D77D7F62DF6D161879E6FF7FB6ABBEDF7B53EB0BA585A4E2AE11CB0224284BEF0D7D49D3AD326CF435C13EE9F5147EA87E5C29C19C7754D2D6DA6BFAA02816FE3C5E8A76755EA81BEEF6897DDCED0011DAE51E713FFA5934EEBA3C38FBC45A79E7EBFCE38B3AF0E3EB887CE38FD319DD0F97E9D795A7F356F72A212979739EB60F03B6F69E1E219D60785C18109CBB4B4B04CAB56AD76809B3E63B2264CFC4C63C70DD7C8D11F68C87B6F1AA00769ECD8B19A366D9A8D77BA8A0A4D8044B43C63CB948F3647C6D759A291F66E84A5ADA198819B220AF20C43877BB760C1027DF1C5176E0168EAD4C91A376EACB3D13D50D142CC19B9C6FC84A9703406B301F3D5B840B366CD76E1CC6FBD060EE55B5C93EE8598B64879FB2B3766C2CFCF44E39114538CCF31065A16A6C27CE5F38C0037F879027B66DA9E840CB8AF4FA29933B5756632DA00AD4B4BB2B4E5A63DB3ED59954A0A0246A7DD912D214B1B48FE52D3E2A6345C3FF8BE80C97080C0876135E0002E0E06F4F1D008DE79D0D1B738CA246E743FFB6BAF6D784E3C1C663E2E60904088109F7800D43B84802F1F06F2871800174065D596AD9675A969EE5C2CDA7459E2624D9A3C41C96B923465DA544D98304D69EB431A3D72BA962C2ED5DB6F8F37932FDF695BF651E9574C680687327C9BBC0B0018D401C7B5174EDE0AA01D81AB758B8BB8D16346D8B8166BF90AEEABB47A758AE1C9A616F9957A62E070FDEEA81BD5AAF585FAF3792FEB84531F55DB7DAFD74EBB99097CDAFDEA7CFC3FD566F7CB74F491F7AAC3FE3DD5E9E8DBD4BC6967CD9892E1ACB1FCBC62E5E5676ACDEA554A5E99A2A5F3576AFE37CB5DD9AB5625297975A2962E9BA7F48C3526C48A224A24384689B64D4BCB30E19FE9162E59E4A4DD9999E9AEDE91F1D8084BE02832761B856F8A6206C622CF18D18E0AB02874DE79E7A969D3A6DA7EFBEDB5EBAE3BAB71E3043DFDF44063D86C27558265FAC0FCF50C898447FA2F5E92E896F5317F6FFDFB1D9A3E7596DE19FC9E9E7CEA199B0F2CD3E5975CEB16112EBEE04A2D5EB042EF0EFE48F7DEFDA0B08EBB9D75BE0A8ACBD5EB5FF7A9779FFECACE2FD21FCFEAE636E1CFBFF8127DF9D5240D1DF689AEBCEA3AC744975D7EB5FB3ECECD3D6FD3C8519FE9A3A123D4E3A61BADBB317CAA95599049D79B86C9738CB370FE222D5F9AA2179E7B431F0F1BA3919F7CAE6BAFE9EEE621FFBCEB5E4DFA6AAA5E7BED35BDFEFAEBFAE8A38FF4D8638FB90DF0DB6FBFDDA567B00863257BC080014A4A4AD2238F3CA2810307EAABAFBED29D77DEE9FCDEBD7BEBDD77DFD54B2FBDA4575F7DD52D3CDC7AEBAD26F4A6BAF8E4FFC1071FE8A1871E72F9F7ECD9D3E640A35D9AFFFCE73FFAFCF3CF5D7CCA79F0C1073571E244F76CF87093FE2347EAF9E79F77FD0E91D78409139C00C18259B162855BFDE61E219A6A005D6700F526308E31CCCDCBD4CA55CB2CBF111A3F7EA26EEC7E87860FFBC2FA275BC33FFE529959F9FAF7FDF7E9D3CF3ED1EB6F0CD215575CA1797317A9478F1E7AE79D77F4C4134FE88E3BEED0679F7DE6F884F16FD7AE9D81FC6DDD7FFFFDDA679F7D9CE04A3096641BE884134ED02DB7DCA2E79EFF3F9D79E699AE9FDAEFB3A7C64F1CADFBFEDD2B105AF6C77AE05DFF7C464D9A76D29FCE785CC77579423BEC748312B6BF44071D758F8E3EE13EEDB9CFB5DABFC3CDA651FFA1430FBA5B871FD24BBBECDC4DE79DDB5BBF3FE22C7D3561B6131669E9294A5DB75AF3E72E70426655D29A7A2B0D8B8A4FAB00CEDCBC0CCDFA669AF1EE7C67FDB168E9B56634216C0023BC0030098B08A88DE26D0DC50C8C2632F6E4253C005BB3668D9336D3A74F37EDB9D4DDD3998306BDA45EBDEED4DCB9DFD66B32A48EEB55236F12A21598AF14864C13068FF4C9D0510A1757EB83219F98765EEC1468CF3BFA88C3251F0C9FA8E9DFAED4E871B3347771AAF24CA90E7E7FACC67D354F3936E5E21AFFCD7747A9C48A1B3E66B232F2AAF4C2A0C10641130C25D5BAF4CAEE2A37E9F9E6DB43357761923B7E76C5353DDD81ECE4F5B99A9FB84679A16A1767E68C254E402C98BB4E5F8D5FA0EC8CB0099011CAC90A16B95E7FED2D67EE0026C0C38201AB7B9836AFBCF28A951868CF3163C638A61C3468900302E099316386EBC3F7DF7FDFC50368F40B5B205825689C975F7ED999D2E3C68D73DB54809CFC1974F2A7EFE6CF9FEFCA466302061CF159C000100092B912A0268C7E9F356B968BEF3531E38985E3B77158DD445325262669C890F76D4CBFB6368CD2A4AFBFD494A9E335E6D311362F9B637915EACB2F2669EEBC451A35FA53CD9A3DD39E7DA2A4954B4DFBAC70ED604C3FFEF86357467272B223F8C82FEAD14EEAE1CD5F6F09E07C1C6F7243ACC487CA4D739BA504BFA7A795AB53E78BD57EDFB375C619FDD5E9B8013AF0D00774C8510FE9E8939E50AB76DDD5669F9BD4AEC3EDFADD1FFAE9480BEF72E2D33AFDD4A774CAA9F719F71FA236BB1EEC04F0BA7529A62DD76AC99245363E411FF1BA9AAB838D234705D1E873E6CE72A0A571D43DD64F54F8D3741E94B1342761114B63A3F04D51CCC0688A2E848C911C109DEBE715DED1D19895DE747592C8AED1AC8096792AE968388CE6B44E85E56103CA960BABDEC9CB53D5E3FA3B3565F242E5E455EBCA9B7B6BF6F26CDDD5F7793DFBE648F57FFA6D4D9EB756175DFF4F3DF6E2077AFBFDA95A9A54AEDB7A3DAD2203DC1D773FADA4944A3DF5DC30F5EEF78AEEEBF3A40A4CD83DF9EC1BEA78D4896EE1E0BA1BF99AF92EBAB5D783EAD0F114DDDDFB591D78F8C91AF8D2FB4A5A1BD2EB83C76A871D0ED283BD07E9DA2BEED55FCEEEAE93BB5CA0A37F778A162D483653DDE66E9CD236475B227D546FB6D10FDE74F3428938F8D10E2D16192C970F0E707A06C6D1C7303ACF3DE1BCEF2D1404056900037DEB999E30DFD7CC97D91203F85F7EF9A503F2A79F7EEA842DC04688BCF5D6DB26245EB1F48CB5FF82BC41C406A7BAB644A5E54C07589D0DDAC2CA2E9F38317B4965E52C52D934C1E6FCEE6D12AB22E0F78E3A3B4D18B9A68F7C9F78731EDEF26D03ECE41D2A2B71E76A59442C0AE5B95F4543417162A845F3A38D8B8FD145170FD24107DFA75DDBDEA19DF6B85D7B1F7A8FF63BFA5EED79502F1DF4BBFBB5C32EDDB5F3EE66EE36BF4EAD5A5EA1A67CCD7EA74E7AE3F561D6870802E6E315CEBAE3B03D73F5E52B96B885A1607E1D6844F7AEA9E37156AF4917847BC2EC8D5822F5619E48E335EBB652CCC04D11839F9898E89889799867063A966B988146218DD022548C67BEE37130A75FE4606032F3B3DDCA6E5E7E96FBF9F5018F0DD48081AF6AE2DCF59ABBAE46F7FDDF879A9A58A25BFBBDAE0F2726EADE811F28D93070FDBF9ED55B9FCED76997FC4333578674F5ED8F8999EF35B73EAA09B3D6E996BB9FD19DFF7E51D3BE4D76BB79092DF652A3EDF6D6B8490BF5D21B23D4F58F97E8EB992B94D064375D76DD5D7AEAF9F774D50DF7EAA65B1ED6DBEF7CA5DD773B56E7FDE5565D76E15D3AAF5B4F9BDB9CA9A38E3845F9B9969B358736B16005E3D14E9C175E5EA079C73DF11B0A35FACA3327CE3331CEE789A60360F898C45C331F45E32C5FBEDC6943D263BE520640051CAC190C1932C499C1583EACACE2A823657A2D469AE87271D48DF2D0F08526E578AF3318C25A771084CF60F2C3BBE1CA02D36EC5A6794A5C7D1160EED49EC91EB6CC10D47EACE1079C6F97F7DDBA1379BB3E0D7C56EFDD2B6B765D6ECF61ED8CA22C9556879C75C4C19F9E373DA5EED73DA70B2E7D457D1F9DAD1EB78ED27E87F552E3D657E8C0A37B6B87763DD464F76BD4A4CDB56AB67B4FEDDBF171ED7FC863DA6DCFDB8D2E52F356876BE8E889969B158042E1149195979B9DA7A58B13555A12567E4EB1F13A9F51D9B4E603B41BD3060B146A18FFBB52CCC06882F118380826614E836380A3998F8160F58B39D673CF3DE7CC3924394C84D4273D71603618877D2924F998CFC7BA71A29148FAEE3D7A6AC8C79FEB81816FE895E153F4C45B9FEB95113374CFC0211A3D2B4517DCDC57939717E8FEE73ED2071397EA9F8FBFAEE5B9753AEB8ADBB5606D892E370D5C647D3F76EA32BDF09FD1BAE78127B52EB34C1F8F3613EE8B99FA7CE2B7FAEB453768E5DA023DF67FAFEBEB6F1668F4F869BAB7CFE3CEE45D9A98A16F66AFD2B8B1DF6ACEEC359A397595E6CD5EABF1E3BED5A84F263A262C2F0BB64890B23039DA80FB6886A75FE83BFA08C1864F5F101761C53D69B847F8010C8007A0FCE638F10022A0A2FFB8C66446200246E6A43C231D26305A129F7B9E479F4262DE878F89CD734C60A62A0079FCF8F14EBBA26D0127F9323EDCB32FCD692ECA678C385689E9C7DE7261518EB179899BBBF19C9F852837ED545981E086B983C52CFA85F6E053777C88FE891C05B5FE08049A6306009393E5B6CFD6AC59EB56A6DDB1447BC40AED7537F456E3468769C7ED4F549BF637A8D5EE57A9C98E97A859CBABD47CA76BB4F741B76B977DBB6BEF8E3DB5CBFE7FD3EEFBFF5D2DDBDCA8844617A945CB0BB47DAB9334614AA28A4DE6727E78C297E36DBEFDB181D42C222B7B4DF23A1515B8C52D87014CD96005DB8DEF7F61E4A7A09881D144C7D2A1742C8CE225370C02D3C068009178F8C4F34C483A06CA0D8039C291A47EA07048487E960EC7C2C7F419B3F5E690A11A327282467E3D5F13E6A768FCBC351AFB4D92D69B95F4ECBB9F6AF292343DFCF2077AFAEDD1FA74E63C6315A9F7532F68E06BEF6AC0F3AF2BDF8ABBED9E7E1A32629C868DF8DC0D3087AC39D4C2359FE128B4392BD7945F4A5D39AF69D79CA92E8FBC7181866057C9F8D3095E7EEB92701897F67B70D2462FB0F069237DC56AF837DF7CE300C41CD39BA50081BE82790128E0C40CF4662C4C0F0134FA15A0A341C90361487A40C4FC18AD8CE003DC800F6D4B19E4477A166848BB64C9120756D612D8D6200E69012E634AFA850B173A10FBA38DB40F339613387E95DC6F7BE1682BDA15B3D8F5834571DAB75E5E05BCE005168E6BEF7C9F11469F39F3B2CEB492595898D799992916C9AE4A2B82A379167A438F7B95D0B8A3F6ED609A72BBF3D574C7ABCD5ABA543BB7BD41BF3FEE41EDDEFE5AB5DEED62E3ECD3B45DAB73B5DB7E176A8F032E5342D3AE6AD4A2AB8EE974BDEEEFFB86F28A6A946EDA7355D2CAE0708D8D7F59A8D4EDC357C32C5698F30D038074735AF5A7A09881B1884E05980C2A4C8076F09DCF20C1583CC7279C307CD2111786E319034238C43563959D53E8063725659D9BAFC21285366765B8305BD30B8CA9C3C181B4DC5203815D9459D13921039885B1D317320E29339389B474AF3FE6C67C835A9699BA24EFE4D5EB545AC63684F4FC0B83EAF709D33282791D75204198970E49C835F351F35940A1C93096174A0096F6F97D494005200113DA0AE18309CAA2929F07BEF0C20B6E2109EB83555816878883CF33567259456641E9BDF7DE732BA3DC0F1D3AD45D932756CBA38F3EAA61C386B9051BB423E09D3B77AEF3D192A3468D72E5B278C55C943D3F9E51079EB362BF6AD52AA775697BB4F363178C4085F1317ED05E5684D99AA24F584C619FD90B632C0EE669DCB388481EA4C1E1D36F0877C61E17F8209B79B08DB8DB522B3741976916C05A0B662B8EF3B3D28D373D6253953F18D79EACB6A62577D8E326B5D8F962EDB8EB556AB9EB35F6ECAFDA6BEF6B75C49137E9908E57A8ED9EA70687ED9B74303A407BB63F5EB7DED15F1959FCB4221B3BC1396FEAE57998FA056DA48101EFD3968880D9080FD1F73F36C50C6C48D19502A410A615DA00707A2989CF20401E983806C35F13074D82948749480A48210E87D349ECE75162A6497C0E3678CA485F675A2D547F0FA4AB2B425A9B9C648238ACC2DC2C27D2D34C6BB0D79ABC3C30D33D53A0413C035236D7CC41782BC7ADD4C178C668AB571983D875B9FBB5E9607B89F956B02FE64DB680F9D048B417B3D269206B27A045A342F491D7626835C00160001B5B2E23468C706627A046F30266A600ACDE0230566D996F022CD2B182CB353E20251E828172680FE5531FC605E7DB4E5DFC6A2FE3E7C72C32B6CE11C6B8F1DC5B48A1B21C159798F95BCA9A4360AA22B8786B05500246B627280FD330D8430C0E68440B6BAEE97F1CFD8470238CFE444BD3CF65E5C5EE600B075A72B2D3CD84A60E4626647B3F38D034E2A1DA61F7B375C051FF5242ABEE6ABD6F1FD39AE7AB73D7FB7474E7DB0D8CC71A4777343A40DB6F77B80E3DE41CF5BA6B80C64F986773692BC98A730B97F048FA5A13D6C14216F5A05F682FE4016BAE1E033C0F844F300F8D7EF65350CCC068A2C3A9786460DD3D156520BDD90503025CC0E7A5130387B4824931ED78CEE0100ED39007D7E172339FACF3D873C3C1C8FE54534666AAC2215652AD436B42CA484D526D6591BB5EBA7096F3AB42F9AA3626AA2C2E5028375BD5ECD9DA68D49946CC4AB1F4561FB40C0E01011332F7F382A3DABCACF43C9595542A352543B959852610729D09976C80857920B4060B29304E8ECD9F002FF5A4FD0C226D0320E41BCDFCDE79E0F8FEA3CF001CE62BDA907DCF37DE78438F3FFEB8031FDA16CD0AB1F502A8070F1EECEE894B1CE6A36859F200F898C5801D40230088831000F0D413C21C663CD0A28C21630579AD41DDB8C777540750AC6FAD8F01132B9AFCF25961810983A2601593B6D1AF3E0FC69D30FA8372B887F1B9266FFA0ADEA1AF003AA7D9D815E01E4B669D8D5B8509030465B8A64C4F3EF392CD2FDBABC58E27AAD56E176AC7DD2FD7766D2FD79E1D6F360E6EAF8466079BBFBF01F5103D3CE05DCD9AB14A05F93680085EF39833738D3046A0F24654F083C226B0C2365E36DFE18D175E9D634113DEE38829EFC12278CC392C20889C408FDCFF941433309AE8FCE8FB864C48C733A7F1F326CF0C8479C9EC410D21D561143411F1D860E760336625C7B518543E0E95B97EAD3B2C9F9B936E8059AEFCBC4CAD4D596920B270034C968138273B4D69EB92555156A4FCEC0C8B9FABD47529CACECC72AB773959B96EFECB4FDE659BB6CECACE75D72CBD27AFB6F9DBBAF54A5B9FE54E9364A4E7B8D346680C9871D1E2A5064CAC8742AB6F8A99FCAB0CE0D6A6126B47012797D8DFAB72733A1C0C8AF600B430286D8739F121841371BCA39F3EFCF0433DF9E4930E7C98A310DA94746865FA8ABC3CC1FCE481F0615C288BFEC7C1FC38EAC035421381445EBE6E3EAE7784799F3CBDB081FCB8A17538B1B33E2DC5CD6BB17A38F699935D686382C91FBC1EE757F31162F41773637716D70434E9A80F630E5FA0FD894BBF64D91872E493F49CECC94A2F50418ECDD1AD39F9D955BAEBAE3EC6A5BB3A40EEB8E3316ADAE408036DA0350F39A29B063CFEA2162C59E32CB0C8D492E9A6D3EE4EC3BB6D24133C2C3E5838C073FD11193F0443F00DDE4A075ABE6ECFD8325746BBFFAFE7A69E6206C6A20840DD35928FC1F4CCE19FC114302440F4D21D930E89CFA20A8B15013853DDC2088B1B00009F95CF8C8C2CB7AABC36D9C2962DD6CAC50BB47485C55B93A2390B162A79ED3AE72F495CA1A4D5664E2E4F74C7DA162C9AAB55AB576AD1B2A591B88B95B86A8D96AC48D68AA4D506BAE54A599BE6FC254B57B8134FAB92D76AE9B224B78842D9D48BEB94756BB43A2559D3664C5562D27267222380D8E447F2B3B0E24C349BB32191798E63F0018207037DE281E0014AFF382D6584A5419FB057C8A2138047C3A209D1B01C2281D15913A07EF49D7B83C3EA08612500763433E417AAD05A80C097190D46C0ED8527D75E03360430CED79FF602A6C4C4A05C8469D28AD55ABE6C95962E49D292C589367EC9AEBE1C1BE50DA9E4E495AEEE8C33E0A4FEB497B6F81565C258FC9ABFE05BABFF22EB83455ABC2849AB9332B526295F898BB374CDE577AA71C2CE6AD6684F75BFBA8F1EEFF781FEF3E258A5AE748B8F09AA657D81AF31B08FCB629399D19566423367AE35A15359A03AE6BDECBBF276BB7505C755F90E14AF30B22FDBF04B8961AC39DE12771458913F078A19B82DE4A57BC3704F30020CC400C180CCC1985FB13882398756613104738D850F7CC00DA15D664E9FE168D68C998EB89E3E759AA64D99AAA993A73881B039620B08C2FC0314100C024820FFF6C3A449932DFE0C772A85FBD9B3E718785638A642D0700A08AD00037B2687911132303A02CA3327968337F930B5024D93E33422C20D4107630334EA02512FCA808129932900F35300E94F7E513EFD49B96853C803D1BBE8FA41C48FBEA66CC8879347B4F3A0F565506FDAC8B68DAF132637FD49BD1BF62DD7F417F118434C6FE273EFFBDEE7032F8C1831D2F861A4467CF291860E7B57EF0E094CFDD1A3BED0C4F1B39C0045C0512FEA6B2E269F317FC68CC6AF71CBF41B3FF702D293EFBF86F17EAE1433705BC89B56D16174C4E6EEE92098164606C42CB430B8AC52025AE6609C0DEDDBB7AF063CF4B0A3471E1EE088EB87FB3FA487FAF557FFBEFDDCF9D7CD117940FDFAF573D4BFBFA533F2CF1F7DF471BB7F587DFAF4B378FDF5E0837DD5BBF7038E08E31CEABFFFFD6F3DF3CC336EE514702174BC9680E96026DA01500125A085BC79EFF734D1BE1E746848BF65435CFA83380002E646A8714D182630E0270EFD8D4F1A2F08301B7DF9E48D458389495DF0498FE000E8BE6ECCD7C993B4948156462820BC28FFADB7DE72E7937BF5EAE5DADFB0EFF0A3FBD513617DFAF4D1030F3CE0FA8EB89C6D865E7CF1C5FA73D1009ABEE0B822E6724928DF349DCD99CD5271C2C2E40FBB3511DE716158719E971036D1C0059C80745340FDA553CCC0EF437464B4F46EF87C73140DE8CD49CF9F9A1A0A1A981CF00144CC7B840C262540C4BC032C00104D84298F0F0120000580000660250D00024C0005F397C3225816F8DE324003F985220406DA88D560E2F85561886BE2F01C42F831F7C57261AB876D21CC6BD2210C008C9F920060AF5169B35F5B88D63CDBAA8562F140A43F9D8B2CCE38139BAD9E60CF36383451901F2C407980468F4343E5F06BA79881DB4A80AAA184F3E198C66801880EF7F1F07946E76F6EF0FD0011C7930F83C86B73C4806E8E38EAC682018B0CF8B156F57C99FE9A765077AEFDDC1210A201D148987C5C63E645FB8013EB011310B3FFCD37DF74BE079D37FB898FE686BCE9EECDF868F3129392F933CF0867AA80D90CF0D056D40D8102007DFD1B12E31079E6CC5DAEE917B436020401443F129770DF6EC21853E2FB7B9EE3734FFC68C2E487A2A64AF5422170B56E71C72DE498632780DF8EF18E3CC9DFDC46F9FE562866E04F490C00CCE207D93314BEBFFE3991AFAF67364C4BB41526309A0EF00038C0C3355A0B10F2CCEF7D3217477B62BAFA3926BEBF86813DC37B20E0FBE7381F8730AE89C37D741F362440429980AF21D3939E307CF2238F481B37CA635B294A10D487510EE1083CCAE01E7395BDEAE06D2BDACE1E6CB0E7EADBEFEB443AB43DC0E799271F279AA2CBFD2553CCC06DA1E8C1A4B37C27E237640688F85E2AC7EA48D27886E1394BE750F08D9C0DE4C31BA66F48D183168B88439D7C999E112098294A036C9427710109733C4E14718A88774779A7F4E9A79F76278C989311CE7C8F7D4E408B064463626A7A8D4219301D75204F9F3F654513E1D409F2FD431AEAE7EFF109234FDAD0308F2D1179356C2F44BE847B805106E194B939F2E921D2532FF2880EF7447CF24690A0D1B9A75FA2EB43B9C48955C75F33C50CDC16DA1443F9EB5883126B0063E5B335445E9BA386F1B795369507ED8A30AB3301011D20A31DCC373D08715E43798DE8E3E208278DAFAF07832FD73FE3FA87A61F2BDF6D21FA30368F6C1988BF25B0C60CDC5662C0BF0B43C502E7CF81796211758DAEAFBFF6DA2B1AB89167EEDE03121FC6A27D3E8C346807E213E6FBD1DC466513EEFB25BA7FA2AF3745B1F2DB1CF9B21AE61D2BECC72480CAC212F5DF541B7ECAFAFCAF2966609C36D0A6982402CA8DC2FC3B8DFE148C23BC08304983368D6882FA70AF7D29CB33DFE698706B34C9A680B5ADC085BC806918BEB93A36A46D89FB7D8945A960612AF6F35F22C50C8C536CDA1240DC9CD9B0E700CB3936FBF3662F2E0292FAFB8640F52E169848E3CBF74CBF39D011877C89131D2FFADAE7B32D84B0D99A74C4F9BE656D0D0148B7A513758A88EB5F175095F0FFA463C3FC4F4F48EB0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A330-200'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000EA00000042080600000059DB4ACD000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000035D949444154785EED9D077C5545F6C743B70056B080150B9675D50515B1EEDAD85D7BEF2EA8AC75715D7551298A9DBF5DB1AEA8D84090A28802221D915E43201008E93D79495EFAEF7FBE73DF8447F6D16C6B79F3C9C9DC3B77FA9CDF3967CABD2F41529C7E04AAAA2E53456548E17058B5B5B516143B5E9C7E7CAAA9AD506D5DA5EA5465B7B1E3FCDC2966609C7E382A2B0B9BE75CCCE771FAF1C903B561F82F896206C6E987A36A27C49D8BF93C4E3F3EFD5820ADADAE312FF6B31F9A6206C6E98720105A25801AD1AA31E2C4E9D74635353F0E786306C6695B28F6BC27980F1950AB6BF5630D5E9CFEF7545D5D6DDE7F8733E63FE4B8C70C8CD3F727805A274CAE6A55D7C4356A9CBE1FC50C8CD3F7A70D402D37A0969A1F3B5E9C7E99545B53A59AEA4AB398366854AED1A2F89BD2B4DF956206C6E9FB93076A4D5D91F9210B8A1D2F4EBF3C02A45595615584CB545454A48A8A0A0BDEF0BCAAAA4A6565658E98FA5455D5D413F7D171B7966206C6E987A3DABA72410DC3E3F4CBA11A0366FD759501ADCEFEAA4C7B5684555DB7615A132A2EA9BF2E364096D94551B84835AA507138D79255AB3C1C685A974F24EED650CCC038FD7054A7B00D507C8EFA6BA0AA0A9BCA1848D1A8F65F75B5D5761B80B8AABA5CA150B14265250AD7941B48C3CA2ECB556955B9C2B521F30BEAE3BAF8A6756BB761ED2266609C7E38C2FC0DE6AAB19FC7E9E7497ED5369A6A0D9800B4AAB2CC405AA9D250A12A2B4C0C97D799F92BD3AE52B90D75A8A246A5B5350AD554AAA2CED29A26CD2DCE547E51B6AA6AA2E7AE1B80BB258A1918A71F8EE240FDE513662A20AD66F1C869C16A1515E719784D2BD655AAA434642112E62E931C66ACA1CA4AD3A4D5AA34F0B24953516B1AB7BC5085C5057617E45B5B6B8077FCC17AC6E6411B33304E718AD3060AE693B50A5784545905B8A4CCAC1CE7B3B8FBCE7B9F6ACCF8057A79C824FD67D85CBD3F6291DE7DFF1B7D3A66A906BF3B5ACF3CFFAA0139D8538D062A90F653230FD80DCF36A69881718AD36F9D3075DD368BA9C4EACA1A371F05AC36339559B60E76E999A5EAFFC8B34A68D656071CF367B53EF04C356E73AA129AFF41098D8FD1AE3B9F6E7E3BA35D9499BB01A07EE5B78E33C82A75B425B0FE57409CE2F45BA286F350C0C9420F5469E6ABA1483555D52A2F638BAD5635765F6AF66D7E91F4FC8BC37470C70B0D8847ABEB5F1FD63E9DEF56EB836F51CBBDFFA6D6BB5CA1D6DB5DA0468D3AE8A28BFFEEE6AF955581562D2BDD3015AA5589E50A79B0C6811AA7386D3B55A15159A1B579649DE93CC3517E619D9E1CF89E5AEF749421A8B33A1C75B32EBCF103ED76D43DDAE1A07FA8D57EB76887D697AB59E36E6ADEFC487DF34DAA50A285451B1F7C21CF5A1537006AECF58CFF0A88539C7E8D84B68C7D5FE134A90FAFA8306D5A5DAEDCDC6CF72E715975A151B14A2ACA55629A342B4F7AE3AD293AE890BF1A7A0E326DFA175D7ADD501D73FA20B53BEA69B5D8AB9F5AED7DBFDAB4BBC59E9FAA3F9E7A8DCA0D9FA150AD0A8A0AEBCBD9D6830F3103E314A75F3B6D0067B95BBDAD3245C69B4E4178B58A8B0BDD0BFF85ACEE5A484E7E89D66757EACB49ABD47AB72E869CC374D0E157A9EBE9CFEAAA1E63D4BCED1D6AFFFBA7D5E6E047D5B8F58DDAFBC01E4A68DA496FBC3652ECC8842B6A5559CDE251A513049595D1DB349BA1C8AB74B11FC6294EBF11AAACB6C9269B2B3687AC354CD4D5D538309596BA5346623EC91EE9DAB422655BD455E9D2F957F45342B32E3AEBC26775FE651FE88CF3072B61C71B74D8892FA965FB7FD9F5A56ABCFDC9DAB7C39F5411264FB9FDD3601BA6D2E6B915EE38A1B998758A453103E314A7DF0AD5D4851C80702C24B1FD52531B767BA600174D3B6FEE4A3DF3DCFB7AF3BD2FB52A47FA78D21A1D76722F9D73F5DB3AA2533FEDDDF16EED75D87D467DB5EBBEBDD476BFEE4EE33ED07F10F8575E7EA14ACB8B55555BEAF23617B32EB1C82F2EC57C18A738FDDA091397955DE6A81C62E0B3562C165554963AB09696966BD5CA542525AFD7074327AACB2957EB9ABFF7D73A9B6F269749AF8D4ED18917BEAC5DF6EFA13D3ADEA1234E7A443BEF739B766DF7771D70E84D6ABEC3EF55684AB9C2901EAE2C8F6853E6BF652A0F9704ABCCCEFA8D5D3F4F6630BBB8311FC6294EBF56DA3037F554A5F2F27207545C5555853B855467F72B96A769755A815E7B6B8276DBFB2C9D73D9039A9654A0348BF7F1CC62B53CF4563373FFA21DF7B95E27747B563BB4EDAEFD0EED6566F1C9DAB1F5EFDC4A6F59B8DCCC5EC06ADAD47D12A6DA4CE9AD7F49A336AE51E3F45B2367DA56061A8A7B7C4CDC9292529B8BB2771A6859FCB2509DA64F59AE22D37AB31656EBB21BDED2915DFFA99D0E394B1D4EBD5CC79ED7479D2F7845AF0E0FE98F97BC69E0BC40871DDB4FAD77BD524D9A1DA7A210FBAD21852BAA545A1656564EB6CA2BCADC1CB8B272EBCDDF9ABA60D129E6C338C5E9D74A8095F7474B4B4B959797E75676432561151795ABB2A2D6CD5353D6ACD7B08F3ED72517F4D44D773FAD479E9DA18BAE1EA6361D4C83EED4D5E8689D70C963BAFFF9D5BABDEF42FDF9EA8F7552B757D5E58FCFAAD5AE97B8F969D894671DA78E584832AC159B3060BE0A48C3618E2106E784A3EBB6398A1918A738FD1AC81F1EF0EF7E06DB2F756692B2B25BEBCCD18A70ADD2D300AC546EF1A67E33534515D56AB2437B2534DA4F7B1EF32FDDFEC8643DF2EA32DDF5F8289D70EEFD6A79F0B9EA74EED33AF6FC97B553C7FBD578AF5B74CA056FAACBD94F688FFDCED3D0113315E62892CA9D5008E6C2C1AB6D98D95C6F2BC50C8C539C7EC9E4B515DB20DCA325FD33CC5D1677304B33B3D39C965B979A21C3A6162D5FE9DE7C49CD2DD5A0B73ED5A967F6549BA32E53970B7A9B89BB40E9F630A54CFA666D8D2EBD739012763E4B09BBDDA2D61DEED5F167BFA08496E728A1E9112AB7BC30AE3969545252F29DC1194D3103E314A75F1B6172321FADA832BFB6CABD6E869F98BC5C1535B5FAF2AB99CAC8ABD0BBC3C6A9C0705560D3C8E973CAF4B7BBC76AD7FD6FD1B1A73DA4275F5EAD2163B2F5EE27E53AE9CF2FEB77270ED283FF97AB475ECA56B7CBDED46EFB9DAFBFFF6320A70E0333B7AAD4CD87D1AA080B4E3A85422177FFDF8B5A9BA79881718AD32F8960FA4D313E5B21F86857A7698DCAC2A5CACACB55A599C095AAD63B4387ABD4B46042E3BDD4B4F561BAA9D773FA64DC5ACD5D2ECD5C2D0D7C67B1F6EF74B3125A9CA4845D4F364DFA27ED75E48DBAEFC939EA79D7429D73F11025343BCDD21EA312B3B633720B4C5B6758B14E93D79BBE10D780360ED438FDE668734C0F380129DF2DAAAC6111A7DA01140895866B3466E2570A59F2C6DB1DAE9DDAFED11071841AB7EAAA36075CAC7D0FBB5E5D2F7E51A75CFA9ACEEBF199FED0ED25ED7EF83D6A79C08DFAD3A58375D780053AE4777DD574C7F3D5FEA08B74CB5D8FB95971651D2BBD45EEE36798BD2C5CF9FA7C578A1918A738FD5A08F39653417C840CAAA835F3335CA1329B6F1616D72A355F3AFEB4BFE98863FFAE84EDBAE9B2EBDF568BDDCEB7EBD395B093CD39B7BB444DF7BA55DDAE9DA447DF28D663AF87F4DCFB591AFE95D4E94F8FE9E84E7769E7B66769E69C2C0752347545155F1FB43BB37F317799A762EEB235E4CDE0E83A6E0DC50C8C539C7E2914FD85C0FA30C3012BBC6CB73057CCC9CB3693B752E5D5A50A55D8BCD1C2DEFFF05395944957747F4C679D3B409DBB3EAA9163A596BBDFA4CB7A0CD55FAE7E45D7DEF1916EBEE70BF3BF50A7335F51B7AB3ED2D5778CD4E127DEA653FE7AB799BB1DD5A8D9E1CA34B04F9ABED8CD75AB229F6AE17769AA58A1B2FA449BBEDF956206C6294EBF146291C8839557C7200F54B65ECAC37C3501C0566B71E2A200A41F8D741F21DBADCDE14A68DA59A7777B4AFD1F4BD689A7BDAD8BAE19ABCB6E1C69A6ED8BBAE8A6C1BAEC9A61EA72CA6B7AE88954B5DDAFAF766E77ADF6E970AD21A7834EE87A8D264D4B74DA39B7A85485A57CC3B92A382FCCE66983BA42DB3A37F51433F07F4D0D4D03F7A6BDF934B2E152BBBFDE12C58A4BA732A05C6FEBDB0C3F247DD7C1DB5AF2F97BFFBB985EFEFDC958697DD8D6BCBAD5B02E9BA2E8E77C91DE5F43BCC8EDAFCD8835F0FD77B91565750EB0D9D9B9765BA1D973663AD377EDBAF52AABAC31CE6FAFC68DDBAB49E373B4D34E579A897B9C121A9DAB7D0EEEA54EA7DEAEC33BDDA284E6879986BD4827FDA9B73D3B4B8D9B9CA1662D4EB4B4C7683B9BD38E1FBFD4F2AE752F95E7E66439BFB020AF3ECCD79BFED9527BB74431037F4A8A3570DFA5510DF3D95C1EB1CCA56D7D91F7B742BE5F985BF930C8BDC35955E15EDFAAA90B7E08ABBEEF23070CB6F523D39B2298BE6198A70A0321DFD1E5DA9B9A95E11A252E5B1998BF56059A6086A8267E3DD3ED71366ED656DFCC4ED7715DAE52CB5627ABCD1E67ABD0B218F57996CEFCCBA34A68B297E62FAF529A61EE8A1E030C25BFD73FEF1FAC628B73CA693DB543CB03346ACCD74E3BF389968913BEACFF540B75CDC9CEAC076934F915DF86E15B4331037F2ADA687037032C88E7D18D6C68F76FAA0336373F7013FE18E1DB4ABE8CEF3A089EB6D4075B225FFEF7CD2716458F13C499551813B392BD497C6F86722C6F53A6DFB650AC8302D1F9569487DD9C93030CBCE8CDCF4C94959628CC2715AC3EB8E52BD29D493A7BCE5A55D4D599666CA1E12356A9B4A64E3367951902F65341499DAEBCF6DFEEB0C373CFCD5756698EAEFBDBC362B639F0E5511A3536C5017CE2E4D55A9352AB61C3BF54D8869C77BA01E6C205F32C262637FC1480359670F9590395CA6D8971784E03A086717D987FEEC3B7946743227EAC349B327961B81F0AC83F17F2ED8FD50FBE7F1A525544A3A239397A17AEAC7087CB392C1ECCFD58DCDC005618B5CC6997FFCEBF615834F9B18D1EE380770286DFE06FC8C7D5CF2A10E26B63562E1FC6E66D18D5556AD1E2B956DF0A2D5EBC5029AB4AAC6ED5DA6187DDD528612FA709AFBAA28FC286CCC676DFB869233DF5D47B06CC52BBEFA284ED13F4FE7BD3AC9D61B56D778201DC0AB378E75D78A3CC6A767352CEF0E615E46AE1C2F9EEEC2EE5679B262D2A2A70422C9A77A867A4DECE45DDD7B77F4B1433F08722DFB9DF87B665EEB82D8DA76E0DEB172BFD77FDB5EAADA9CBB60ED6FF82AA391B5B7F3E36387163BAC381124D1636B5E2C32BCDD604C4EE3531030C7D170DBCE86B88F6370C8BA66DE91FB42920ADA8E08B0D661057976AC498E1AA2AB3FCAD724D135AAAD5F67B68C9FC5477BE6F755289F802E8B97FBD4E4525856ADAA2A5CA6B2A347ACC2255AAD8E6AFAD5D3BBA9D7BA5CA0C74FB1D789856A7AEB1F6E65976E5D6CE1CADCF58A62953A65879566264FBA5A0A0C0F9B4CBB78D7644DAE25CD47DCCB6C4A298813F36453702A9E94DC72D91FFE56E3E40E5C3A2697383EE89380D3B6A539DB6358226BA1D3E6C6BC9978BEFF3D99A36C4225F3EFB763E0C6AD8367F4F39DB5267D24516F5227D17684F3707B42B3E85E9018B4681C9B72408A3CBE7689DBF8688EB9F7B33B2DAE6C4F8E5A5650A97950BD3D72F066276E6E566283D2D4573E7CDD217E3C799B60D2AD7A5F3596ADEA88D4EEBD25D612B66DFBD8ED7C37D072B546C0913F640073BB337BBA4D869CE4ABB43730E1BFEB1DDB7D49BAF8FB236D1B62A33B12D9101B5A830C7FDACC5FA75A9AA34D59C9591A9BA9A88C91FE988E8452F88F67CD7F18D19F87D09B5EF553F92A6E1266FF480711DCDA43003613E0E1AB5A8A8449999D94A4A5AE5C2F2F20ACCDC08F28F1E6CE6349405B3928F1F7C164458910C85CA1C7989179D8EF2FC7B82D4BDDCE6398545AC185A19D5966F65A96B13C48BBFBE5C7E5A0F3F9AD1FC33CA886E9F0FF314617CB7AAEDAFC98FF4A48B6EDB96C8971F30D286C51F5FB6F7B7254FDF6F5CA7A7A76BE5CA95EEA40D6561E20144D66F98AFAD5AB3DE4C496BAB69DFC2E222577F7E3489B45E78F876734D1E9E37B827FFDCDC5C07043FF60D89F9273E3FD6C43EA5036C799D812543D3A74D514E66AACD0D8333BDE410B67F8D1A1FAB46CDF6D581FBDDA8264DBA98E6ECA4D63B5EA584E6FB6BBFFD2F53630B4B68DC5E094D0F5142B3BD75C4EFAF57428BDD0D19FB5AFC766A91708086BD3B5B75749BE1BE8661321016E685959D5E2AF7C3516607035000CB33FF63523F3BA0D2B1D19DEB560323D22F1635AC3003C9EF4CA6A4A468D1A2459A33678E66CE9CA96FBFFD56C9C96BB464C932BB9EABA953A7BB34E9E999CACF2F744C949999A9C2C242C740BC5F483E9E09381152526CE1B94566921459BCE20858434A4B4BD3EAD5AB5DBD49C331AFFCFC5C4B53E416260A4C626666C17CC694C579CA2FC8763E0C4A3C7CEA9D9F9FEF00959D9DEDC046DED4C3D707E6E3193EF75C43393939CAC8C870BFA1491E10D7B48778B48934FE1961D1E4C3894799303AF5A15DB48532084F4D4D7561F42DD7F8BE7CD2B37D9193433D29A3C011D7846765E5D838D55A5B2A347BF66C7DFDF5D7AE5F69677AFA7A8B97ED80BA6A4DA6D6A5E5EAB9175FD5EB6F0C760A65DDFA54574F4C41CAF475A6AF1917EAC4353E63CA3520F5F5C2276D81F535546CFDBD6AE50AE5E5E42A7D7D9A32D33394B86CB9667F6373D0D5A9A64953B53E2559EBCD3CC5CD5FB45C7F3EEF72356F75BA99AD776B8FFDAED52E7BF4D0EF8F7D5EED0EBE416DDADFAAF687FC4D7FF8C393DA7BDFEBB4E32E7F51BB03AE55DBBDAE53C7236E502B4BD7E5B83BF4C90773549053A9ACB4324DF97ABAA64DFD4AF3E72ED28CC93395B8689556AE48526949A81EA48013CD0A785D98B50D5EDF94F0D95A8A19B835145D300CE6A526006D3899460331E1CEC848D3DAB56B356FDE3C37E893274F56666A86D252D35566CC506E52895CD9A4E6A7049C75E51A5F67A6CE06E954C5A7171197F447E41B1AF8C199CA603103D3CB4DEC2DA4A0900F5849492BD7B84580E2127EB3944508EB4893C0A5217E6EA042F9A16CF71379957561CBC54C727E8DCB34A9B39F8C9873F1753ADFC68869E7858E73110DEB0606868CF601344CCE357E44BBB97AFB76100E187816E953973FCFF9A60FBE2F2F4AE0B9B8FEB9CF9B7B08473CAE018477DCFBBCA31D530B08D0AECFCC0AC6A43A387EC739D6A2D2B00B6326C23A4ED36607A859D30E6ADA747F3DFDCC10AB8BF57951BEF5B96354D727B419C183F37D818BF8F5961575C7E107750F008026E36307B5EE3D4F1B1D93108579D6D741F3CC595FD4B1A76AFD6377B7DF3150AD5A1EA7534E7A56175EF8864EECFAA06EBDED6375EDFA904E38A1BF4E39E511753EEE3E9D77E14B3AF8F01BF5E773FBEBAFE7F5558B66C769EFB6E7E8C0F6E768E217ABCDBCB6CCAC8CE2E29009AE0CF7A94FBE7B4479F0436E4EA1162E58AA2FC67DE568C2F8AF9D5259BA74B1BEF8F2338D1C39529F7CF289962D5BE6048FC709EDC5DF5A8A19B825A2437D41BE637141256094C05FB46881E6CF9F6B955CA2050BE699E9B4C2C56300EAD355197359E7035472641982BE474A6D18041B786BA4B90424308C4C1D18F82A033173D760635B4E0B7887C6F2E5101FA98E033838C724C6A44579D966B2051FA0321675C7C0583071716C50C215C4AF7607AD691704480B0AF2EA81407F704DDDD0A630BF27CFA0DEACF3697C3F121EDD27D1BECF03E71919229D07A3BFA75CC6C0039CE7A4219C7AE1100AC4F5F109A77CD2F08C8F7AA145A9222F59D30BC565A52AABB2B83627E3BECC0425201DFAF178B569DB593BB53E4A8D1AED63B4972C8969724691E10BC0E8EB4F99D407A26E5803D41F4DEFC3A80FE4DB5D6E7D8E59192A32E160D971B0809F3B242C22276DCCB3DC8210755BBB3E4F0FF479491D0FBF405D4FBA557FBB61B88E39F61EBBEFA9ABAE794D471CF90F03EB005D71E59B3AA7DB936AD4FC28B53BF0543D38E0658D1C3B452B5666BBEF250DFD70AC5B6CA2216B53D29C7259B67C91162E9AA3CFC68ED494A913DDCAF2DAB5A9CACA34CB213FA4ECAC021777CE9C791A3D7AA43EFCF0FD7A6B26D2FFF518A22FA2EFB7443103B786FC60FBCEA7C301536161BE556CB5D33C797939C600C1D2B5072FA6DDE2C58BDD20D0C168CADC6C9BEF58E704836B80AF448CD9E09414A8D22458564EBA85572BC34C5196DC21EEF9383209CA4206721B3436D88BF9F45B24A392A262673251EEBAB59844B54A5993EC7C56095980A846039AA82E2ECAB3B9564819D9A95ABA7C896B5756860D9A3B6A6D5AA438D70135D0A61410681EE2310884051A3D60481F86C3E7DE4B540F44EFBC9643F3D02F30303EF10013F9FAFC616608E77DFA9FF898BA389F16F311471E5ED393872F8F38A4C59186320027A66EE4A0834206D2F44C33A739D85E6BEDB5606B9E4E38FE6C356DBCA79A34EAA83DF7E8A2D6AD3BEA6163769A8605C32A7146968D9BE54939106560A253EF68CB63DDBA75F57D451FF19C3ABB7E348B069E013CAC572050AB6B4A8DC2CE3A4BCB5CEBCEF2223CB2F36AF58FBB9F538BED8FD6F63B76D5D97FEE679AB4AFDAEE79A981F5361D7FFCDDDAA7FD0DFAE3E98FEBC0FDBBAB73A75E7AF5CDB16E844D7C68F5FA655AB07896FEF3D66BFA6AE2175ABA6481A64E99E980072FC30B1595C5360DCA506E5E9AD6A42419802D8E4DC9D0A49F7DFA8599E2F34C412DD1A449936CBA30CBB5C983943E4028D2E7B48DB0ADA598810D2956A674A697DC383A1AC660EE82E9C9620C808098D3051F340E069FB4300C0DC83190623EE090AC9894EB5257DB9D01B514909916A930D3B0A6C201977B246A4971BEBB666023F573731BD2539E1710E565C52E3D69AB4D2BD4980947BA602E53AD129B8B561933844A6D0E55946929C2661A1B68CB4B94BC22D1E218D3844B1C63D026E677D41D66C6D16E00021302009EE1D6AF5FEFEA437CE2A0553D73D26ED2780DEBD3D02F847BC0F18CB4302D83DC90C1A3F3F3DAC95B0B38AFC91927FAC931BCC5F1F571E51910F30B4D80549A26ABAA546151893163B5FB2817D383E05397EC97A2256BD5FF214EEA6CAF268D77D7F62DF6D161879E6FF7FB6ABBEDF7B53EB0BA585A4E2AE11CB0224284BEF0D7D49D3AD326CF435C13EE9F5147EA87E5C29C19C7754D2D6DA6BFAA02816FE3C5E8A76755EA81BEEF6897DDCED0011DAE51E713FFA5934EEBA3C38FBC45A79E7EBFCE38B3AF0E3EB887CE38FD319DD0F97E9D795A7F356F72A212979739EB60F03B6F69E1E219D60785C18109CBB4B4B04CAB56AD76809B3E63B2264CFC4C63C70DD7C8D11F68C87B6F1AA00769ECD8B19A366D9A8D77BA8A0A4D8044B43C63CB948F3647C6D759A291F66E84A5ADA198819B220AF20C43877BB760C1027DF1C5176E0168EAD4C91A376EACB3D13D50D142CC19B9C6FC84A9703406B301F3D5B840B366CD76E1CC6FBD060EE55B5C93EE8598B64879FB2B3766C2CFCF44E39114538CCF31065A16A6C27CE5F38C0037F879027B66DA9E840CB8AF4FA29933B5756632DA00AD4B4BB2B4E5A63DB3ED59954A0A0246A7DD912D214B1B48FE52D3E2A6345C3FF8BE80C97080C0876135E0002E0E06F4F1D008DE79D0D1B738CA246E743FFB6BAF6D784E3C1C663E2E60904088109F7800D43B84802F1F06F2871800174065D596AD9675A969EE5C2CDA7459E2624D9A3C41C96B923465DA544D98304D69EB431A3D72BA962C2ED5DB6F8F37932FDF695BF651E9574C680687327C9BBC0B0018D401C7B5174EDE0AA01D81AB758B8BB8D16346D8B8166BF90AEEABB47A758AE1C9A616F9957A62E070FDEEA81BD5AAF585FAF3792FEB84531F55DB7DAFD74EBB99097CDAFDEA7CFC3FD566F7CB74F491F7AAC3FE3DD5E9E8DBD4BC6967CD9892E1ACB1FCBC62E5E5676ACDEA554A5E99A2A5F3576AFE37CB5DD9AB5625297975A2962E9BA7F48C3526C48A224A24384689B64D4BCB30E19FE9162E59E4A4DD9999E9AEDE91F1D8084BE02832761B856F8A6206C622CF18D18E0AB02874DE79E7A969D3A6DA7EFBEDB5EBAE3BAB71E3043DFDF44063D86C27558265FAC0FCF50C898447FA2F5E92E896F5317F6FFDFB1D9A3E7596DE19FC9E9E7CEA199B0F2CD3E5975CEB16112EBEE04A2D5EB042EF0EFE48F7DEFDA0B08EBB9D75BE0A8ACBD5EB5FF7A9779FFECACE2FD21FCFEAE636E1CFBFF8127DF9D5240D1DF689AEBCEA3AC744975D7EB5FB3ECECD3D6FD3C8519FE9A3A123D4E3A61BADBB317CAA95599049D79B86C9738CB370FE222D5F9AA2179E7B431F0F1BA3919F7CAE6BAFE9EEE621FFBCEB5E4DFA6AAA5E7BED35BDFEFAEBFAE8A38FF4D8638FB90DF0DB6FBFDDA567B00863257BC080014A4A4AD2238F3CA2810307EAABAFBED29D77DEE9FCDEBD7BEBDD77DFD54B2FBDA4575F7DD52D3CDC7AEBAD26F4A6BAF8E4FFC1071FE8A1871E72F9F7ECD9D3E640A35D9AFFFCE73FFAFCF3CF5D7CCA79F0C1073571E244F76CF87093FE2347EAF9E79F77FD0E91D78409139C00C18259B162855BFDE61E219A6A005D6700F526308E31CCCDCBD4CA55CB2CBF111A3F7EA26EEC7E87860FFBC2FA275BC33FFE529959F9FAF7FDF7E9D3CF3ED1EB6F0CD215575CA1797317A9478F1E7AE79D77F4C4134FE88E3BEED0679F7DE6F884F16FD7AE9D81FC6DDD7FFFFDDA679F7D9CE04A3096641BE884134ED02DB7DCA2E79EFF3F9D79E699AE9FDAEFB3A7C64F1CADFBFEDD2B105AF6C77AE05DFF7C464D9A76D29FCE785CC77579423BEC748312B6BF44071D758F8E3EE13EEDB9CFB5DABFC3CDA651FFA1430FBA5B871FD24BBBECDC4DE79DDB5BBF3FE22C7D3561B6131669E9294A5DB75AF3E72E70426655D29A7A2B0D8B8A4FAB00CEDCBC0CCDFA669AF1EE7C67FDB168E9B56634216C0023BC0030098B08A88DE26D0DC50C8C2632F6E4253C005BB3668D9336D3A74F37EDB9D4DDD3998306BDA45EBDEED4DCB9DFD66B32A48EEB55236F12A21598AF14864C13068FF4C9D0510A1757EB83219F98765EEC1468CF3BFA88C3251F0C9FA8E9DFAED4E871B3347771AAF24CA90E7E7FACC67D354F3936E5E21AFFCD7747A9C48A1B3E66B232F2AAF4C2A0C10641130C25D5BAF4CAEE2A37E9F9E6DB43357761923B7E76C5353DDD81ECE4F5B99A9FB84679A16A1767E68C254E402C98BB4E5F8D5FA0EC8CB0099011CAC90A16B95E7FED2D67EE0026C0C38201AB7B9836AFBCF28A951868CF3163C638A61C3468900302E099316386EBC3F7DF7FDFC50368F40B5B205825689C975F7ED999D2E3C68D73DB54809CFC1974F2A7EFE6CF9FEFCA466302061CF159C000100092B912A0268C7E9F356B968BEF3531E38985E3B77158DD445325262669C890F76D4CBFB6368CD2A4AFBFD494A9E335E6D311362F9B637915EACB2F2669EEBC451A35FA53CD9A3DD39E7DA2A4954B4DFBAC70ED604C3FFEF86357467272B223F8C82FEAD14EEAE1CD5F6F09E07C1C6F7243ACC487CA4D739BA504BFA7A795AB53E78BD57EDFB375C619FDD5E9B8013AF0D00774C8510FE9E8939E50AB76DDD5669F9BD4AEC3EDFADD1FFAE9480BEF72E2D33AFDD4A774CAA9F719F71FA236BB1EEC04F0BA7529A62DD76AC99245363E411FF1BA9AAB838D234705D1E873E6CE72A0A571D43DD64F54F8D3741E94B1342761114B63A3F04D51CCC0688A2E848C911C109DEBE715DED1D19895DE747592C8AED1AC8096792AE968388CE6B44E85E56103CA960BABDEC9CB53D5E3FA3B3565F242E5E455EBCA9B7B6BF6F26CDDD5F7793DFBE648F57FFA6D4D9EB756175DFF4F3DF6E2077AFBFDA95A9A54AEDB7A3DAD2203DC1D773FADA4944A3DF5DC30F5EEF78AEEEBF3A40A4CD83DF9EC1BEA78D4896EE1E0BA1BF99AF92EBAB5D783EAD0F114DDDDFB591D78F8C91AF8D2FB4A5A1BD2EB83C76A871D0ED283BD07E9DA2BEED55FCEEEAE93BB5CA0A37F778A162D483653DDE66E9CD236475B227D546FB6D10FDE74F3428938F8D10E2D16192C970F0E707A06C6D1C7303ACF3DE1BCEF2D1404056900037DEB999E30DFD7CC97D91203F85F7EF9A503F2A79F7EEA842DC04688BCF5D6DB26245EB1F48CB5FF82BC41C406A7BAB644A5E54C07589D0DDAC2CA2E9F38317B4965E52C52D934C1E6FCEE6D12AB22E0F78E3A3B4D18B9A68F7C9F78731EDEF26D03ECE41D2A2B71E76A59442C0AE5B95F4543417162A845F3A38D8B8FD145170FD24107DFA75DDBDEA19DF6B85D7B1F7A8FF63BFA5EED79502F1DF4BBFBB5C32EDDB5F3EE66EE36BF4EAD5A5EA1A67CCD7EA74E7AE3F561D6870802E6E315CEBAE3B03D73F5E52B96B885A1607E1D6844F7AEA9E37156AF4917847BC2EC8D5822F5619E48E335EBB652CCC04D11839F9898E89889799867063A966B988146218DD022548C67BEE37130A75FE4606032F3B3DDCA6E5E7E96FBF9F5018F0DD48081AF6AE2DCF59ABBAE46F7FDDF879A9A58A25BFBBDAE0F2726EADE811F28D93070FDBF9ED55B9FCED76997FC4333578674F5ED8F8999EF35B73EAA09B3D6E996BB9FD19DFF7E51D3BE4D76BB79092DF652A3EDF6D6B8490BF5D21B23D4F58F97E8EB992B94D064375D76DD5D7AEAF9F774D50DF7EAA65B1ED6DBEF7CA5DD773B56E7FDE5565D76E15D3AAF5B4F9BDB9CA9A38E3845F9B9969B358736B16005E3D14E9C175E5EA079C73DF11B0A35FACA3327CE3331CEE789A60360F898C45C331F45E32C5FBEDC6943D263BE520640051CAC190C1932C499C1583EACACE2A823657A2D469AE87271D48DF2D0F08526E578AF3318C25A771084CF60F2C3BBE1CA02D36EC5A6794A5C7D1160EED49EC91EB6CC10D47EACE1079C6F97F7DDBA1379BB3E0D7C56EFDD2B6B765D6ECF61ED8CA22C9556879C75C4C19F9E373DA5EED73DA70B2E7D457D1F9DAD1EB78ED27E87F552E3D657E8C0A37B6B87763DD464F76BD4A4CDB56AB67B4FEDDBF171ED7FC863DA6DCFDB8D2E52F356876BE8E889969B158042E1149195979B9DA7A58B13555A12567E4EB1F13A9F51D9B4E603B41BD3060B146A18FFBB52CCC06882F118380826614E836380A3998F8160F58B39D673CF3DE7CC3924394C84D4273D71603618877D2924F998CFC7BA71A29148FAEE3D7A6AC8C79FEB81816FE895E153F4C45B9FEB95113374CFC0211A3D2B4517DCDC57939717E8FEE73ED2071397EA9F8FBFAEE5B9753AEB8ADBB5606D892E370D5C647D3F76EA32BDF09FD1BAE78127B52EB34C1F8F3613EE8B99FA7CE2B7FAEB453768E5DA023DF67FAFEBEB6F1668F4F869BAB7CFE3CEE45D9A98A16F66AFD2B8B1DF6ACEEC359A397595E6CD5EABF1E3BED5A84F263A262C2F0BB64890B23039DA80FB6886A75FE83BFA08C1864F5F101761C53D69B847F8010C8007A0FCE638F10022A0A2FFB8C66446200246E6A43C231D26305A129F7B9E479F4262DE878F89CD734C60A62A0079FCF8F14EBBA26D0127F9323EDCB32FCD692ECA678C385689E9C7DE7261518EB179899BBBF19C9F852837ED545981E086B983C52CFA85F6E053777C88FE891C05B5FE08049A6306009393E5B6CFD6AC59EB56A6DDB1447BC40AED7537F456E3468769C7ED4F549BF637A8D5EE57A9C98E97A859CBABD47CA76BB4F741B76B977DBB6BEF8E3DB5CBFE7FD3EEFBFF5D2DDBDCA8844617A945CB0BB47DAB9334614AA28A4DE6727E78C297E36DBEFDB181D42C222B7B4DF23A1515B8C52D87014CD96005DB8DEF7F61E4A7A09881D144C7D2A1742C8CE225370C02D3C068009178F8C4F34C483A06CA0D8039C291A47EA07048487E960EC7C2C7F419B3F5E690A11A327282467E3D5F13E6A768FCBC351AFB4D92D69B95F4ECBB9F6AF292343DFCF2077AFAEDD1FA74E63C6315A9F7532F68E06BEF6AC0F3AF2BDF8ABBED9E7E1A32629C868DF8DC0D3087AC39D4C2359FE128B4392BD7945F4A5D39AF69D79CA92E8FBC7181866057C9F8D3095E7EEB92701897F67B70D2462FB0F069237DC56AF837DF7CE300C41CD39BA50081BE82790128E0C40CF4662C4C0F0134FA15A0A341C90361487A40C4FC18AD8CE003DC800F6D4B19E4477A166848BB64C9120756D612D8D6200E69012E634AFA850B173A10FBA38DB40F339613387E95DC6F7BE1682BDA15B3D8F5834571DAB75E5E05BCE005168E6BEF7C9F11469F39F3B2CEB492595898D799992916C9AE4A2B82A379167A438F7B95D0B8A3F6ED609A72BBF3D574C7ABCD5ABA543BB7BD41BF3FEE41EDDEFE5AB5DEED62E3ECD3B45DAB73B5DB7E176A8F032E5342D3AE6AD4A2AB8EE974BDEEEFFB86F28A6A946EDA7355D2CAE0708D8D7F59A8D4EDC357C32C5698F30D038074735AF5A7A09881B1884E05980C2A4C8076F09DCF20C1583CC7279C307CD2111786E319034238C43563959D53E8063725659D9BAFC21285366765B8305BD30B8CA9C3C181B4DC5203815D9459D13921039885B1D317320E29339389B474AF3FE6C67C835A9699BA24EFE4D5EB545AC63684F4FC0B83EAF709D33282791D75204198970E49C835F351F35940A1C93096174A0096F6F97D494005200113DA0AE18309CAA2929F07BEF0C20B6E2109EB83555816878883CF33567259456641E9BDF7DE732BA3DC0F1D3AD45D932756CBA38F3EAA61C386B9051BB423E09D3B77AEF3D192A3468D72E5B278C55C943D3F9E51079EB362BF6AD52AA775697BB4F363178C4085F1317ED05E5684D99AA24F584C619FD90B632C0EE669DCB388481EA4C1E1D36F0877C61E17F8209B79B08DB8DB522B3741976916C05A0B662B8EF3B3D28D373D6253953F18D79EACB6A62577D8E326B5D8F962EDB8EB556AB9EB35F6ECAFDA6BEF6B75C49137E9908E57A8ED9EA70687ED9B74303A407BB63F5EB7DED15F1959FCB4221B3BC1396FEAE57998FA056DA48101EFD3968880D9080FD1F73F36C50C6C48D19502A410A615DA00707A2989CF20401E983806C35F13074D82948749480A48210E87D349ECE75162A6497C0E3678CA485F675A2D547F0FA4AB2B425A9B9C648238ACC2DC2C27D2D34C6BB0D79ABC3C30D33D53A0413C035236D7CC41782BC7ADD4C178C668AB571983D875B9FBB5E9607B89F956B02FE64DB680F9D048B417B3D269206B27A045A342F491D7626835C00160001B5B2E23468C706627A046F30266A600ACDE0230566D996F022CD2B182CB353E20251E828172680FE5531FC605E7DB4E5DFC6A2FE3E7C72C32B6CE11C6B8F1DC5B48A1B21C159798F95BCA9A4360AA22B8786B05500246B627280FD330D8430C0E68440B6BAEE97F1CFD8470238CFE444BD3CF65E5C5EE600B075A72B2D3CD84A60E4626647B3F38D034E2A1DA61F7B375C051FF5242ABEE6ABD6F1FD39AE7AB73D7FB7474E7DB0D8CC71A4777343A40DB6F77B80E3DE41CF5BA6B80C64F986773692BC98A730B97F048FA5A13D6C14216F5A05F682FE4016BAE1E033C0F844F300F8D7EF65350CCC068A2C3A9786460DD3D156520BDD90503025CC0E7A5130387B4824931ED78CEE0100ED39007D7E172339FACF3D873C3C1C8FE54534666AAC2215652AD436B42CA484D526D6591BB5EBA7096F3AB42F9AA3626AA2C2E5028375BD5ECD9DA68D49946CC4AB1F4561FB40C0E01011332F7F382A3DABCACF43C9595542A352543B959852610729D09976C80857920B4060B29304E8ECD9F002FF5A4FD0C226D0320E41BCDFCDE79E0F8FEA3CF001CE62BDA907DCF37DE78438F3FFEB8031FDA16CD0AB1F502A8070F1EECEE894B1CE6A36859F200F898C5801D40230088831000F0D413C21C663CD0A28C21630579AD41DDB8C777540750AC6FAD8F01132B9AFCF25961810983A2601593B6D1AF3E0FC69D30FA8372B887F1B9266FFA0ADEA1AF003AA7D9D815E01E4B669D8D5B8509030465B8A64C4F3EF392CD2FDBABC58E27AAD56E176AC7DD2FD7766D2FD79E1D6F360E6EAF8466079BBFBF01F5103D3CE05DCD9AB14A05F93680085EF39833738D3046A0F24654F083C226B0C2365E36DFE18D175E9D634113DEE38829EFC12278CC392C20889C408FDCFF941433309AE8FCE8FB864C48C733A7F1F326CF0C8479C9EC410D21D561143411F1D860E760336625C7B518543E0E95B97EAD3B2C9F9B936E8059AEFCBC4CAD4D596920B270034C968138273B4D69EB92555156A4FCEC0C8B9FABD47529CACECC72AB773959B96EFECB4FDE659BB6CECACE75D72CBD27AFB6F9DBBAF54A5B9FE54E9364A4E7B8D346680C9871D1E2A5064CAC8742AB6F8A99FCAB0CE0D6A6126B47012797D8DFAB72733A1C0C8AF600B430286D8739F121841371BCA39F3EFCF0433DF9E4930E7C98A310DA94746865FA8ABC3CC1FCE481F0615C288BFEC7C1FC38EAC035421381445EBE6E3EAE7784799F3CBDB081FCB8A17538B1B33E2DC5CD6BB17A38F699935D686382C91FBC1EE757F31162F41773637716D70434E9A80F630E5FA0FD894BBF64D91872E493F49CECC94A2F50418ECDD1AD39F9D955BAEBAE3EC6A5BB3A40EEB8E3316ADAE408036DA0350F39A29B063CFEA2162C59E32CB0C8D492E9A6D3EE4EC3BB6D24133C2C3E5838C073FD11193F0443F00DDE4A075ABE6ECFD8325746BBFFAFE7A69E6206C6A20840DD35928FC1F4CCE19FC114302440F4D21D930E89CFA20A8B15013853DDC2088B1B00009F95CF8C8C2CB7AABC36D9C2962DD6CAC50BB47485C55B93A2390B162A79ED3AE72F495CA1A4D5664E2E4F74C7DA162C9AAB55AB576AD1B2A591B88B95B86A8D96AC48D68AA4D506BAE54A599BE6FC254B57B8134FAB92D76AE9B224B78842D9D48BEB94756BB43A2559D3664C5562D27267222380D8E447F2B3B0E24C349BB32191798E63F0018207037DE281E0014AFF382D6584A5419FB057C8A2138047C3A209D1B01C2281D15913A07EF49D7B83C3EA08612500763433E417AAD05A80C097190D46C0ED8527D75E03360430CED79FF602A6C4C4A05C8469D28AD55ABE6C95962E49D292C589367EC9AEBE1C1BE50DA9E4E495AEEE8C33E0A4FEB497B6F81565C258FC9ABFE05BABFF22EB83455ABC2849AB9332B526295F898BB374CDE577AA71C2CE6AD6684F75BFBA8F1EEFF781FEF3E258A5AE748B8F09AA657D81AF31B08FCB629399D19566423367AE35A15359A03AE6BDECBBF276BB7505C755F90E14AF30B22FDBF04B8961AC39DE12771458913F078A19B82DE4A57BC3704F30020CC400C180CCC1985FB13882398756613104738D850F7CC00DA15D664E9FE168D68C998EB89E3E759AA64D99AAA993A73881B039620B08C2FC0314100C024820FFF6C3A449932DFE0C772A85FBD9B3E718785638A642D0700A08AD00037B2687911132303A02CA3327968337F930B5024D93E33422C20D4107630334EA02512FCA808129932900F35300E94F7E513EFD49B96853C803D1BBE8FA41C48FBEA66CC8879347B4F3A0F565506FDAC8B68DAF132637FD49BD1BF62DD7F417F118434C6FE273EFFBDEE7032F8C1831D2F861A4467CF291860E7B57EF0E094CFDD1A3BED0C4F1B39C0045C0512FEA6B2E269F317FC68CC6AF71CBF41B3FF702D293EFBF86F17EAE1433705BC89B56D16174C4E6EEE92098164606C42CB430B8AC52025AE6609C0DEDDBB7AF063CF4B0A3471E1EE088EB87FB3FA487FAF557FFBEFDDCF9D7CD117940FDFAF573D4BFBFA533F2CF1F7DF471BB7F587DFAF4B378FDF5E0837DD5BBF7038E08E31CEABFFFFD6F3DF3CC336EE514702174BC9680E96026DA01500125A085BC79EFF734D1BE1E746848BF65435CFA83380002E646A8714D182630E0270EFD8D4F1A2F08301B7DF9E48D458389495DF0498FE000E8BE6ECCD7C993B4948156462820BC28FFADB7DE72E7937BF5EAE5DADFB0EFF0A3FBD513617DFAF4D1030F3CE0FA8EB89C6D865E7CF1C5FA73D1009ABEE0B822E6724928DF349DCD99CD5271C2C2E40FBB3511DE716158719E971036D1C0059C80745340FDA553CCC0EF437464B4F46EF87C73140DE8CD49CF9F9A1A0A1A981CF00144CC7B840C262540C4BC032C00104D84298F0F0120000580000660250D00024C0005F397C3225816F8DE324003F985220406DA88D560E2F85561886BE2F01C42F831F7C57261AB876D21CC6BD2210C008C9F920060AF5169B35F5B88D63CDBAA8562F140A43F9D8B2CCE38139BAD9E60CF36383451901F2C407980468F4343E5F06BA79881DB4A80AAA184F3E198C66801880EF7F1F07946E76F6EF0FD0011C7930F83C86B73C4806E8E38EAC682018B0CF8B156F57C99FE9A765077AEFDDC1210A201D148987C5C63E645FB8013EB011310B3FFCD37DF74BE079D37FB898FE686BCE9EECDF868F3129392F933CF0867AA80D90CF0D056D40D8102007DFD1B12E31079E6CC5DAEE917B436020401443F129770DF6EC21853E2FB7B9EE3734FFC68C2E487A2A64AF5422170B56E71C72DE498632780DF8EF18E3CC9DFDC46F9FE562866E04F490C00CCE207D93314BEBFFE3991AFAF67364C4BB41526309A0EF00038C0C3355A0B10F2CCEF7D3217477B62BAFA3926BEBF86813DC37B20E0FBE7381F8730AE89C37D741F362440429980AF21D3939E307CF2238F481B37CA635B294A10D487510EE1083CCAE01E7395BDEAE06D2BDACE1E6CB0E7EADBEFEB443AB43DC0E799271F279AA2CBFD2553CCC06DA1E8C1A4B37C27E237640688F85E2AC7EA48D27886E1394BE750F08D9C0DE4C31BA66F48D183168B88439D7C999E112098294A036C9427710109733C4E14718A88774779A7F4E9A79F76278C989311CE7C8F7D4E408B064463626A7A8D4219301D75204F9F3F654513E1D409F2FD431AEAE7EFF109234FDAD0308F2D1179356C2F44BE847B805106E194B939F2E921D2532FF2880EF7447CF24690A0D1B9A75FA2EB43B9C48955C75F33C50CDC16DA1443F9EB5883126B0063E5B335445E9BA386F1B795369507ED8A30AB3301011D20A31DCC373D08715E43798DE8E3E208278DAFAF07832FD73FE3FA87A61F2BDF6D21FA30368F6C1988BF25B0C60CDC5662C0BF0B43C502E7CF81796211758DAEAFBFF6DA2B1AB89167EEDE03121FC6A27D3E8C346807E213E6FBD1DC466513EEFB25BA7FA2AF3745B1F2DB1CF9B21AE61D2BECC72480CAC212F5DF541B7ECAFAFCAF2966609C36D0A6982402CA8DC2FC3B8DFE148C23BC08304983368D6882FA70AF7D29CB33DFE698706B34C9A680B5ADC085BC806918BEB93A36A46D89FB7D8945A960612AF6F35F22C50C8C536CDA1240DC9CD9B0E700CB3936FBF3662F2E0292FAFB8640F52E169848E3CBF74CBF39D011877C89131D2FFADAE7B32D84B0D99A74C4F9BE656D0D0148B7A513758A88EB5F175095F0FFA463C3FC4F4F48EB0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A330-300'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E3000000400806000000E806C00C000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000034CE49444154785EED9D07605545FAF60301C18E20D850045644504140EC05FBEE8205D7BEBA485151B02E1644AC8865C5EEE202767415EBAA58E9D244AA74088496407AB9B9B9C94DF27CEF6FCE9D70132E8AFBEDEAFEF50EBC39E7CC9933F57DDE3233E7DC1449494A52927680CAA2E52AAF882A5A59A18AAACA6DA8BCBC5C55555596746BA8A8A850595999BBE7037190851AF9D7B848529292B46304200167695944A170898A4B422A292951241251341AAD0625E71E88C4415C03500B35F2AC7191A4242569FBE4B562ED78E2B8E701585959E90820864221151717BB73E2D08800B6B4B4741BED5823D32425294935A9DCCCCF32035B6965D42E95627ACD1DA10A3B2DCA0FCBDD321C462A0C8096B68A88AA804A4245DC92839D9D54462B54690F5656182023C5C4A65490911DB7293C49494A524D029090BF8ED76815E516CFFF6895039CE151D1B20A850A0A559C5FE0E201637138AA228BAB2241A0402DA03DB79AABD50526294949FA612A2F8FD861DB78005569DAB0A0A8303063631AD06948035CA4BCD4E203BFD1AC5995452CAEB452199BB288AACEA746A6494A5292768CA215E6F35596AABC32ACA250BE2AAACA0C83E54651031FE0B454169865252E5C56A470D8706A405DBF3E47CB96A473BB469E352E9294A424FD30959595AAD201AFD428A26855A9F243050A1B003153274CFA4E279C7C81EAA43657C39D0F3184EDA3BAA9FBD8B1B13B4F4969A23A298DD4A9D3C92A2E0A342D133A1C131698A42425692BB94917A38A72D37025C54E23561A1823D190CAAACA4DEF99E9691AEFE3F1CB7464C74B54BFC1F13AFEC4BBD4AEFD001D7C702F753A6AA052538F5387232F57DDBA6D54AFFEFEFAF0C32FEDA99AE5D4B8485292929480F0FF0C88AAAA50B43C6C602C31B3B3409B733355645AADB0A44A7316A6E9EABE4FA8D97EDD95927AA68E3D69844EEA3652AD0F19A27A752FD291EDEFB46337356D7286EAEFD4CACC5BCBD9F20E97169A1F194CE2242E3C49494AD2563230AA2CAA723351CBCB42161571266A71A44885E1724D9FB34CD70EB857BBEE759452EA7550F3367D747AF7177558C747D4B1EBDF9452A7A7694503654A7735D8E9140D18F8B8CA2CCB4894658F12CB2F2867DB829394A4DF18B154C1A23CE72CDE57C707EA2B255A1A36CD581A2C161AB18366DDE675CA09E729AFB442FD6E78D090D4C640D755BB37BE58A79CF5822EE9FD89EAED79835AB77F4AFB1F7CA752763A532DCC644D4969A7ECBC6075A3221A76EB8D49CD98A424ED2039B000D2289A91595469F1CA95CA2D8D687351857A5E36C89074A89A363F5F175EFE924E3F6F948E3AE949EDBCCFCDDA73BFC13AFAA4A70C8CDD54AFC189FA7DF79B140A4B7905B996F5D60D04508D429394A424C5B6B705FB49DD3513374CE0941467D8655421D386B3E6AD54A12599BE60A3C6BC39DD8078961A1D78816E1E3A495DCE7852290D2E5487539ED31EFBDDA67D0EBE41BBEC7DB699B0ED347BDE46A76073F336ABAA32E276E35006E56D53912425E9B74A89F69DB2AF34120916EC4B2305CEBC5CB63A5FBDAEBD5F431E794D5FCE5AAFA51BA5218F8ED3317F1CAA7627DDAB3D5ADDA094BDAF54DB131E538B23CD844D3D4707B4B950BBEFD54E112BA2D2E018ADC0F72C5771611159BBB26A149CA424FD5A8905F9607DB0A669184FD168E0234295B17485C545622215D334AF30A2556B0A35E6D56FD4E5A4BE3AA3E720CD5F1355BE255C9E29FDA1CF8B4AD9FD7CD5D9AF8FBA5DF6AAEA36EDAD63CF7C4E7576FDBD5276395237FFF53E85CD0F2D2D2F564E8E21385696A71A17494AD2AF91002114F86835C118BCE2C43B87C1916B76D7945594B85D35C5A56167569644CC4F5C9AADB4F5D2C897E7EAC8636F50F72B1ED68857BED1ECD5157AF8C52FD4EAC441DAFFE8C1EA72EE8BDAB5F54035D8FF5AEDD5FC06B53DF27A435A2B85CBAADC8E9C82C26C1515E6D4A80754E3224949FAB5910722C4FAA05BB0AF6269625B0D09203122016CB4AA4491CAB00A42C50E440B16AFD537B33334674144CBD74A175CF5AC5A75EAA794DD8E574AA313D4A1DB4DBA60E0BB7A7C6C81CEB9FA23A534BD5A0DF7BB56293B5DA4D4FAA7EAE46EBD9D891B8E94285ACE728681BF64EB2671EA53A332494AD2AF89BC69EA29D8C2566AB7B66FAAB2193C5492AFC250B66944F3E94C332E5DB54EF70F7BCA54D741EA3BE0590DBAF75F7A7CE47CB5EC749DEA343D4729BB9EAEFD8FB84EB73DB940839F5FAF632F785DED4F7B4AB7DC3F5FAD0EBB4B75EB9EAC4913D798CF59A10D1B365831D8BD5B975020D62D6B54244949FAB5917F1F3152556140E4E5DE00881591402B458A0167AD67D8DB66FFC39664757AB6E62D4B579DDD1A2BA57E0B03E4A1BAE6D63734F4A989FA60E616F51DFAAABA5D31421DCF7E4C07751C6C5AF2CF4ADDB7BFDA9DFC9CBAF57C4D29A9A7E89853FFA290612F1CAD525E916946374FB4B5BC8AD20098352A91A424FDDA28FE5DC4DA4B169E22863AFC455EF60D34A8F98865154E23161B70D6659768F692753AEBBCDBD5F796314AD9E524BD37A558E317146B8D0176B629BBBB9E9AA17DDADEA994C657EBA0CE0FE9A8D39F576A93AB0C8CC7E9F5B7A739BF333BBFC0EA124C06F1890E5F7E655950A71A954A52927ECD145886C179555900D0F2B069460308EF239696855874706FF57FBF2A4DCF8E1EABE75E795F9B0AA4CD2169A361E6DA21A374E55F5FD1A1A75EA7B37A0DD3232F2FD4F54327E8D2FE1FE8CC8BDF57FFBBE7EBC57195BAE6CE6FD4EA889BB4CF41DDDDE40F93429BB232F04655163553385454ADA53D559F242949BF768A3ADE370096182A4D45059BBF0320029022D390C5664ACE5FBE56431E7941471C779E52763B52071C7A81DEFE64BD5EFE2CD3D105D7BFA6434EBA5B297BFD41297B9E60E6EB31DA7DFFAB74C69FDED55D8FAD56A7D39E509D3DCF57C3C667ABDF758F2A6278AF8CE6BB195ADEF4E0FD46FC46E7CB56C45E58AE4A4EE024E93740EC3D6507CD36F1E6AB9547A22A290D2B6488C18B5CB5216CDAF04BFDAED3254AD9A98B1A343340D63F53F5F7FC939A76BC525DCFFD9B060E9BA31E7DDF528FDE637570C77BD4F3CAF774E19FDF56EF5B27EBA2BE6F2BA5DEC94A69789C1E7EFC236DDC54CECB1E0A8732DD9B1E19996BC59B1A4C22454C1303485F9F1A954B52927E6DE4DF4384304DA18AB00124D80AA3BC9C42E723969A469CCA6E9AB552EF9BC768DFB67DD5FEA4616ADCEA66B53F76B881EB52D569FA67A5D43D5B879CF0B00E3BE1495D75E3347D3C457AFCEF6BF5CA5B25BAFD81AFB54FEB0B75C43197EBD97F8CD7966C53BC646E05555598ADAB8801912D02A8E840335AA8FEA64EC206242949BF1A3230628E062669A5CA4A428A9698DDC84C8A81313727A48C8C3C6DC82CD0EA0DD24E8D8F55DB636FD3A04716ABE735F8825374E97513D4AAC350FDF18A37F5F8E81C1D72F4631AFAE45A753DEB591D77F6333AF50F4F9AF63C55BB3639D6C0DA5C57F7BF5DB8A4DF2F4D73BB77F82C234034496000C42C35E15019334FE3A8C6459292F4ABA31818C56C69285FA545A699CACB0D90652A0B4535EFBB65CAD81C52618925AE7F90CEE879977AF67D4D87777B4ED7DFBB5AFB77784CDD2E1CAB51E3C23AFEAC6774DAF9A3D4FFAE19EA78EA089DD6F365356F7FB376DDE742EDBCB7F98F294D75DFC3CFA8D0C097BE699DFB168EFF181CBB7900235A717B5BF2B689F825C9BF5396887EE85E927E39AA3D2318EC62A999E697A4EC6C5E55325D14ADD4C6F51B4C399A76B22A326953522CCD9FB7549F7E3243A975F7D6BECDBB9B66EBE026645252BA28B5FE9FD5B1EB433AFAC407D4B0C91FD5AEEB353AECE8FE4AA973BC0E6CFD17D56DD04D0D76E9A6D406963EB5A39E7E7A0C38976150FFFA68BCFBA8311334951568C6D2EA3734B6470923FF5D72FBFAFECBA089FF6665927E7EF2EB74B54108C5AFE1793EF825C6AB360F86C321073EEC526654F3F2B768D37AF701612D9C9FA9CE9D4FD17BE3A668BF03FEA826CD4ED11FCFFBABBE999DAFB9F3A56E67DF6D28394429F55A685586D4E3D23BD560CFAE1AF6E8784D9E56A07ED78EB0FB07E9E2CB0729CC2CADA9C1EF172D53A8887544F3150DFC91D2223BDDFABAD4F62861E4CF4D0C581264FF7789B1E3B7233C40F982DAF6BE31FADF22CF3F31CDBCB52EE5256EF6D27D56B1AC4AC5C5856EA981EF987EF1D97C43407D6DD8C0E670E9D597E6DA7523450D50D7F51FA6523BDEF3C04835D8ED609531FB69190E1FF1826EBF7B848A0D6B5F4F5C2636F20C1870A73345F9B3E4FBC5DAB03E5DD9599BAD10AB438525B0B22A225B17F9B7470923FFD7281EA849D0FEB214AF75FC2B47C1AF2CC1AAFC12534425D87F760E28E3BF98FD739007A32BDF8058E5162C4C2B5585955F58A039DF2D74BB61C67F3E5375EAEDAE5E570F72EF187E3C7EA65E7FF50BD54969ACBAF553F4F22B6FB8C997FAA9FBAAD4907AF0EF5ACB0C5B3351531CF06EB9E51E43CFAE814368656564AC71DFC7410B7E3B7BBA0131A2C2DC2CF1C90EEB045584C32A2B8DA8DCD08B0591888F6B5CFCFFD20F01E5BF6DBE26E93F4F8C67A2318DF70B8B511116822F6AE71B6F56DA3F7E08C6980EAD10F7DC7F83E2EB17130E2E049A917A469D669C30F1732D5EBECA69BD156B36AA43A7338DFB7753C8AAB839AF42E919619584A4EE3D7AEAC5D1CF2B357577038F94BEB242118BE783E0D18AB0BEFAEA0B4B57A67A751A6AF68CB90E8C9919EBAC1C039DF9856BD7AC70AF47F11539666F01A3DFEE9668AD339E1246FE3B547BD0001F1280A3A7F8FBA4270EA9EA7F95A7B4B424A17943C7462234B6667C927E5EF2D3F1458561858AB78E6741016B6851F1222E0BE87CD4899944EEF9B7E713BD45FF9F26782AF6536B2EE4E5E569EAD4A95AB26489D6AF5FAF52C344BE29ED5D7639DC7CC07DF4D1BFD6286CCDE8D1F3567DF2E50237F379CB2D4F38C0965A361FBCBD420D538E53BD94D61A7EEFFB42C9A7A4ECAC871E7CDCBD74C17ED6E067DE4CF8444DF399269E3A6DA23B66676F515E6EB6A1B8CA9E0BC0F8639430F2A79007952700183695CCE70A824F166C05577C3A9EAB4D3E1D143F41C03EBECD9B33027BDF4089E9137F3F49FF394A3416F1C4D8F125EC4D1B91FE0641A3A54B973A0644F097B1CDCC1246627B3F7F2E4298BB195233917373733577EE7C4D9EF48DAB5F69D8C062405A9956A1A6CDCE30AE6FADBDF63A4F29A9871B30CF526A83232CAE9D1A373DCD8E2DB547A3AE6AB0532735AC778A764A3951A9295DB453FD43D5B47107D5ABBBAF060F7E38B66451A99CC25C67F686303F4D136EC8CC087E89CAE2625F9A73A1B0B050E190299C9288FB8C0740B650A30D352EFE1D62E03C086BDFFBA904D87272B2949EBEC60678B1962D5BA2152B9669C182799A326592BEFF7EA1962F5FEAE2B8B764C9F75AB870BEE6CF9FAB458B16D8F9C21FA4050B6AA659B46891E5F97D352D5BB6C2D1D2A5CBB578F1528B5B62E9BEB7E716398A7F96BCA0F9F3293F31CD9B37AF06F9677E29A28DB439BEFEB5FBA1F6FDB973E7EADB6FBFD5AC59B33469F257360E5334EE9D0FF5F1475F6BCDEA4C7DFAC9972A2A2AD22633D55E7E652C8A40A192723DFFC2284DFB66B696AF58A36FA67FAB050B97EABBEFBE73449E90EF17DF5FFE9E8FA3FCDA7543CB7124CDE2C58BB57AF56A77FCE69B6FCC14FD42B367CF74F55FBF7EA3962E31B3D4D812A32A6DD566F5ECF990EAD6EDAAA33ADEAAF3CE7B429D8F1AAC94BAA7E8946E43D5A8C91F74FC0943D5AACDC5EAD4798076DFE32CEDD7EC0A9D70CCAD3AF9849BB577B323D46CEF133468D0D3AAB036BAB741CC2CDD94B351ABD7A76BD9EAB55AB8748581D2CCE2720CF5C09DCC2BC8773FAAEA79FC872861646D8A97943F06BAEDDD271EB3017361F9F2E5AEE3274E9EA429D3A66AEEFC794A5BBB46E9EB565B9A1CB7A3DD870A6B79388C195B16DBC9807F12F806FE4729FDB513447494491DE2101284D8EB2A6E6BD256073FB80EB62B05A1CC99C2E415F83D483E3EDF0E99CB6DF166569B06E07E6C62C205EAE8835B5BF2F509FACD055F1FFA21662D54B78774FE87367D9D7D1EF1816749E7D3107C3AF28C3F27C4C6C205EED1FF04EEFB7BBE8EFEE8FB048A49EFEAF6F12612F1E445FAA8C5638191159A272B4BEAD2A5BB5BB3AB5F7F4F0740B44060CA55B9677C39F175F5A6657C3AE2E9634C40C8FDD29359436C6B735C4EFD8CF143454C163121C2F20579D237615594613A57AA30DFF8CEACC5CB2E35E0A574D539E73EA0DF9F3F5CCD0EB8527FBAE40D753AFA215D72D9EBEA76DA30FDF98AB774D6D98FA8C7B90FEBD46EB7E8D28B87AB61FD4E3AB2DD796ADFF66C0DBEFB3E573416009A915F2CAEA8C22467A228AA397366ABA020CF298E0913BED2C71F7F644265AE56AE5CEE140726F3871F7EA8F1E3C73BA1B369D3263F0E0E23DB806647895F64E5E83BCEC733E05C5310D79F7CF289A64D9BE6241D40CCC9C971F75DA7E3E09A4AE7A798C311CC0C1E09069C41E43A52CA8F4B06E610A02484426177BFA6C36EF99944E2B7F198B562203C854CE3061F8A0DAE31753169FC40E3AB06F7CC7CE6DB9866FF735E66473AD920A44825C0B1F30A3EDB10E4451E30006DF1CCCD35EDF3F11C0326090240F20C49F00023C433A50FA4E599F83C102E1EC804CA239D8F8B7FDE07FF7CBC4FC5797C5DE84F0FBCB8E25C9C1762413E41DB49495108C147878F3110B6D201071CA3160776D609C79FA3C222DEAC0F0233AB3ED066CAF575F2F5E53A5ED07810529E277EDF90718EE0ECB90A587F84827D9F8C6B7E41B609D590090EEB677BB42047EAD7E771FDAED59F74C699C3F4FB1E7FD349A73DA0AE273EAC233B0FD319678DD11147DEA733CF7C5207B7EC6D88E8AC8E5D2ED7157F19A2A1F78E527EBE34737A9ABE99BA4CDF2F5EE18048B1696BD2DDECEC071FBDAFCFBFFC540B16CD75E0634D1330AE5AB5C2D177DF7D6B96C52C4D9E3C51EFBEFBAE3EFBEC33A7C9B34C72C5BFD348BB6B00ECA7121DEA8115EB44A701015C7676B6D6AD6396296028026960009EA122FC9E1D0E3F8D73AADCFADBFD8C1DFD6E91E5113B71C7AD1D0FB1A0CA8F504225C56167873340C54505E61F0403C179A4B4D880C8C65C9E2F77E70C5479994934031D839897BBA53A5D517E9672B2331C1517E5BA0F07318356561E8AAD5559394625613617979B1F906F6D2B777E0A134FB42FBE3F380210DA8C1F0DC5A7C1A7A6BFE88BD8C0B841E219D240A4F76960569E09264C0210622212E28F94E7C9F5732C3DCF921F82D4E7491E3E5F40E7051C9608E71C01225A323737DFD2F35B13E6FB448A8086DD931AEDD146FB34E9AA638EBED2F956F5EB1E6826E226CBD786D2C6ABC8C6823EDBB2654BF5CF6A5326449FD0171CE113EA4C7D03DE220EA16CA69F8D2B63EB6624E103CB9B710F6628A3CACFDBA2A52B1669F3968D8150E2BE29CD938FEDAB5D1B9CA6830FECAD534F7D442D5AF5D72187DDAA3F9CF78A0E6A758F3A1E35427BEE79AD2EB9E89F6A77445FDD39E4356DDC52A1759BF3DCEF617C3571BAC68EFD4013BEFE4693264ED30C33B9F145376CD8A4356BD6587D1132F4538929A00DCECD5ABB364D19191BDD356E15DA71E2C4AF357DFA74A5A5A5D1BD09B1B44DE48E504C02575F33B0F926423232321CD1E968483ADE33199D0C2370C49905B048160089A38B76048F4C1B13DC40DA9F78CDE5351ACCCFE0708F78BFC6E5406747AF05839F7336296C1A2E1A354674262668376DC4CCA069B832F753CE411C441AEE41AC1B71CDF3A4452B5246981D15AE2C345650A6D314C654742AEDF48C46209E3E22DE0B26E2E243C07C81E6F71ACE07CFB8F45D7CF0E9B847F0CFFBEBF87C38A74C7F8FF23887F17D7D49431EFE1E47DAE0F309EA6CC0AC28D4D265F3F5D1C7FF324DB29BEAD5395875520E516A4A7BBB6EA9F6EDCF766349758BDCD247D05704FAC1D793730265714E79FE1AB2B36A66678C6393762EF8F630CFE0C73F14C9721F92A23D33BE59A401D73DAA268DCED4D9673CAA6EA78E50C74E437468BB5BD4EEC83B7454D7E1A6019FD461ED86AB53A7C74C3B0E55CBD6176BC69C2D6E6572FADCA99A3CE34BE59A802660A22304F8815304544101938A59FAE8A38F9C1FCDF1BDF7C6E9B9E79ED1A79F7EEC342100F49A7DCB964CE7EF820D0B0E37B1F174E7B4BD1A50DBA358876D73EE332213E2376FDE6C6A79959316BE537D604049E3C114742A72B5521B3336289BC55153895C732C2CE663B1C628A69D78FB1A53911733D146FC1E1E475ED2B4A1AA8E2F0EE7DBE0049215331629EF7DC7801128336ADA2EC7818A673C931415E73922AED0CA24AEB8284FD959193608B4D3D214120F830675A71DB54D281FA8436D868B0F3092EF231887C075CCF48FD539B8E7D3F97C7896FB3E7F0F741F3CA0086849EEF9FC086825EAE7F3E51CE148F0E962635B1DC88F7CD3D26C7CD7AE70AF014D9F3151FDAEBD462FBDF48EDE7C7DA2DE1EFBAD9E7F6EBCE6CDCDD13BE3263BD315AD882B429F61FAFBB61228CBD7C1971B7F0CDA84D98A10F7FD8C898E560D8420443C8A00E19FB66E918DA1591465957AE6A9B1AA93D246C71C335007B5E8AD66FBF651DBF637AAED1103D5B6E32D3AB2CB50B56E3B5807B6BA5DA79FF5AC1A35B95C8D1A9DA1B90BF2659E91C21505DAB879A5667F6BDA6CD51A4DFC6AAA162E58A22993A76BF6EC396672BE6F3EE25C3343E7392DE9F7C0A2F97C3BD7AE5D6BBEE30477A4FF2C54E38A3EF5968A8FABBEB93D8A6936771E1BF4EA7B6478D34D37999F70805AB76EAD3A75EAA863C78E6AD0A081D390308A670C82EF580869160A176B4BF666035C58E9EBD7EAABC95F6BF6BC6F6510D26D77DCEEA64C5E1C33DAED80E87DCDB50E3A9F7EF58596AF59AD7C1B94A10F3DE03E9170EFB007556C12F4F3AF2768F8E323DC73D70F0C9E7FF68551EEF8CAD857956992EC934F3FD3C44953B4252B47AFBD3ED606CE06D598A6DC4CB2EC1C1B50F30590FF9C23FD08CCAACE9D33CF0D02E1A5975EB1B649FFFAD7BFDC6414B37B4845DA3A6CD830C7648F3EFA6835B8C68D1BE7BE0A76FFFDF7BB3E19326488B31890A83367CE748CF4F2CB2FBBB4CF3EFBAC4BF3F1C71F3BC1B662C50A4D9A34C9DD7BF3CD375DDE983B083FF2C00721FDADB7DEEA0677E8D0A1AE5CCC5D02F57BE595571C733FF1C413D540A36C988480B426FDEAD56B5C9B61AE75EB36B819E5CCCC2D666E65DAFD408861B267E798F593B5C94D60DC7BEF70D941C31E1CE92673DEFCE76766F5440CB41BF5F0F0475D5F5E7EF9E50E60F7DC738F735DFEF9CF7FEAC9279F748CD8A54B17576FF868CC98317AF1C51775C51557B83986860D777280E3F8F6DB6FE9DE7B86EACE3B06E983F7DF51B3A67B894DD8A975EA3A8DB53E7D938D73545979F9CE5F3DEFDC81DA7FBF33D5B9CB001DD1D9B461A7DBD4F6F0FE3AEE94BB74F8D137ABF921D769D72657E9F04E4395DAE05CD392B7595DAED7238FBC63829E8D01CBCCFFCCB2BEAD3017C8C05918D196CC2CE566E7A9B830643EABF1313F25656597197A0BF28A5DDB5048E9E9E96E4C11868090F12130763101548DA1784A18194F317FA3461C4CC0202F5BB6CCA9E7112346E8BEFBEED339E79CA35EBD7AA96DDBB66EAA9940A5D08C1C3129F01FF0B59C4D9DB9514521F3C5AAA2FAF4B34F34CAC071FBD0FBECF8A61E7CEC29A56DCCD109DD7A68CACC25FA76C11AF5193048AB37E5A9ED51C76BC99A4C5DDE678066CC5FAEC79E1DADBFBFF2B6E67CBF54D7DD7487328C1906DEF6A03665477559AFEB3561FA2CFDF59E217A60F8130ED027763B5B052551753DA19BBBC635E58844E4581CA9D2D4E9DF5927A2D5AB1CC321E98FE97AA23BD6ADD3C00DC205E75FA437DE78D318659C060EBC493366CC708CC44CD9CD37DFEC2436A081C100E495575EA98D1B37AA7BF7EE0E5077DF7DB7468F1EADAFBFFEDAA59F3C79B2FAF5EBA7CF3FFF5C83070FD6DFFFFE77BDFFFEFB8E9999FC6AD3A68DEB4704DE4B2FBDA4FEFDFB3B80CD9933473D7AF4708CF0E0830F3A4148006030FC35D75CE39600BA76EDEA8E0093B2C91BC6813233331D1891F08011FF302FCFDC0803274B3DD3A64DD79CEF66EAD3F11F3953ECF1C71FD71B63DF52AFABFB6889DDEF79E145FA76DE42DD7AFB1D7A7BDC3B1A35E61F1A3CE42E13B659BAF1C69BB5266DBD1E7BEC31B74C42B9B48DB620BC58177CE38D37DCF2059AE58B2FBE70826DECD8D7AD1595268C26B86381016D5D3ADBCE8CFF962DB2B8A872B27883D7DD760BF53DCE6512A6856E1CF8A22987637454E71BB57FAB5EDAB9C9F9DAAD510F1DDCA6979A34BF44FBB6ECADF69D8768AF7DAED6393D9ED6DEFB5EA406F58FB1675A6BE04D773B0B6DFA8C299A3563A6664C99AED5CBD254546056053B0762E5F162F29CD9F3B47CE92A270C70BDE873044FBC75C118C46BC0ED51C2C878A2A3FC391952180CC68023B9BD69C1002301201FE7434CA35A08CC0ECC553463714991D38898A400B2C0EA3F61C65C7DF0D954E599BBF5FDCA1C7D36E17BADD9688018F6B26E1BFA8CB24C0A679855F5C197F374E57543B42E47CA340576FBFDCF2B64C58E19FBA172CC0D7C7EF4077AEF9399BAEBBEA75C3CFA3DA5DE1E2A31C0DD36F821356DDE464556DEFE2DDBBBCFE81DDFED8FEE3E715985511DD0A29DFE7CD5F51A6D66588B16EDADDED2BECD5A6AF42863101B0CB7A1C48E80D30D0E076B3B6D45FA797F911093864E03900690728C0D50F539C439C13F13274DABD3C70F74F01DCEADE9191BCE57AE5CE9AE798638C684B1E49A6525CC27D2B060CF58F28C1F367CA2F8C0040E9339EEE3BFCE4F0FDACDF4BE8D9C35BFDCDC0513AA6622862BF8CD414BE728980B58BFCE8483352B66AAB9B2FCA4527CA08EBE1D046F45510A73049830FC0A1420C4A72FC8F73B5CAAB470DE129D7BEEF526285B6B97065DF5D0FD5FAA4387813AB0E5D5DA6BBF4BD4BC6D5F7539FE4EF775EF030FE9A303DBF457AB7683B44BA33FABE1EE17E8F85387181A0E57BFBE0F3A50E7E6E7595D62BF85C190588369FADAB4744D993455F3E72ED2CAE5694E6B024C261EFDD8313EB485EB18EF3BEC70FC214A18599BC808958B5467C9C2CFDC51208C458839A6D5662915A152101522DE6D7773CB0554D0FC3FEB50B4A35BE2301F6F55FA463D3DF225F5BBF10EE5599277BF9AA71BEE79566B0D5CB70E7F43CBACEF4F3CFF3ACD4E2BD11FAEBADD5D7738FD0A773CAFCFDDC2F3B9B0F71D7AEDE399BAFECE511AFAF83815591FF0FDCBBFDE35483BEDBCBF3664942AD7F8A05193DFE9DE079E57CBDF1DA3534FBF5877DE3D42235F7A5F279ED653AFBFF999F98ED26EBB1EA85E57DEAC91CFBE257E871D00EEDC700F9586A3FAE2F3096ED9C5CF3AC2C89E71D0FC081CCEBD6FC9118B82BEA0FFE80F7C35FA70ABB00AFA94E081E7FB932396086991C010F97DF5D5578EC961620F52D2301E1C7D7EA4F1790142CF283CC7916BCC5BD2FBF1253FEA487AB72616315FD3DA929F9F6B82B44065E6BF87AB8A55AA908AAB0AEC6F9E79F121852AF2158EE2D3FB7CC36EE69BE0FD53CAF2E0447051166BCCACD3115F58586C7E7CF0F36BF90525968F2534E015E617D87985B2B237181F854D0020C865E3B14CDD4EBB55B7DC32D6AC8349BAECF231DABB592FEDD9D4C0B84F1F1DD4E6161DDAC57CC4436FD21ECDAED61E7BF7524A6A77B7DC7154A7EB0C091DD4E7DADBDCCFB5515699594780903667AC5FA7D9D3A63957A520CFEA4F5D8C3057DDB9D531586E314513233428AB00FE371E77841246D626068C4E64B9C2FB41749E9762300E6618A60FA6D8238F3CE27C1D7F1FA6E159163F597361FFDED469133463D634CD9E33CB494FDA3479E6428D7D77BCAEE873B303E380BBFEA64FA6ADD48D4347EA8AEB87EBBE273FD4883113DD8F8CDC307894468FFB4EFDFEFABCB22D6DFF3B5F54811577DBD07F28C3AAF8CEF8D59A31AF58FBB538DA81B15EFD5D74FC89E7A8FBB957E8D0C3BAAA77DF5BF4C2C8B16AB0F3BE5AB0689D39F8875A6FECA6BCA22ABD35EE331D726817DD71FB433AA4F5516AD6B8A5323714D9FDFA1AF9F7D1D55A31541C6C6D22A03D9CF4B691C9CDCD360687F18319E0ADC72078A0C56B0AE2E827B427A624FD85F0638118B0B0460548BC4FFAEAABAFBA31E11E20E38829CBB8000088F41CC98F00A8484B59BE6CCAF4E9B72E29040BF13C87E98BF60C34B031969B2433609797987E623344B9C29556EF4A036465915920762C37615369FE65144D1ACC1BB0158CBC314DA92B429CFA730F9EE21E02C6D7CBB5C38EA56C1D336187B0A6AF996D271E8A98B62AB1EE3FFBF7BDD578AFE39452173A514DF7BBCC2C9BEBB4F36E57E877870D56B3030668F7C67D94BA2B00BC4C2DDB0C56C7CE0FE8C083FBD9F5F136AE87EAF2ABEE57A199480CEDFA0D9B5D01B3667DABD93367293FDBFC65DEBEB0B8C2FC22656FC9715A12C0F92304F07E0AF86A53C2C8DA44C7D0793008CC42C711307F9098BE03095EEA13308B78D607D47EC0A43063D486D63AB734E416FC172E5AEC40F8F08851FACB35B76BFABCB5767DBBD66444F5C013AFEBEB99691AFDFA24BDFCE654333D47AB77FF61BAC380F7E67BB3F5C957CBD4E9B88B34FCA917D5E786A1CA359BF4963B9FD71FCE1BA0175EFCA7314400166ACDEF2620A437669A1962D7C5610C2DEB64B365811535CBCC2A74CFB866D9911FAD5D386F59C0014639D9C6B4019E5C603302E9616CDAEE350B121F6D861FC46409DBB4D8C6C5A4CDECD9B3DD6608B67C6136728EAFC8C40A71F42BF911605200846F4EC0478C0F9EA9191BAF096178E249CBB8F93182F149E7AFBD60E0E84101F13CF5C684659CC903ADC87211160EBE3E4B53D966CE15981062028DF9F0B08D31E4FA9A17072D0048CF37F1E6BB0FDC27D05ECA8548076F646C36FE2A0BBB19F64815DF3535CD6D6DC5CFCF292ED3F997F4372E6EADD4FAC7AA45DB1BB4F35E9719207B689F036F30B7E32203E240EDD1A88FF6DABB9F1A37BD557B341EA8E607DDA6C67B5FA5FA0D4ED59E4D8ED36967FDC52D67B0C5EDA34F3F31D7699D1B2FC7E756B562D3C6A102EBE37069B0AE691A9A63F6962C039FF59FA571C704D8F9299430B23601283A93D922A435C0F48348473288749E97C49E217CC7FBB484C0E730D3ADA2D43A39E43A9CA140FACD5AB8522576916B8F715CB46283F3F1366DB1FC0D29FC4865898D0260DA62CE333911C731638B9937966F9A4970062A33DBCCA55293F8766FFD863556B7CD6E3DB32854EC9808493B6FFE42337772DD8CEA8A956B34D59CF5B0752ACFAC4E5B6BCC516ACF0596009198A7F83F009159469A89894A3B69374CE4850F8CC58C20135C808C5D17F8D84C96003404154788749F7EFAA9B32E98D860D694891D8E1F7CF0819BDC60D674E4C8912E6FFA973EA75FB140BCFFE5FBD9838DBAF8FA0028CEA9A79FC401E45C7B0182804078F8B4E4E3038CC98609B42360E4B9B2F20A33216D6C4CC0E59A29C9DC466149F0FD51C693BEC6EA4100B324411E9445DEBE7EF49DCBDBCE11983EC0277905D96E298B9F502B2D2F54B1B698E62D32E31403D55C8F214F1A07B754AB43AF52F3167D4DCB5DAA238E7D4CBB37BD460DF7FC8B3351F7DEF76AEDD9F812EDDEE8421DD07C809A3435ED58E70CD54D3D41BBECD659F5766EA10213C4EB32334D0863FA1A0FAD5D697D59E6C688718FD77668768873DF475E18FA342CA9D11628B6A5B0069EB6470923B7478010868AD7866E50AC5274280CC8395294C1F681E7A82C148091C699A6AA0A5EBB2934862F0E45B4D6183CC78CF6023347726128933EFC4E02E0E0951C76C4F85F112A8F96B82353EDEC92E19AA9EDB01D498FD04013E383F06269289CED3A3ABFD07CAD98C465E288ED78C57C31CC95633E9EE5C22F055147BF8EC5822D26281A114032EBE8CD53DA84F6E0489B39D217F40F830950F0DF3867B335C07CEBADB7DC343EC01B3B76ACDE7EFB6DB7B4C13D964BD08E4CB030BBCA39606429807D8DBE8F190318195032061C89F3FD4E3AEAC03D00CB354C445DA81FDA997CA857302ED5930DD581FC49E3CD61FA22E853EB07F39561367ECC85FE66EB9B25B56B036B2C8E5D558C1B263AF304940B511EF5E1E8C11898C8EC580ACA834F36673146E55AB17A891D235ABC6E81FD35616355E979E99D4A69D059A90DCE30BF7F90B921BDB573A3EBD5F2B0A1C6D57FD47E07F735D3B4BB3A74EAA7464D4E569DD4C30D84471A083B98166DAF73CF1BE8E6062C38DE0E9599F999B7C9F8107E7102CCB9673101B70D16E229D66FD5D7FE398EF1F13F4609237F8C90A89852985C741C929AC291127EF060043A1860326D8EE465E0B987A39E95B5D981C2BDFB66838AA3EE7EA0A4B24C45A5C5EE1EBB1F8A43F9AE83DC2F0319B0D8E6163629CBD628DE17E388F9C426627C43AC8592907502DC00D92903CE5A2279210420A4B503584E96630A88A5170886E3886FC4648CF7FF8C5F8DE9C3C6F4998E69BCE6E0591F60D0E5CB57BAB706780364C99265D64F0B8CF96757BFFD0001064C5388A97C008966FCC73FFEE1C0C772C80B2FBCE03617BFF6DA6BD5DA953E8591F1E1E857EF2A0032CE39323E583100D49B99F4014CC3B3AC8BB2FC82C0223D33E4A48D318F1B4F4F8C2BC294407BC99B31262FFAC092B836738E0F8DB0C2AF436B62A6F2C27156CE163773CEF3D403DEA01EE40D2108E00DF2A67D31CDE3CC535E509E316BBA09D13C074466CA4F38F59A98AF77A2F9FC176B975DAFD501FBDF67A0EBA57D0FE8A5BD9A9D6FF73A18F87E6726EB01E63B1EA833CEBA48FF7CE70BE5E4B183C8144451E07BFAF72E9909862FB6EE3D0E78DD6B362C20267338C7242D2D61522AB8F79FA28491F1C400C5239C81F0F174EEC489131D43617ED199302680F38CC13569195066C8E86CBFDE985760A65A66863311D3D76D52FA9AB58E412006876700318CC200B23998C5D5E2423389CD2C0ADBA017E687B4717DA68BDF9091EF16F6376F2A50EEE61C65589E9CAF4D5F6F9D1F75C04308B081973A520EF9B2B6969393E75E02CDDABCC5AD67C110948B2540BB20D6DF48C700D10E8207229336ACC9717FC284498E39097EE3358309D3410418DD9F13606ECAA4DDF4256B960016204200944DF7000933133052378E1E9080936BEE3399C3840DC290BAB22E4C3C79E3A302560F320F3A02E3CBB8429C134FBD48C3C23FCFD32FE4CB39DF7AC932CB81CDF8A463BC387A5031C66CECC8C9CB76F78887E84FAE01256D278EBEF4FD40FDD998B1DEFA1C614D4FAD4C2F50CF4BFEAA5D763F56BBED799ADAB4EFAD835A5FA98E470F529DFADD55AFAE69CABA872BB55E6B9D74724F0D1EF288DB88C0B3583E087E8E816035EF93ED906EA924E0EDF8978063E31AC4DBD8F9F3DA8412F8B10F4DED28258CAC4DF160AC15E7188A01C3D967A708E044EA7AF3874EE51E4C82B6C0315EB76EADC5AD726B8CBCEF95935BA86CF301B336651B88CC94DA98E500B671DD66A5ADB6E78D962C65AB5DBA0129CDD1CA95AB9DB9B8654BB623F60966E6E49B2F6900CC3040E56628376B9D0357765EA6D2376D56E6A68CE0DA1C6F7653302BB63E7D8332366ED106F3055943223E7D8DF9C6EBD9080CE3855DFEE906E88D1B331CD8FCCE1CDA0D9332B8CE14B351E772D2A429EE4808B6E405F1F419E4191EA6F6E69A0703C18394FB3026DA04E0D077F87468482C13342C7E1E1B08D0BA808C091B2C16883840CD7DC6052DCB2412662BE341A02ED4C90B150FC0A05D41406005C732D7CF800830AEB771DC9CB9411BD6A7695DFA2A231312EBD3AD9E4C58A5599F99203310B266C7E2BF171A6862AFD5BDF045B0F0BE2AEFAE72CD8603ACA52FBE9CA4706985B56DB1AEEC3B40A90D0F30AE6D6E1A8F2FB6B5749AAFDE1E87EACC0B6ED0D857BF54A8101F2FE877C605F72552860503604CDB1B004325665D95E21E6D5D43F794683634F692708DB8DAF49F0064C2C81D250610D0C12C3E30504861769530F9C0B6AE2FBFFCD231038C01030156243C0C05F3700D83C168100CE3198D5D19300FC43DF2F6D74CB9FB174D7D3E3F449E49E3AF993C81A88B3FF7E988836072EA4E5D6062DAED34751C88602C0F22D6FEE81318CEDF47E2C3E83CC339478008D37BE2793436F708A4C74F44C851077C48267A00153B9C28877EC6CCA58F3165E9EF60D3F27B6EDB19CF13CF7358305E4342B401C0536E3CF87CF075F201203136E4437D38A71F7DFF11E7FB9423C200ED4E5DA93342C10B6CDF06FA95B4D40B4189C05C9BB64613BEFA5AEFBFFB815BABFB7CFC173ABA7357E3D6C6DAA3510B5DDDE7568D79F95D4D9BBE50C5C67A4CE8E1A20480B3BE8DBD8513EC2B36AD8F4B62AE0DFDEE03022836360979FB97A08491DB2398C33315D73486C1F40C57BB71A4039C98AB9834800B0662CDECF5D75F7793166CEB62CD8C890C180802C44C64C04098663014CF10EF8938988E74302044FA1FA2F8B4107913CF5A1E04D342F1D730393399A487B900986750DA0B786827F1B41510D24ED2A001D0665806B41FFF8D74101A8F6B8E6802408E5919580EEB1C5810745C13601EEEC3D08092F63309C4AC2B7D487FD21E181D502038D036009E401DFDB91F3702E6A1D7D080138D4D9C7711E2B5320212F0FB71F2FD495F513642813EA3BF7C9C27FA99B4A40190B48173FC64DAF1FCF3CF6BC4DF9ED0E38F3EA6912FFC5D6FBE3156635F7F5373669BB6379A3DF35B130EB423303B99034073BA73FBCBC45B857BBBC6F83362ED091598F988503341675A8B790578375E10D236AEFF57809930329E7C45E32B4B1C47E268108D837C7C6DDA5E63197C808A8663A06130988AC90BA6F121263198756462836BCE8983B8261E866440FD333F463E0F18E0B9E79E739BB39F79E6193DFDF4D3EE0811471A9FFFA851A3DC2C28CC864041B233D309F3C3A80007400134DA82790E000110C0029080836BD241DC6751DDFB728012EDE327BDC803C6257F0002B849E341E28F000D2D467F7A8D0DB37950E19F0170AC09F2A23CCAA50C341265A3D9B13CBCA581C6A26D808AB6DF71C71D7AF8E187ABFBDDF7217DF5D4534FB935508ECCFA72249EFB3C8BD045E0E2F7C60B61042C828BBE40A8D5E60F4FFEA5723FBBCD445CF0C5050352256668A1999C59D56FE47853949974260B999F0826E182FCBC42F95F00603C258C8C2780E4A9F6BD1DA59FF2ECF680FBBF40B1765407069577D430D7606A0F50B40047CFD8DE8CF37E1DF700199A01F39C349873C4A3313C08D028302D160079C2BCAC3D727CE79D77AA277720E2B12E7843836720AF35617E40018038273D262C65A0DD280F331F41013001316DB3E0DA0DE0012F80F5719E76746C49F76369FDFD44E9F057F9FC212F85870D689506BA4884C9C06CBBCDD24CC8019497BFDD97DAE22666E209DE8A6F1BB42375FB392861E4F60889EB250A47AE69583C786814D7BE81FEDCDFF3E9FCF3F171F1E49F8D7FFEE726CAF5141F47DD7DF01A8A405DD14C6834CC39CC35CC39DE5280001726B637E338073C6811DE82409300124C5180813603C4682CAEBD164593A041298734683BCE21E22134289A349EF162F576E7D435519C8F8F27E2D0B03E2D793276FE7E3CD5EEAFF8F8DAD71079935F6D80788A6DBAA8BE667921982CA934DFD04CEB70703F8863D635D8E5150F46EA8D29EECB89AF4BA2B85F8A1246EE28D191BE53B98E3FFFA9C4738918E1E7225FBE6F53EDFB507C3CE7FE1AC68C9FE8C0F4C6E4460B794D84198DE9CB391A0CCDC6C23EE025C4F272F978F2D784DA132CC41317578FEAC03DDF160B09EBBF23B4BDBEA80D1CD2D58EFB772871598C4BA5E51FDC63B6937DA0BCA9E1D378DA9E36FCBF4209237F887EEA80FE9AC9F7058C08A8387AD0781011E2CF615C7FCDB9B7367C20CEFBE19C13C893F35879EE3A51FE3E5DECB9EA3AC65FC7D37F622CB797F77F833C206B13BFA1117FCDBB88F1D710DBF36AC7FDAF51C2C81FA2449DFF6B03E88FB527DEB4F3041021FAC70392749CFB6B0F261F001DC183CB13E90023A615E7FE399F1F65F838D2FBEBF8B189DDAF51C71FA3F8E7E3CF7784E2EA54239EB89F529760513E38F70062D1DFBDB911DDDAEF89F204846CB1AC1DFF7F851246FE9629D120D796BCAC0107EBC035D355A94CEC9DE5C8D7D3985060719909054FCCF4F985E8DCBCCDC18483F93894EB670B3D9196FBF842CE1F8A6940D2C6CCC2EA904840C4B70546264DA2F6FDFF52F001B0E09C0F51F9F3581D6BA4FDA920FF2D51C2C82425A66072A02683B12F33FE1AC2C789673A9E0358049E672B56F0C271E0F331535890CF7A2DD7DEE4DC6A7E9297D7BAF1608A4DA26C53274FB1FBDBC47BFA29C0ACA8B5C384D7893806DFA88D4F57334F2F246A3F0F712F09CEAD9430F2B74CDB6350341CA0F29304F82FF13E0CF7FC79BCD684E1D88BCB1A186F7AF0AB4D800FE24B016ED53A466ECF72EC1C6BCD596C760EE063966E0D30C66B3A8EF1758827181EA003CE385FB4469AEDB5DB1360FAB11F7041F3A3C18363E234DB03DF8F95FF5BA08491BF65DACADCC114391A2DD06A3062603E06BE0BBE60F0763F3F47C0FB7AB16FBE56E7E5B5D9560D0778B64EF2782D08A89DAF687C0A0003CD4AFE81568CD529FEBC469D3DF975B6C0B40DE27E2A93C76B59EA9A48A3F93CE381E5EA5B45B926B0DC827CCD6792F4E39430F2B7483FC6B430788CF99C99E95FAB0AC8FE3A80C1B88149EAC8F9804140BB555415BB772F030D1BACB306CFB33E16001CE2392F08B807F1456E0BD5F5D96AFE6D7F82241E2C9EE2D3C683BBFA187B63BDF6C667F679C62F1DC49664DC79CC54B710ACF3B10BC682BB17FBDCC836E750EDF5C0DF3629E5FF018DE1AB636A9FA3F40000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A340-200'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E3000000400806000000E806C00C000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000034CE49444154785EED9D07605545FAF60301C18E20D850045644504140EC05FBEE8205D7BEBA485151B02E1644AC8865C5EEE202767415EBAA58E9D244AA74088496407AB9B9B9C94DF27CEF6FCE9D70132E8AFBEDEAFEF50EBC39E7CC9933F57DDE3233E7DC1449494A52927680CAA2E52AAF882A5A59A18AAACA6DA8BCBC5C55555596746BA8A8A850595999BBE7037190851AF9D7B848529292B46304200167695944A170898A4B422A292951241251341AAD0625E71E88C4415C03500B35F2AC7191A4242569FBE4B562ED78E2B8E701585959E90820864221151717BB73E2D08800B6B4B4741BED5823D32425294935A9DCCCCF32035B6965D42E95627ACD1DA10A3B2DCA0FCBDD321C462A0C8096B68A88AA804A4245DC92839D9D54462B54690F5656182023C5C4A65490911DB7293C49494A524D029090BF8ED76815E516CFFF6895039CE151D1B20A850A0A559C5FE0E201637138AA228BAB2241A0402DA03DB79AABD50526294949FA612A2F8FD861DB78005569DAB0A0A8303063631AD06948035CA4BCD4E203BFD1AC5995452CAEB452199BB288AACEA746A6494A5292768CA215E6F35596AABC32ACA250BE2AAACA0C83E54651031FE0B454169865252E5C56A470D8706A405DBF3E47CB96A473BB469E352E9294A424FD30959595AAD201AFD428A26855A9F243050A1B003153274CFA4E279C7C81EAA43657C39D0F3184EDA3BAA9FBD8B1B13B4F4969A23A298DD4A9D3C92A2E0A342D133A1C131698A42425692BB94917A38A72D37025C54E23561A1823D190CAAACA4DEF99E9691AEFE3F1CB7464C74B54BFC1F13AFEC4BBD4AEFD001D7C702F753A6AA052538F5387232F57DDBA6D54AFFEFEFAF0C32FEDA99AE5D4B8485292929480F0FF0C88AAAA50B43C6C602C31B3B3409B733355645AADB0A44A7316A6E9EABE4FA8D97EDD95927AA68E3D69844EEA3652AD0F19A27A752FD291EDEFB46337356D7286EAEFD4CACC5BCBD9F20E97169A1F194CE2242E3C49494AD2563230AA2CAA723351CBCB42161571266A71A44885E1724D9FB34CD70EB857BBEE759452EA7550F3367D747AF7177558C747D4B1EBDF9452A7A7694503654A7735D8E9140D18F8B8CA2CCB4894658F12CB2F2867DB829394A4DF18B154C1A23CE72CDE57C707EA2B255A1A36CD581A2C161AB18366DDE675CA09E729AFB442FD6E78D090D4C640D755BB37BE58A79CF5822EE9FD89EAED79835AB77F4AFB1F7CA752763A532DCC644D4969A7ECBC6075A3221A76EB8D49CD98A424ED2039B000D2289A91595469F1CA95CA2D8D687351857A5E36C89074A89A363F5F175EFE924E3F6F948E3AE949EDBCCFCDDA73BFC13AFAA4A70C8CDD54AFC189FA7DF79B140A4B7905B996F5D60D04508D429394A424C5B6B705FB49DD3513374CE0941467D8655421D386B3E6AD54A12599BE60A3C6BC39DD8078961A1D78816E1E3A495DCE7852290D2E5487539ED31EFBDDA67D0EBE41BBEC7DB699B0ED347BDE46A76073F336ABAA32E276E35006E56D53912425E9B74A89F69DB2AF34120916EC4B2305CEBC5CB63A5FBDAEBD5F431E794D5FCE5AAFA51BA5218F8ED3317F1CAA7627DDAB3D5ADDA094BDAF54DB131E538B23CD844D3D4707B4B950BBEFD54E112BA2D2E018ADC0F72C5771611159BBB26A149CA424FD5A8905F9607DB0A669184FD168E0234295B17485C545622215D334AF30A2556B0A35E6D56FD4E5A4BE3AA3E720CD5F1355BE255C9E29FDA1CF8B4AD9FD7CD5D9AF8FBA5DF6AAEA36EDAD63CF7C4E7576FDBD5276395237FFF53E85CD0F2D2D2F564E8E21385696A71A17494AD2AF91002114F86835C118BCE2C43B87C1916B76D7945594B85D35C5A56167569644CC4F5C9AADB4F5D2C897E7EAC8636F50F72B1ED68857BED1ECD5157AF8C52FD4EAC441DAFFE8C1EA72EE8BDAB5F54035D8FF5AEDD5FC06B53DF27A435A2B85CBAADC8E9C82C26C1515E6D4A80754E3224949FAB5910722C4FAA05BB0AF6269625B0D09203122016CB4AA4491CAB00A42C50E440B16AFD537B33334674144CBD74A175CF5AC5A75EAA794DD8E574AA313D4A1DB4DBA60E0BB7A7C6C81CEB9FA23A534BD5A0DF7BB56293B5DA4D4FAA7EAE46EBD9D891B8E94285ACE728681BF64EB2671EA53A332494AD2AF89BC69EA29D8C2566AB7B66FAAB2193C5492AFC250B66944F3E94C332E5DB54EF70F7BCA54D741EA3BE0590DBAF75F7A7CE47CB5EC749DEA343D4729BB9EAEFD8FB84EB73DB940839F5FAF632F785DED4F7B4AB7DC3F5FAD0EBB4B75EB9EAC4913D798CF59A10D1B365831D8BD5B975020D62D6B54244949FAB5917F1F3152556140E4E5DE00881591402B458A0167AD67D8DB66FFC39664757AB6E62D4B579DDD1A2BA57E0B03E4A1BAE6D63734F4A989FA60E616F51DFAAABA5D31421DCF7E4C07751C6C5AF2CF4ADDB7BFDA9DFC9CBAF57C4D29A9A7E89853FFA290612F1CAD525E916946374FB4B5BC8AD20098352A91A424FDDA28FE5DC4DA4B169E22863AFC455EF60D34A8F98865154E23161B70D6659768F692753AEBBCDBD5F796314AD9E524BD37A558E317146B8D0176B629BBBB9E9AA17DDADEA994C657EBA0CE0FE9A8D39F576A93AB0C8CC7E9F5B7A739BF333BBFC0EA124C06F1890E5F7E655950A71A954A52927ECD145886C179555900D0F2B069460308EF239696855874706FF57FBF2A4DCF8E1EABE75E795F9B0AA4CD2169A361E6DA21A374E55F5FD1A1A75EA7B37A0DD3232F2FD4F54327E8D2FE1FE8CC8BDF57FFBBE7EBC57195BAE6CE6FD4EA889BB4CF41DDDDE40F93429BB232F04655163553385454ADA53D559F242949BF768A3ADE370096182A4D45059BBF0320029022D390C5664ACE5FBE56431E7941471C779E52763B52071C7A81DEFE64BD5EFE2CD3D105D7BFA6434EBA5B297BFD41297B9E60E6EB31DA7DFFAB74C69FDED55D8FAD56A7D39E509D3DCF57C3C667ABDF758F2A6278AF8CE6BB195ADEF4E0FD46FC46E7CB56C45E58AE4A4EE024E93740EC3D6507CD36F1E6AB9547A22A290D2B6488C18B5CB5216CDAF04BFDAED3254AD9A98B1A343340D63F53F5F7FC939A76BC525DCFFD9B060E9BA31E7DDF528FDE637570C77BD4F3CAF774E19FDF56EF5B27EBA2BE6F2BA5DEC94A69789C1E7EFC236DDC54CECB1E0A8732DD9B1E19996BC59B1A4C22454C1303485F9F1A954B52927E6DE4DF4384304DA18AB00124D80AA3BC9C42E723969A469CCA6E9AB552EF9BC768DFB67DD5FEA4616ADCEA66B53F76B881EB52D569FA67A5D43D5B879CF0B00E3BE1495D75E3347D3C457AFCEF6BF5CA5B25BAFD81AFB54FEB0B75C43197EBD97F8CD7966C53BC646E05555598ADAB8801912D02A8E840335AA8FEA64EC206242949BF1A3230628E062669A5CA4A428A9698DDC84C8A81313727A48C8C3C6DC82CD0EA0DD24E8D8F55DB636FD3A04716ABE735F8825374E97513D4AAC350FDF18A37F5F8E81C1D72F4631AFAE45A753DEB591D77F6333AF50F4F9AF63C55BB3639D6C0DA5C57F7BF5DB8A4DF2F4D73BB77F82C234034496000C42C35E15019334FE3A8C6459292F4ABA31818C56C69285FA545A699CACB0D90652A0B4535EFBB65CAD81C52618925AE7F90CEE879977AF67D4D87777B4ED7DFBB5AFB77784CDD2E1CAB51E3C23AFEAC6774DAF9A3D4FFAE19EA78EA089DD6F365356F7FB376DDE742EDBCB7F98F294D75DFC3CFA8D0C097BE699DFB168EFF181CBB7900235A717B5BF2B689F825C9BF5396887EE85E927E39AA3D2318EC62A999E697A4EC6C5E55325D14ADD4C6F51B4C399A76B22A326953522CCD9FB7549F7E3243A975F7D6BECDBB9B66EBE026645252BA28B5FE9FD5B1EB433AFAC407D4B0C91FD5AEEB353AECE8FE4AA973BC0E6CFD17D56DD04D0D76E9A6D406963EB5A39E7E7A0C38976150FFFA68BCFBA8311334951568C6D2EA3734B6470923FF5D72FBFAFECBA089FF6665927E7EF2EB74B54108C5AFE1793EF825C6AB360F86C321073EEC526654F3F2B768D37AF701612D9C9FA9CE9D4FD17BE3A668BF03FEA826CD4ED11FCFFBABBE999DAFB9F3A56E67DF6D28394429F55A685586D4E3D23BD560CFAE1AF6E8784D9E56A07ED78EB0FB07E9E2CB0729CC2CADA9C1EF172D53A8887544F3150DFC91D2223BDDFABAD4F62861E4CF4D0C581264FF7789B1E3B7233C40F982DAF6BE31FADF22CF3F31CDBCB52EE5256EF6D27D56B1AC4AC5C5856EA981EF987EF1D97C43407D6DD8C0E670E9D597E6DA7523450D50D7F51FA6523BDEF3C04835D8ED609531FB69190E1FF1826EBF7B848A0D6B5F4F5C2636F20C1870A73345F9B3E4FBC5DAB03E5DD9599BAD10AB438525B0B22A225B17F9B7470923FFD7281EA849D0FEB214AF75FC2B47C1AF2CC1AAFC12534425D87F760E28E3BF98FD739007A32BDF8058E5162C4C2B5585955F58A039DF2D74BB61C67F3E5375EAEDAE5E570F72EF187E3C7EA65E7FF50BD54969ACBAF553F4F22B6FB8C997FAA9FBAAD4907AF0EF5ACB0C5B3351531CF06EB9E51E43CFAE814368656564AC71DFC7410B7E3B7BBA0131A2C2DC2CF1C90EEB045584C32A2B8DA8DCD08B0591888F6B5CFCFFD20F01E5BF6DBE26E93F4F8C67A2318DF70B8B511116822F6AE71B6F56DA3F7E08C6980EAD10F7DC7F83E2EB17130E2E049A917A469D669C30F1732D5EBECA69BD156B36AA43A7338DFB7753C8AAB839AF42E919619584A4EE3D7AEAC5D1CF2B357577038F94BEB242118BE783E0D18AB0BEFAEA0B4B57A67A751A6AF68CB90E8C9919EBAC1C039DF9856BD7AC70AF47F11539666F01A3DFEE9668AD339E1246FE3B547BD0001F1280A3A7F8FBA4270EA9EA7F95A7B4B424A17943C7462234B6667C927E5EF2D3F1458561858AB78E6741016B6851F1222E0BE87CD4899944EEF9B7E713BD45FF9F26782AF6536B2EE4E5E569EAD4A95AB26489D6AF5FAF52C344BE29ED5D7639DC7CC07DF4D1BFD6286CCDE8D1F3567DF2E50237F379CB2D4F38C0965A361FBCBD420D538E53BD94D61A7EEFFB42C9A7A4ECAC871E7CDCBD74C17ED6E067DE4CF8444DF399269E3A6DA23B66676F515E6EB6A1B8CA9E0BC0F8639430F2A79007952700183695CCE70A824F166C05577C3A9EAB4D3E1D143F41C03EBECD9B33027BDF4089E9137F3F49FF394A3416F1C4D8F125EC4D1B91FE0641A3A54B973A0644F097B1CDCC1246627B3F7F2E4298BB195233917373733577EE7C4D9EF48DAB5F69D8C062405A9956A1A6CDCE30AE6FADBDF63A4F29A9871B30CF526A83232CAE9D1A373DCD8E2DB547A3AE6AB0532735AC778A764A3951A9295DB453FD43D5B47107D5ABBBAF060F7E38B66451A99CC25C67F686303F4D136EC8CC087E89CAE2625F9A73A1B0B050E190299C9288FB8C0740B650A30D352EFE1D62E03C086BDFFBA904D87272B2949EBEC60678B1962D5BA2152B9669C182799A326592BEFF7EA1962F5FEAE2B8B764C9F75AB870BEE6CF9FAB458B16D8F9C21FA4050B6AA659B46891E5F97D352D5BB6C2D1D2A5CBB578F1528B5B62E9BEB7E716398A7F96BCA0F9F3293F31CD9B37AF06F9677E29A28DB439BEFEB5FBA1F6FDB973E7EADB6FBFD5AC59B33469F257360E5334EE9D0FF5F1475F6BCDEA4C7DFAC9972A2A2AD22633D55E7E652C8A40A192723DFFC2284DFB66B696AF58A36FA67FAB050B97EABBEFBE73449E90EF17DF5FFE9E8FA3FCDA7543CB7124CDE2C58BB57AF56A77FCE69B6FCC14FD42B367CF74F55FBF7EA3962E31B3D4D812A32A6DD566F5ECF990EAD6EDAAA33ADEAAF3CE7B429D8F1AAC94BAA7E8946E43D5A8C91F74FC0943D5AACDC5EAD4798076DFE32CEDD7EC0A9D70CCAD3AF9849BB577B323D46CEF133468D0D3AAB036BAB741CC2CDD94B351ABD7A76BD9EAB55AB8748581D2CCE2720CF5C09DCC2BC8773FAAEA79FC872861646D8A97943F06BAEDDD271EB3017361F9F2E5AEE3274E9EA429D3A66AEEFC794A5BBB46E9EB565B9A1CB7A3DD870A6B79388C195B16DBC9807F12F806FE4729FDB513447494491DE2101284D8EB2A6E6BD256073FB80EB62B05A1CC99C2E415F83D483E3EDF0E99CB6DF166569B06E07E6C62C205EAE8835B5BF2F509FACD055F1FFA21662D54B78774FE87367D9D7D1EF1816749E7D3107C3AF28C3F27C4C6C205EED1FF04EEFB7BBE8EFEE8FB048A49EFEAF6F12612F1E445FAA8C5638191159A272B4BEAD2A5BB5BB3AB5F7F4F0740B44060CA55B9677C39F175F5A6657C3AE2E9634C40C8FDD29359436C6B735C4EFD8CF143454C163121C2F20579D237615594613A57AA30DFF8CEACC5CB2E35E0A574D539E73EA0DF9F3F5CCD0EB8527FBAE40D753AFA215D72D9EBEA76DA30FDF98AB774D6D98FA8C7B90FEBD46EB7E8D28B87AB61FD4E3AB2DD796ADFF66C0DBEFB3E573416009A915F2CAEA8C22467A228AA397366ABA020CF298E0913BED2C71F7F644265AE56AE5CEE140726F3871F7EA8F1E3C73BA1B369D3263F0E0E23DB806647895F64E5E83BCEC733E05C5310D79F7CF289A64D9BE6241D40CCC9C971F75DA7E3E09A4AE7A798C311CC0C1E09069C41E43A52CA8F4B06E610A02484426177BFA6C36EF99944E2B7F198B562203C854CE3061F8A0DAE31753169FC40E3AB06F7CC7CE6DB9866FF735E66473AD920A44825C0B1F30A3EDB10E4451E30006DF1CCCD35EDF3F11C0326090240F20C49F00023C433A50FA4E599F83C102E1EC804CA239D8F8B7FDE07FF7CBC4FC5797C5DE84F0FBCB8E25C9C1762413E41DB49495108C147878F3110B6D201071CA3160776D609C79FA3C222DEAC0F0233AB3ED066CAF575F2F5E53A5ED07810529E277EDF90718EE0ECB90A587F84827D9F8C6B7E41B609D590090EEB677BB42047EAD7E771FDAED59F74C699C3F4FB1E7FD349A73DA0AE273EAC233B0FD319678DD11147DEA733CF7C5207B7EC6D88E8AC8E5D2ED7157F19A2A1F78E527EBE34737A9ABE99BA4CDF2F5EE18048B1696BD2DDECEC071FBDAFCFBFFC540B16CD75E0634D1330AE5AB5C2D177DF7D6B96C52C4D9E3C51EFBEFBAE3EFBEC33A7C9B34C72C5BFD348BB6B00ECA7121DEA8115EB44A701015C7676B6D6AD6396296028026960009EA122FC9E1D0E3F8D73AADCFADBFD8C1DFD6E91E5113B71C7AD1D0FB1A0CA8F504225C56167873340C54505E61F0403C179A4B4D880C8C65C9E2F77E70C5479994934031D839897BBA53A5D517E9672B2331C1517E5BA0F07318356561E8AAD5559394625613617979B1F906F6D2B777E0A134FB42FBE3F380210DA8C1F0DC5A7C1A7A6BFE88BD8C0B841E219D240A4F76960569E09264C0210622212E28F94E7C9F5732C3DCF921F82D4E7491E3E5F40E7051C9608E71C01225A323737DFD2F35B13E6FB448A8086DD931AEDD146FB34E9AA638EBED2F956F5EB1E6826E226CBD786D2C6ABC8C6823EDBB2654BF5CF6A5326449FD0171CE113EA4C7D03DE220EA16CA69F8D2B63EB6624E103CB9B710F6628A3CACFDBA2A52B1669F3968D8150E2BE29CD938FEDAB5D1B9CA6830FECAD534F7D442D5AF5D72187DDAA3F9CF78A0E6A758F3A1E35427BEE79AD2EB9E89F6A77445FDD39E4356DDC52A1759BF3DCEF617C3571BAC68EFD4013BEFE4693264ED30C33B9F145376CD8A4356BD6587D1132F4538929A00DCECD5ABB364D19191BDD356E15DA71E2C4AF357DFA74A5A5A5D1BD09B1B44DE48E504C02575F33B0F926423232321CD1E968483ADE33199D0C2370C49905B048160089A38B76048F4C1B13DC40DA9F78CDE5351ACCCFE0708F78BFC6E5406747AF05839F7336296C1A2E1A354674262668376DC4CCA069B832F753CE411C441AEE41AC1B71CDF3A4452B5246981D15AE2C345650A6D314C654742AEDF48C46209E3E22DE0B26E2E243C07C81E6F71ACE07CFB8F45D7CF0E9B847F0CFFBEBF87C38A74C7F8FF23887F17D7D49431EFE1E47DAE0F309EA6CC0AC28D4D265F3F5D1C7FF324DB29BEAD5395875520E516A4A7BBB6EA9F6EDCF766349758BDCD247D05704FAC1D793730265714E79FE1AB2B36A66678C6393762EF8F630CFE0C73F14C9721F92A23D33BE59A401D73DAA268DCED4D9673CAA6EA78E50C74E437468BB5BD4EEC83B7454D7E1A6019FD461ED86AB53A7C74C3B0E55CBD6176BC69C2D6E6572FADCA99A3CE34BE59A802660A22304F8815304544101938A59FAE8A38F9C1FCDF1BDF7C6E9B9E79ED1A79F7EEC342100F49A7DCB964CE7EF820D0B0E37B1F174E7B4BD1A50DBA358876D73EE332213E2376FDE6C6A79959316BE537D604049E3C114742A72B5521B3336289BC55153895C732C2CE663B1C628A69D78FB1A53911733D146FC1E1E475ED2B4A1AA8E2F0EE7DBE0049215331629EF7DC7801128336ADA2EC7818A673C931415E73922AED0CA24AEB8284FD959193608B4D3D214120F830675A71DB54D281FA8436D868B0F3092EF231887C075CCF48FD539B8E7D3F97C7896FB3E7F0F741F3CA0086849EEF9FC086825EAE7F3E51CE148F0E962635B1DC88F7CD3D26C7CD7AE70AF014D9F3151FDAEBD462FBDF48EDE7C7DA2DE1EFBAD9E7F6EBCE6CDCDD13BE3263BD315AD882B429F61FAFBB61228CBD7C1971B7F0CDA84D98A10F7FD8C898E560D8420443C8A00E19FB66E918DA1591465957AE6A9B1AA93D246C71C335007B5E8AD66FBF651DBF637AAED1103D5B6E32D3AB2CB50B56E3B5807B6BA5DA79FF5AC1A35B95C8D1A9DA1B90BF2659E91C21505DAB879A5667F6BDA6CD51A4DFC6AAA162E58A22993A76BF6EC396672BE6F3EE25C3343E7392DE9F7C0A2F97C3BD7AE5D6BBEE30477A4FF2C54E38A3EF5968A8FABBEB93D8A6936771E1BF4EA7B6478D34D37999F70805AB76EAD3A75EAA863C78E6AD0A081D390308A670C82EF580869160A176B4BF666035C58E9EBD7EAABC95F6BF6BC6F6510D26D77DCEEA64C5E1C33DAED80E87DCDB50E3A9F7EF58596AF59AD7C1B94A10F3DE03E9170EFB007556C12F4F3AF2768F8E323DC73D70F0C9E7FF68551EEF8CAD857956992EC934F3FD3C44953B4252B47AFBD3ED606CE06D598A6DC4CB2EC1C1B50F30590FF9C23FD08CCAACE9D33CF0D02E1A5975EB1B649FFFAD7BFDC6414B37B4845DA3A6CD830C7648F3EFA6835B8C68D1BE7BE0A76FFFDF7BB3E19326488B31890A83367CE748CF4F2CB2FBBB4CF3EFBAC4BF3F1C71F3BC1B662C50A4D9A34C9DD7BF3CD375DDE983B083FF2C00721FDADB7DEEA0677E8D0A1AE5CCC5D02F57BE595571C733FF1C413D540A36C988480B426FDEAD56B5C9B61AE75EB36B819E5CCCC2D666E65DAFD408861B267E798F593B5C94D60DC7BEF70D941C31E1CE92673DEFCE76766F5440CB41BF5F0F0475D5F5E7EF9E50E60F7DC738F735DFEF9CF7FEAC9279F748CD8A54B17576FF868CC98317AF1C51775C51557B83986860D777280E3F8F6DB6FE9DE7B86EACE3B06E983F7DF51B3A67B894DD8A975EA3A8DB53E7D938D73545979F9CE5F3DEFDC81DA7FBF33D5B9CB001DD1D9B461A7DBD4F6F0FE3AEE94BB74F8D137ABF921D769D72657E9F04E4395DAE05CD392B7595DAED7238FBC63829E8D01CBCCFFCCB2BEAD3017C8C05918D196CC2CE566E7A9B830643EABF1313F25656597197A0BF28A5DDB5048E9E9E96E4C11868090F12130763101548DA1784A18194F317FA3461C4CC0202F5BB6CCA9E7112346E8BEFBEED339E79CA35EBD7AA96DDBB66EAA9940A5D08C1C3129F01FF0B59C4D9DB9514521F3C5AAA2FAF4B34F34CAC071FBD0FBECF8A61E7CEC29A56DCCD109DD7A68CACC25FA76C11AF5193048AB37E5A9ED51C76BC99A4C5DDE678066CC5FAEC79E1DADBFBFF2B6E67CBF54D7DD7487328C1906DEF6A03665477559AFEB3561FA2CFDF59E217A60F8130ED027763B5B052551753DA19BBBC635E58844E4581CA9D2D4E9DF5927A2D5AB1CC321E98FE97AA23BD6ADD3C00DC205E75FA437DE78D318659C060EBC493366CC708CC44CD9CD37DFEC2436A081C100E495575EA98D1B37AA7BF7EE0E5077DF7DB7468F1EADAFBFFEDAA59F3C79B2FAF5EBA7CF3FFF5C83070FD6DFFFFE77BDFFFEFB8E9999FC6AD3A68DEB4704DE4B2FBDA4FEFDFB3B80CD9933473D7AF4708CF0E0830F3A4148006030FC35D75CE39600BA76EDEA8E0093B2C91BC6813233331D1891F08011FF302FCFDC0803274B3DD3A64DD79CEF66EAD3F11F3953ECF1C71FD71B63DF52AFABFB6889DDEF79E145FA76DE42DD7AFB1D7A7BDC3B1A35E61F1A3CE42E13B659BAF1C69BB5266DBD1E7BEC31B74C42B9B48DB620BC58177CE38D37DCF2059AE58B2FBE70826DECD8D7AD1595268C26B86381016D5D3ADBCE8CFF962DB2B8A872B27883D7DD760BF53DCE6512A6856E1CF8A22987637454E71BB57FAB5EDAB9C9F9DAAD510F1DDCA6979A34BF44FBB6ECADF69D8768AF7DAED6393D9ED6DEFB5EA406F58FB1675A6BE04D773B0B6DFA8C299A3563A6664C99AED5CBD254546056053B0762E5F162F29CD9F3B47CE92A270C70BDE873044FBC75C118C46BC0ED51C2C878A2A3FC391952180CC68023B9BD69C1002301201FE7434CA35A08CC0ECC553463714991D38898A400B2C0EA3F61C65C7DF0D954E599BBF5FDCA1C7D36E17BADD9688018F6B26E1BFA8CB24C0A679855F5C197F374E57543B42E47CA340576FBFDCF2B64C58E19FBA172CC0D7C7EF4077AEF9399BAEBBEA75C3CFA3DA5DE1E2A31C0DD36F821356DDE464556DEFE2DDBBBCFE81DDFED8FEE3E715985511DD0A29DFE7CD5F51A6D66588B16EDADDED2BECD5A6AF42863101B0CB7A1C48E80D30D0E076B3B6D45FA797F911093864E03900690728C0D50F539C439C13F13274DABD3C70F74F01DCEADE9191BCE57AE5CE9AE798638C684B1E49A6525CC27D2B060CF58F28C1F367CA2F8C0040E9339EEE3BFCE4F0FDACDF4BE8D9C35BFDCDC0513AA6622862BF8CD414BE728980B58BFCE8483352B66AAB9B2FCA4527CA08EBE1D046F45510A73049830FC0A1420C4A72FC8F73B5CAAB470DE129D7BEEF526285B6B97065DF5D0FD5FAA4387813AB0E5D5DA6BBF4BD4BC6D5F7539FE4EF775EF030FE9A303DBF457AB7683B44BA33FABE1EE17E8F85387181A0E57BFBE0F3A50E7E6E7595D62BF85C190588369FADAB4744D993455F3E72ED2CAE5694E6B024C261EFDD8313EB485EB18EF3BEC70FC214A18599BC808958B5467C9C2CFDC51208C458839A6D5662915A152101522DE6D7773CB0554D0FC3FEB50B4A35BE2301F6F55FA463D3DF225F5BBF10EE5599277BF9AA71BEE79566B0D5CB70E7F43CBACEF4F3CFF3ACD4E2BD11FAEBADD5D7738FD0A773CAFCFDDC2F3B9B0F71D7AEDE399BAFECE511AFAF83815591FF0FDCBBFDE35483BEDBCBF3664942AD7F8A05193DFE9DE079E57CBDF1DA3534FBF5877DE3D42235F7A5F279ED653AFBFF999F98ED26EBB1EA85E57DEAC91CFBE257E871D00EEDC700F9586A3FAE2F3096ED9C5CF3AC2C89E71D0FC081CCEBD6FC9118B82BEA0FFE80F7C35FA70ABB00AFA94E081E7FB932396086991C010F97DF5D5578EC961620F52D2301E1C7D7EA4F1790142CF283CC7916BCC5BD2FBF1253FEA487AB72616315FD3DA929F9F6B82B44065E6BF87AB8A55AA908AAB0AEC6F9E79F121852AF2158EE2D3FB7CC36EE69BE0FD53CAF2E0447051166BCCACD3115F58586C7E7CF0F36BF90525968F2534E015E617D87985B2B237181F854D0020C865E3B14CDD4EBB55B7DC32D6AC8349BAECF231DABB592FEDD9D4C0B84F1F1DD4E6161DDAC57CC4436FD21ECDAED61E7BF7524A6A77B7DC7154A7EB0C091DD4E7DADBDCCFB5515699594780903667AC5FA7D9D3A63957A520CFEA4F5D8C3057DDB9D531586E314513233428AB00FE371E77841246D626068C4E64B9C2FB41749E9762300E6618A60FA6D8238F3CE27C1D7F1FA6E159163F597361FFDED469133463D634CD9E33CB494FDA3479E6428D7D77BCAEE873B303E380BBFEA64FA6ADD48D4347EA8AEB87EBBE273FD4883113DD8F8CDC307894468FFB4EFDFEFABCB22D6DFF3B5F54811577DBD07F28C3AAF8CEF8D59A31AF58FBB538DA81B15EFD5D74FC89E7A8FBB957E8D0C3BAAA77DF5BF4C2C8B16AB0F3BE5AB0689D39F8875A6FECA6BCA22ABD35EE331D726817DD71FB433AA4F5516AD6B8A5323714D9FDFA1AF9F7D1D55A31541C6C6D22A03D9CF4B691C9CDCD360687F18319E0ADC72078A0C56B0AE2E827B427A624FD85F0638118B0B0460548BC4FFAEAABAFBA31E11E20E38829CBB8000088F41CC98F00A8484B59BE6CCAF4E9B72E29040BF13C87E98BF60C34B031969B2433609797987E623344B9C29556EF4A036465915920762C37615369FE65144D1ACC1BB0158CBC314DA92B429CFA730F9EE21E02C6D7CBB5C38EA56C1D336187B0A6AF996D271E8A98B62AB1EE3FFBF7BDD578AFE39452173A514DF7BBCC2C9BEBB4F36E57E877870D56B3030668F7C67D94BA2B00BC4C2DDB0C56C7CE0FE8C083FBD9F5F136AE87EAF2ABEE57A199480CEDFA0D9B5D01B3667DABD93367293FDBFC65DEBEB0B8C2FC22656FC9715A12C0F92304F07E0AF86A53C2C8DA44C7D0793008CC42C711307F9098BE03095EEA13308B78D607D47EC0A43063D486D63AB734E416FC172E5AEC40F8F08851FACB35B76BFABCB5767DBBD66444F5C013AFEBEB99691AFDFA24BDFCE654333D47AB77FF61BAC380F7E67BB3F5C957CBD4E9B88B34FCA917D5E786A1CA359BF4963B9FD71FCE1BA0175EFCA7314400166ACDEF2620A437669A1962D7C5610C2DEB64B365811535CBCC2A74CFB866D9911FAD5D386F59C0014639D9C6B4019E5C603302E9616CDAEE350B121F6D861FC46409DBB4D8C6C5A4CDECD9B3DD6608B67C6136728EAFC8C40A71F42BF911605200846F4EC0478C0F9EA9191BAF096178E249CBB8F93182F149E7AFBD60E0E84101F13CF5C684659CC903ADC87211160EBE3E4B53D966CE15981062028DF9F0B08D31E4FA9A17072D0048CF37F1E6BB0FDC27D05ECA8548076F646C36FE2A0BBB19F64815DF3535CD6D6DC5CFCF292ED3F997F4372E6EADD4FAC7AA45DB1BB4F35E9719207B689F036F30B7E32203E240EDD1A88FF6DABB9F1A37BD557B341EA8E607DDA6C67B5FA5FA0D4ED59E4D8ED36967FDC52D67B0C5EDA34F3F31D7699D1B2FC7E756B562D3C6A102EBE37069B0AE691A9A63F6962C039FF59FA571C704D8F9299430B23601283A93D922A435C0F48348473288749E97C49E217CC7FBB484C0E730D3ADA2D43A39E43A9CA140FACD5AB8522576916B8F715CB46283F3F1366DB1FC0D29FC4865898D0260DA62CE333911C731638B9937966F9A4970062A33DBCCA55293F8766FFD863556B7CD6E3DB32854EC9808493B6FFE42337772DD8CEA8A956B34D59CF5B0752ACFAC4E5B6BCC516ACF0596009198A7F83F009159469A89894A3B69374CE4850F8CC58C20135C808C5D17F8D84C96003404154788749F7EFAA9B32E98D860D694891D8E1F7CF0819BDC60D674E4C8912E6FFA973EA75FB140BCFFE5FBD9838DBAF8FA0028CEA9A79FC401E45C7B0182804078F8B4E4E3038CC98609B42360E4B9B2F20A33216D6C4CC0E59A29C9DC466149F0FD51C693BEC6EA4100B324411E9445DEBE7EF49DCBDBCE11983EC0277905D96E298B9F502B2D2F54B1B698E62D32E31403D55C8F214F1A07B754AB43AF52F3167D4DCB5DAA238E7D4CBB37BD460DF7FC8B3351F7DEF76AEDD9F812EDDEE8421DD07C809A3435ED58E70CD54D3D41BBECD659F5766EA10213C4EB32334D0863FA1A0FAD5D697D59E6C688718FD77668768873DF475E18FA342CA9D11628B6A5B0069EB6470923B7478010868AD7866E50AC5274280CC8395294C1F681E7A82C148091C699A6AA0A5EBB2934862F0E45B4D6183CC78CF6023347726128933EFC4E02E0E0951C76C4F85F112A8F96B82353EDEC92E19AA9EDB01D498FD04013E383F06269289CED3A3ABFD07CAD98C465E288ED78C57C31CC95633E9EE5C22F055147BF8EC5822D26281A114032EBE8CD53DA84F6E0489B39D217F40F830950F0DF3867B335C07CEBADB7DC343EC01B3B76ACDE7EFB6DB7B4C13D964BD08E4CB030BBCA39606429807D8DBE8F190318195032061C89F3FD4E3AEAC03D00CB354C445DA81FDA997CA857302ED5930DD581FC49E3CD61FA22E853EB07F39561367ECC85FE66EB9B25B56B036B2C8E5D558C1B263AF304940B511EF5E1E8C11898C8EC580ACA834F36673146E55AB17A891D235ABC6E81FD35616355E979E99D4A69D059A90DCE30BF7F90B921BDB573A3EBD5F2B0A1C6D57FD47E07F735D3B4BB3A74EAA7464D4E569DD4C30D84471A083B98166DAF73CF1BE8E6062C38DE0E9599F999B7C9F8107E7102CCB9673101B70D16E229D66FD5D7FE398EF1F13F4609237F8C90A89852985C741C929AC291127EF060043A1860326D8EE465E0B987A39E95B5D981C2BDFB66838AA3EE7EA0A4B24C45A5C5EE1EBB1F8A43F9AE83DC2F0319B0D8E6163629CBD628DE17E388F9C426627C43AC8592907502DC00D92903CE5A2279210420A4B503584E96630A88A5170886E3886FC4648CF7FF8C5F8DE9C3C6F4998E69BCE6E0591F60D0E5CB57BAB706780364C99265D64F0B8CF96757BFFD0001064C5388A97C008966FCC73FFEE1C0C772C80B2FBCE03617BFF6DA6BD5DA953E8591F1E1E857EF2A0032CE39323E583100D49B99F4014CC3B3AC8BB2FC82C0223D33E4A48D318F1B4F4F8C2BC294407BC99B31262FFAC092B836738E0F8DB0C2AF436B62A6F2C27156CE163773CEF3D403DEA01EE40D2108E00DF2A67D31CDE3CC535E509E316BBA09D13C074466CA4F38F59A98AF77A2F9FC176B975DAFD501FBDF67A0EBA57D0FE8A5BD9A9D6FF73A18F87E6726EB01E63B1EA833CEBA48FF7CE70BE5E4B183C8144451E07BFAF72E9909862FB6EE3D0E78DD6B362C20267338C7242D2D61522AB8F79FA28491F1C400C5239C81F0F174EEC489131D43617ED199302680F38CC13569195066C8E86CBFDE985760A65A66863311D3D76D52FA9AB58E412006876700318CC200B23998C5D5E2423389CD2C0ADBA017E687B4717DA68BDF9091EF16F6376F2A50EEE61C65589E9CAF4D5F6F9D1F75C04308B081973A520EF9B2B6969393E75E02CDDABCC5AD67C110948B2540BB20D6DF48C700D10E8207229336ACC9717FC284498E39097EE3358309D3410418DD9F13606ECAA4DDF4256B960016204200944DF7000933133052378E1E9080936BEE3399C3840DC290BAB22E4C3C79E3A302560F320F3A02E3CBB8429C134FBD48C3C23FCFD32FE4CB39DF7AC932CB81CDF8A463BC387A5031C66CECC8C9CB76F78887E84FAE01256D278EBEF4FD40FDD998B1DEFA1C614D4FAD4C2F50CF4BFEAA5D763F56BBED799ADAB4EFAD835A5FA98E470F529DFADD55AFAE69CABA872BB55E6B9D74724F0D1EF288DB88C0B3583E087E8E816035EF93ED906EA924E0EDF8978063E31AC4DBD8F9F3DA8412F8B10F4DED28258CAC4DF160AC15E7188A01C3D967A708E044EA7AF3874EE51E4C82B6C0315EB76EADC5AD726B8CBCEF95935BA86CF301B336651B88CC94DA98E500B671DD66A5ADB6E78D962C65AB5DBA0129CDD1CA95AB9DB9B8654BB623F60966E6E49B2F6900CC3040E56628376B9D0357765EA6D2376D56E6A68CE0DA1C6F7653302BB63E7D8332366ED106F3055943223E7D8DF9C6EBD9080CE3855DFEE906E88D1B331CD8FCCE1CDA0D9332B8CE14B351E772D2A429EE4808B6E405F1F419E4191EA6F6E69A0703C18394FB3026DA04E0D077F87468482C13342C7E1E1B08D0BA808C091B2C16883840CD7DC6052DCB2412662BE341A02ED4C90B150FC0A05D41406005C732D7CF800830AEB771DC9CB9411BD6A7695DFA2A231312EBD3AD9E4C58A5599F99203310B266C7E2BF171A6862AFD5BDF045B0F0BE2AEFAE72CD8603ACA52FBE9CA4706985B56DB1AEEC3B40A90D0F30AE6D6E1A8F2FB6B5749AAFDE1E87EACC0B6ED0D857BF54A8101F2FE877C605F72552860503604CDB1B004325665D95E21E6D5D43F794683634F692708DB8DAF49F0064C2C81D250610D0C12C3E30504861769530F9C0B6AE2FBFFCD231038C01030156243C0C05F3700D83C168100CE3198D5D19300FC43DF2F6D74CB9FB174D7D3E3F449E49E3AF993C81A88B3FF7E988836072EA4E5D6062DAED34751C88602C0F22D6FEE81318CEDF47E2C3E83CC339478008D37BE2793436F708A4C74F44C851077C48267A00153B9C28877EC6CCA58F3165E9EF60D3F27B6EDB19CF13CF7358305E4342B401C0536E3CF87CF075F201203136E4437D38A71F7DFF11E7FB9423C200ED4E5DA93342C10B6CDF06FA95B4D40B4189C05C9BB64613BEFA5AEFBFFB815BABFB7CFC173ABA7357E3D6C6DAA3510B5DDDE7568D79F95D4D9BBE50C5C67A4CE8E1A20480B3BE8DBD8513EC2B36AD8F4B62AE0DFDEE03022836360979FB97A08491DB2398C33315D73486C1F40C57BB71A4039C98AB9834800B0662CDECF5D75F7793166CEB62CD8C890C180802C44C64C04098663014CF10EF8938988E74302044FA1FA2F8B4107913CF5A1E04D342F1D730393399A487B900986750DA0B786827F1B41510D24ED2A001D0665806B41FFF8D74101A8F6B8E6802408E5919580EEB1C5810745C13601EEEC3D08092F63309C4AC2B7D487FD21E181D502038D036009E401DFDB91F3702E6A1D7D080138D4D9C7711E2B5320212F0FB71F2FD495F513642813EA3BF7C9C27FA99B4A40190B48173FC64DAF1FCF3CF6BC4DF9ED0E38F3EA6912FFC5D6FBE3156635F7F5373669BB6379A3DF35B130EB423303B99034073BA73FBCBC45B857BBBC6F83362ED091598F988503341675A8B790578375E10D236AEFF57809930329E7C45E32B4B1C47E268108D837C7C6DDA5E63197C808A8663A06130988AC90BA6F121263198756462836BCE8983B8261E866440FD333F463E0F18E0B9E79E739BB39F79E6193DFDF4D3EE0811471A9FFFA851A3DC2C28CC864041B233D309F3C3A80007400134DA82790E000110C0029080836BD241DC6751DDFB728012EDE327BDC803C6257F0002B849E341E28F000D2D467F7A8D0DB37950E19F0170AC09F2A23CCAA50C341265A3D9B13CBCA581C6A26D808AB6DF71C71D7AF8E187ABFBDDF7217DF5D4534FB935508ECCFA72249EFB3C8BD045E0E2F7C60B61042C828BBE40A8D5E60F4FFEA5723FBBCD445CF0C5050352256668A1999C59D56FE47853949974260B999F0826E182FCBC42F95F00603C258C8C2780E4A9F6BD1DA59FF2ECF680FBBF40B1765407069577D430D7606A0F50B40047CFD8DE8CF37E1DF700199A01F39C349873C4A3313C08D028302D160079C2BCAC3D727CE79D77AA277720E2B12E7843836720AF35617E40018038273D262C65A0DD280F331F41013001316DB3E0DA0DE0012F80F5719E76746C49F76369FDFD44E9F057F9FC212F85870D689506BA4884C9C06CBBCDD24CC8019497BFDD97DAE22666E209DE8A6F1BB42375FB392861E4F60889EB250A47AE69583C786814D7BE81FEDCDFF3E9FCF3F171F1E49F8D7FFEE726CAF5141F47DD7DF01A8A405DD14C6834CC39CC35CC39DE5280001726B637E338073C6811DE82409300124C5180813603C4682CAEBD164593A041298734683BCE21E22134289A349EF162F576E7D435519C8F8F27E2D0B03E2D793276FE7E3CD5EEAFF8F8DAD71079935F6D80788A6DBAA8BE667921982CA934DFD04CEB70703F8863D635D8E5150F46EA8D29EECB89AF4BA2B85F8A1246EE28D191BE53B98E3FFFA9C4738918E1E7225FBE6F53EDFB507C3CE7FE1AC68C9FE8C0F4C6E4460B794D84198DE9CB391A0CCDC6C23EE025C4F272F978F2D784DA132CC41317578FEAC03DDF160B09EBBF23B4BDBEA80D1CD2D58EFB772871598C4BA5E51FDC63B6937DA0BCA9E1D378DA9E36FCBF4209237F887EEA80FE9AC9F7058C08A8387AD0781011E2CF615C7FCDB9B7367C20CEFBE19C13C893F35879EE3A51FE3E5DECB9EA3AC65FC7D37F622CB797F77F833C206B13BFA1117FCDBB88F1D710DBF36AC7FDAF51C2C81FA2449DFF6B03E88FB527DEB4F3041021FAC70392749CFB6B0F261F001DC183CB13E90023A615E7FE399F1F65F838D2FBEBF8B189DDAF51C71FA3F8E7E3CF7784E2EA54239EB89F529760513E38F70062D1DFBDB911DDDAEF89F204846CB1AC1DFF7F851246FE9629D120D796BCAC0107EBC035D355A94CEC9DE5C8D7D3985060719909054FCCF4F985E8DCBCCDC18483F93894EB670B3D9196FBF842CE1F8A6940D2C6CCC2EA904840C4B70546264DA2F6FDFF52F001B0E09C0F51F9F3581D6BA4FDA920FF2D51C2C82425A66072A02683B12F33FE1AC2C789673A9E0358049E672B56F0C271E0F331535890CF7A2DD7DEE4DC6A7E9297D7BAF1608A4DA26C53274FB1FBDBC47BFA29C0ACA8B5C384D7893806DFA88D4F57334F2F246A3F0F712F09CEAD9430F2B74CDB6350341CA0F29304F82FF13E0CF7FC79BCD684E1D88BCB1A186F7AF0AB4D800FE24B016ED53A466ECF72EC1C6BCD596C760EE063966E0D30C66B3A8EF1758827181EA003CE385FB4469AEDB5DB1360FAB11F7041F3A3C18363E234DB03DF8F95FF5BA08491BF65DACADCC114391A2DD06A3062603E06BE0BBE60F0763F3F47C0FB7AB16FBE56E7E5B5D9560D0778B64EF2782D08A89DAF687C0A0003CD4AFE81568CD529FEBC469D3DF975B6C0B40DE27E2A93C76B59EA9A48A3F93CE381E5EA5B45B926B0DC827CCD6792F4E39430F2B7483FC6B430788CF99C99E95FAB0AC8FE3A80C1B88149EAC8F9804140BB555415BB772F030D1BACB306CFB33E16001CE2392F08B807F1456E0BD5F5D96AFE6D7F82241E2C9EE2D3C683BBFA187B63BDF6C667F679C62F1DC49664DC79CC54B710ACF3B10BC682BB17FBDCC836E750EDF5C0DF3629E5FF018DE1AB636A9FA3F40000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A340-300'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E3000000400806000000E806C00C000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000034CE49444154785EED9D07605545FAF60301C18E20D850045644504140EC05FBEE8205D7BEBA485151B02E1644AC8865C5EEE202767415EBAA58E9D244AA74088496407AB9B9B9C94DF27CEF6FCE9D70132E8AFBEDEAFEF50EBC39E7CC9933F57DDE3233E7DC1449494A52927680CAA2E52AAF882A5A59A18AAACA6DA8BCBC5C55555596746BA8A8A850595999BBE7037190851AF9D7B848529292B46304200167695944A170898A4B422A292951241251341AAD0625E71E88C4415C03500B35F2AC7191A4242569FBE4B562ED78E2B8E701585959E90820864221151717BB73E2D08800B6B4B4741BED5823D32425294935A9DCCCCF32035B6965D42E95627ACD1DA10A3B2DCA0FCBDD321C462A0C8096B68A88AA804A4245DC92839D9D54462B54690F5656182023C5C4A65490911DB7293C49494A524D029090BF8ED76815E516CFFF6895039CE151D1B20A850A0A559C5FE0E201637138AA228BAB2241A0402DA03DB79AABD50526294949FA612A2F8FD861DB78005569DAB0A0A8303063631AD06948035CA4BCD4E203BFD1AC5995452CAEB452199BB288AACEA746A6494A5292768CA215E6F35596AABC32ACA250BE2AAACA0C83E54651031FE0B454169865252E5C56A470D8706A405DBF3E47CB96A473BB469E352E9294A424FD30959595AAD201AFD428A26855A9F243050A1B003153274CFA4E279C7C81EAA43657C39D0F3184EDA3BAA9FBD8B1B13B4F4969A23A298DD4A9D3C92A2E0A342D133A1C131698A42425692BB94917A38A72D37025C54E23561A1823D190CAAACA4DEF99E9691AEFE3F1CB7464C74B54BFC1F13AFEC4BBD4AEFD001D7C702F753A6AA052538F5387232F57DDBA6D54AFFEFEFAF0C32FEDA99AE5D4B8485292929480F0FF0C88AAAA50B43C6C602C31B3B3409B733355645AADB0A44A7316A6E9EABE4FA8D97EDD95927AA68E3D69844EEA3652AD0F19A27A752FD291EDEFB46337356D7286EAEFD4CACC5BCBD9F20E97169A1F194CE2242E3C49494AD2563230AA2CAA723351CBCB42161571266A71A44885E1724D9FB34CD70EB857BBEE759452EA7550F3367D747AF7177558C747D4B1EBDF9452A7A7694503654A7735D8E9140D18F8B8CA2CCB4894658F12CB2F2867DB829394A4DF18B154C1A23CE72CDE57C707EA2B255A1A36CD581A2C161AB18366DDE675CA09E729AFB442FD6E78D090D4C640D755BB37BE58A79CF5822EE9FD89EAED79835AB77F4AFB1F7CA752763A532DCC644D4969A7ECBC6075A3221A76EB8D49CD98A424ED2039B000D2289A91595469F1CA95CA2D8D687351857A5E36C89074A89A363F5F175EFE924E3F6F948E3AE949EDBCCFCDDA73BFC13AFAA4A70C8CDD54AFC189FA7DF79B140A4B7905B996F5D60D04508D429394A424C5B6B705FB49DD3513374CE0941467D8655421D386B3E6AD54A12599BE60A3C6BC39DD8078961A1D78816E1E3A495DCE7852290D2E5487539ED31EFBDDA67D0EBE41BBEC7DB699B0ED347BDE46A76073F336ABAA32E276E35006E56D53912425E9B74A89F69DB2AF34120916EC4B2305CEBC5CB63A5FBDAEBD5F431E794D5FCE5AAFA51BA5218F8ED3317F1CAA7627DDAB3D5ADDA094BDAF54DB131E538B23CD844D3D4707B4B950BBEFD54E112BA2D2E018ADC0F72C5771611159BBB26A149CA424FD5A8905F9607DB0A669184FD168E0234295B17485C545622215D334AF30A2556B0A35E6D56FD4E5A4BE3AA3E720CD5F1355BE255C9E29FDA1CF8B4AD9FD7CD5D9AF8FBA5DF6AAEA36EDAD63CF7C4E7576FDBD5276395237FFF53E85CD0F2D2D2F564E8E21385696A71A17494AD2AF91002114F86835C118BCE2C43B87C1916B76D7945594B85D35C5A56167569644CC4F5C9AADB4F5D2C897E7EAC8636F50F72B1ED68857BED1ECD5157AF8C52FD4EAC441DAFFE8C1EA72EE8BDAB5F54035D8FF5AEDD5FC06B53DF27A435A2B85CBAADC8E9C82C26C1515E6D4A80754E3224949FAB5910722C4FAA05BB0AF6269625B0D09203122016CB4AA4491CAB00A42C50E440B16AFD537B33334674144CBD74A175CF5AC5A75EAA794DD8E574AA313D4A1DB4DBA60E0BB7A7C6C81CEB9FA23A534BD5A0DF7BB56293B5DA4D4FAA7EAE46EBD9D891B8E94285ACE728681BF64EB2671EA53A332494AD2AF89BC69EA29D8C2566AB7B66FAAB2193C5492AFC250B66944F3E94C332E5DB54EF70F7BCA54D741EA3BE0590DBAF75F7A7CE47CB5EC749DEA343D4729BB9EAEFD8FB84EB73DB940839F5FAF632F785DED4F7B4AB7DC3F5FAD0EBB4B75EB9EAC4913D798CF59A10D1B365831D8BD5B975020D62D6B54244949FAB5917F1F3152556140E4E5DE00881591402B458A0167AD67D8DB66FFC39664757AB6E62D4B579DDD1A2BA57E0B03E4A1BAE6D63734F4A989FA60E616F51DFAAABA5D31421DCF7E4C07751C6C5AF2CF4ADDB7BFDA9DFC9CBAF57C4D29A9A7E89853FFA290612F1CAD525E916946374FB4B5BC8AD20098352A91A424FDDA28FE5DC4DA4B169E22863AFC455EF60D34A8F98865154E23161B70D6659768F692753AEBBCDBD5F796314AD9E524BD37A558E317146B8D0176B629BBBB9E9AA17DDADEA994C657EBA0CE0FE9A8D39F576A93AB0C8CC7E9F5B7A739BF333BBFC0EA124C06F1890E5F7E655950A71A954A52927ECD145886C179555900D0F2B069460308EF239696855874706FF57FBF2A4DCF8E1EABE75E795F9B0AA4CD2169A361E6DA21A374E55F5FD1A1A75EA7B37A0DD3232F2FD4F54327E8D2FE1FE8CC8BDF57FFBBE7EBC57195BAE6CE6FD4EA889BB4CF41DDDDE40F93429BB232F04655163553385454ADA53D559F242949BF768A3ADE370096182A4D45059BBF0320029022D390C5664ACE5FBE56431E7941471C779E52763B52071C7A81DEFE64BD5EFE2CD3D105D7BFA6434EBA5B297BFD41297B9E60E6EB31DA7DFFAB74C69FDED55D8FAD56A7D39E509D3DCF57C3C667ABDF758F2A6278AF8CE6BB195ADEF4E0FD46FC46E7CB56C45E58AE4A4EE024E93740EC3D6507CD36F1E6AB9547A22A290D2B6488C18B5CB5216CDAF04BFDAED3254AD9A98B1A343340D63F53F5F7FC939A76BC525DCFFD9B060E9BA31E7DDF528FDE637570C77BD4F3CAF774E19FDF56EF5B27EBA2BE6F2BA5DEC94A69789C1E7EFC236DDC54CECB1E0A8732DD9B1E19996BC59B1A4C22454C1303485F9F1A954B52927E6DE4DF4384304DA18AB00124D80AA3BC9C42E723969A469CCA6E9AB552EF9BC768DFB67DD5FEA4616ADCEA66B53F76B881EB52D569FA67A5D43D5B879CF0B00E3BE1495D75E3347D3C457AFCEF6BF5CA5B25BAFD81AFB54FEB0B75C43197EBD97F8CD7966C53BC646E05555598ADAB8801912D02A8E840335AA8FEA64EC206242949BF1A3230628E062669A5CA4A428A9698DDC84C8A81313727A48C8C3C6DC82CD0EA0DD24E8D8F55DB636FD3A04716ABE735F8825374E97513D4AAC350FDF18A37F5F8E81C1D72F4631AFAE45A753DEB591D77F6333AF50F4F9AF63C55BB3639D6C0DA5C57F7BF5DB8A4DF2F4D73BB77F82C234034496000C42C35E15019334FE3A8C6459292F4ABA31818C56C69285FA545A699CACB0D90652A0B4535EFBB65CAD81C52618925AE7F90CEE879977AF67D4D87777B4ED7DFBB5AFB77784CDD2E1CAB51E3C23AFEAC6774DAF9A3D4FFAE19EA78EA089DD6F365356F7FB376DDE742EDBCB7F98F294D75DFC3CFA8D0C097BE699DFB168EFF181CBB7900235A717B5BF2B689F825C9BF5396887EE85E927E39AA3D2318EC62A999E697A4EC6C5E55325D14ADD4C6F51B4C399A76B22A326953522CCD9FB7549F7E3243A975F7D6BECDBB9B66EBE026645252BA28B5FE9FD5B1EB433AFAC407D4B0C91FD5AEEB353AECE8FE4AA973BC0E6CFD17D56DD04D0D76E9A6D406963EB5A39E7E7A0C38976150FFFA68BCFBA8311334951568C6D2EA3734B6470923FF5D72FBFAFECBA089FF6665927E7EF2EB74B54108C5AFE1793EF825C6AB360F86C321073EEC526654F3F2B768D37AF701612D9C9FA9CE9D4FD17BE3A668BF03FEA826CD4ED11FCFFBABBE999DAFB9F3A56E67DF6D28394429F55A685586D4E3D23BD560CFAE1AF6E8784D9E56A07ED78EB0FB07E9E2CB0729CC2CADA9C1EF172D53A8887544F3150DFC91D2223BDDFABAD4F62861E4CF4D0C581264FF7789B1E3B7233C40F982DAF6BE31FADF22CF3F31CDBCB52EE5256EF6D27D56B1AC4AC5C5856EA981EF987EF1D97C43407D6DD8C0E670E9D597E6DA7523450D50D7F51FA6523BDEF3C04835D8ED609531FB69190E1FF1826EBF7B848A0D6B5F4F5C2636F20C1870A73345F9B3E4FBC5DAB03E5DD9599BAD10AB438525B0B22A225B17F9B7470923FFD7281EA849D0FEB214AF75FC2B47C1AF2CC1AAFC12534425D87F760E28E3BF98FD739007A32BDF8058E5162C4C2B5585955F58A039DF2D74BB61C67F3E5375EAEDAE5E570F72EF187E3C7EA65E7FF50BD54969ACBAF553F4F22B6FB8C997FAA9FBAAD4907AF0EF5ACB0C5B3351531CF06EB9E51E43CFAE814368656564AC71DFC7410B7E3B7BBA0131A2C2DC2CF1C90EEB045584C32A2B8DA8DCD08B0591888F6B5CFCFFD20F01E5BF6DBE26E93F4F8C67A2318DF70B8B511116822F6AE71B6F56DA3F7E08C6980EAD10F7DC7F83E2EB17130E2E049A917A469D669C30F1732D5EBECA69BD156B36AA43A7338DFB7753C8AAB839AF42E919619584A4EE3D7AEAC5D1CF2B357577038F94BEB242118BE783E0D18AB0BEFAEA0B4B57A67A751A6AF68CB90E8C9919EBAC1C039DF9856BD7AC70AF47F11539666F01A3DFEE9668AD339E1246FE3B547BD0001F1280A3A7F8FBA4270EA9EA7F95A7B4B424A17943C7462234B6667C927E5EF2D3F1458561858AB78E6741016B6851F1222E0BE87CD4899944EEF9B7E713BD45FF9F26782AF6536B2EE4E5E569EAD4A95AB26489D6AF5FAF52C344BE29ED5D7639DC7CC07DF4D1BFD6286CCDE8D1F3567DF2E50237F379CB2D4F38C0965A361FBCBD420D538E53BD94D61A7EEFFB42C9A7A4ECAC871E7CDCBD74C17ED6E067DE4CF8444DF399269E3A6DA23B66676F515E6EB6A1B8CA9E0BC0F8639430F2A79007952700183695CCE70A824F166C05577C3A9EAB4D3E1D143F41C03EBECD9B33027BDF4089E9137F3F49FF394A3416F1C4D8F125EC4D1B91FE0641A3A54B973A0644F097B1CDCC1246627B3F7F2E4298BB195233917373733577EE7C4D9EF48DAB5F69D8C062405A9956A1A6CDCE30AE6FADBDF63A4F29A9871B30CF526A83232CAE9D1A373DCD8E2DB547A3AE6AB0532735AC778A764A3951A9295DB453FD43D5B47107D5ABBBAF060F7E38B66451A99CC25C67F686303F4D136EC8CC087E89CAE2625F9A73A1B0B050E190299C9288FB8C0740B650A30D352EFE1D62E03C086BDFFBA904D87272B2949EBEC60678B1962D5BA2152B9669C182799A326592BEFF7EA1962F5FEAE2B8B764C9F75AB870BEE6CF9FAB458B16D8F9C21FA4050B6AA659B46891E5F97D352D5BB6C2D1D2A5CBB578F1528B5B62E9BEB7E716398A7F96BCA0F9F3293F31CD9B37AF06F9677E29A28DB439BEFEB5FBA1F6FDB973E7EADB6FBFD5AC59B33469F257360E5334EE9D0FF5F1475F6BCDEA4C7DFAC9972A2A2AD22633D55E7E652C8A40A192723DFFC2284DFB66B696AF58A36FA67FAB050B97EABBEFBE73449E90EF17DF5FFE9E8FA3FCDA7543CB7124CDE2C58BB57AF56A77FCE69B6FCC14FD42B367CF74F55FBF7EA3962E31B3D4D812A32A6DD566F5ECF990EAD6EDAAA33ADEAAF3CE7B429D8F1AAC94BAA7E8946E43D5A8C91F74FC0943D5AACDC5EAD4798076DFE32CEDD7EC0A9D70CCAD3AF9849BB577B323D46CEF133468D0D3AAB036BAB741CC2CDD94B351ABD7A76BD9EAB55AB8748581D2CCE2720CF5C09DCC2BC8773FAAEA79FC872861646D8A97943F06BAEDDD271EB3017361F9F2E5AEE3274E9EA429D3A66AEEFC794A5BBB46E9EB565B9A1CB7A3DD870A6B79388C195B16DBC9807F12F806FE4729FDB513447494491DE2101284D8EB2A6E6BD256073FB80EB62B05A1CC99C2E415F83D483E3EDF0E99CB6DF166569B06E07E6C62C205EAE8835B5BF2F509FACD055F1FFA21662D54B78774FE87367D9D7D1EF1816749E7D3107C3AF28C3F27C4C6C205EED1FF04EEFB7BBE8EFEE8FB048A49EFEAF6F12612F1E445FAA8C5638191159A272B4BEAD2A5BB5BB3AB5F7F4F0740B44060CA55B9677C39F175F5A6657C3AE2E9634C40C8FDD29359436C6B735C4EFD8CF143454C163121C2F20579D237615594613A57AA30DFF8CEACC5CB2E35E0A574D539E73EA0DF9F3F5CCD0EB8527FBAE40D753AFA215D72D9EBEA76DA30FDF98AB774D6D98FA8C7B90FEBD46EB7E8D28B87AB61FD4E3AB2DD796ADFF66C0DBEFB3E573416009A915F2CAEA8C22467A228AA397366ABA020CF298E0913BED2C71F7F644265AE56AE5CEE140726F3871F7EA8F1E3C73BA1B369D3263F0E0E23DB806647895F64E5E83BCEC733E05C5310D79F7CF289A64D9BE6241D40CCC9C971F75DA7E3E09A4AE7A798C311CC0C1E09069C41E43A52CA8F4B06E610A02484426177BFA6C36EF99944E2B7F198B562203C854CE3061F8A0DAE31753169FC40E3AB06F7CC7CE6DB9866FF735E66473AD920A44825C0B1F30A3EDB10E4451E30006DF1CCCD35EDF3F11C0326090240F20C49F00023C433A50FA4E599F83C102E1EC804CA239D8F8B7FDE07FF7CBC4FC5797C5DE84F0FBCB8E25C9C1762413E41DB49495108C147878F3110B6D201071CA3160776D609C79FA3C222DEAC0F0233AB3ED066CAF575F2F5E53A5ED07810529E277EDF90718EE0ECB90A587F84827D9F8C6B7E41B609D590090EEB677BB42047EAD7E771FDAED59F74C699C3F4FB1E7FD349A73DA0AE273EAC233B0FD319678DD11147DEA733CF7C5207B7EC6D88E8AC8E5D2ED7157F19A2A1F78E527EBE34737A9ABE99BA4CDF2F5EE18048B1696BD2DDECEC071FBDAFCFBFFC540B16CD75E0634D1330AE5AB5C2D177DF7D6B96C52C4D9E3C51EFBEFBAE3EFBEC33A7C9B34C72C5BFD348BB6B00ECA7121DEA8115EB44A701015C7676B6D6AD6396296028026960009EA122FC9E1D0E3F8D73AADCFADBFD8C1DFD6E91E5113B71C7AD1D0FB1A0CA8F504225C56167873340C54505E61F0403C179A4B4D880C8C65C9E2F77E70C5479994934031D839897BBA53A5D517E9672B2331C1517E5BA0F07318356561E8AAD5559394625613617979B1F906F6D2B777E0A134FB42FBE3F380210DA8C1F0DC5A7C1A7A6BFE88BD8C0B841E219D240A4F76960569E09264C0210622212E28F94E7C9F5732C3DCF921F82D4E7491E3E5F40E7051C9608E71C01225A323737DFD2F35B13E6FB448A8086DD931AEDD146FB34E9AA638EBED2F956F5EB1E6826E226CBD786D2C6ABC8C6823EDBB2654BF5CF6A5326449FD0171CE113EA4C7D03DE220EA16CA69F8D2B63EB6624E103CB9B710F6628A3CACFDBA2A52B1669F3968D8150E2BE29CD938FEDAB5D1B9CA6830FECAD534F7D442D5AF5D72187DDAA3F9CF78A0E6A758F3A1E35427BEE79AD2EB9E89F6A77445FDD39E4356DDC52A1759BF3DCEF617C3571BAC68EFD4013BEFE4693264ED30C33B9F145376CD8A4356BD6587D1132F4538929A00DCECD5ABB364D19191BDD356E15DA71E2C4AF357DFA74A5A5A5D1BD09B1B44DE48E504C02575F33B0F926423232321CD1E968483ADE33199D0C2370C49905B048160089A38B76048F4C1B13DC40DA9F78CDE5351ACCCFE0708F78BFC6E5406747AF05839F7336296C1A2E1A354674262668376DC4CCA069B832F753CE411C441AEE41AC1B71CDF3A4452B5246981D15AE2C345650A6D314C654742AEDF48C46209E3E22DE0B26E2E243C07C81E6F71ACE07CFB8F45D7CF0E9B847F0CFFBEBF87C38A74C7F8FF23887F17D7D49431EFE1E47DAE0F309EA6CC0AC28D4D265F3F5D1C7FF324DB29BEAD5395875520E516A4A7BBB6EA9F6EDCF766349758BDCD247D05704FAC1D793730265714E79FE1AB2B36A66678C6393762EF8F630CFE0C73F14C9721F92A23D33BE59A401D73DAA268DCED4D9673CAA6EA78E50C74E437468BB5BD4EEC83B7454D7E1A6019FD461ED86AB53A7C74C3B0E55CBD6176BC69C2D6E6572FADCA99A3CE34BE59A802660A22304F8815304544101938A59FAE8A38F9C1FCDF1BDF7C6E9B9E79ED1A79F7EEC342100F49A7DCB964CE7EF820D0B0E37B1F174E7B4BD1A50DBA358876D73EE332213E2376FDE6C6A79959316BE537D604049E3C114742A72B5521B3336289BC55153895C732C2CE663B1C628A69D78FB1A53911733D146FC1E1E475ED2B4A1AA8E2F0EE7DBE0049215331629EF7DC7801128336ADA2EC7818A673C931415E73922AED0CA24AEB8284FD959193608B4D3D214120F830675A71DB54D281FA8436D868B0F3092EF231887C075CCF48FD539B8E7D3F97C7896FB3E7F0F741F3CA0086849EEF9FC086825EAE7F3E51CE148F0E962635B1DC88F7CD3D26C7CD7AE70AF014D9F3151FDAEBD462FBDF48EDE7C7DA2DE1EFBAD9E7F6EBCE6CDCDD13BE3263BD315AD882B429F61FAFBB61228CBD7C1971B7F0CDA84D98A10F7FD8C898E560D8420443C8A00E19FB66E918DA1591465957AE6A9B1AA93D246C71C335007B5E8AD66FBF651DBF637AAED1103D5B6E32D3AB2CB50B56E3B5807B6BA5DA79FF5AC1A35B95C8D1A9DA1B90BF2659E91C21505DAB879A5667F6BDA6CD51A4DFC6AAA162E58A22993A76BF6EC396672BE6F3EE25C3343E7392DE9F7C0A2F97C3BD7AE5D6BBEE30477A4FF2C54E38A3EF5968A8FABBEB93D8A6936771E1BF4EA7B6478D34D37999F70805AB76EAD3A75EAA863C78E6AD0A081D390308A670C82EF580869160A176B4BF666035C58E9EBD7EAABC95F6BF6BC6F6510D26D77DCEEA64C5E1C33DAED80E87DCDB50E3A9F7EF58596AF59AD7C1B94A10F3DE03E9170EFB007556C12F4F3AF2768F8E323DC73D70F0C9E7FF68551EEF8CAD857956992EC934F3FD3C44953B4252B47AFBD3ED606CE06D598A6DC4CB2EC1C1B50F30590FF9C23FD08CCAACE9D33CF0D02E1A5975EB1B649FFFAD7BFDC6414B37B4845DA3A6CD830C7648F3EFA6835B8C68D1BE7BE0A76FFFDF7BB3E19326488B31890A83367CE748CF4F2CB2FBBB4CF3EFBAC4BF3F1C71F3BC1B662C50A4D9A34C9DD7BF3CD375DDE983B083FF2C00721FDADB7DEEA0677E8D0A1AE5CCC5D02F57BE595571C733FF1C413D540A36C988480B426FDEAD56B5C9B61AE75EB36B819E5CCCC2D666E65DAFD408861B267E798F593B5C94D60DC7BEF70D941C31E1CE92673DEFCE76766F5440CB41BF5F0F0475D5F5E7EF9E50E60F7DC738F735DFEF9CF7FEAC9279F748CD8A54B17576FF868CC98317AF1C51775C51557B83986860D777280E3F8F6DB6FE9DE7B86EACE3B06E983F7DF51B3A67B894DD8A975EA3A8DB53E7D938D73545979F9CE5F3DEFDC81DA7FBF33D5B9CB001DD1D9B461A7DBD4F6F0FE3AEE94BB74F8D137ABF921D769D72657E9F04E4395DAE05CD392B7595DAED7238FBC63829E8D01CBCCFFCCB2BEAD3017C8C05918D196CC2CE566E7A9B830643EABF1313F25656597197A0BF28A5DDB5048E9E9E96E4C11868090F12130763101548DA1784A18194F317FA3461C4CC0202F5BB6CCA9E7112346E8BEFBEED339E79CA35EBD7AA96DDBB66EAA9940A5D08C1C3129F01FF0B59C4D9DB9514521F3C5AAA2FAF4B34F34CAC071FBD0FBECF8A61E7CEC29A56DCCD109DD7A68CACC25FA76C11AF5193048AB37E5A9ED51C76BC99A4C5DDE678066CC5FAEC79E1DADBFBFF2B6E67CBF54D7DD7487328C1906DEF6A03665477559AFEB3561FA2CFDF59E217A60F8130ED027763B5B052551753DA19BBBC635E58844E4581CA9D2D4E9DF5927A2D5AB1CC321E98FE97AA23BD6ADD3C00DC205E75FA437DE78D318659C060EBC493366CC708CC44CD9CD37DFEC2436A081C100E495575EA98D1B37AA7BF7EE0E5077DF7DB7468F1EADAFBFFEDAA59F3C79B2FAF5EBA7CF3FFF5C83070FD6DFFFFE77BDFFFEFB8E9999FC6AD3A68DEB4704DE4B2FBDA4FEFDFB3B80CD9933473D7AF4708CF0E0830F3A4148006030FC35D75CE39600BA76EDEA8E0093B2C91BC6813233331D1891F08011FF302FCFDC0803274B3DD3A64DD79CEF66EAD3F11F3953ECF1C71FD71B63DF52AFABFB6889DDEF79E145FA76DE42DD7AFB1D7A7BDC3B1A35E61F1A3CE42E13B659BAF1C69BB5266DBD1E7BEC31B74C42B9B48DB620BC58177CE38D37DCF2059AE58B2FBE70826DECD8D7AD1595268C26B86381016D5D3ADBCE8CFF962DB2B8A872B27883D7DD760BF53DCE6512A6856E1CF8A22987637454E71BB57FAB5EDAB9C9F9DAAD510F1DDCA6979A34BF44FBB6ECADF69D8768AF7DAED6393D9ED6DEFB5EA406F58FB1675A6BE04D773B0B6DFA8C299A3563A6664C99AED5CBD254546056053B0762E5F162F29CD9F3B47CE92A270C70BDE873044FBC75C118C46BC0ED51C2C878A2A3FC391952180CC68023B9BD69C1002301201FE7434CA35A08CC0ECC553463714991D38898A400B2C0EA3F61C65C7DF0D954E599BBF5FDCA1C7D36E17BADD9688018F6B26E1BFA8CB24C0A679855F5C197F374E57543B42E47CA340576FBFDCF2B64C58E19FBA172CC0D7C7EF4077AEF9399BAEBBEA75C3CFA3DA5DE1E2A31C0DD36F821356DDE464556DEFE2DDBBBCFE81DDFED8FEE3E715985511DD0A29DFE7CD5F51A6D66588B16EDADDED2BECD5A6AF42863101B0CB7A1C48E80D30D0E076B3B6D45FA797F911093864E03900690728C0D50F539C439C13F13274DABD3C70F74F01DCEADE9191BCE57AE5CE9AE798638C684B1E49A6525CC27D2B060CF58F28C1F367CA2F8C0040E9339EEE3BFCE4F0FDACDF4BE8D9C35BFDCDC0513AA6622862BF8CD414BE728980B58BFCE8483352B66AAB9B2FCA4527CA08EBE1D046F45510A73049830FC0A1420C4A72FC8F73B5CAAB470DE129D7BEEF526285B6B97065DF5D0FD5FAA4387813AB0E5D5DA6BBF4BD4BC6D5F7539FE4EF775EF030FE9A303DBF457AB7683B44BA33FABE1EE17E8F85387181A0E57BFBE0F3A50E7E6E7595D62BF85C190588369FADAB4744D993455F3E72ED2CAE5694E6B024C261EFDD8313EB485EB18EF3BEC70FC214A18599BC808958B5467C9C2CFDC51208C458839A6D5662915A152101522DE6D7773CB0554D0FC3FEB50B4A35BE2301F6F55FA463D3DF225F5BBF10EE5599277BF9AA71BEE79566B0D5CB70E7F43CBACEF4F3CFF3ACD4E2BD11FAEBADD5D7738FD0A773CAFCFDDC2F3B9B0F71D7AEDE399BAFECE511AFAF83815591FF0FDCBBFDE35483BEDBCBF3664942AD7F8A05193DFE9DE079E57CBDF1DA3534FBF5877DE3D42235F7A5F279ED653AFBFF999F98ED26EBB1EA85E57DEAC91CFBE257E871D00EEDC700F9586A3FAE2F3096ED9C5CF3AC2C89E71D0FC081CCEBD6FC9118B82BEA0FFE80F7C35FA70ABB00AFA94E081E7FB932396086991C010F97DF5D5578EC961620F52D2301E1C7D7EA4F1790142CF283CC7916BCC5BD2FBF1253FEA487AB72616315FD3DA929F9F6B82B44065E6BF87AB8A55AA908AAB0AEC6F9E79F121852AF2158EE2D3FB7CC36EE69BE0FD53CAF2E0447051166BCCACD3115F58586C7E7CF0F36BF90525968F2534E015E617D87985B2B237181F854D0020C865E3B14CDD4EBB55B7DC32D6AC8349BAECF231DABB592FEDD9D4C0B84F1F1DD4E6161DDAC57CC4436FD21ECDAED61E7BF7524A6A77B7DC7154A7EB0C091DD4E7DADBDCCFB5515699594780903667AC5FA7D9D3A63957A520CFEA4F5D8C3057DDB9D531586E314513233428AB00FE371E77841246D626068C4E64B9C2FB41749E9762300E6618A60FA6D8238F3CE27C1D7F1FA6E159163F597361FFDED469133463D634CD9E33CB494FDA3479E6428D7D77BCAEE873B303E380BBFEA64FA6ADD48D4347EA8AEB87EBBE273FD4883113DD8F8CDC307894468FFB4EFDFEFABCB22D6DFF3B5F54811577DBD07F28C3AAF8CEF8D59A31AF58FBB538DA81B15EFD5D74FC89E7A8FBB957E8D0C3BAAA77DF5BF4C2C8B16AB0F3BE5AB0689D39F8875A6FECA6BCA22ABD35EE331D726817DD71FB433AA4F5516AD6B8A5323714D9FDFA1AF9F7D1D55A31541C6C6D22A03D9CF4B691C9CDCD360687F18319E0ADC72078A0C56B0AE2E827B427A624FD85F0638118B0B0460548BC4FFAEAABAFBA31E11E20E38829CBB8000088F41CC98F00A8484B59BE6CCAF4E9B72E29040BF13C87E98BF60C34B031969B2433609797987E623344B9C29556EF4A036465915920762C37615369FE65144D1ACC1BB0158CBC314DA92B429CFA730F9EE21E02C6D7CBB5C38EA56C1D336187B0A6AF996D271E8A98B62AB1EE3FFBF7BDD578AFE39452173A514DF7BBCC2C9BEBB4F36E57E877870D56B3030668F7C67D94BA2B00BC4C2DDB0C56C7CE0FE8C083FBD9F5F136AE87EAF2ABEE57A199480CEDFA0D9B5D01B3667DABD93367293FDBFC65DEBEB0B8C2FC22656FC9715A12C0F92304F07E0AF86A53C2C8DA44C7D0793008CC42C711307F9098BE03095EEA13308B78D607D47EC0A43063D486D63AB734E416FC172E5AEC40F8F08851FACB35B76BFABCB5767DBBD66444F5C013AFEBEB99691AFDFA24BDFCE654333D47AB77FF61BAC380F7E67BB3F5C957CBD4E9B88B34FCA917D5E786A1CA359BF4963B9FD71FCE1BA0175EFCA7314400166ACDEF2620A437669A1962D7C5610C2DEB64B365811535CBCC2A74CFB866D9911FAD5D386F59C0014639D9C6B4019E5C603302E9616CDAEE350B121F6D861FC46409DBB4D8C6C5A4CDECD9B3DD6608B67C6136728EAFC8C40A71F42BF911605200846F4EC0478C0F9EA9191BAF096178E249CBB8F93182F149E7AFBD60E0E84101F13CF5C684659CC903ADC87211160EBE3E4B53D966CE15981062028DF9F0B08D31E4FA9A17072D0048CF37F1E6BB0FDC27D05ECA8548076F646C36FE2A0BBB19F64815DF3535CD6D6DC5CFCF292ED3F997F4372E6EADD4FAC7AA45DB1BB4F35E9719207B689F036F30B7E32203E240EDD1A88FF6DABB9F1A37BD557B341EA8E607DDA6C67B5FA5FA0D4ED59E4D8ED36967FDC52D67B0C5EDA34F3F31D7699D1B2FC7E756B562D3C6A102EBE37069B0AE691A9A63F6962C039FF59FA571C704D8F9299430B23601283A93D922A435C0F48348473288749E97C49E217CC7FBB484C0E730D3ADA2D43A39E43A9CA140FACD5AB8522576916B8F715CB46283F3F1366DB1FC0D29FC4865898D0260DA62CE333911C731638B9937966F9A4970062A33DBCCA55293F8766FFD863556B7CD6E3DB32854EC9808493B6FFE42337772DD8CEA8A956B34D59CF5B0752ACFAC4E5B6BCC516ACF0596009198A7F83F009159469A89894A3B69374CE4850F8CC58C20135C808C5D17F8D84C96003404154788749F7EFAA9B32E98D860D694891D8E1F7CF0819BDC60D674E4C8912E6FFA973EA75FB140BCFFE5FBD9838DBAF8FA0028CEA9A79FC401E45C7B0182804078F8B4E4E3038CC98609B42360E4B9B2F20A33216D6C4CC0E59A29C9DC466149F0FD51C693BEC6EA4100B324411E9445DEBE7EF49DCBDBCE11983EC0277905D96E298B9F502B2D2F54B1B698E62D32E31403D55C8F214F1A07B754AB43AF52F3167D4DCB5DAA238E7D4CBB37BD460DF7FC8B3351F7DEF76AEDD9F812EDDEE8421DD07C809A3435ED58E70CD54D3D41BBECD659F5766EA10213C4EB32334D0863FA1A0FAD5D697D59E6C688718FD77668768873DF475E18FA342CA9D11628B6A5B0069EB6470923B7478010868AD7866E50AC5274280CC8395294C1F681E7A82C148091C699A6AA0A5EBB2934862F0E45B4D6183CC78CF6023347726128933EFC4E02E0E0951C76C4F85F112A8F96B82353EDEC92E19AA9EDB01D498FD04013E383F06269289CED3A3ABFD07CAD98C465E288ED78C57C31CC95633E9EE5C22F055147BF8EC5822D26281A114032EBE8CD53DA84F6E0489B39D217F40F830950F0DF3867B335C07CEBADB7DC343EC01B3B76ACDE7EFB6DB7B4C13D964BD08E4CB030BBCA39606429807D8DBE8F190318195032061C89F3FD4E3AEAC03D00CB354C445DA81FDA997CA857302ED5930DD581FC49E3CD61FA22E853EB07F39561367ECC85FE66EB9B25B56B036B2C8E5D558C1B263AF304940B511EF5E1E8C11898C8EC580ACA834F36673146E55AB17A891D235ABC6E81FD35616355E979E99D4A69D059A90DCE30BF7F90B921BDB573A3EBD5F2B0A1C6D57FD47E07F735D3B4BB3A74EAA7464D4E569DD4C30D84471A083B98166DAF73CF1BE8E6062C38DE0E9599F999B7C9F8107E7102CCB9673101B70D16E229D66FD5D7FE398EF1F13F4609237F8C90A89852985C741C929AC291127EF060043A1860326D8EE465E0B987A39E95B5D981C2BDFB66838AA3EE7EA0A4B24C45A5C5EE1EBB1F8A43F9AE83DC2F0319B0D8E6163629CBD628DE17E388F9C426627C43AC8592907502DC00D92903CE5A2279210420A4B503584E96630A88A5170886E3886FC4648CF7FF8C5F8DE9C3C6F4998E69BCE6E0591F60D0E5CB57BAB706780364C99265D64F0B8CF96757BFFD0001064C5388A97C008966FCC73FFEE1C0C772C80B2FBCE03617BFF6DA6BD5DA953E8591F1E1E857EF2A0032CE39323E583100D49B99F4014CC3B3AC8BB2FC82C0223D33E4A48D318F1B4F4F8C2BC294407BC99B31262FFAC092B836738E0F8DB0C2AF436B62A6F2C27156CE163773CEF3D403DEA01EE40D2108E00DF2A67D31CDE3CC535E509E316BBA09D13C074466CA4F38F59A98AF77A2F9FC176B975DAFD501FBDF67A0EBA57D0FE8A5BD9A9D6FF73A18F87E6726EB01E63B1EA833CEBA48FF7CE70BE5E4B183C8144451E07BFAF72E9909862FB6EE3D0E78DD6B362C20267338C7242D2D61522AB8F79FA28491F1C400C5239C81F0F174EEC489131D43617ED199302680F38CC13569195066C8E86CBFDE985760A65A66863311D3D76D52FA9AB58E412006876700318CC200B23998C5D5E2423389CD2C0ADBA017E687B4717DA68BDF9091EF16F6376F2A50EEE61C65589E9CAF4D5F6F9D1F75C04308B081973A520EF9B2B6969393E75E02CDDABCC5AD67C110948B2540BB20D6DF48C700D10E8207229336ACC9717FC284498E39097EE3358309D3410418DD9F13606ECAA4DDF4256B960016204200944DF7000933133052378E1E9080936BEE3399C3840DC290BAB22E4C3C79E3A302560F320F3A02E3CBB8429C134FBD48C3C23FCFD32FE4CB39DF7AC932CB81CDF8A463BC387A5031C66CECC8C9CB76F78887E84FAE01256D278EBEF4FD40FDD998B1DEFA1C614D4FAD4C2F50CF4BFEAA5D763F56BBED799ADAB4EFAD835A5FA98E470F529DFADD55AFAE69CABA872BB55E6B9D74724F0D1EF288DB88C0B3583E087E8E816035EF93ED906EA924E0EDF8978063E31AC4DBD8F9F3DA8412F8B10F4DED28258CAC4DF160AC15E7188A01C3D967A708E044EA7AF3874EE51E4C82B6C0315EB76EADC5AD726B8CBCEF95935BA86CF301B336651B88CC94DA98E500B671DD66A5ADB6E78D962C65AB5DBA0129CDD1CA95AB9DB9B8654BB623F60966E6E49B2F6900CC3040E56628376B9D0357765EA6D2376D56E6A68CE0DA1C6F7653302BB63E7D8332366ED106F3055943223E7D8DF9C6EBD9080CE3855DFEE906E88D1B331CD8FCCE1CDA0D9332B8CE14B351E772D2A429EE4808B6E405F1F419E4191EA6F6E69A0703C18394FB3026DA04E0D077F87468482C13342C7E1E1B08D0BA808C091B2C16883840CD7DC6052DCB2412662BE341A02ED4C90B150FC0A05D41406005C732D7CF800830AEB771DC9CB9411BD6A7695DFA2A231312EBD3AD9E4C58A5599F99203310B266C7E2BF171A6862AFD5BDF045B0F0BE2AEFAE72CD8603ACA52FBE9CA4706985B56DB1AEEC3B40A90D0F30AE6D6E1A8F2FB6B5749AAFDE1E87EACC0B6ED0D857BF54A8101F2FE877C605F72552860503604CDB1B004325665D95E21E6D5D43F794683634F692708DB8DAF49F0064C2C81D250610D0C12C3E30504861769530F9C0B6AE2FBFFCD231038C01030156243C0C05F3700D83C168100CE3198D5D19300FC43DF2F6D74CB9FB174D7D3E3F449E49E3AF993C81A88B3FF7E988836072EA4E5D6062DAED34751C88602C0F22D6FEE81318CEDF47E2C3E83CC339478008D37BE2793436F708A4C74F44C851077C48267A00153B9C28877EC6CCA58F3165E9EF60D3F27B6EDB19CF13CF7358305E4342B401C0536E3CF87CF075F201203136E4437D38A71F7DFF11E7FB9423C200ED4E5DA93342C10B6CDF06FA95B4D40B4189C05C9BB64613BEFA5AEFBFFB815BABFB7CFC173ABA7357E3D6C6DAA3510B5DDDE7568D79F95D4D9BBE50C5C67A4CE8E1A20480B3BE8DBD8513EC2B36AD8F4B62AE0DFDEE03022836360979FB97A08491DB2398C33315D73486C1F40C57BB71A4039C98AB9834800B0662CDECF5D75F7793166CEB62CD8C890C180802C44C64C04098663014CF10EF8938988E74302044FA1FA2F8B4107913CF5A1E04D342F1D730393399A487B900986750DA0B786827F1B41510D24ED2A001D0665806B41FFF8D74101A8F6B8E6802408E5919580EEB1C5810745C13601EEEC3D08092F63309C4AC2B7D487FD21E181D502038D036009E401DFDB91F3702E6A1D7D080138D4D9C7711E2B5320212F0FB71F2FD495F513642813EA3BF7C9C27FA99B4A40190B48173FC64DAF1FCF3CF6BC4DF9ED0E38F3EA6912FFC5D6FBE3156635F7F5373669BB6379A3DF35B130EB423303B99034073BA73FBCBC45B857BBBC6F83362ED091598F988503341675A8B790578375E10D236AEFF57809930329E7C45E32B4B1C47E268108D837C7C6DDA5E63197C808A8663A06130988AC90BA6F121263198756462836BCE8983B8261E866440FD333F463E0F18E0B9E79E739BB39F79E6193DFDF4D3EE0811471A9FFFA851A3DC2C28CC864041B233D309F3C3A80007400134DA82790E000110C0029080836BD241DC6751DDFB728012EDE327BDC803C6257F0002B849E341E28F000D2D467F7A8D0DB37950E19F0170AC09F2A23CCAA50C341265A3D9B13CBCA581C6A26D808AB6DF71C71D7AF8E187ABFBDDF7217DF5D4534FB935508ECCFA72249EFB3C8BD045E0E2F7C60B61042C828BBE40A8D5E60F4FFEA5723FBBCD445CF0C5050352256668A1999C59D56FE47853949974260B999F0826E182FCBC42F95F00603C258C8C2780E4A9F6BD1DA59FF2ECF680FBBF40B1765407069577D430D7606A0F50B40047CFD8DE8CF37E1DF700199A01F39C349873C4A3313C08D028302D160079C2BCAC3D727CE79D77AA277720E2B12E7843836720AF35617E40018038273D262C65A0DD280F331F41013001316DB3E0DA0DE0012F80F5719E76746C49F76369FDFD44E9F057F9FC212F85870D689506BA4884C9C06CBBCDD24CC8019497BFDD97DAE22666E209DE8A6F1BB42375FB392861E4F60889EB250A47AE69583C786814D7BE81FEDCDFF3E9FCF3F171F1E49F8D7FFEE726CAF5141F47DD7DF01A8A405DD14C6834CC39CC35CC39DE5280001726B637E338073C6811DE82409300124C5180813603C4682CAEBD164593A041298734683BCE21E22134289A349EF162F576E7D435519C8F8F27E2D0B03E2D793276FE7E3CD5EEAFF8F8DAD71079935F6D80788A6DBAA8BE667921982CA934DFD04CEB70703F8863D635D8E5150F46EA8D29EECB89AF4BA2B85F8A1246EE28D191BE53B98E3FFFA9C4738918E1E7225FBE6F53EDFB507C3CE7FE1AC68C9FE8C0F4C6E4460B794D84198DE9CB391A0CCDC6C23EE025C4F272F978F2D784DA132CC41317578FEAC03DDF160B09EBBF23B4BDBEA80D1CD2D58EFB772871598C4BA5E51FDC63B6937DA0BCA9E1D378DA9E36FCBF4209237F887EEA80FE9AC9F7058C08A8387AD0781011E2CF615C7FCDB9B7367C20CEFBE19C13C893F35879EE3A51FE3E5DECB9EA3AC65FC7D37F622CB797F77F833C206B13BFA1117FCDBB88F1D710DBF36AC7FDAF51C2C81FA2449DFF6B03E88FB527DEB4F3041021FAC70392749CFB6B0F261F001DC183CB13E90023A615E7FE399F1F65F838D2FBEBF8B189DDAF51C71FA3F8E7E3CF7784E2EA54239EB89F529760513E38F70062D1DFBDB911DDDAEF89F204846CB1AC1DFF7F851246FE9629D120D796BCAC0107EBC035D355A94CEC9DE5C8D7D3985060719909054FCCF4F985E8DCBCCDC18483F93894EB670B3D9196FBF842CE1F8A6940D2C6CCC2EA904840C4B70546264DA2F6FDFF52F001B0E09C0F51F9F3581D6BA4FDA920FF2D51C2C82425A66072A02683B12F33FE1AC2C789673A9E0358049E672B56F0C271E0F331535890CF7A2DD7DEE4DC6A7E9297D7BAF1608A4DA26C53274FB1FBDBC47BFA29C0ACA8B5C384D7893806DFA88D4F57334F2F246A3F0F712F09CEAD9430F2B74CDB6350341CA0F29304F82FF13E0CF7FC79BCD684E1D88BCB1A186F7AF0AB4D800FE24B016ED53A466ECF72EC1C6BCD596C760EE063966E0D30C66B3A8EF1758827181EA003CE385FB4469AEDB5DB1360FAB11F7041F3A3C18363E234DB03DF8F95FF5BA08491BF65DACADCC114391A2DD06A3062603E06BE0BBE60F0763F3F47C0FB7AB16FBE56E7E5B5D9560D0778B64EF2782D08A89DAF687C0A0003CD4AFE81568CD529FEBC469D3DF975B6C0B40DE27E2A93C76B59EA9A48A3F93CE381E5EA5B45B926B0DC827CCD6792F4E39430F2B7483FC6B430788CF99C99E95FAB0AC8FE3A80C1B88149EAC8F9804140BB555415BB772F030D1BACB306CFB33E16001CE2392F08B807F1456E0BD5F5D96AFE6D7F82241E2C9EE2D3C683BBFA187B63BDF6C667F679C62F1DC49664DC79CC54B710ACF3B10BC682BB17FBDCC836E750EDF5C0DF3629E5FF018DE1AB636A9FA3F40000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A340-500'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E3000000400806000000E806C00C000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000034CE49444154785EED9D07605545FAF60301C18E20D850045644504140EC05FBEE8205D7BEBA485151B02E1644AC8865C5EEE202767415EBAA58E9D244AA74088496407AB9B9B9C94DF27CEF6FCE9D70132E8AFBEDEAFEF50EBC39E7CC9933F57DDE3233E7DC1449494A52927680CAA2E52AAF882A5A59A18AAACA6DA8BCBC5C55555596746BA8A8A850595999BBE7037190851AF9D7B848529292B46304200167695944A170898A4B422A292951241251341AAD0625E71E88C4415C03500B35F2AC7191A4242569FBE4B562ED78E2B8E701585959E90820864221151717BB73E2D08800B6B4B4741BED5823D32425294935A9DCCCCF32035B6965D42E95627ACD1DA10A3B2DCA0FCBDD321C462A0C8096B68A88AA804A4245DC92839D9D54462B54690F5656182023C5C4A65490911DB7293C49494A524D029090BF8ED76815E516CFFF6895039CE151D1B20A850A0A559C5FE0E201637138AA228BAB2241A0402DA03DB79AABD50526294949FA612A2F8FD861DB78005569DAB0A0A8303063631AD06948035CA4BCD4E203BFD1AC5995452CAEB452199BB288AACEA746A6494A5292768CA215E6F35596AABC32ACA250BE2AAACA0C83E54651031FE0B454169865252E5C56A470D8706A405DBF3E47CB96A473BB469E352E9294A424FD30959595AAD201AFD428A26855A9F243050A1B003153274CFA4E279C7C81EAA43657C39D0F3184EDA3BAA9FBD8B1B13B4F4969A23A298DD4A9D3C92A2E0A342D133A1C131698A42425692BB94917A38A72D37025C54E23561A1823D190CAAACA4DEF99E9691AEFE3F1CB7464C74B54BFC1F13AFEC4BBD4AEFD001D7C702F753A6AA052538F5387232F57DDBA6D54AFFEFEFAF0C32FEDA99AE5D4B8485292929480F0FF0C88AAAA50B43C6C602C31B3B3409B733355645AADB0A44A7316A6E9EABE4FA8D97EDD95927AA68E3D69844EEA3652AD0F19A27A752FD291EDEFB46337356D7286EAEFD4CACC5BCBD9F20E97169A1F194CE2242E3C49494AD2563230AA2CAA723351CBCB42161571266A71A44885E1724D9FB34CD70EB857BBEE759452EA7550F3367D747AF7177558C747D4B1EBDF9452A7A7694503654A7735D8E9140D18F8B8CA2CCB4894658F12CB2F2867DB829394A4DF18B154C1A23CE72CDE57C707EA2B255A1A36CD581A2C161AB18366DDE675CA09E729AFB442FD6E78D090D4C640D755BB37BE58A79CF5822EE9FD89EAED79835AB77F4AFB1F7CA752763A532DCC644D4969A7ECBC6075A3221A76EB8D49CD98A424ED2039B000D2289A91595469F1CA95CA2D8D687351857A5E36C89074A89A363F5F175EFE924E3F6F948E3AE949EDBCCFCDDA73BFC13AFAA4A70C8CDD54AFC189FA7DF79B140A4B7905B996F5D60D04508D429394A424C5B6B705FB49DD3513374CE0941467D8655421D386B3E6AD54A12599BE60A3C6BC39DD8078961A1D78816E1E3A495DCE7852290D2E5487539ED31EFBDDA67D0EBE41BBEC7DB699B0ED347BDE46A76073F336ABAA32E276E35006E56D53912425E9B74A89F69DB2AF34120916EC4B2305CEBC5CB63A5FBDAEBD5F431E794D5FCE5AAFA51BA5218F8ED3317F1CAA7627DDAB3D5ADDA094BDAF54DB131E538B23CD844D3D4707B4B950BBEFD54E112BA2D2E018ADC0F72C5771611159BBB26A149CA424FD5A8905F9607DB0A669184FD168E0234295B17485C545622215D334AF30A2556B0A35E6D56FD4E5A4BE3AA3E720CD5F1355BE255C9E29FDA1CF8B4AD9FD7CD5D9AF8FBA5DF6AAEA36EDAD63CF7C4E7576FDBD5276395237FFF53E85CD0F2D2D2F564E8E21385696A71A17494AD2AF91002114F86835C118BCE2C43B87C1916B76D7945594B85D35C5A56167569644CC4F5C9AADB4F5D2C897E7EAC8636F50F72B1ED68857BED1ECD5157AF8C52FD4EAC441DAFFE8C1EA72EE8BDAB5F54035D8FF5AEDD5FC06B53DF27A435A2B85CBAADC8E9C82C26C1515E6D4A80754E3224949FAB5910722C4FAA05BB0AF6269625B0D09203122016CB4AA4491CAB00A42C50E440B16AFD537B33334674144CBD74A175CF5AC5A75EAA794DD8E574AA313D4A1DB4DBA60E0BB7A7C6C81CEB9FA23A534BD5A0DF7BB56293B5DA4D4FAA7EAE46EBD9D891B8E94285ACE728681BF64EB2671EA53A332494AD2AF89BC69EA29D8C2566AB7B66FAAB2193C5492AFC250B66944F3E94C332E5DB54EF70F7BCA54D741EA3BE0590DBAF75F7A7CE47CB5EC749DEA343D4729BB9EAEFD8FB84EB73DB940839F5FAF632F785DED4F7B4AB7DC3F5FAD0EBB4B75EB9EAC4913D798CF59A10D1B365831D8BD5B975020D62D6B54244949FAB5917F1F3152556140E4E5DE00881591402B458A0167AD67D8DB66FFC39664757AB6E62D4B579DDD1A2BA57E0B03E4A1BAE6D63734F4A989FA60E616F51DFAAABA5D31421DCF7E4C07751C6C5AF2CF4ADDB7BFDA9DFC9CBAF57C4D29A9A7E89853FFA290612F1CAD525E916946374FB4B5BC8AD20098352A91A424FDDA28FE5DC4DA4B169E22863AFC455EF60D34A8F98865154E23161B70D6659768F692753AEBBCDBD5F796314AD9E524BD37A558E317146B8D0176B629BBBB9E9AA17DDADEA994C657EBA0CE0FE9A8D39F576A93AB0C8CC7E9F5B7A739BF333BBFC0EA124C06F1890E5F7E655950A71A954A52927ECD145886C179555900D0F2B069460308EF239696855874706FF57FBF2A4DCF8E1EABE75E795F9B0AA4CD2169A361E6DA21A374E55F5FD1A1A75EA7B37A0DD3232F2FD4F54327E8D2FE1FE8CC8BDF57FFBBE7EBC57195BAE6CE6FD4EA889BB4CF41DDDDE40F93429BB232F04655163553385454ADA53D559F242949BF768A3ADE370096182A4D45059BBF0320029022D390C5664ACE5FBE56431E7941471C779E52763B52071C7A81DEFE64BD5EFE2CD3D105D7BFA6434EBA5B297BFD41297B9E60E6EB31DA7DFFAB74C69FDED55D8FAD56A7D39E509D3DCF57C3C667ABDF758F2A6278AF8CE6BB195ADEF4E0FD46FC46E7CB56C45E58AE4A4EE024E93740EC3D6507CD36F1E6AB9547A22A290D2B6488C18B5CB5216CDAF04BFDAED3254AD9A98B1A343340D63F53F5F7FC939A76BC525DCFFD9B060E9BA31E7DDF528FDE637570C77BD4F3CAF774E19FDF56EF5B27EBA2BE6F2BA5DEC94A69789C1E7EFC236DDC54CECB1E0A8732DD9B1E19996BC59B1A4C22454C1303485F9F1A954B52927E6DE4DF4384304DA18AB00124D80AA3BC9C42E723969A469CCA6E9AB552EF9BC768DFB67DD5FEA4616ADCEA66B53F76B881EB52D569FA67A5D43D5B879CF0B00E3BE1495D75E3347D3C457AFCEF6BF5CA5B25BAFD81AFB54FEB0B75C43197EBD97F8CD7966C53BC646E05555598ADAB8801912D02A8E840335AA8FEA64EC206242949BF1A3230628E062669A5CA4A428A9698DDC84C8A81313727A48C8C3C6DC82CD0EA0DD24E8D8F55DB636FD3A04716ABE735F8825374E97513D4AAC350FDF18A37F5F8E81C1D72F4631AFAE45A753DEB591D77F6333AF50F4F9AF63C55BB3639D6C0DA5C57F7BF5DB8A4DF2F4D73BB77F82C234034496000C42C35E15019334FE3A8C6459292F4ABA31818C56C69285FA545A699CACB0D90652A0B4535EFBB65CAD81C52618925AE7F90CEE879977AF67D4D87777B4ED7DFBB5AFB77784CDD2E1CAB51E3C23AFEAC6774DAF9A3D4FFAE19EA78EA089DD6F365356F7FB376DDE742EDBCB7F98F294D75DFC3CFA8D0C097BE699DFB168EFF181CBB7900235A717B5BF2B689F825C9BF5396887EE85E927E39AA3D2318EC62A999E697A4EC6C5E55325D14ADD4C6F51B4C399A76B22A326953522CCD9FB7549F7E3243A975F7D6BECDBB9B66EBE026645252BA28B5FE9FD5B1EB433AFAC407D4B0C91FD5AEEB353AECE8FE4AA973BC0E6CFD17D56DD04D0D76E9A6D406963EB5A39E7E7A0C38976150FFFA68BCFBA8311334951568C6D2EA3734B6470923FF5D72FBFAFECBA089FF6665927E7EF2EB74B54108C5AFE1793EF825C6AB360F86C321073EEC526654F3F2B768D37AF701612D9C9FA9CE9D4FD17BE3A668BF03FEA826CD4ED11FCFFBABBE999DAFB9F3A56E67DF6D28394429F55A685586D4E3D23BD560CFAE1AF6E8784D9E56A07ED78EB0FB07E9E2CB0729CC2CADA9C1EF172D53A8887544F3150DFC91D2223BDDFABAD4F62861E4CF4D0C581264FF7789B1E3B7233C40F982DAF6BE31FADF22CF3F31CDBCB52EE5256EF6D27D56B1AC4AC5C5856EA981EF987EF1D97C43407D6DD8C0E670E9D597E6DA7523450D50D7F51FA6523BDEF3C04835D8ED609531FB69190E1FF1826EBF7B848A0D6B5F4F5C2636F20C1870A73345F9B3E4FBC5DAB03E5DD9599BAD10AB438525B0B22A225B17F9B7470923FFD7281EA849D0FEB214AF75FC2B47C1AF2CC1AAFC12534425D87F760E28E3BF98FD739007A32BDF8058E5162C4C2B5585955F58A039DF2D74BB61C67F3E5375EAEDAE5E570F72EF187E3C7EA65E7FF50BD54969ACBAF553F4F22B6FB8C997FAA9FBAAD4907AF0EF5ACB0C5B3351531CF06EB9E51E43CFAE814368656564AC71DFC7410B7E3B7BBA0131A2C2DC2CF1C90EEB045584C32A2B8DA8DCD08B0591888F6B5CFCFFD20F01E5BF6DBE26E93F4F8C67A2318DF70B8B511116822F6AE71B6F56DA3F7E08C6980EAD10F7DC7F83E2EB17130E2E049A917A469D669C30F1732D5EBECA69BD156B36AA43A7338DFB7753C8AAB839AF42E919619584A4EE3D7AEAC5D1CF2B357577038F94BEB242118BE783E0D18AB0BEFAEA0B4B57A67A751A6AF68CB90E8C9919EBAC1C039DF9856BD7AC70AF47F11539666F01A3DFEE9668AD339E1246FE3B547BD0001F1280A3A7F8FBA4270EA9EA7F95A7B4B424A17943C7462234B6667C927E5EF2D3F1458561858AB78E6741016B6851F1222E0BE87CD4899944EEF9B7E713BD45FF9F26782AF6536B2EE4E5E569EAD4A95AB26489D6AF5FAF52C344BE29ED5D7639DC7CC07DF4D1BFD6286CCDE8D1F3567DF2E50237F379CB2D4F38C0965A361FBCBD420D538E53BD94D61A7EEFFB42C9A7A4ECAC871E7CDCBD74C17ED6E067DE4CF8444DF399269E3A6DA23B66676F515E6EB6A1B8CA9E0BC0F8639430F2A79007952700183695CCE70A824F166C05577C3A9EAB4D3E1D143F41C03EBECD9B33027BDF4089E9137F3F49FF394A3416F1C4D8F125EC4D1B91FE0641A3A54B973A0644F097B1CDCC1246627B3F7F2E4298BB195233917373733577EE7C4D9EF48DAB5F69D8C062405A9956A1A6CDCE30AE6FADBDF63A4F29A9871B30CF526A83232CAE9D1A373DCD8E2DB547A3AE6AB0532735AC778A764A3951A9295DB453FD43D5B47107D5ABBBAF060F7E38B66451A99CC25C67F686303F4D136EC8CC087E89CAE2625F9A73A1B0B050E190299C9288FB8C0740B650A30D352EFE1D62E03C086BDFFBA904D87272B2949EBEC60678B1962D5BA2152B9669C182799A326592BEFF7EA1962F5FEAE2B8B764C9F75AB870BEE6CF9FAB458B16D8F9C21FA4050B6AA659B46891E5F97D352D5BB6C2D1D2A5CBB578F1528B5B62E9BEB7E716398A7F96BCA0F9F3293F31CD9B37AF06F9677E29A28DB439BEFEB5FBA1F6FDB973E7EADB6FBFD5AC59B33469F257360E5334EE9D0FF5F1475F6BCDEA4C7DFAC9972A2A2AD22633D55E7E652C8A40A192723DFFC2284DFB66B696AF58A36FA67FAB050B97EABBEFBE73449E90EF17DF5FFE9E8FA3FCDA7543CB7124CDE2C58BB57AF56A77FCE69B6FCC14FD42B367CF74F55FBF7EA3962E31B3D4D812A32A6DD566F5ECF990EAD6EDAAA33ADEAAF3CE7B429D8F1AAC94BAA7E8946E43D5A8C91F74FC0943D5AACDC5EAD4798076DFE32CEDD7EC0A9D70CCAD3AF9849BB577B323D46CEF133468D0D3AAB036BAB741CC2CDD94B351ABD7A76BD9EAB55AB8748581D2CCE2720CF5C09DCC2BC8773FAAEA79FC872861646D8A97943F06BAEDDD271EB3017361F9F2E5AEE3274E9EA429D3A66AEEFC794A5BBB46E9EB565B9A1CB7A3DD870A6B79388C195B16DBC9807F12F806FE4729FDB513447494491DE2101284D8EB2A6E6BD256073FB80EB62B05A1CC99C2E415F83D483E3EDF0E99CB6DF166569B06E07E6C62C205EAE8835B5BF2F509FACD055F1FFA21662D54B78774FE87367D9D7D1EF1816749E7D3107C3AF28C3F27C4C6C205EED1FF04EEFB7BBE8EFEE8FB048A49EFEAF6F12612F1E445FAA8C5638191159A272B4BEAD2A5BB5BB3AB5F7F4F0740B44060CA55B9677C39F175F5A6657C3AE2E9634C40C8FDD29359436C6B735C4EFD8CF143454C163121C2F20579D237615594613A57AA30DFF8CEACC5CB2E35E0A574D539E73EA0DF9F3F5CCD0EB8527FBAE40D753AFA215D72D9EBEA76DA30FDF98AB774D6D98FA8C7B90FEBD46EB7E8D28B87AB61FD4E3AB2DD796ADFF66C0DBEFB3E573416009A915F2CAEA8C22467A228AA397366ABA020CF298E0913BED2C71F7F644265AE56AE5CEE140726F3871F7EA8F1E3C73BA1B369D3263F0E0E23DB806647895F64E5E83BCEC733E05C5310D79F7CF289A64D9BE6241D40CCC9C971F75DA7E3E09A4AE7A798C311CC0C1E09069C41E43A52CA8F4B06E610A02484426177BFA6C36EF99944E2B7F198B562203C854CE3061F8A0DAE31753169FC40E3AB06F7CC7CE6DB9866FF735E66473AD920A44825C0B1F30A3EDB10E4451E30006DF1CCCD35EDF3F11C0326090240F20C49F00023C433A50FA4E599F83C102E1EC804CA239D8F8B7FDE07FF7CBC4FC5797C5DE84F0FBCB8E25C9C1762413E41DB49495108C147878F3110B6D201071CA3160776D609C79FA3C222DEAC0F0233AB3ED066CAF575F2F5E53A5ED07810529E277EDF90718EE0ECB90A587F84827D9F8C6B7E41B609D590090EEB677BB42047EAD7E771FDAED59F74C699C3F4FB1E7FD349A73DA0AE273EAC233B0FD319678DD11147DEA733CF7C5207B7EC6D88E8AC8E5D2ED7157F19A2A1F78E527EBE34737A9ABE99BA4CDF2F5EE18048B1696BD2DDECEC071FBDAFCFBFFC540B16CD75E0634D1330AE5AB5C2D177DF7D6B96C52C4D9E3C51EFBEFBAE3EFBEC33A7C9B34C72C5BFD348BB6B00ECA7121DEA8115EB44A701015C7676B6D6AD6396296028026960009EA122FC9E1D0E3F8D73AADCFADBFD8C1DFD6E91E5113B71C7AD1D0FB1A0CA8F504225C56167873340C54505E61F0403C179A4B4D880C8C65C9E2F77E70C5479994934031D839897BBA53A5D517E9672B2331C1517E5BA0F07318356561E8AAD5559394625613617979B1F906F6D2B777E0A134FB42FBE3F380210DA8C1F0DC5A7C1A7A6BFE88BD8C0B841E219D240A4F76960569E09264C0210622212E28F94E7C9F5732C3DCF921F82D4E7491E3E5F40E7051C9608E71C01225A323737DFD2F35B13E6FB448A8086DD931AEDD146FB34E9AA638EBED2F956F5EB1E6826E226CBD786D2C6ABC8C6823EDBB2654BF5CF6A5326449FD0171CE113EA4C7D03DE220EA16CA69F8D2B63EB6624E103CB9B710F6628A3CACFDBA2A52B1669F3968D8150E2BE29CD938FEDAB5D1B9CA6830FECAD534F7D442D5AF5D72187DDAA3F9CF78A0E6A758F3A1E35427BEE79AD2EB9E89F6A77445FDD39E4356DDC52A1759BF3DCEF617C3571BAC68EFD4013BEFE4693264ED30C33B9F145376CD8A4356BD6587D1132F4538929A00DCECD5ABB364D19191BDD356E15DA71E2C4AF357DFA74A5A5A5D1BD09B1B44DE48E504C02575F33B0F926423232321CD1E968483ADE33199D0C2370C49905B048160089A38B76048F4C1B13DC40DA9F78CDE5351ACCCFE0708F78BFC6E5406747AF05839F7336296C1A2E1A354674262668376DC4CCA069B832F753CE411C441AEE41AC1B71CDF3A4452B5246981D15AE2C345650A6D314C654742AEDF48C46209E3E22DE0B26E2E243C07C81E6F71ACE07CFB8F45D7CF0E9B847F0CFFBEBF87C38A74C7F8FF23887F17D7D49431EFE1E47DAE0F309EA6CC0AC28D4D265F3F5D1C7FF324DB29BEAD5395875520E516A4A7BBB6EA9F6EDCF766349758BDCD247D05704FAC1D793730265714E79FE1AB2B36A66678C6393762EF8F630CFE0C73F14C9721F92A23D33BE59A401D73DAA268DCED4D9673CAA6EA78E50C74E437468BB5BD4EEC83B7454D7E1A6019FD461ED86AB53A7C74C3B0E55CBD6176BC69C2D6E6572FADCA99A3CE34BE59A802660A22304F8815304544101938A59FAE8A38F9C1FCDF1BDF7C6E9B9E79ED1A79F7EEC342100F49A7DCB964CE7EF820D0B0E37B1F174E7B4BD1A50DBA358876D73EE332213E2376FDE6C6A79959316BE537D604049E3C114742A72B5521B3336289BC55153895C732C2CE663B1C628A69D78FB1A53911733D146FC1E1E475ED2B4A1AA8E2F0EE7DBE0049215331629EF7DC7801128336ADA2EC7818A673C931415E73922AED0CA24AEB8284FD959193608B4D3D214120F830675A71DB54D281FA8436D868B0F3092EF231887C075CCF48FD539B8E7D3F97C7896FB3E7F0F741F3CA0086849EEF9FC086825EAE7F3E51CE148F0E962635B1DC88F7CD3D26C7CD7AE70AF014D9F3151FDAEBD462FBDF48EDE7C7DA2DE1EFBAD9E7F6EBCE6CDCDD13BE3263BD315AD882B429F61FAFBB61228CBD7C1971B7F0CDA84D98A10F7FD8C898E560D8420443C8A00E19FB66E918DA1591465957AE6A9B1AA93D246C71C335007B5E8AD66FBF651DBF637AAED1103D5B6E32D3AB2CB50B56E3B5807B6BA5DA79FF5AC1A35B95C8D1A9DA1B90BF2659E91C21505DAB879A5667F6BDA6CD51A4DFC6AAA162E58A22993A76BF6EC396672BE6F3EE25C3343E7392DE9F7C0A2F97C3BD7AE5D6BBEE30477A4FF2C54E38A3EF5968A8FABBEB93D8A6936771E1BF4EA7B6478D34D37999F70805AB76EAD3A75EAA863C78E6AD0A081D390308A670C82EF580869160A176B4BF666035C58E9EBD7EAABC95F6BF6BC6F6510D26D77DCEEA64C5E1C33DAED80E87DCDB50E3A9F7EF58596AF59AD7C1B94A10F3DE03E9170EFB007556C12F4F3AF2768F8E323DC73D70F0C9E7FF68551EEF8CAD857956992EC934F3FD3C44953B4252B47AFBD3ED606CE06D598A6DC4CB2EC1C1B50F30590FF9C23FD08CCAACE9D33CF0D02E1A5975EB1B649FFFAD7BFDC6414B37B4845DA3A6CD830C7648F3EFA6835B8C68D1BE7BE0A76FFFDF7BB3E19326488B31890A83367CE748CF4F2CB2FBBB4CF3EFBAC4BF3F1C71F3BC1B662C50A4D9A34C9DD7BF3CD375DDE983B083FF2C00721FDADB7DEEA0677E8D0A1AE5CCC5D02F57BE595571C733FF1C413D540A36C988480B426FDEAD56B5C9B61AE75EB36B819E5CCCC2D666E65DAFD408861B267E798F593B5C94D60DC7BEF70D941C31E1CE92673DEFCE76766F5440CB41BF5F0F0475D5F5E7EF9E50E60F7DC738F735DFEF9CF7FEAC9279F748CD8A54B17576FF868CC98317AF1C51775C51557B83986860D777280E3F8F6DB6FE9DE7B86EACE3B06E983F7DF51B3A67B894DD8A975EA3A8DB53E7D938D73545979F9CE5F3DEFDC81DA7FBF33D5B9CB001DD1D9B461A7DBD4F6F0FE3AEE94BB74F8D137ABF921D769D72657E9F04E4395DAE05CD392B7595DAED7238FBC63829E8D01CBCCFFCCB2BEAD3017C8C05918D196CC2CE566E7A9B830643EABF1313F25656597197A0BF28A5DDB5048E9E9E96E4C11868090F12130763101548DA1784A18194F317FA3461C4CC0202F5BB6CCA9E7112346E8BEFBEED339E79CA35EBD7AA96DDBB66EAA9940A5D08C1C3129F01FF0B59C4D9DB9514521F3C5AAA2FAF4B34F34CAC071FBD0FBECF8A61E7CEC29A56DCCD109DD7A68CACC25FA76C11AF5193048AB37E5A9ED51C76BC99A4C5DDE678066CC5FAEC79E1DADBFBFF2B6E67CBF54D7DD7487328C1906DEF6A03665477559AFEB3561FA2CFDF59E217A60F8130ED027763B5B052551753DA19BBBC635E58844E4581CA9D2D4E9DF5927A2D5AB1CC321E98FE97AA23BD6ADD3C00DC205E75FA437DE78D318659C060EBC493366CC708CC44CD9CD37DFEC2436A081C100E495575EA98D1B37AA7BF7EE0E5077DF7DB7468F1EADAFBFFEDAA59F3C79B2FAF5EBA7CF3FFF5C83070FD6DFFFFE77BDFFFEFB8E9999FC6AD3A68DEB4704DE4B2FBDA4FEFDFB3B80CD9933473D7AF4708CF0E0830F3A4148006030FC35D75CE39600BA76EDEA8E0093B2C91BC6813233331D1891F08011FF302FCFDC0803274B3DD3A64DD79CEF66EAD3F11F3953ECF1C71FD71B63DF52AFABFB6889DDEF79E145FA76DE42DD7AFB1D7A7BDC3B1A35E61F1A3CE42E13B659BAF1C69BB5266DBD1E7BEC31B74C42B9B48DB620BC58177CE38D37DCF2059AE58B2FBE70826DECD8D7AD1595268C26B86381016D5D3ADBCE8CFF962DB2B8A872B27883D7DD760BF53DCE6512A6856E1CF8A22987637454E71BB57FAB5EDAB9C9F9DAAD510F1DDCA6979A34BF44FBB6ECADF69D8768AF7DAED6393D9ED6DEFB5EA406F58FB1675A6BE04D773B0B6DFA8C299A3563A6664C99AED5CBD254546056053B0762E5F162F29CD9F3B47CE92A270C70BDE873044FBC75C118C46BC0ED51C2C878A2A3FC391952180CC68023B9BD69C1002301201FE7434CA35A08CC0ECC553463714991D38898A400B2C0EA3F61C65C7DF0D954E599BBF5FDCA1C7D36E17BADD9688018F6B26E1BFA8CB24C0A679855F5C197F374E57543B42E47CA340576FBFDCF2B64C58E19FBA172CC0D7C7EF4077AEF9399BAEBBEA75C3CFA3DA5DE1E2A31C0DD36F821356DDE464556DEFE2DDBBBCFE81DDFED8FEE3E715985511DD0A29DFE7CD5F51A6D66588B16EDADDED2BECD5A6AF42863101B0CB7A1C48E80D30D0E076B3B6D45FA797F911093864E03900690728C0D50F539C439C13F13274DABD3C70F74F01DCEADE9191BCE57AE5CE9AE798638C684B1E49A6525CC27D2B060CF58F28C1F367CA2F8C0040E9339EEE3BFCE4F0FDACDF4BE8D9C35BFDCDC0513AA6622862BF8CD414BE728980B58BFCE8483352B66AAB9B2FCA4527CA08EBE1D046F45510A73049830FC0A1420C4A72FC8F73B5CAAB470DE129D7BEEF526285B6B97065DF5D0FD5FAA4387813AB0E5D5DA6BBF4BD4BC6D5F7539FE4EF775EF030FE9A303DBF457AB7683B44BA33FABE1EE17E8F85387181A0E57BFBE0F3A50E7E6E7595D62BF85C190588369FADAB4744D993455F3E72ED2CAE5694E6B024C261EFDD8313EB485EB18EF3BEC70FC214A18599BC808958B5467C9C2CFDC51208C458839A6D5662915A152101522DE6D7773CB0554D0FC3FEB50B4A35BE2301F6F55FA463D3DF225F5BBF10EE5599277BF9AA71BEE79566B0D5CB70E7F43CBACEF4F3CFF3ACD4E2BD11FAEBADD5D7738FD0A773CAFCFDDC2F3B9B0F71D7AEDE399BAFECE511AFAF83815591FF0FDCBBFDE35483BEDBCBF3664942AD7F8A05193DFE9DE079E57CBDF1DA3534FBF5877DE3D42235F7A5F279ED653AFBFF999F98ED26EBB1EA85E57DEAC91CFBE257E871D00EEDC700F9586A3FAE2F3096ED9C5CF3AC2C89E71D0FC081CCEBD6FC9118B82BEA0FFE80F7C35FA70ABB00AFA94E081E7FB932396086991C010F97DF5D5578EC961620F52D2301E1C7D7EA4F1790142CF283CC7916BCC5BD2FBF1253FEA487AB72616315FD3DA929F9F6B82B44065E6BF87AB8A55AA908AAB0AEC6F9E79F121852AF2158EE2D3FB7CC36EE69BE0FD53CAF2E0447051166BCCACD3115F58586C7E7CF0F36BF90525968F2534E015E617D87985B2B237181F854D0020C865E3B14CDD4EBB55B7DC32D6AC8349BAECF231DABB592FEDD9D4C0B84F1F1DD4E6161DDAC57CC4436FD21ECDAED61E7BF7524A6A77B7DC7154A7EB0C091DD4E7DADBDCCFB5515699594780903667AC5FA7D9D3A63957A520CFEA4F5D8C3057DDB9D531586E314513233428AB00FE371E77841246D626068C4E64B9C2FB41749E9762300E6618A60FA6D8238F3CE27C1D7F1FA6E159163F597361FFDED469133463D634CD9E33CB494FDA3479E6428D7D77BCAEE873B303E380BBFEA64FA6ADD48D4347EA8AEB87EBBE273FD4883113DD8F8CDC307894468FFB4EFDFEFABCB22D6DFF3B5F54811577DBD07F28C3AAF8CEF8D59A31AF58FBB538DA81B15EFD5D74FC89E7A8FBB957E8D0C3BAAA77DF5BF4C2C8B16AB0F3BE5AB0689D39F8875A6FECA6BCA22ABD35EE331D726817DD71FB433AA4F5516AD6B8A5323714D9FDFA1AF9F7D1D55A31541C6C6D22A03D9CF4B691C9CDCD360687F18319E0ADC72078A0C56B0AE2E827B427A624FD85F0638118B0B0460548BC4FFAEAABAFBA31E11E20E38829CBB8000088F41CC98F00A8484B59BE6CCAF4E9B72E29040BF13C87E98BF60C34B031969B2433609797987E623344B9C29556EF4A036465915920762C37615369FE65144D1ACC1BB0158CBC314DA92B429CFA730F9EE21E02C6D7CBB5C38EA56C1D336187B0A6AF996D271E8A98B62AB1EE3FFBF7BDD578AFE39452173A514DF7BBCC2C9BEBB4F36E57E877870D56B3030668F7C67D94BA2B00BC4C2DDB0C56C7CE0FE8C083FBD9F5F136AE87EAF2ABEE57A199480CEDFA0D9B5D01B3667DABD93367293FDBFC65DEBEB0B8C2FC22656FC9715A12C0F92304F07E0AF86A53C2C8DA44C7D0793008CC42C711307F9098BE03095EEA13308B78D607D47EC0A43063D486D63AB734E416FC172E5AEC40F8F08851FACB35B76BFABCB5767DBBD66444F5C013AFEBEB99691AFDFA24BDFCE654333D47AB77FF61BAC380F7E67BB3F5C957CBD4E9B88B34FCA917D5E786A1CA359BF4963B9FD71FCE1BA0175EFCA7314400166ACDEF2620A437669A1962D7C5610C2DEB64B365811535CBCC2A74CFB866D9911FAD5D386F59C0014639D9C6B4019E5C603302E9616CDAEE350B121F6D861FC46409DBB4D8C6C5A4CDECD9B3DD6608B67C6136728EAFC8C40A71F42BF911605200846F4EC0478C0F9EA9191BAF096178E249CBB8F93182F149E7AFBD60E0E84101F13CF5C684659CC903ADC87211160EBE3E4B53D966CE15981062028DF9F0B08D31E4FA9A17072D0048CF37F1E6BB0FDC27D05ECA8548076F646C36FE2A0BBB19F64815DF3535CD6D6DC5CFCF292ED3F997F4372E6EADD4FAC7AA45DB1BB4F35E9719207B689F036F30B7E32203E240EDD1A88FF6DABB9F1A37BD557B341EA8E607DDA6C67B5FA5FA0D4ED59E4D8ED36967FDC52D67B0C5EDA34F3F31D7699D1B2FC7E756B562D3C6A102EBE37069B0AE691A9A63F6962C039FF59FA571C704D8F9299430B23601283A93D922A435C0F48348473288749E97C49E217CC7FBB484C0E730D3ADA2D43A39E43A9CA140FACD5AB8522576916B8F715CB46283F3F1366DB1FC0D29FC4865898D0260DA62CE333911C731638B9937966F9A4970062A33DBCCA55293F8766FFD863556B7CD6E3DB32854EC9808493B6FFE42337772DD8CEA8A956B34D59CF5B0752ACFAC4E5B6BCC516ACF0596009198A7F83F009159469A89894A3B69374CE4850F8CC58C20135C808C5D17F8D84C96003404154788749F7EFAA9B32E98D860D694891D8E1F7CF0819BDC60D674E4C8912E6FFA973EA75FB140BCFFE5FBD9838DBAF8FA0028CEA9A79FC401E45C7B0182804078F8B4E4E3038CC98609B42360E4B9B2F20A33216D6C4CC0E59A29C9DC466149F0FD51C693BEC6EA4100B324411E9445DEBE7EF49DCBDBCE11983EC0277905D96E298B9F502B2D2F54B1B698E62D32E31403D55C8F214F1A07B754AB43AF52F3167D4DCB5DAA238E7D4CBB37BD460DF7FC8B3351F7DEF76AEDD9F812EDDEE8421DD07C809A3435ED58E70CD54D3D41BBECD659F5766EA10213C4EB32334D0863FA1A0FAD5D697D59E6C688718FD77668768873DF475E18FA342CA9D11628B6A5B0069EB6470923B7478010868AD7866E50AC5274280CC8395294C1F681E7A82C148091C699A6AA0A5EBB2934862F0E45B4D6183CC78CF6023347726128933EFC4E02E0E0951C76C4F85F112A8F96B82353EDEC92E19AA9EDB01D498FD04013E383F06269289CED3A3ABFD07CAD98C465E288ED78C57C31CC95633E9EE5C22F055147BF8EC5822D26281A114032EBE8CD53DA84F6E0489B39D217F40F830950F0DF3867B335C07CEBADB7DC343EC01B3B76ACDE7EFB6DB7B4C13D964BD08E4CB030BBCA39606429807D8DBE8F190318195032061C89F3FD4E3AEAC03D00CB354C445DA81FDA997CA857302ED5930DD581FC49E3CD61FA22E853EB07F39561367ECC85FE66EB9B25B56B036B2C8E5D558C1B263AF304940B511EF5E1E8C11898C8EC580ACA834F36673146E55AB17A891D235ABC6E81FD35616355E979E99D4A69D059A90DCE30BF7F90B921BDB573A3EBD5F2B0A1C6D57FD47E07F735D3B4BB3A74EAA7464D4E569DD4C30D84471A083B98166DAF73CF1BE8E6062C38DE0E9599F999B7C9F8107E7102CCB9673101B70D16E229D66FD5D7FE398EF1F13F4609237F8C90A89852985C741C929AC291127EF060043A1860326D8EE465E0B987A39E95B5D981C2BDFB66838AA3EE7EA0A4B24C45A5C5EE1EBB1F8A43F9AE83DC2F0319B0D8E6163629CBD628DE17E388F9C426627C43AC8592907502DC00D92903CE5A2279210420A4B503584E96630A88A5170886E3886FC4648CF7FF8C5F8DE9C3C6F4998E69BCE6E0591F60D0E5CB57BAB706780364C99265D64F0B8CF96757BFFD0001064C5388A97C008966FCC73FFEE1C0C772C80B2FBCE03617BFF6DA6BD5DA953E8591F1E1E857EF2A0032CE39323E583100D49B99F4014CC3B3AC8BB2FC82C0223D33E4A48D318F1B4F4F8C2BC294407BC99B31262FFAC092B836738E0F8DB0C2AF436B62A6F2C27156CE163773CEF3D403DEA01EE40D2108E00DF2A67D31CDE3CC535E509E316BBA09D13C074466CA4F38F59A98AF77A2F9FC176B975DAFD501FBDF67A0EBA57D0FE8A5BD9A9D6FF73A18F87E6726EB01E63B1EA833CEBA48FF7CE70BE5E4B183C8144451E07BFAF72E9909862FB6EE3D0E78DD6B362C20267338C7242D2D61522AB8F79FA28491F1C400C5239C81F0F174EEC489131D43617ED199302680F38CC13569195066C8E86CBFDE985760A65A66863311D3D76D52FA9AB58E412006876700318CC200B23998C5D5E2423389CD2C0ADBA017E687B4717DA68BDF9091EF16F6376F2A50EEE61C65589E9CAF4D5F6F9D1F75C04308B081973A520EF9B2B6969393E75E02CDDABCC5AD67C110948B2540BB20D6DF48C700D10E8207229336ACC9717FC284498E39097EE3358309D3410418DD9F13606ECAA4DDF4256B960016204200944DF7000933133052378E1E9080936BEE3399C3840DC290BAB22E4C3C79E3A302560F320F3A02E3CBB8429C134FBD48C3C23FCFD32FE4CB39DF7AC932CB81CDF8A463BC387A5031C66CECC8C9CB76F78887E84FAE01256D278EBEF4FD40FDD998B1DEFA1C614D4FAD4C2F50CF4BFEAA5D763F56BBED799ADAB4EFAD835A5FA98E470F529DFADD55AFAE69CABA872BB55E6B9D74724F0D1EF288DB88C0B3583E087E8E816035EF93ED906EA924E0EDF8978063E31AC4DBD8F9F3DA8412F8B10F4DED28258CAC4DF160AC15E7188A01C3D967A708E044EA7AF3874EE51E4C82B6C0315EB76EADC5AD726B8CBCEF95935BA86CF301B336651B88CC94DA98E500B671DD66A5ADB6E78D962C65AB5DBA0129CDD1CA95AB9DB9B8654BB623F60966E6E49B2F6900CC3040E56628376B9D0357765EA6D2376D56E6A68CE0DA1C6F7653302BB63E7D8332366ED106F3055943223E7D8DF9C6EBD9080CE3855DFEE906E88D1B331CD8FCCE1CDA0D9332B8CE14B351E772D2A429EE4808B6E405F1F419E4191EA6F6E69A0703C18394FB3026DA04E0D077F87468482C13342C7E1E1B08D0BA808C091B2C16883840CD7DC6052DCB2412662BE341A02ED4C90B150FC0A05D41406005C732D7CF800830AEB771DC9CB9411BD6A7695DFA2A231312EBD3AD9E4C58A5599F99203310B266C7E2BF171A6862AFD5BDF045B0F0BE2AEFAE72CD8603ACA52FBE9CA4706985B56DB1AEEC3B40A90D0F30AE6D6E1A8F2FB6B5749AAFDE1E87EACC0B6ED0D857BF54A8101F2FE877C605F72552860503604CDB1B004325665D95E21E6D5D43F794683634F692708DB8DAF49F0064C2C81D250610D0C12C3E30504861769530F9C0B6AE2FBFFCD231038C01030156243C0C05F3700D83C168100CE3198D5D19300FC43DF2F6D74CB9FB174D7D3E3F449E49E3AF993C81A88B3FF7E988836072EA4E5D6062DAED34751C88602C0F22D6FEE81318CEDF47E2C3E83CC339478008D37BE2793436F708A4C74F44C851077C48267A00153B9C28877EC6CCA58F3165E9EF60D3F27B6EDB19CF13CF7358305E4342B401C0536E3CF87CF075F201203136E4437D38A71F7DFF11E7FB9423C200ED4E5DA93342C10B6CDF06FA95B4D40B4189C05C9BB64613BEFA5AEFBFFB815BABFB7CFC173ABA7357E3D6C6DAA3510B5DDDE7568D79F95D4D9BBE50C5C67A4CE8E1A20480B3BE8DBD8513EC2B36AD8F4B62AE0DFDEE03022836360979FB97A08491DB2398C33315D73486C1F40C57BB71A4039C98AB9834800B0662CDECF5D75F7793166CEB62CD8C890C180802C44C64C04098663014CF10EF8938988E74302044FA1FA2F8B4107913CF5A1E04D342F1D730393399A487B900986750DA0B786827F1B41510D24ED2A001D0665806B41FFF8D74101A8F6B8E6802408E5919580EEB1C5810745C13601EEEC3D08092F63309C4AC2B7D487FD21E181D502038D036009E401DFDB91F3702E6A1D7D080138D4D9C7711E2B5320212F0FB71F2FD495F513642813EA3BF7C9C27FA99B4A40190B48173FC64DAF1FCF3CF6BC4DF9ED0E38F3EA6912FFC5D6FBE3156635F7F5373669BB6379A3DF35B130EB423303B99034073BA73FBCBC45B857BBBC6F83362ED091598F988503341675A8B790578375E10D236AEFF57809930329E7C45E32B4B1C47E268108D837C7C6DDA5E63197C808A8663A06130988AC90BA6F121263198756462836BCE8983B8261E866440FD333F463E0F18E0B9E79E739BB39F79E6193DFDF4D3EE0811471A9FFFA851A3DC2C28CC864041B233D309F3C3A80007400134DA82790E000110C0029080836BD241DC6751DDFB728012EDE327BDC803C6257F0002B849E341E28F000D2D467F7A8D0DB37950E19F0170AC09F2A23CCAA50C341265A3D9B13CBCA581C6A26D808AB6DF71C71D7AF8E187ABFBDDF7217DF5D4534FB935508ECCFA72249EFB3C8BD045E0E2F7C60B61042C828BBE40A8D5E60F4FFEA5723FBBCD445CF0C5050352256668A1999C59D56FE47853949974260B999F0826E182FCBC42F95F00603C258C8C2780E4A9F6BD1DA59FF2ECF680FBBF40B1765407069577D430D7606A0F50B40047CFD8DE8CF37E1DF700199A01F39C349873C4A3313C08D028302D160079C2BCAC3D727CE79D77AA277720E2B12E7843836720AF35617E40018038273D262C65A0DD280F331F41013001316DB3E0DA0DE0012F80F5719E76746C49F76369FDFD44E9F057F9FC212F85870D689506BA4884C9C06CBBCDD24CC8019497BFDD97DAE22666E209DE8A6F1BB42375FB392861E4F60889EB250A47AE69583C786814D7BE81FEDCDFF3E9FCF3F171F1E49F8D7FFEE726CAF5141F47DD7DF01A8A405DD14C6834CC39CC35CC39DE5280001726B637E338073C6811DE82409300124C5180813603C4682CAEBD164593A041298734683BCE21E22134289A349EF162F576E7D435519C8F8F27E2D0B03E2D793276FE7E3CD5EEAFF8F8DAD71079935F6D80788A6DBAA8BE667921982CA934DFD04CEB70703F8863D635D8E5150F46EA8D29EECB89AF4BA2B85F8A1246EE28D191BE53B98E3FFFA9C4738918E1E7225FBE6F53EDFB507C3CE7FE1AC68C9FE8C0F4C6E4460B794D84198DE9CB391A0CCDC6C23EE025C4F272F978F2D784DA132CC41317578FEAC03DDF160B09EBBF23B4BDBEA80D1CD2D58EFB772871598C4BA5E51FDC63B6937DA0BCA9E1D378DA9E36FCBF4209237F887EEA80FE9AC9F7058C08A8387AD0781011E2CF615C7FCDB9B7367C20CEFBE19C13C893F35879EE3A51FE3E5DECB9EA3AC65FC7D37F622CB797F77F833C206B13BFA1117FCDBB88F1D710DBF36AC7FDAF51C2C81FA2449DFF6B03E88FB527DEB4F3041021FAC70392749CFB6B0F261F001DC183CB13E90023A615E7FE399F1F65F838D2FBEBF8B189DDAF51C71FA3F8E7E3CF7784E2EA54239EB89F529760513E38F70062D1DFBDB911DDDAEF89F204846CB1AC1DFF7F851246FE9629D120D796BCAC0107EBC035D355A94CEC9DE5C8D7D3985060719909054FCCF4F985E8DCBCCDC18483F93894EB670B3D9196FBF842CE1F8A6940D2C6CCC2EA904840C4B70546264DA2F6FDFF52F001B0E09C0F51F9F3581D6BA4FDA920FF2D51C2C82425A66072A02683B12F33FE1AC2C789673A9E0358049E672B56F0C271E0F331535890CF7A2DD7DEE4DC6A7E9297D7BAF1608A4DA26C53274FB1FBDBC47BFA29C0ACA8B5C384D7893806DFA88D4F57334F2F246A3F0F712F09CEAD9430F2B74CDB6350341CA0F29304F82FF13E0CF7FC79BCD684E1D88BCB1A186F7AF0AB4D800FE24B016ED53A466ECF72EC1C6BCD596C760EE063966E0D30C66B3A8EF1758827181EA003CE385FB4469AEDB5DB1360FAB11F7041F3A3C18363E234DB03DF8F95FF5BA08491BF65DACADCC114391A2DD06A3062603E06BE0BBE60F0763F3F47C0FB7AB16FBE56E7E5B5D9560D0778B64EF2782D08A89DAF687C0A0003CD4AFE81568CD529FEBC469D3DF975B6C0B40DE27E2A93C76B59EA9A48A3F93CE381E5EA5B45B926B0DC827CCD6792F4E39430F2B7483FC6B430788CF99C99E95FAB0AC8FE3A80C1B88149EAC8F9804140BB555415BB772F030D1BACB306CFB33E16001CE2392F08B807F1456E0BD5F5D96AFE6D7F82241E2C9EE2D3C683BBFA187B63BDF6C667F679C62F1DC49664DC79CC54B710ACF3B10BC682BB17FBDCC836E750EDF5C0DF3629E5FF018DE1AB636A9FA3F40000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A340-600'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000CA0000008F0806000000BBF04477000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000052B749444154785EED5D077C56E5F5A66AEDB076D77F97B6D656AB55BBB456AB56AD5B6BEBAE7B2BCA908DECBD026492BDF7DE7B4F32208B2424810412C882EC3D09CFFF3CEFC70D1F1F1F4B408D7EF9FD9EDC7BCF1DDF1DE7BC67BCE73DEF1400269860C2196094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269C0D86868630383C24ABBAEDE1D1110C8D0CAB6D2E7BFA7A27F64D7618259A60C2A9303A7A4C108606D452AD8F8DA2A5BB03833822388AC3BD3D13FBF4313C3A80B123C7056B32C128D104134E85BEBE1E0C0EF6A3A7A74B3631A5777000BB765722283A0A617109A018515848E77E7D0C8DF463746CF024FA648051A209269C0AD428478F1EC1F0B08EE1FB8646D1DCDA013B374FBCF6EE4768ED3D2E20BBF7544FACF70FF6811A45DB9E6C304A34C1845361644C0405E3E052A30D8E0061B1A958B6D61C0B966D4047FFA8DAD7A5E7A3F4F68B261AEE9BD89E6C304A34C184536160A85F1CF64170A94F4FCB29455CCA0EFCE1CFFFC4662BD713F61183C303729EC9F432E12B02CD99D740479ECBF4EDBB5055DB85F7A7ADC06B6FCF878DAD8FA26BE81BE8152D34398584304A34C104438C8C887D6584DE33D88DA1B1A3C8CAAF40724625EA1B81BBEE7D1177DEF51F242517C921BAE38647194A36995E267C45A039F11AFA47747E48C5DE662C5ABE0D193907F0F2EB4B70E59537E0D63F3E88A8E8D889BE96FE41E361E3C900A344134C38571C38D40B735B7F24A6EF86B3672296ACB4C3FC85E67074F44463D36139C4F879930546892698702AD047A156615F0A41938AF45EB1CC7276D6607B611D4AAB5A915F7400A919E53033B3466B9BAECF65E488293C6CC2571CED7D23C829AC82775012FCC3D2101E9B8DD8C4ED58BBCE0C03833A87BF6FA05B2D27238C124D30E15C30383A82C33DFDC82828835F5822B66C73878D9317A213D2B0798B951CA23BCE2428267CA540734B03B7074686517FA80DF11979088C4A86476004DCFC02515C5E09730B1B750CA1DF4939D96094688209670B8DF9F34ACAE0EA170A737B3784C625C3C1C30B3B4A4B61B679AB985E9357403418259A60C2B9627B61197CC3E261E3E28DA0E80458393A8B9F120D0B2B4BD13CC6FB6026138C124D30E15C505A5E8DD8941C044426C1D12B184EDE01F00A0E427064385CDC4E4E67998C304A34C18433A15F2F8DBEB8BC0AE17169221C5170F609C636676F8446C5C12F300C21C11113C74D6618259A60C299A0995387DABA9157588A90E864B8F88628D8B9FA2A41F1F40944BCF82BDA3993194689269870B6A8DA5B87D4AC5C044725619BAB8F121467AF2084C724C0D9CD1B05F9C7F3BD26338C124D30E16CD0DBDF879DC5E5884D4A435064A272E41D3C03E0E61B8AF8940C58DA38A0B6A65E0E357EFE648251A209269C0D0E363620233B1FD10929F00C8810273E08B66EBE70F4084056DE4E2C5BB90E1DED933711521F468926987036D85B5B83B8C43444C625C1C1DD1F9E41914AABD8BBF921776709A6CD9C8BA1C13139D4F8F9930946892698702630EA555452AC042524325609877B40382C1CDC957649CBCE53826278DE648551A209269C090D4D8D484C4E426AC676F8068529BFC4D12B1066364E2A541C93988A790B97CAA1C7CF311C1D3999609478B161385AAEA7E7B81DDBDD7D62E2DCE0E0205A5A5A4EA069686E6EC6C080F1D4ED8E8E0EE8FF0ED759B08DD0681A8687CFFE03F27EB4F5D6D6D68975A2A4A404BDBD9FAEE81BAFAB7F6D0D7C375D5D5D38D53D1E3E7C587B26B53CD5FBB8D0A8ACDA8394D474E5B47BF9072B41610ACBB2F55B91909E079FC050ACD9B8450E3D7ECEA946494E0618257ED6E8ECEC3C8181F9B1C91CDAB6C6247CD15CEFEF3FB1B00161C824C698EE5C702A8122E31AEED3B6F91C1AED4CE0BDF27863CCC3DFD1FF0DFD63B8CF983090CE67E679E7FBECA782761FED9D1DC8DF5180D47431BBC263E0E11B08579F10D5D9B8CEDC56F5D253CBB87AF8AAE3BF0C304AFC2CC08FA9AF490C19861F9E4B3293B6AE31005B6DFD733F0D0C994F5B3704B519B5933ECDF0F8BEBE13C7821B13B23381D730BC0EC16B9DCDF5F485C75843722151B36F2FF20A72919296AC3A15354161D48B3E4A5462269C3D7C109F942E871BBFC6648351E26705C356D3584BA8CF3C86C2742ADAD9E04CE79DEEB7B4FBD4BF7F4D78CEF57E8C09C7E9C0DFD417547DCDFB59A1A2B21C3B0A0B1013170D17771F25284E9E812A2C4CC4A56EC7862D96282ADD2D871BBFC6648351E285843133C118F485E4742DBC31E6D4402625E351E3F038FD633F2DF419DF981633149E4F0B3ECB99EE97BF652888676A482E340E361E40C9AE62646FCF42786418DCBDFCE1E51B0407175FD8BAF8C0DD2F0C99DB8BB168E92A34B6B4CB29C6AF33D96094782161C8CCDCD63EA8FEBE537D6432BDBEB0E93BCB867E0C19CD18339D0FF4FD086342AFD10C99DCF0B93F0D4EF71CFC3D43E1BC100DC39940BF243D3343212A261A01816108088E80A3AB1F2CEDDDE1131C8D8C9C22CC99BF18FD03BA21C017E25D7CDE304AFC22E3CBF0D23F0B5C0CA1E9EF1B46744C021293D290929A8990D048F88836090A8D828B4720B66E7351A92C310999983D6F919CA23BCF24289F234EF7F23F8B96F5AB82C181E33DEBF97945C8D9BE03D939E29FC426C1C9D903F60EAEF00D085582B2C5D2115171E9080A8BC7FC4F964D9CF7658051E285C2E8F8F9D9ED267C71D0DD3388ACAC1DC8DF598194B41D080C8E878757B8F828C10A9EE2CC5BDB38202D3D076EAE5ED8B8E1C43E94C90EA3C473C564AE296BC29931347C0475F54DC8CCCAC3F6FC5D888C4915210983B76F14FC83A2E1E8E20D67676F3838BA21392513AE6E5E7077F396538D5F6F32C228F15C303C3E84231847EFE0087AFA756ABAA77F04FDC363E81938399ECF6AE693B5A2F957155DDDFD282C2A9B109480E0186CB3F3827F601C82C5CCB2757087ABABAFF257E2E25354E595B4D42C39D5F8F526238C124F07DAFF8CF430E2C2F5917160EC28443074CBA2D23A505C8E08868F8C81A9D83C9ED5054726F144325F65B41C6A574242FF2433A7083EFE11B0B2715782C2751B3B57B87AF82338241241C111D8B2D50AD555B572AAF1EB4D4618259E0BEC1C7CF1AF875FC4AD7F7D04FF7CE8357CEB7BBF434C523E44A9605404A7B3AB4F04E4889A0493F3FE519B1C111C3D2A9A6574F21644FBAA6078640C55D5B5484DCBC6F6DC9D088F4A86976F185CDC82E0E91D210212083B470F7878072122320EA161D1D8BCC5123DDD5FAE46D128F174189117A7BF1D12968CDBFFFE845CE9E7F8C36DCFCBF2D7B8F2C77FC292E556E815CB8B9AA57760146DEDDDC7FA23C671749C112BC19173EB9536E1B3477B4717B273F295934E38B9FA2941090A4980934BA0985D9ECAF4F2F60E466C5C321293D231F5C31972AAF1EB4D5618259E0D8687759D49C4CAF5D6B8ECBB37E0BEC76762E6021F5C76C51D72E5DFE1D187A7617F7D3B46C53C3B2ADA655CA4E6A8AC8C8E486BA30A36EB340BA15DCB842F16AAAAF7AA7E93F48CED888A4E508241073E3834118ECE01D862E1A04CAF808008E59FB00372F69C0572AAF1EB4D5618259E0D34CD327254FC1459F10ECBC294CB6EC613CF9BE1DE7F2DC1AFAEF91F2E99723B7E7EF5CD88884AC7B808CB08656B5C24E6E8288607BAD1DDD63421282661F9E261686844B449AE12948CCC5CF8B3BFC43D00A11189F0F18B12F32B1896362E42F3437C7C3A929233C43FB1167F26574ED75DA3BF5F7C53032B6432C228F16CC12CD5BE9136F48E76605F73133E98B106975E7E27EEBC7B155E7B2304D7FC66BA08CBAD58B9C213BBCA1A91B7639732C5180060A4EC0846D5FFA3E2FEF7F4B66370E8B34FF0FBAA63ECD860AAD1615DBA8C7EDACCFEFDF52A7A952542426DA1225B3E614A48BC7C22E0E0E48FAD96F670F70A548242D36BD1E2E5282ADC35718D2F0B8C124F07FD17A92260633DC2E6C3B21CC29008C015DFBD03575CF9381E7BD2068F3EBE4D7EE156BCF1D60624A496C32F240959B96538DC317C2C523684EE9E3EF4E8CD1E3B7644A75946862F6EAAB809C6A12559D289CFCADEAE84841AC5C5D50B2E2E3EF0F00882B76FA482ADBD8F12141FFF302524C48C9973D0D078485D831A89CB2F038C12CF05DDBD1DE81DEE044D302AD8A4B42A7CEF87FFC4A55F7F00FF7BC50D7FBBF763CC98E786B4BC4684C596E0C9673E82B57D280EB40CA9C9FB790EE72AE7B5F4317644AE3789878E4E36680D204D252E0F363409E327202FBF10F10929B0B4B283AF6F289CDDFCE1EC1A0877CF3058D978C0DAD60541A131724CAAD23AD367CC56E713DDDD9F6EB4E717114689E70AA6AAF48F760BD38F614834C5C6AD4172E53FE0B7D7BF813B1F5A888DB699A86C0076EE1EC18FAF7900F73F3603D68EB1D87B700087BBC6D02772C2621DBD83A2A146C5A6551D9272351116FDDF31E1B343496985F81CE9D89EBB03E111B14A50FC8322958F424171F30A83858D3BEC9D3C95A044C624C2CB3B000B162E91D375D7E8ECFCF284FF8D12CF05A3C3C71DB5CE9E6671ECC754FFC9FB1F6EC494AFDD8A2957FC032FBC63099FC87D482F1CC133AF5BE2DEC716E2D5A9E688CBA943594DBBF83703E813E765809D97E2B1701E73535ACCE707CEB9C89070525AA64A49618F3B05C2C33B44F59F38BB07C3C52344CC2E7795BE121A118FA8D82435BB96AD9D935C42779D81812F4F43679478AE181AD031F5510CA2B5BB597C9571ECABEFC3BF1E7E4F7EE1163CFEFC6A7C38CF0B6F4C73C7736F3AE18E479660FEFA48241575C037B20061894568974BF48866191281A1A33F9967909DECD8B1B304B18929C8CEDB016FBF6038897FE21718A1CC2E27B7409DA0B887C1D6C11F0ECE5E888E4B55A6D7BCF98B919BB7532EA1BBCEE097605E140D4689E78323E8474945B18A6E55EFEDC23D0F4CC7B4392E7873AA3D7E78F5B39872F9BF30E5BB0FE395396ED8E29B837F3CF62EFEF9C43BB0F78A41F9BE6674CACB1D3D3AAE22619C1C733297B8998CE8EE1940E6F67CC42424AB2A90D6B64EAAE79D66979D93B7985CA170F70E174D120C2B7B5FB87906284161FFC9B4E9B3D1DE71BC81A3BFA3DFDF36996194783E3872B40FC363BDC2E610F3097070CAC46D77BC8947FFB30CFFF99F15BEF193E7F0F59F3E83C7DEDA8A755E1998BEC85184E75A4CF9CEAF60B6CD0DBBF7D5A3B8A24C74CAA808DB30BABB59A145972BC6E5E946FD1983FEB895733DF7AB04461FB9A4B9959E9D8B84E40C35C497DAC4D9CD57E57259D9BAC1CB2F521085F55B9C306BC15AC426A42331255B650E4FFD70A6BAC6F0C8F819FB4E6896698183C900A3C44F8371D561D88F312528FD18181A14AD00F40D1FC13BEF2FC2E5DFFE13AEFCE953B8F2BA5731D73A13A1059D98B9DE0B8FBDBC00BFB8E911FCE4BA7BF1EECC4D38DC09EC28DC83E4A40CD53979F4C838DA0EB762B0FFE4DCA1D1B10171F8752F7B68F8C47418465CFAFA06505DB50F8D0D874E28C84098464ACA3B181DC1E0E871866EEDEA434AE676E41494202C36555556B176F1838B4F38ECDD8360E7122002E2001B7B6FD5D9B8C5DC59042A0B01C151D8BAD516AB566F98B8962128186732C5D890191B6E4D81223ECF70B351E2F9A07FA85D69021A4FFD0374ED81D2F283A255FE87AF7DE74EBCB32818091540C141C03EB402EFCC77C67DFF9D87275E5E8298F47D088D2946784C3EBA448397551C407B5B0F46478EA2A444D789C54818132B0D05A3B7EFC49A5A559535282E2A47487024A2A3E2274A01513369C77C15C140091354B5EDBEA1E3EBBBF7EE575338A464E6C13F2C46555471F209C336177F057BD7406CD8EAA87C146FFF6825286999F908098FC3FA0D5BE0E6EEA3AEC5F12BDA353F0D8C090BF1799A714689E783EEBE56A551D85A1D3ADC865E69B999EB5554D288E75E5B8E27DFD880875EDBAC04E689572C70DF336BF1F08BEBB0DE3603FBDA80FCB2016CB08CC4953FFA2B162C71469BF0FF11514DECA0AC3F58A7841062960D0EEA3A24474675B1FAA1E1E331FBBEDE61C4C7A5212A22190EF6AEB0B1B6477BFB97A722C8B942DFCF63CD606A7B6D5BD328AD5DBDC8D85EA06A06874527C2C95384C3D91B8EDEA170F60E838DB31F6C1C7DE1E411A242C356B69EAAC331396DBB8A7ACD9ABD0009896913D7D54C2F6A016366D8E94CB3B30D027C96826394783EA0034E47FCA8E894B1F123E811BF8213F21F9146A6B16D1C3FFFC323F8C10DFFC5A53F7E1C977DEFDF98F2ED87F1C207EE88D93E8290D436D8FB96E15B57FD0B5FBBF21E7CFBAA47317F892B76D70CA07C4F93CEEF39AAD328FABF3976E4782FFEE0C0286AF61E848B932F9C1DFDE0E71B0C17670FA335C34CD0A1A3A71FE5D535484ACF56739D0484C78A9078C2CAC103F69EC1F00C8C819338F19676E2AF7886C2414CB00D9BEDE1EC1AA484843ECC6B6FBE87DA7D622618B9FE99702AA1A1B9C512BB9F47ED324318259E0F7AC4041A18EA55FD209C5A99A92D6CD198EE42F95F6BE589879E5F80EF5DFD14AEFFD30CDC78E742DCFFF456FC6FAA37FEFCC0624CF9E67DF8EB834BF1CD9F3E8B1F5CFB1AA65C7A1BFE74E79B28DED385D6BE51341BD10C23A3C7B48BD8B8070F34637B4E212CB63AC0C1CE1B09F1A9F0386612F03E4C51B493B1FF609368937CF14D8A5429549A5D76AEDEAA4E97B36F18EC3D02E1E61F21C2E38B4D964EB0DCE60E3B69885CC50463448C21E20FA7CF563E291D79EDBA8D8DCD13EBA7C231ADA0FC8FDEDE7E7C513B298D12CF07ADED873128FE03B5CAF0A86813C5C4F232C68755E48A6C9A54B01FCFBDB91EAB362561AD4D21EEFB8F19AEFDF30CFCFEAEC5F8CD6D0B30E5FBCFE007D7BF87ABFF321BB7DCBD100F3EB306AF7EB805FEE139C8CC2BC7810387D1D33980D181136DE18E8E2E4446C42177FB4EF87807639BB5AB5AB730B79938EEABEEA310CCE3D2D63B7A7A5150548AC8B844EC2CAD8093BB38EA6276593BBAABC2DB0E5EC1B074F4829D3BAB408A43EFEA8F2D96CEB075F44158448A1A8BC25CAF37DF7A1F63F239282CF451AAAAF62036361E7BF6D42801D8B7AF4ED1F2F3772025250D8989C9484848426242AA7CB3587879FAA9A214B6DB1CE1EB1388A0C0301C3E74BC942D833314A2CFCB4F314A3C1FB08073DF40AF388CFDE8E9D73D284734F67532516E5434CC18BAA5D17963DA1AFCFAC6C7B178632C5EFBC81D773DBA017F7F782B7EF4BB19B8E3094B3CFAA61B1E79CB096FCC8DC2DF1F5D83BF3D38178F3FB71065955D6838D88DFD358DE86D13CD35AC6BC186878EA0B4A402FE7E214A8B0405862BFF242E3619F676CE4AA3F138138E4331744D2D3272F210159F84F49C7C38B87AC2DE451856C0AA8F76A24D1C3C8360ED2CDAC52B44B44D02365B38C1DACE13E99945088B4C50F95EB7FEF136F8FA05AB0EC7B2F22A787BFB62F9F295A8AB3BA098FBB0F8AB4D4D2DA8AEDE8BCACA6A1417972AA1292FAB4266C67695A54C2C98BF18B7DCFC677CFF7B3FC69D7FBF0769691972ABBAFB6543A8AD7FD6304ABC10A0AFA2AD8F8FCBBA607CB40F9D7D5D20CBD6B78FE2E63BC447B9E4463CF4F42ACC589280FB9EB2C71BB353F1F19A1DB8FA8E7998B63E15B73CB00ECFBEE78B39AB1270FF630BE58E7F8DE79F9D8A2323C0819A3A69918EBF48FA237BF7EC87D92673AC5EB51E3B7716C1CAD24EB55ADC3F32A21316F6C770F9550319B6ADFD7874B07ACF3EE4E4176067491932730B10141EAD04C53B200C7EA1D16A722017BF70780446C1454C3027F1571CDC036166EE089F806864E588268A49C6367B37DC73EFBF70DBED77E1F26F5C010BCB6DE25BF48A5F7A540944616131CACB778B25D0A09664F8AEAE1EECDA558EBCDC9D4A73A424672821B9EA273FC715DFFE1EEEBDE701FCF00757E1EAAB7F85D6569DB9BD77EFF171F8D452DAFA6701A3C48B8DBD35FB30383A2E1A670457FFEC6EB98B9FE377B7BC8E079FB6178DF231169B17E1A3A561F8EBFD2BF1EE6C57CC5D1E8CEF7EFF1D5CFA8D0771FF83222C975C816F5CF15B55688DE3C0EAEA1BE1E4ECAE5AB330F9D8F60E4E080C0A51B0B7774743E361F9594CE9335215E68B0A32B5E6E4D2F7FAB4FD3E5A74D010AD1DBDE08CBEC969D9489296DCC73F0416D6F630B7B1878D838BC23647575839B98B36F1C0161B67D5E148DF84D1AEB08854040725A85CAF25CBD7E1F1C79FC13DF73C84A5CB562327BB40D9602C9ED7D2D2A4E6B7E15C36070E36A262F71EA57158C0BB521A3516AEA8ACAAC1263373FCE4AA9FE3EA6B7E831B6FBA1577FDE39FF8E9CFAEC6D7BF7925964BA3A7DD779F38F8FAB30B3050A4AD5F4C18255E480CF60F61E4581A3D5B743AF81595BBC5E91B5303B8C242E295969872D98DB8F6D657F08B3FBC2EDBB761CAB7EEC153AF2CC3946FDC84295FFF9308C70D78EE7F1B30E5F26FE2F7B7DC87EFFFF0465C32E5777077F797173780DCDC62F8FA86AB426CFC581C8DE7E9E587CD66C60B1D9C6B2FBDB1E31949230313E77ABD0B05DE03C14174EC7F38D57DE8F79D304DA5BCB206E959794849CF45546C0A7CC454A526090A8F856F48143CFC43E1253467F1175C7C83E02A6615E769B4B2F55066574050BC4AB55FB7D102B3E62EC6DB6F7F8499331760A53035C7CDF7F78DE088C839877E3372D5DADE86DEBE010C0E8DE1887CF7F6AE7E1C9006ECD0E10E253CF3172CC60F7E78957CFBCB70CDAFAEC3F77FF013DC79D7BDB8EA67D7E089A79E55F7AE1F283084D61969E8C3B0B1B910396746891703A3222463637C18D1247DDDAA32CB803C003B10B3B2AB71E32D0F8B10FC12532EBD06350720AABD48D6AF848D6B02FAC549FC68A615BE76F9CF41999353E1E75D8C1F5EF14FB91E10179780D2D2326576AD5AB90EAFBEFAAAD0629099950AF32D56AA75E3EF7FD106839D4EB82EA4E0196AA39ADA7A648BC943414948D9AE0A6C6FB6761247DD57C1CAC9534D5ACA197EB7B97BC25C34CB3671F2B7DAB9AAE3E8D4FB05C5AA30B1B99503B658D8A9027841415130DB6C290D943FB232F350B9BB464CAF62E4E4E4C8B760718A4C84864521223216A1E2C0131CECC512AD1C6A1C161EA30AEDE51714ABF1F92C8FC45CB319B3E6ABE368359457548B85D0ACB22EF82CDAC84C62A04FBEAF98184CD23596C9A1D3D29FEEBD1A255E0C0C8B5F70549CF9F1A3BC514A79BF3673168E1C1D475A4611FEF897FB4573FC08F109851092688CEFA0A973084B57D9A25B0EBDF9E667E4C51F82AF6716B66C0CC5D7A6FC5E398A5F9BF27571DCDD457301032255A92959484A4AC1C285F3B175B339C64646E57A63686BD5852BC7463F7DE46B64583EC2401FF83C5C3F693F0592376240FFA2A076DF0135C14F70583462E275F3C3D3ACB276F414BF2456FC91083569A95F789C9AE5D7234C7C94E05004C5C6CBBE3035FD5C684C0A2213B2101597A9B4119322B3B6178A735EAA2AB5B0AC516646AE8A38E6E5E521313111C929696AC464724A06B6E717215784213DAB40651D532078CE2E71EC4BC4246350A0B2AA564CB46AB9EE0E54D7D4CB6F2423454CC415D2109A6DB6507E28AB51C64445A3766F8D3C9AEEF994E048C3383CA8FB06861AE6D3C228F1428237AA459C8E8C0DA99A5EE34C43612516A1757532274CF770875A06E48EBE8B179F7B03FDDD3D08F34FC494AF7D1B5FFFC6AF5567E3DFFFF60A1293F39097DDA8D4FA8C0F3649CB017CF3F21F63E92273B838842333B50203BDA2DA5B87B07CD93AD86DB3D7B52E47194A1E1306979D47A565B940DA6578F4B3110ABE47B6A274845B5A0EA3A1A14939C70CBF565454A2ACAC023B761422393915313171888E8E45585884200CE1E191888C8A11C4A9569BD3C991B9D9AB9E9E5DA8B44A465E097696ED455E7125F24AABB0B3A2462D4B6A442BECDD8BB27D75C897DF2828AD44F1EE7DD85E5086D28A7DA8A8DA8F9DC5BBB1775FA338ED15D85FD7889ADA03282FAB46D9AE2AECDFBF5FDD5BB5DC67FD812659EEC7C1A65634B674A2667F93A001BBABF761FF8166B475F6A1A07097BABF86E63635916A624A267655EC819F08292BC1B0105F52923484899922287E70B477C2366B5B586CB5C4A2858B4568F6A1BFF7446DD23F3084A1F31418A3C48B85B151DAD03DC2A8223023C719B5A5B95DE562B12FB0F960379A1B5A317FF64A9097376FF5C2AAB5F6B8F6BA3F625004EDEE7F3E885FFEEAB778F491E7E1E793A286AB6EDC6829AD5905BCBDA270D9A53F82B9B99372F2991940738C1192E6E64631F57A8E55AB1C3BA78E477D1FE46CC3CCF409183CA099B06F7FBDD8E155282ED9859D85C5625AEC9456344FB5B0DB73F3D53AAB9D6464662321311931D27A4709A3874744212C340AE1D2FAB3AF2146CC917869599312D35494285598889A93FD125962DAE4C83588BCBC021415952873941127AEEF2C2C05C799149754A04A18B3724F3D4ACAF6A0B47CAF62D88A3D220845E5D82982B043189CD855BD1FC5D5E2785755A364CF5E9454EDC5BE83E294CBF72ADE552DCCDD8A436D0C0A1C406B6BAFFC5EB5EA9D2FDD55895AB19F1B1BC40739D40A46ABF6D6D4C97B3888DDE21BD58B50F037F9DBF5F2AD791FE595FBD47675CD4175CDE6C3DDEA1E692252502A76EFC56E1150F6A19595D5A220AF0CE9A9F9888D4944A0F8A3EC7B615FCC270B97AA7E338EF5D79FE39E82C2942A6DFB5C61947831400665E1BBC1BE7611925EB524BDBFFF788E16C3807CC0C6C6763005E9CAEFFD0295D53DA2AEF951FAD5C8C9DBEF784A398354129C40F8D2CBAF445BC788080170F7DDCFE1924B7E8E5F5EFD47CC9CBD586921E69955D5EC477EE14E6CDF912BB423E83FA6CD4E85A1B1A3181891E386C7C4E41B425B572F0EB577813DD845BB2A90932F8C2E60FF034D89B8F864616C3277BC086E92303B0732A508C327AA256984AEECCF76159DCB2F2842C18E6235D496D0B639469DEB646C623799444C10F63770C9ED4A32CD313A358A624401D7F55153232DB5082935CFC18616151DDC272D38994D63548688E950B32044756D1DEA1B5B70B0F930EA1A9AD1D4DA81FD2DCD38D8D6AAD61B0EB5A996BEA9A943316D7373273ABA87D4B50E1DEA465D5D0B5ADBBA71B8B50BBD3DD28A0F1E5161E2B6B60E3080C02459EEEBEA1A52C25077F0B0D22CDD7DA3F27D0F89A66917A1A851DBDBF34B14AD458E2F14E166C0861A6BCF9E066914CBB0A7AA11BB4A6A95C0EE28AA1073325381C301E6CC5F8AFFBDF236A67FBC40CCB90A154410D6513EB1FE773E1718255E2CA8FE140847B342E4D8A99995C5D50ACB6B505DD7852BAEFCADDCE5AFF1A31FDC87BBEE7C4FFC96FBF0E31FDE8FDFFCE641FCDF4FFF86AB7FF9A0985EB7CB31B7E186EB5EC75F6EFD10BFF8E9BF71C9D7FE80DB6F7F091DBD83686EEB42656D2D5A3ADAD025FEC59EBA7D48CDCE466058A41AB1C73116C1E14988884947646C8602EDEF98846C24A665A9FC27E6413169304B98BCA0B80CC5E5D2EA9694AB964E035B4B9A167BC5A6D6B0676F9D5AD21CD1075B5E322DC1753AB104F729663ED8A2502FA64C9D6C1307643F870C348BE94234350AA389C66A6E16263BD8A8C0169C60E71E4D34EEE37A738B30B83079A39C47A626A336B674ABF3D91948B4C879EC67E9ECEA91C6A15BA1BDB717ADD2221D6AEFC0E10EA1B5F72821681121E916866FEDE81766EE518CDCDEDE8F0E319F7AFB86D17AB84B7CC26E652AF2DAAC14CA7DBC87EEEE61250C9D3DA3683AD4A504E440A3FCBE5CE770BB1C2334DE1F0585A659BD3C737DBD084D4B17AAAB0FCA738AD9B6A71975FB5AA501DC8D1DC55548CBDA89B824F9A6A171D8E6E089B51BAD307BFE72FCF92FB761FA8C8FE51BEC13D6D2F1576373D3C4BA16B9A4BF7C3A47DF28F1E282E92D5D387AF4B82621B44212B4C599D458B5FBA0681DA0A2BA11AFBC3E5BEEF41AF157FE82EF7DFFBFB8FC5B4FE297BF791557FCE8015CF6FDFB30E5CABB70C977EEC155BF7A01DFFCC193B8F5F6E9F8EBDD1FE0A1FFCE82B9752806A421A1361A157D3222E6D888ACB78A4AAA696A14616C41D99E0328AD3A8092CA7A145588CD2DAABDB04CCC8E0A314FC44C2916C7B2A4B2568ED9877231477657D729D03EA7D941D06420F6D436287B5D033FF43E6170DAE004D7893A0A82303A5B700D079A0E29B045D7C0569C4BD29B9A85C9A5F56F9356B6ED70275A0F75084376AA0E3B82F40E61E4CE8EDE0970FB045A67B7025BFA9E1ECE7749669606A4AB43B6BBC404EEC1803426EC94E53EAE93999898A88D58E4CC5B346B0886FEC7E4853233A2B747F6CBB2A77748090BA7A6EB9197DFD537A82AED748976EE132D4D4D4F96EC191943A7F813DAFE8ECE5EA579D8B7C2E72238CCE2F0A14E6918E41E3BFBE5F93BE57E84834448F7EF176DD7D489AEDE3111B001E537D9387960ED662BACDD6A8D77A6CFC6AF7EFF473CF0C433B0B073817F4884B20CC867049F4B5B3784A1697EC2CECF069AA09CE84C1BDE5875A5B4AC358774438A6B5AF1EED475F8F1550FE39917EC70CFFD1B71F7836BF09F972DF1D1BC48BC3B3310B316C762F5E64244C48F23231F088E6DC5C235C1B8F5AF8FC9C7A25772142DEDCD625ED4A0524CB1EAFA83A89596A5A6EE10F6EC6B46E55E718C65B9FF608730660F1A0FF5A1B9750007A5656C948FA520EB758DADC2E82DAAB5A37DCDD68E0C4FD04925689E1882137F36CB473E44D344187702D24A13AD9D3D13A0A93781EEBE8975163C2723912115BA07541F91863E61D081FE1130839A4CCC25999A3405716AB50154F4B5081E43301588E37EB824B3136A9F30138F1B1D6506F8918975FEB1256644911126469BC6C45CD5056F645D0EE16FD2E4E1371C167B9902323426C71C3D8A3E69BDDB7A7AE4DB0CAAC163ACC0431389E6113B15B9E47DF239794FBC97DEBE21A5915871B44F9E8F8D0DAF2D3F2B56430FCAA4217BE7A359F8E7238FE3B1679FC7EB533FC29B1FCEC2BC656B6166658F0F67CE81E5367B31438F6B94B38551E2C50505A5E72441314483BC04464EFAFA87D5CBA01F76FFBFE662E9AA6C7CF071125E792F14735666E2E3451998F949BAC2C2153BF0B35FCFC2953F79133FFEE52BF8EE4F9F102DF46369B18EA0BDA7431CD11A71440F8A70889088C9D12ECE364D0782B67243B3B4D01D8362778FA0BD6B58E1B0B4726DDDFD72FE003802908C4E86A7ED4C4667A4869D67448730AB21D862328D9DD05A4EFA3E5CB2B5E55203E91AE823116C81B56DE666B1D38D8CA3189B4B6995C99CFAD0A7A9565FEF382EC7C618CCE0FE611108F63109B3493B6508323B9995A928141226948E8FB3C991EB8CF663FCE830C647067164585AA2232214B28F6173D5672582C0DF18153AAB81323AC8A117238C381E034B530DCA8FF3FBB21822317A644C0DFAA38011BC5FD6AD1EE4B89651115E59F2786A067E47F6EEBB7AF8E2A5D7DFC60BAFBC81FFBCF832EE7BF4093CF7FA9B30DB6687B8F47C1455EE4352661E36996FC36B6FBD8B0D1B4F9E0DEC4C411AA3C48B8971C80B1641D10D1D3E79FFA0BC742656AAF212F2810EB5EA5A8D436D4771ED6FFF8DABAF7B0B3FFFCD34FCE0EA0F30E5F227F09DAB5E13BC8229DFFA2F2EBDE205DC72DB5AFCE4EAA94A50AEFFD37B98F28D9FA95A63ACECD2D5DBA6FB58EC94928BB25D642A0D3B7C59719F8CCD65EFC011B19F87657B4896141C1DD377498BCDB41BB6663C8EEB9C40C990D1B56DEED382021AB3F3F7182CE05231BFAC7340A021784FC4E0B1FD5C67762E831C6460D5EB2DDB64E2B13169AD05A3C24804996B423044484EDCAFD30C049999D761F1742578A251786D6E739D4BD68CD65D9303B0C8ECEC0B13061F12AB00222047454018F21F1D90E345C3A83E2A6176D55FC6DF3DB61CD795CF656646DF70BF328319C51CE5775667F09D7044EC712121F8C7654F6FBFD2380D2D87505E552966563EEA1A4450F6EEC3DC858BF1E4D3CFE1A38FE760D5A62D70F4F441616535F64A639896578A90D8340447252138224E75603EF3EC8B2A52287F137C773AFF84304ABC98D009CA71FF6440984E5B27BA7A3AE5C58CAB97CA8EC8CEEE36610E51BDF201AFBDFE61119417F1C0E39B70E36DF3F0EB9BA7E217BF7B13773CB018F73FB11EBFFFF31C3CF5BC2BEE79D00C77FD6B29FEF1F03CFCF6A6FBD0D42EAD9E5CBC7FA85BAE291F485A25AA7BCE08C6E43C6D4C36CD17CD74610AC6403F5B4E112AE154A65E70C96D32EB045D185E637E0D1A8D20936B8CCEA5B65FA351684F05FA552CFDA4ADB3E1E0BB20D35340344121C8D0045B5F0DFC234DFB633A09A1AD1F3922CC7BEC006D4901E29F2650FCE3EFE9FEE477C787E5FBB0F5E592011936371448B110444B90E5791C41C1E277D4BE2785840DD6F038B582BC330A961CC98C722EF94D68A271C9BE0F9A5F34370FB776A2B1A905EDDD3D2228CDA8ADAF436945391A5BC5E73BD08855EB36E29DA9D3E0E8E6855E79B72DE2CBD489CF5625BE60A238F93EE2E07B074521302C0629E93998F9F15C3CF2C8632A8B59FE2678EF74304ABCD83895D9C517DBD8542F1FF1082A2A2A548E506F7F8F6272BE48678F18693D5CC461CB87674005DCFC8BE1E85B04079F4244A5B622236F1C5B6D76619B53351CDCCAB06A630C9E7F792132F3AA54EB4D21A1E9C0D6834395FB867B75ADEA3186D031D27126E39FD67AB375E59202A2CC1F4D600C98DB101408C5E4722D2E3561511AE218ED74A03DCF258F65589CC2A20986F09A5A6AF7AC0FED4F7F9D7F7C460A8532A18E75C2EA43377AF4F8F6B13C29F5A769070ACBF0086B10B01394E589749A63445E167F8EC38DF9ECBC6F8EC9EF17FF85E03AAFC02B73D92FC248D3F290F8681D62A272BD5D7CB296B64E15BC50010E31C1190D646725C3F3E555D5E23FB6A0E6401DCAF754C97A1B2AAA6BD4581AB6B987BA06B0BBB61131A9B948CD2D417A5E1952B617C3D92B48955BB27374C373CFBF8C77DEFE40A5FCCBDF449ED8E9609478B16128283A07517D90290D0D0770F0603D7273F38589D9EB01A562B9ACAD6F43627229D2B2F6A1A0F820F28BF763BD65B0AADE3275B635365AA4C22FE0006C6C4BE1E9B30701217BE0E9BB0339F907E4230993C835B49692BF279F52289CD8889F4EC779E362DF1C110960F5172EC785A9153F1D634832261956F840773DF947E80B8746530C716C5BC7763A3A5B4D3AB584463F15F809B5F3F99BC48430A82557747F3A2D21D7640B2DE03AEF57274CBAE348A3AFA19E5F3D18F7B3F557CCA29C77FE91461F46778D71D521AC691D1EA3ADF30A3431B9A4A6D4EE5B2C39DDFDCBCF72BD6F583C53417D4B870223897B1B0E49E35684C4B41CC42567AA40093B3E193964DF0CA38835354DD8BB571751A43FB27B4FAD0A5797EFD983C4F454EC2C2E574E7D49C55E648B99151E978184B41D088E4E4364622E82A252A5418DC0FAADF62A5CFCF26BEFE2F737DEAA3A6CE5EF04BE3C1D8C122F360CE742E147D31F07CF0FC1BE000EC44A4849877F7008B6585A60ED862D7070F2436070824A9B38DCD68A7691B9151BDC70D915BFC7EF6E7A0EBFBBFE0DDC77DF523CF8D0123CF7C27AFCF7D9E578E23FD3B1CDC1470506C82FFCF8875B9B84CF447AC41C18ECEDC28898614769230F091330AC221C799402234DFF1131BB7461503123C89C72936458650A8979C89033E7ABD4C06DD2696F9359F405473191080A5BD8EEFE81099A3EB4E309638232F1C76D61587D61E1B63E4D7BDEE382C2A8143324683E89993320AD785B0F0E09F30E0F891F27660B4D4EF6AAEF2AAD54C7676464A0B0B050F93C2A5D6657A5D2B0CC7AA0AFE7E91784F2EA5AC426652050FC80BCE20A44C4A7AB04CB90E8544427E52021BD003B76D52032291B190565884DCB131FA20305A5D5C82AD885F0E81474F68EA9E8636DDD21ECAB3F8C8AAA7AF9DD6AECAE3E805D15FBD4B421ECCBDA595AAEFAC10A4A4A148D2828AA14542B21F1094A80A5832FCCAC3CB1DACC169FACDC8C0F672DC6E34FBD880F3E9A8DDCBC42BE8A09FE3B1B18259E2F74939BEA348421742D161D4BE3FB55C7D9816635D88A231457AD5EAFE6047474F15485A0D79959AAA207AFBD3B1DBFBAFE56BCFADE74ACDEEC84FFBC3017D7FEEE193CF4E80AFCEDEFF371FD0D1FE0EE7B97E0F67B17E2C63FBF8DF59B23A55523A308D389208C314CDADDAF9C58AA5EF62374741E562605A339342FC89EE3B495C8A5C2676C80C92CB49F6946D09656CC2CDCAB853F4993C314B88F0EEA909824141ED218F9A2E93520BFCB6DAEF33C9A869A1FC39699FBB82ED688BA0EB5188726B0820AB319FAFABBD49C329D1D6DC2D40770F850B35A969614617745190ED4EF47556505AAABCA5154988F9D3B0B909696828888088484862B616756015366F6ECDDAFFC806879BFECECF4F70F474949159C9C7C70F8708BD236CCFCA590CAADE170C7A0BAE7EADA16756F1939A5A83DD8A90AAE87C564A168F7414425E58900EC41796D87F809BBC4142A54DBB1A93B9057528B1DA5FB452314C1DE29102BD75863CE82D5A8D97718B9F9156AE6E1DC5C8E8014085333A381A9FBCCFD0A898C857F481442639210235AC837385EF8C10B8B966DC4D4E90BF1D67BB3B06EA3955CD71BE6564E983B6F13DE7E6721A64D5F8E556B2C549ED8E16303C10C713ABE3D897031D1D3A3CA6DAA0EAEC36DBA3934B41A4E0D0D0DD8BE3D0F7E7E01D86C663191B313161EA960EFE082058B97C1CB3F18AB376CC6234F3D871B6EBD0D2FBEF111566E70C4FD0FBF8F4B2EBF1DBFBCE645FCECEA57F1A3FF7B11B7FC650E6EBE6D0E2EFDD643B8F2FB8FE0D12766827E29CD92216653CA3A1D72320DC1821822C20A1CEF7F2CE151B5CAB434C828DAB164647D46D709893892625FEBA3B9F5B02C5B9506A1A9C57031C3C28C9AF54B734CB385F638CB98C62549EB1BCF0C817824A66628A465E622393D4BE5B4050587C2CBC7139EDE1EF0F671878FAF3BBCBDDCE0EFE7054F0F1704F87B233D2D0979B959C8CE4A43417E0E0A45400A0AF254AA3B87DE667376DF9C4231A5C6505FDF8A7DFB5A1015958296961EB8B8048053D5787986A3A2BC0136D65E888D4D57CF3F6DDA423571D0B29516786FEA224C9DB112AFBE350F4515CDD272FBC0D5271EC5BB0F61FE326BF8866661BA30E8B28D2E700B4CC7BC15B658BEC91D2B377B62DE522B2C586E23825482A56BEDE1E41181B5664EB0B1F3C581C63E71D2EB1115938188A834358292D9C87EFE21F00D0845B808476A563E2213D254A6338702ACDB6C8FA5ABCD31FB93D598B5709508DC2AACD9608965ABCCF0E18C0578F4F197F0FED485F0F58F166DB85FBED2717E3C972C6FA3C40B0976466929CF84617DADB6B636C4C4C4C0DDDD5D5A3017CC9A35078E0EAE2AF1CFD3C3176BD6ACC18A552B51BEBBE2186332574B67DB978A3376FF23CFE2B26FFD1253BE7E1D6EB8F905FCE0AA7FE31B573E866B6F9C8ADFDD325DB4C9C7B8FA37EFE317D7BC832BAEBC0FF31658A0B272BF4AF7F870EA4C3CFDDC4BF00D0C11B55D88E8841844C48623392305F12909888C8D415874DC04C205646242CBED0A0A8B145F281C1E3EFE7076F71213CF59ADF39A444048A81C138EA4B474951FB66B77B5EA9967C764D3A10EE58C32C78A82B2BDA01065957B941DAE72AD0EB7ABCE4AD5632FF7DBD47C08DD6226B26F42693BF66308582D93100F4981EB47C6F9CE45738A934D5F4445AE84E1E98AF4F61E455363AF9858E2FFEDEFC4CD7FF807C24285A1E7AEC33B6F2DC0EFAFBF1B1FBCB7040F3EF03FFCEFA599D8597840B4F47FF0C73F3F0A7BE718BC376D1D9E7D692EDE7C6F35BC4373F1F1226B986D0B45765133DE9CBE1E4171A5786FF666CC59E6884DF63198BDC209F356BB62DA026BA4EF6C82939F9872953DF870AE39C262F33177F156BC3F6305DEF97011F28AF6C1DE9585C14354A13D5678B1D8E6A4D2527C82A355513E16BAB070F4C2665B376CB5F550B066792AAF10F1531D316FC93ACC98BD187317AE54E3F93914803966F237C17767EA37318451E2F9C098EA3246AB3FD0A006F35083F8FAFA63CB16736CDD6AA1D2C41D1C9CB07AF55A848484494BC75E549A472CDCA60B027449B3572B0EBFD692F78A35B770A925BEFB93BFE0926FFF19DFBDEA214CB9FC4E4CB9E29FF8E1CFFE8B9B6E9DA64CB1DBFF36131CA3EFE99D0496DAADACAC47645C0A8ACA2A515C51818CDC1C64492B9C5DB01DC999E962EFA621212B1BF1995948CCCC467A9ECE3E2EAFDAAB86AFEEAE64E66D83389F07D488413A9B5C67A724416160A446313AD1A8EBC1A78068692CD42844736B87D240D438EC4CE33A2340ECBB619FCC80988BECB166F8BCBD93B9532DF2F11BD1D85487CE2E8E146C50E8EBEF947DCDA8ABDF7B8C764004AC5EBD47FA74CD2DED2AD78B664E47D711D4D77509177C17533F58A804E59E7FFC17EFBEBD104F3CF6065E79E963FCE39E17B078A92D9E7D7E267EFACBDBF1C2AB0B70C73D2FE2AEFB5FC153CF7F8CD5E63E78F899A998FE8939ECFD52F1CE9C4DF08E2AC0FBD2207D2802B4D1210AF3D6BA61A9990FA62EB0C41AAB60BCF8CE1298D985E1AE875F87AB6F12D69B7BE265D14E8FFDF76DC4A614232A211FAEDE9170F78D96862656E56F790546C2464C410B11180A89AD7B20ACDCFC95D0ACD9628B8F3F59856973968A2FF2896897952AC295955BA242D1E499B3C1E9FA528C122F264A4ACB909A96A146AB31FE6D66B605DBB6D98946F184A3A333ECED1D557A38D53D3BBA28245D9D3A2DA4A94A66FF320ECF9EDD5661120A0B1FB147FEED286BC216BB70FCFD5F6FE06BDFB90953BE7603A65C7A23BE79C56DB8E6DAA770C9A57FC5A597DC84E9D2F275F5E8225255B507515C5E89439D9DE81D1E4483D8E5070F1D42AF30E8FEC36D68EEEE45AB306983306F556D3D4A99C55BBD4FA58B73BBA6BE117BEB4460F61FC42E111ED20896282D2AAB465E218B3788B610E1E2FE26F1072AF6ECD3255556D7A0B6BE4165385393B0B779CFBE7A456B686955C24461ABAD67B264BDAA96D9D8DC20CC7F000D8DA2191B4438F7EE56DB2D871A505E51A2B69B5B0E626F4D25F6D414A3B2BA08D53565A816FAEEAA4A1496EE529A8A633F4ACA6AB07A9D3452968ED8B0C91673E6AD427C622E167CB2014525FBE117908ACCEC6A30825A507C00DB0BF78B16C84372CE6E64EDAC45405C365EFD48846CB505966D76C0478B37618D8D173E58B81E2B2CDC60E7178739ABADB160BD1DE6AEB482734082AAEDC6E5CCC566F00FCF824F48BA084108B63987C2DC563483987E5E01716A6963EF211A3A540506CCAC9C5545185B118E559BE55E576CC407331788C9B5020B97AF0773BC38A4393BBF18075B7429F59CE44ABFD0C9A78551E28546A7303AFB454A779563F98A55D866EB28CE16EB4185C0DACA4E9958ACC6A15F308DD2DDDBDB8B6123433A39770AA7C463CDB0610C88900C63E8E8C9AAB44F3E2E35EE260B575C7FE3DF71C96557E3F6DB5E1541B919BFF8F99D98F1F172F10BB60B93362A2667113846538ACACB95E0B0205CD95E61E8B2DDD85E548A920A319B0E36ABF415E66E512B50C8F6EC6F44F5BE0654D61C40E1AE2A94EEAED1254FEEAD17536B3F4ACA6BD592C7844625886997A33292236213954FC2EAF134BB585FABB4A24A995F9A09C6DFA036E2B896FD7507B0B7760F6AF7D7A8FE266A1486D3E9F3F11D3320A13AF9C675E36D889EFE369591D074E800EA0ED4CAFD56AB5E6D9AB099DB7395C66273440D5850588EF4AC9DC8DF5981E4D40211941A8445A4233C527C86E82C8444A4886F108FC0A844A46C17273BAB00690525F08D8843FA8E52848AEF10189786D8AC1D08884D45626E317276ED457042A66CA72132793B7CC31390B1A31C49D985F0166D1195588090E86C387B478826C95185C06D5DFCC46C8D81975FB8F826E17070F5C65671CC2DECDCB062BD39E62FDF20E6DE6A7CB27A3336995B2B079F8D1073E6F4BF3FD1D9D3AACA66A97AD5629530347EAADAC6A78351E2F9C0D0F6639F48A69831B6F6764A48DCDCBD612B3E082B7E787807A9AC57FDE3D977A2BFADA1BF9703BB46D0DEDE2A9B62CEA90158421FEB43EF480FB8EC579D60C7CFD1EF481A60F2922C6DED82F1DC73B3F08D6F5E2D4FFF1DC19558B7C146A576D38CA2E3CC9034C79367722C7746BEDCBF3044663E925273D4F0599A6B44B43006E3FF3189E90A2C6E9D94BE1DE9393B94D3C9ED84943CC427E7AA5184C9E9F97074F351511B66B2B22A23C7B4D077A190EC28DE85BC9DC54A68727714A93242D45ED43A35B5FB959FD2D6D1AA4C507E7856F367608139500C55331A57BBAF4E0D10E380300600FC0342E0E1E9AB8221D6768E7074F580939BA7BA76744232C285E9CB76D7AAE81A73DBCA771F809B4708D2338BC5018E818B733032334AE1267E43FE8E4A040BA3F3199DBDFDC46CF257C528F81EE2D37254410A3AD971E9B9088E4946406402BC83625468382C365DF647222C2A598DAAF40988145F2F15EE7E1148CE2A5482C07D1EBEC170F3F4539557D8986E32B3C08C99733177C112AC5C47C1D8067B79870C2B37779DD8CDA0C1D0D467904699EE0327F2872118913D95F97512E17C40216144893FB66FDF3EC4C7C78B83EE202A5D1EDAD101965636A24A9D541A0153DFF5CF3D1F0C9D831DAA81C5ED0F3474E15F0F3D83CB2EFFA138FB3760D3162B35308BA57438563B237B0792A5358C894E4644783CA265C9B9402804C919B9624F6789939E87A8B874C540FCF0FCD831720EC74624A652404478D20A94E6E236058B6618354A7482089B68949088E889A000C1E817350A3386198E658B4F8150FD28B2C50C030E841B18EC162DBD5B0DF17576F1809DBDB3828BAB27DC3D7C94705859BAC1C6DA0301FEB1AAB2639CB4DA31F119AAD453484422824212E0E115063B071F15D5DA5BDB26A657BE5C235CCCE350F87AC5C2DF27569D1F1595A6A6A763CE14B5A1BFDCABA74F30BC7C43C4E9F681D53657985B3BABBA5FEB366D53D55A2CB779A849512DADDD6163EB89F5EBAD6161E18C0D1BACC427B5C7EA0D5B6169EB8C8D5B6DB07E933996AF5E87156BD6CBF3B8C147043157BE034746722C0BA384DAF7FBAC6194782E3856206262BBA9A909B9B9B9E26F3862C9922558B162053C3C3C90268E31CD2F4369A7701DEB0D9EA05D68188601BBE4A5B3FF447FBB20BF08AE2E9ED8B8618B30972D7CBC03D410DC5461708263B4E3C4AC600B4C551F181983A0A8586198649543E4171C29F478448A89C1CE330A0E1D51FF50395E182C222E4B15646001B9E0A814A4E796CA7606AC6C1D540B1F1E11A346387214208542CBDAD5751892A2D31CB9792CC890249A224898D2469C56110C0F6F1569A329CBF241665BED8439DDD5A4A42161494A4062E3B355B835357D27B6E795AB6D0A09E739F1F0125FC0D60B1BCDECF1C8632FA8C6E3F917DFC5D2E59B616DE32B1AD70EF316ACC3DCF9ABB172E5162C58B01A73C4715EBD92FB1DD424A79151F16A3C3B07B071B01A07B1719DD36FEC117FAE46681C7CC6ACF016F18F38D684E367C83FFCFEA7EABF389585F159C328D118F8201A43B33FA4B5B555A53568FB6B6A6AE0E7E787B973E762F1E2C5B0B3B3435050108A8A8A8C4EB970BA08C3C506C75A18D2087E9463B94D13B481DE311CAC6B16412A46527206E212696EA5A912A4C1D1B1D2BAC6880319AA7AA75917CB3728425723CB5F4CABC028F804C72234264D25E5790644A8C979AC1CDCB0D9DA412D39051C87027382514EEBA61B9ACB2C678672998F05353A8FE3EB2322A3554B6BB3CD4E15F9A3A05043BB79718A383F6CB1D8A6E65AF414E73790F67F4C86087632A24478A945A80D56AED982454BD7E1E3394BF0EE07B3F0FA9BD3F1E4532FE33F4FBF86A79F7D030B17ADC3A2251B4468EC14ACB7792AACDFB84D09C99225EB606E6EA7A6D5686A3CF1BBB24F4A7FFBCB04A3C4D3818E10C1B408FEB11C8DB7B737366DDA046B6B6B787979A9CEAD4387741D8AFAD0D73EA76A412E26A8BDF45B28660C5388CF46A319B66CDD83FD6A6831A355C5E2ECAB790FE3C5D90D0C1333444C0D1B713EAD1D6123C2E0EE13A4AA2EBA7AF9A9F9475810DB2F380C896999D2FAEE07472EEE2AAB54E3E9D937C322101CE3CEE1BB5972BCAF08214BF42C59B15A09053510975E7E81B0777653897E1412FA7EAC2ECF7AC01C3F9E21BE40AC38D53636CEA20596AB2275EFBE3B1D1F7CF031A64F9F87D9B31761C68C858AF9972FDF8879F396CB712BF1D147F3147DE9D2F5E22B9861B3B93DDCDCFC909C9CAD462FEABF070D6CF8CE349CD618D8D8123C977C75BAFE8DCF53BB9C44E083EA3FACFEBAE683F08F26565C5C1CD6AD5B07333333252CBB76ED3A81E9B473B9E48B6036B0B68FD73ADD4BF92CA07BD6E3F7C02891B6CD259DBF9EAEEE4FC500C6D0C5026DB2645A0B0729B1A95159C9620572F4DEA8BC5AA692B0042C8BC2514B58DA3AC2629B831A47C1014A34AF38532F85823E158322CE6EDE2ABD8753583320C1123FA4AD5E6786E933E6E0DDF73EC26BAFBF83975F7913ABD76CC46639CF5C04CB5EAEC14A9B616171AA785D4A4A8E4A5DE1D8741690E8E9D18DBDE13D1B82DF4EBFE133C4A95294262B8C120D418927A35048F2F3F3E1EA2A4E9BB9B932AF6A6B6B8DBE3086764FF722BF28604895A9E22CC867E8CB9C0E8CCD73663143FAB980D3C4A9B9D86967D117118161710A063B6CEC5CB1C1CC0A66568EAAAA3CC1DE69178F40D9E72E82E32602238E7F62065233F25434CEDDCB5FF639AB814C2FBEF23A9E7AE6592C5DB64A692AFE5E0F7B666539CCA432BDFBD0406135A411CC31EBE8EC46F3A116D93C79FF57014689A7025B91EAEA6A69718CBF3063DA447FFB74268EAE753FFF56FB4CA050186BED48638C5DCBAC25B86D789C3130FCC8BC300E4C32DC7736E8EDEE53C97F748A2D2C6DB1D5D21EABD699C3D6D14B5592679A38E72859BA66AB9A72C1DCD24545AAE890D3FFF00F8A5642B568E92AFCFBE9E730EF9345884B4A944B9FF83B1CA46648A339C3BA67F4CD587042A37179BA711A1CA83534C834986E0C0EF46078A80F2C6AC8228786C77E196094680CB41FE957E83BF08630E67750380CE99A407C1EA6D7A9AABB9F0AE7A265CE062CC7CAA556D6B5B478175C9C5CB14C987CF1929558B162039C5CFD54DA86AB6708566FB1C3829566D8B2CD1D0161496AEAEA948C42E4E496C3C72F1A2B579BE3838FE6E2BDA91FABBE068ECDE775090EB5E5927E987E23F4691B24ADA36E4C1A952FAB409C0A46892618C7B9DADD2CC134C2517D7A33EFB2F00253E3E362A3B171C31A2CFB6429D6AD598F6D360E0860875D6084729E57ADB3C492D55BB07CF3367887C62325B7140111C9C8D95129E6570866CD59A142B92FBF3A1591D1E9E81D5021E489DFEE91D6BE7BE0C444400ABDFE33D0ECD4D62F64A3F5651422A34413CE0EFA3ECA2885424C30AED3F7E010662EB5FD445747372243C310E217005B0B2B783A38C3D7DB0FA1A1E1E2F7B9ABD41EF64473EC0DA7A456BDFE49B9C82ED88D50118620D1280F3CF85F251C6BD658203D7DE70933FC12679A0386B3A169EB5A2D350A092D85B389FE7D55619468C2A9A1FC976302A181D3F0E96F1BA2A27A0F5252D3E1E2E2A63A3437AC3383F5561BB8D8BBC2D9C95D81537C6FD8B8154ECE1EE29407AADE6E869799F73463DE72DCF18F87F1E47F5F5221DFFA8693FBA59859ACADD3F9D62F4ACDC164DABA06E68619D24C38358C124D383718AB65CCDCB2FAC606A46667C2CA9EA91A6658B6729DEAD3E0C84157673FD8DB7A61D34673988BD0383B79C1D73714313129B013C77DCD7A0BF80644A2BEA94D8D376FED1A004B8FEA876B5B98AEBFFF203895437149B90A2DA7A567233A4697E3C5DAC7793B4AD4340B2CCEC07951B473E9A7683EA7E67B98706A18259A707660B91D431A8708EF3FD880988444586EB3C5EACD1B61E5E408171F3FD573CFB471E63EADDF682F4B2FD57F91949483B4B47C6467172120200AD6D62EAA13B0AEEEB0EA6BE178140E07A040AC5DB7092C3CCD94FBCAAA3D38D8704855A7E7DC223B0B77A9AA255CAA394AB2F2E0EA11A8D2E85F7CF92D3CF6F87F544E18ABE76B7F34B73E8B68E3648751A209E70ED69CAAA9AB47545C22BCFD83546A09CB776EB2B682A3A7B72ACAE6E8E1A7A69F76F70E8787770C12920BC53F89476060346C6DDD55A2E0BBEFCEC4F4E90BF0E18773456822909E960D2F2F1F141C9B2A222C225CF567704A8BAE9E6E350F636D5D2338D90E41ED51BCAB522D396582BDA32F1E7BF279DC70D35FF18B5F5C275FFC323CFBDC0B2AC4FF79441D272B8C124D3835388E83A30DB9E4364727B25A2173B62820CC80B5DAE6A87AC6D983EE26CEFA162BD12C1BB66283F93655958409924C940C084B115F244CB5F81F4E9F8FD75F7F1F1F7D34074B97ACC1AC8FE7E3C17F3D860FDE9B8A00BF40341E6C9A488E1C1C1E42776F0F0E341C54655D393E86A32629305C726C090B82B318C3BBEFCFC12FAEBE11D75D770B7E7DEDF5F8F615DFC355FFF7336CD972BCAC284D309366393D8C124D383358486240909E23E68D97AF1A40C4541327776F388BE6608ED7DA4D16D8B4C506F64E9E888A4F455A76814AC9670FFB8A355B307DD622CC9EB704D366CEC7AB6FBC8F7F3DF818FEFDD4B3F8F7934F8B903C8ABFFCF96F880C89C29121D61B132119879A42A1B3B3534D52C4B2B35A9956ADBA0B87297328318B7DFB0404E3DEFB9EC48FFFEFD7B8E596DB95E9F5E2FF5EC695DFFB0EFE71F71DD85FA72B0067C299619468C2716797B590F57BDCA94D9808191219A3CBC1B27756534E33E9512728BE58BFD90A56762EF0F40B5135A7327376C2C73F0C665BB7E1E9175E5502945FB44B5D734005A74453C9B2BB67504DE84353EBEDB7DF859787B76E300A334EC4871F3A3688676C6C5C15B3A666A16B4F412128281C7BCFB1F6F46BE62F5A0A4E35FE97DBEFC54F7F760DFE76C73FF0E453FFC6EF6FBA01D7FDF61AC4C547F272273DBB0927C328F1AB82BEC12E957AD23FD8778230900159E397B9572A0F4BFE98E651555D2B7E4281CA0E5EB2722DE62D5A01736B5B6572713C8899B9951A4518199B80D4CC1C658E996FB5C69CD90B307FDE22151A6E6FEF14013C1EBA35C4B1924E5A96832A66C73F0A2E6F85F598B9EC1D64F13C5DA924CA12EB8AD1E1E736C1F5691FCFC237BEF33DDC74EB9F71FD4DB7E0C97FFF072FBFFA0A5E7AE925DC73F75D707672902375BF6BF2574E0FA3C42F2BC87CAA78DC40B7B4C67DD22A1F670E6D1E76D6CDA580106448B6DE2CE61C1111A5460F4E9DFEB14A3C64A66E4068A4128ED5EB37A9254D9DF8E43455CE88E9EF2BD76EC0471FCE84ADF82C9C1D8BD727344121F33371D45847DFF6EDDB515E5E4EBAFAA3E34E11D104E5B8808810C9BD6A1A854BD26992718A836F5EF97DFCF1AF7FC3EF6FFE239E7BFE454C9F3903B366CDC2238F3C041F6F4F39F2D8F39B04E5B4304AFCB2E24CCEAA96FACECA8F9C8AADA0A818C121617075F350C398CD2D6CD4787A33D11233454B2C59BE069E1C63929E8DCCAC5C359684D56566CF598079F317C9B91172B5E3D75799C2B2E47D68C2714C739C701F25252598366D9A1A04478DC2B13F9DDD9C668105FB38A1CE802AC7CA489B36BD04E79A647105566EA1BFC27247CFFDEF155CF1FD1F2B41B9EE869BF0F433CF61DAF4994AA33CFDF4D3C8C9CE942B9EF8DB26188751E257059CA783E54EF5699CF989258342C507D9B0D91C9BB65A2A6DB1C592C36E5DB170C97255E82E292D531584484A4E57C2C2D2AF3366CEC1FA0D9B51545C76C2359B5B0EAB7911F569A78226401C315A5A5AAAB299E9BCB7B6B7A992AAAD6D1DAA381E2BB3B0781EABB470D62F963562092516A3D8BBEFA09A49F7A557DFC275BFBF1977DE7D3FFE74DB1D22282FE099679FC7F5D75F8F0F3EF8002D4DBAAA37A74B74354107A3C42F1BF435094D2C6A0E6D5B435D53139233B261EFE28ECD22148C626DB5B68383AB8732A35C3D7DB0D56A9BF247E87FA4C8B11BB758E0A5975FC5FB1F7CA8CA9D761D4B53D740C6666A4977CF898CC82927F4B7397647CBB76A6E3E5EB289E8EEEE44717121F20AF2B1676F2DF6D735A8394158708F42C14218140AAEE7EF2C9DE83FA169F8FA5BEFE3A63FFE15BFFFC39FF0B73BEF151FE5695C7FC38DF8FEF77F88AD5BB74EFC8EFEFB31A6E14CF80A6A149A2CDA3AB507E7E548CDDA0E330B6BCC98335F39E91BB658C2C6C14545B2CCC4DC72F7095061DF70F13D687AAD5CBB0EFF7BF535D1385BD4D4D41C52AC5D93D02626D2A7D12F619D81E3DBECB7D009AC21735270EAEAEA26686565A5C8CCCE52F3D03398C09EF7ACED85C8C92B5660548D83B738882B36215D15C070F30C00A78FBEEFA12770F31F6FC3ED7FBF077FFECBDFF0F35FFC0AEFBEFB3EAAAAF64C5CDF8433C328F1CB84530DA6625DDF7C319DD69B5B62C99A7598B774B9AC5B6193680D054B3B387B05204E4C2CDFD008B8F8F863F18AD578FFA319AA96B0FEB538BB6E9FF80DFA347D70BFFEF6E90684B175D7F76108D632AB3B50AF2AB0308F2B3C3C1E11D1494848CE5163E339469EDBCC38F60F8A54A168D64C6338FAC9A75FC4DFFFF1006EB8E98FF8C955BFC0FD0F3C8CF4749D6FC201631D1D1DA6CEC6B38051E264053FB661EB7CAC22FDC476474FAF8A4CAD58BB41CD12BB60F94AACDD628ECD36764A40281061B1C9088F4B81674018A68AD33E63FE27B017BF84B309734E45FDEB7D96A023CFFA569C5827253D1FEE5EC1AA96D6A62DB6B075F0544384994CC98210ABD66EC5C2C56B306BFE127CB264352C6D1C10179FA2CA21195ED78433C328F18B0C0E593D53358ED1E131AD736E825655BD57552D59BA6A1D662F588C8F662FC4B2B566AAB39053498446B1A85B82AA90B276D316CC5BB4149B2C2CD4B40B749A790D63E9EA9F0758938CD34AB3CAE6BEDA83A8AF6B42C3C1436A2EF696E676054E0CA49B9FBD551D6B780D13CE0D468993051CD3AD098D9AE047FC02C3BA5C2C0ACEF0EEBAF51BD5FC2AABD69BE19365ABC461DFA64A806EDF51AC4A086D12B3EBDD0FA763E5BA8DF00D0E46F5FE13E7D220E89CEB6F7FD92A8D98706A18254E4668335DB10F8493F6E4ED2C84939B3BE62FF804AFBFF11666CF99070746B4C469CFDD5902569B8F4FC9C007D366E2E5D7DF52B5B29823A57F4D820E7F1B4B161DEB03F9BCC18640EB8FD1071B0A361CA7EAF5E739868D8809670FA3C42F12F443A95CE77CE3EC93D06FDDFBC4372138836E466E2ECC2C2DF1F6D4A978FD5D4EBE6F86C8A818556591FD202C7ECD9EF4A79E791E6FBFFFA14A3361871DAF4361632E17A7D5D6AEFD45039FDB50B39970F161943899D0DED38F5D957B10101AA142BC349F662F58840D5B2CE0E2E9034FDF002520D426B6760E2A7BD6DBC74FF56E1B5ECB18B4C98B74EB93CFD6E77372BE76FDA1C1269C3B8C12BF686034CB3017A9A9A905C5C5A54A402C6D1DF0F1BC85F870E66C71D6D7AAFE0E761E32C3779D38E6AC904E4149CFC83AE11AC4E998BFB5FDF044B224FB3CB42927BE28389599752A9842C09F1E46895F64ECDD5B8BECECEDB0B5B5C702F13F3E9C314B5546E4DC899C2E810989AC10BF78F92A9566CE6915B4B11ACC08D6C2C75A3F8521F318D6FD1A183ADEDB7EA16B7C5D4C5088F40589E3E24DA92A9F1E46895F34509B949595A9A99F291C8B172F55733CDAD8D8AAE912424223D55870960FFD64D132B8BA79A9E2D786D7399D437E3A21D0CAFA98F0D58551E2F9E04CEADD30B5833DDAECB9EEECD415F0362CFB19139D804D1BB762E58AB558BE6C35366FDEAACAFE448983CE791F972D5BA1E6804C4C4C06CD31FD73092D55E474A1DCF1A3A67E06134E0FA3C4F38136BE421318F673E8F77570A9C1589893282DA95093F94CFBE863AC5AB94E5551E49CF3161656888D8D5766172729B2B2B252C271AAF49173B5E14D30E154304A3C1F9C49A39C4A38DADB7A50B87317E6CD5D04B34D167071F684B75700FC7C8364DD43573C6EA39932B738A8493B8F7D07864988A7FA0D134CF8B4304A3C1F18E65AE947ABA8693810499FB69F33E5864461C3FA2D58307F09428223E1CB89776C1C158DC5AB291C8585C567EC30E36F5FE8C8CE515CBCE27047C62FDEB54DB8B0304A3C1F9051094659F42B101E9B2B45FD719E95CCCC4C31A52C307FDE621186D5B0B773415464BC985AEBB17AD506383AB8213FAF48F35DD49FFE7C2B8602A90FEEA3309EEE18E26C7C932347FB405C283F46FF3A26DF68F2C028F17C60D8A26B7E024DA3868626AC58B10A6BD7AE8799D916E573708E794E32CA71E52CBEC049313BDA7B4E988C94851D0C8300041DF58E8E2E857331B7C8A0C4C5D416267CB96094783ED01F4741D0D166C720235414102EDDDC3C606FEF084B4B6B356B17B5CBB118FF495AE05493D9B0488461248BBF75360E3C4D9E71F45F3041E91F383EE5DEF96032F5D37CD570C206B5415757979A00D4D8B4729A596548270C0B3D730A3B4E7EBA7CF94A2C59B24C85753D3DBD55FF878787174A4BCB545858FF9CDEDE0BC370A7C3E8D80046C774E6D4519CDC014766E51CEEA37A15EBC7B83DD2AF6695D26696E2643ADAFED6D6E313BB6A93FE73A90DD01A61885A6FB01667AB22B8AEBD0336101D1D6D62327EB65A6E589ECBB09F88EF80F7A3BBA78E931AAFAF228C1239FD9CA5A5255E7CF1453CFBECB36AAE784E6CCA61AFC65AEC415D1537B5BE758B15EC6C9DC0E58AE56B94CFE1EEE683F8B86464A4E7A80C57EDD8CF0A837ABDEB86E8E96E9F60FAE1416908868E606CE4A8AA5534D0772C5357D6556EA62C750D85AED6D640FF89CFA266D192630E35751E3B64140383AA5F0847C68021BD4AF4FAEF81410AF61F31D0419039B57DFA3036CEC610A3E3276AF4738126D86C4844B71F03BFEDD809FEE65711132B5A0B62985345646565E1FDF7DFC7D557FF0ADFF8C6B770EDB5D7E1B9E75E509D805E9E7EE278BB62DDDA4D58B860898A52B1CFC3DDCD1B29C9196054AB5F188ED7D1F73B3E2BE8B7D067326D468784CBE5168744F08F1ED155663CCA89DEF9270BAED2CCEAEB1741A0F176ECB9F441611BE573F252AAA51E457B87D238EAFCEEAE9335B506DEEBF83885697C8231FB3911EB312DA50FDE1B7F6B62FB585DB24F03CD84D5966C588E8C0FA1BBA71DBD7D1DF22823E2D3E90234DCFF55845122C197C232398674B6843B7614AA4EBF79F316E08927FE2D5AE779BCFEFA9B9833671E76EFAE524E7B6BEBC913D568DA4813C6CF4AA59301B4D6D204133E0D8C128DC198A6D1A009C0317BFB24F38C743ADA5A395193CD6BC264C34904C3A8D5999C4B6A1EFDAC540AC1A91C7ED2793CB5D2E7E1AB9860C2A7C5C48AC6DCFA9A439FE169DFB3181BCDB1536917434D713A2D648209930927110C99BDB7AF53B4C0C9CE24414DD2D3A31B674E3F407F2C87E6380F0D738E40DDF986FD1E269830596094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269870228C124D30C1047D60CAFF03149AB82DD1225D5F0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A350-800'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000CA0000008F0806000000BBF04477000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000052B749444154785EED5D077C56E5F5A66AEDB076D77F97B6D656AB55BBB456AB56AD5B6BEBAE7B2BCA908DECBD026492BDF7DE7B4F32208B2424810412C882EC3D09CFFF3CEFC70D1F1F1F4B408D7EF9FD9EDC7BCF1DDF1DE7BC67BCE73DEF1400269860C2196094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269C0D86868630383C24ABBAEDE1D1110C8D0CAB6D2E7BFA7A27F64D7618259A60C2A9303A7A4C108606D452AD8F8DA2A5BB03833822388AC3BD3D13FBF4313C3A80B123C7056B32C128D104134E85BEBE1E0C0EF6A3A7A74B3631A5777000BB765722283A0A617109A018515848E77E7D0C8DF463746CF024FA648051A209269C0AD428478F1EC1F0B08EE1FB8646D1DCDA013B374FBCF6EE4768ED3D2E20BBF7544FACF70FF6811A45DB9E6C304A34C1845361644C0405E3E052A30D8E0061B1A958B6D61C0B966D4047FFA8DAD7A5E7A3F4F68B261AEE9BD89E6C304A34C184536160A85F1CF64170A94F4FCB29455CCA0EFCE1CFFFC4662BD713F61183C303729EC9F432E12B02CD99D740479ECBF4EDBB5055DB85F7A7ADC06B6FCF878DAD8FA26BE81BE8152D34398584304A34C104438C8C887D6584DE33D88DA1B1A3C8CAAF40724625EA1B81BBEE7D1177DEF51F242517C921BAE38647194A36995E267C45A039F11AFA47747E48C5DE662C5ABE0D193907F0F2EB4B70E59537E0D63F3E88A8E8D889BE96FE41E361E3C900A344134C38571C38D40B735B7F24A6EF86B3672296ACB4C3FC85E67074F44463D36139C4F879930546892698702AD047A156615F0A41938AF45EB1CC7276D6607B611D4AAB5A915F7400A919E53033B3466B9BAECF65E488293C6CC2571CED7D23C829AC82775012FCC3D2101E9B8DD8C4ED58BBCE0C03833A87BF6FA05B2D27238C124D30E15C30383A82C33DFDC82828835F5822B66C73878D9317A213D2B0798B951CA23BCE2428267CA540734B03B7074686517FA80DF11979088C4A86476004DCFC02515C5E09730B1B750CA1DF4939D96094688209670B8DF9F34ACAE0EA170A737B3784C625C3C1C30B3B4A4B61B679AB985E9357403418259A60C2B9627B61197CC3E261E3E28DA0E80458393A8B9F120D0B2B4BD13CC6FB6026138C124D30E15C505A5E8DD8941C044426C1D12B184EDE01F00A0E427064385CDC4E4E67998C304A34C18433A15F2F8DBEB8BC0AE17169221C5170F609C636676F8446C5C12F300C21C11113C74D6618259A60C299A0995387DABA9157588A90E864B8F88628D8B9FA2A41F1F40944BCF82BDA3993194689269870B6A8DA5B87D4AC5C044725619BAB8F121467AF2084C724C0D9CD1B05F9C7F3BD26338C124D30E16CD0DBDF879DC5E5884D4A435064A272E41D3C03E0E61B8AF8940C58DA38A0B6A65E0E357EFE648251A209269C0D0E363620233B1FD10929F00C8810273E08B66EBE70F4084056DE4E2C5BB90E1DED933711521F468926987036D85B5B83B8C43444C625C1C1DD1F9E41914AABD8BBF921776709A6CD9C8BA1C13139D4F8F9930946892698702630EA555452AC042524325609877B40382C1CDC957649CBCE53826278DE648551A209269C090D4D8D484C4E426AC676F8068529BFC4D12B1066364E2A541C93988A790B97CAA1C7CF311C1D3999609478B161385AAEA7E7B81DDBDD7D62E2DCE0E0205A5A5A4EA069686E6EC6C080F1D4ED8E8E0EE8FF0ED759B08DD0681A8687CFFE03F27EB4F5D6D6D68975A2A4A404BDBD9FAEE81BAFAB7F6D0D7C375D5D5D38D53D1E3E7C587B26B53CD5FBB8D0A8ACDA8394D474E5B47BF9072B41610ACBB2F55B91909E079FC050ACD9B8450E3D7ECEA946494E0618257ED6E8ECEC3C8181F9B1C91CDAB6C6247CD15CEFEF3FB1B00161C824C698EE5C702A8122E31AEED3B6F91C1AED4CE0BDF27863CCC3DFD1FF0DFD63B8CF983090CE67E679E7FBECA782761FED9D1DC8DF5180D47431BBC263E0E11B08579F10D5D9B8CEDC56F5D253CBB87AF8AAE3BF0C304AFC2CC08FA9AF490C19861F9E4B3293B6AE31005B6DFD733F0D0C994F5B3704B519B5933ECDF0F8BEBE13C7821B13B23381D730BC0EC16B9DCDF5F485C75843722151B36F2FF20A72919296AC3A15354161D48B3E4A5462269C3D7C109F942E871BBFC6648351E26705C356D3584BA8CF3C86C2742ADAD9E04CE79DEEB7B4FBD4BF7F4D78CEF57E8C09C7E9C0DFD417547DCDFB59A1A2B21C3B0A0B1013170D17771F25284E9E812A2C4CC4A56EC7862D96282ADD2D871BBFC6648351E285843133C118F485E4742DBC31E6D4402625E351E3F038FD633F2DF419DF981633149E4F0B3ECB99EE97BF652888676A482E340E361E40C9AE62646FCF42786418DCBDFCE1E51B0407175FD8BAF8C0DD2F0C99DB8BB168E92A34B6B4CB29C6AF33D96094782161C8CCDCD63EA8FEBE537D6432BDBEB0E93BCB867E0C19CD18339D0FF4FD086342AFD10C99DCF0B93F0D4EF71CFC3D43E1BC100DC39940BF243D3343212A261A01816108088E80A3AB1F2CEDDDE1131C8D8C9C22CC99BF18FD03BA21C017E25D7CDE304AFC22E3CBF0D23F0B5C0CA1E9EF1B46744C021293D290929A8990D048F88836090A8D828B4720B66E7351A92C310999983D6F919CA23BCF24289F234EF7F23F8B96F5AB82C181E33DEBF97945C8D9BE03D939E29FC426C1C9D903F60EAEF00D085582B2C5D2115171E9080A8BC7FC4F964D9CF7658051E285C2E8F8F9D9ED267C71D0DD3388ACAC1DC8DF598194B41D080C8E878757B8F828C10A9EE2CC5BDB38202D3D076EAE5ED8B8E1C43E94C90EA3C473C564AE296BC29931347C0475F54DC8CCCAC3F6FC5D888C4915210983B76F14FC83A2E1E8E20D67676F3838BA21392513AE6E5E7077F396538D5F6F32C228F15C303C3E84231847EFE0087AFA756ABAA77F04FDC363E81938399ECF6AE693B5A2F957155DDDFD282C2A9B109480E0186CB3F3827F601C82C5CCB2757087ABABAFF257E2E25354E595B4D42C39D5F8F526238C124F07DAFF8CF430E2C2F5917160EC28443074CBA2D23A505C8E08868F8C81A9D83C9ED5054726F144325F65B41C6A574242FF2433A7083EFE11B0B2715782C2751B3B57B87AF82338241241C111D8B2D50AD555B572AAF1EB4D4618259E0BEC1C7CF1AF875FC4AD7F7D04FF7CE8357CEB7BBF434C523E44A9605404A7B3AB4F04E4889A0493F3FE519B1C111C3D2A9A6574F21644FBAA6078640C55D5B5484DCBC6F6DC9D088F4A86976F185CDC82E0E91D210212083B470F7878072122320EA161D1D8BCC5123DDD5FAE46D128F174189117A7BF1D12968CDBFFFE845CE9E7F8C36DCFCBF2D7B8F2C77FC292E556E815CB8B9AA57760146DEDDDC7FA23C671749C112BC19173EB9536E1B3477B4717B273F295934E38B9FA2941090A4980934BA0985D9ECAF4F2F60E466C5C321293D231F5C31972AAF1EB4D5618259E0D8687759D49C4CAF5D6B8ECBB37E0BEC76762E6021F5C76C51D72E5DFE1D187A7617F7D3B46C53C3B2ADA655CA4E6A8AC8C8E486BA30A36EB340BA15DCB842F16AAAAF7AA7E93F48CED888A4E508241073E3834118ECE01D862E1A04CAF808008E59FB00372F69C0572AAF1EB4D5618259E0D34CD327254FC1459F10ECBC294CB6EC613CF9BE1DE7F2DC1AFAEF91F2E99723B7E7EF5CD88884AC7B808CB08656B5C24E6E8288607BAD1DDD63421282661F9E261686844B449AE12948CCC5CF8B3BFC43D00A11189F0F18B12F32B1896362E42F3437C7C3A929233C43FB1167F26574ED75DA3BF5F7C53032B6432C228F16CC12CD5BE9136F48E76605F73133E98B106975E7E27EEBC7B155E7B2304D7FC66BA08CBAD58B9C213BBCA1A91B7639732C5180060A4EC0846D5FFA3E2FEF7F4B66370E8B34FF0FBAA63ECD860AAD1615DBA8C7EDACCFEFDF52A7A952542426DA1225B3E614A48BC7C22E0E0E48FAD96F670F70A548242D36BD1E2E5282ADC35718D2F0B8C124F07FD17A92260633DC2E6C3B21CC29008C015DFBD03575CF9381E7BD2068F3EBE4D7EE156BCF1D60624A496C32F240959B96538DC317C2C523684EE9E3EF4E8CD1E3B7644A75946862F6EAAB809C6A12559D289CFCADEAE84841AC5C5D50B2E2E3EF0F00882B76FA482ADBD8F12141FFF302524C48C9973D0D078485D831A89CB2F038C12CF05DDBD1DE81DEE044D302AD8A4B42A7CEF87FFC4A55F7F00FF7BC50D7FBBF763CC98E786B4BC4684C596E0C9673E82B57D280EB40CA9C9FB790EE72AE7B5F4317644AE3789878E4E36680D204D252E0F363409E327202FBF10F10929B0B4B283AF6F289CDDFCE1EC1A0877CF3058D978C0DAD60541A131724CAAD23AD367CC56E713DDDD9F6EB4E717114689E70AA6AAF48F760BD38F614834C5C6AD4172E53FE0B7D7BF813B1F5A888DB699A86C0076EE1EC18FAF7900F73F3603D68EB1D87B700087BBC6D02772C2621DBD83A2A146C5A6551D9272351116FDDF31E1B343496985F81CE9D89EBB03E111B14A50FC8322958F424171F30A83858D3BEC9D3C95A044C624C2CB3B000B162E91D375D7E8ECFCF284FF8D12CF05A3C3C71DB5CE9E6671ECC754FFC9FB1F6EC494AFDD8A2957FC032FBC63099FC87D482F1CC133AF5BE2DEC716E2D5A9E688CBA943594DBBF83703E813E765809D97E2B1701E73535ACCE707CEB9C89070525AA64A49618F3B05C2C33B44F59F38BB07C3C52344CC2E7795BE121A118FA8D82435BB96AD9D935C42779D81812F4F43679478AE181AD031F5510CA2B5BB597C9571ECABEFC3BF1E7E4F7EE1163CFEFC6A7C38CF0B6F4C73C7736F3AE18E479660FEFA48241575C037B20061894568974BF48866191281A1A33F9967909DECD8B1B304B18929C8CEDB016FBF6038897FE21718A1CC2E27B7409DA0B887C1D6C11F0ECE5E888E4B55A6D7BCF98B919BB7532EA1BBCEE097605E140D4689E78323E8474945B18A6E55EFEDC23D0F4CC7B4392E7873AA3D7E78F5B39872F9BF30E5BB0FE395396ED8E29B837F3CF62EFEF9C43BB0F78A41F9BE6674CACB1D3D3AAE22619C1C733297B8998CE8EE1940E6F67CC42424AB2A90D6B64EAAE79D66979D93B7985CA170F70E174D120C2B7B5FB87906284161FFC9B4E9B3D1DE71BC81A3BFA3DFDF36996194783E3872B40FC363BDC2E610F3097070CAC46D77BC8947FFB30CFFF99F15BEF193E7F0F59F3E83C7DEDA8A755E1998BEC85184E75A4CF9CEAF60B6CD0DBBF7D5A3B8A24C74CAA808DB30BABB59A145972BC6E5E946FD1983FEB895733DF7AB04461FB9A4B9959E9D8B84E40C35C497DAC4D9CD57E57259D9BAC1CB2F521085F55B9C306BC15AC426A42331255B650E4FFD70A6BAC6F0C8F819FB4E6896698183C900A3C44F8371D561D88F312528FD18181A14AD00F40D1FC13BEF2FC2E5DFFE13AEFCE953B8F2BA5731D73A13A1059D98B9DE0B8FBDBC00BFB8E911FCE4BA7BF1EECC4D38DC09EC28DC83E4A40CD53979F4C838DA0EB762B0FFE4DCA1D1B10171F8752F7B68F8C47418465CFAFA06505DB50F8D0D874E28C84098464ACA3B181DC1E0E871866EEDEA434AE676E41494202C36555556B176F1838B4F38ECDD8360E7122002E2001B7B6FD5D9B8C5DC59042A0B01C151D8BAD516AB566F98B8962128186732C5D890191B6E4D81223ECF70B351E2F9A07FA85D69021A4FFD0374ED81D2F283A255FE87AF7DE74EBCB32818091540C141C03EB402EFCC77C67DFF9D87275E5E8298F47D088D2946784C3EBA448397551C407B5B0F46478EA2A444D789C54818132B0D05A3B7EFC49A5A559535282E2A47487024A2A3E2274A01513369C77C15C140091354B5EDBEA1E3EBBBF7EE575338A464E6C13F2C46555471F209C336177F057BD7406CD8EAA87C146FFF6825286999F908098FC3FA0D5BE0E6EEA3AEC5F12BDA353F0D8C090BF1799A714689E783EEBE56A551D85A1D3ADC865E69B999EB5554D288E75E5B8E27DFD880875EDBAC04E689572C70DF336BF1F08BEBB0DE3603FBDA80FCB2016CB08CC4953FFA2B162C71469BF0FF11514DECA0AC3F58A7841062960D0EEA3A24474675B1FAA1E1E331FBBEDE61C4C7A5212A22190EF6AEB0B1B6477BFB97A722C8B942DFCF63CD606A7B6D5BD328AD5DBDC8D85EA06A06874527C2C95384C3D91B8EDEA170F60E838DB31F6C1C7DE1E411A242C356B69EAAC331396DBB8A7ACD9ABD0009896913D7D54C2F6A016366D8E94CB3B30D027C96826394783EA0034E47FCA8E894B1F123E811BF8213F21F9146A6B16D1C3FFFC323F8C10DFFC5A53F7E1C977DEFDF98F2ED87F1C207EE88D93E8290D436D8FB96E15B57FD0B5FBBF21E7CFBAA47317F892B76D70CA07C4F93CEEF39AAD328FABF3976E4782FFEE0C0286AF61E848B932F9C1DFDE0E71B0C17670FA335C34CD0A1A3A71FE5D535484ACF56739D0484C78A9078C2CAC103F69EC1F00C8C819338F19676E2AF7886C2414CB00D9BEDE1EC1AA484843ECC6B6FBE87DA7D622618B9FE99702AA1A1B9C512BB9F47ED324318259E0F7AC4041A18EA55FD209C5A99A92D6CD198EE42F95F6BE589879E5F80EF5DFD14AEFFD30CDC78E742DCFFF456FC6FAA37FEFCC0624CF9E67DF8EB834BF1CD9F3E8B1F5CFB1AA65C7A1BFE74E79B28DED385D6BE51341BD10C23A3C7B48BD8B8070F34637B4E212CB63AC0C1CE1B09F1A9F0386612F03E4C51B493B1FF609368937CF14D8A5429549A5D76AEDEAA4E97B36F18EC3D02E1E61F21C2E38B4D964EB0DCE60E3B69885CC50463448C21E20FA7CF563E291D79EDBA8D8DCD13EBA7C231ADA0FC8FDEDE7E7C513B298D12CF07ADED873128FE03B5CAF0A86813C5C4F232C68755E48A6C9A54B01FCFBDB91EAB362561AD4D21EEFB8F19AEFDF30CFCFEAEC5F8CD6D0B30E5FBCFE007D7BF87ABFF321BB7DCBD100F3EB306AF7EB805FEE139C8CC2BC7810387D1D33980D181136DE18E8E2E4446C42177FB4EF87807639BB5AB5AB730B79938EEABEEA310CCE3D2D63B7A7A5150548AC8B844EC2CAD8093BB38EA6276593BBAABC2DB0E5EC1B074F4829D3BAB408A43EFEA8F2D96CEB075F44158448A1A8BC25CAF37DF7A1F63F239282CF451AAAAF62036361E7BF6D42801D8B7AF4ED1F2F3772025250D8989C9484848426242AA7CB3587879FAA9A214B6DB1CE1EB1388A0C0301C3E74BC942D833314A2CFCB4F314A3C1FB08073DF40AF388CFDE8E9D73D284734F67532516E5434CC18BAA5D17963DA1AFCFAC6C7B178632C5EFBC81D773DBA017F7F782B7EF4BB19B8E3094B3CFAA61B1E79CB096FCC8DC2DF1F5D83BF3D38178F3FB71065955D6838D88DFD358DE86D13CD35AC6BC186878EA0B4A402FE7E214A8B0405862BFF242E3619F676CE4AA3F138138E4331744D2D3272F210159F84F49C7C38B87AC2DE451856C0AA8F76A24D1C3C8360ED2CDAC52B44B44D02365B38C1DACE13E99945088B4C50F95EB7FEF136F8FA05AB0EC7B2F22A787BFB62F9F295A8AB3BA098FBB0F8AB4D4D2DA8AEDE8BCACA6A1417972AA1292FAB4266C67695A54C2C98BF18B7DCFC677CFF7B3FC69D7FBF0769691972ABBAFB6543A8AD7FD6304ABC10A0AFA2AD8F8FCBBA607CB40F9D7D5D20CBD6B78FE2E63BC447B9E4463CF4F42ACC589280FB9EB2C71BB353F1F19A1DB8FA8E7998B63E15B73CB00ECFBEE78B39AB1270FF630BE58E7F8DE79F9D8A2323C0819A3A69918EBF48FA237BF7EC87D92673AC5EB51E3B7716C1CAD24EB55ADC3F32A21316F6C770F9550319B6ADFD7874B07ACF3EE4E4176067491932730B10141EAD04C53B200C7EA1D16A722017BF70780446C1454C3027F1571CDC036166EE089F806864E588268A49C6367B37DC73EFBF70DBED77E1F26F5C010BCB6DE25BF48A5F7A540944616131CACB778B25D0A09664F8AEAE1EECDA558EBCDC9D4A73A424672821B9EA273FC715DFFE1EEEBDE701FCF00757E1EAAB7F85D6569DB9BD77EFF171F8D452DAFA6701A3C48B8DBD35FB30383A2E1A670457FFEC6EB98B9FE377B7BC8E079FB6178DF231169B17E1A3A561F8EBFD2BF1EE6C57CC5D1E8CEF7EFF1D5CFA8D0771FF83222C975C816F5CF15B55688DE3C0EAEA1BE1E4ECAE5AB330F9D8F60E4E080C0A51B0B7774743E361F9594CE9335215E68B0A32B5E6E4D2F7FAB4FD3E5A74D010AD1DBDE08CBEC969D9489296DCC73F0416D6F630B7B1878D838BC23647575839B98B36F1C0161B67D5E148DF84D1AEB08854040725A85CAF25CBD7E1F1C79FC13DF73C84A5CB562327BB40D9602C9ED7D2D2A4E6B7E15C36070E36A262F71EA57158C0BB521A3516AEA8ACAAC1263373FCE4AA9FE3EA6B7E831B6FBA1577FDE39FF8E9CFAEC6D7BF7925964BA3A7DD779F38F8FAB30B3050A4AD5F4C18255E480CF60F61E4581A3D5B743AF81595BBC5E91B5303B8C242E295969872D98DB8F6D657F08B3FBC2EDBB761CAB7EEC153AF2CC3946FDC84295FFF9308C70D78EE7F1B30E5F26FE2F7B7DC87EFFFF0465C32E5777077F797173780DCDC62F8FA86AB426CFC581C8DE7E9E587CD66C60B1D9C6B2FBDB1E31949230313E77ABD0B05DE03C14174EC7F38D57DE8F79D304DA5BCB206E959794849CF45546C0A7CC454A526090A8F856F48143CFC43E1253467F1175C7C83E02A6615E769B4B2F55066574050BC4AB55FB7D102B3E62EC6DB6F7F8499331760A53035C7CDF7F78DE088C839877E3372D5DADE86DEBE010C0E8DE1887CF7F6AE7E1C9006ECD0E10E253CF3172CC60F7E78957CFBCB70CDAFAEC3F77FF013DC79D7BDB8EA67D7E089A79E55F7AE1F283084D61969E8C3B0B1B910396746891703A3222463637C18D1247DDDAA32CB803C003B10B3B2AB71E32D0F8B10FC12532EBD06350720AABD48D6AF848D6B02FAC549FC68A615BE76F9CF41999353E1E75D8C1F5EF14FB91E10179780D2D2326576AD5AB90EAFBEFAAAD0629099950AF32D56AA75E3EF7FD106839D4EB82EA4E0196AA39ADA7A648BC943414948D9AE0A6C6FB6761247DD57C1CAC9534D5ACA197EB7B97BC25C34CB3671F2B7DAB9AAE3E8D4FB05C5AA30B1B99503B658D8A9027841415130DB6C290D943FB232F350B9BB464CAF62E4E4E4C8B760718A4C84864521223216A1E2C0131CECC512AD1C6A1C161EA30AEDE51714ABF1F92C8FC45CB319B3E6ABE368359457548B85D0ACB22EF82CDAC84C62A04FBEAF98184CD23596C9A1D3D29FEEBD1A255E0C0C8B5F70549CF9F1A3BC514A79BF3673168E1C1D475A4611FEF897FB4573FC08F109851092688CEFA0A973084B57D9A25B0EBDF9E667E4C51F82AF6716B66C0CC5D7A6FC5E398A5F9BF27571DCDD457301032255A92959484A4AC1C285F3B175B339C64646E57A63686BD5852BC7463F7DE46B64583EC2401FF83C5C3F693F0592376240FFA2A076DF0135C14F70583462E275F3C3D3ACB276F414BF2456FC91083569A95F789C9AE5D7234C7C94E05004C5C6CBBE3035FD5C684C0A2213B2101597A9B4119322B3B6178A735EAA2AB5B0AC516646AE8A38E6E5E521313111C929696AC464724A06B6E717215784213DAB40651D532078CE2E71EC4BC4246350A0B2AA564CB46AB9EE0E54D7D4CB6F2423454CC415D2109A6DB6507E28AB51C64445A3766F8D3C9AEEF994E048C3383CA8FB06861AE6D3C228F1428237AA459C8E8C0DA99A5EE34C43612516A1757532274CF770875A06E48EBE8B179F7B03FDDD3D08F34FC494AF7D1B5FFFC6AF5567E3DFFFF60A1293F39097DDA8D4FA8C0F3649CB017CF3F21F63E92273B838842333B50203BDA2DA5B87B07CD93AD86DB3D7B52E47194A1E1306979D47A565B940DA6578F4B3110ABE47B6A274845B5A0EA3A1A14939C70CBF565454A2ACAC023B761422393915313171888E8E45585884200CE1E191888C8A11C4A9569BD3C991B9D9AB9E9E5DA8B44A465E097696ED455E7125F24AABB0B3A2462D4B6A442BECDD8BB27D75C897DF2828AD44F1EE7DD85E5086D28A7DA8A8DA8F9DC5BBB1775FA338ED15D85FD7889ADA03282FAB46D9AE2AECDFBF5FDD5BB5DC67FD812659EEC7C1A65634B674A2667F93A001BBABF761FF8166B475F6A1A07097BABF86E63635916A624A267655EC819F08292BC1B0105F52923484899922287E70B477C2366B5B586CB5C4A2858B4568F6A1BFF7446DD23F3084A1F31418A3C48B85B151DAD03DC2A8223023C719B5A5B95DE562B12FB0F960379A1B5A317FF64A9097376FF5C2AAB5F6B8F6BA3F625004EDEE7F3E885FFEEAB778F491E7E1E793A286AB6EDC6829AD5905BCBDA270D9A53F82B9B99372F2991940738C1192E6E64631F57A8E55AB1C3BA78E477D1FE46CC3CCF409183CA099B06F7FBDD8E155282ED9859D85C5625AEC9456344FB5B0DB73F3D53AAB9D6464662321311931D27A4709A3874744212C340AE1D2FAB3AF2146CC917869599312D35494285598889A93FD125962DAE4C83588BCBC021415952873941127AEEF2C2C05C799149754A04A18B3724F3D4ACAF6A0B47CAF62D88A3D220845E5D82982B043189CD855BD1FC5D5E2785755A364CF5E9454EDC5BE83E294CBF72ADE552DCCDD8A436D0C0A1C406B6BAFFC5EB5EA9D2FDD55895AB19F1B1BC40739D40A46ABF6D6D4C97B3888DDE21BD58B50F037F9DBF5F2AD791FE595FBD47675CD4175CDE6C3DDEA1E692252502A76EFC56E1150F6A19595D5A220AF0CE9A9F9888D4944A0F8A3EC7B615FCC270B97AA7E338EF5D79FE39E82C2942A6DFB5C61947831400665E1BBC1BE7611925EB524BDBFFF788E16C3807CC0C6C6763005E9CAEFFD0295D53DA2AEF951FAD5C8C9DBEF784A398354129C40F8D2CBAF445BC788080170F7DDCFE1924B7E8E5F5EFD47CC9CBD586921E69955D5EC477EE14E6CDF912BB423E83FA6CD4E85A1B1A3181891E386C7C4E41B425B572F0EB577813DD845BB2A90932F8C2E60FF034D89B8F864616C3277BC086E92303B0732A508C327AA256984AEECCF76159DCB2F2842C18E6235D496D0B639469DEB646C623799444C10F63770C9ED4A32CD313A358A624401D7F55153232DB5082935CFC18616151DDC272D38994D63548688E950B32044756D1DEA1B5B70B0F930EA1A9AD1D4DA81FD2DCD38D8D6AAD61B0EB5A996BEA9A943316D7373273ABA87D4B50E1DEA465D5D0B5ADBBA71B8B50BBD3DD28A0F1E5161E2B6B60E3080C02459EEEBEA1A52C25077F0B0D22CDD7DA3F27D0F89A66917A1A851DBDBF34B14AD458E2F14E166C0861A6BCF9E066914CBB0A7AA11BB4A6A95C0EE28AA1073325381C301E6CC5F8AFFBDF236A67FBC40CCB90A154410D6513EB1FE773E1718255E2CA8FE140847B342E4D8A99995C5D50ACB6B505DD7852BAEFCADDCE5AFF1A31FDC87BBEE7C4FFC96FBF0E31FDE8FDFFCE641FCDF4FFF86AB7FF9A0985EB7CB31B7E186EB5EC75F6EFD10BFF8E9BF71C9D7FE80DB6F7F091DBD83686EEB42656D2D5A3ADAD025FEC59EBA7D48CDCE466058A41AB1C73116C1E14988884947646C8602EDEF98846C24A665A9FC27E6413169304B98BCA0B80CC5E5D2EA9694AB964E035B4B9A167BC5A6D6B0676F9D5AD21CD1075B5E322DC1753AB104F729663ED8A2502FA64C9D6C1307643F870C348BE94234350AA389C66A6E16263BD8A8C0169C60E71E4D34EEE37A738B30B83079A39C47A626A336B674ABF3D91948B4C879EC67E9ECEA91C6A15BA1BDB717ADD2221D6AEFC0E10EA1B5F72821681121E916866FEDE81766EE518CDCDEDE8F0E319F7AFB86D17AB84B7CC26E652AF2DAAC14CA7DBC87EEEE61250C9D3DA3683AD4A504E440A3FCBE5CE770BB1C2334DE1F0585A659BD3C737DBD084D4B17AAAB0FCA738AD9B6A71975FB5AA501DC8D1DC55548CBDA89B824F9A6A171D8E6E089B51BAD307BFE72FCF92FB761FA8C8FE51BEC13D6D2F1576373D3C4BA16B9A4BF7C3A47DF28F1E282E92D5D387AF4B82621B44212B4C599D458B5FBA0681DA0A2BA11AFBC3E5BEEF41AF157FE82EF7DFFBFB8FC5B4FE297BF791557FCE8015CF6FDFB30E5CABB70C977EEC155BF7A01DFFCC193B8F5F6E9F8EBDD1FE0A1FFCE82B9752806A421A1361A157D3222E6D888ACB78A4AAA696A14616C41D99E0328AD3A8092CA7A145588CD2DAABDB04CCC8E0A314FC44C2916C7B2A4B2568ED9877231477657D729D03EA7D941D06420F6D436287B5D033FF43E6170DAE004D7893A0A82303A5B700D079A0E29B045D7C0569C4BD29B9A85C9A5F56F9356B6ED70275A0F75084376AA0E3B82F40E61E4CE8EDE0970FB045A67B7025BFA9E1ECE7749669606A4AB43B6BBC404EEC1803426EC94E53EAE93999898A88D58E4CC5B346B0886FEC7E4853233A2B747F6CBB2A77748090BA7A6EB9197DFD537A82AED748976EE132D4D4D4F96EC191943A7F813DAFE8ECE5EA579D8B7C2E72238CCE2F0A14E6918E41E3BFBE5F93BE57E84834448F7EF176DD7D489AEDE3111B001E537D9387960ED662BACDD6A8D77A6CFC6AF7EFF473CF0C433B0B073817F4884B20CC867049F4B5B3784A1697EC2CECF069AA09CE84C1BDE5875A5B4AC358774438A6B5AF1EED475F8F1550FE39917EC70CFFD1B71F7836BF09F972DF1D1BC48BC3B3310B316C762F5E64244C48F23231F088E6DC5C235C1B8F5AF8FC9C7A25772142DEDCD625ED4A0524CB1EAFA83A89596A5A6EE10F6EC6B46E55E718C65B9FF608730660F1A0FF5A1B9750007A5656C948FA520EB758DADC2E82DAAB5A37DCDD68E0C4FD04925689E1882137F36CB473E44D344187702D24A13AD9D3D13A0A93781EEBE8975163C2723912115BA07541F91863E61D081FE1130839A4CCC25999A3405716AB50154F4B5081E43301588E37EB824B3136A9F30138F1B1D6506F8918975FEB1256644911126469BC6C45CD5056F645D0EE16FD2E4E1371C167B9902323426C71C3D8A3E69BDDB7A7AE4DB0CAAC163ACC0431389E6113B15B9E47DF239794FBC97DEBE21A5915871B44F9E8F8D0DAF2D3F2B56430FCAA4217BE7A359F8E7238FE3B1679FC7EB533FC29B1FCEC2BC656B6166658F0F67CE81E5367B31438F6B94B38551E2C50505A5E72441314483BC04464EFAFA87D5CBA01F76FFBFE662E9AA6C7CF071125E792F14735666E2E3451998F949BAC2C2153BF0B35FCFC2953F79133FFEE52BF8EE4F9F102DF46369B18EA0BDA7431CD11A71440F8A70889088C9D12ECE364D0782B67243B3B4D01D8362778FA0BD6B58E1B0B4726DDDFD72FE003802908C4E86A7ED4C4667A4869D67448730AB21D862328D9DD05A4EFA3E5CB2B5E55203E91AE823116C81B56DE666B1D38D8CA3189B4B6995C99CFAD0A7A9565FEF382EC7C618CCE0FE611108F63109B3493B6508323B9995A928141226948E8FB3C991EB8CF663FCE830C647067164585AA2232214B28F6173D5672582C0DF18153AAB81323AC8A117238C381E034B530DCA8FF3FBB21822317A644C0DFAA38011BC5FD6AD1EE4B89651115E59F2786A067E47F6EEBB7AF8E2A5D7DFC60BAFBC81FFBCF832EE7BF4093CF7FA9B30DB6687B8F47C1455EE4352661E36996FC36B6FBD8B0D1B4F9E0DEC4C411AA3C48B8971C80B1641D10D1D3E79FFA0BC742656AAF212F2810EB5EA5A8D436D4771ED6FFF8DABAF7B0B3FFFCD34FCE0EA0F30E5F227F09DAB5E13BC8229DFFA2F2EBDE205DC72DB5AFCE4EAA94A50AEFFD37B98F28D9FA95A63ACECD2D5DBA6FB58EC94928BB25D642A0D3B7C59719F8CCD65EFC011B19F87657B4896141C1DD377498BCDB41BB6663C8EEB9C40C990D1B56DEED382021AB3F3F7182CE05231BFAC7340A021784FC4E0B1FD5C67762E831C6460D5EB2DDB64E2B13169AD05A3C24804996B423044484EDCAFD30C049999D761F1742578A251786D6E739D4BD68CD65D9303B0C8ECEC0B13061F12AB00222047454018F21F1D90E345C3A83E2A6176D55FC6DF3DB61CD795CF656646DF70BF328319C51CE5775667F09D7044EC712121F8C7654F6FBFD2380D2D87505E552966563EEA1A4450F6EEC3DC858BF1E4D3CFE1A38FE760D5A62D70F4F441616535F64A639896578A90D8340447252138224E75603EF3EC8B2A52287F137C773AFF84304ABC98D009CA71FF6440984E5B27BA7A3AE5C58CAB97CA8EC8CEEE36610E51BDF201AFBDFE61119417F1C0E39B70E36DF3F0EB9BA7E217BF7B13773CB018F73FB11EBFFFF31C3CF5BC2BEE79D00C77FD6B29FEF1F03CFCF6A6FBD0D42EAD9E5CBC7FA85BAE291F485A25AA7BCE08C6E43C6D4C36CD17CD74610AC6403F5B4E112AE154A65E70C96D32EB045D185E637E0D1A8D20936B8CCEA5B65FA351684F05FA552CFDA4ADB3E1E0BB20D35340344121C8D0045B5F0DFC234DFB633A09A1AD1F3922CC7BEC006D4901E29F2650FCE3EFE9FEE477C787E5FBB0F5E592011936371448B110444B90E5791C41C1E277D4BE2785840DD6F038B582BC330A961CC98C722EF94D68A271C9BE0F9A5F34370FB776A2B1A905EDDD3D2228CDA8ADAF436945391A5BC5E73BD08855EB36E29DA9D3E0E8E6855E79B72DE2CBD489CF5625BE60A238F93EE2E07B074521302C0629E93998F9F15C3CF2C8632A8B59FE2678EF74304ABCD83895D9C517DBD8542F1FF1082A2A2A548E506F7F8F6272BE48678F18693D5CC461CB87674005DCFC8BE1E85B04079F4244A5B622236F1C5B6D76619B53351CDCCAB06A630C9E7F792132F3AA54EB4D21A1E9C0D6834395FB867B75ADEA3186D031D27126E39FD67AB375E59202A2CC1F4D600C98DB101408C5E4722D2E3561511AE218ED74A03DCF258F65589CC2A20986F09A5A6AF7AC0FED4F7F9D7F7C460A8532A18E75C2EA43377AF4F8F6B13C29F5A769070ACBF0086B10B01394E589749A63445E167F8EC38DF9ECBC6F8EC9EF17FF85E03AAFC02B73D92FC248D3F290F8681D62A272BD5D7CB296B64E15BC50010E31C1190D646725C3F3E555D5E23FB6A0E6401DCAF754C97A1B2AAA6BD4581AB6B987BA06B0BBB61131A9B948CD2D417A5E1952B617C3D92B48955BB27374C373CFBF8C77DEFE40A5FCCBDF449ED8E9609478B16128283A07517D90290D0D0770F0603D7273F38589D9EB01A562B9ACAD6F43627229D2B2F6A1A0F820F28BF763BD65B0AADE3275B635365AA4C22FE0006C6C4BE1E9B30701217BE0E9BB0339F907E4230993C835B49692BF279F52289CD8889F4EC779E362DF1C110960F5172EC785A9153F1D634832261956F840773DF947E80B8746530C716C5BC7763A3A5B4D3AB584463F15F809B5F3F99BC48430A82557747F3A2D21D7640B2DE03AEF57274CBAE348A3AFA19E5F3D18F7B3F557CCA29C77FE91461F46778D71D521AC691D1EA3ADF30A3431B9A4A6D4EE5B2C39DDFDCBCF72BD6F583C53417D4B870223897B1B0E49E35684C4B41CC42567AA40093B3E193964DF0CA38835354DD8BB571751A43FB27B4FAD0A5797EFD983C4F454EC2C2E574E7D49C55E648B99151E978184B41D088E4E4364622E82A252A5418DC0FAADF62A5CFCF26BEFE2F737DEAA3A6CE5EF04BE3C1D8C122F360CE742E147D31F07CF0FC1BE000EC44A4849877F7008B6585A60ED862D7070F2436070824A9B38DCD68A7691B9151BDC70D915BFC7EF6E7A0EBFBBFE0DDC77DF523CF8D0123CF7C27AFCF7D9E578E23FD3B1CDC1470506C82FFCF8875B9B84CF447AC41C18ECEDC28898614769230F091330AC221C799402234DFF1131BB7461503123C89C72936458650A8979C89033E7ABD4C06DD2696F9359F405473191080A5BD8EEFE81099A3EB4E309638232F1C76D61587D61E1B63E4D7BDEE382C2A8143324683E89993320AD785B0F0E09F30E0F891F27660B4D4EF6AAEF2AAD54C7676464A0B0B050F93C2A5D6657A5D2B0CC7AA0AFE7E91784F2EA5AC426652050FC80BCE20A44C4A7AB04CB90E8544427E52021BD003B76D52032291B190565884DCB131FA20305A5D5C82AD885F0E81474F68EA9E8636DDD21ECAB3F8C8AAA7AF9DD6AECAE3E805D15FBD4B421ECCBDA595AAEFAC10A4A4A148D2828AA14542B21F1094A80A5832FCCAC3CB1DACC169FACDC8C0F672DC6E34FBD880F3E9A8DDCBC42BE8A09FE3B1B18259E2F74939BEA348421742D161D4BE3FB55C7D9816635D88A231457AD5EAFE6047474F15485A0D79959AAA207AFBD3B1DBFBAFE56BCFADE74ACDEEC84FFBC3017D7FEEE193CF4E80AFCEDEFF371FD0D1FE0EE7B97E0F67B17E2C63FBF8DF59B23A55523A308D389208C314CDADDAF9C58AA5EF62374741E562605A339342FC89EE3B495C8A5C2676C80C92CB49F6946D09656CC2CDCAB853F4993C314B88F0EEA909824141ED218F9A2E93520BFCB6DAEF33C9A869A1FC39699FBB82ED688BA0EB5188726B0820AB319FAFABBD49C329D1D6DC2D40770F850B35A969614617745190ED4EF47556505AAABCA5154988F9D3B0B909696828888088484862B616756015366F6ECDDAFFC806879BFECECF4F70F474949159C9C7C70F8708BD236CCFCA590CAADE170C7A0BAE7EADA16756F1939A5A83DD8A90AAE87C564A168F7414425E58900EC41796D87F809BBC4142A54DBB1A93B9057528B1DA5FB452314C1DE29102BD75863CE82D5A8D97718B9F9156AE6E1DC5C8E8014085333A381A9FBCCFD0A898C857F481442639210235AC837385EF8C10B8B966DC4D4E90BF1D67BB3B06EA3955CD71BE6564E983B6F13DE7E6721A64D5F8E556B2C549ED8E16303C10C713ABE3D897031D1D3A3CA6DAA0EAEC36DBA3934B41A4E0D0D0DD8BE3D0F7E7E01D86C663191B313161EA960EFE082058B97C1CB3F18AB376CC6234F3D871B6EBD0D2FBEF111566E70C4FD0FBF8F4B2EBF1DBFBCE645FCECEA57F1A3FF7B11B7FC650E6EBE6D0E2EFDD643B8F2FB8FE0D12766827E29CD92216653CA3A1D72320DC1821822C20A1CEF7F2CE151B5CAB434C828DAB164647D46D709893892625FEBA3B9F5B02C5B9506A1A9C57031C3C28C9AF54B734CB385F638CB98C62549EB1BCF0C817824A66628A465E622393D4BE5B4050587C2CBC7139EDE1EF0F671878FAF3BBCBDDCE0EFE7054F0F1704F87B233D2D0979B959C8CE4A43417E0E0A45400A0AF254AA3B87DE667376DF9C4231A5C6505FDF8A7DFB5A1015958296961EB8B8048053D5787986A3A2BC0136D65E888D4D57CF3F6DDA423571D0B29516786FEA224C9DB112AFBE350F4515CDD272FBC0D5271EC5BB0F61FE326BF8866661BA30E8B28D2E700B4CC7BC15B658BEC91D2B377B62DE522B2C586E23825482A56BEDE1E41181B5664EB0B1F3C581C63E71D2EB1115938188A834358292D9C87EFE21F00D0845B808476A563E2213D254A6338702ACDB6C8FA5ABCD31FB93D598B5709508DC2AACD9608965ABCCF0E18C0578F4F197F0FED485F0F58F166DB85FBED2717E3C972C6FA3C40B0976466929CF84617DADB6B636C4C4C4C0DDDD5D5A3017CC9A35078E0EAE2AF1CFD3C3176BD6ACC18A552B51BEBBE2186332574B67DB978A3376FF23CFE2B26FFD1253BE7E1D6EB8F905FCE0AA7FE31B573E866B6F9C8ADFDD325DB4C9C7B8FA37EFE317D7BC832BAEBC0FF31658A0B272BF4AF7F870EA4C3CFDDC4BF00D0C11B55D88E8841844C48623392305F12909888C8D415874DC04C205646242CBED0A0A8B145F281C1E3EFE7076F71213CF59ADF39A444048A81C138EA4B474951FB66B77B5EA9967C764D3A10EE58C32C78A82B2BDA01065957B941DAE72AD0EB7ABCE4AD5632FF7DBD47C08DD6226B26F42693BF66308582D93100F4981EB47C6F9CE45738A934D5F4445AE84E1E98AF4F61E455363AF9858E2FFEDEFC4CD7FF807C24285A1E7AEC33B6F2DC0EFAFBF1B1FBCB7040F3EF03FFCEFA599D8597840B4F47FF0C73F3F0A7BE718BC376D1D9E7D692EDE7C6F35BC4373F1F1226B986D0B45765133DE9CBE1E4171A5786FF666CC59E6884DF63198BDC209F356BB62DA026BA4EF6C82939F9872953DF870AE39C262F33177F156BC3F6305DEF97011F28AF6C1DE9585C14354A13D5678B1D8E6A4D2527C82A355513E16BAB070F4C2665B376CB5F550B066792AAF10F1531D316FC93ACC98BD187317AE54E3F93914803966F237C17767EA37318451E2F9C098EA3246AB3FD0A006F35083F8FAFA63CB16736CDD6AA1D2C41D1C9CB07AF55A848484494BC75E549A472CDCA60B027449B3572B0EBFD692F78A35B770A925BEFB93BFE0926FFF19DFBDEA214CB9FC4E4CB9E29FF8E1CFFE8B9B6E9DA64CB1DBFF36131CA3EFE99D0496DAADACAC47645C0A8ACA2A515C51818CDC1C64492B9C5DB01DC999E962EFA621212B1BF1995948CCCC467A9ECE3E2EAFDAAB86AFEEAE64E66D83389F07D488413A9B5C67A724416160A446313AD1A8EBC1A78068692CD42844736B87D240D438EC4CE33A2340ECBB619FCC80988BECB166F8BCBD93B9532DF2F11BD1D85487CE2E8E146C50E8EBEF947DCDA8ABDF7B8C764004AC5EBD47FA74CD2DED2AD78B664E47D711D4D77509177C17533F58A804E59E7FFC17EFBEBD104F3CF6065E79E963FCE39E17B078A92D9E7D7E267EFACBDBF1C2AB0B70C73D2FE2AEFB5FC153CF7F8CD5E63E78F899A998FE8939ECFD52F1CE9C4DF08E2AC0FBD2207D2802B4D1210AF3D6BA61A9990FA62EB0C41AAB60BCF8CE1298D985E1AE875F87AB6F12D69B7BE265D14E8FFDF76DC4A614232A211FAEDE9170F78D96862656E56F790546C2464C410B11180A89AD7B20ACDCFC95D0ACD9628B8F3F59856973968A2FF2896897952AC295955BA242D1E499B3C1E9FA528C122F264A4ACB909A96A146AB31FE6D66B605DBB6D98946F184A3A333ECED1D557A38D53D3BBA28245D9D3A2DA4A94A66FF320ECF9EDD5661120A0B1FB147FEED286BC216BB70FCFD5F6FE06BDFB90953BE7603A65C7A23BE79C56DB8E6DAA770C9A57FC5A597DC84E9D2F275F5E8225255B507515C5E89439D9DE81D1E4483D8E5070F1D42AF30E8FEC36D68EEEE45AB306983306F556D3D4A99C55BBD4FA58B73BBA6BE117BEB4460F61FC42E111ED20896282D2AAB465E218B3788B610E1E2FE26F1072AF6ECD3255556D7A0B6BE4165385393B0B779CFBE7A456B686955C24461ABAD67B264BDAA96D9D8DC20CC7F000D8DA2191B4438F7EE56DB2D871A505E51A2B69B5B0E626F4D25F6D414A3B2BA08D53565A816FAEEAA4A1496EE529A8A633F4ACA6AB07A9D3452968ED8B0C91673E6AD427C622E167CB2014525FBE117908ACCEC6A30825A507C00DB0BF78B16C84372CE6E64EDAC45405C365EFD48846CB505966D76C0478B37618D8D173E58B81E2B2CDC60E7178739ABADB160BD1DE6AEB482734082AAEDC6E5CCC566F00FCF824F48BA084108B63987C2DC563483987E5E01716A6963EF211A3A540506CCAC9C5545185B118E559BE55E576CC407331788C9B5020B97AF0773BC38A4393BBF18075B7429F59CE44ABFD0C9A78551E28546A7303AFB454A779563F98A55D866EB28CE16EB4185C0DACA4E9958ACC6A15F308DD2DDDBDB8B6123433A39770AA7C463CDB0610C88900C63E8E8C9AAB44F3E2E35EE260B575C7FE3DF71C96557E3F6DB5E1541B919BFF8F99D98F1F172F10BB60B93362A2667113846538ACACB95E0B0205CD95E61E8B2DDD85E548A920A319B0E36ABF415E66E512B50C8F6EC6F44F5BE0654D61C40E1AE2A94EEAED1254FEEAD17536B3F4ACA6BD592C7844625886997A33292236213954FC2EAF134BB585FABB4A24A995F9A09C6DFA036E2B896FD7507B0B7760F6AF7D7A8FE266A1486D3E9F3F11D3320A13AF9C675E36D889EFE369591D074E800EA0ED4CAFD56AB5E6D9AB099DB7395C66273440D5850588EF4AC9DC8DF5981E4D40211941A8445A4233C527C86E82C8444A4886F108FC0A844A46C17273BAB00690525F08D8843FA8E52848AEF10189786D8AC1D08884D45626E317276ED457042A66CA72132793B7CC31390B1A31C49D985F0166D1195588090E86C387B478826C95185C06D5DFCC46C8D81975FB8F826E17070F5C65671CC2DECDCB062BD39E62FDF20E6DE6A7CB27A3336995B2B079F8D1073E6F4BF3FD1D9D3AACA66A97AD5629530347EAADAC6A78351E2F9C0D0F6639F48A69831B6F6764A48DCDCBD612B3E082B7E787807A9AC57FDE3D977A2BFADA1BF9703BB46D0DEDE2A9B62CEA90158421FEB43EF480FB8EC579D60C7CFD1EF481A60F2922C6DED82F1DC73B3F08D6F5E2D4FFF1DC19558B7C146A576D38CA2E3CC9034C79367722C7746BEDCBF3044663E925273D4F0599A6B44B43006E3FF3189E90A2C6E9D94BE1DE9393B94D3C9ED84943CC427E7AA5184C9E9F97074F351511B66B2B22A23C7B4D077A190EC28DE85BC9DC54A68727714A93242D45ED43A35B5FB959FD2D6D1AA4C507E7856F367608139500C55331A57BBAF4E0D10E380300600FC0342E0E1E9AB8221D6768E7074F580939BA7BA76744232C285E9CB76D7AAE81A73DBCA771F809B4708D2338BC5018E818B733032334AE1267E43FE8E4A040BA3F3199DBDFDC46CF257C528F81EE2D37254410A3AD971E9B9088E4946406402BC83625468382C365DF647222C2A598DAAF40988145F2F15EE7E1148CE2A5482C07D1EBEC170F3F4539557D8986E32B3C08C99733177C112AC5C47C1D8067B79870C2B37779DD8CDA0C1D0D467904699EE0327F2872118913D95F97512E17C40216144893FB66FDF3EC4C7C78B83EE202A5D1EDAD101965636A24A9D541A0153DFF5CF3D1F0C9D831DAA81C5ED0F3474E15F0F3D83CB2EFFA138FB3760D3162B35308BA57438563B237B0792A5358C894E4644783CA265C9B9402804C919B9624F6789939E87A8B874C540FCF0FCD831720EC74624A652404478D20A94E6E236058B6618354A7482089B68949088E889A000C1E817350A3386198E658B4F8150FD28B2C50C030E841B18EC162DBD5B0DF17576F1809DBDB3828BAB27DC3D7C94705859BAC1C6DA0301FEB1AAB2639CB4DA31F119AAD453484422824212E0E115063B071F15D5DA5BDB26A657BE5C235CCCE350F87AC5C2DF27569D1F1595A6A6A763CE14B5A1BFDCABA74F30BC7C43C4E9F681D53657985B3BABBA5FEB366D53D55A2CB779A849512DADDD6163EB89F5EBAD6161E18C0D1BACC427B5C7EA0D5B6169EB8C8D5B6DB07E933996AF5E87156BD6CBF3B8C147043157BE034746722C0BA384DAF7FBAC6194782E3856206262BBA9A909B9B9B9E26F3862C9922558B162053C3C3C90268E31CD2F4369A7701DEB0D9EA05D68188601BBE4A5B3FF447FBB20BF08AE2E9ED8B8618B30972D7CBC03D410DC5461708263B4E3C4AC600B4C551F181983A0A8586198649543E4171C29F478448A89C1CE330A0E1D51FF50395E182C222E4B15646001B9E0A814A4E796CA7606AC6C1D540B1F1E11A346387214208542CBDAD5751892A2D31CB9792CC890249A224898D2469C56110C0F6F1569A329CBF241665BED8439DDD5A4A42161494A4062E3B355B835357D27B6E795AB6D0A09E739F1F0125FC0D60B1BCDECF1C8632FA8C6E3F917DFC5D2E59B616DE32B1AD70EF316ACC3DCF9ABB172E5162C58B01A73C4715EBD92FB1DD424A79151F16A3C3B07B071B01A07B1719DD36FEC117FAE46681C7CC6ACF016F18F38D684E367C83FFCFEA7EABF389585F159C328D118F8201A43B33FA4B5B555A53568FB6B6A6AE0E7E787B973E762F1E2C5B0B3B3435050108A8A8A8C4EB970BA08C3C506C75A18D2087E9463B94D13B481DE311CAC6B16412A46527206E212696EA5A912A4C1D1B1D2BAC6880319AA7AA75917CB3728425723CB5F4CABC028F804C72234264D25E5790644A8C979AC1CDCB0D9DA412D39051C87027382514EEBA61B9ACB2C678672998F05353A8FE3EB2322A3554B6BB3CD4E15F9A3A05043BB79718A383F6CB1D8A6E65AF414E73790F67F4C86087632A24478A945A80D56AED982454BD7E1E3394BF0EE07B3F0FA9BD3F1E4532FE33F4FBF86A79F7D030B17ADC3A2251B4468EC14ACB7792AACDFB84D09C99225EB606E6EA7A6D5686A3CF1BBB24F4A7FFBCB04A3C4D3818E10C1B408FEB11C8DB7B737366DDA046B6B6B787979A9CEAD4387741D8AFAD0D73EA76A412E26A8BDF45B28660C5388CF46A319B66CDD83FD6A6831A355C5E2ECAB790FE3C5D90D0C1333444C0D1B713EAD1D6123C2E0EE13A4AA2EBA7AF9A9F9475810DB2F380C896999D2FAEE07472EEE2AAB54E3E9D937C322101CE3CEE1BB5972BCAF08214BF42C59B15A09053510975E7E81B0777653897E1412FA7EAC2ECF7AC01C3F9E21BE40AC38D53636CEA20596AB2275EFBE3B1D1F7CF031A64F9F87D9B31761C68C858AF9972FDF8879F396CB712BF1D147F3147DE9D2F5E22B9861B3B93DDCDCFC909C9CAD462FEABF070D6CF8CE349CD618D8D8123C977C75BAFE8DCF53BB9C44E083EA3FACFEBAE683F08F26565C5C1CD6AD5B07333333252CBB76ED3A81E9B473B9E48B6036B0B68FD73ADD4BF92CA07BD6E3F7C02891B6CD259DBF9EAEEE4FC500C6D0C5026DB2645A0B0729B1A95159C9620572F4DEA8BC5AA692B0042C8BC2514B58DA3AC2629B831A47C1014A34AF38532F85823E158322CE6EDE2ABD8753583320C1123FA4AD5E6786E933E6E0DDF73EC26BAFBF83975F7913ABD76CC46639CF5C04CB5EAEC14A9B616171AA785D4A4A8E4A5DE1D8741690E8E9D18DBDE13D1B82DF4EBFE133C4A95294262B8C120D418927A35048F2F3F3E1EA2A4E9BB9B932AF6A6B6B8DBE3086764FF722BF28604895A9E22CC867E8CB9C0E8CCD73663143FAB980D3C4A9B9D86967D117118161710A063B6CEC5CB1C1CC0A66568EAAAA3CC1DE69178F40D9E72E82E32602238E7F62065233F25434CEDDCB5FF639AB814C2FBEF23A9E7AE6592C5DB64A692AFE5E0F7B666539CCA432BDFBD0406135A411CC31EBE8EC46F3A116D93C79FF57014689A7025B91EAEA6A69718CBF3063DA447FFB74268EAE753FFF56FB4CA050186BED48638C5DCBAC25B86D789C3130FCC8BC300E4C32DC7736E8EDEE53C97F748A2D2C6DB1D5D21EABD699C3D6D14B5592679A38E72859BA66AB9A72C1DCD24545AAE890D3FFF00F8A5642B568E92AFCFBE9E730EF9345884B4A944B9FF83B1CA46648A339C3BA67F4CD587042A37179BA711A1CA83534C834986E0C0EF46078A80F2C6AC8228786C77E196094680CB41FE957E83BF08630E67750380CE99A407C1EA6D7A9AABB9F0AE7A265CE062CC7CAA556D6B5B478175C9C5CB14C987CF1929558B162039C5CFD54DA86AB6708566FB1C3829566D8B2CD1D0161496AEAEA948C42E4E496C3C72F1A2B579BE3838FE6E2BDA91FABBE068ECDE775090EB5E5927E987E23F4691B24ADA36E4C1A952FAB409C0A46892618C7B9DADD2CC134C2517D7A33EFB2F00253E3E362A3B171C31A2CFB6429D6AD598F6D360E0860875D6084729E57ADB3C492D55BB07CF3367887C62325B7140111C9C8D95129E6570866CD59A142B92FBF3A1591D1E9E81D5021E489DFEE91D6BE7BE0C444400ABDFE33D0ECD4D62F64A3F5651422A34413CE0EFA3ECA2885424C30AED3F7E010662EB5FD445747372243C310E217005B0B2B783A38C3D7DB0FA1A1E1E2F7B9ABD41EF64473EC0DA7A456BDFE49B9C82ED88D50118620D1280F3CF85F251C6BD658203D7DE70933FC12679A0386B3A169EB5A2D350A092D85B389FE7D55619468C2A9A1FC976302A181D3F0E96F1BA2A27A0F5252D3E1E2E2A63A3437AC3383F5561BB8D8BBC2D9C95D81537C6FD8B8154ECE1EE29407AADE6E869799F73463DE72DCF18F87F1E47F5F5221DFFA8693FBA59859ACADD3F9D62F4ACDC164DABA06E68619D24C38358C124D383718AB65CCDCB2FAC606A46667C2CA9EA91A6658B6729DEAD3E0C84157673FD8DB7A61D34673988BD0383B79C1D73714313129B013C77DCD7A0BF80644A2BEA94D8D376FED1A004B8FEA876B5B98AEBFFF203895437149B90A2DA7A567233A4697E3C5DAC7793B4AD4340B2CCEC07951B473E9A7683EA7E67B98706A18259A707660B91D431A8708EF3FD880988444586EB3C5EACD1B61E5E408171F3FD573CFB471E63EADDF682F4B2FD57F91949483B4B47C6467172120200AD6D62EAA13B0AEEEB0EA6BE178140E07A040AC5DB7092C3CCD94FBCAAA3D38D8704855A7E7DC223B0B77A9AA255CAA394AB2F2E0EA11A8D2E85F7CF92D3CF6F87F544E18ABE76B7F34B73E8B68E3648751A209E70ED69CAAA9AB47545C22BCFD83546A09CB776EB2B682A3A7B72ACAE6E8E1A7A69F76F70E8787770C12920BC53F89476060346C6DDD55A2E0BBEFCEC4F4E90BF0E18773456822909E960D2F2F1F141C9B2A222C225CF567704A8BAE9E6E350F636D5D2338D90E41ED51BCAB522D396582BDA32F1E7BF279DC70D35FF18B5F5C275FFC323CFBDC0B2AC4FF79441D272B8C124D3835388E83A30DB9E4364727B25A2173B62820CC80B5DAE6A87AC6D983EE26CEFA162BD12C1BB66283F93655958409924C940C084B115F244CB5F81F4E9F8FD75F7F1F1F7D34074B97ACC1AC8FE7E3C17F3D860FDE9B8A00BF40341E6C9A488E1C1C1E42776F0F0E341C54655D393E86A32629305C726C090B82B318C3BBEFCFC12FAEBE11D75D770B7E7DEDF5F8F615DFC355FFF7336CD972BCAC284D309366393D8C124D383358486240909E23E68D97AF1A40C4541327776F388BE6608ED7DA4D16D8B4C506F64E9E888A4F455A76814AC9670FFB8A355B307DD622CC9EB704D366CEC7AB6FBC8F7F3DF818FEFDD4B3F8F7934F8B903C8ABFFCF96F880C89C29121D61B132119879A42A1B3B3534D52C4B2B35A9956ADBA0B87297328318B7DFB0404E3DEFB9EC48FFFEFD7B8E596DB95E9F5E2FF5EC695DFFB0EFE71F71DD85FA72B0067C299619468C2716797B590F57BDCA94D9808191219A3CBC1B27756534E33E9512728BE58BFD90A56762EF0F40B5135A7327376C2C73F0C665BB7E1E9175E5502945FB44B5D734005A74453C9B2BB67504DE84353EBEDB7DF859787B76E300A334EC4871F3A3688676C6C5C15B3A666A16B4F412128281C7BCFB1F6F46BE62F5A0A4E35FE97DBEFC54F7F760DFE76C73FF0E453FFC6EF6FBA01D7FDF61AC4C547F272273DBB0927C328F1AB82BEC12E957AD23FD8778230900159E397B9572A0F4BFE98E651555D2B7E4281CA0E5EB2722DE62D5A01736B5B6572713C8899B9951A4518199B80D4CC1C658E996FB5C69CD90B307FDE22151A6E6FEF14013C1EBA35C4B1924E5A96832A66C73F0A2E6F85F598B9EC1D64F13C5DA924CA12EB8AD1E1E736C1F5691FCFC237BEF33DDC74EB9F71FD4DB7E0C97FFF072FBFFA0A5E7AE925DC73F75D707672902375BF6BF2574E0FA3C42F2BC87CAA78DC40B7B4C67DD22A1F670E6D1E76D6CDA580106448B6DE2CE61C1111A5460F4E9DFEB14A3C64A66E4068A4128ED5EB37A9254D9DF8E43455CE88E9EF2BD76EC0471FCE84ADF82C9C1D8BD727344121F33371D45847DFF6EDDB515E5E4EBAFAA3E34E11D104E5B8808810C9BD6A1A854BD26992718A836F5EF97DFCF1AF7FC3EF6FFE239E7BFE454C9F3903B366CDC2238F3C041F6F4F39F2D8F39B04E5B4304AFCB2E24CCEAA96FACECA8F9C8AADA0A818C121617075F350C398CD2D6CD4787A33D11233454B2C59BE069E1C63929E8DCCAC5C359684D56566CF598079F317C9B91172B5E3D75799C2B2E47D68C2714C739C701F25252598366D9A1A04478DC2B13F9DDD9C668105FB38A1CE802AC7CA489B36BD04E79A647105566EA1BFC27247CFFDEF155CF1FD1F2B41B9EE869BF0F433CF61DAF4994AA33CFDF4D3C8C9CE942B9EF8DB26188751E257059CA783E54EF5699CF989258342C507D9B0D91C9BB65A2A6DB1C592C36E5DB170C97255E82E292D531584484A4E57C2C2D2AF3366CEC1FA0D9B51545C76C2359B5B0EAB7911F569A78226401C315A5A5AAAB299E9BCB7B6B7A992AAAD6D1DAA381E2BB3B0781EABB470D62F963562092516A3D8BBEFA09A49F7A557DFC275BFBF1977DE7D3FFE74DB1D22282FE099679FC7F5D75F8F0F3EF8002D4DBAAA37A74B74354107A3C42F1BF435094D2C6A0E6D5B435D53139233B261EFE28ECD22148C626DB5B68383AB8732A35C3D7DB0D56A9BF247E87FA4C8B11BB758E0A5975FC5FB1F7CA8CA9D761D4B53D740C6666A4977CF898CC82927F4B7397647CBB76A6E3E5EB289E8EEEE44717121F20AF2B1676F2DF6D735A8394158708F42C14218140AAEE7EF2C9DE83FA169F8FA5BEFE3A63FFE15BFFFC39FF0B73BEF151FE5695C7FC38DF8FEF77F88AD5BB74EFC8EFEFB31A6E14CF80A6A149A2CDA3AB507E7E548CDDA0E330B6BCC98335F39E91BB658C2C6C14545B2CCC4DC72F7095061DF70F13D687AAD5CBB0EFF7BF535D1385BD4D4D41C52AC5D93D02626D2A7D12F619D81E3DBECB7D009AC21735270EAEAEA26686565A5C8CCCE52F3D03398C09EF7ACED85C8C92B5660548D83B738882B36215D15C070F30C00A78FBEEFA12770F31F6FC3ED7FBF077FFECBDFF0F35FFC0AEFBEFB3EAAAAF64C5CDF8433C328F1CB84530DA6625DDF7C319DD69B5B62C99A7598B774B9AC5B6193680D054B3B387B05204E4C2CDFD008B8F8F863F18AD578FFA319AA96B0FEB538BB6E9FF80DFA347D70BFFEF6E90684B175D7F76108D632AB3B50AF2AB0308F2B3C3C1E11D1494848CE5163E339469EDBCC38F60F8A54A168D64C6338FAC9A75FC4DFFFF1006EB8E98FF8C955BFC0FD0F3C8CF4749D6FC201631D1D1DA6CEC6B38051E264053FB661EB7CAC22FDC476474FAF8A4CAD58BB41CD12BB60F94AACDD628ECD36764A40281061B1C9088F4B81674018A68AD33E63FE27B017BF84B309734E45FDEB7D96A023CFFA569C5827253D1FEE5EC1AA96D6A62DB6B075F0544384994CC98210ABD66EC5C2C56B306BFE127CB264352C6D1C10179FA2CA21195ED78433C328F18B0C0E593D53358ED1E131AD736E825655BD57552D59BA6A1D662F588C8F662FC4B2B566AAB39053498446B1A85B82AA90B276D316CC5BB4149B2C2CD4B40B749A790D63E9EA9F0758938CD34AB3CAE6BEDA83A8AF6B42C3C1436A2EF696E676054E0CA49B9FBD551D6B780D13CE0D468993051CD3AD098D9AE047FC02C3BA5C2C0ACEF0EEBAF51BD5FC2AABD69BE19365ABC461DFA64A806EDF51AC4A086D12B3EBDD0FA763E5BA8DF00D0E46F5FE13E7D220E89CEB6F7FD92A8D98706A18254E4668335DB10F8493F6E4ED2C84939B3BE62FF804AFBFF11666CF99070746B4C469CFDD5902569B8F4FC9C007D366E2E5D7DF52B5B29823A57F4D820E7F1B4B161DEB03F9BCC18640EB8FD1071B0A361CA7EAF5E739868D8809670FA3C42F12F443A95CE77CE3EC93D06FDDFBC4372138836E466E2ECC2C2DF1F6D4A978FD5D4EBE6F86C8A818556591FD202C7ECD9EF4A79E791E6FBFFFA14A3361871DAF4361632E17A7D5D6AEFD45039FDB50B39970F161943899D0DED38F5D957B10101AA142BC349F662F58840D5B2CE0E2E9034FDF002520D426B6760E2A7BD6DBC74FF56E1B5ECB18B4C98B74EB93CFD6E77372BE76FDA1C1269C3B8C12BF686034CB3017A9A9A905C5C5A54A402C6D1DF0F1BC85F870E66C71D6D7AAFE0E761E32C3779D38E6AC904E4149CFC83AE11AC4E998BFB5FDF044B224FB3CB42927BE28389599752A9842C09F1E46895F64ECDD5B8BECECEDB0B5B5C702F13F3E9C314B5546E4DC899C2E810989AC10BF78F92A9566CE6915B4B11ACC08D6C2C75A3F8521F318D6FD1A183ADEDB7EA16B7C5D4C5088F40589E3E24DA92A9F1E46895F34509B949595A9A99F291C8B172F55733CDAD8D8AAE912424223D55870960FFD64D132B8BA79A9E2D786D7399D437E3A21D0CAFA98F0D58551E2F9E04CEADD30B5833DDAECB9EEECD415F0362CFB19139D804D1BB762E58AB558BE6C35366FDEAACAFE448983CE791F972D5BA1E6804C4C4C06CD31FD73092D55E474A1DCF1A3A67E06134E0FA3C4F38136BE421318F673E8F77570A9C1589893282DA95093F94CFBE863AC5AB94E5551E49CF3161656888D8D5766172729B2B2B252C271AAF49173B5E14D30E154304A3C1F9C49A39C4A38DADB7A50B87317E6CD5D04B34D167071F684B75700FC7C8364DD43573C6EA39932B738A8493B8F7D07864988A7FA0D134CF8B4304A3C1F18E65AE947ABA8693810499FB69F33E5864461C3FA2D58307F09428223E1CB89776C1C158DC5AB291C8585C567EC30E36F5FE8C8CE515CBCE27047C62FDEB54DB8B0304A3C1F9051094659F42B101E9B2B45FD719E95CCCC4C31A52C307FDE621186D5B0B773415464BC985AEBB17AD506383AB8213FAF48F35DD49FFE7C2B8602A90FEEA3309EEE18E26C7C932347FB405C283F46FF3A26DF68F2C028F17C60D8A26B7E024DA3868626AC58B10A6BD7AE8799D916E573708E794E32CA71E52CBEC049313BDA7B4E988C94851D0C8300041DF58E8E2E857331B7C8A0C4C5D416267CB96094783ED01F4741D0D166C720235414102EDDDC3C606FEF084B4B6B356B17B5CBB118FF495AE05493D9B0488461248BBF75360E3C4D9E71F45F3041E91F383EE5DEF96032F5D37CD570C206B5415757979A00D4D8B4729A596548270C0B3D730A3B4E7EBA7CF94A2C59B24C85753D3DBD55FF878787174A4BCB545858FF9CDEDE0BC370A7C3E8D80046C774E6D4519CDC014766E51CEEA37A15EBC7B83DD2AF6695D26696E2643ADAFED6D6E313BB6A93FE73A90DD01A61885A6FB01667AB22B8AEBD0336101D1D6D62327EB65A6E589ECBB09F88EF80F7A3BBA78E931AAFAF228C1239FD9CA5A5255E7CF1453CFBECB36AAE784E6CCA61AFC65AEC415D1537B5BE758B15EC6C9DC0E58AE56B94CFE1EEE683F8B86464A4E7A80C57EDD8CF0A837ABDEB86E8E96E9F60FAE1416908868E606CE4A8AA5534D0772C5357D6556EA62C750D85AED6D640FF89CFA266D192630E35751E3B64140383AA5F0847C68021BD4AF4FAEF81410AF61F31D0419039B57DFA3036CEC610A3E3276AF4738126D86C4844B71F03BFEDD809FEE65711132B5A0B62985345646565E1FDF7DFC7D557FF0ADFF8C6B770EDB5D7E1B9E75E509D805E9E7EE278BB62DDDA4D58B860898A52B1CFC3DDCD1B29C9196054AB5F188ED7D1F73B3E2BE8B7D067326D468784CBE5168744F08F1ED155663CCA89DEF9270BAED2CCEAEB1741A0F176ECB9F441611BE573F252AAA51E457B87D238EAFCEEAE9335B506DEEBF83885697C8231FB3911EB312DA50FDE1B7F6B62FB585DB24F03CD84D5966C588E8C0FA1BBA71DBD7D1DF22823E2D3E90234DCFF55845122C197C232398674B6843B7614AA4EBF79F316E08927FE2D5AE779BCFEFA9B9833671E76EFAE524E7B6BEBC913D568DA4813C6CF4AA59301B4D6D204133E0D8C128DC198A6D1A009C0317BFB24F38C743ADA5A395193CD6BC264C34904C3A8D5999C4B6A1EFDAC540AC1A91C7ED2793CB5D2E7E1AB9860C2A7C5C48AC6DCFA9A439FE169DFB3181BCDB1536917434D713A2D648209930927110C99BDB7AF53B4C0C9CE24414DD2D3A31B674E3F407F2C87E6380F0D738E40DDF986FD1E269830596094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269870228C124D30C1047D60CAFF03149AB82DD1225D5F0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A350-900'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000CA0000008F0806000000BBF04477000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF000052B749444154785EED5D077C56E5F5A66AEDB076D77F97B6D656AB55BBB456AB56AD5B6BEBAE7B2BCA908DECBD026492BDF7DE7B4F32208B2424810412C882EC3D09CFFF3CEFC70D1F1F1F4B408D7EF9FD9EDC7BCF1DDF1DE7BC67BCE73DEF1400269860C2196094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269C0D86868630383C24ABBAEDE1D1110C8D0CAB6D2E7BFA7A27F64D7618259A60C2A9303A7A4C108606D452AD8F8DA2A5BB03833822388AC3BD3D13FBF4313C3A80B123C7056B32C128D104134E85BEBE1E0C0EF6A3A7A74B3631A5777000BB765722283A0A617109A018515848E77E7D0C8DF463746CF024FA648051A209269C0AD428478F1EC1F0B08EE1FB8646D1DCDA013B374FBCF6EE4768ED3D2E20BBF7544FACF70FF6811A45DB9E6C304A34C1845361644C0405E3E052A30D8E0061B1A958B6D61C0B966D4047FFA8DAD7A5E7A3F4F68B261AEE9BD89E6C304A34C184536160A85F1CF64170A94F4FCB29455CCA0EFCE1CFFFC4662BD713F61183C303729EC9F432E12B02CD99D740479ECBF4EDBB5055DB85F7A7ADC06B6FCF878DAD8FA26BE81BE8152D34398584304A34C104438C8C887D6584DE33D88DA1B1A3C8CAAF40724625EA1B81BBEE7D1177DEF51F242517C921BAE38647194A36995E267C45A039F11AFA47747E48C5DE662C5ABE0D193907F0F2EB4B70E59537E0D63F3E88A8E8D889BE96FE41E361E3C900A344134C38571C38D40B735B7F24A6EF86B3672296ACB4C3FC85E67074F44463D36139C4F879930546892698702AD047A156615F0A41938AF45EB1CC7276D6607B611D4AAB5A915F7400A919E53033B3466B9BAECF65E488293C6CC2571CED7D23C829AC82775012FCC3D2101E9B8DD8C4ED58BBCE0C03833A87BF6FA05B2D27238C124D30E15C30383A82C33DFDC82828835F5822B66C73878D9317A213D2B0798B951CA23BCE2428267CA540734B03B7074686517FA80DF11979088C4A86476004DCFC02515C5E09730B1B750CA1DF4939D96094688209670B8DF9F34ACAE0EA170A737B3784C625C3C1C30B3B4A4B61B679AB985E9357403418259A60C2B9627B61197CC3E261E3E28DA0E80458393A8B9F120D0B2B4BD13CC6FB6026138C124D30E15C505A5E8DD8941C044426C1D12B184EDE01F00A0E427064385CDC4E4E67998C304A34C18433A15F2F8DBEB8BC0AE17169221C5170F609C636676F8446C5C12F300C21C11113C74D6618259A60C299A0995387DABA9157588A90E864B8F88628D8B9FA2A41F1F40944BCF82BDA3993194689269870B6A8DA5B87D4AC5C044725619BAB8F121467AF2084C724C0D9CD1B05F9C7F3BD26338C124D30E16CD0DBDF879DC5E5884D4A435064A272E41D3C03E0E61B8AF8940C58DA38A0B6A65E0E357EFE648251A209269C0D0E363620233B1FD10929F00C8810273E08B66EBE70F4084056DE4E2C5BB90E1DED933711521F468926987036D85B5B83B8C43444C625C1C1DD1F9E41914AABD8BBF921776709A6CD9C8BA1C13139D4F8F9930946892698702630EA555452AC042524325609877B40382C1CDC957649CBCE53826278DE648551A209269C090D4D8D484C4E426AC676F8068529BFC4D12B1066364E2A541C93988A790B97CAA1C7CF311C1D3999609478B161385AAEA7E7B81DDBDD7D62E2DCE0E0205A5A5A4EA069686E6EC6C080F1D4ED8E8E0EE8FF0ED759B08DD0681A8687CFFE03F27EB4F5D6D6D68975A2A4A404BDBD9FAEE81BAFAB7F6D0D7C375D5D5D38D53D1E3E7C587B26B53CD5FBB8D0A8ACDA8394D474E5B47BF9072B41610ACBB2F55B91909E079FC050ACD9B8450E3D7ECEA946494E0618257ED6E8ECEC3C8181F9B1C91CDAB6C6247CD15CEFEF3FB1B00161C824C698EE5C702A8122E31AEED3B6F91C1AED4CE0BDF27863CCC3DFD1FF0DFD63B8CF983090CE67E679E7FBECA782761FED9D1DC8DF5180D47431BBC263E0E11B08579F10D5D9B8CEDC56F5D253CBB87AF8AAE3BF0C304AFC2CC08FA9AF490C19861F9E4B3293B6AE31005B6DFD733F0D0C994F5B3704B519B5933ECDF0F8BEBE13C7821B13B23381D730BC0EC16B9DCDF5F485C75843722151B36F2FF20A72919296AC3A15354161D48B3E4A5462269C3D7C109F942E871BBFC6648351E26705C356D3584BA8CF3C86C2742ADAD9E04CE79DEEB7B4FBD4BF7F4D78CEF57E8C09C7E9C0DFD417547DCDFB59A1A2B21C3B0A0B1013170D17771F25284E9E812A2C4CC4A56EC7862D96282ADD2D871BBFC6648351E285843133C118F485E4742DBC31E6D4402625E351E3F038FD633F2DF419DF981633149E4F0B3ECB99EE97BF652888676A482E340E361E40C9AE62646FCF42786418DCBDFCE1E51B0407175FD8BAF8C0DD2F0C99DB8BB168E92A34B6B4CB29C6AF33D96094782161C8CCDCD63EA8FEBE537D6432BDBEB0E93BCB867E0C19CD18339D0FF4FD086342AFD10C99DCF0B93F0D4EF71CFC3D43E1BC100DC39940BF243D3343212A261A01816108088E80A3AB1F2CEDDDE1131C8D8C9C22CC99BF18FD03BA21C017E25D7CDE304AFC22E3CBF0D23F0B5C0CA1E9EF1B46744C021293D290929A8990D048F88836090A8D828B4720B66E7351A92C310999983D6F919CA23BCF24289F234EF7F23F8B96F5AB82C181E33DEBF97945C8D9BE03D939E29FC426C1C9D903F60EAEF00D085582B2C5D2115171E9080A8BC7FC4F964D9CF7658051E285C2E8F8F9D9ED267C71D0DD3388ACAC1DC8DF598194B41D080C8E878757B8F828C10A9EE2CC5BDB38202D3D076EAE5ED8B8E1C43E94C90EA3C473C564AE296BC29931347C0475F54DC8CCCAC3F6FC5D888C4915210983B76F14FC83A2E1E8E20D67676F3838BA21392513AE6E5E7077F396538D5F6F32C228F15C303C3E84231847EFE0087AFA756ABAA77F04FDC363E81938399ECF6AE693B5A2F957155DDDFD282C2A9B109480E0186CB3F3827F601C82C5CCB2757087ABABAFF257E2E25354E595B4D42C39D5F8F526238C124F07DAFF8CF430E2C2F5917160EC28443074CBA2D23A505C8E08868F8C81A9D83C9ED5054726F144325F65B41C6A574242FF2433A7083EFE11B0B2715782C2751B3B57B87AF82338241241C111D8B2D50AD555B572AAF1EB4D4618259E0BEC1C7CF1AF875FC4AD7F7D04FF7CE8357CEB7BBF434C523E44A9605404A7B3AB4F04E4889A0493F3FE519B1C111C3D2A9A6574F21644FBAA6078640C55D5B5484DCBC6F6DC9D088F4A86976F185CDC82E0E91D210212083B470F7878072122320EA161D1D8BCC5123DDD5FAE46D128F174189117A7BF1D12968CDBFFFE845CE9E7F8C36DCFCBF2D7B8F2C77FC292E556E815CB8B9AA57760146DEDDDC7FA23C671749C112BC19173EB9536E1B3477B4717B273F295934E38B9FA2941090A4980934BA0985D9ECAF4F2F60E466C5C321293D231F5C31972AAF1EB4D5618259E0D8687759D49C4CAF5D6B8ECBB37E0BEC76762E6021F5C76C51D72E5DFE1D187A7617F7D3B46C53C3B2ADA655CA4E6A8AC8C8E486BA30A36EB340BA15DCB842F16AAAAF7AA7E93F48CED888A4E508241073E3834118ECE01D862E1A04CAF808008E59FB00372F69C0572AAF1EB4D5618259E0D34CD327254FC1459F10ECBC294CB6EC613CF9BE1DE7F2DC1AFAEF91F2E99723B7E7EF5CD88884AC7B808CB08656B5C24E6E8288607BAD1DDD63421282661F9E261686844B449AE12948CCC5CF8B3BFC43D00A11189F0F18B12F32B1896362E42F3437C7C3A929233C43FB1167F26574ED75DA3BF5F7C53032B6432C228F16CC12CD5BE9136F48E76605F73133E98B106975E7E27EEBC7B155E7B2304D7FC66BA08CBAD58B9C213BBCA1A91B7639732C5180060A4EC0846D5FFA3E2FEF7F4B66370E8B34FF0FBAA63ECD860AAD1615DBA8C7EDACCFEFDF52A7A952542426DA1225B3E614A48BC7C22E0E0E48FAD96F670F70A548242D36BD1E2E5282ADC35718D2F0B8C124F07FD17A92260633DC2E6C3B21CC29008C015DFBD03575CF9381E7BD2068F3EBE4D7EE156BCF1D60624A496C32F240959B96538DC317C2C523684EE9E3EF4E8CD1E3B7644A75946862F6EAAB809C6A12559D289CFCADEAE84841AC5C5D50B2E2E3EF0F00882B76FA482ADBD8F12141FFF302524C48C9973D0D078485D831A89CB2F038C12CF05DDBD1DE81DEE044D302AD8A4B42A7CEF87FFC4A55F7F00FF7BC50D7FBBF763CC98E786B4BC4684C596E0C9673E82B57D280EB40CA9C9FB790EE72AE7B5F4317644AE3789878E4E36680D204D252E0F363409E327202FBF10F10929B0B4B283AF6F289CDDFCE1EC1A0877CF3058D978C0DAD60541A131724CAAD23AD367CC56E713DDDD9F6EB4E717114689E70AA6AAF48F760BD38F614834C5C6AD4172E53FE0B7D7BF813B1F5A888DB699A86C0076EE1EC18FAF7900F73F3603D68EB1D87B700087BBC6D02772C2621DBD83A2A146C5A6551D9272351116FDDF31E1B343496985F81CE9D89EBB03E111B14A50FC8322958F424171F30A83858D3BEC9D3C95A044C624C2CB3B000B162E91D375D7E8ECFCF284FF8D12CF05A3C3C71DB5CE9E6671ECC754FFC9FB1F6EC494AFDD8A2957FC032FBC63099FC87D482F1CC133AF5BE2DEC716E2D5A9E688CBA943594DBBF83703E813E765809D97E2B1701E73535ACCE707CEB9C89070525AA64A49618F3B05C2C33B44F59F38BB07C3C52344CC2E7795BE121A118FA8D82435BB96AD9D935C42779D81812F4F43679478AE181AD031F5510CA2B5BB597C9571ECABEFC3BF1E7E4F7EE1163CFEFC6A7C38CF0B6F4C73C7736F3AE18E479660FEFA48241575C037B20061894568974BF48866191281A1A33F9967909DECD8B1B304B18929C8CEDB016FBF6038897FE21718A1CC2E27B7409DA0B887C1D6C11F0ECE5E888E4B55A6D7BCF98B919BB7532EA1BBCEE097605E140D4689E78323E8474945B18A6E55EFEDC23D0F4CC7B4392E7873AA3D7E78F5B39872F9BF30E5BB0FE395396ED8E29B837F3CF62EFEF9C43BB0F78A41F9BE6674CACB1D3D3AAE22619C1C733297B8998CE8EE1940E6F67CC42424AB2A90D6B64EAAE79D66979D93B7985CA170F70E174D120C2B7B5FB87906284161FFC9B4E9B3D1DE71BC81A3BFA3DFDF36996194783E3872B40FC363BDC2E610F3097070CAC46D77BC8947FFB30CFFF99F15BEF193E7F0F59F3E83C7DEDA8A755E1998BEC85184E75A4CF9CEAF60B6CD0DBBF7D5A3B8A24C74CAA808DB30BABB59A145972BC6E5E946FD1983FEB895733DF7AB04461FB9A4B9959E9D8B84E40C35C497DAC4D9CD57E57259D9BAC1CB2F521085F55B9C306BC15AC426A42331255B650E4FFD70A6BAC6F0C8F819FB4E6896698183C900A3C44F8371D561D88F312528FD18181A14AD00F40D1FC13BEF2FC2E5DFFE13AEFCE953B8F2BA5731D73A13A1059D98B9DE0B8FBDBC00BFB8E911FCE4BA7BF1EECC4D38DC09EC28DC83E4A40CD53979F4C838DA0EB762B0FFE4DCA1D1B10171F8752F7B68F8C47418465CFAFA06505DB50F8D0D874E28C84098464ACA3B181DC1E0E871866EEDEA434AE676E41494202C36555556B176F1838B4F38ECDD8360E7122002E2001B7B6FD5D9B8C5DC59042A0B01C151D8BAD516AB566F98B8962128186732C5D890191B6E4D81223ECF70B351E2F9A07FA85D69021A4FFD0374ED81D2F283A255FE87AF7DE74EBCB32818091540C141C03EB402EFCC77C67DFF9D87275E5E8298F47D088D2946784C3EBA448397551C407B5B0F46478EA2A444D789C54818132B0D05A3B7EFC49A5A559535282E2A47487024A2A3E2274A01513369C77C15C140091354B5EDBEA1E3EBBBF7EE575338A464E6C13F2C46555471F209C336177F057BD7406CD8EAA87C146FFF6825286999F908098FC3FA0D5BE0E6EEA3AEC5F12BDA353F0D8C090BF1799A714689E783EEBE56A551D85A1D3ADC865E69B999EB5554D288E75E5B8E27DFD880875EDBAC04E689572C70DF336BF1F08BEBB0DE3603FBDA80FCB2016CB08CC4953FFA2B162C71469BF0FF11514DECA0AC3F58A7841062960D0EEA3A24474675B1FAA1E1E331FBBEDE61C4C7A5212A22190EF6AEB0B1B6477BFB97A722C8B942DFCF63CD606A7B6D5BD328AD5DBDC8D85EA06A06874527C2C95384C3D91B8EDEA170F60E838DB31F6C1C7DE1E411A242C356B69EAAC331396DBB8A7ACD9ABD0009896913D7D54C2F6A016366D8E94CB3B30D027C96826394783EA0034E47FCA8E894B1F123E811BF8213F21F9146A6B16D1C3FFFC323F8C10DFFC5A53F7E1C977DEFDF98F2ED87F1C207EE88D93E8290D436D8FB96E15B57FD0B5FBBF21E7CFBAA47317F892B76D70CA07C4F93CEEF39AAD328FABF3976E4782FFEE0C0286AF61E848B932F9C1DFDE0E71B0C17670FA335C34CD0A1A3A71FE5D535484ACF56739D0484C78A9078C2CAC103F69EC1F00C8C819338F19676E2AF7886C2414CB00D9BEDE1EC1AA484843ECC6B6FBE87DA7D622618B9FE99702AA1A1B9C512BB9F47ED324318259E0F7AC4041A18EA55FD209C5A99A92D6CD198EE42F95F6BE589879E5F80EF5DFD14AEFFD30CDC78E742DCFFF456FC6FAA37FEFCC0624CF9E67DF8EB834BF1CD9F3E8B1F5CFB1AA65C7A1BFE74E79B28DED385D6BE51341BD10C23A3C7B48BD8B8070F34637B4E212CB63AC0C1CE1B09F1A9F0386612F03E4C51B493B1FF609368937CF14D8A5429549A5D76AEDEAA4E97B36F18EC3D02E1E61F21C2E38B4D964EB0DCE60E3B69885CC50463448C21E20FA7CF563E291D79EDBA8D8DCD13EBA7C231ADA0FC8FDEDE7E7C513B298D12CF07ADED873128FE03B5CAF0A86813C5C4F232C68755E48A6C9A54B01FCFBDB91EAB362561AD4D21EEFB8F19AEFDF30CFCFEAEC5F8CD6D0B30E5FBCFE007D7BF87ABFF321BB7DCBD100F3EB306AF7EB805FEE139C8CC2BC7810387D1D33980D181136DE18E8E2E4446C42177FB4EF87807639BB5AB5AB730B79938EEABEEA310CCE3D2D63B7A7A5150548AC8B844EC2CAD8093BB38EA6276593BBAABC2DB0E5EC1B074F4829D3BAB408A43EFEA8F2D96CEB075F44158448A1A8BC25CAF37DF7A1F63F239282CF451AAAAF62036361E7BF6D42801D8B7AF4ED1F2F3772025250D8989C9484848426242AA7CB3587879FAA9A214B6DB1CE1EB1388A0C0301C3E74BC942D833314A2CFCB4F314A3C1FB08073DF40AF388CFDE8E9D73D284734F67532516E5434CC18BAA5D17963DA1AFCFAC6C7B178632C5EFBC81D773DBA017F7F782B7EF4BB19B8E3094B3CFAA61B1E79CB096FCC8DC2DF1F5D83BF3D38178F3FB71065955D6838D88DFD358DE86D13CD35AC6BC186878EA0B4A402FE7E214A8B0405862BFF242E3619F676CE4AA3F138138E4331744D2D3272F210159F84F49C7C38B87AC2DE451856C0AA8F76A24D1C3C8360ED2CDAC52B44B44D02365B38C1DACE13E99945088B4C50F95EB7FEF136F8FA05AB0EC7B2F22A787BFB62F9F295A8AB3BA098FBB0F8AB4D4D2DA8AEDE8BCACA6A1417972AA1292FAB4266C67695A54C2C98BF18B7DCFC677CFF7B3FC69D7FBF0769691972ABBAFB6543A8AD7FD6304ABC10A0AFA2AD8F8FCBBA607CB40F9D7D5D20CBD6B78FE2E63BC447B9E4463CF4F42ACC589280FB9EB2C71BB353F1F19A1DB8FA8E7998B63E15B73CB00ECFBEE78B39AB1270FF630BE58E7F8DE79F9D8A2323C0819A3A69918EBF48FA237BF7EC87D92673AC5EB51E3B7716C1CAD24EB55ADC3F32A21316F6C770F9550319B6ADFD7874B07ACF3EE4E4176067491932730B10141EAD04C53B200C7EA1D16A722017BF70780446C1454C3027F1571CDC036166EE089F806864E588268A49C6367B37DC73EFBF70DBED77E1F26F5C010BCB6DE25BF48A5F7A540944616131CACB778B25D0A09664F8AEAE1EECDA558EBCDC9D4A73A424672821B9EA273FC715DFFE1EEEBDE701FCF00757E1EAAB7F85D6569DB9BD77EFF171F8D452DAFA6701A3C48B8DBD35FB30383A2E1A670457FFEC6EB98B9FE377B7BC8E079FB6178DF231169B17E1A3A561F8EBFD2BF1EE6C57CC5D1E8CEF7EFF1D5CFA8D0771FF83222C975C816F5CF15B55688DE3C0EAEA1BE1E4ECAE5AB330F9D8F60E4E080C0A51B0B7774743E361F9594CE9335215E68B0A32B5E6E4D2F7FAB4FD3E5A74D010AD1DBDE08CBEC969D9489296DCC73F0416D6F630B7B1878D838BC23647575839B98B36F1C0161B67D5E148DF84D1AEB08854040725A85CAF25CBD7E1F1C79FC13DF73C84A5CB562327BB40D9602C9ED7D2D2A4E6B7E15C36070E36A262F71EA57158C0BB521A3516AEA8ACAAC1263373FCE4AA9FE3EA6B7E831B6FBA1577FDE39FF8E9CFAEC6D7BF7925964BA3A7DD779F38F8FAB30B3050A4AD5F4C18255E480CF60F61E4581A3D5B743AF81595BBC5E91B5303B8C242E295969872D98DB8F6D657F08B3FBC2EDBB761CAB7EEC153AF2CC3946FDC84295FFF9308C70D78EE7F1B30E5F26FE2F7B7DC87EFFFF0465C32E5777077F797173780DCDC62F8FA86AB426CFC581C8DE7E9E587CD66C60B1D9C6B2FBDB1E31949230313E77ABD0B05DE03C14174EC7F38D57DE8F79D304DA5BCB206E959794849CF45546C0A7CC454A526090A8F856F48143CFC43E1253467F1175C7C83E02A6615E769B4B2F55066574050BC4AB55FB7D102B3E62EC6DB6F7F8499331760A53035C7CDF7F78DE088C839877E3372D5DADE86DEBE010C0E8DE1887CF7F6AE7E1C9006ECD0E10E253CF3172CC60F7E78957CFBCB70CDAFAEC3F77FF013DC79D7BDB8EA67D7E089A79E55F7AE1F283084D61969E8C3B0B1B910396746891703A3222463637C18D1247DDDAA32CB803C003B10B3B2AB71E32D0F8B10FC12532EBD06350720AABD48D6AF848D6B02FAC549FC68A615BE76F9CF41999353E1E75D8C1F5EF14FB91E10179780D2D2326576AD5AB90EAFBEFAAAD0629099950AF32D56AA75E3EF7FD106839D4EB82EA4E0196AA39ADA7A648BC943414948D9AE0A6C6FB6761247DD57C1CAC9534D5ACA197EB7B97BC25C34CB3671F2B7DAB9AAE3E8D4FB05C5AA30B1B99503B658D8A9027841415130DB6C290D943FB232F350B9BB464CAF62E4E4E4C8B760718A4C84864521223216A1E2C0131CECC512AD1C6A1C161EA30AEDE51714ABF1F92C8FC45CB319B3E6ABE368359457548B85D0ACB22EF82CDAC84C62A04FBEAF98184CD23596C9A1D3D29FEEBD1A255E0C0C8B5F70549CF9F1A3BC514A79BF3673168E1C1D475A4611FEF897FB4573FC08F109851092688CEFA0A973084B57D9A25B0EBDF9E667E4C51F82AF6716B66C0CC5D7A6FC5E398A5F9BF27571DCDD457301032255A92959484A4AC1C285F3B175B339C64646E57A63686BD5852BC7463F7DE46B64583EC2401FF83C5C3F693F0592376240FFA2A076DF0135C14F70583462E275F3C3D3ACB276F414BF2456FC91083569A95F789C9AE5D7234C7C94E05004C5C6CBBE3035FD5C684C0A2213B2101597A9B4119322B3B6178A735EAA2AB5B0AC516646AE8A38E6E5E521313111C929696AC464724A06B6E717215784213DAB40651D532078CE2E71EC4BC4246350A0B2AA564CB46AB9EE0E54D7D4CB6F2423454CC415D2109A6DB6507E28AB51C64445A3766F8D3C9AEEF994E048C3383CA8FB06861AE6D3C228F1428237AA459C8E8C0DA99A5EE34C43612516A1757532274CF770875A06E48EBE8B179F7B03FDDD3D08F34FC494AF7D1B5FFFC6AF5567E3DFFFF60A1293F39097DDA8D4FA8C0F3649CB017CF3F21F63E92273B838842333B50203BDA2DA5B87B07CD93AD86DB3D7B52E47194A1E1306979D47A565B940DA6578F4B3110ABE47B6A274845B5A0EA3A1A14939C70CBF565454A2ACAC023B761422393915313171888E8E45585884200CE1E191888C8A11C4A9569BD3C991B9D9AB9E9E5DA8B44A465E097696ED455E7125F24AABB0B3A2462D4B6A442BECDD8BB27D75C897DF2828AD44F1EE7DD85E5086D28A7DA8A8DA8F9DC5BBB1775FA338ED15D85FD7889ADA03282FAB46D9AE2AECDFBF5FDD5BB5DC67FD812659EEC7C1A65634B674A2667F93A001BBABF761FF8166B475F6A1A07097BABF86E63635916A624A267655EC819F08292BC1B0105F52923484899922287E70B477C2366B5B586CB5C4A2858B4568F6A1BFF7446DD23F3084A1F31418A3C48B85B151DAD03DC2A8223023C719B5A5B95DE562B12FB0F960379A1B5A317FF64A9097376FF5C2AAB5F6B8F6BA3F625004EDEE7F3E885FFEEAB778F491E7E1E793A286AB6EDC6829AD5905BCBDA270D9A53F82B9B99372F2991940738C1192E6E64631F57A8E55AB1C3BA78E477D1FE46CC3CCF409183CA099B06F7FBDD8E155282ED9859D85C5625AEC9456344FB5B0DB73F3D53AAB9D6464662321311931D27A4709A3874744212C340AE1D2FAB3AF2146CC917869599312D35494285598889A93FD125962DAE4C83588BCBC021415952873941127AEEF2C2C05C799149754A04A18B3724F3D4ACAF6A0B47CAF62D88A3D220845E5D82982B043189CD855BD1FC5D5E2785755A364CF5E9454EDC5BE83E294CBF72ADE552DCCDD8A436D0C0A1C406B6BAFFC5EB5EA9D2FDD55895AB19F1B1BC40739D40A46ABF6D6D4C97B3888DDE21BD58B50F037F9DBF5F2AD791FE595FBD47675CD4175CDE6C3DDEA1E692252502A76EFC56E1150F6A19595D5A220AF0CE9A9F9888D4944A0F8A3EC7B615FCC270B97AA7E338EF5D79FE39E82C2942A6DFB5C61947831400665E1BBC1BE7611925EB524BDBFFF788E16C3807CC0C6C6763005E9CAEFFD0295D53DA2AEF951FAD5C8C9DBEF784A398354129C40F8D2CBAF445BC788080170F7DDCFE1924B7E8E5F5EFD47CC9CBD586921E69955D5EC477EE14E6CDF912BB423E83FA6CD4E85A1B1A3181891E386C7C4E41B425B572F0EB577813DD845BB2A90932F8C2E60FF034D89B8F864616C3277BC086E92303B0732A508C327AA256984AEECCF76159DCB2F2842C18E6235D496D0B639469DEB646C623799444C10F63770C9ED4A32CD313A358A624401D7F55153232DB5082935CFC18616151DDC272D38994D63548688E950B32044756D1DEA1B5B70B0F930EA1A9AD1D4DA81FD2DCD38D8D6AAD61B0EB5A996BEA9A943316D7373273ABA87D4B50E1DEA465D5D0B5ADBBA71B8B50BBD3DD28A0F1E5161E2B6B60E3080C02459EEEBEA1A52C25077F0B0D22CDD7DA3F27D0F89A66917A1A851DBDBF34B14AD458E2F14E166C0861A6BCF9E066914CBB0A7AA11BB4A6A95C0EE28AA1073325381C301E6CC5F8AFFBDF236A67FBC40CCB90A154410D6513EB1FE773E1718255E2CA8FE140847B342E4D8A99995C5D50ACB6B505DD7852BAEFCADDCE5AFF1A31FDC87BBEE7C4FFC96FBF0E31FDE8FDFFCE641FCDF4FFF86AB7FF9A0985EB7CB31B7E186EB5EC75F6EFD10BFF8E9BF71C9D7FE80DB6F7F091DBD83686EEB42656D2D5A3ADAD025FEC59EBA7D48CDCE466058A41AB1C73116C1E14988884947646C8602EDEF98846C24A665A9FC27E6413169304B98BCA0B80CC5E5D2EA9694AB964E035B4B9A167BC5A6D6B0676F9D5AD21CD1075B5E322DC1753AB104F729663ED8A2502FA64C9D6C1307643F870C348BE94234350AA389C66A6E16263BD8A8C0169C60E71E4D34EEE37A738B30B83079A39C47A626A336B674ABF3D91948B4C879EC67E9ECEA91C6A15BA1BDB717ADD2221D6AEFC0E10EA1B5F72821681121E916866FEDE81766EE518CDCDEDE8F0E319F7AFB86D17AB84B7CC26E652AF2DAAC14CA7DBC87EEEE61250C9D3DA3683AD4A504E440A3FCBE5CE770BB1C2334DE1F0585A659BD3C737DBD084D4B17AAAB0FCA738AD9B6A71975FB5AA501DC8D1DC55548CBDA89B824F9A6A171D8E6E089B51BAD307BFE72FCF92FB761FA8C8FE51BEC13D6D2F1576373D3C4BA16B9A4BF7C3A47DF28F1E282E92D5D387AF4B82621B44212B4C599D458B5FBA0681DA0A2BA11AFBC3E5BEEF41AF157FE82EF7DFFBFB8FC5B4FE297BF791557FCE8015CF6FDFB30E5CABB70C977EEC155BF7A01DFFCC193B8F5F6E9F8EBDD1FE0A1FFCE82B9752806A421A1361A157D3222E6D888ACB78A4AAA696A14616C41D99E0328AD3A8092CA7A145588CD2DAABDB04CCC8E0A314FC44C2916C7B2A4B2568ED9877231477657D729D03EA7D941D06420F6D436287B5D033FF43E6170DAE004D7893A0A82303A5B700D079A0E29B045D7C0569C4BD29B9A85C9A5F56F9356B6ED70275A0F75084376AA0E3B82F40E61E4CE8EDE0970FB045A67B7025BFA9E1ECE7749669606A4AB43B6BBC404EEC1803426EC94E53EAE93999898A88D58E4CC5B346B0886FEC7E4853233A2B747F6CBB2A77748090BA7A6EB9197DFD537A82AED748976EE132D4D4D4F96EC191943A7F813DAFE8ECE5EA579D8B7C2E72238CCE2F0A14E6918E41E3BFBE5F93BE57E84834448F7EF176DD7D489AEDE3111B001E537D9387960ED662BACDD6A8D77A6CFC6AF7EFF473CF0C433B0B073817F4884B20CC867049F4B5B3784A1697EC2CECF069AA09CE84C1BDE5875A5B4AC358774438A6B5AF1EED475F8F1550FE39917EC70CFFD1B71F7836BF09F972DF1D1BC48BC3B3310B316C762F5E64244C48F23231F088E6DC5C235C1B8F5AF8FC9C7A25772142DEDCD625ED4A0524CB1EAFA83A89596A5A6EE10F6EC6B46E55E718C65B9FF608730660F1A0FF5A1B9750007A5656C948FA520EB758DADC2E82DAAB5A37DCDD68E0C4FD04925689E1882137F36CB473E44D344187702D24A13AD9D3D13A0A93781EEBE8975163C2723912115BA07541F91863E61D081FE1130839A4CCC25999A3405716AB50154F4B5081E43301588E37EB824B3136A9F30138F1B1D6506F8918975FEB1256644911126469BC6C45CD5056F645D0EE16FD2E4E1371C167B9902323426C71C3D8A3E69BDDB7A7AE4DB0CAAC163ACC0431389E6113B15B9E47DF239794FBC97DEBE21A5915871B44F9E8F8D0DAF2D3F2B56430FCAA4217BE7A359F8E7238FE3B1679FC7EB533FC29B1FCEC2BC656B6166658F0F67CE81E5367B31438F6B94B38551E2C50505A5E72441314483BC04464EFAFA87D5CBA01F76FFBFE662E9AA6C7CF071125E792F14735666E2E3451998F949BAC2C2153BF0B35FCFC2953F79133FFEE52BF8EE4F9F102DF46369B18EA0BDA7431CD11A71440F8A70889088C9D12ECE364D0782B67243B3B4D01D8362778FA0BD6B58E1B0B4726DDDFD72FE003802908C4E86A7ED4C4667A4869D67448730AB21D862328D9DD05A4EFA3E5CB2B5E55203E91AE823116C81B56DE666B1D38D8CA3189B4B6995C99CFAD0A7A9565FEF382EC7C618CCE0FE611108F63109B3493B6508323B9995A928141226948E8FB3C991EB8CF663FCE830C647067164585AA2232214B28F6173D5672582C0DF18153AAB81323AC8A117238C381E034B530DCA8FF3FBB21822317A644C0DFAA38011BC5FD6AD1EE4B89651115E59F2786A067E47F6EEBB7AF8E2A5D7DFC60BAFBC81FFBCF832EE7BF4093CF7FA9B30DB6687B8F47C1455EE4352661E36996FC36B6FBD8B0D1B4F9E0DEC4C411AA3C48B8971C80B1641D10D1D3E79FFA0BC742656AAF212F2810EB5EA5A8D436D4771ED6FFF8DABAF7B0B3FFFCD34FCE0EA0F30E5F227F09DAB5E13BC8229DFFA2F2EBDE205DC72DB5AFCE4EAA94A50AEFFD37B98F28D9FA95A63ACECD2D5DBA6FB58EC94928BB25D642A0D3B7C59719F8CCD65EFC011B19F87657B4896141C1DD377498BCDB41BB6663C8EEB9C40C990D1B56DEED382021AB3F3F7182CE05231BFAC7340A021784FC4E0B1FD5C67762E831C6460D5EB2DDB64E2B13169AD05A3C24804996B423044484EDCAFD30C049999D761F1742578A251786D6E739D4BD68CD65D9303B0C8ECEC0B13061F12AB00222047454018F21F1D90E345C3A83E2A6176D55FC6DF3DB61CD795CF656646DF70BF328319C51CE5775667F09D7044EC712121F8C7654F6FBFD2380D2D87505E552966563EEA1A4450F6EEC3DC858BF1E4D3CFE1A38FE760D5A62D70F4F441616535F64A639896578A90D8340447252138224E75603EF3EC8B2A52287F137C773AFF84304ABC98D009CA71FF6440984E5B27BA7A3AE5C58CAB97CA8EC8CEEE36610E51BDF201AFBDFE61119417F1C0E39B70E36DF3F0EB9BA7E217BF7B13773CB018F73FB11EBFFFF31C3CF5BC2BEE79D00C77FD6B29FEF1F03CFCF6A6FBD0D42EAD9E5CBC7FA85BAE291F485A25AA7BCE08C6E43C6D4C36CD17CD74610AC6403F5B4E112AE154A65E70C96D32EB045D185E637E0D1A8D20936B8CCEA5B65FA351684F05FA552CFDA4ADB3E1E0BB20D35340344121C8D0045B5F0DFC234DFB633A09A1AD1F3922CC7BEC006D4901E29F2650FCE3EFE9FEE477C787E5FBB0F5E592011936371448B110444B90E5791C41C1E277D4BE2785840DD6F038B582BC330A961CC98C722EF94D68A271C9BE0F9A5F34370FB776A2B1A905EDDD3D2228CDA8ADAF436945391A5BC5E73BD08855EB36E29DA9D3E0E8E6855E79B72DE2CBD489CF5625BE60A238F93EE2E07B074521302C0629E93998F9F15C3CF2C8632A8B59FE2678EF74304ABCD83895D9C517DBD8542F1FF1082A2A2A548E506F7F8F6272BE48678F18693D5CC461CB87674005DCFC8BE1E85B04079F4244A5B622236F1C5B6D76619B53351CDCCAB06A630C9E7F792132F3AA54EB4D21A1E9C0D6834395FB867B75ADEA3186D031D27126E39FD67AB375E59202A2CC1F4D600C98DB101408C5E4722D2E3561511AE218ED74A03DCF258F65589CC2A20986F09A5A6AF7AC0FED4F7F9D7F7C460A8532A18E75C2EA43377AF4F8F6B13C29F5A769070ACBF0086B10B01394E589749A63445E167F8EC38DF9ECBC6F8EC9EF17FF85E03AAFC02B73D92FC248D3F290F8681D62A272BD5D7CB296B64E15BC50010E31C1190D646725C3F3E555D5E23FB6A0E6401DCAF754C97A1B2AAA6BD4581AB6B987BA06B0BBB61131A9B948CD2D417A5E1952B617C3D92B48955BB27374C373CFBF8C77DEFE40A5FCCBDF449ED8E9609478B16128283A07517D90290D0D0770F0603D7273F38589D9EB01A562B9ACAD6F43627229D2B2F6A1A0F820F28BF763BD65B0AADE3275B635365AA4C22FE0006C6C4BE1E9B30701217BE0E9BB0339F907E4230993C835B49692BF279F52289CD8889F4EC779E362DF1C110960F5172EC785A9153F1D634832261956F840773DF947E80B8746530C716C5BC7763A3A5B4D3AB584463F15F809B5F3F99BC48430A82557747F3A2D21D7640B2DE03AEF57274CBAE348A3AFA19E5F3D18F7B3F557CCA29C77FE91461F46778D71D521AC691D1EA3ADF30A3431B9A4A6D4EE5B2C39DDFDCBCF72BD6F583C53417D4B870223897B1B0E49E35684C4B41CC42567AA40093B3E193964DF0CA38835354DD8BB571751A43FB27B4FAD0A5797EFD983C4F454EC2C2E574E7D49C55E648B99151E978184B41D088E4E4364622E82A252A5418DC0FAADF62A5CFCF26BEFE2F737DEAA3A6CE5EF04BE3C1D8C122F360CE742E147D31F07CF0FC1BE000EC44A4849877F7008B6585A60ED862D7070F2436070824A9B38DCD68A7691B9151BDC70D915BFC7EF6E7A0EBFBBFE0DDC77DF523CF8D0123CF7C27AFCF7D9E578E23FD3B1CDC1470506C82FFCF8875B9B84CF447AC41C18ECEDC28898614769230F091330AC221C799402234DFF1131BB7461503123C89C72936458650A8979C89033E7ABD4C06DD2696F9359F405473191080A5BD8EEFE81099A3EB4E309638232F1C76D61587D61E1B63E4D7BDEE382C2A8143324683E89993320AD785B0F0E09F30E0F891F27660B4D4EF6AAEF2AAD54C7676464A0B0B050F93C2A5D6657A5D2B0CC7AA0AFE7E91784F2EA5AC426652050FC80BCE20A44C4A7AB04CB90E8544427E52021BD003B76D52032291B190565884DCB131FA20305A5D5C82AD885F0E81474F68EA9E8636DDD21ECAB3F8C8AAA7AF9DD6AECAE3E805D15FBD4B421ECCBDA595AAEFAC10A4A4A148D2828AA14542B21F1094A80A5832FCCAC3CB1DACC169FACDC8C0F672DC6E34FBD880F3E9A8DDCBC42BE8A09FE3B1B18259E2F74939BEA348421742D161D4BE3FB55C7D9816635D88A231457AD5EAFE6047474F15485A0D79959AAA207AFBD3B1DBFBAFE56BCFADE74ACDEEC84FFBC3017D7FEEE193CF4E80AFCEDEFF371FD0D1FE0EE7B97E0F67B17E2C63FBF8DF59B23A55523A308D389208C314CDADDAF9C58AA5EF62374741E562605A339342FC89EE3B495C8A5C2676C80C92CB49F6946D09656CC2CDCAB853F4993C314B88F0EEA909824141ED218F9A2E93520BFCB6DAEF33C9A869A1FC39699FBB82ED688BA0EB5188726B0820AB319FAFABBD49C329D1D6DC2D40770F850B35A969614617745190ED4EF47556505AAABCA5154988F9D3B0B909696828888088484862B616756015366F6ECDDAFFC806879BFECECF4F70F474949159C9C7C70F8708BD236CCFCA590CAADE170C7A0BAE7EADA16756F1939A5A83DD8A90AAE87C564A168F7414425E58900EC41796D87F809BBC4142A54DBB1A93B9057528B1DA5FB452314C1DE29102BD75863CE82D5A8D97718B9F9156AE6E1DC5C8E8014085333A381A9FBCCFD0A898C857F481442639210235AC837385EF8C10B8B966DC4D4E90BF1D67BB3B06EA3955CD71BE6564E983B6F13DE7E6721A64D5F8E556B2C549ED8E16303C10C713ABE3D897031D1D3A3CA6DAA0EAEC36DBA3934B41A4E0D0D0DD8BE3D0F7E7E01D86C663191B313161EA960EFE082058B97C1CB3F18AB376CC6234F3D871B6EBD0D2FBEF111566E70C4FD0FBF8F4B2EBF1DBFBCE645FCECEA57F1A3FF7B11B7FC650E6EBE6D0E2EFDD643B8F2FB8FE0D12766827E29CD92216653CA3A1D72320DC1821822C20A1CEF7F2CE151B5CAB434C828DAB164647D46D709893892625FEBA3B9F5B02C5B9506A1A9C57031C3C28C9AF54B734CB385F638CB98C62549EB1BCF0C817824A66628A465E622393D4BE5B4050587C2CBC7139EDE1EF0F671878FAF3BBCBDDCE0EFE7054F0F1704F87B233D2D0979B959C8CE4A43417E0E0A45400A0AF254AA3B87DE667376DF9C4231A5C6505FDF8A7DFB5A1015958296961EB8B8048053D5787986A3A2BC0136D65E888D4D57CF3F6DDA423571D0B29516786FEA224C9DB112AFBE350F4515CDD272FBC0D5271EC5BB0F61FE326BF8866661BA30E8B28D2E700B4CC7BC15B658BEC91D2B377B62DE522B2C586E23825482A56BEDE1E41181B5664EB0B1F3C581C63E71D2EB1115938188A834358292D9C87EFE21F00D0845B808476A563E2213D254A6338702ACDB6C8FA5ABCD31FB93D598B5709508DC2AACD9608965ABCCF0E18C0578F4F197F0FED485F0F58F166DB85FBED2717E3C972C6FA3C40B0976466929CF84617DADB6B636C4C4C4C0DDDD5D5A3017CC9A35078E0EAE2AF1CFD3C3176BD6ACC18A552B51BEBBE2186332574B67DB978A3376FF23CFE2B26FFD1253BE7E1D6EB8F905FCE0AA7FE31B573E866B6F9C8ADFDD325DB4C9C7B8FA37EFE317D7BC832BAEBC0FF31658A0B272BF4AF7F870EA4C3CFDDC4BF00D0C11B55D88E8841844C48623392305F12909888C8D415874DC04C205646242CBED0A0A8B145F281C1E3EFE7076F71213CF59ADF39A444048A81C138EA4B474951FB66B77B5EA9967C764D3A10EE58C32C78A82B2BDA01065957B941DAE72AD0EB7ABCE4AD5632FF7DBD47C08DD6226B26F42693BF66308582D93100F4981EB47C6F9CE45738A934D5F4445AE84E1E98AF4F61E455363AF9858E2FFEDEFC4CD7FF807C24285A1E7AEC33B6F2DC0EFAFBF1B1FBCB7040F3EF03FFCEFA599D8597840B4F47FF0C73F3F0A7BE718BC376D1D9E7D692EDE7C6F35BC4373F1F1226B986D0B45765133DE9CBE1E4171A5786FF666CC59E6884DF63198BDC209F356BB62DA026BA4EF6C82939F9872953DF870AE39C262F33177F156BC3F6305DEF97011F28AF6C1DE9585C14354A13D5678B1D8E6A4D2527C82A355513E16BAB070F4C2665B376CB5F550B066792AAF10F1531D316FC93ACC98BD187317AE54E3F93914803966F237C17767EA37318451E2F9C098EA3246AB3FD0A006F35083F8FAFA63CB16736CDD6AA1D2C41D1C9CB07AF55A848484494BC75E549A472CDCA60B027449B3572B0EBFD692F78A35B770A925BEFB93BFE0926FFF19DFBDEA214CB9FC4E4CB9E29FF8E1CFFE8B9B6E9DA64CB1DBFF36131CA3EFE99D0496DAADACAC47645C0A8ACA2A515C51818CDC1C64492B9C5DB01DC999E962EFA621212B1BF1995948CCCC467A9ECE3E2EAFDAAB86AFEEAE64E66D83389F07D488413A9B5C67A724416160A446313AD1A8EBC1A78068692CD42844736B87D240D438EC4CE33A2340ECBB619FCC80988BECB166F8BCBD93B9532DF2F11BD1D85487CE2E8E146C50E8EBEF947DCDA8ABDF7B8C764004AC5EBD47FA74CD2DED2AD78B664E47D711D4D77509177C17533F58A804E59E7FFC17EFBEBD104F3CF6065E79E963FCE39E17B078A92D9E7D7E267EFACBDBF1C2AB0B70C73D2FE2AEFB5FC153CF7F8CD5E63E78F899A998FE8939ECFD52F1CE9C4DF08E2AC0FBD2207D2802B4D1210AF3D6BA61A9990FA62EB0C41AAB60BCF8CE1298D985E1AE875F87AB6F12D69B7BE265D14E8FFDF76DC4A614232A211FAEDE9170F78D96862656E56F790546C2464C410B11180A89AD7B20ACDCFC95D0ACD9628B8F3F59856973968A2FF2896897952AC295955BA242D1E499B3C1E9FA528C122F264A4ACB909A96A146AB31FE6D66B605DBB6D98946F184A3A333ECED1D557A38D53D3BBA28245D9D3A2DA4A94A66FF320ECF9EDD5661120A0B1FB147FEED286BC216BB70FCFD5F6FE06BDFB90953BE7603A65C7A23BE79C56DB8E6DAA770C9A57FC5A597DC84E9D2F275F5E8225255B507515C5E89439D9DE81D1E4483D8E5070F1D42AF30E8FEC36D68EEEE45AB306983306F556D3D4A99C55BBD4FA58B73BBA6BE117BEB4460F61FC42E111ED20896282D2AAB465E218B3788B610E1E2FE26F1072AF6ECD3255556D7A0B6BE4165385393B0B779CFBE7A456B686955C24461ABAD67B264BDAA96D9D8DC20CC7F000D8DA2191B4438F7EE56DB2D871A505E51A2B69B5B0E626F4D25F6D414A3B2BA08D53565A816FAEEAA4A1496EE529A8A633F4ACA6AB07A9D3452968ED8B0C91673E6AD427C622E167CB2014525FBE117908ACCEC6A30825A507C00DB0BF78B16C84372CE6E64EDAC45405C365EFD48846CB505966D76C0478B37618D8D173E58B81E2B2CDC60E7178739ABADB160BD1DE6AEB482734082AAEDC6E5CCC566F00FCF824F48BA084108B63987C2DC563483987E5E01716A6963EF211A3A540506CCAC9C5545185B118E559BE55E576CC407331788C9B5020B97AF0773BC38A4393BBF18075B7429F59CE44ABFD0C9A78551E28546A7303AFB454A779563F98A55D866EB28CE16EB4185C0DACA4E9958ACC6A15F308DD2DDDBDB8B6123433A39770AA7C463CDB0610C88900C63E8E8C9AAB44F3E2E35EE260B575C7FE3DF71C96557E3F6DB5E1541B919BFF8F99D98F1F172F10BB60B93362A2667113846538ACACB95E0B0205CD95E61E8B2DDD85E548A920A319B0E36ABF415E66E512B50C8F6EC6F44F5BE0654D61C40E1AE2A94EEAED1254FEEAD17536B3F4ACA6BD592C7844625886997A33292236213954FC2EAF134BB585FABB4A24A995F9A09C6DFA036E2B896FD7507B0B7760F6AF7D7A8FE266A1486D3E9F3F11D3320A13AF9C675E36D889EFE369591D074E800EA0ED4CAFD56AB5E6D9AB099DB7395C66273440D5850588EF4AC9DC8DF5981E4D40211941A8445A4233C527C86E82C8444A4886F108FC0A844A46C17273BAB00690525F08D8843FA8E52848AEF10189786D8AC1D08884D45626E317276ED457042A66CA72132793B7CC31390B1A31C49D985F0166D1195588090E86C387B478826C95185C06D5DFCC46C8D81975FB8F826E17070F5C65671CC2DECDCB062BD39E62FDF20E6DE6A7CB27A3336995B2B079F8D1073E6F4BF3FD1D9D3AACA66A97AD5629530347EAADAC6A78351E2F9C0D0F6639F48A69831B6F6764A48DCDCBD612B3E082B7E787807A9AC57FDE3D977A2BFADA1BF9703BB46D0DEDE2A9B62CEA90158421FEB43EF480FB8EC579D60C7CFD1EF481A60F2922C6DED82F1DC73B3F08D6F5E2D4FFF1DC19558B7C146A576D38CA2E3CC9034C79367722C7746BEDCBF3044663E925273D4F0599A6B44B43006E3FF3189E90A2C6E9D94BE1DE9393B94D3C9ED84943CC427E7AA5184C9E9F97074F351511B66B2B22A23C7B4D077A190EC28DE85BC9DC54A68727714A93242D45ED43A35B5FB959FD2D6D1AA4C507E7856F367608139500C55331A57BBAF4E0D10E380300600FC0342E0E1E9AB8221D6768E7074F580939BA7BA76744232C285E9CB76D7AAE81A73DBCA771F809B4708D2338BC5018E818B733032334AE1267E43FE8E4A040BA3F3199DBDFDC46CF257C528F81EE2D37254410A3AD971E9B9088E4946406402BC83625468382C365DF647222C2A598DAAF40988145F2F15EE7E1148CE2A5482C07D1EBEC170F3F4539557D8986E32B3C08C99733177C112AC5C47C1D8067B79870C2B37779DD8CDA0C1D0D467904699EE0327F2872118913D95F97512E17C40216144893FB66FDF3EC4C7C78B83EE202A5D1EDAD101965636A24A9D541A0153DFF5CF3D1F0C9D831DAA81C5ED0F3474E15F0F3D83CB2EFFA138FB3760D3162B35308BA57438563B237B0792A5358C894E4644783CA265C9B9402804C919B9624F6789939E87A8B874C540FCF0FCD831720EC74624A652404478D20A94E6E236058B6618354A7482089B68949088E889A000C1E817350A3386198E658B4F8150FD28B2C50C030E841B18EC162DBD5B0DF17576F1809DBDB3828BAB27DC3D7C94705859BAC1C6DA0301FEB1AAB2639CB4DA31F119AAD453484422824212E0E115063B071F15D5DA5BDB26A657BE5C235CCCE350F87AC5C2DF27569D1F1595A6A6A763CE14B5A1BFDCABA74F30BC7C43C4E9F681D53657985B3BABBA5FEB366D53D55A2CB779A849512DADDD6163EB89F5EBAD6161E18C0D1BACC427B5C7EA0D5B6169EB8C8D5B6DB07E933996AF5E87156BD6CBF3B8C147043157BE034746722C0BA384DAF7FBAC6194782E3856206262BBA9A909B9B9B9E26F3862C9922558B162053C3C3C90268E31CD2F4369A7701DEB0D9EA05D68188601BBE4A5B3FF447FBB20BF08AE2E9ED8B8618B30972D7CBC03D410DC5461708263B4E3C4AC600B4C551F181983A0A8586198649543E4171C29F478448A89C1CE330A0E1D51FF50395E182C222E4B15646001B9E0A814A4E796CA7606AC6C1D540B1F1E11A346387214208542CBDAD5751892A2D31CB9792CC890249A224898D2469C56110C0F6F1569A329CBF241665BED8439DDD5A4A42161494A4062E3B355B835357D27B6E795AB6D0A09E739F1F0125FC0D60B1BCDECF1C8632FA8C6E3F917DFC5D2E59B616DE32B1AD70EF316ACC3DCF9ABB172E5162C58B01A73C4715EBD92FB1DD424A79151F16A3C3B07B071B01A07B1719DD36FEC117FAE46681C7CC6ACF016F18F38D684E367C83FFCFEA7EABF389585F159C328D118F8201A43B33FA4B5B555A53568FB6B6A6AE0E7E787B973E762F1E2C5B0B3B3435050108A8A8A8C4EB970BA08C3C506C75A18D2087E9463B94D13B481DE311CAC6B16412A46527206E212696EA5A912A4C1D1B1D2BAC6880319AA7AA75917CB3728425723CB5F4CABC028F804C72234264D25E5790644A8C979AC1CDCB0D9DA412D39051C87027382514EEBA61B9ACB2C678672998F05353A8FE3EB2322A3554B6BB3CD4E15F9A3A05043BB79718A383F6CB1D8A6E65AF414E73790F67F4C86087632A24478A945A80D56AED982454BD7E1E3394BF0EE07B3F0FA9BD3F1E4532FE33F4FBF86A79F7D030B17ADC3A2251B4468EC14ACB7792AACDFB84D09C99225EB606E6EA7A6D5686A3CF1BBB24F4A7FFBCB04A3C4D3818E10C1B408FEB11C8DB7B737366DDA046B6B6B787979A9CEAD4387741D8AFAD0D73EA76A412E26A8BDF45B28660C5388CF46A319B66CDD83FD6A6831A355C5E2ECAB790FE3C5D90D0C1333444C0D1B713EAD1D6123C2E0EE13A4AA2EBA7AF9A9F9475810DB2F380C896999D2FAEE07472EEE2AAB54E3E9D937C322101CE3CEE1BB5972BCAF08214BF42C59B15A09053510975E7E81B0777653897E1412FA7EAC2ECF7AC01C3F9E21BE40AC38D53636CEA20596AB2275EFBE3B1D1F7CF031A64F9F87D9B31761C68C858AF9972FDF8879F396CB712BF1D147F3147DE9D2F5E22B9861B3B93DDCDCFC909C9CAD462FEABF070D6CF8CE349CD618D8D8123C977C75BAFE8DCF53BB9C44E083EA3FACFEBAE683F08F26565C5C1CD6AD5B07333333252CBB76ED3A81E9B473B9E48B6036B0B68FD73ADD4BF92CA07BD6E3F7C02891B6CD259DBF9EAEEE4FC500C6D0C5026DB2645A0B0729B1A95159C9620572F4DEA8BC5AA692B0042C8BC2514B58DA3AC2629B831A47C1014A34AF38532F85823E158322CE6EDE2ABD8753583320C1123FA4AD5E6786E933E6E0DDF73EC26BAFBF83975F7913ABD76CC46639CF5C04CB5EAEC14A9B616171AA785D4A4A8E4A5DE1D8741690E8E9D18DBDE13D1B82DF4EBFE133C4A95294262B8C120D418927A35048F2F3F3E1EA2A4E9BB9B932AF6A6B6B8DBE3086764FF722BF28604895A9E22CC867E8CB9C0E8CCD73663143FAB980D3C4A9B9D86967D117118161710A063B6CEC5CB1C1CC0A66568EAAAA3CC1DE69178F40D9E72E82E32602238E7F62065233F25434CEDDCB5FF639AB814C2FBEF23A9E7AE6592C5DB64A692AFE5E0F7B666539CCA432BDFBD0406135A411CC31EBE8EC46F3A116D93C79FF57014689A7025B91EAEA6A69718CBF3063DA447FFB74268EAE753FFF56FB4CA050186BED48638C5DCBAC25B86D789C3130FCC8BC300E4C32DC7736E8EDEE53C97F748A2D2C6DB1D5D21EABD699C3D6D14B5592679A38E72859BA66AB9A72C1DCD24545AAE890D3FFF00F8A5642B568E92AFCFBE9E730EF9345884B4A944B9FF83B1CA46648A339C3BA67F4CD587042A37179BA711A1CA83534C834986E0C0EF46078A80F2C6AC8228786C77E196094680CB41FE957E83BF08630E67750380CE99A407C1EA6D7A9AABB9F0AE7A265CE062CC7CAA556D6B5B478175C9C5CB14C987CF1929558B162039C5CFD54DA86AB6708566FB1C3829566D8B2CD1D0161496AEAEA948C42E4E496C3C72F1A2B579BE3838FE6E2BDA91FABBE068ECDE775090EB5E5927E987E23F4691B24ADA36E4C1A952FAB409C0A46892618C7B9DADD2CC134C2517D7A33EFB2F00253E3E362A3B171C31A2CFB6429D6AD598F6D360E0860875D6084729E57ADB3C492D55BB07CF3367887C62325B7140111C9C8D95129E6570866CD59A142B92FBF3A1591D1E9E81D5021E489DFEE91D6BE7BE0C444400ABDFE33D0ECD4D62F64A3F5651422A34413CE0EFA3ECA2885424C30AED3F7E010662EB5FD445747372243C310E217005B0B2B783A38C3D7DB0FA1A1E1E2F7B9ABD41EF64473EC0DA7A456BDFE49B9C82ED88D50118620D1280F3CF85F251C6BD658203D7DE70933FC12679A0386B3A169EB5A2D350A092D85B389FE7D55619468C2A9A1FC976302A181D3F0E96F1BA2A27A0F5252D3E1E2E2A63A3437AC3383F5561BB8D8BBC2D9C95D81537C6FD8B8154ECE1EE29407AADE6E869799F73463DE72DCF18F87F1E47F5F5221DFFA8693FBA59859ACADD3F9D62F4ACDC164DABA06E68619D24C38358C124D383718AB65CCDCB2FAC606A46667C2CA9EA91A6658B6729DEAD3E0C84157673FD8DB7A61D34673988BD0383B79C1D73714313129B013C77DCD7A0BF80644A2BEA94D8D376FED1A004B8FEA876B5B98AEBFFF203895437149B90A2DA7A567233A4697E3C5DAC7793B4AD4340B2CCEC07951B473E9A7683EA7E67B98706A18259A707660B91D431A8708EF3FD880988444586EB3C5EACD1B61E5E408171F3FD573CFB471E63EADDF682F4B2FD57F91949483B4B47C6467172120200AD6D62EAA13B0AEEEB0EA6BE178140E07A040AC5DB7092C3CCD94FBCAAA3D38D8704855A7E7DC223B0B77A9AA255CAA394AB2F2E0EA11A8D2E85F7CF92D3CF6F87F544E18ABE76B7F34B73E8B68E3648751A209E70ED69CAAA9AB47545C22BCFD83546A09CB776EB2B682A3A7B72ACAE6E8E1A7A69F76F70E8787770C12920BC53F89476060346C6DDD55A2E0BBEFCEC4F4E90BF0E18773456822909E960D2F2F1F141C9B2A222C225CF567704A8BAE9E6E350F636D5D2338D90E41ED51BCAB522D396582BDA32F1E7BF279DC70D35FF18B5F5C275FFC323CFBDC0B2AC4FF79441D272B8C124D3835388E83A30DB9E4364727B25A2173B62820CC80B5DAE6A87AC6D983EE26CEFA162BD12C1BB66283F93655958409924C940C084B115F244CB5F81F4E9F8FD75F7F1F1F7D34074B97ACC1AC8FE7E3C17F3D860FDE9B8A00BF40341E6C9A488E1C1C1E42776F0F0E341C54655D393E86A32629305C726C090B82B318C3BBEFCFC12FAEBE11D75D770B7E7DEDF5F8F615DFC355FFF7336CD972BCAC284D309366393D8C124D383358486240909E23E68D97AF1A40C4541327776F388BE6608ED7DA4D16D8B4C506F64E9E888A4F455A76814AC9670FFB8A355B307DD622CC9EB704D366CEC7AB6FBC8F7F3DF818FEFDD4B3F8F7934F8B903C8ABFFCF96F880C89C29121D61B132119879A42A1B3B3534D52C4B2B35A9956ADBA0B87297328318B7DFB0404E3DEFB9EC48FFFEFD7B8E596DB95E9F5E2FF5EC695DFFB0EFE71F71DD85FA72B0067C299619468C2716797B590F57BDCA94D9808191219A3CBC1B27756534E33E9512728BE58BFD90A56762EF0F40B5135A7327376C2C73F0C665BB7E1E9175E5502945FB44B5D734005A74453C9B2BB67504DE84353EBEDB7DF859787B76E300A334EC4871F3A3688676C6C5C15B3A666A16B4F412128281C7BCFB1F6F46BE62F5A0A4E35FE97DBEFC54F7F760DFE76C73FF0E453FFC6EF6FBA01D7FDF61AC4C547F272273DBB0927C328F1AB82BEC12E957AD23FD8778230900159E397B9572A0F4BFE98E651555D2B7E4281CA0E5EB2722DE62D5A01736B5B6572713C8899B9951A4518199B80D4CC1C658E996FB5C69CD90B307FDE22151A6E6FEF14013C1EBA35C4B1924E5A96832A66C73F0A2E6F85F598B9EC1D64F13C5DA924CA12EB8AD1E1E736C1F5691FCFC237BEF33DDC74EB9F71FD4DB7E0C97FFF072FBFFA0A5E7AE925DC73F75D707672902375BF6BF2574E0FA3C42F2BC87CAA78DC40B7B4C67DD22A1F670E6D1E76D6CDA580106448B6DE2CE61C1111A5460F4E9DFEB14A3C64A66E4068A4128ED5EB37A9254D9DF8E43455CE88E9EF2BD76EC0471FCE84ADF82C9C1D8BD727344121F33371D45847DFF6EDDB515E5E4EBAFAA3E34E11D104E5B8808810C9BD6A1A854BD26992718A836F5EF97DFCF1AF7FC3EF6FFE239E7BFE454C9F3903B366CDC2238F3C041F6F4F39F2D8F39B04E5B4304AFCB2E24CCEAA96FACECA8F9C8AADA0A818C121617075F350C398CD2D6CD4787A33D11233454B2C59BE069E1C63929E8DCCAC5C359684D56566CF598079F317C9B91172B5E3D75799C2B2E47D68C2714C739C701F25252598366D9A1A04478DC2B13F9DDD9C668105FB38A1CE802AC7CA489B36BD04E79A647105566EA1BFC27247CFFDEF155CF1FD1F2B41B9EE869BF0F433CF61DAF4994AA33CFDF4D3C8C9CE942B9EF8DB26188751E257059CA783E54EF5699CF989258342C507D9B0D91C9BB65A2A6DB1C592C36E5DB170C97255E82E292D531584484A4E57C2C2D2AF3366CEC1FA0D9B51545C76C2359B5B0EAB7911F569A78226401C315A5A5AAAB299E9BCB7B6B7A992AAAD6D1DAA381E2BB3B0781EABB470D62F963562092516A3D8BBEFA09A49F7A557DFC275BFBF1977DE7D3FFE74DB1D22282FE099679FC7F5D75F8F0F3EF8002D4DBAAA37A74B74354107A3C42F1BF435094D2C6A0E6D5B435D53139233B261EFE28ECD22148C626DB5B68383AB8732A35C3D7DB0D56A9BF247E87FA4C8B11BB758E0A5975FC5FB1F7CA8CA9D761D4B53D740C6666A4977CF898CC82927F4B7397647CBB76A6E3E5EB289E8EEEE44717121F20AF2B1676F2DF6D735A8394158708F42C14218140AAEE7EF2C9DE83FA169F8FA5BEFE3A63FFE15BFFFC39FF0B73BEF151FE5695C7FC38DF8FEF77F88AD5BB74EFC8EFEFB31A6E14CF80A6A149A2CDA3AB507E7E548CDDA0E330B6BCC98335F39E91BB658C2C6C14545B2CCC4DC72F7095061DF70F13D687AAD5CBB0EFF7BF535D1385BD4D4D41C52AC5D93D02626D2A7D12F619D81E3DBECB7D009AC21735270EAEAEA26686565A5C8CCCE52F3D03398C09EF7ACED85C8C92B5660548D83B738882B36215D15C070F30C00A78FBEEFA12770F31F6FC3ED7FBF077FFECBDFF0F35FFC0AEFBEFB3EAAAAF64C5CDF8433C328F1CB84530DA6625DDF7C319DD69B5B62C99A7598B774B9AC5B6193680D054B3B387B05204E4C2CDFD008B8F8F863F18AD578FFA319AA96B0FEB538BB6E9FF80DFA347D70BFFEF6E90684B175D7F76108D632AB3B50AF2AB0308F2B3C3C1E11D1494848CE5163E339469EDBCC38F60F8A54A168D64C6338FAC9A75FC4DFFFF1006EB8E98FF8C955BFC0FD0F3C8CF4749D6FC201631D1D1DA6CEC6B38051E264053FB661EB7CAC22FDC476474FAF8A4CAD58BB41CD12BB60F94AACDD628ECD36764A40281061B1C9088F4B81674018A68AD33E63FE27B017BF84B309734E45FDEB7D96A023CFFA569C5827253D1FEE5EC1AA96D6A62DB6B075F0544384994CC98210ABD66EC5C2C56B306BFE127CB264352C6D1C10179FA2CA21195ED78433C328F18B0C0E593D53358ED1E131AD736E825655BD57552D59BA6A1D662F588C8F662FC4B2B566AAB39053498446B1A85B82AA90B276D316CC5BB4149B2C2CD4B40B749A790D63E9EA9F0758938CD34AB3CAE6BEDA83A8AF6B42C3C1436A2EF696E676054E0CA49B9FBD551D6B780D13CE0D468993051CD3AD098D9AE047FC02C3BA5C2C0ACEF0EEBAF51BD5FC2AABD69BE19365ABC461DFA64A806EDF51AC4A086D12B3EBDD0FA763E5BA8DF00D0E46F5FE13E7D220E89CEB6F7FD92A8D98706A18254E4668335DB10F8493F6E4ED2C84939B3BE62FF804AFBFF11666CF99070746B4C469CFDD5902569B8F4FC9C007D366E2E5D7DF52B5B29823A57F4D820E7F1B4B161DEB03F9BCC18640EB8FD1071B0A361CA7EAF5E739868D8809670FA3C42F12F443A95CE77CE3EC93D06FDDFBC4372138836E466E2ECC2C2DF1F6D4A978FD5D4EBE6F86C8A818556591FD202C7ECD9EF4A79E791E6FBFFFA14A3361871DAF4361632E17A7D5D6AEFD45039FDB50B39970F161943899D0DED38F5D957B10101AA142BC349F662F58840D5B2CE0E2E9034FDF002520D426B6760E2A7BD6DBC74FF56E1B5ECB18B4C98B74EB93CFD6E77372BE76FDA1C1269C3B8C12BF686034CB3017A9A9A905C5C5A54A402C6D1DF0F1BC85F870E66C71D6D7AAFE0E761E32C3779D38E6AC904E4149CFC83AE11AC4E998BFB5FDF044B224FB3CB42927BE28389599752A9842C09F1E46895F64ECDD5B8BECECEDB0B5B5C702F13F3E9C314B5546E4DC899C2E810989AC10BF78F92A9566CE6915B4B11ACC08D6C2C75A3F8521F318D6FD1A183ADEDB7EA16B7C5D4C5088F40589E3E24DA92A9F1E46895F34509B949595A9A99F291C8B172F55733CDAD8D8AAE912424223D55870960FFD64D132B8BA79A9E2D786D7399D437E3A21D0CAFA98F0D58551E2F9E04CEADD30B5833DDAECB9EEECD415F0362CFB19139D804D1BB762E58AB558BE6C35366FDEAACAFE448983CE791F972D5BA1E6804C4C4C06CD31FD73092D55E474A1DCF1A3A67E06134E0FA3C4F38136BE421318F673E8F77570A9C1589893282DA95093F94CFBE863AC5AB94E5551E49CF3161656888D8D5766172729B2B2B252C271AAF49173B5E14D30E154304A3C1F9C49A39C4A38DADB7A50B87317E6CD5D04B34D167071F684B75700FC7C8364DD43573C6EA39932B738A8493B8F7D07864988A7FA0D134CF8B4304A3C1F18E65AE947ABA8693810499FB69F33E5864461C3FA2D58307F09428223E1CB89776C1C158DC5AB291C8585C567EC30E36F5FE8C8CE515CBCE27047C62FDEB54DB8B0304A3C1F9051094659F42B101E9B2B45FD719E95CCCC4C31A52C307FDE621186D5B0B773415464BC985AEBB17AD506383AB8213FAF48F35DD49FFE7C2B8602A90FEEA3309EEE18E26C7C932347FB405C283F46FF3A26DF68F2C028F17C60D8A26B7E024DA3868626AC58B10A6BD7AE8799D916E573708E794E32CA71E52CBEC049313BDA7B4E988C94851D0C8300041DF58E8E2E857331B7C8A0C4C5D416267CB96094783ED01F4741D0D166C720235414102EDDDC3C606FEF084B4B6B356B17B5CBB118FF495AE05493D9B0488461248BBF75360E3C4D9E71F45F3041E91F383EE5DEF96032F5D37CD570C206B5415757979A00D4D8B4729A596548270C0B3D730A3B4E7EBA7CF94A2C59B24C85753D3DBD55FF878787174A4BCB545858FF9CDEDE0BC370A7C3E8D80046C774E6D4519CDC014766E51CEEA37A15EBC7B83DD2AF6695D26696E2643ADAFED6D6E313BB6A93FE73A90DD01A61885A6FB01667AB22B8AEBD0336101D1D6D62327EB65A6E589ECBB09F88EF80F7A3BBA78E931AAFAF228C1239FD9CA5A5255E7CF1453CFBECB36AAE784E6CCA61AFC65AEC415D1537B5BE758B15EC6C9DC0E58AE56B94CFE1EEE683F8B86464A4E7A80C57EDD8CF0A837ABDEB86E8E96E9F60FAE1416908868E606CE4A8AA5534D0772C5357D6556EA62C750D85AED6D640FF89CFA266D192630E35751E3B64140383AA5F0847C68021BD4AF4FAEF81410AF61F31D0419039B57DFA3036CEC610A3E3276AF4738126D86C4844B71F03BFEDD809FEE65711132B5A0B62985345646565E1FDF7DFC7D557FF0ADFF8C6B770EDB5D7E1B9E75E509D805E9E7EE278BB62DDDA4D58B860898A52B1CFC3DDCD1B29C9196054AB5F188ED7D1F73B3E2BE8B7D067326D468784CBE5168744F08F1ED155663CCA89DEF9270BAED2CCEAEB1741A0F176ECB9F441611BE573F252AAA51E457B87D238EAFCEEAE9335B506DEEBF83885697C8231FB3911EB312DA50FDE1B7F6B62FB585DB24F03CD84D5966C588E8C0FA1BBA71DBD7D1DF22823E2D3E90234DCFF55845122C197C232398674B6843B7614AA4EBF79F316E08927FE2D5AE779BCFEFA9B9833671E76EFAE524E7B6BEBC913D568DA4813C6CF4AA59301B4D6D204133E0D8C128DC198A6D1A009C0317BFB24F38C743ADA5A395193CD6BC264C34904C3A8D5999C4B6A1EFDAC540AC1A91C7ED2793CB5D2E7E1AB9860C2A7C5C48AC6DCFA9A439FE169DFB3181BCDB1536917434D713A2D648209930927110C99BDB7AF53B4C0C9CE24414DD2D3A31B674E3F407F2C87E6380F0D738E40DDF986FD1E269830596094688209269C08A344134C30E14418259A60820927C228D104134C38114689269860C289304A34C104134E8451A209269870228C124D30C1047D60CAFF03149AB82DD1225D5F0000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A350-900R'
update aircraft_type_ref set aircraft_family_image = 0x89504E470D0A1A0A0000000D49484452000000E200000070080600000003BEAC9F000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC200000EC20115284A800000001874455874536F667477617265007061696E742E6E657420342E302E36FC8C63DF0000483949444154785EED7D07601545F7FD23090408480FBD570545451111051B282848AFD291DEA5F7DEA48322BDF7DE9BF41A7A27A124841412D27B3FFF7B66DFE0233C0B7EFEF3FB3EDD2187D99D9D999D9DB967EE9DB2FB2C004C98F8D7232929413CE338313111494949EA3C3131D9084F8C065212911227F17889D1E30589F4139190148B14394996C0F8A468394E405C02FD6424493A889F2CF7484A642295A7722982A494E4E70B63C2C4BF1DB684B44542421292C91F618EF00609F1A4908D93B01412548293C83BF193ADE7445CAC1059113019717131888A8A5264E7E564F9FF851B9A3061C2405C5C9C78246792D25AF189714219D16A88414272841C4709892205D1488C17D65949474626C49378B142B628215E889057D829E1298AADBF6A44923041986BB700264CFCDBA04D512222224C089480848438248A29191313A508161D1D8BD8B848C4C687082943C47F2A240A1592464A3282A40B527E6262A82409477C422042C3BC54FA98A8688487874BBED4BA62AA0AA51392E295E9FA42814C98F8B7826343FA0101FEE2516B25223A261C31B1116A5C9814630D4E105625D11695BF046A3A8929C48B8D0D4554A41050B45F7C6C1C92E45AA29099F9C4468B6F55842929298AE82460528A8C291363EC17C884897F33A811938520D13161A2CD028567F188087D82A4786A4683784971F1C2AF0404073C417870A0248B41A230959A55828DF1A1388E05E313A2F1E0DE4384878A39CBB48CA3266D1225AB44C48896B55B101326FEAD20499245A3C509E98282FD451B864A701C22627C853471080B8F546422D148B8D858C54BC4093F13E58093AA9C68250F43236310221A323639120971C96A1CC9595863563641913D31394ECDB2DA2D8C0913FF568486862A6D457334322A4482E290901829FF034FC5429DF4C3660C19B609B5EB8C418E9C5F2043C62AB038568093637964CFF61E2C96579139D35B7071791D2E594B60F20F3F215A4C59CED1704296444C4E4E5693362422973B380164B730264CFCD3A166426D26686C111511AD341855DD93C0185CB9E6051F9F140C1FBE5C88F6265C0BB540F9B707A364F9FEC89EBF3532E7680C4B8ECF85909F237BEED6C899AB21B266AF2471B320249C1ACF98A8E1B851D8A790182F1A31F1D7FBBF50081326FEC9B0473E6316F357DF208CE842F12E5EF6C0AEBDA7317AF45A64CB591DCE596AA252B531A8596F31CABE3D06AF14EA0C8B737D58B2D745FA5C2D90A75037E4716D82744E65D1B5FB20D1A656D33526561191E44B4912AD684342E2B9029930F14F872D11791CCB419ECD759AA509F12A0C972FDF86FB83009C72F34099575B8BC6FB10390BB645A51A33F0CEE73FC1B5DC706428D80339CA0C40FA7C1D51E0B5C12850B20FD265A801C70CA5114B533449B49F98A3249F2D6C8948823E2B800913FF0668ADC7C5FAB0B030040404203E9E3398C6756F6F2FF192F1D8C70FCB566C814F40122C0E05E090F90B38BEF20DB216EC88BAEDB623F76B2390F7CDB128F4DE44A42BD41D4EF97AC192B90DF296EC29F12B63E6DCCD6A022738F829FCFD7D15E1791FDBED73B678EEC484897F3A48069290132674F45313232C2C02F3172C0397FE2CE98AE2D33A7D6071A987F4B99BA3C8DBC3D0B0DB5E642EDD0FB92B0E47BECAA360716D0B4B968EC851AC2F2C4E9F234FE1CF70E9C663242627196B905C478C8D5633A5B6F7D19B06886781264CFC1B40224647472BED141414A476B9F03C96933372DDFDEE03AC5EB3117BF69E432ED7F790A7601DD170D550ECEDE1B0E46A85BA1DB7E3E396EB6129D019AE6F0E43B12A6325FC5B3864E98022E584B0A20DBFEB3111C65C8FB12180848B8C08B32EEEDB2F97DD401326FE89D03B6734EEDDBBA7B421C1B5C10B17AF61E9B2D5080F4F469162EF239DD35B2851E63B58D2D747FABCDDF1CE978BD165E435147F6F2AF2941F8912EF4C84539E4E28F6E648E42BD80D5973D485A373051C3971596D5D4B4C89152337414DD6FC1609F94606FD172E9830F16F81BBBBBB78C6EE175FDF602C5BB60E4F9F46C2DB27128E4E2551E503D17096DA28556E0C2C397AA2ED80ABA8D9722F9CF2F743CE92C350FADD1F60C9D00A55AAFF849225BB4BDC4A68D4B82FE29536E4B245A4D28AFE4FB9F3E6D7FB6AF2D9E2B9131326FEE9080F8B46427492025515C76EDE8F1F60FB8E65B8EB7917D7EEF962E7815BF869F1193867FA0C2E39DBE3FD9A2BD1A0F3417CD47035F2941D22E3C58E285D71165E7B673E2C99DAA2C27B1391C1B1B6B0A93C4E9EBD2E66693CA262F8FE229010170F7FBF47726BFBE5E15ED32421ADDD8B264CFCD310151FA904DE78A337164989DCC19D005F7F6FDCB87B1D53674C87BBB73F0E9DBF090FFF04783C9644E92AA270B96EE831E20A3A0C3C8DF76AFF044BCE76C85CA81FAAD7DD841C0587226B9E6E28597E201CD3D5408D1ADF2146B24FE2E44CBCE42F444C4A48466C0C276CEC978BA62BC968F7A20913FF24706CC8715A5C02C76C5122F861884D0C8697AF27C64C9C8A1DFB4FA0E46BB5D075C0749CBDFB049B7F398B2B0F02B1E9C06D741DB605D9CA7445F3AEBBE152B8B310B115F2BD350E55EBAE83C5B92DD267F916458BD32CAD8035EB8EA93DA641A14F90989CA0F6A2727F697C1C496FBF6C242261F7A20913FF1470228633A391915C5CA7B68A43624A241E3DF1C2B9EB37112A64F9E8CB4E285EFE3BD46A360E1E6180774C32EE3C0945908CF5561FF24196D7DAC292B1019C0BB441E612DD50B1F6CF485FA41F5C4B0F45A5F7C62063862F50A44855448A35CA1788A3622513A1D7B3CF6CFC09D80D3461E27F0D241C351F49977A76542DA2AB0914D2231E6ED7CFE2C0A9C358B86E0B5AF6188D8A9FB44593EF76E0FDBA13D075EC72B879058354BA1B00F49DBA1379DFEF8AACF93B0819BF41998F262B22662B3D18E95EF916A5CA76131655C6FC792B55FE7C8B3F293956AD0DF2DE7F1676034D98F85F0549670BBD80CF59CCE8B85019BDC563CBDE1D58B16D3B7CC4627C2C1AB156BBC128536D126AB75F8A4F5A8EC3CCD527F1E3EAB3E836780D3E6B3913253F1B8A373E9A861CA5FAE0ED2F7F428642BD61C9DA0EF9E4DCC1F963BC92ED43C5F2F878E39EA9CBF4676037D08489FF656873549350213E1CC1A12158B464030E1DBF83FD273D71FC6614EEC7026B4E3D42F516CBE054A4392CF9BE40DEB22D902D6F63BCF6F6507CD264119A0F3E80EFA7DCC7D0995EF8A8E15A3553EAF04A47BCFEEE48A477A98E81C39782AF39850687A9C9195D0E92526FA9FB23D80D3461E27F19B61A91A454DBD944635DBEE489258B8EE1EBBAE351B7C93C0C99720A9FB59E8DE18BCE63C09CCBB0E4AF0FCB2B9FC1925EE0501F6FBDFB039A743E80A6FD7F41DF299EE82FF8B2C54EB8B8F643CDAFD7A046AD994897A90AA298FDAFB62F12E38D8DDEB665FA23D80D3461E27F0DD47EF4B95D8D8EE4A336E2F7611E3D7A84EBD71F62E1E2F568D57A102C8E05856C6FA0FBD01D1832FD227A4F74438B21DBD177E22194A8D0068E196B88D6AB8DF4B95AA162F51F50BFDD56741C7A52CCD475C82E63C32F5A6E44ABEE5B51F9A39E285FF10BE32D0B1BE2B31C2F0BBB81264CFCAF82642029B9504FF574FBF64DAC59B30A7BF6FF826D5BAFC2922E1FD23B578543E60FF04AC136F8A4D1728CFEE91E9A0FDD86E6DF2FC33EB7A798BFFE3CBEF87632CAD618828C453B214B916EC856B6332C19EBCAF8B0333E6EB8041FD6998C12E51B60E7FE336AC922262646BD61F1674DD1D4B01B68C2C4FF02526B20BE7C6B9887296A2337B5A19B9B1B66CC9881BBEED1B8E5F110EBD73F44AD3A4351F3AB85F8AAF9326429DA0EE3163CC5B920E04122B0EBD213ECBE1C8E0DE762B1F040286AB49C034BB6CFE05C4CC68FD9EAC1296F2B54FE7C322CCE1FA2FC3BF5D5F680EBB7DC14113916659974795E0676034D98F89F446212C242C21519F935EED1A3268836DCA236747BF9C6E18E3B102DC75B77C4A072F58178E7D3E168D57B170ABD3D02E53FF91E63171E817B0470DA370AC77D81B1ABAEE2C3C6F351E9E31F50ADD11CD46CB9185D87FD82AF9ACE47E69C1FE3CE8358C42424CBED8CAF76BF509E9780DD401326FE1B416DF35BA65F64780462A2C43494A1225FB0FFE5B01B3CEE0563EAB465A8F5656B7878262158C28F9F8A078DD6EB5EC0F7130EA156CB1F51F7BB95A8D37A32DAF55984B76BF444FB811BF0D69793E05AB11FBE6CB904AD3AAFC3576D3760D98E78F418F28B907830BE6DFF0362E2E45E0929888DFBED2D6C7F16760353434F07D3FF4F996FC2C45F0565CFD6F44B2D8FFC3D0A4E906EDE7214877EB98D864D06C898B00CD239BD8E3C453EC0D84947B166C771DC1612064A36276E025396DC47CD363F214BBE6EB0A4AF8D6CF9EBC2E2F0162C993E46BA3C2D50AAD264346E7D00BD46DF44AF91E7F166D5C16296BE8B93677D10C59D6BA261F925F0FFC42C25EC06FE11EC91D136CCDE751326FE4E50E839394202E8302EE12D5FB903878EDE45D58FDAC129E37BC8E1FA35B2E4A823680C4BC64AA85C6D307217AB8D5CC59AE2938693D069E80EBC596B3A0ABE35025F345986022548C8BAC898EF3B94AE3A0D452B8F47B5064BD0B4F351B8E46F2FD7AAA0FC9B5F235AB42B1D7F508644E404519A11F13FB9910913FF095277EEB4D0F49BF63C7FF0C8077B0F1DC7D51B3E983E671B1C9C45AB59DE43C1626DE190E96BE4C8DD0EB95C3B21834B3D9428F73DDEAE360E1F7D3D07B5BF5D8946DD77E0B33607F179D30D68D47A2D7A0E3A8CF6030EA2FB84AB18BB32146D465D44856A73F1DAFB2361C9FC0EF68AD9CBDFAD888EE5EF5CC4213C8CFE8BE57D19856437D08489FF16D813667E9837322A140989D1EA33F77C9DE9C1EDCBD8B4750F464FDB8FE26FF645AB9E6B84681391AD481B54FC540894FE2338B87C265AF173585CBE14D41413F31338BA7E83373F1D8666FD4FA1D5807DE83BE51A86CDF7C2B435DE98BEF231064CB92E63C8B5A8506506F2156F8F4AEFB542248784A27DBDEF792BD3546B654DBE9721A086DD401326D21A7F760E8204E46F51F093F864434C4C1C1E79F962FB8ECD98BD681D0A576C83D6FD0EA0DC8723D1B2D74E7CD468390ABC3D1CA3E63F42A9AA33D1B2DF31546BB202551BADC7E7EDB7E3EB5EBB50A3ED2654ABBB1C559BAD10429E40C58FA7A1568B79F8B8C56238E46B27E3C51A702DD5498D0D57AE3FA23690AB0F0527255A3FBD687C463FCDC788264CA405484A3D4BAABE82961C87E818E333F8FC35DEF0881884852663DF1E370C183901AF556D886FFB6F11026DC4176DB6A06ABDE568D6C70D4DFB5D429137A6A36EBBAD285B650E6A36DF87AF3A6EC5C7CDD6A354B51FF145FBCD42CA2368FCDD26BC557D321AF638821255870AF1AA217BDEBA6A1DD192A512CA56AA8308B184F92A555C5C98F02F01BE3EFCFCA2B189C024A2897F0CE21244DB09F82942FE8027C170FE2E214DD0B0087FC425F2474293B160D16A3C094841E72E1361C9501C794A36408ED23D50E5AB9568D6F510BE68BE09B55BEE42ADD687D0A0EB1934EA7A53F9EF375A831ACDF68BBF05FD66DEC327AD0EA05E8B0D78B7DE62642CD257CC58315D33BC832A5F8E42A67CF560495718ABB69F44B814254E689802C31C8E8E121B5599A6318A887FC524D5B01B68C2C4FF15484042E45BA896A28E196EBCDF97A8B4113F2D71F2AC1B3C1E06E2AD77EB225B4EFECE4445547C6FA0F8F550B0CC4038656E826CB99BA176C30528F5F608147D630CBE692B5AB0FE627CDE64295EFB60345EAF310125DF1D014BE64670CADB51D2BE85CC596AE195C2EDF1EEE7CCAB1032A62F8549F3B7E1EA5D5FB93310991029148C533B6914096369A7DA1FCBBE0CEC069A3091D6D0E3439AA2D42E04BFAEC65F67E217B9F5753FFF00B5B773EA8C9FD1A6D300D15E059125670564CA5C158E4E9FA372D531B038892969A9827496D7E094F175581CDE469B36F345B3158363FA3790BFC01770C850140EE9CB21A3730D895B5AAE493C97CA2859B183A47B15E9D31746E63C6F61F8A455EABE2111C988951B47C5C5AAFBC78BC56C7CADDFFEF3BC2CEC069A30F1DF008EB9F446EA8404117FD140BEBEA158B36E2FB6ED390D8B631ECC5FBA059172A9F6D77D90CBB50E5C72D614A97E15DBB75D51BF29CA8F398D1CBF58C89913AE453E8557501CC225737F19E2ED3FEA2E796443CDDA8370E56638F86999479EB1A8D77888103C1FA64C99AB7EF3D0373C14111149080C0957244CE0FE399B32D24CD5E77F1576034D98486B50A0A979E8EB6312D01074714288870F7CB168E146AC5A735008941FDF761C882809BFF9C81F51C2108B7379C16B88169E244978A74E9DC4984D54233A8BA333221343D4799D7A75853A517224E1969C722F35EF82CAEF7DA0BE6B432BB863E75E88917C48F263177EE104A95C4B11AD1887F8945F89C7DF36E4C7A8F4F95F85DDC0BF03ACC83F13F657C07C7E2B2FFDFB02DA8F8F1753C2CE075DFF2CF8AB3DB6BFDCC3DF45D7C71AA97F62EBB760AFDC56417B56377A963075F89F814EABA1F3487DFC7B481DCF5EBAD465E279EA78BF57167BE02CA870474CBE24314783D5AFF5729922214E48192F1AEC31B06EF5492C597442912763E6A2088D4DC0C9F3EE8814E2F0CBDA4E4E459037F797F8F8E30170C95E52CC4D674383497A8BC5458EA3306BCE526474C92D2414CD28EAB27587CE8811720D1CB840E2B8C2CF2F44CDCE262609519362E1F5C817A1112FEE71B53DE7B3112FD356A96137F0AFE08F2A9A85FC4F0ACA07FFADF4A92B89F833E47BD9F29070B644D40454BFA7670DFBBF807E8E97157E7B489DE6AFEEA1D46958267D4CDFB6CE796E9BB7FAF092987DC6EFCB4B7B0B21E26460E6ED158CFDBBDDD1B3EB0C647FA5928C078B62E090C94AA355A95E0B4F42F859FB3891E6028257858079F05583F6884B49425C52329A34EE206345175CB8F81071C9B1F07818801849DCB17B07FCB47083C44B907485043995E68D8EA286337E137FE7CEDD4242A871AAED76BA97C19F9133BB817F37EC15C4B601FE2EBC2CB15E06F6CA9BFAB7F5787F4D06C6E7B13ED75BB1EC4197DB56306D49657BFCDF02DB32DB86A57E4EDB36B17DBED4E0EF44F0BBA35CAE8889E3FB11623C4645C0FDAE17D6AFD98F0963B7A040DECFE060298D4C994A2B12B256468C1B876DBB0F22213902A5CB56C2ECD97B70F5BA9032A305E55EAF84B08814F5D1A86D3B4F8BE64C8473E68222F5D955FA3BF77CE0E52304131334B34B31D4A8FE3562A3A5CD622370F7D645E5474772E3C08BE525523F9BEDF9CBC26EE05F051B41FF0E1C85873E7B11420BE56F1598E95287DB6B3486FD563E7F4660FF6A65D94BA7A6B05385D9C6B33DB61757433FA7ED33D90AB4EDF16FE59F1A7F36DEEFE1CFA4B3D7467F06B69A563DB7682AEE96A189C935C2D0F0208C9F3005A74EDEC0C17D374552DF846B2E7ED6FE552C5B765A349D8C19BD83459B892E9463E63478D00AECDA734F7463226E3D0854CB0D0CEFD96B2CAEDD8847585C022E5F8BC0D9F3DE88967BCE9EB70EC3464D53710E1E38ABB4E1B12347150191188DE0405FF5E331FCD96DFDE2EF5FADCB3F82DDC0FF4B6892D986F1E10986474646AA29ED274F9EE0C18307E00F89DCB87103972E5DC2C58B1771F5EA555CBF7E5DF9D7AE5DC3EDDBB7D575E2CA952BB87CF9B2BACEE35BB76E29FFE6CD9B387FFE3C2E5CB880B367CF3E3B261897F9302EE3313EC3989FBE077DDE8771F43D6DE3329C79310DC3E9EB743C6799745974389F876999973ED6CF409FE74CC763A6D5D73574DEBA4CBA6EE833BF73E7CEA9F43CA7CF38CC836978CCFB301E7D7D4F82D7198F612C1BD3D3D7F7E73D74DD69F02D79A6D379EBB84CC75F6462D8B5EB1771F8F041AC5CBD0A93A64CC6864D1BD5F86EF5EA2322A56590376F4364CA581B6FBEDD49D202F7BC6224DC151687ECE8D87514FC9F02E3276F814BB66AB8EF25A6A4F4C9C74E87A24BB7851227275E7BA3116EDF05C245D9DEF148C4A021B3C4844D8F4CA209B7EDDA4B0E22E829BFC226B2279D41526C24BCEEBBE369A09F5CF95516F9C944224E481D1B4B856310537526FF0149ED06FE27B0258D2DA1D8ABFF5161B96EE4E7E7074F4F4F787979C1DBDB5BF9241C7D5F5F5FF8FBFB23222242F54ED4A2FA23417C0F8DCEFAF5AC67BE76FC6C02E3B11C3C667A3AAB79F92CDCAA5595D33F6649A7E3EB30C6E731D3D0D127F4F3F3587FAE81B0D6C5B3344CCFEB8CABEFC938BCA63B237D2F7D6E9B0F9D6D59E9185FA7D1BE76D67A7FE6F4736BA77B7BDE834EDF2F759E8CC36BBA3ED8316AA7D3EA343A1D1DAF314D78387F2FD0288BED75FEB2AEF1EBBD897812F0149132883B77E13E4A96FC12CE4EEF2343A66F50BC642F91D81A7074AE895C62A6E6CAF7095C0B7EAAD609D3397E0407A7BA72FD6D585E29A2F6855A325443FE224D9023D73772BD062C8E95E194A132D239BC01A74C45D5D245E3265D1023E4F3F6F385DF137F24C6CBD8342E5E48780F01BE3ED0BFDC44E2B16C3CB607B627DBC3FA6C76E3FC1EEC06FE15E806628188DF2B10D53CB59A8F8F8FD268ECB5D9FB3E7CF8F085866563D1D78D672B7CBA218DEB8610582B4BAE29EF59381DCBC7F48C4F12303DEF479F93048CC9318ADED1111D2BE648423C22A3A314181E9F68FCDE5D5048B08ACB7846CA5FC9A885FCB784948ECFC38E47A761D96C9F91613A2ECF099EB36EE9F47D6CF3A5A0EB7BEBFCE8D3B1F3A253CF2AE1FA5C3BA663B8CEDF6A4A3FCB9F4E979365D1F7D1F9F01AD3E8F8CC4B93958ECFCA74AC77E6C1F4B46A3809C23205053E45BC0CD6B844C71CC2A5EA1CD30BA1C4246DD2683E2CE91BC321530B94AD301A39F3B793F0EAC89AAB1E4A97EB8E32AFF641966C6D91A7706BE42DD1020ED96AA278C55670CED65448FA0DCA54E8863C79BA235FA12F657C591FAF55682324CD8D8F6A344748B874726C6F69451EB18CFC3E69807FA01CFF355269E8FA679EA9AFA586DDC0BF0BBAC17585F3175AF9693B9A23D47AD46EEC21B5B0D836B4EE61784E302F3A36AEAD30B161496A7FFF00B513FFC9934045C6A8A818899322D7C2258E21343A5FA6675A9E878484289F44E34F69053C0DC4D3E02045347E9056EF7724D948565E23F91E4B6FA9C9AAE2D994393838581D3F7D2AF69238969F82C8B2123A8CE5D669583F8CA3B5067DC6A570EB73C665B9794C41D675A749C873E6C973A6637AE6C938ECF478CCCE81A0F6E17D35989EF1749EFABA2E932616D3B20C7AB74B6020EBDB980BE031EFA9E3B22C3C66BB320E1DD36A12337F7D9D9FB950EBE4C2426FEF4064CD56080E8EC5912FDF57C895BD297215EC03975C5DE098A933CA551C85222507206BEE16A2E15AA2ECABA391C3B52F7217EE861CC59AC2B56C4358B2D58673AE96C898A3355C0B7747D162FDC414AD8F42459AC3D1A91A3EF8E85B24C8BDD84F3F0D9367957FEE9EF7D49B1561A151888D11CBC6104B4B4CA22AAF92695A5A942F8244D5E073E8381A0C635D12A9AFA586DDC0DF43EA1BDA9EEB1BEB735638C9F7F8F1634540362A1B848242A77B4F7D6E4DFBCCE9EB86138D9024C219A57F023919511191EAD77654172A5970513620F0BE8ACB46560B50AC43F5DE0A7B78E9B125203A86D3D3D4662208D2FA71D4A229ECD98598622231B3FBF7EF234448CC1245C87821F0A9AFBACE77E0B8BE959CC2CFB853B812101119AC7CAE3D315CBFA243C18AE1EA32FFE4196D9F87824CC772329C424BA705D636BED6ACB65A8A82AE9D4DBDAB6BBAF1796C6D9F67F1D929B2F3A1B94FC736611CDE57A7A523A178CE72E8F6D16565796CF3E6B9EEAC5453487C76B28F1E3D36DA46409DC33542F5442A2C413AAAC7488C8B44B8746EAA7D243BEE6E2953EA4BA4732A8BF7ABF54771FE62AFA51E32E46F89D76B8C87936B6B5832378663AE7628FDEE38E42EDE5B4CCCFA12A729DE7E77A290AD368A96EE00971C5FA35C85EE7048FF05B2E76A813225BF47CE1CA2212D6F216FBEF7D4672E580C8E53B9D4B5679F314EDCBB7F1F0E1E3E040F314DFD039E8866964E27827B718C71209F8DBEF5D99FF1E03F85DD407BB0776325ECD663928E7118C6466743B231E8B3E1A925D81BB2C765C3F16118976998966918CE0765B8AD00D0710783B1BE6484F98BE67BECE38730197DFBC948FDCE1D77F53358474EEC96264FC2852BD71111158E2B176FC0CFD70B014F1EE382DB69F83CF6C495AB17E47E31387CF8B0CAEFE4C9934896B1C1DD5B97E55CCCAE2819A7F806A9817A7252AC943D14972F5E42F0D3209C3F7B0E8F3CBD1016128A0BE7DDD498E2D2858BAA4C070E1C50F91D3A7440043C021E1EF7A5E388C79DDBF7D51897F5C1890A3A4E56B00E4E9F3EADCE8F1E3DAAEA81931DD4461C2B932C240A274428F82C27EB8F160589C30913E6CBCE6EDFBE7D2ACEA953A754BEBC0F35324D7FD6233B42A6610740701840625353B25C8CC7B6623A96E3C489132A9F3B77EE3C1BA37B7878A8B2EA3273528B7139C145EBE0AE87BBB493B45B4A3C1E7A7AE0C143DE3B51EE13A5AEDD757F201D81987D4F82557BEEDDBB557249C0D1238755BCA781A142C23A22954590335743947D5D4C48C7AF51AA7C7F58323511F2B555047478A52D32E5E90CC7575A235B81AE28F7CE68E476ED2024AC83CC59BF913124BFD4FD81E4F39ED280050A354786F4D5E1E4541965CBD651FB44493ACA00EF7FF3A6D4AF1CF119541F61053B165A402CFBC58B6E52B727B079F3466CD9B249CABE1B070FEE5761F43921C5492FB609875AAC576D75897B8E37F6603730354816364AEAF0D4D0E6101BF9EEDDBBCAD784D23D287DE6459F8DA8C3E9B4B6E47586F19C04255829D45EE1D131EAA791AFDFF2C089D317F1C82F0817AFBA63DFE1FDB8FFC8077B8EEE854F700436ED3A824701413877E9061E3C7687D7233F6CDB6E2CCE9E397B41F5CE8B16AF5063C083878EAAFCF9E6756810CB2AFDB3984AEAF725253E7BED1B57EFE1D1C300ECDB7D14017EA22945C19C3E710909A271F7EF39A6BE1CF6E3FC2588088FC5A64D5B94E01E3F7E5CD501494632910C3B76EC5064DAB2658BF2D7AC59A3EA6CC99225EA39972F5FAE88C6C6641C76606BD7AE559DD9D6AD5B95A6FEE5975F949571F0E04135B666FC65CB963D8BCBFBECDCB953919DC2C1BAE44417EB9582419FF7667B312D6733F7EF97FA93BC8F1D3BA63A818D1B37AA7B90FCEC1C4836765C6C93952B57AAF6E23D49E255AB5629C1BDFFF0817A4F90DA2F223244EA385A3A57A54DE0EEE12975E18702054AA0719366D21EF7B07DC706B13062E4D997A919D2AA1F50639546DDAF7F46C1A2AD902E435364716D84C2657BC3B5645F38646D852A9FCE81C5B901DEA8320A0E2E5FC9F586627ED6469972CD847C15B1799B07962C3F8F39F30EA2753BD1A0CEE584A025E0E8501CE5CAD5109353E48C3629BB6BB16044F74B7B47E1A1972756AC5A89736EE7D58CEDAC39B33165DA5474EDDE0D63C78FC394A9133068707F0C1B3E08A3C70C57C70C5BBA6C21A6CF9882D9B36763DAB4699830610266CE9CA9EA9F9D9BD59AB1CB175BD80D4C8DDF62B59540EA984240E1A389C58664239364EC956DB5A126269D1E7F5010D9C03CE7B1229E351EC17C4840DE2D2651CCB828192FC9F15DCF00ACDEB257ED3364DF76F8F4650425482FEE138DA3177CE12B32B079CF298427C7E3C0F1DB3879F11E0224ECE6FD00444ABF3266F202F59DCB136EB7B06DEF75444AB1761E3C0D8F878938774EC680922FC704DB361DC6E5AB01D263023F2FDA8D0B97FC70E9CA134C9BBE16816255DDBC1D8ADE3DC6205A887BCFDD4799A4EC64D8D8D131E14AD8AC1D99727C563A3E9B11CF30FBE874DDB00EE858C7BAA362FDD1E9BC582FDAE9F83A6F3ADDA1B12D781FC6E131C309A6677C9D3F7D5DDFDAF19869B46339B545A3CBA33BD49414E9B0C5DCE7C27CA4D87E2C26EBE2F62D7FE4CD5F1ACECEB9D0B1632FA90F767B09088F0A466C1C3B061120879CC894F54D91C84F91255B6B386468871C053AA140993EC89CB725D2676B824265BAA340C98E28FB6657589CDE45A56AA2052D459135AFA44BEF82C2C55F83FB033FA97591AD58E95863256FB953606880582B2771EEEC25D15C17B166ED0ACC9D331D03BEEF8D01FD7A62F4F02118336EAC428F5E3D3174F83045C4454B1663CDBAB558BE720596AD588CCD5B37282C5AB2409D2F5EFA33A6CF9CAACE690DD1CCA59C8B7BC6115DD7B661F66037D0166C1C563E616D3015CECCAD8DFEEC9C0DCD4621B4409058DA318CF9D80A191BDE5A50D598BCAE8581D0C7BC336345C6F18D34C02F340E8B576F43D7FEA370EBA134A8847DD5F83BEC3F730D4B36BA61F2BCC318F9C33AB4EA32163E9171A8DB7A3486CF588B5E2397A3FFB885D877EE3E068C5B8A1091B9290BB6A0EBF0E9B8740FE83E6809BE1F3517A3A72CC46DF738DCB81522E38C2C58BAFA14CE5F09458BB6A351E1ED06A8F86E63D4A9DF178D5B0E43BE221FA154F1CAD8BEE508D46CB7E4C967E55E45A552059A70146A0D1DA69F518F1B79ACEB44D723C3E8747D9204BA2E757DF21AF3E239D3E9343C675CDDD1F1BEDA44D524647C86333D1DD3328DCE83E1BABDE8184EE8347C5F9026A8B120CFFC80F11316C2215D4938A67B5588964334CE4E21A98CE383C3D4B83B52D413274B3EFBAC95486209942EFF2D0A16EE83E2A547225B9E01628E368373EEF6C894EF5B64CAD102D9C4B7387C8CF4596AA0C617BDA52396CE401EDD3030C5524A89C5AAF52BB17EE31ACC983D154386F715428DC7A8B17DD1A143078C18361C13278CC3C811C3943F77F61CFCFCD342AC5ABA5269F76DDBB661F5EAD5D8B06183C2A64D9BB074E952CC9D3B57CABE54916FCEBC99D219FF08B78B67C56C7DA2361E887B8133A9C3FE0876036DC14C29146C141DC686D52A97D738AED0E3072D5C4CA785880D65DBA00CD78DAC1BD6562018A6C3B5E37C0B45933FF811119B8CA3E7AE61E4E47968DB7530CEDDF4468C24AFDFB4274225D2F0891B307ED641CC5B711C93E6EDC61369A9CF9B8FC4BA5F6EE2FB895BB1E9E85D6C3C7C134D3B4D46A0A49B30772B7E5C73065B8F5E43DD6FFB60EF116FACDF7A193152E44A55F96E9B2B6AD4EE8449B33763FA4F3BF176B5A6F8E88B0ED2437F8C2A9F7C2B9DC10C64CEE8AA261A6299481CC71F7CAB9C64E4E40DAD022DBC1AFA99753D587B535507ACD7D475A0EB4DFB24167DC623C1988F26A5AE4786E9735DE774DAA7D369581E5A302C07C7A9EC2C38D6E1308363500AE6F6EDDB95F93575EA54F4E8D103FDFAF5533E3F6B3F71E2784C9932099DBBF4407AE7DC526FF9913BD70770B0BC85E2252A4B3D48FD08BC1E3F51DD1377C4581CB8E5AC0C0A956C2E1D5E03B8E468895CAE23E092BB0D3264EB86570A7540865CED91396767B816EE29E884BC859B4B9A37E0ED2F56CDA49FF0C3AC4572CF6EE8D77F00868F1C81A93FD0441C8731634760B168ABD56B9663E5F215D8BB7B0F0E1F3C849DDB7761FBD61D58B37A0356AD5C87E5CBD6A8675BBF7E3D162E5CA84C6F9ADB0B162C50A63EC3F7ECD9A5361C04063E919253866961C4485D85499D71FD53C9FA33CEE8E33F0BBB81A9F17B19738CB16EDD3AD5401C9370B04A01A1633A2D241CA368E160B86E7CEDB377A6A0302EE391D05AE8749C8828116CF1FD9E8663FABCA5982C0D3066EACFA2FD56E38CDB6D7CDDE03BD53B7E58AB3D96AEBF809357023075FE2E314DA5779EBB135E22E75D07FE8CF9ABF761E6E26D98B5E0B0FAEA73E75E53B171E72FF07D0A3C0906A6CF5E82068DDAC1CF3F11BD7A8E10530A98FBE31A8C9D300F5DBA0F559D41DDFA6DF1F3E24DA2359F488F3B1B2B57AC33A6DFC5513BD04C0B0B0B7946263D2BAA9F8975C47A202134F89CAC078EBB48088E0B6D09A63B395B12D191B40CD35A549B92BAEED809E80920B61177BB70670DC7837BF6EC5182367FFE7CFCFCF3CF4A33906843870E45F7EEDDD1B76F5F74E9D20543860CC1D8B163317AF4687CFFFDF7CAEFDCB9B3BADEB2654B0C1B325CC55FBA74313C1F7989699884C9D316CB18AD0CB2E77C5F242D171E7A46E2C4A96BAA0DF9E68343C67C78F7BD6F515248F84DC395F8AAC15264C8D445B45F7364C8DA09398AB6856BB141C8576210B2E6EE01D722BD91CEB9BE8CF93E44B35653E0762508A7DCEE226BCE7CD2190CC6983153B06FFF41ECDC6D9086B278F0C011ECD8BE57C6BCEB15C16842AE5CB95A9E7511B66CDDAEE2AFDFB0092B56AC50E3748EBF39F6663D71430927AAD8165C1AB336A5D4333BCD28B9E6294AE8A675C9EC57226AB03DAC6DF25CB83DD80DFC2D5070B40DCC63167AD8B061EABD2F3646CD9A35951A671C0A805ED32228544C43A1602FCBF124858C712844DA2CD3BD367DA6A3CFBC38ABC6F3B0F0481C3D711623274CC78E03A7B062E301F4193259046803FA0F9C005F317B464E5A80FB7EC0B28D4750BFE5401CB970138DDA0C408F21A33078D4628409AF3DBC4250B0D007E8F05D6F8C1BB744A41BE8DDEB7B74E9DC131F7FF425428344E8D9FF082243E49929FB8287F73D951F1B2D99B061E4D8CFC75F959333A5444C6C842A2F9F592D0A33BE90888DC2789A309A586C443E1B9F9B3EEB493BD69776BCCEFA62BE7AB693F5C809214ECA70C694E3140AE0DEBD7B71E4C8116CDEBC59819D25CDAD3973E628ED458C1C39127DFAF451C422A968BE11D47023468C50717EF8E107158FC49B32650A060C18804993262981E6CC2A9D22BED4455818654386288951D8B86D93988A5277229F59B2BF0A47A7FCF07E2C431679746AC21CF98A215D8642A8557B10EAD4992692D814F90B0FC6879FCC15EDF83D2C2E7590B3E077C890A31D1CB37445C6DC6D91C5B5355CF23444B172A2119DCA20523A448A3FD7005BB7EB0667975750BA6C09142F951F454BE4C507D52AA359B366E8D777107AF6EC8E162D9AA176EDDAF8A6417D0C1E3A04C74F1E9394D25925FF6A92D3B18DE8D80E0CE7F371F63B243802972F5DC763AA6279B6186E10E743DA70846D696DBFE7B8F34778218085D019D9CB9482C1193D9A2BBAE7651C2D5CEC4DE818C69E843E058864A2633C12509F6BB2325FD60517DF25BAA493FFF88C023E2C0F232239232795CF468F16534B8EF9F226C106894C4C51448C10E18F95CC0285DC2C155F873976CE4D8D2D798D4B7BB42099861B81A3ACBB6F588E5F272038C65287628E042199D5C03471C9080D11B35C8EEF7978223020441D8784181D09177AD95BF299ADE6BBCA97E79A78FA9C8EF5C38570BDE9416B428224633D935834FFB909427762249F9E9DD624E42CEDBC79F3947945CDA667F2089268F2E4C9CAE4E24C2D7DCEECEDDAB54B918A69CF9C39A3B42509C6B0DDBB772B6D496DC1995FDE8F8E65B76D533EA7125E7924AEEDAA46629B485DA936956815DE7C1F37EE3C566F3A64C9515148C889994A68D87CAE90EA13942C3F12AFE4EF8E2A9FCAB98C0DF99BF5D90AB545FA5C0D90A5601364CADB07CEB9BA2257A1EEA858793832B87C0EA78C55D0B5FB1C346F3E4234E043FCB46023BEF9A6019A376D866E9DFBE0BB0EBDD0A85123D4AAF3A15214AD5BB756339A5416EC94681570E9473F83964BCA35DB826DC23AE76C327D5A14DA92A11CD317F78C1B3ADCCA8567E17F067603352838B62A9742CA42521838B54DC706A0D9C342F321F8005AC8B4E0310E7B6F9EF3C1399EE4143BC3D8F8CC6B8398073E3E7ED2E8ABA457BF8B6D5B77E1F8B1D3387DEA3C366DDC8EDB77DCB15CAE711FE2FACDDBE0FED01BA7CE5FC269B7CB3268F7C5EE83FBA5F78DC5A215CB8484F16A32E0DAEDABD22BC72120E409F61CDA27A44C865FD0136CD9B50D9EBE8FB07CED4A5CBD7D1DDBF6EC506B62EC443856A01B376E8222D48F3F2E90E74AC0C50B57B164F10A65EAF03B9A2CD7BAB512571E75F9B2D58A88AB57AF5571B76C91FCA5E1989F166C3E27970068CA739333EF4772B19139CDAD374593741A8C4FAD46ED4652703983DA8DE420D148282E8710241409C3353EDE8FF10E1D3AF4EC3A972748364E48701944138D79F39A3EE73D983F8FB974C1B121EFC3745CBEE01084612C2BEFC97664189FEFD001310BB7EF90DE3609E3C68C97E1883F2E5EBA02FFA74170F70C866F0050EBCBDEE8D36F0D2ABCDE13F90AB6C5378D16217BEE96C85DB80B3AF63C88726F8D84C32B2D9021676B642DD81EF9CAF640D6A2ED90BD443738E66E058B733D357BEA94A50E0A156F26125C11D9727E287E4964CA5C041D3B7E87BE7D7A61C4D031183D62A268F3D19834750C162D5AA4CA4F59A3FCD2E4A4F5C0BAD7D6189502950C976B18AE655A138B442328CFE401E599C75A61D982F15F0676033578334D44168605A5EDCCDE9A64A350B121E8188F2463AFC20763AF4D473395BD0D2B80856621A9FD98371F92C24882EFD9234411DB7BDFDE436A61FEFAB5DBF093419BBF5F10CE9EB9A8B4E1A6CD5B5567BB5906DB346F0E1D3B853317AEE0915F2056AC5D8EA8F84819B7CD477C928C33059E5E77C1DF4E8F4F9032C484E2C9531F84463CC5BE83BB90901C83D3E78E2330D80F17AF9C539A85CF45739B0DC58E816EEDDAF5CAD7E7D4D89BA51CD498E7CF5F50C423013986983C79AA3C639208F24635BE2029380EA3E0927C24168949A1A786619DB03EA821E95887BA61AD8DAFAEF198F5CA72B19CCC830422694806129EC75CFBA3A6E3040389440252EB91688CCF4E863EC7850CD7E343CE142E5EBC588D9128B0D3A74F57DA539BB0344F19F6E38F3FAA3C783F6A71FA94036AE380007F848506E3C8E15F70FDD2359C397556957FE6BC196289F01F50E79B9E2852AC3EF2E76F83B2E5068BF4D5C39011676171A8094BE6CFD557B8BF68381705CA7687256B0364C8DB0AE9723783738156C850B0112CD9BF46F14A03848C5F2347813628F3464F142FD35A346A15942A594FF22B005F9F0019AF2FC1944993317BE63C5C928E2024ECA9D2665418ECA428B7D4EE2426EB8CF54002B23D526B33B6873EE635826D66EB6B42A64EFB3278214067A66FA0CFF9201426FA24164D28EB3545506D86B1A7610109C661AFC26B241BE3B3E1F4343A858CC24FA7C652E238CEA0291A111EA37C9A84FC641DD79BF871E56811789AA6FC5D3AA6088D34D617D5DBDC6A6B99E8BD9478C4C64488091988C8881085A741FEF07FF258889C8047DE0FE0E7EFADE2332EC348706E1808090B553ECF35029F1AE3344F4FA3D3A1D9ACF7B1721B17412D1E20DA7AE3C6CD42160FB523858DCD8E8A13553CA7F6A326A146A200D0A4648744C7BA619DD0B1EED849B17E3449B5E335C6A3CFB4EC1849740A137D7624D46484364319C66BD488D45EBC3709481396C4E32602928D33A11C43328CD7D961D07CA376D026BBBE2F1DDB91568D719E281DE763E3455AA9B4A70141B874E5B2B2422293A351B9466D58D21747EE027591BF6027E476ED8ADC79BF43D937FAE1D5B785782EEF0BC1AAA059879F91A7541B58B27D8DBCAF4A788E86B0E46C882CC55B2047E9F662B6D645DE92BDC56F84EC795BE2B5377BC092EE3DF08B6D376E483BB1C1E4AE11E1C108F07F221DDE71EC3BB057696C3E073B28761C3C6667A2E55B83CFA78FAD2454CFACCFD92EEC287567C96B3A3C755E2F8317027803DB1BEB1B916CAC784D3A0A037B18AA77361867D5DAB76FAF1A975A8ED7D8C3303F0A137B219A6B144CF6ECD4188C43B252835273B262D8A81C9371D33649C96D4F1C93F10B5AB11C034A03736F283524CD54FA4F83846CE273E37764B8905CC879CFFD3EBCEE79223C280CFEDE7EF0F632F63DFA3EF653132D4181C1EA472D3D1F78C1E3EE3D84868721363E4E6DFEE6EB30F71F78AAFCBD8464A7CF9C1302F1BDC02B22D8EB9406A4A6A4094A509BF3930ADC51E3EE7E4F2D1A532B7116921A84DA8A84D09A892624B5955EF2A1A340EB3108EB80BE6E60FAAC4386310EA11D77D690701CF3503B123C2791784F12949A98E4A7D6E375129153F3D48024DEAC59B35439B5094A4DCE0E558F5DD94E6C3376246C779683ED4A47EB86200903452B72EA3824889BDE13C5EA90B17374225A77EE054B8662C853A416D2397F2E266937E474ED09D7823DF0EA9B03F1D6FB8350ED9391A8D7743E2A571F0BC7AC8D902E6B53191FB6468EE23D90B76C3F314D3BCA58B12D7215ED8A02257BA1F41BFDE12C64E5DED1A2651AA83122BF581218108A98E870F5C3300FEE7BA8AD67A7CE9C561D8ACD82FB33677D8E67B24F674BC6DF2217E3D8129169FF5622DA66A66FC68A674390300C231979CE46A186A3E6A46663614836168CE16C384D32128EE928706C5836327D86316DA8980FD4505CA7E1B43F7D9ABA4CC7B82420112E24F291B107C9C770968DC242EDC43DA16142DA90A07005AF7BDE78F2381081BE41080D96320484C0EBE163C44449850B29E363931015110B7FDF40A5A968F2517319B38EFBC5AC3C21C2BB54999A972F5F152D735AEEC937481EAB4E82662A4D53FA7A173EC94AED4813885A8863350A3841F291889CC1E431CD21DDC3B273633DB0BE749D500BE97342CF46B3DE59C7F459569A991C4B724CC84E91F7A5E071AC4352F19E34C3B8CD8EF7264969325353321EC3F50BBEAC4BDE976DAADB956124BF2626C3794C02B24CF49F4A7BD10A498889C4AE9DDBD59B0B62BCA041B37E42C232C890BD0EB2BA3687934B73E4CADB07995FE90A47E7B6C89AB32372E5170D99BF3B0A14ED2BDAAD319C32B64191528351ACEC60A4CBD80C0E999A8AB6AC0BC72CF551FCB5EEE2D7428EFCB59125D78770C9F116E62FDEAF3E7B78F1B2879AD5BC7AE5920C697C10F084D69BD2E44A9E5987749A40DA598F5F907F0D4D327BD708A6B7CDE3AFC06EA086BE01859D3D2F4D29DD739364145A8651DB919814126A3AA6A13664AF4A0DC8F83C661CA667C3B1B149329E33EE236F0F8447048926BA239A48D23EBC8BC73E9ECA84F4F57B84C7FE81B82F5A8D7E809081661F894A9F3DB1AFF4C8FEFEBE52167743D306087945FBD144E2F2024D11968D95C9F2526069BE9130D4021450CE32D23CE37AD99831E3307AF45831D9662852321D3B176A26FAD68A573EA15F44A666D6D62489A235197B666A4692821A499BA614685BD251D009DD01D9FA8CC3672681F90CAC6F96858E9D08B51C9F85EB657C068EEFB8EC3071E2443563C865092E45D0F4A499CA713CDB82F76719A98999270596EDC2F662BBF15E2C139F87C72C0BCBC0A10AE3312DB5E0037721B2EF43B16002A4534DC18041B3E0E0F48E48D98728FDFA68314D9BA0F8AB4351B0447FF56EA1934B2BE42FD617798BF446CEBC5D51A2EC10947B7D241C3334443AA73A489FE94B5478A333CABFD109C54A7540F63CA201D371B6B5B88C0B0BA975C82E3D06AB4F6690229C14A28B08B3CEDC8A59CCA1873825CFECBCD88E24163B133E0FCFADA6F673B2AF49C7343A8C30DADAC8C32A03CFA5FBABB01B48E81BF2983725A128B4EC3929D46C00C6614392946C306A43C6E1B8458F87748392B46C3CC6D3F1D9A80C57B357F7AEC2E3FE3521DF7D35C962F81EF0B8774BF977EF7B82BF81E729E47A286335928A82E4F3F811BC3C85F03ED219F83FC4B59B1770F3D6153129EF8BE6F4523DE3C30762164B1EDE8F1F60F98A45983E6332BAF7F80EC3860FC4F7037AA34BD70E6A319AD3DA83070F566B68A3468DC1F0E1233174E870195F9C7B4642361A05970D492DC63AA2F092807AC983E34786313E1DD372928544A109498D4422D28467BDB2DE28D4AC17821D13059F3EC797F419879D0EEB928465DEAC3B8EED7AF6ECA9CA4EADCB730E13060D1AA426573826629BB0BE481896579397ED4772B3A3E47D983FEFA3EFAFCBC07B126C77B6193B06B62B9F89D799F78DCBD771F7E635040570922E563A80C98A30995C6AE2B50A4360716C89A2A2E12CE9BF46CEC2DFAAF54097DC8D51B27C7F64CCDE528825666BA6DA42AE9A285AAA254A966D026797378478FCBA5A2EC11B2856F22B4C9FBD19771E3C555FDD260D6213454EC50F8D0D9473EBCE21FEC9C59464EE34E5F8FF793269B9B687DF23D7DF49BCD4787690BA706C20924C9FB310AC7C360607BE041B8284626350A008C6A1AFA78635F9D8D01C13D194229929788CC3EB1448E675E3E6155CB9760657AF9FC28D5B6771EBCE452195F5DB333785B0823BB7EE3E071D7EFDDA25DCB87E19F7EFDDC1B5AB1771EBE65521A03BEEDCBE2E64F4965E9E6654988C91768856188E8103BF57DBB1962F5F8A9933A763EEBC9958B26C21E6FD3817CB572EC3A2654B316B9E1073F808ECDCBB4F8496CB347C91395469252DBC9CA2F7F6F641B098C2FCE6094D569AAF5C8A61BD10AC479ADAE7CE9D11521C93F1DA663127B7AB57681E4B4772EBD60DA92B4EE678485D498723E02B549CF461B887C75DD521F1D5A2478F3C957635665D1FA9371C7C7C3D95367FF7DD7751A74E1DB5483F63C62CCC9BF723060C18A4B43B2728D8A1EA0924968BA427B1D871F29C1D1B89C8E7D2560B7D4D48B61FA1B5218FD919B03CE72FF2D5A8643CBAEF8D2EED44E3594A209DA52ACABE3E04058A0F1313B3B968BB51C8954FC6784544C3956E03E7CCD5E192E533383A5647C64C5F216FC13A70C9FEBA48653E392F876FEAF5C6B12337A4EEC5D2488A8518886AF2871FF88D893396D6E26262D5EB6962080B62857D249D7480EC6BAC4849FAFFF30EE1DF8917027461F9905A65F3583F08B5001B81E3119A599C85E33436CD2C3628C338EEA0294BC2917814028E61F4A2B1FE3813E3701CC3FCA83DAF5DBF844B97E5FA852338E726E397F3C771DEEDB48A7FEECC799C3F2B0D2E703B77E1059C3F770A172F9C55C42311E97B3E144111FFB1F7432148889854018A48274F1E17D36D34BA75EB82BE7D7B8B16998A4993C761F69CE9F871C17C45C6793FCEC79A0DEB3173EE3CEC3D7848CDCA924CFC7930D5D0026A3D9A378699C337E6393B6C4C64B1AEA8816832F3BE7C97921D01C9C7F7D9D6AF5F2BE3C78D52476E22CCDC20C14E891F95E20798F871A66B6A5C7AE1823CBB10D8EDC219E5B3AE390EE57898F53B63C60F1838A81F3A77EE84BA75BF523B497AF5EA25DA7CB822E3BE7D07543EEC20A82CCE9E3DAFF2E60CF0FDFB0F857CDED66363D19A24252179CECE5177963C363A1E5FD5566C47B633C1F1E65DF77BB876C503D3262E41464B696471AC8AEA1F8E824BB6E6A2D5EAE3D5D7072243E686EA455D8BC37BA221CBCAD8B188DA5D53B87835D46F3C0C33E76D84A75F90D2701CF3D1A0506F67244720222E4A11302E391EA1E121CA7C56DF9595780942C684843021A68C6D659CCAAFAE71428E1F27D6716841D0CCA44C538609B6DB7F0B395F08B0B589752159780A17AF91941CA0338C3D25C75A7A0D8A33A66C208EBD4854928FB3719C3C600FCE70CEE06962EA38349D3879B16FDF1EFC72642F8E9DD867E0F801A54118FFE471FB38714CC679C4F1A3EA0553FA477E3924C43C231AF22ADCCE9F9501BC10557CBEB0EBE5F5506912EE455CB8708122E4F4E9D3C4545C8FB56B5763FB4E1963AD5E81556B56ABD9B6E5AB5761D3B6AD08090D14AD74FBD90BAF0F1FD2BCBEA7F2A3A6A400736CEAEDEDA5B418EFC12593A0E0276ACBDBD9B3A7D1BB774F198BAE1193711EE6CF9FAB9EF7D8B1235237BF282DC9325DB870499191E43977CE4DA52301D97990785CBBBC73FB1EDCEF3E5033B51CEFAD5AC585FC935287DBD4FDD956B44C3896E33E48E675FB9687DA2471E6B41BAE5CBEA17C6ED5BA7943C826D7D889B243E43DF4A600B6253B529290A085C3736A47E6CD780485FAE2E54BE8DF773832A62B061787B7503C5F7DA4B308E1D25516D3B3BA48DAEB70727E072D5A8F174B630B8E9DBD8258311DB9F182521625CA4C7DBA027142422152BC7E752C5678148AA81889C71FB3900E909D9AFAA8B3683ABED01D11C2C92D3F44470939AD1F7BD2488833B4E6EF69C4FF0632BE10A00BC5826B52A67E0892D15EE149506A484E9173BA5CCF16726CC469728E59F4BA955EE3E2343FC1C9126A8A5DBBB70A3663CB56095FB742998E7C1565D5AA356AD980CB07EBD6719CC5098FCD6AC9800BEC4C4B215FB162197EFEF927958EE4DAB0611DB66D9386178127110F1CD82742774D09EC2521E89A35AB644C380CC386715C35406998C9532761FACC19D8B465337EFA7981D28C8FFD3CE1E97D0F014FFDE029E3CF0742C8875E0F646C7B17376FDF1053D547CC3C77A5D9383EBDFFE02E2E5C3C8BABD72E0889038418FC029DAFD4C58FF8F8E3EAF8E4931A98366D8AD28C2CD7E5CB17551977ECD825CFB24DEA708F68BFC382FD8AB0ECCCB66FDF89F5EB36AB4DCCBB76EE573B7B162C58A8F6FB8E1A35426976E64562B3F3A2B6624777EAD4195CBA784DED08723B7F5981E7274F9C95CEEB242EB8199F99A485A227E568A99074343B493676A20CA375C271273B5EB61FC7BAA3468D42858AA5E0E060413A8B0B0AB9BE894F3F6A25E36DD1C8BF5CC2137EB25E04845FD72695B8192326314A0866FCC49A7A3F5148C86529F5B64A5C8C68335187F2677C599DCB689C68897F9E68A2ED52E4BA8218AE7A2C48D9B44E9E3D279FFFCDB01B489084A9B52309687BAE8F09C6A546A0A319A0272A6CD53F7B6A6A518E19D9C3D2C46163D34C6543D36C3B75FA184E9C3C8223470FE2D0E17D8A385C7FA3F6A459C6630A25D7C728109CBA274836C63D4ECD288248EDB27F3FB7867107C92E158769B81793EB665CCB6307C0C9136AF231A346AB090E9A749CB0193D7614A6FE300543870FC18449E371EDE62519BF5E14E2DD96DEFF3CDC2E9EC7B51B5771FDA698905729C0FC6EE93545466ACCBBEE37E1EE714B20CF78D54D95839A976F270C1D2AF98F1E29E598A1C2D809904863C68CC2C48993D54CEDAC597364DC37575D9F3A75B2DA72C79D3B83078D509B9889F6ED3AA3499366A85FBF21BEAEFB256AD5FA1CE3C773B6F407751F5A21BA535CB15C3AC5D51BB065F30EA519376D14B2EFDC27A4DEA37CD60DAD122EB7B04E5837EC2CD909723D941D2827845847AC1FCEC8B2F324513956F4F317B3D69BDF0BFA5526549B27886653FFC214F1E213F9DD20CA551CA2A24385742267546E0CE28E0DEBF88ECA4F942292E3A826294B225324A3447E46469A9D4C237FB6B3A3B6A0EC19BFAD687BFEE2FBB5FFD77821C05EE1741849654B4E5B58C793CA6CA523110DD3E2F978BF97FFDF81D4BF4FA1C1F15CEA30DE979D0BCBCA013DC1F2734C4442535BCD9E3B0B3367CF50A62DC9EDE6764E8DDBD879D08CD39A84134E34E56822320E4DEA93A78EAAEFE35CBEE2A6CCC70103FAAB3700FAF7EFABB42F09D9A9530774ECD85EBD1D40D3B56FDFFEE8D7EF7BE5F7E9D34F8D6109CEEA76EDDA1D1D3B744187F65DC4EF2A7E6709EFA966497BF7E98E9EBDBAE2C30F3F5084649AFEFDFBABAD6AE3C68DC3A449FC9CC35C0C1C3858EDBF24E1C78F9F289A6D99580F2BD5108264E4389EE4E2F390601C13729698F5C736B6B6A9F27567AB043B5EE8655D4BE5B96D7DF3985FF2E63B7C3A2C398584B4EED1942C8DCF56C421322258CE8D755E7E0FC820A074E6EA7B45CFB71FC172502E79CCB6E7C7C492B893C0264E6A73F5BF1176037F0BF688650B6DB2DA36C4DF49B23F021B82BBFF3958371AD108B7FE48CCB38E81BE3EA69666B9B92387037CE66134ACD10BD3748A8A0957C24961A5663D70E09068E503CA7CDCB3FB80C2D6ADDB4590A9C18D492CC6A576A126A489FCD34FF315F1860CE1B2C23C21C022A505A9BD3856A559C9E39933678B3F4BCCD6E99832856F4D4C5218376E8C5A03E4B51FA6CDC2E851E3D531CD7CE6BF69F33A31E557E2CCD91362655C7A3613CB5951CEF2D2DCA37947E8673334055FBB32D6D7F4B2061DDBCD36CC5A5FCF593BBA2353C7C66555DF5CC6D1C729F1129F5A4D5C54A410D21A8F3FF09222E33F7E5683E7506F861AC71CD769B9E1AC30E31A1F0E33F264B9F9A1277DFE4F80DDC0DF031BC4965C3CD73D12F1B2C463FADFD2B22F035BE211D48AFA579AD8B0BF770FAB36973CA4EC62EA90CC6C6C0A284D1E7E77E6F8F193629ACD7F66324E9B3A1353264FC7F41F660B316663FEBC9F317BD67CB564C0B12B0949739B33904A235809A0BF44C7F715E9F30562ED1B106520A0AC13FABA7E1F938EEB949A33C673497A31F70C932F51ED50D2E908B609677D798DE037740C534EF214DFB866904D4FCCB1CC3C27B4D5A0EFCF734D403AE64FB218BF73FF7CDDA6583B64E6A3C334F4984E412D3B18C7DCF4AF8FD5B90DE98C099B5FAFE91F0D55B3A336E1FF6BB01BF832D00DA51AFB2549F87F017B02610BEB7511642EE08BA08BC94533490BADD6229A488A048A40DC6DA3C99080F804EB067489A7EA46A2134CCF3742C2C203D41A201D7F7A8CCB1EF61C4D3D4E3C902CCC9BF730C0B7368C38C66602EEE231CACE6B5A93318E1A87096139BBC9B5416D059074249C8ECB747C7E555EEBC6767D0F3A46B346558EC72C1BF795320DF317675B8F2FD4AF09FBB01BF8326003B0918DC6331A928D4C2DA97B57AEA7B1C16DA17B55E2EFD088B6F9D9BB07CB661B9FE736631EF5BB1B14520AA5B53C4A086363844C92343282934EBF4A21AF69282797789DBB5E8CFD8DC6051587B796EB2495A1A90CB22A72C9B931F63608C7D7A908E6C372B37C2C0FB5585434BF06CE31F8AFDA89E90C67683E5DFF4CF3BC063560AD87678E61461D189D4BEAEBCC423F37E3E97C78ACE31A6534349F866101187EEA6B265E84DDC07F2A2830B666B412702B2888D6C984E7269C0C9F6F9E8BA08BBCD21252E31CCAA6957C8432A76CC2D49BFAE131888966229A73EC98F876B7F1490D6A4B6D2E72CA9EC26D94C370DAB4E4D88E04A1F634B4AD31A6D365A32381F5C6705BB2B013E4391DAFB173E2F393A8BC66EB7EFD6565235F5D1E4D427602BC3F616872C34230BE5427262D3F0F22E7BCAE4C6355D617DBC0847DD80DFC2BB0F68E76AFA53558167BE5A10052EB5905FEF9F008633B9F958416BE524559B79A5B888A14019773128EE62ACD416AD467C2ABC8668CB128F0741466E340C829A4D3E62C7FF988A6A431569370019DD149189A89E32D0A746858A01A7F51B029ECD1D1C6F8950433343F7F37C3E8386C894CA749C832EAB218E43276FDD0E7B3D3E716406A721292205159172C1393B20C34B709CE76C6C5B37C91CFCE49464D5082CFCBF2AB6FBA2AB23EDF16269E87DDC07F326C49989A90B6E0B88D84E37B91D43E1446C2D03A1C5F1963404ECB73AF27F322B9F8856BFE3E064D4F0A26B7D6710980CEE81C8C091B4D4A638283669EA1C5782FDB4F31321F82C786A01BE949424D34CE52522BD2A7A94AF290445AABB20CEA5E523E6EF1D3F726486A1295C4D124B4D58CBF3A83602C0709161915AA3A07A623A831F50410CF757CC631B5E31FC36EA0091326D21676034D983091B6B01B68C28489B485DD4013264CA42DEC069A3061226D6137D0840913690BBB81264C98485BD80D3461C244DAC26EA0091326D21676034D983091B6B01B68C28489B485DD4013264CA42DEC069A3061226D6137D0840913690BBB81264C98485BD80D3461C244DAC26EA0091326D21676034D983091B6B01B68C28489B485DD4013264CA42DEC069A3061226D6137D0840913690BBB81264C98485BD80D3461C244DAC26EA0091326D21676034D983091B6B01B68C28489B485DD4013264CA42DEC069A3061226D6137D0840913690BBB81264C98485BD80D3461C244DAC26EA0091326D21676034D983091B6B01B68C28489B4042CFF0F63AD20F12B91EE110000000049454E44AE426082 where aircraft_type_rcd = 'Airbus A380'
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

            scripts.Add(lastScript = new DatabaseScript
            {
                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
                ScriptNumber = this.scriptNumber++,
                Name = "PortTestDataSchedule",
                Description = "Port Test Data Schedule Light Load",
                #region script ( *** )
                DatabaseScriptBatch = new DatabaseScriptBatch
                {
                    Script = @"
-- base
if object_id (N'dbo.add_schedule') is not null
	drop procedure dbo.add_schedule
go
create procedure dbo.add_schedule(	
	@airline_id uniqueidentifier,
	@departure_airport_id uniqueidentifier,
	@arrival_airport_id uniqueidentifier,
	@fare decimal,
	@user_id uniqueidentifier
	) as begin

	-- today utc
	declare @date_time datetime = convert(date, getutcdate())
	declare @flight_number int = rand() * 1000
	declare @hour int set @hour = 1

	-- fare
	declare @financial_currency_id uniqueidentifier set @financial_currency_id = (
		select financial_currency_id
		from financial_currency as fc
		where fc.financial_currency_type_rcd = 'USD'
			and fc.financial_currency_against_financial_currency_type_rcd = 'USD')

	insert into financial_fare (financial_fare_id, financial_fare_type_rcd,  departure_airport_id,   arrival_airport_id,	valid_from_flight_date_time, valid_until_flight_date_time,		amount, financial_currency_id,		user_id, date_time )
		values (newid(), dbo.ref('financial_fare_type_ref.STD'),			@departure_airport_id,	@arrival_airport_id,	getutcdate()				,dateadd(month, 1, getutcdate()),	@fare, @financial_currency_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
	insert into financial_fare (financial_fare_id, financial_fare_type_rcd,  departure_airport_id,   arrival_airport_id,		valid_from_flight_date_time, valid_until_flight_date_time,		amount,  financial_currency_id,		user_id, date_time )
		values (newid(), dbo.ref('financial_fare_type_ref.STD'),			@arrival_airport_id,	 @departure_airport_id,		getutcdate()				, dateadd(month, 1, getutcdate()),	@fare,	@financial_currency_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

	while @hour <= 22 begin
		set @hour = @hour + 2

		declare @from_date_time datetime = dateadd(hour, @hour, @date_time)
	
		-- one month
		declare @until_date_time datetime = dateadd(hour, @hour + 1, @date_time)
		set @until_date_time = dateadd(month, 1, @until_date_time)
	
		declare @departure_time time = convert(time, @from_date_time)
		declare @arrival_time time = convert(time, @until_date_time)

		--select @departure_time, @arrival_time

		-- ping
		declare @flight_schedule_id uniqueidentifier set @flight_schedule_id = newid()
		insert into flight_schedule (flight_schedule_id,   binding_flight_schedule_id,	 airline_id,	aircraft_type_rcd,			 departure_airport_id, arrival_airport_id, from_date_time, until_date_time, comment,	   date_time,     user_id)
							 values (@flight_schedule_id, @flight_schedule_id,			@airline_id,	dbo.ref('Airbus A330-300'), @departure_airport_id,@arrival_airport_id,@from_date_time,@until_date_time, 'auto gen', getutcdate(), @user_id);

		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
							  values (	newid(),			   
										@flight_schedule_id, 
										dbo.ref('flight_identifier_type_ref.FN3'),
										substring(replace(convert(nvarchar(30), @flight_number + @hour), '.', ''), 0, 4),
										getutcdate(), 
										@user_id);

		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
							  values (	newid(),			   
										@flight_schedule_id, 
										dbo.ref('flight_identifier_type_ref.MATRI'),
										'XHUAGI',
										getutcdate(), 
										@user_id);
	
		insert into flight_schedule_segment(	flight_schedule_segment_id,  flight_schedule_id, departure_time, arrival_time, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number,	date_time,	   user_id)
										values(	newid(),					@flight_schedule_id,@departure_time,@arrival_time,@departure_airport_id,@arrival_airport_id, 1,						 1,							getutcdate(), @user_id)

		-- pong
		set @flight_schedule_id = newid()
		insert into flight_schedule (flight_schedule_id,   binding_flight_schedule_id,	 airline_id,	aircraft_type_rcd,			    departure_airport_id, arrival_airport_id,   from_date_time, until_date_time, comment,	   date_time,     user_id)
							 values (@flight_schedule_id, @flight_schedule_id,			@airline_id,	dbo.ref('Airbus A330-300'), @arrival_airport_id,  @departure_airport_id,@from_date_time,@until_date_time, 'auto gen', getutcdate(), @user_id);

		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
							  values (	newid(),			   
										@flight_schedule_id, 
										dbo.ref('flight_identifier_type_ref.FN3'),
										substring(replace(convert(nvarchar(30), @flight_number + @hour), '.', ''), 0, 4)  + '6',
										getutcdate(), 
										@user_id);

		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
							  values (	newid(),			   
										@flight_schedule_id, 
										dbo.ref('flight_identifier_type_ref.MATRI'),
										'XHUAGIX',
										getutcdate(), 
										@user_id);
	
		insert into flight_schedule_segment(	flight_schedule_segment_id,  flight_schedule_id, departure_time, arrival_time, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number,	date_time,	   user_id)
										values(	newid(),					@flight_schedule_id,@departure_time,@arrival_time,@arrival_airport_id,@departure_airport_id, 1,						 1,							getutcdate(), @user_id)

	end
end
go
-- schedule osl - arl
declare @airline_id uniqueidentifier 
set @airline_id = (select a.airline_id from airline as a where a.airline_name = 'SAS Scandinavian Airlines');

declare @departure_airport_id uniqueidentifier 
set @departure_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Gardermoen');

declare @arrival_airport_id uniqueidentifier 
set @arrival_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Arlanda');

exec add_schedule	
		@airline_id,
		@departure_airport_id,
		@arrival_airport_id,
		33,
		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'
go
                            ",
                    BreakUpToBatches = true
                }
                #endregion
            });

//            scripts.Add(lastScript = new DatabaseScript
//            {
//                DatabaseVersion = new DatabaseVersion { MajorNumber = majorNumber, MinorNumber = minorNumber, SequenceNumber = sequence++, DateTime = new DateTime(2018, 03, 07) },
//                ScriptNumber = this.scriptNumber++,
//                Name = "PortTestDataSchedule",
//                Description = "Port Test Data Schedule Medium Load",
//                #region script ( *** )
//                DatabaseScriptBatch = new DatabaseScriptBatch
//                {
//                    Script = @"
//-- base
//if object_id (N'dbo.add_schedule') is not null
//	drop procedure dbo.add_schedule
//go
//create procedure dbo.add_schedule(	
//	@airline_id uniqueidentifier,
//	@departure_airport_id uniqueidentifier,
//	@arrival_airport_id uniqueidentifier,
//	@fare decimal,
//	@user_id uniqueidentifier
//	) as begin

//	-- today utc
//	declare @date_time datetime = convert(date, getutcdate())
//	declare @flight_number int = rand() * 1000
//	declare @hour int set @hour = 1

//	-- fare
//	declare @financial_currency_id uniqueidentifier set @financial_currency_id = (
//		select financial_currency_id
//		from financial_currency as fc
//		where fc.financial_currency_type_rcd = 'USD'
//			and fc.financial_currency_against_financial_currency_type_rcd = 'USD')

//	insert into financial_fare (financial_fare_id, financial_fare_type_rcd,  departure_airport_id,   arrival_airport_id,	valid_from_flight_date_time, valid_until_flight_date_time,		amount, financial_currency_id,		user_id, date_time )
//		values (newid(), dbo.ref('financial_fare_type_ref.STD'),			@departure_airport_id,	@arrival_airport_id,	getutcdate()				,dateadd(month, 1, getutcdate()),	@fare, @financial_currency_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());
//	insert into financial_fare (financial_fare_id, financial_fare_type_rcd,  departure_airport_id,   arrival_airport_id,		valid_from_flight_date_time, valid_until_flight_date_time,		amount,  financial_currency_id,		user_id, date_time )
//		values (newid(), dbo.ref('financial_fare_type_ref.STD'),			@arrival_airport_id,	 @departure_airport_id,		getutcdate()				, dateadd(month, 1, getutcdate()),	@fare,	@financial_currency_id, '{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}', getutcdate());

//	while @hour <= 22 begin
//		set @hour = @hour + 2

//		declare @from_date_time datetime = dateadd(hour, @hour, @date_time)
	
//		-- one month
//		declare @until_date_time datetime = dateadd(hour, @hour + 1, @date_time)
//		set @until_date_time = dateadd(month, 1, @until_date_time)
	
//		declare @departure_time time = convert(time, @from_date_time)
//		declare @arrival_time time = convert(time, @until_date_time)

//		--select @departure_time, @arrival_time

//		-- ping
//		declare @flight_schedule_id uniqueidentifier set @flight_schedule_id = newid()
//		insert into flight_schedule (flight_schedule_id,   binding_flight_schedule_id,	 airline_id,	aircraft_type_rcd,			 departure_airport_id, arrival_airport_id, from_date_time, until_date_time, comment,	   date_time,     user_id)
//							 values (@flight_schedule_id, @flight_schedule_id,			@airline_id,	dbo.ref('Airbus A330-300'), @departure_airport_id,@arrival_airport_id,@from_date_time,@until_date_time, 'auto gen', getutcdate(), @user_id);

//		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
//							  values (	newid(),			   
//										@flight_schedule_id, 
//										dbo.ref('flight_identifier_type_ref.FN3'),
//										substring(replace(convert(nvarchar(30), @flight_number + @hour), '.', ''), 0, 4),
//										getutcdate(), 
//										@user_id);

//		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
//							  values (	newid(),			   
//										@flight_schedule_id, 
//										dbo.ref('flight_identifier_type_ref.MATRI'),
//										'XHUAGI',
//										getutcdate(), 
//										@user_id);
	
//		insert into flight_schedule_segment(	flight_schedule_segment_id,  flight_schedule_id, departure_time, arrival_time, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number,	date_time,	   user_id)
//										values(	newid(),					@flight_schedule_id,@departure_time,@arrival_time,@departure_airport_id,@arrival_airport_id, 1,						 1,							getutcdate(), @user_id)

//		-- pong
//		set @flight_schedule_id = newid()
//		insert into flight_schedule (flight_schedule_id,   binding_flight_schedule_id,	 airline_id,	aircraft_type_rcd,			    departure_airport_id, arrival_airport_id,   from_date_time, until_date_time, comment,	   date_time,     user_id)
//							 values (@flight_schedule_id, @flight_schedule_id,			@airline_id,	dbo.ref('Airbus A330-300'), @arrival_airport_id,  @departure_airport_id,@from_date_time,@until_date_time, 'auto gen', getutcdate(), @user_id);

//		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
//							  values (	newid(),			   
//										@flight_schedule_id, 
//										dbo.ref('flight_identifier_type_ref.FN3'),
//										substring(replace(convert(nvarchar(30), @flight_number + @hour), '.', ''), 0, 4)  + '6',
//										getutcdate(), 
//										@user_id);

//		insert into flight_schedule_identifier(flight_schedule_identifier_id, flight_schedule_id, flight_identifier_type_rcd,  flight_identifier_code, date_time,     user_id)
//							  values (	newid(),			   
//										@flight_schedule_id, 
//										dbo.ref('flight_identifier_type_ref.MATRI'),
//										'XHUAGIX',
//										getutcdate(), 
//										@user_id);
	
//		insert into flight_schedule_segment(	flight_schedule_segment_id,  flight_schedule_id, departure_time, arrival_time, departure_airport_id, arrival_airport_id, logical_segment_number, physical_segment_number,	date_time,	   user_id)
//										values(	newid(),					@flight_schedule_id,@departure_time,@arrival_time,@arrival_airport_id,@departure_airport_id, 1,						 1,							getutcdate(), @user_id)

//	end
//end
//go
//-- schedule osl - mia
//declare @airline_id uniqueidentifier 
//set @airline_id = (select a.airline_id from airline as a where a.airline_name = 'SAS Scandinavian Airlines');

//declare @departure_airport_id uniqueidentifier 
//set @departure_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Gardermoen');

//declare @arrival_airport_id uniqueidentifier 
//set @arrival_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Miami International');

//exec add_schedule	
//		@airline_id,
//		@departure_airport_id,
//		@arrival_airport_id,
//		33,
//		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'
//go
//-- schedule bkk - ARL
//declare @airline_id uniqueidentifier 
//set @airline_id = (select a.airline_id from airline as a where a.airline_name = 'SAS Scandinavian Airlines');

//declare @departure_airport_id uniqueidentifier 
//set @departure_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Suvarnabhumi International');

//declare @arrival_airport_id uniqueidentifier 
//set @arrival_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Arlanda');

//exec add_schedule	
//		@airline_id,
//		@departure_airport_id,
//		@arrival_airport_id,
//		44,
//		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'

//go

//-- schedule bkk - cnx
//declare @airline_id uniqueidentifier 
//set @airline_id = (select a.airline_id from airline as a where a.airline_name = 'Swiss');

//declare @departure_airport_id uniqueidentifier 
//set @departure_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Suvarnabhumi International');

//declare @arrival_airport_id uniqueidentifier 
//set @arrival_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Chiang Mai International');

//exec add_schedule	
//		@airline_id,
//		@departure_airport_id,
//		@arrival_airport_id,
//		55,
//		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'
//go
//-- schedule bkk - cnx
//declare @airline_id uniqueidentifier 
//set @airline_id = (select a.airline_id from airline as a where a.airline_name = 'Swiss');

//declare @departure_airport_id uniqueidentifier 
//set @departure_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Arlanda');

//declare @arrival_airport_id uniqueidentifier 
//set @arrival_airport_id = (select a.airport_id from airport as a where a.airport_name = 'Chiang Mai International');

//exec add_schedule	
//		@airline_id,
//		@departure_airport_id,
//		@arrival_airport_id,
//		66,
//		'{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}'
//                            ",
//                    BreakUpToBatches = true
//                }
//                #endregion
//            });

        }
    }
}
