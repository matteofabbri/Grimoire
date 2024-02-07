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
	public class Flex_Credit_Details_DataType : INotifyPropertyChanged
	{
		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal flex_Credit_ValueField;

		private bool flex_Credit_ValueFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Flex_Credit_Currency_Conversion_Details_DataType currency_Conversion_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Flex_Credit_Currency_Conversion_Details_DataType Currency_Conversion_Details_Data
		{
			get
			{
				return this.currency_Conversion_Details_DataField;
			}
			set
			{
				this.currency_Conversion_Details_DataField = value;
				this.RaisePropertyChanged("Currency_Conversion_Details_Data");
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
