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
	public class Retirement_Savings_Election_for_Coverage_Type_DataType : INotifyPropertyChanged
	{
		private DateTime coverage_Begin_DateField;

		private DateTime original_Coverage_Begin_DateField;

		private bool original_Coverage_Begin_DateFieldSpecified;

		private DateTime deduction_Begin_DateField;

		private bool deduction_Begin_DateFieldSpecified;

		private DateTime original_Deduction_Begin_DateField;

		private bool original_Deduction_Begin_DateFieldSpecified;

		private Retirement_Savings_PlanObjectType retirement_Savings_Plan_ReferenceField;

		private decimal employee_Contribution_Allocation_PercentField;

		private bool employee_Contribution_Allocation_PercentFieldSpecified;

		private decimal employer_Contribution_Allocation_PercentField;

		private bool employer_Contribution_Allocation_PercentFieldSpecified;

		private Beneficiary_Allocation_for_Change_Benefits_DataType[] beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Coverage_Begin_Date
		{
			get
			{
				return this.coverage_Begin_DateField;
			}
			set
			{
				this.coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Coverage_Begin_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Coverage_Begin_DateSpecified
		{
			get
			{
				return this.original_Coverage_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Coverage_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Deduction_Begin_Date
		{
			get
			{
				return this.deduction_Begin_DateField;
			}
			set
			{
				this.deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Deduction_Begin_DateSpecified
		{
			get
			{
				return this.deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Original_Deduction_Begin_Date
		{
			get
			{
				return this.original_Deduction_Begin_DateField;
			}
			set
			{
				this.original_Deduction_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Deduction_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Deduction_Begin_DateSpecified
		{
			get
			{
				return this.original_Deduction_Begin_DateFieldSpecified;
			}
			set
			{
				this.original_Deduction_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Deduction_Begin_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Retirement_Savings_PlanObjectType Retirement_Savings_Plan_Reference
		{
			get
			{
				return this.retirement_Savings_Plan_ReferenceField;
			}
			set
			{
				this.retirement_Savings_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Retirement_Savings_Plan_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Employee_Contribution_Allocation_Percent
		{
			get
			{
				return this.employee_Contribution_Allocation_PercentField;
			}
			set
			{
				this.employee_Contribution_Allocation_PercentField = value;
				this.RaisePropertyChanged("Employee_Contribution_Allocation_Percent");
			}
		}

		[XmlIgnore]
		public bool Employee_Contribution_Allocation_PercentSpecified
		{
			get
			{
				return this.employee_Contribution_Allocation_PercentFieldSpecified;
			}
			set
			{
				this.employee_Contribution_Allocation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Contribution_Allocation_PercentSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Employer_Contribution_Allocation_Percent
		{
			get
			{
				return this.employer_Contribution_Allocation_PercentField;
			}
			set
			{
				this.employer_Contribution_Allocation_PercentField = value;
				this.RaisePropertyChanged("Employer_Contribution_Allocation_Percent");
			}
		}

		[XmlIgnore]
		public bool Employer_Contribution_Allocation_PercentSpecified
		{
			get
			{
				return this.employer_Contribution_Allocation_PercentFieldSpecified;
			}
			set
			{
				this.employer_Contribution_Allocation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Contribution_Allocation_PercentSpecified");
			}
		}

		[XmlElement("Beneficiary_Allocation_Data", Order = 7)]
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
