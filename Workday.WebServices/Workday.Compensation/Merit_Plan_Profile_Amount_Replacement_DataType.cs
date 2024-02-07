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
	public class Merit_Plan_Profile_Amount_Replacement_DataType : INotifyPropertyChanged
	{
		private decimal profile_AmountField;

		private bool profile_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Condition_RuleObjectType condition_Rule_ReferenceField;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Profile_Amount
		{
			get
			{
				return this.profile_AmountField;
			}
			set
			{
				this.profile_AmountField = value;
				this.RaisePropertyChanged("Profile_Amount");
			}
		}

		[XmlIgnore]
		public bool Profile_AmountSpecified
		{
			get
			{
				return this.profile_AmountFieldSpecified;
			}
			set
			{
				this.profile_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Profile_AmountSpecified");
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
		public Condition_RuleObjectType Condition_Rule_Reference
		{
			get
			{
				return this.condition_Rule_ReferenceField;
			}
			set
			{
				this.condition_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Rule_Reference");
			}
		}

		[XmlElement(Order = 3)]
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
