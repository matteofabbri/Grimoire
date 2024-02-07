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
	public class Put_Currency_Conversion_Rates_ResponseType : INotifyPropertyChanged
	{
		private Put_Currency_Conversion_Rates_Response_DataType[] currency_Conversion_RatesField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Currency_Conversion_Rates", Order = 0)]
		public Put_Currency_Conversion_Rates_Response_DataType[] Currency_Conversion_Rates
		{
			get
			{
				return this.currency_Conversion_RatesField;
			}
			set
			{
				this.currency_Conversion_RatesField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rates");
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
