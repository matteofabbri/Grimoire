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
	public class Put_Currency_Conversion_Rates_Response_DataType : INotifyPropertyChanged
	{
		private Currency_Conversion_RateObjectType currency_Conversion_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Currency_Conversion_RateObjectType Currency_Conversion_Rate_Reference
		{
			get
			{
				return this.currency_Conversion_Rate_ReferenceField;
			}
			set
			{
				this.currency_Conversion_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rate_Reference");
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
