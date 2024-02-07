using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Health_Savings_Account_Election_DataType : INotifyPropertyChanged
	{
		private Health_Savings_Account_PlanObjectType health_Savings_Account_Plan_ReferenceField;

		private decimal yTD_Contribution_AmountField;

		private bool yTD_Contribution_AmountFieldSpecified;

		private decimal annual_ContributionField;

		private bool annual_ContributionFieldSpecified;

		private decimal employee_CostField;

		private bool employee_CostFieldSpecified;

		private Beneficiary_Allocation_for_Change_Benefits_DataType[] beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Health_Savings_Account_PlanObjectType Health_Savings_Account_Plan_Reference
		{
			get
			{
				return this.health_Savings_Account_Plan_ReferenceField;
			}
			set
			{
				this.health_Savings_Account_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Health_Savings_Account_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal YTD_Contribution_Amount
		{
			get
			{
				return this.yTD_Contribution_AmountField;
			}
			set
			{
				this.yTD_Contribution_AmountField = value;
				this.RaisePropertyChanged("YTD_Contribution_Amount");
			}
		}

		[XmlIgnore]
		public bool YTD_Contribution_AmountSpecified
		{
			get
			{
				return this.yTD_Contribution_AmountFieldSpecified;
			}
			set
			{
				this.yTD_Contribution_AmountFieldSpecified = value;
				this.RaisePropertyChanged("YTD_Contribution_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Annual_Contribution
		{
			get
			{
				return this.annual_ContributionField;
			}
			set
			{
				this.annual_ContributionField = value;
				this.RaisePropertyChanged("Annual_Contribution");
			}
		}

		[XmlIgnore]
		public bool Annual_ContributionSpecified
		{
			get
			{
				return this.annual_ContributionFieldSpecified;
			}
			set
			{
				this.annual_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("Annual_ContributionSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Employee_Cost
		{
			get
			{
				return this.employee_CostField;
			}
			set
			{
				this.employee_CostField = value;
				this.RaisePropertyChanged("Employee_Cost");
			}
		}

		[XmlIgnore]
		public bool Employee_CostSpecified
		{
			get
			{
				return this.employee_CostFieldSpecified;
			}
			set
			{
				this.employee_CostFieldSpecified = value;
				this.RaisePropertyChanged("Employee_CostSpecified");
			}
		}

		[XmlElement("Beneficiary_Allocation_Data", Order = 4)]
		public Beneficiary_Allocation_for_Change_Benefits_DataType[] Beneficiary_Allocation_Data
		{
			get
			{
				return this.beneficiary_Allocation_DataField;
			}
			set
			{
				this.beneficiary_Allocation_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Allocation_Data");
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
