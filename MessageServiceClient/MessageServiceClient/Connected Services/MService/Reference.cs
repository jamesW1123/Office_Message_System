﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageServiceClientApp.MService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DataComm")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Display_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string User_NameField;
        
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
        public string Display_Name {
            get {
                return this.Display_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Display_NameField, value) != true)) {
                    this.Display_NameField = value;
                    this.RaisePropertyChanged("Display_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User_Name {
            get {
                return this.User_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.User_NameField, value) != true)) {
                    this.User_NameField = value;
                    this.RaisePropertyChanged("User_Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/DataComm")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Date_TakenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DeliveredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Message_TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecipientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Sent_FromField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date_Taken {
            get {
                return this.Date_TakenField;
            }
            set {
                if ((object.ReferenceEquals(this.Date_TakenField, value) != true)) {
                    this.Date_TakenField = value;
                    this.RaisePropertyChanged("Date_Taken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Deleted {
            get {
                return this.DeletedField;
            }
            set {
                if ((this.DeletedField.Equals(value) != true)) {
                    this.DeletedField = value;
                    this.RaisePropertyChanged("Deleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Delivered {
            get {
                return this.DeliveredField;
            }
            set {
                if ((this.DeliveredField.Equals(value) != true)) {
                    this.DeliveredField = value;
                    this.RaisePropertyChanged("Delivered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message_Text {
            get {
                return this.Message_TextField;
            }
            set {
                if ((object.ReferenceEquals(this.Message_TextField, value) != true)) {
                    this.Message_TextField = value;
                    this.RaisePropertyChanged("Message_Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mid {
            get {
                return this.MidField;
            }
            set {
                if ((this.MidField.Equals(value) != true)) {
                    this.MidField = value;
                    this.RaisePropertyChanged("Mid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Read {
            get {
                return this.ReadField;
            }
            set {
                if ((this.ReadField.Equals(value) != true)) {
                    this.ReadField = value;
                    this.RaisePropertyChanged("Read");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recipient {
            get {
                return this.RecipientField;
            }
            set {
                if ((object.ReferenceEquals(this.RecipientField, value) != true)) {
                    this.RecipientField = value;
                    this.RaisePropertyChanged("Recipient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sent_From {
            get {
                return this.Sent_FromField;
            }
            set {
                if ((object.ReferenceEquals(this.Sent_FromField, value) != true)) {
                    this.Sent_FromField = value;
                    this.RaisePropertyChanged("Sent_From");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MService.IMessageService", CallbackContract=typeof(MessageServiceClientApp.MService.IMessageServiceCallback))]
    public interface IMessageService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/DeleteMessage")]
        void DeleteMessage(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/DeleteMessage")]
        System.Threading.Tasks.Task DeleteMessageAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetActiveUsers", ReplyAction="http://tempuri.org/IMessageService/GetActiveUsersResponse")]
        MessageServiceClientApp.MService.User[] GetActiveUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetActiveUsers", ReplyAction="http://tempuri.org/IMessageService/GetActiveUsersResponse")]
        System.Threading.Tasks.Task<MessageServiceClientApp.MService.User[]> GetActiveUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetAllMessages", ReplyAction="http://tempuri.org/IMessageService/GetAllMessagesResponse")]
        MessageServiceClientApp.MService.Message[] GetAllMessages(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetAllMessages", ReplyAction="http://tempuri.org/IMessageService/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetAllMessagesAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetDeletedMessages", ReplyAction="http://tempuri.org/IMessageService/GetDeletedMessagesResponse")]
        MessageServiceClientApp.MService.Message[] GetDeletedMessages(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetDeletedMessages", ReplyAction="http://tempuri.org/IMessageService/GetDeletedMessagesResponse")]
        System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetDeletedMessagesAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetNewMessages", ReplyAction="http://tempuri.org/IMessageService/GetNewMessagesResponse")]
        MessageServiceClientApp.MService.Message[] GetNewMessages(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetNewMessages", ReplyAction="http://tempuri.org/IMessageService/GetNewMessagesResponse")]
        System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetNewMessagesAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Join")]
        void Join(string userId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Join")]
        System.Threading.Tasks.Task JoinAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Leave")]
        void Leave(string userId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/Leave")]
        System.Threading.Tasks.Task LeaveAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkDelivered")]
        void MarkDelivered(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkDelivered")]
        System.Threading.Tasks.Task MarkDeliveredAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkNotDelivered")]
        void MarkNotDelivered(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkNotDelivered")]
        System.Threading.Tasks.Task MarkNotDeliveredAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkNotRead")]
        void MarkNotRead(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkNotRead")]
        System.Threading.Tasks.Task MarkNotReadAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkRead")]
        void MarkRead(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/MarkRead")]
        System.Threading.Tasks.Task MarkReadAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/RegisterUser", ReplyAction="http://tempuri.org/IMessageService/RegisterUserResponse")]
        bool RegisterUser(MessageServiceClientApp.MService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/RegisterUser", ReplyAction="http://tempuri.org/IMessageService/RegisterUserResponse")]
        System.Threading.Tasks.Task<bool> RegisterUserAsync(MessageServiceClientApp.MService.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/RestoreMessage")]
        void RestoreMessage(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/RestoreMessage")]
        System.Threading.Tasks.Task RestoreMessageAsync(int mid);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/SendMessage")]
        void SendMessage(MessageServiceClientApp.MService.Message message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(MessageServiceClientApp.MService.Message message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMessageService/RecieveMessage")]
        void RecieveMessage(MessageServiceClientApp.MService.Message message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceChannel : MessageServiceClientApp.MService.IMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageServiceClient : System.ServiceModel.DuplexClientBase<MessageServiceClientApp.MService.IMessageService>, MessageServiceClientApp.MService.IMessageService {
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void DeleteMessage(int mid) {
            base.Channel.DeleteMessage(mid);
        }
        
        public System.Threading.Tasks.Task DeleteMessageAsync(int mid) {
            return base.Channel.DeleteMessageAsync(mid);
        }
        
        public MessageServiceClientApp.MService.User[] GetActiveUsers() {
            return base.Channel.GetActiveUsers();
        }
        
        public System.Threading.Tasks.Task<MessageServiceClientApp.MService.User[]> GetActiveUsersAsync() {
            return base.Channel.GetActiveUsersAsync();
        }
        
        public MessageServiceClientApp.MService.Message[] GetAllMessages(string id) {
            return base.Channel.GetAllMessages(id);
        }
        
        public System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetAllMessagesAsync(string id) {
            return base.Channel.GetAllMessagesAsync(id);
        }
        
        public MessageServiceClientApp.MService.Message[] GetDeletedMessages(string id) {
            return base.Channel.GetDeletedMessages(id);
        }
        
        public System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetDeletedMessagesAsync(string id) {
            return base.Channel.GetDeletedMessagesAsync(id);
        }
        
        public MessageServiceClientApp.MService.Message[] GetNewMessages(string id) {
            return base.Channel.GetNewMessages(id);
        }
        
        public System.Threading.Tasks.Task<MessageServiceClientApp.MService.Message[]> GetNewMessagesAsync(string id) {
            return base.Channel.GetNewMessagesAsync(id);
        }
        
        public void Join(string userId) {
            base.Channel.Join(userId);
        }
        
        public System.Threading.Tasks.Task JoinAsync(string userId) {
            return base.Channel.JoinAsync(userId);
        }
        
        public void Leave(string userId) {
            base.Channel.Leave(userId);
        }
        
        public System.Threading.Tasks.Task LeaveAsync(string userId) {
            return base.Channel.LeaveAsync(userId);
        }
        
        public void MarkDelivered(int mid) {
            base.Channel.MarkDelivered(mid);
        }
        
        public System.Threading.Tasks.Task MarkDeliveredAsync(int mid) {
            return base.Channel.MarkDeliveredAsync(mid);
        }
        
        public void MarkNotDelivered(int mid) {
            base.Channel.MarkNotDelivered(mid);
        }
        
        public System.Threading.Tasks.Task MarkNotDeliveredAsync(int mid) {
            return base.Channel.MarkNotDeliveredAsync(mid);
        }
        
        public void MarkNotRead(int mid) {
            base.Channel.MarkNotRead(mid);
        }
        
        public System.Threading.Tasks.Task MarkNotReadAsync(int mid) {
            return base.Channel.MarkNotReadAsync(mid);
        }
        
        public void MarkRead(int mid) {
            base.Channel.MarkRead(mid);
        }
        
        public System.Threading.Tasks.Task MarkReadAsync(int mid) {
            return base.Channel.MarkReadAsync(mid);
        }
        
        public bool RegisterUser(MessageServiceClientApp.MService.User user) {
            return base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterUserAsync(MessageServiceClientApp.MService.User user) {
            return base.Channel.RegisterUserAsync(user);
        }
        
        public void RestoreMessage(int mid) {
            base.Channel.RestoreMessage(mid);
        }
        
        public System.Threading.Tasks.Task RestoreMessageAsync(int mid) {
            return base.Channel.RestoreMessageAsync(mid);
        }
        
        public void SendMessage(MessageServiceClientApp.MService.Message message) {
            base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(MessageServiceClientApp.MService.Message message) {
            return base.Channel.SendMessageAsync(message);
        }
    }
}
