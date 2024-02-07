using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Request_DataType : INotifyPropertyChanged
	{
		private string customer_Request_IDField;

		private string customer_IDField;

		private string customer_Request_NameField;

		private External_SourceObjectType customer_Request_Source_ReferenceField;

		private Customer_CategoryObjectType customer_Category_ReferenceField;

		private Customer_GroupObjectType[] customer_Group_ReferenceField;

		private Tax_CodeObjectType customer_Tax_Code_ReferenceField;

		private Payment_TermsObjectType default_Payment_Terms_ReferenceField;

		private Contact_Information_DataType contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Request_ID
		{
			get
			{
				return this.customer_Request_IDField;
			}
			set
			{
				this.customer_Request_IDField = value;
				this.RaisePropertyChanged("Customer_Request_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_ID
		{
			get
			{
				return this.customer_IDField;
			}
			set
			{
				this.customer_IDField = value;
				this.RaisePropertyChanged("Customer_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Request_Name
		{
			get
			{
				return this.customer_Request_NameField;
			}
			set
			{
				this.customer_Request_NameField = value;
				this.RaisePropertyChanged("Customer_Request_Name");
			}
		}

		[XmlElement(Order = 3)]
		public External_SourceObjectType Customer_Request_Source_Reference
		{
			get
			{
				return this.customer_Request_Source_ReferenceField;
			}
			set
			{
				this.customer_Request_Source_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Request_Source_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Customer_CategoryObjectType Customer_Category_Reference
		{
			get
			{
				return this.customer_Category_ReferenceField;
			}
			set
			{
				this.customer_Category_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Category_Reference");
			}
		}

		[XmlElement("Customer_Group_Reference", Order = 5)]
		public Customer_GroupObjectType[] Customer_Group_Reference
		{
			get
			{
				return this.customer_Group_ReferenceField;
			}
			set
			{
				this.customer_Group_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Group_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Tax_CodeObjectType Customer_Tax_Code_Reference
		{
			get
			{
				return this.customer_Tax_Code_ReferenceField;
			}
			set
			{
				this.customer_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Payment_TermsObjectType Default_Payment_Terms_Reference
		{
			get
			{
				return this.default_Payment_Terms_ReferenceField;
			}
			set
			{
				this.default_Payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Default_Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
