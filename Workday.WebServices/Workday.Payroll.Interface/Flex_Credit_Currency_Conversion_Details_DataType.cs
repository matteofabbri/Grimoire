using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Flex_Credit_Currency_Conversion_Details_DataType : INotifyPropertyChanged
	{
		private decimal flex_Credit_ValueField;

		private bool flex_Credit_ValueFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Flex_Credit_Value
		{
			get
			{
				return this.flex_Credit_ValueField;
			}
			set
			{
				this.flex_Credit_ValueField = value;
				this.RaisePropertyChanged("Flex_Credit_Value");
			}
		}

		[XmlIgnore]
		public bool Flex_Credit_ValueSpecified
		{
			get
			{
				return this.flex_Credit_ValueFieldSpecified;
			}
			set
			{
				this.flex_Credit_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Flex_Credit_ValueSpecified");
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
