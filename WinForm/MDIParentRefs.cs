using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface {
    class MDIParentRefs {
        static public void DisplayRefForm(
            string systemReferenceTableName,
            Form mdiParent
            ) {

            switch (systemReferenceTableName) {
                case "address_type_ref": {
                        var mdiChild = new CrudeAddressTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_body_ref": {
                        var mdiChild = new CrudeAircraftBodyRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_compartment_type_ref": {
                        var mdiChild = new CrudeAircraftCompartmentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_configuration_ref": {
                        var mdiChild = new CrudeAircraftConfigurationRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_document_type_ref": {
                        var mdiChild = new CrudeAircraftDocumentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_identifier_type_ref": {
                        var mdiChild = new CrudeAircraftIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "aircraft_type_ref": {
                        var mdiChild = new CrudeAircraftTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "airline_identifier_type_ref": {
                        var mdiChild = new CrudeAirlineIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "airline_type_ref": {
                        var mdiChild = new CrudeAirlineTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "airport_facility_type_ref": {
                        var mdiChild = new CrudeAirportFacilityTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "airport_identifier_type_ref": {
                        var mdiChild = new CrudeAirportIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "airport_type_ref": {
                        var mdiChild = new CrudeAirportTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "booking_document_type_ref": {
                        var mdiChild = new CrudeBookingDocumentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "booking_event_type_ref": {
                        var mdiChild = new CrudeBookingEventTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "booking_identifier_type_ref": {
                        var mdiChild = new CrudeBookingIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "booking_passenger_event_type_ref": {
                        var mdiChild = new CrudeBookingPassengerEventTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "booking_source_ref": {
                        var mdiChild = new CrudeBookingSourceRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_event_type_ref": {
                        var mdiChild = new CrudeClientEventTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "client_type_ref": {
                        var mdiChild = new CrudeClientTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "contact_method_ref": {
                        var mdiChild = new CrudeContactMethodRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "date_time_type_ref": {
                        var mdiChild = new CrudeDateTimeTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_change_log_type_ref": {
                        var mdiChild = new CrudeDefaultChangeLogTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_layer_ref": {
                        var mdiChild = new CrudeDefaultErrorLayerRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_error_type_ref": {
                        var mdiChild = new CrudeDefaultErrorTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_status_ref": {
                        var mdiChild = new CrudeDefaultIssueStatusRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_issue_type_ref": {
                        var mdiChild = new CrudeDefaultIssueTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_rule_type_ref": {
                        var mdiChild = new CrudeDefaultRuleTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_state_ref": {
                        var mdiChild = new CrudeDefaultStateRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_system_setting_ref": {
                        var mdiChild = new CrudeDefaultSystemSettingRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_test_run_result_ref": {
                        var mdiChild = new CrudeDefaultTestRunResultRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        mdiChild.Show();
                        //mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "default_user_activity_type_ref": {
                        var mdiChild = new CrudeDefaultUserActivityTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "ferry_identifier_type_ref": {
                        var mdiChild = new CrudeFerryIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "ferry_type_ref": {
                        var mdiChild = new CrudeFerryTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_adjustment_type_ref": {
                        var mdiChild = new CrudeFinancialAdjustmentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_bank_account_number_type_ref": {
                        var mdiChild = new CrudeFinancialBankAccountNumberTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_booking_transaction_type_ref": {
                        var mdiChild = new CrudeFinancialBookingTransactionTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_card_type_ref": {
                        var mdiChild = new CrudeFinancialCardTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_coupon_type_ref": {
                        var mdiChild = new CrudeFinancialCouponTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_currency_type_ref": {
                        var mdiChild = new CrudeFinancialCurrencyTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_fare_type_ref": {
                        var mdiChild = new CrudeFinancialFareTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_fee_type_ref": {
                        var mdiChild = new CrudeFinancialFeeTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_payment_type_ref": {
                        var mdiChild = new CrudeFinancialPaymentTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_tax_type_ref": {
                        var mdiChild = new CrudeFinancialTaxTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "financial_voucher_type_ref": {
                        var mdiChild = new CrudeFinancialVoucherTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "flight_identifier_type_ref": {
                        var mdiChild = new CrudeFlightIdentifierTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "flight_schedule_segment_rule_ref": {
                        var mdiChild = new CrudeFlightScheduleSegmentRuleRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "gender_ref": {
                        var mdiChild = new CrudeGenderRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "language_ref": {
                        var mdiChild = new CrudeLanguageRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "link_type_ref": {
                        var mdiChild = new CrudeLinkTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "nationality_ref": {
                        var mdiChild = new CrudeNationalityRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "passenger_type_ref": {
                        var mdiChild = new CrudePassengerTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "reporting_roundup_type_ref": {
                        var mdiChild = new CrudeReportingRoundupTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_image_type_ref": {
                        var mdiChild = new CrudeServiceImageTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_request_status_ref": {
                        var mdiChild = new CrudeServiceRequestStatusRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_special_service_request_group_ref": {
                        var mdiChild = new CrudeServiceSpecialServiceRequestGroupRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_special_service_request_operation_rule_ref": {
                        var mdiChild = new CrudeServiceSpecialServiceRequestOperationRuleRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_special_service_request_requirement_ref": {
                        var mdiChild = new CrudeServiceSpecialServiceRequestRequirementRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "service_type_ref": {
                        var mdiChild = new CrudeServiceTypeRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                case "title_ref": {
                        var mdiChild = new CrudeTitleRefSearch();
                        Singleton.Instance.CheckForm(mdiChild);
                        mdiChild.MdiParent = mdiParent;
                        //mdiChild.Show();
                        mdiChild.Show(Singleton.Instance.UserId);
                        break;
                    }
                default:
                    MessageBox.Show("Missing reference table implementation; " + systemReferenceTableName);
                    break;
            }
        }
    }
}
