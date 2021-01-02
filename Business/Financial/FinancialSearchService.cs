/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:46:18 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPort.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IFinancialSearchService {
        // returns a list of GetAvailableCurrencies contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  financialCurrencyId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  currencyDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime);
        // returns a list of FinancialFares contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<FinancialFaresContract> FinancialFares ();
        // returns a list of VoucherSearchWithRemainingAmount contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  voucherValidOnDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime);
        // returns a list of VoucherTransactions contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  financialVoucherId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId);
        // returns a list of FinancialServiceDetailsForBooking contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId);
        // returns a list of ServiceFerryList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<ServiceFerryListContract> ServiceFerryList ();
        // returns a list of ServiceCarRentalList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<ServiceCarRentalListContract> ServiceCarRentalList ();
        // returns a list of ServiceHotelList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<ServiceHotelListContract> ServiceHotelList ();
        // returns a list of SpecialServiceRequestList contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/5fe72920-1923-416a-93bb-a2396990ec67
        [OperationContract()]
        List<SpecialServiceRequestListContract> SpecialServiceRequestList ();
        
        // returns a list of TransactionsCreditDebitBalance contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance(System.DateTime fromDateTime, System.DateTime untilDateTime);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class FinancialSearchService : IFinancialSearchService {
        // returns a list of GetAvailableCurrencies contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  financialCurrencyId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  currencyDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<GetAvailableCurrenciesContract> GetAvailableCurrencies (System.Guid financialCurrencyId,System.DateTime currencyDateTime) {
            // transfer all GetAvailableCurrencies serialized objects from FinancialSearch as GetAvailableCurrencies contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new GetAvailableCurrencies();
            return businessLogicLayer.GetAvailableCurrenciesFromDal(dataAccessLayer.GetAvailableCurrencies(financialCurrencyId, currencyDateTime));
        }
        // returns a list of FinancialFares contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<FinancialFaresContract> FinancialFares () {
            // transfer all FinancialFares serialized objects from FinancialSearch as FinancialFares contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new FinancialFares();
            return businessLogicLayer.FinancialFaresFromDal(dataAccessLayer.FinancialFares());
        }
        // returns a list of VoucherSearchWithRemainingAmount contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  voucherValidOnDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<VoucherSearchWithRemainingAmountContract> VoucherSearchWithRemainingAmount (System.DateTime voucherValidOnDateTime) {
            // transfer all VoucherSearchWithRemainingAmount serialized objects from FinancialSearch as VoucherSearchWithRemainingAmount contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new VoucherSearchWithRemainingAmount();
            return businessLogicLayer.VoucherSearchWithRemainingAmountFromDal(dataAccessLayer.VoucherSearchWithRemainingAmount(voucherValidOnDateTime));
        }
        // returns a list of VoucherTransactions contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  financialVoucherId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<VoucherTransactionsContract> VoucherTransactions (System.Guid financialVoucherId) {
            // transfer all VoucherTransactions serialized objects from FinancialSearch as VoucherTransactions contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new VoucherTransactions();
            return businessLogicLayer.VoucherTransactionsFromDal(dataAccessLayer.VoucherTransactions(financialVoucherId));
        }
        // returns a list of FinancialServiceDetailsForBooking contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        // parameters:
        //  bookingId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<FinancialServiceDetailsForBookingContract> FinancialServiceDetailsForBooking (System.Guid bookingId) {
            // transfer all FinancialServiceDetailsForBooking serialized objects from FinancialSearch as FinancialServiceDetailsForBooking contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new FinancialServiceDetailsForBooking();
            return businessLogicLayer.FinancialServiceDetailsForBookingFromDal(dataAccessLayer.FinancialServiceDetailsForBooking(bookingId));
        }
        // returns a list of ServiceFerryList contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<ServiceFerryListContract> ServiceFerryList () {
            // transfer all ServiceFerryList serialized objects from FinancialSearch as ServiceFerryList contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new ServiceFerryList();
            return businessLogicLayer.ServiceFerryListFromDal(dataAccessLayer.ServiceFerryList());
        }
        // returns a list of ServiceCarRentalList contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<ServiceCarRentalListContract> ServiceCarRentalList () {
            // transfer all ServiceCarRentalList serialized objects from FinancialSearch as ServiceCarRentalList contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new ServiceCarRentalList();
            return businessLogicLayer.ServiceCarRentalListFromDal(dataAccessLayer.ServiceCarRentalList());
        }
        // returns a list of ServiceHotelList contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<ServiceHotelListContract> ServiceHotelList () {
            // transfer all ServiceHotelList serialized objects from FinancialSearch as ServiceHotelList contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new ServiceHotelList();
            return businessLogicLayer.ServiceHotelListFromDal(dataAccessLayer.ServiceHotelList());
        }
        // returns a list of SpecialServiceRequestList contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb26aecd-6edc-44ae-938f-42f53929062d
        public List<SpecialServiceRequestListContract> SpecialServiceRequestList () {
            // transfer all SpecialServiceRequestList serialized objects from FinancialSearch as SpecialServiceRequestList contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new SpecialServiceRequestList();
            return businessLogicLayer.SpecialServiceRequestListFromDal(dataAccessLayer.SpecialServiceRequestList());
        }
        
        // returns a list of TransactionsCreditDebitBalance contracts from FinancialSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  fromDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  untilDateTime: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<TransactionsCreditDebitBalanceContract> TransactionsCreditDebitBalance(System.DateTime fromDateTime, System.DateTime untilDateTime) {
            // transfer all TransactionsCreditDebitBalance serialized objects from FinancialSearch as TransactionsCreditDebitBalance contracts
            var dataAccessLayer = new SolutionNorSolutionPort.DataAccessLayer.FinancialSearch();
            var businessLogicLayer = new TransactionsCreditDebitBalance();
            return businessLogicLayer.TransactionsCreditDebitBalanceFromDal(dataAccessLayer.TransactionsCreditDebitBalance(fromDateTime, untilDateTime));
        }
    }
}
