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
	public class Currency_Conversion_Rate_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime effective_TimestampField;

		private CurrencyObjectType[] source_Currencies_ReferenceField;

		private CurrencyObjectType[] target_Currencies_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Effective_Timestamp
		{
			get
			{
				return this.effective_TimestampField;
			}
			set
			{
				this.effective_TimestampField = value;
				this.RaisePropertyChanged("Effective_Timestamp");
			}
		}

		[XmlElement("Source_Currencies_Reference", Order = 1)]
		public CurrencyObjectType[] Source_Currencies_Reference
		{
			get
			{
				return this.source_Currencies_ReferenceField;
			}
			set
			{
				this.source_Currencies_ReferenceField = value;
				this.RaisePropertyChanged("Source_Currencies_Reference");
			}
		}

		[XmlElement("Target_Currencies_Reference", Order = 2)]
		public CurrencyObjectType[] Target_Currencies_Reference
		{
			get
			{
				return this.target_Currencies_ReferenceField;
			}
			set
			{
				this.target_Currencies_ReferenceField = value;
				this.RaisePropertyChanged("Target_Currencies_Reference");
			}
		}

		[XmlElement(Order = 3)]
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
