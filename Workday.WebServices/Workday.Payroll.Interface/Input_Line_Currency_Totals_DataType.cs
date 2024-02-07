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
	public class Input_Line_Currency_Totals_DataType : INotifyPropertyChanged
	{
		private CurrencyObjectType currency_ReferenceField;

		private decimal countField;

		private bool countFieldSpecified;

		private decimal sum_Input_ValueField;

		private bool sum_Input_ValueFieldSpecified;

		private decimal sum_Goal_AmountField;

		private bool sum_Goal_AmountFieldSpecified;

		private decimal sum_Adjustment_ValueField;

		private bool sum_Adjustment_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public decimal Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		[XmlIgnore]
		public bool CountSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
				this.RaisePropertyChanged("CountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Sum_Input_Value
		{
			get
			{
				return this.sum_Input_ValueField;
			}
			set
			{
				this.sum_Input_ValueField = value;
				this.RaisePropertyChanged("Sum_Input_Value");
			}
		}

		[XmlIgnore]
		public bool Sum_Input_ValueSpecified
		{
			get
			{
				return this.sum_Input_ValueFieldSpecified;
			}
			set
			{
				this.sum_Input_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Sum_Input_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Sum_Goal_Amount
		{
			get
			{
				return this.sum_Goal_AmountField;
			}
			set
			{
				this.sum_Goal_AmountField = value;
				this.RaisePropertyChanged("Sum_Goal_Amount");
			}
		}

		[XmlIgnore]
		public bool Sum_Goal_AmountSpecified
		{
			get
			{
				return this.sum_Goal_AmountFieldSpecified;
			}
			set
			{
				this.sum_Goal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Sum_Goal_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Sum_Adjustment_Value
		{
			get
			{
				return this.sum_Adjustment_ValueField;
			}
			set
			{
				this.sum_Adjustment_ValueField = value;
				this.RaisePropertyChanged("Sum_Adjustment_Value");
			}
		}

		[XmlIgnore]
		public bool Sum_Adjustment_ValueSpecified
		{
			get
			{
				return this.sum_Adjustment_ValueFieldSpecified;
			}
			set
			{
				this.sum_Adjustment_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Sum_Adjustment_ValueSpecified");
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
