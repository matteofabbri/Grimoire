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
	public class Tax_Rate_DataType : INotifyPropertyChanged
	{
		private string tax_Rate_IDField;

		private string tax_Rate_NameField;

		private CountryObjectType country_ReferenceField;

		private decimal tax_RateField;

		private bool tax_RateFieldSpecified;

		private Tax_AuthorityObjectType tax_Authority_ReferenceField;

		private Tax_CategoryObjectType tax_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Rate_ID
		{
			get
			{
				return this.tax_Rate_IDField;
			}
			set
			{
				this.tax_Rate_IDField = value;
				this.RaisePropertyChanged("Tax_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Rate_Name
		{
			get
			{
				return this.tax_Rate_NameField;
			}
			set
			{
				this.tax_Rate_NameField = value;
				this.RaisePropertyChanged("Tax_Rate_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Tax_Rate
		{
			get
			{
				return this.tax_RateField;
			}
			set
			{
				this.tax_RateField = value;
				this.RaisePropertyChanged("Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool Tax_RateSpecified
		{
			get
			{
				return this.tax_RateFieldSpecified;
			}
			set
			{
				this.tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_RateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Tax_AuthorityObjectType Tax_Authority_Reference
		{
			get
			{
				return this.tax_Authority_ReferenceField;
			}
			set
			{
				this.tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Tax_CategoryObjectType Tax_Category_Reference
		{
			get
			{
				return this.tax_Category_ReferenceField;
			}
			set
			{
				this.tax_Category_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Category_Reference");
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
