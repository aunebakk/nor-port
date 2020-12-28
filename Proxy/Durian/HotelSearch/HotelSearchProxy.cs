/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:46:49 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPort.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHotelSearchService")]
    public interface IHotelSearchService {
        // transfer all objects from data to contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/da04228c-8663-4aa2-b0ba-64712bbdc601
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelSearchService/GetHotelIndexWithFilter", ReplyAction="http://tempuri.org/IHotelSearchService/GetHotelIndexWithFilterResponse")]
        List<GetHotelIndexWithFilterContract> GetHotelIndexWithFilter ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelSearchServiceChannel : IHotelSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class HotelSearchService : System.ServiceModel.ClientBase<IHotelSearchService>, IHotelSearchService {
        // This Method
        // is generated by
        // links:
        //  SQL2X.org: https://sql2.org
        //  docLink: http://sql2x.org/documentationLink/3cf57883-f68e-4318-80a4-1a36604ef84b
        public List<GetHotelIndexWithFilterContract> GetHotelIndexWithFilter () {
            return base.Channel.GetHotelIndexWithFilter();
        }
        
        public HotelSearchService() {
        }
        
        public HotelSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
