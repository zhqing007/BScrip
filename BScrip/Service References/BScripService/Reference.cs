﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BScrip.BScripService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Host", Namespace="http://schemas.datacontract.org/2004/07/BScripServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Host : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hostnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ipaddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int loginmodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string loginnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long monitorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string superpwField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long tspanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int useridField;
        
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
        public string hostname {
            get {
                return this.hostnameField;
            }
            set {
                if ((object.ReferenceEquals(this.hostnameField, value) != true)) {
                    this.hostnameField = value;
                    this.RaisePropertyChanged("hostname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ipaddress {
            get {
                return this.ipaddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ipaddressField, value) != true)) {
                    this.ipaddressField = value;
                    this.RaisePropertyChanged("ipaddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int loginmode {
            get {
                return this.loginmodeField;
            }
            set {
                if ((this.loginmodeField.Equals(value) != true)) {
                    this.loginmodeField = value;
                    this.RaisePropertyChanged("loginmode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string loginname {
            get {
                return this.loginnameField;
            }
            set {
                if ((object.ReferenceEquals(this.loginnameField, value) != true)) {
                    this.loginnameField = value;
                    this.RaisePropertyChanged("loginname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long monitor {
            get {
                return this.monitorField;
            }
            set {
                if ((this.monitorField.Equals(value) != true)) {
                    this.monitorField = value;
                    this.RaisePropertyChanged("monitor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string superpw {
            get {
                return this.superpwField;
            }
            set {
                if ((object.ReferenceEquals(this.superpwField, value) != true)) {
                    this.superpwField = value;
                    this.RaisePropertyChanged("superpw");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long tspan {
            get {
                return this.tspanField;
            }
            set {
                if ((this.tspanField.Equals(value) != true)) {
                    this.tspanField = value;
                    this.RaisePropertyChanged("tspan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userid {
            get {
                return this.useridField;
            }
            set {
                if ((this.useridField.Equals(value) != true)) {
                    this.useridField = value;
                    this.RaisePropertyChanged("userid");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ROccupy", Namespace="http://schemas.datacontract.org/2004/07/BScripServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ROccupy : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CpuOccupyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MemOccupyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SlotNameField;
        
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
        public int CpuOccupy {
            get {
                return this.CpuOccupyField;
            }
            set {
                if ((this.CpuOccupyField.Equals(value) != true)) {
                    this.CpuOccupyField = value;
                    this.RaisePropertyChanged("CpuOccupy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IP {
            get {
                return this.IPField;
            }
            set {
                if ((object.ReferenceEquals(this.IPField, value) != true)) {
                    this.IPField = value;
                    this.RaisePropertyChanged("IP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MemOccupy {
            get {
                return this.MemOccupyField;
            }
            set {
                if ((this.MemOccupyField.Equals(value) != true)) {
                    this.MemOccupyField = value;
                    this.RaisePropertyChanged("MemOccupy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SlotName {
            get {
                return this.SlotNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SlotNameField, value) != true)) {
                    this.SlotNameField = value;
                    this.RaisePropertyChanged("SlotName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BScripService.IBSService")]
    public interface IBSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetPath", ReplyAction="http://tempuri.org/IBSService/GetPathResponse")]
        string GetPath();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/SaveConf", ReplyAction="http://tempuri.org/IBSService/SaveConfResponse")]
        void SaveConf(int userid, string[] hostnames);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/SetSaveConfTime", ReplyAction="http://tempuri.org/IBSService/SetSaveConfTimeResponse")]
        void SetSaveConfTime(int userid, string hostname, long span);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/SetMonitorTime", ReplyAction="http://tempuri.org/IBSService/SetMonitorTimeResponse")]
        void SetMonitorTime(int userid, string hostname, long span);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetHosts", ReplyAction="http://tempuri.org/IBSService/GetHostsResponse")]
        BScrip.BScripService.Host[] GetHosts(int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetBackUpHosts", ReplyAction="http://tempuri.org/IBSService/GetBackUpHostsResponse")]
        BScrip.BScripService.Host[] GetBackUpHosts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetConSaveDate", ReplyAction="http://tempuri.org/IBSService/GetConSaveDateResponse")]
        System.DateTime[] GetConSaveDate(string ip, System.DateTime begin, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetCpuMemOccupy", ReplyAction="http://tempuri.org/IBSService/GetCpuMemOccupyResponse")]
        BScrip.BScripService.ROccupy[] GetCpuMemOccupy(BScrip.BScripService.Host h, System.DateTime begintime, System.DateTime endtime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GetConf", ReplyAction="http://tempuri.org/IBSService/GetConfResponse")]
        string GetConf(string ip, System.DateTime checkdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/AddHost", ReplyAction="http://tempuri.org/IBSService/AddHostResponse")]
        void AddHost(BScrip.BScripService.Host item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/UpdateHost", ReplyAction="http://tempuri.org/IBSService/UpdateHostResponse")]
        void UpdateHost(BScrip.BScripService.Host item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/CheckUser", ReplyAction="http://tempuri.org/IBSService/CheckUserResponse")]
        int CheckUser(string name, string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBSService/GeConfCount", ReplyAction="http://tempuri.org/IBSService/GeConfCountResponse")]
        int[] GeConfCount(BScrip.BScripService.Host[] hl, System.DateTime begin, System.DateTime end);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBSServiceChannel : BScrip.BScripService.IBSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BSServiceClient : System.ServiceModel.ClientBase<BScrip.BScripService.IBSService>, BScrip.BScripService.IBSService {
        
        public BSServiceClient() {
        }
        
        public BSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPath() {
            return base.Channel.GetPath();
        }
        
        public void SaveConf(int userid, string[] hostnames) {
            base.Channel.SaveConf(userid, hostnames);
        }
        
        public void SetSaveConfTime(int userid, string hostname, long span) {
            base.Channel.SetSaveConfTime(userid, hostname, span);
        }
        
        public void SetMonitorTime(int userid, string hostname, long span) {
            base.Channel.SetMonitorTime(userid, hostname, span);
        }
        
        public BScrip.BScripService.Host[] GetHosts(int userid) {
            return base.Channel.GetHosts(userid);
        }
        
        public BScrip.BScripService.Host[] GetBackUpHosts() {
            return base.Channel.GetBackUpHosts();
        }
        
        public System.DateTime[] GetConSaveDate(string ip, System.DateTime begin, System.DateTime end) {
            return base.Channel.GetConSaveDate(ip, begin, end);
        }
        
        public BScrip.BScripService.ROccupy[] GetCpuMemOccupy(BScrip.BScripService.Host h, System.DateTime begintime, System.DateTime endtime) {
            return base.Channel.GetCpuMemOccupy(h, begintime, endtime);
        }
        
        public string GetConf(string ip, System.DateTime checkdate) {
            return base.Channel.GetConf(ip, checkdate);
        }
        
        public void AddHost(BScrip.BScripService.Host item) {
            base.Channel.AddHost(item);
        }
        
        public void UpdateHost(BScrip.BScripService.Host item) {
            base.Channel.UpdateHost(item);
        }
        
        public int CheckUser(string name, string pw) {
            return base.Channel.CheckUser(name, pw);
        }
        
        public int[] GeConfCount(BScrip.BScripService.Host[] hl, System.DateTime begin, System.DateTime end) {
            return base.Channel.GeConfCount(hl, begin, end);
        }
    }
}
