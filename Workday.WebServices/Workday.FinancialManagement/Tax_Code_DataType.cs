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
	public class Tax_Code_DataType : INotifyPropertyChanged
	{
		private string tax_Code_IDField;

		private string tax_Code_NameField;

		private bool transaction_Tax_ID_RequiredField;

		private bool transaction_Tax_ID_RequiredFieldSpecified;

		private CountryObjectType country_ReferenceField;

		private bool itemField;

		private Tax_RateObjectType[] tax_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Code_ID
		{
			get
			{
				return this.tax_Code_IDField;
			}
			set
			{
				this.tax_Code_IDField = value;
				this.RaisePropertyChanged("Tax_Code_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Code_Name
		{
			get
			{
				return this.tax_Code_NameField;
			}
			set
			{
				this.tax_Code_NameField = value;
				this.RaisePropertyChanged("Tax_Code_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Transaction_Tax_ID_Required
		{
			get
			{
				return this.transaction_Tax_ID_RequiredField;
			}
			set
			{
				this.transaction_Tax_ID_RequiredField = value;
				this.RaisePropertyChanged("Transaction_Tax_ID_Required");
			}
		}

		[XmlIgnore]
		public bool Transaction_Tax_ID_RequiredSpecified
		{
			get
			{
				return this.transaction_Tax_ID_RequiredFieldSpecified;
			}
			set
			{
				this.transaction_Tax_ID_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Tax_ID_RequiredSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Exempt", Order = 4)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Tax_Rate_Reference", Order = 5)]
		public Tax_RateObjectType[] Tax_Rate_Reference
		{
			get
			{
				return this.tax_Rate_ReferenceField;
			}
			set
			{
				this.tax_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Rate_Reference");
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
