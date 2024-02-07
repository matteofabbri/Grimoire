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
	public class External_Payroll_Input_Currency_Conversion_DataType : INotifyPropertyChanged
	{
		private decimal amount_ValueField;

		private bool amount_ValueFieldSpecified;

		private decimal goal_AmountField;

		private bool goal_AmountFieldSpecified;

		private decimal adjustment_ValueField;

		private bool adjustment_ValueFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Amount_Value
		{
			get
			{
				return this.amount_ValueField;
			}
			set
			{
				this.amount_ValueField = value;
				this.RaisePropertyChanged("Amount_Value");
			}
		}

		[XmlIgnore]
		public bool Amount_ValueSpecified
		{
			get
			{
				return this.amount_ValueFieldSpecified;
			}
			set
			{
				this.amount_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Amount_ValueSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Goal_Amount
		{
			get
			{
				return this.goal_AmountField;
			}
			set
			{
				this.goal_AmountField = value;
				this.RaisePropertyChanged("Goal_Amount");
			}
		}

		[XmlIgnore]
		public bool Goal_AmountSpecified
		{
			get
			{
				return this.goal_AmountFieldSpecified;
			}
			set
			{
				this.goal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Goal_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Adjustment_Value
		{
			get
			{
				return this.adjustment_ValueField;
			}
			set
			{
				this.adjustment_ValueField = value;
				this.RaisePropertyChanged("Adjustment_Value");
			}
		}

		[XmlIgnore]
		public bool Adjustment_ValueSpecified
		{
			get
			{
				return this.adjustment_ValueFieldSpecified;
			}
			set
			{
				this.adjustment_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_ValueSpecified");
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
