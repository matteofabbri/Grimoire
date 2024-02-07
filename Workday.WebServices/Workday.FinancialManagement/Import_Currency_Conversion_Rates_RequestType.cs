using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_Currency_Conversion_Rates_RequestType : INotifyPropertyChanged
	{
		private bool calculate_Inverse_RateField;

		private bool calculate_Inverse_RateFieldSpecified;

		private Currency_Conversion_Rate__HV__DataType[] currency_Conversion_Rate_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Calculate_Inverse_Rate
		{
			get
			{
				return this.calculate_Inverse_RateField;
			}
			set
			{
				this.calculate_Inverse_RateField = value;
				this.RaisePropertyChanged("Calculate_Inverse_Rate");
			}
		}

		[XmlIgnore]
		public bool Calculate_Inverse_RateSpecified
		{
			get
			{
				return this.calculate_Inverse_RateFieldSpecified;
			}
			set
			{
				this.calculate_Inverse_RateFieldSpecified = value;
				this.RaisePropertyChanged("Calculate_Inverse_RateSpecified");
			}
		}

		[XmlElement("Currency_Conversion_Rate_Data", Order = 1)]
		public Currency_Conversion_Rate__HV__DataType[] Currency_Conversion_Rate_Data
		{
			get
			{
				return this.currency_Conversion_Rate_DataField;
			}
			set
			{
				this.currency_Conversion_Rate_DataField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rate_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
