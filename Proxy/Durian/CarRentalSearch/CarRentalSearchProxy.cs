/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 12:38:25 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICarRentalSearchService")]
    public interface ICarRentalSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarRentalSearchService/GetCarRentalIndexWithFilter", ReplyAction="http://tempuri.org/ICarRentalSearchService/GetCarRentalIndexWithFilterResponse")]
        List<GetCarRentalIndexWithFilterContract> GetCarRentalIndexWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarRentalSearchServiceChannel : ICarRentalSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CarRentalSearchService : System.ServiceModel.ClientBase<ICarRentalSearchService>, ICarRentalSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetCarRentalIndexWithFilterContract> GetCarRentalIndexWithFilter () {
            return base.Channel.GetCarRentalIndexWithFilter();
        }
        
        public CarRentalSearchService() {
        }
        
        public CarRentalSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarRentalSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
