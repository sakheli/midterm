﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class AuthorDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Birth_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.CityDTO CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.CountryDTO CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.GenderDTO GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Personal_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.ProductDTO[] ProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Unique_IdField;
        
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
        public System.DateTime Birth_Date {
            get {
                return this.Birth_DateField;
            }
            set {
                if ((this.Birth_DateField.Equals(value) != true)) {
                    this.Birth_DateField = value;
                    this.RaisePropertyChanged("Birth_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.ServiceReference.CityDTO City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.ServiceReference.CountryDTO Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
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
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.ServiceReference.GenderDTO Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Personal_Id {
            get {
                return this.Personal_IdField;
            }
            set {
                if ((object.ReferenceEquals(this.Personal_IdField, value) != true)) {
                    this.Personal_IdField = value;
                    this.RaisePropertyChanged("Personal_Id");
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
        public ClientApplication.ServiceReference.ProductDTO[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Unique_Id {
            get {
                return this.Unique_IdField;
            }
            set {
                if ((this.Unique_IdField.Equals(value) != true)) {
                    this.Unique_IdField = value;
                    this.RaisePropertyChanged("Unique_Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CityDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class CityDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Id_CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id_Country {
            get {
                return this.Id_CountryField;
            }
            set {
                if ((this.Id_CountryField.Equals(value) != true)) {
                    this.Id_CountryField = value;
                    this.RaisePropertyChanged("Id_Country");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class CountryDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GenderDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class GenderDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Gender1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string Gender1 {
            get {
                return this.Gender1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Gender1Field, value) != true)) {
                    this.Gender1Field = value;
                    this.RaisePropertyChanged("Gender1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class ProductDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.ProductTypeDTO ProductTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Publish_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.ServiceReference.Publishing_HouseDTO PublishingHouseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Unique_IdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public System.Nullable<int> Pages {
            get {
                return this.PagesField;
            }
            set {
                if ((this.PagesField.Equals(value) != true)) {
                    this.PagesField = value;
                    this.RaisePropertyChanged("Pages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.ServiceReference.ProductTypeDTO ProductType {
            get {
                return this.ProductTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductTypeField, value) != true)) {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Publish_Date {
            get {
                return this.Publish_DateField;
            }
            set {
                if ((this.Publish_DateField.Equals(value) != true)) {
                    this.Publish_DateField = value;
                    this.RaisePropertyChanged("Publish_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.ServiceReference.Publishing_HouseDTO PublishingHouse {
            get {
                return this.PublishingHouseField;
            }
            set {
                if ((object.ReferenceEquals(this.PublishingHouseField, value) != true)) {
                    this.PublishingHouseField = value;
                    this.RaisePropertyChanged("PublishingHouse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Unique_Id {
            get {
                return this.Unique_IdField;
            }
            set {
                if ((this.Unique_IdField.Equals(value) != true)) {
                    this.Unique_IdField = value;
                    this.RaisePropertyChanged("Unique_Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductTypeDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class ProductTypeDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Publishing_HouseDTO", Namespace="WcfService")]
    [System.SerializableAttribute()]
    public partial class Publishing_HouseDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IClientService")]
    public interface IClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAllAuthores", ReplyAction="http://tempuri.org/IClientService/GetAllAuthoresResponse")]
        ClientApplication.ServiceReference.AuthorDTO[] GetAllAuthores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAllAuthores", ReplyAction="http://tempuri.org/IClientService/GetAllAuthoresResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference.AuthorDTO[]> GetAllAuthoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAuthorByUnique_Id", ReplyAction="http://tempuri.org/IClientService/GetAuthorByUnique_IdResponse")]
        ClientApplication.ServiceReference.AuthorDTO GetAuthorByUnique_Id(int Unique_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAuthorByUnique_Id", ReplyAction="http://tempuri.org/IClientService/GetAuthorByUnique_IdResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference.AuthorDTO> GetAuthorByUnique_IdAsync(int Unique_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddNewAuthor", ReplyAction="http://tempuri.org/IClientService/AddNewAuthorResponse")]
        bool AddNewAuthor(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddNewAuthor", ReplyAction="http://tempuri.org/IClientService/AddNewAuthorResponse")]
        System.Threading.Tasks.Task<bool> AddNewAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateAuthor", ReplyAction="http://tempuri.org/IClientService/UpdateAuthorResponse")]
        bool UpdateAuthor(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateAuthor", ReplyAction="http://tempuri.org/IClientService/UpdateAuthorResponse")]
        System.Threading.Tasks.Task<bool> UpdateAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/DeleteAuthor", ReplyAction="http://tempuri.org/IClientService/DeleteAuthorResponse")]
        bool DeleteAuthor(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/DeleteAuthor", ReplyAction="http://tempuri.org/IClientService/DeleteAuthorResponse")]
        System.Threading.Tasks.Task<bool> DeleteAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAllProducts", ReplyAction="http://tempuri.org/IClientService/GetAllProductsResponse")]
        ClientApplication.ServiceReference.ProductDTO[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetAllProducts", ReplyAction="http://tempuri.org/IClientService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetProductByUnique_Id", ReplyAction="http://tempuri.org/IClientService/GetProductByUnique_IdResponse")]
        ClientApplication.ServiceReference.ProductDTO GetProductByUnique_Id(int Unique_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetProductByUnique_Id", ReplyAction="http://tempuri.org/IClientService/GetProductByUnique_IdResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO> GetProductByUnique_IdAsync(int Unique_Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetProductsByAuthorId", ReplyAction="http://tempuri.org/IClientService/GetProductsByAuthorIdResponse")]
        ClientApplication.ServiceReference.ProductDTO[] GetProductsByAuthorId(int AuthorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetProductsByAuthorId", ReplyAction="http://tempuri.org/IClientService/GetProductsByAuthorIdResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO[]> GetProductsByAuthorIdAsync(int AuthorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddNewProduct", ReplyAction="http://tempuri.org/IClientService/AddNewProductResponse")]
        bool AddNewProduct(ClientApplication.ServiceReference.ProductDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddNewProduct", ReplyAction="http://tempuri.org/IClientService/AddNewProductResponse")]
        System.Threading.Tasks.Task<bool> AddNewProductAsync(ClientApplication.ServiceReference.ProductDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateProduct", ReplyAction="http://tempuri.org/IClientService/UpdateProductResponse")]
        bool UpdateProduct(ClientApplication.ServiceReference.ProductDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateProduct", ReplyAction="http://tempuri.org/IClientService/UpdateProductResponse")]
        System.Threading.Tasks.Task<bool> UpdateProductAsync(ClientApplication.ServiceReference.ProductDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/DeleteProduct", ReplyAction="http://tempuri.org/IClientService/DeleteProductResponse")]
        bool DeleteProduct(ClientApplication.ServiceReference.ProductDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/DeleteProduct", ReplyAction="http://tempuri.org/IClientService/DeleteProductResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductAsync(ClientApplication.ServiceReference.ProductDTO obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientServiceChannel : ClientApplication.ServiceReference.IClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceClient : System.ServiceModel.ClientBase<ClientApplication.ServiceReference.IClientService>, ClientApplication.ServiceReference.IClientService {
        
        public ClientServiceClient() {
        }
        
        public ClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientApplication.ServiceReference.AuthorDTO[] GetAllAuthores() {
            return base.Channel.GetAllAuthores();
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference.AuthorDTO[]> GetAllAuthoresAsync() {
            return base.Channel.GetAllAuthoresAsync();
        }
        
        public ClientApplication.ServiceReference.AuthorDTO GetAuthorByUnique_Id(int Unique_Id) {
            return base.Channel.GetAuthorByUnique_Id(Unique_Id);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference.AuthorDTO> GetAuthorByUnique_IdAsync(int Unique_Id) {
            return base.Channel.GetAuthorByUnique_IdAsync(Unique_Id);
        }
        
        public bool AddNewAuthor(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.AddNewAuthor(obj);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.AddNewAuthorAsync(obj);
        }
        
        public bool UpdateAuthor(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.UpdateAuthor(obj);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.UpdateAuthorAsync(obj);
        }
        
        public bool DeleteAuthor(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.DeleteAuthor(obj);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAuthorAsync(ClientApplication.ServiceReference.AuthorDTO obj) {
            return base.Channel.DeleteAuthorAsync(obj);
        }
        
        public ClientApplication.ServiceReference.ProductDTO[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public ClientApplication.ServiceReference.ProductDTO GetProductByUnique_Id(int Unique_Id) {
            return base.Channel.GetProductByUnique_Id(Unique_Id);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO> GetProductByUnique_IdAsync(int Unique_Id) {
            return base.Channel.GetProductByUnique_IdAsync(Unique_Id);
        }
        
        public ClientApplication.ServiceReference.ProductDTO[] GetProductsByAuthorId(int AuthorId) {
            return base.Channel.GetProductsByAuthorId(AuthorId);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference.ProductDTO[]> GetProductsByAuthorIdAsync(int AuthorId) {
            return base.Channel.GetProductsByAuthorIdAsync(AuthorId);
        }
        
        public bool AddNewProduct(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.AddNewProduct(obj);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewProductAsync(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.AddNewProductAsync(obj);
        }
        
        public bool UpdateProduct(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.UpdateProduct(obj);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProductAsync(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.UpdateProductAsync(obj);
        }
        
        public bool DeleteProduct(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.DeleteProduct(obj);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductAsync(ClientApplication.ServiceReference.ProductDTO obj) {
            return base.Channel.DeleteProductAsync(obj);
        }
    }
}
