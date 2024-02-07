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
	public class Tax_Status_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType tax_Status_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Transaction_Tax_StatusObjectType transaction_Tax_Status_ReferenceField;

		private Withholding_Tax_StatusObjectType withholding_Tax_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Tax_Status_Reference
		{
			get
			{
				return this.tax_Status_ReferenceField;
			}
			set
			{
				this.tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Transaction_Tax_StatusObjectType Transaction_Tax_Status_Reference
		{
			get
			{
				return this.transaction_Tax_Status_ReferenceField;
			}
			set
			{
				this.transaction_Tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Tax_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Withholding_Tax_StatusObjectType Withholding_Tax_Status_Reference
		{
			get
			{
				return this.withholding_Tax_Status_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Status_Reference");
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
