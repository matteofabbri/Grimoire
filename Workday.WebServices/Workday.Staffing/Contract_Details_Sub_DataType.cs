using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contract_Details_Sub_DataType : INotifyPropertyChanged
	{
		private decimal contract_Pay_RateField;

		private bool contract_Pay_RateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private string contract_Assignment_DetailsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Contract_Pay_Rate
		{
			get
			{
				return this.contract_Pay_RateField;
			}
			set
			{
				this.contract_Pay_RateField = value;
				this.RaisePropertyChanged("Contract_Pay_Rate");
			}
		}

		[XmlIgnore]
		public bool Contract_Pay_RateSpecified
		{
			get
			{
				return this.contract_Pay_RateFieldSpecified;
			}
			set
			{
				this.contract_Pay_RateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Pay_RateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Contract_Assignment_Details
		{
			get
			{
				return this.contract_Assignment_DetailsField;
			}
			set
			{
				this.contract_Assignment_DetailsField = value;
				this.RaisePropertyChanged("Contract_Assignment_Details");
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
