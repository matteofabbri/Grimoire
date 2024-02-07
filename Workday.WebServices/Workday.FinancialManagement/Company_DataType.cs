using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_DataType : INotifyPropertyChanged
	{
		private string organization_NameField;

		private string transaction_Tax_IDField;

		private bool vAT_on_PaymentField;

		private bool vAT_on_PaymentFieldSpecified;

		private Tax_ApplicabilityObjectType default_Tax_Applicability_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Tax_ID_DataType[] tax_ID_DataField;

		private IDType[] integration_IDField;

		private Address_DataType[] address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Transaction_Tax_ID
		{
			get
			{
				return this.transaction_Tax_IDField;
			}
			set
			{
				this.transaction_Tax_IDField = value;
				this.RaisePropertyChanged("Transaction_Tax_ID");
			}
		}

		[XmlElement(Order = 2)]
		public bool VAT_on_Payment
		{
			get
			{
				return this.vAT_on_PaymentField;
			}
			set
			{
				this.vAT_on_PaymentField = value;
				this.RaisePropertyChanged("VAT_on_Payment");
			}
		}

		[XmlIgnore]
		public bool VAT_on_PaymentSpecified
		{
			get
			{
				return this.vAT_on_PaymentFieldSpecified;
			}
			set
			{
				this.vAT_on_PaymentFieldSpecified = value;
				this.RaisePropertyChanged("VAT_on_PaymentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Tax_ApplicabilityObjectType Default_Tax_Applicability_Reference
		{
			get
			{
				return this.default_Tax_Applicability_ReferenceField;
			}
			set
			{
				this.default_Tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Tax_CodeObjectType Default_Tax_Code_Reference
		{
			get
			{
				return this.default_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Code_Reference");
			}
		}

		[XmlElement("Tax_ID_Data", Order = 5)]
		public Tax_ID_DataType[] Tax_ID_Data
		{
			get
			{
				return this.tax_ID_DataField;
			}
			set
			{
				this.tax_ID_DataField = value;
				this.RaisePropertyChanged("Tax_ID_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("ID", typeof(IDType), IsNullable = false)]
		public IDType[] Integration_ID
		{
			get
			{
				return this.integration_IDField;
			}
			set
			{
				this.integration_IDField = value;
				this.RaisePropertyChanged("Integration_ID");
			}
		}

		[XmlElement("Address_Data", Order = 7)]
		public Address_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
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
