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

namespace attendanceproject.taimoor_net {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback registerstudentOperationCompleted;
        
        private System.Threading.SendOrPostCallback isvaliduserOperationCompleted;
        
        private System.Threading.SendOrPostCallback addclassOperationCompleted;
        
        private System.Threading.SendOrPostCallback dOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback registerteacherOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::attendanceproject.Properties.Settings.Default.attendanceproject_taimoor_net_Service1;
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
        public event registerstudentCompletedEventHandler registerstudentCompleted;
        
        /// <remarks/>
        public event isvaliduserCompletedEventHandler isvaliduserCompleted;
        
        /// <remarks/>
        public event addclassCompletedEventHandler addclassCompleted;
        
        /// <remarks/>
        public event dCompletedEventHandler dCompleted;
        
        /// <remarks/>
        public event deleteCompletedEventHandler deleteCompleted;
        
        /// <remarks/>
        public event registerteacherCompletedEventHandler registerteacherCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/registerstudent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registerstudent([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string question, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string answer, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string s_class) {
            this.Invoke("registerstudent", new object[] {
                        name,
                        password,
                        email,
                        question,
                        answer,
                        s_class});
        }
        
        /// <remarks/>
        public void registerstudentAsync(string name, string password, string email, string question, string answer, string s_class) {
            this.registerstudentAsync(name, password, email, question, answer, s_class, null);
        }
        
        /// <remarks/>
        public void registerstudentAsync(string name, string password, string email, string question, string answer, string s_class, object userState) {
            if ((this.registerstudentOperationCompleted == null)) {
                this.registerstudentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregisterstudentOperationCompleted);
            }
            this.InvokeAsync("registerstudent", new object[] {
                        name,
                        password,
                        email,
                        question,
                        answer,
                        s_class}, this.registerstudentOperationCompleted, userState);
        }
        
        private void OnregisterstudentOperationCompleted(object arg) {
            if ((this.registerstudentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registerstudentCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/isvaliduser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void isvaliduser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool isvaliduserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool isvaliduserResultSpecified) {
            object[] results = this.Invoke("isvaliduser", new object[] {
                        username,
                        password});
            isvaliduserResult = ((bool)(results[0]));
            isvaliduserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void isvaliduserAsync(string username, string password) {
            this.isvaliduserAsync(username, password, null);
        }
        
        /// <remarks/>
        public void isvaliduserAsync(string username, string password, object userState) {
            if ((this.isvaliduserOperationCompleted == null)) {
                this.isvaliduserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisvaliduserOperationCompleted);
            }
            this.InvokeAsync("isvaliduser", new object[] {
                        username,
                        password}, this.isvaliduserOperationCompleted, userState);
        }
        
        private void OnisvaliduserOperationCompleted(object arg) {
            if ((this.isvaliduserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isvaliduserCompleted(this, new isvaliduserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/addclass", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addclass(bool check, [System.Xml.Serialization.XmlIgnoreAttribute()] bool checkSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string s_class, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string subject) {
            this.Invoke("addclass", new object[] {
                        check,
                        checkSpecified,
                        s_class,
                        subject});
        }
        
        /// <remarks/>
        public void addclassAsync(bool check, bool checkSpecified, string s_class, string subject) {
            this.addclassAsync(check, checkSpecified, s_class, subject, null);
        }
        
        /// <remarks/>
        public void addclassAsync(bool check, bool checkSpecified, string s_class, string subject, object userState) {
            if ((this.addclassOperationCompleted == null)) {
                this.addclassOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddclassOperationCompleted);
            }
            this.InvokeAsync("addclass", new object[] {
                        check,
                        checkSpecified,
                        s_class,
                        subject}, this.addclassOperationCompleted, userState);
        }
        
        private void OnaddclassOperationCompleted(object arg) {
            if ((this.addclassCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addclassCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/d", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Attendance_server")]
        public @class[] d() {
            object[] results = this.Invoke("d", new object[0]);
            return ((@class[])(results[0]));
        }
        
        /// <remarks/>
        public void dAsync() {
            this.dAsync(null);
        }
        
        /// <remarks/>
        public void dAsync(object userState) {
            if ((this.dOperationCompleted == null)) {
                this.dOperationCompleted = new System.Threading.SendOrPostCallback(this.OndOperationCompleted);
            }
            this.InvokeAsync("d", new object[0], this.dOperationCompleted, userState);
        }
        
        private void OndOperationCompleted(object arg) {
            if ((this.dCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dCompleted(this, new dCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/delete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void delete(int a, [System.Xml.Serialization.XmlIgnoreAttribute()] bool aSpecified) {
            this.Invoke("delete", new object[] {
                        a,
                        aSpecified});
        }
        
        /// <remarks/>
        public void deleteAsync(int a, bool aSpecified) {
            this.deleteAsync(a, aSpecified, null);
        }
        
        /// <remarks/>
        public void deleteAsync(int a, bool aSpecified, object userState) {
            if ((this.deleteOperationCompleted == null)) {
                this.deleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteOperationCompleted);
            }
            this.InvokeAsync("delete", new object[] {
                        a,
                        aSpecified}, this.deleteOperationCompleted, userState);
        }
        
        private void OndeleteOperationCompleted(object arg) {
            if ((this.deleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/registerteacher", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void registerteacher([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string qualification) {
            this.Invoke("registerteacher", new object[] {
                        name,
                        password,
                        email,
                        qualification});
        }
        
        /// <remarks/>
        public void registerteacherAsync(string name, string password, string email, string qualification) {
            this.registerteacherAsync(name, password, email, qualification, null);
        }
        
        /// <remarks/>
        public void registerteacherAsync(string name, string password, string email, string qualification, object userState) {
            if ((this.registerteacherOperationCompleted == null)) {
                this.registerteacherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregisterteacherOperationCompleted);
            }
            this.InvokeAsync("registerteacher", new object[] {
                        name,
                        password,
                        email,
                        qualification}, this.registerteacherOperationCompleted, userState);
        }
        
        private void OnregisterteacherOperationCompleted(object arg) {
            if ((this.registerteacherCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registerteacherCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Attendance_server")]
    public partial class @class {
        
        private bool checkField;
        
        private bool checkFieldSpecified;
        
        private string s_classField;
        
        private string subjectField;
        
        /// <remarks/>
        public bool Check {
            get {
                return this.checkField;
            }
            set {
                this.checkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckSpecified {
            get {
                return this.checkFieldSpecified;
            }
            set {
                this.checkFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string S_class {
            get {
                return this.s_classField;
            }
            set {
                this.s_classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Attendance_server")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void registerstudentCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void isvaliduserCompletedEventHandler(object sender, isvaliduserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isvaliduserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isvaliduserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool isvaliduserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool isvaliduserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void addclassCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void dCompletedEventHandler(object sender, dCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public @class[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((@class[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void deleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void registerteacherCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
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