﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SUPPLIER", Namespace="http://schemas.datacontract.org/2004/07/Wcfsba")]
    [System.SerializableAttribute()]
    public partial class SUPPLIER : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SUPLADDRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SUPLNAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SUPLNOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SUPLADDR {
            get {
                return this.SUPLADDRField;
            }
            set {
                if ((object.ReferenceEquals(this.SUPLADDRField, value) != true)) {
                    this.SUPLADDRField = value;
                    this.RaisePropertyChanged("SUPLADDR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SUPLNAME {
            get {
                return this.SUPLNAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.SUPLNAMEField, value) != true)) {
                    this.SUPLNAMEField = value;
                    this.RaisePropertyChanged("SUPLNAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SUPLNO {
            get {
                return this.SUPLNOField;
            }
            set {
                if ((this.SUPLNOField.Equals(value) != true)) {
                    this.SUPLNOField = value;
                    this.RaisePropertyChanged("SUPLNO");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Isupliermanager")]
    public interface Isupliermanager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/GetSUPPLIERs", ReplyAction="http://tempuri.org/Isupliermanager/GetSUPPLIERsResponse")]
        WebApplication3.ServiceReference1.SUPPLIER[] GetSUPPLIERs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/GetSUPPLIERs", ReplyAction="http://tempuri.org/Isupliermanager/GetSUPPLIERsResponse")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.SUPPLIER[]> GetSUPPLIERsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/GetUPPLIER", ReplyAction="http://tempuri.org/Isupliermanager/GetUPPLIERResponse")]
        WebApplication3.ServiceReference1.SUPPLIER GetUPPLIER(int supno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/GetUPPLIER", ReplyAction="http://tempuri.org/Isupliermanager/GetUPPLIERResponse")]
        System.Threading.Tasks.Task<WebApplication3.ServiceReference1.SUPPLIER> GetUPPLIERAsync(int supno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/add", ReplyAction="http://tempuri.org/Isupliermanager/addResponse")]
        void add(WebApplication3.ServiceReference1.SUPPLIER obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/add", ReplyAction="http://tempuri.org/Isupliermanager/addResponse")]
        System.Threading.Tasks.Task addAsync(WebApplication3.ServiceReference1.SUPPLIER obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/update", ReplyAction="http://tempuri.org/Isupliermanager/updateResponse")]
        void update(WebApplication3.ServiceReference1.SUPPLIER obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/update", ReplyAction="http://tempuri.org/Isupliermanager/updateResponse")]
        System.Threading.Tasks.Task updateAsync(WebApplication3.ServiceReference1.SUPPLIER obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/delete", ReplyAction="http://tempuri.org/Isupliermanager/deleteResponse")]
        void delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Isupliermanager/delete", ReplyAction="http://tempuri.org/Isupliermanager/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsupliermanagerChannel : WebApplication3.ServiceReference1.Isupliermanager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsupliermanagerClient : System.ServiceModel.ClientBase<WebApplication3.ServiceReference1.Isupliermanager>, WebApplication3.ServiceReference1.Isupliermanager {
        
        public IsupliermanagerClient() {
        }
        
        public IsupliermanagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsupliermanagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsupliermanagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsupliermanagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication3.ServiceReference1.SUPPLIER[] GetSUPPLIERs() {
            return base.Channel.GetSUPPLIERs();
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.SUPPLIER[]> GetSUPPLIERsAsync() {
            return base.Channel.GetSUPPLIERsAsync();
        }
        
        public WebApplication3.ServiceReference1.SUPPLIER GetUPPLIER(int supno) {
            return base.Channel.GetUPPLIER(supno);
        }
        
        public System.Threading.Tasks.Task<WebApplication3.ServiceReference1.SUPPLIER> GetUPPLIERAsync(int supno) {
            return base.Channel.GetUPPLIERAsync(supno);
        }
        
        public void add(WebApplication3.ServiceReference1.SUPPLIER obj) {
            base.Channel.add(obj);
        }
        
        public System.Threading.Tasks.Task addAsync(WebApplication3.ServiceReference1.SUPPLIER obj) {
            return base.Channel.addAsync(obj);
        }
        
        public void update(WebApplication3.ServiceReference1.SUPPLIER obj) {
            base.Channel.update(obj);
        }
        
        public System.Threading.Tasks.Task updateAsync(WebApplication3.ServiceReference1.SUPPLIER obj) {
            return base.Channel.updateAsync(obj);
        }
        
        public void delete(int id) {
            base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task deleteAsync(int id) {
            return base.Channel.deleteAsync(id);
        }
    }
}
