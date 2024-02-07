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
	public class Commission_Plan_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal draw_AmountField;

		private bool draw_AmountFieldSpecified;

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
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Draw_Amount
		{
			get
			{
				return this.draw_AmountField;
			}
			set
			{
				this.draw_AmountField = value;
				this.RaisePropertyChanged("Draw_Amount");
			}
		}

		[XmlIgnore]
		public bool Draw_AmountSpecified
		{
			get
			{
				return this.draw_AmountFieldSpecified;
			}
			set
			{
				this.draw_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Draw_AmountSpecified");
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
