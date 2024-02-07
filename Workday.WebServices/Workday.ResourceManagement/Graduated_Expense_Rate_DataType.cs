using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Graduated_Expense_Rate_DataType : INotifyPropertyChanged
	{
		private decimal minimum_ValueField;

		private bool minimum_ValueFieldSpecified;

		private decimal average_ValueField;

		private bool average_ValueFieldSpecified;

		private decimal maximum_ValueField;

		private bool maximum_ValueFieldSpecified;

		private decimal rateField;

		private bool rateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Minimum_Value
		{
			get
			{
				return this.minimum_ValueField;
			}
			set
			{
				this.minimum_ValueField = value;
				this.RaisePropertyChanged("Minimum_Value");
			}
		}

		[XmlIgnore]
		public bool Minimum_ValueSpecified
		{
			get
			{
				return this.minimum_ValueFieldSpecified;
			}
			set
			{
				this.minimum_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_ValueSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Average_Value
		{
			get
			{
				return this.average_ValueField;
			}
			set
			{
				this.average_ValueField = value;
				this.RaisePropertyChanged("Average_Value");
			}
		}

		[XmlIgnore]
		public bool Average_ValueSpecified
		{
			get
			{
				return this.average_ValueFieldSpecified;
			}
			set
			{
				this.average_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Average_ValueSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Maximum_Value
		{
			get
			{
				return this.maximum_ValueField;
			}
			set
			{
				this.maximum_ValueField = value;
				this.RaisePropertyChanged("Maximum_Value");
			}
		}

		[XmlIgnore]
		public bool Maximum_ValueSpecified
		{
			get
			{
				return this.maximum_ValueFieldSpecified;
			}
			set
			{
				this.maximum_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
				this.RaisePropertyChanged("Rate");
			}
		}

		[XmlIgnore]
		public bool RateSpecified
		{
			get
			{
				return this.rateFieldSpecified;
			}
			set
			{
				this.rateFieldSpecified = value;
				this.RaisePropertyChanged("RateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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
