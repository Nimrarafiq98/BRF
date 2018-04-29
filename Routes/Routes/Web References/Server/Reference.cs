﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Routes.Server {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback isvalidOperationCompleted;
        
        private System.Threading.SendOrPostCallback registrationOperationCompleted;
        
        private System.Threading.SendOrPostCallback resetOperationCompleted;
        
        private System.Threading.SendOrPostCallback addrouteOperationCompleted;
        
        private System.Threading.SendOrPostCallback addstopOperationCompleted;
        
        private System.Threading.SendOrPostCallback getstopsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getbusrouteOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::Routes.Properties.Settings.Default.Routes_Server_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event isvalidCompletedEventHandler isvalidCompleted;
        
        /// <remarks/>
        public event registrationCompletedEventHandler registrationCompleted;
        
        /// <remarks/>
        public event resetCompletedEventHandler resetCompleted;
        
        /// <remarks/>
        public event addrouteCompletedEventHandler addrouteCompleted;
        
        /// <remarks/>
        public event addstopCompletedEventHandler addstopCompleted;
        
        /// <remarks/>
        public event getstopsCompletedEventHandler getstopsCompleted;
        
        /// <remarks/>
        public event getbusrouteCompletedEventHandler getbusrouteCompleted;
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/isvalid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void isvalid([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool isvalidResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool isvalidResultSpecified) {
            object[] results = this.Invoke("isvalid", new object[] {
                        username,
                        password});
            isvalidResult = ((bool)(results[0]));
            isvalidResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void isvalidAsync(string username, string password) {
            this.isvalidAsync(username, password, null);
        }
        
        /// <remarks/>
        public void isvalidAsync(string username, string password, object userState) {
            if ((this.isvalidOperationCompleted == null)) {
                this.isvalidOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisvalidOperationCompleted);
            }
            this.InvokeAsync("isvalid", new object[] {
                        username,
                        password}, this.isvalidOperationCompleted, userState);
        }
        
        private void OnisvalidOperationCompleted(object arg) {
            if ((this.isvalidCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isvalidCompleted(this, new isvalidCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/registration", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registration([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password) {
            this.Invoke("registration", new object[] {
                        username,
                        password});
        }
        
        /// <remarks/>
        public void registrationAsync(string username, string password) {
            this.registrationAsync(username, password, null);
        }
        
        /// <remarks/>
        public void registrationAsync(string username, string password, object userState) {
            if ((this.registrationOperationCompleted == null)) {
                this.registrationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregistrationOperationCompleted);
            }
            this.InvokeAsync("registration", new object[] {
                        username,
                        password}, this.registrationOperationCompleted, userState);
        }
        
        private void OnregistrationOperationCompleted(object arg) {
            if ((this.registrationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registrationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/reset", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void reset([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ConfirmPassword, out bool resetResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool resetResultSpecified) {
            object[] results = this.Invoke("reset", new object[] {
                        username,
                        password,
                        ConfirmPassword});
            resetResult = ((bool)(results[0]));
            resetResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void resetAsync(string username, string password, string ConfirmPassword) {
            this.resetAsync(username, password, ConfirmPassword, null);
        }
        
        /// <remarks/>
        public void resetAsync(string username, string password, string ConfirmPassword, object userState) {
            if ((this.resetOperationCompleted == null)) {
                this.resetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnresetOperationCompleted);
            }
            this.InvokeAsync("reset", new object[] {
                        username,
                        password,
                        ConfirmPassword}, this.resetOperationCompleted, userState);
        }
        
        private void OnresetOperationCompleted(object arg) {
            if ((this.resetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.resetCompleted(this, new resetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/addroute", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addroute([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string BusNumber, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string RouteNumber) {
            this.Invoke("addroute", new object[] {
                        BusNumber,
                        RouteNumber});
        }
        
        /// <remarks/>
        public void addrouteAsync(string BusNumber, string RouteNumber) {
            this.addrouteAsync(BusNumber, RouteNumber, null);
        }
        
        /// <remarks/>
        public void addrouteAsync(string BusNumber, string RouteNumber, object userState) {
            if ((this.addrouteOperationCompleted == null)) {
                this.addrouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddrouteOperationCompleted);
            }
            this.InvokeAsync("addroute", new object[] {
                        BusNumber,
                        RouteNumber}, this.addrouteOperationCompleted, userState);
        }
        
        private void OnaddrouteOperationCompleted(object arg) {
            if ((this.addrouteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addrouteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/addstop", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addstop([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string StopNumber) {
            this.Invoke("addstop", new object[] {
                        StopNumber});
        }
        
        /// <remarks/>
        public void addstopAsync(string StopNumber) {
            this.addstopAsync(StopNumber, null);
        }
        
        /// <remarks/>
        public void addstopAsync(string StopNumber, object userState) {
            if ((this.addstopOperationCompleted == null)) {
                this.addstopOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddstopOperationCompleted);
            }
            this.InvokeAsync("addstop", new object[] {
                        StopNumber}, this.addstopOperationCompleted, userState);
        }
        
        private void OnaddstopOperationCompleted(object arg) {
            if ((this.addstopCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addstopCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/getstops", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
        public Stops[] getstops() {
            object[] results = this.Invoke("getstops", new object[0]);
            return ((Stops[])(results[0]));
        }
        
        /// <remarks/>
        public void getstopsAsync() {
            this.getstopsAsync(null);
        }
        
        /// <remarks/>
        public void getstopsAsync(object userState) {
            if ((this.getstopsOperationCompleted == null)) {
                this.getstopsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetstopsOperationCompleted);
            }
            this.InvokeAsync("getstops", new object[0], this.getstopsOperationCompleted, userState);
        }
        
        private void OngetstopsOperationCompleted(object arg) {
            if ((this.getstopsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getstopsCompleted(this, new getstopsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/getbusroute", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
        public Route[] getbusroute() {
            object[] results = this.Invoke("getbusroute", new object[0]);
            return ((Route[])(results[0]));
        }
        
        /// <remarks/>
        public void getbusrouteAsync() {
            this.getbusrouteAsync(null);
        }
        
        /// <remarks/>
        public void getbusrouteAsync(object userState) {
            if ((this.getbusrouteOperationCompleted == null)) {
                this.getbusrouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetbusrouteOperationCompleted);
            }
            this.InvokeAsync("getbusroute", new object[0], this.getbusrouteOperationCompleted, userState);
        }
        
        private void OngetbusrouteOperationCompleted(object arg) {
            if ((this.getbusrouteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getbusrouteCompleted(this, new getbusrouteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    public partial class Stops {
        
        private string stopName1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StopName1 {
            get {
                return this.stopName1Field;
            }
            set {
                this.stopName1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    public partial class Route {
        
        private string busNumber1Field;
        
        private string routeNumber1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string BusNumber1 {
            get {
                return this.busNumber1Field;
            }
            set {
                this.busNumber1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string RouteNumber1 {
            get {
                return this.routeNumber1Field;
            }
            set {
                this.routeNumber1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void isvalidCompletedEventHandler(object sender, isvalidCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isvalidCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isvalidCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool isvalidResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool isvalidResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void registrationCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void resetCompletedEventHandler(object sender, resetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class resetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal resetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool resetResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool resetResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void addrouteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void addstopCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void getstopsCompletedEventHandler(object sender, getstopsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getstopsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getstopsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Stops[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Stops[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void getbusrouteCompletedEventHandler(object sender, getbusrouteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getbusrouteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getbusrouteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Route[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Route[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591