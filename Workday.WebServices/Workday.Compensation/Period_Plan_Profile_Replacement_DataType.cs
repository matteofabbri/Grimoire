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
	public class Period_Plan_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private decimal default_Compensation_Period_MultiplierField;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

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
		public decimal Default_Compensation_Period_Multiplier
		{
			get
			{
				return this.default_Compensation_Period_MultiplierField;
			}
			set
			{
				this.default_Compensation_Period_MultiplierField = value;
				this.RaisePropertyChanged("Default_Compensation_Period_Multiplier");
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
