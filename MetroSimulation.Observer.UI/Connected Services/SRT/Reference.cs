﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetroSimulation.Observer.UI.SRT {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrainInfo", Namespace="http://schemas.datacontract.org/2004/07/MetroSimulation.Train")]
    [System.SerializableAttribute()]
    public partial class TrainInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MetroSimulation.Observer.UI.SRT.Train BaseTrainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrainPositionField;
        
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
        public MetroSimulation.Observer.UI.SRT.Train BaseTrain {
            get {
                return this.BaseTrainField;
            }
            set {
                if ((object.ReferenceEquals(this.BaseTrainField, value) != true)) {
                    this.BaseTrainField = value;
                    this.RaisePropertyChanged("BaseTrain");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrainPosition {
            get {
                return this.TrainPositionField;
            }
            set {
                if ((object.ReferenceEquals(this.TrainPositionField, value) != true)) {
                    this.TrainPositionField = value;
                    this.RaisePropertyChanged("TrainPosition");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Train", Namespace="http://schemas.datacontract.org/2004/07/MetroSimulation.Train")]
    [System.SerializableAttribute()]
    public partial class Train : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentPassengersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxPassengersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float SpeedField;
        
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
        public int CurrentPassengers {
            get {
                return this.CurrentPassengersField;
            }
            set {
                if ((this.CurrentPassengersField.Equals(value) != true)) {
                    this.CurrentPassengersField = value;
                    this.RaisePropertyChanged("CurrentPassengers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxPassengers {
            get {
                return this.MaxPassengersField;
            }
            set {
                if ((this.MaxPassengersField.Equals(value) != true)) {
                    this.MaxPassengersField = value;
                    this.RaisePropertyChanged("MaxPassengers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Speed {
            get {
                return this.SpeedField;
            }
            set {
                if ((this.SpeedField.Equals(value) != true)) {
                    this.SpeedField = value;
                    this.RaisePropertyChanged("Speed");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRT.ITrainObserverService", CallbackContract=typeof(MetroSimulation.Observer.UI.SRT.ITrainObserverServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ITrainObserverService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainObserverService/Connect", ReplyAction="http://tempuri.org/ITrainObserverService/ConnectResponse")]
        bool Connect();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/Connect", ReplyAction="http://tempuri.org/ITrainObserverService/ConnectResponse")]
        System.IAsyncResult BeginConnect(System.AsyncCallback callback, object asyncState);
        
        bool EndConnect(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainObserverService/GetTrainInfo", ReplyAction="http://tempuri.org/ITrainObserverService/GetTrainInfoResponse")]
        void GetTrainInfo();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/GetTrainInfo", ReplyAction="http://tempuri.org/ITrainObserverService/GetTrainInfoResponse")]
        System.IAsyncResult BeginGetTrainInfo(System.AsyncCallback callback, object asyncState);
        
        void EndGetTrainInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainObserverService/GetTrainPosition", ReplyAction="http://tempuri.org/ITrainObserverService/GetTrainPositionResponse")]
        string GetTrainPosition();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/GetTrainPosition", ReplyAction="http://tempuri.org/ITrainObserverService/GetTrainPositionResponse")]
        System.IAsyncResult BeginGetTrainPosition(System.AsyncCallback callback, object asyncState);
        
        string EndGetTrainPosition(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrainObserverService/SetTrainPosition")]
        void SetTrainPosition(string possition);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/SetTrainPosition")]
        System.IAsyncResult BeginSetTrainPosition(string possition, System.AsyncCallback callback, object asyncState);
        
        void EndSetTrainPosition(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrainObserverService/SetPassengers")]
        void SetPassengers(int passengers);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/SetPassengers")]
        System.IAsyncResult BeginSetPassengers(int passengers, System.AsyncCallback callback, object asyncState);
        
        void EndSetPassengers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrainObserverService/Disconnect")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/Disconnect")]
        System.IAsyncResult BeginDisconnect(System.AsyncCallback callback, object asyncState);
        
        void EndDisconnect(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrainObserverServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrainObserverService/ReciveTrainInfo")]
        void ReciveTrainInfo(MetroSimulation.Observer.UI.SRT.TrainInfo info);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/ITrainObserverService/ReciveTrainInfo")]
        System.IAsyncResult BeginReciveTrainInfo(MetroSimulation.Observer.UI.SRT.TrainInfo info, System.AsyncCallback callback, object asyncState);
        
        void EndReciveTrainInfo(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrainObserverServiceChannel : MetroSimulation.Observer.UI.SRT.ITrainObserverService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConnectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ConnectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetTrainPositionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetTrainPositionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrainObserverServiceClient : System.ServiceModel.DuplexClientBase<MetroSimulation.Observer.UI.SRT.ITrainObserverService>, MetroSimulation.Observer.UI.SRT.ITrainObserverService {
        
        private BeginOperationDelegate onBeginConnectDelegate;
        
        private EndOperationDelegate onEndConnectDelegate;
        
        private System.Threading.SendOrPostCallback onConnectCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetTrainInfoDelegate;
        
        private EndOperationDelegate onEndGetTrainInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetTrainInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetTrainPositionDelegate;
        
        private EndOperationDelegate onEndGetTrainPositionDelegate;
        
        private System.Threading.SendOrPostCallback onGetTrainPositionCompletedDelegate;
        
        private BeginOperationDelegate onBeginSetTrainPositionDelegate;
        
        private EndOperationDelegate onEndSetTrainPositionDelegate;
        
        private System.Threading.SendOrPostCallback onSetTrainPositionCompletedDelegate;
        
        private BeginOperationDelegate onBeginSetPassengersDelegate;
        
        private EndOperationDelegate onEndSetPassengersDelegate;
        
        private System.Threading.SendOrPostCallback onSetPassengersCompletedDelegate;
        
        private BeginOperationDelegate onBeginDisconnectDelegate;
        
        private EndOperationDelegate onEndDisconnectDelegate;
        
        private System.Threading.SendOrPostCallback onDisconnectCompletedDelegate;
        
        public TrainObserverServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public TrainObserverServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public TrainObserverServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrainObserverServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrainObserverServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public event System.EventHandler<ConnectCompletedEventArgs> ConnectCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> GetTrainInfoCompleted;
        
        public event System.EventHandler<GetTrainPositionCompletedEventArgs> GetTrainPositionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SetTrainPositionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SetPassengersCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DisconnectCompleted;
        
        public bool Connect() {
            return base.Channel.Connect();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginConnect(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginConnect(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndConnect(System.IAsyncResult result) {
            return base.Channel.EndConnect(result);
        }
        
        private System.IAsyncResult OnBeginConnect(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginConnect(callback, asyncState);
        }
        
        private object[] OnEndConnect(System.IAsyncResult result) {
            bool retVal = this.EndConnect(result);
            return new object[] {
                    retVal};
        }
        
        private void OnConnectCompleted(object state) {
            if ((this.ConnectCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ConnectCompleted(this, new ConnectCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ConnectAsync() {
            this.ConnectAsync(null);
        }
        
        public void ConnectAsync(object userState) {
            if ((this.onBeginConnectDelegate == null)) {
                this.onBeginConnectDelegate = new BeginOperationDelegate(this.OnBeginConnect);
            }
            if ((this.onEndConnectDelegate == null)) {
                this.onEndConnectDelegate = new EndOperationDelegate(this.OnEndConnect);
            }
            if ((this.onConnectCompletedDelegate == null)) {
                this.onConnectCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnConnectCompleted);
            }
            base.InvokeAsync(this.onBeginConnectDelegate, null, this.onEndConnectDelegate, this.onConnectCompletedDelegate, userState);
        }
        
        public void GetTrainInfo() {
            base.Channel.GetTrainInfo();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetTrainInfo(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTrainInfo(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndGetTrainInfo(System.IAsyncResult result) {
            base.Channel.EndGetTrainInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetTrainInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetTrainInfo(callback, asyncState);
        }
        
        private object[] OnEndGetTrainInfo(System.IAsyncResult result) {
            this.EndGetTrainInfo(result);
            return null;
        }
        
        private void OnGetTrainInfoCompleted(object state) {
            if ((this.GetTrainInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTrainInfoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTrainInfoAsync() {
            this.GetTrainInfoAsync(null);
        }
        
        public void GetTrainInfoAsync(object userState) {
            if ((this.onBeginGetTrainInfoDelegate == null)) {
                this.onBeginGetTrainInfoDelegate = new BeginOperationDelegate(this.OnBeginGetTrainInfo);
            }
            if ((this.onEndGetTrainInfoDelegate == null)) {
                this.onEndGetTrainInfoDelegate = new EndOperationDelegate(this.OnEndGetTrainInfo);
            }
            if ((this.onGetTrainInfoCompletedDelegate == null)) {
                this.onGetTrainInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTrainInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetTrainInfoDelegate, null, this.onEndGetTrainInfoDelegate, this.onGetTrainInfoCompletedDelegate, userState);
        }
        
        public string GetTrainPosition() {
            return base.Channel.GetTrainPosition();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetTrainPosition(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTrainPosition(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetTrainPosition(System.IAsyncResult result) {
            return base.Channel.EndGetTrainPosition(result);
        }
        
        private System.IAsyncResult OnBeginGetTrainPosition(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetTrainPosition(callback, asyncState);
        }
        
        private object[] OnEndGetTrainPosition(System.IAsyncResult result) {
            string retVal = this.EndGetTrainPosition(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetTrainPositionCompleted(object state) {
            if ((this.GetTrainPositionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTrainPositionCompleted(this, new GetTrainPositionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTrainPositionAsync() {
            this.GetTrainPositionAsync(null);
        }
        
        public void GetTrainPositionAsync(object userState) {
            if ((this.onBeginGetTrainPositionDelegate == null)) {
                this.onBeginGetTrainPositionDelegate = new BeginOperationDelegate(this.OnBeginGetTrainPosition);
            }
            if ((this.onEndGetTrainPositionDelegate == null)) {
                this.onEndGetTrainPositionDelegate = new EndOperationDelegate(this.OnEndGetTrainPosition);
            }
            if ((this.onGetTrainPositionCompletedDelegate == null)) {
                this.onGetTrainPositionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTrainPositionCompleted);
            }
            base.InvokeAsync(this.onBeginGetTrainPositionDelegate, null, this.onEndGetTrainPositionDelegate, this.onGetTrainPositionCompletedDelegate, userState);
        }
        
        public void SetTrainPosition(string possition) {
            base.Channel.SetTrainPosition(possition);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSetTrainPosition(string possition, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSetTrainPosition(possition, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSetTrainPosition(System.IAsyncResult result) {
            base.Channel.EndSetTrainPosition(result);
        }
        
        private System.IAsyncResult OnBeginSetTrainPosition(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string possition = ((string)(inValues[0]));
            return this.BeginSetTrainPosition(possition, callback, asyncState);
        }
        
        private object[] OnEndSetTrainPosition(System.IAsyncResult result) {
            this.EndSetTrainPosition(result);
            return null;
        }
        
        private void OnSetTrainPositionCompleted(object state) {
            if ((this.SetTrainPositionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SetTrainPositionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SetTrainPositionAsync(string possition) {
            this.SetTrainPositionAsync(possition, null);
        }
        
        public void SetTrainPositionAsync(string possition, object userState) {
            if ((this.onBeginSetTrainPositionDelegate == null)) {
                this.onBeginSetTrainPositionDelegate = new BeginOperationDelegate(this.OnBeginSetTrainPosition);
            }
            if ((this.onEndSetTrainPositionDelegate == null)) {
                this.onEndSetTrainPositionDelegate = new EndOperationDelegate(this.OnEndSetTrainPosition);
            }
            if ((this.onSetTrainPositionCompletedDelegate == null)) {
                this.onSetTrainPositionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSetTrainPositionCompleted);
            }
            base.InvokeAsync(this.onBeginSetTrainPositionDelegate, new object[] {
                        possition}, this.onEndSetTrainPositionDelegate, this.onSetTrainPositionCompletedDelegate, userState);
        }
        
        public void SetPassengers(int passengers) {
            base.Channel.SetPassengers(passengers);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSetPassengers(int passengers, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSetPassengers(passengers, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSetPassengers(System.IAsyncResult result) {
            base.Channel.EndSetPassengers(result);
        }
        
        private System.IAsyncResult OnBeginSetPassengers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int passengers = ((int)(inValues[0]));
            return this.BeginSetPassengers(passengers, callback, asyncState);
        }
        
        private object[] OnEndSetPassengers(System.IAsyncResult result) {
            this.EndSetPassengers(result);
            return null;
        }
        
        private void OnSetPassengersCompleted(object state) {
            if ((this.SetPassengersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SetPassengersCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SetPassengersAsync(int passengers) {
            this.SetPassengersAsync(passengers, null);
        }
        
        public void SetPassengersAsync(int passengers, object userState) {
            if ((this.onBeginSetPassengersDelegate == null)) {
                this.onBeginSetPassengersDelegate = new BeginOperationDelegate(this.OnBeginSetPassengers);
            }
            if ((this.onEndSetPassengersDelegate == null)) {
                this.onEndSetPassengersDelegate = new EndOperationDelegate(this.OnEndSetPassengers);
            }
            if ((this.onSetPassengersCompletedDelegate == null)) {
                this.onSetPassengersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSetPassengersCompleted);
            }
            base.InvokeAsync(this.onBeginSetPassengersDelegate, new object[] {
                        passengers}, this.onEndSetPassengersDelegate, this.onSetPassengersCompletedDelegate, userState);
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDisconnect(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDisconnect(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDisconnect(System.IAsyncResult result) {
            base.Channel.EndDisconnect(result);
        }
        
        private System.IAsyncResult OnBeginDisconnect(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginDisconnect(callback, asyncState);
        }
        
        private object[] OnEndDisconnect(System.IAsyncResult result) {
            this.EndDisconnect(result);
            return null;
        }
        
        private void OnDisconnectCompleted(object state) {
            if ((this.DisconnectCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DisconnectCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DisconnectAsync() {
            this.DisconnectAsync(null);
        }
        
        public void DisconnectAsync(object userState) {
            if ((this.onBeginDisconnectDelegate == null)) {
                this.onBeginDisconnectDelegate = new BeginOperationDelegate(this.OnBeginDisconnect);
            }
            if ((this.onEndDisconnectDelegate == null)) {
                this.onEndDisconnectDelegate = new EndOperationDelegate(this.OnEndDisconnect);
            }
            if ((this.onDisconnectCompletedDelegate == null)) {
                this.onDisconnectCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDisconnectCompleted);
            }
            base.InvokeAsync(this.onBeginDisconnectDelegate, null, this.onEndDisconnectDelegate, this.onDisconnectCompletedDelegate, userState);
        }
    }
}