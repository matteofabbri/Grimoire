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
	public class Withholding_Tax_Code_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string tax_Code_NameField;

		private CountryObjectType country_ReferenceField;

		private Tax_RateObjectType[] tax_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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

		[XmlElement("Tax_Rate_Reference", Order = 3)]
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
