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
	public class Currency_Conversion_Rate__HV__DataType : INotifyPropertyChanged
	{
		private DateTime effective_TimestampField;

		private CurrencyObjectType from_Currency_ReferenceField;

		private CurrencyObjectType target_Currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private decimal currency_RateField;

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

		[XmlElement(Order = 1)]
		public CurrencyObjectType From_Currency_Reference
		{
			get
			{
				return this.from_Currency_ReferenceField;
			}
			set
			{
				this.from_Currency_ReferenceField = value;
				this.RaisePropertyChanged("From_Currency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Target_Currency_Reference
		{
			get
			{
				return this.target_Currency_ReferenceField;
			}
			set
			{
				this.target_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Target_Currency_Reference");
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

		[XmlElement(Order = 4)]
		public decimal Currency_Rate
		{
			get
			{
				return this.currency_RateField;
			}
			set
			{
				this.currency_RateField = value;
				this.RaisePropertyChanged("Currency_Rate");
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
