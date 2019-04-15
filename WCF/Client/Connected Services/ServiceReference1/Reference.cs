﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStringService")]
    public interface IStringService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/ReadData", ReplyAction="http://tempuri.org/IStringService/ReadDataResponse")]
        kNN.Info ReadData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/ReadData", ReplyAction="http://tempuri.org/IStringService/ReadDataResponse")]
        System.Threading.Tasks.Task<kNN.Info> ReadDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/MakeData", ReplyAction="http://tempuri.org/IStringService/MakeDataResponse")]
        void MakeData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/MakeData", ReplyAction="http://tempuri.org/IStringService/MakeDataResponse")]
        System.Threading.Tasks.Task MakeDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/AddClass", ReplyAction="http://tempuri.org/IStringService/AddClassResponse")]
        void AddClass(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/AddClass", ReplyAction="http://tempuri.org/IStringService/AddClassResponse")]
        System.Threading.Tasks.Task AddClassAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/IncreaseRequests", ReplyAction="http://tempuri.org/IStringService/IncreaseRequestsResponse")]
        void IncreaseRequests();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/IncreaseRequests", ReplyAction="http://tempuri.org/IStringService/IncreaseRequestsResponse")]
        System.Threading.Tasks.Task IncreaseRequestsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/CountRequests", ReplyAction="http://tempuri.org/IStringService/CountRequestsResponse")]
        int CountRequests();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/CountRequests", ReplyAction="http://tempuri.org/IStringService/CountRequestsResponse")]
        System.Threading.Tasks.Task<int> CountRequestsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/IncreaseClients", ReplyAction="http://tempuri.org/IStringService/IncreaseClientsResponse")]
        void IncreaseClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/IncreaseClients", ReplyAction="http://tempuri.org/IStringService/IncreaseClientsResponse")]
        System.Threading.Tasks.Task IncreaseClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/DecreaseClients", ReplyAction="http://tempuri.org/IStringService/DecreaseClientsResponse")]
        void DecreaseClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/DecreaseClients", ReplyAction="http://tempuri.org/IStringService/DecreaseClientsResponse")]
        System.Threading.Tasks.Task DecreaseClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/CountClients", ReplyAction="http://tempuri.org/IStringService/CountClientsResponse")]
        int CountClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/CountClients", ReplyAction="http://tempuri.org/IStringService/CountClientsResponse")]
        System.Threading.Tasks.Task<int> CountClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/ClassifyObject", ReplyAction="http://tempuri.org/IStringService/ClassifyObjectResponse")]
        string ClassifyObject(string obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringService/ClassifyObject", ReplyAction="http://tempuri.org/IStringService/ClassifyObjectResponse")]
        System.Threading.Tasks.Task<string> ClassifyObjectAsync(string obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStringServiceChannel : Client.ServiceReference1.IStringService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StringServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IStringService>, Client.ServiceReference1.IStringService {
        
        public StringServiceClient() {
        }
        
        public StringServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StringServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StringServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public kNN.Info ReadData() {
            return base.Channel.ReadData();
        }
        
        public System.Threading.Tasks.Task<kNN.Info> ReadDataAsync() {
            return base.Channel.ReadDataAsync();
        }
        
        public void MakeData() {
            base.Channel.MakeData();
        }
        
        public System.Threading.Tasks.Task MakeDataAsync() {
            return base.Channel.MakeDataAsync();
        }
        
        public void AddClass(string str) {
            base.Channel.AddClass(str);
        }
        
        public System.Threading.Tasks.Task AddClassAsync(string str) {
            return base.Channel.AddClassAsync(str);
        }
        
        public void IncreaseRequests() {
            base.Channel.IncreaseRequests();
        }
        
        public System.Threading.Tasks.Task IncreaseRequestsAsync() {
            return base.Channel.IncreaseRequestsAsync();
        }
        
        public int CountRequests() {
            return base.Channel.CountRequests();
        }
        
        public System.Threading.Tasks.Task<int> CountRequestsAsync() {
            return base.Channel.CountRequestsAsync();
        }
        
        public void IncreaseClients() {
            base.Channel.IncreaseClients();
        }
        
        public System.Threading.Tasks.Task IncreaseClientsAsync() {
            return base.Channel.IncreaseClientsAsync();
        }
        
        public void DecreaseClients() {
            base.Channel.DecreaseClients();
        }
        
        public System.Threading.Tasks.Task DecreaseClientsAsync() {
            return base.Channel.DecreaseClientsAsync();
        }
        
        public int CountClients() {
            return base.Channel.CountClients();
        }
        
        public System.Threading.Tasks.Task<int> CountClientsAsync() {
            return base.Channel.CountClientsAsync();
        }
        
        public string ClassifyObject(string obj) {
            return base.Channel.ClassifyObject(obj);
        }
        
        public System.Threading.Tasks.Task<string> ClassifyObjectAsync(string obj) {
            return base.Channel.ClassifyObjectAsync(obj);
        }
    }
}