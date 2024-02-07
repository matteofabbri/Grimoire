using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Run_Pay_Calculation_Process_Calculation_CriteriaType : INotifyPropertyChanged
	{
		private PeriodObjectType period_ReferenceField;

		private Pay_Run_Group_SelectionObjectType[] pay_Run_Group_Selection_ReferenceField;

		private Unique_IdentifierObjectType[] calculation_OptionsField;

		private bool limit_Accounting_Population_Based_on_Calculation_CriteriaField;

		private bool limit_Accounting_Population_Based_on_Calculation_CriteriaFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PeriodObjectType Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement("Pay_Run_Group_Selection_Reference", Order = 1)]
		public Pay_Run_Group_SelectionObjectType[] Pay_Run_Group_Selection_Reference
		{
			get
			{
				return this.pay_Run_Group_Selection_ReferenceField;
			}
			set
			{
				this.pay_Run_Group_Selection_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Run_Group_Selection_Reference");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Pay_Calculation_Status_Reference", typeof(Unique_IdentifierObjectType), IsNullable = false)]
		public Unique_IdentifierObjectType[] Calculation_Options
		{
			get
			{
				return this.calculation_OptionsField;
			}
			set
			{
				this.calculation_OptionsField = value;
				this.RaisePropertyChanged("Calculation_Options");
			}
		}

		[XmlElement(Order = 3)]
		public bool Limit_Accounting_Population_Based_on_Calculation_Criteria
		{
			get
			{
				return this.limit_Accounting_Population_Based_on_Calculation_CriteriaField;
			}
			set
			{
				this.limit_Accounting_Population_Based_on_Calculation_CriteriaField = value;
				this.RaisePropertyChanged("Limit_Accounting_Population_Based_on_Calculation_Criteria");
			}
		}

		[XmlIgnore]
		public bool Limit_Accounting_Population_Based_on_Calculation_CriteriaSpecified
		{
			get
			{
				return this.limit_Accounting_Population_Based_on_Calculation_CriteriaFieldSpecified;
			}
			set
			{
				this.limit_Accounting_Population_Based_on_Calculation_CriteriaFieldSpecified = value;
				this.RaisePropertyChanged("Limit_Accounting_Population_Based_on_Calculation_CriteriaSpecified");
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
