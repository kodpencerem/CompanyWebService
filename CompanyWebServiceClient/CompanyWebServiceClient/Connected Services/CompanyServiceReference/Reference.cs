﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyWebServiceClient.CompanyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyServiceReference.ICompanyPublicService")]
    public interface ICompanyPublicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyPublicService/GetPublicInformation", ReplyAction="http://tempuri.org/ICompanyPublicService/GetPublicInformationResponse")]
        string GetPublicInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyPublicService/GetPublicInformation", ReplyAction="http://tempuri.org/ICompanyPublicService/GetPublicInformationResponse")]
        System.Threading.Tasks.Task<string> GetPublicInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyPublicServiceChannel : CompanyWebServiceClient.CompanyServiceReference.ICompanyPublicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyPublicServiceClient : System.ServiceModel.ClientBase<CompanyWebServiceClient.CompanyServiceReference.ICompanyPublicService>, CompanyWebServiceClient.CompanyServiceReference.ICompanyPublicService {
        
        public CompanyPublicServiceClient() {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyPublicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyPublicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPublicInformation() {
            return base.Channel.GetPublicInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetPublicInformationAsync() {
            return base.Channel.GetPublicInformationAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyServiceReference.ICompanyConfidentialService")]
    public interface ICompanyConfidentialService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformation", ReplyAction="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformationResponse" +
            "")]
        string GetConfidentialInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformation", ReplyAction="http://tempuri.org/ICompanyConfidentialService/GetConfidentialInformationResponse" +
            "")]
        System.Threading.Tasks.Task<string> GetConfidentialInformationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyConfidentialServiceChannel : CompanyWebServiceClient.CompanyServiceReference.ICompanyConfidentialService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyConfidentialServiceClient : System.ServiceModel.ClientBase<CompanyWebServiceClient.CompanyServiceReference.ICompanyConfidentialService>, CompanyWebServiceClient.CompanyServiceReference.ICompanyConfidentialService {
        
        public CompanyConfidentialServiceClient() {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyConfidentialServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyConfidentialServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetConfidentialInformation() {
            return base.Channel.GetConfidentialInformation();
        }
        
        public System.Threading.Tasks.Task<string> GetConfidentialInformationAsync() {
            return base.Channel.GetConfidentialInformationAsync();
        }
    }
}
