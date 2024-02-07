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
	public class Currency_Rate_TypeType : INotifyPropertyChanged
	{
		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private Currency_Rate_Type_DataType[] currency_Rate_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
			}
		}

		[XmlElement("Currency_Rate_Type_Data", Order = 1)]
		public Currency_Rate_Type_DataType[] Currency_Rate_Type_Data
		{
			get
			{
				return this.currency_Rate_Type_DataField;
			}
			set
			{
				this.currency_Rate_Type_DataField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Data");
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
