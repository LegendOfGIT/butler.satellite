﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Satellite.DataWarehouse {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataWarehouse.DataWarehouse")]
    public interface DataWarehouse {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataWarehouse/DigInformation", ReplyAction="http://tempuri.org/DataWarehouse/DigInformationResponse")]
        System.Collections.Generic.Dictionary<string, object[]>[] DigInformation(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataWarehouse/DigInformation", ReplyAction="http://tempuri.org/DataWarehouse/DigInformationResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, object[]>[]> DigInformationAsync(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataWarehouse/StoreInformation", ReplyAction="http://tempuri.org/DataWarehouse/StoreInformationResponse")]
        void StoreInformation(System.Collections.Generic.Dictionary<string, object[]> information);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DataWarehouse/StoreInformation", ReplyAction="http://tempuri.org/DataWarehouse/StoreInformationResponse")]
        System.Threading.Tasks.Task StoreInformationAsync(System.Collections.Generic.Dictionary<string, object[]> information);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataWarehouseChannel : DataWarehouse, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataWarehouseClient : System.ServiceModel.ClientBase<DataWarehouse>, DataWarehouse {
        
        public DataWarehouseClient() {
        }
        
        public DataWarehouseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataWarehouseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataWarehouseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataWarehouseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, object[]>[] DigInformation(string question) {
            return base.Channel.DigInformation(question);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, object[]>[]> DigInformationAsync(string question) {
            return base.Channel.DigInformationAsync(question);
        }
        
        public void StoreInformation(System.Collections.Generic.Dictionary<string, object[]> information) {
            base.Channel.StoreInformation(information);
        }
        
        public System.Threading.Tasks.Task StoreInformationAsync(System.Collections.Generic.Dictionary<string, object[]> information) {
            return base.Channel.StoreInformationAsync(information);
        }
    }
}
