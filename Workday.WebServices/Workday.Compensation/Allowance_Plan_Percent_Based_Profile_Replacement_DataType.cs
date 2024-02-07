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
	public class Allowance_Plan_Percent_Based_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private decimal percentField;

		private bool percentFieldSpecified;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private decimal ceiling_AmountField;

		private bool ceiling_AmountFieldSpecified;

		private CurrencyObjectType ceiling_Currency_ReferenceField;

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
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Compensation_BasisObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Ceiling_Amount
		{
			get
			{
				return this.ceiling_AmountField;
			}
			set
			{
				this.ceiling_AmountField = value;
				this.RaisePropertyChanged("Ceiling_Amount");
			}
		}

		[XmlIgnore]
		public bool Ceiling_AmountSpecified
		{
			get
			{
				return this.ceiling_AmountFieldSpecified;
			}
			set
			{
				this.ceiling_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Ceiling_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Ceiling_Currency_Reference
		{
			get
			{
				return this.ceiling_Currency_ReferenceField;
			}
			set
			{
				this.ceiling_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Ceiling_Currency_Reference");
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
