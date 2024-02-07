using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allowance_Plan_Unit_Based_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private decimal number_of_UnitsField;

		private bool number_of_UnitsFieldSpecified;

		private decimal per_Unit_AmountField;

		private bool per_Unit_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Eligibility_Rule_Reference
		{
			get
			{
				return this.eligibility_Rule_ReferenceField;
			}
			set
			{
				this.eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Number_of_Units
		{
			get
			{
				return this.number_of_UnitsField;
			}
			set
			{
				this.number_of_UnitsField = value;
				this.RaisePropertyChanged("Number_of_Units");
			}
		}

		[XmlIgnore]
		public bool Number_of_UnitsSpecified
		{
			get
			{
				return this.number_of_UnitsFieldSpecified;
			}
			set
			{
				this.number_of_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Per_Unit_Amount
		{
			get
			{
				return this.per_Unit_AmountField;
			}
			set
			{
				this.per_Unit_AmountField = value;
				this.RaisePropertyChanged("Per_Unit_Amount");
			}
		}

		[XmlIgnore]
		public bool Per_Unit_AmountSpecified
		{
			get
			{
				return this.per_Unit_AmountFieldSpecified;
			}
			set
			{
				this.per_Unit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Per_Unit_AmountSpecified");
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
