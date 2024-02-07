using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Proposed_For_Position_DataType : INotifyPropertyChanged
	{
		private bool initialize_Using_Defaulting_LogicField;

		private bool initialize_Using_Defaulting_LogicFieldSpecified;

		private DateTime employee_Visibility_DateField;

		private bool employee_Visibility_DateFieldSpecified;

		private decimal primary_Compensation_BasisField;

		private bool primary_Compensation_BasisFieldSpecified;

		private Compensatable_Guidelines_DataType compensation_Guidelines_DataField;

		private Proposed_Base_Pay_Plan_Job_Assignment_Container_DataType pay_Plan_DataField;

		private Proposed_Salary_Unit_Plan_Assignment_Container_DataType unit_Salary_Plan_DataField;

		private Proposed_Allowance_Plan_Assignment_Container_DataType allowance_Plan_DataField;

		private Proposed_Allowance_Unit_Plan_Assignment_Container_DataType unit_Allowance_Plan_DataField;

		private Proposed_Bonus_Plan_Assignment_Container_DataType bonus_Plan_DataField;

		private Proposed_Merit_Plan_Assignment_Container_DataType merit_Plan_DataField;

		private Proposed_Commission_Plan_Assignment_Container_DataType commission_Plan_DataField;

		private Proposed_Stock_Plan_Assignment_Container_DataType stock_Plan_DataField;

		private Proposed_Period_Salary_Plan_Assignment_Container_DataType period_Salary_Plan_DataField;

		private Proposed_Calculated_Plan_Assignment_Container_DataType calculated_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Initialize_Using_Defaulting_Logic
		{
			get
			{
				return this.initialize_Using_Defaulting_LogicField;
			}
			set
			{
				this.initialize_Using_Defaulting_LogicField = value;
				this.RaisePropertyChanged("Initialize_Using_Defaulting_Logic");
			}
		}

		[XmlIgnore]
		public bool Initialize_Using_Defaulting_LogicSpecified
		{
			get
			{
				return this.initialize_Using_Defaulting_LogicFieldSpecified;
			}
			set
			{
				this.initialize_Using_Defaulting_LogicFieldSpecified = value;
				this.RaisePropertyChanged("Initialize_Using_Defaulting_LogicSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Employee_Visibility_Date
		{
			get
			{
				return this.employee_Visibility_DateField;
			}
			set
			{
				this.employee_Visibility_DateField = value;
				this.RaisePropertyChanged("Employee_Visibility_Date");
			}
		}

		[XmlIgnore]
		public bool Employee_Visibility_DateSpecified
		{
			get
			{
				return this.employee_Visibility_DateFieldSpecified;
			}
			set
			{
				this.employee_Visibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Visibility_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Primary_Compensation_Basis
		{
			get
			{
				return this.primary_Compensation_BasisField;
			}
			set
			{
				this.primary_Compensation_BasisField = value;
				this.RaisePropertyChanged("Primary_Compensation_Basis");
			}
		}

		[XmlIgnore]
		public bool Primary_Compensation_BasisSpecified
		{
			get
			{
				return this.primary_Compensation_BasisFieldSpecified;
			}
			set
			{
				this.primary_Compensation_BasisFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Compensation_BasisSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Compensatable_Guidelines_DataType Compensation_Guidelines_Data
		{
			get
			{
				return this.compensation_Guidelines_DataField;
			}
			set
			{
				this.compensation_Guidelines_DataField = value;
				this.RaisePropertyChanged("Compensation_Guidelines_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Proposed_Base_Pay_Plan_Job_Assignment_Container_DataType Pay_Plan_Data
		{
			get
			{
				return this.pay_Plan_DataField;
			}
			set
			{
				this.pay_Plan_DataField = value;
				this.RaisePropertyChanged("Pay_Plan_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Proposed_Salary_Unit_Plan_Assignment_Container_DataType Unit_Salary_Plan_Data
		{
			get
			{
				return this.unit_Salary_Plan_DataField;
			}
			set
			{
				this.unit_Salary_Plan_DataField = value;
				this.RaisePropertyChanged("Unit_Salary_Plan_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Proposed_Allowance_Plan_Assignment_Container_DataType Allowance_Plan_Data
		{
			get
			{
				return this.allowance_Plan_DataField;
			}
			set
			{
				this.allowance_Plan_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Proposed_Allowance_Unit_Plan_Assignment_Container_DataType Unit_Allowance_Plan_Data
		{
			get
			{
				return this.unit_Allowance_Plan_DataField;
			}
			set
			{
				this.unit_Allowance_Plan_DataField = value;
				this.RaisePropertyChanged("Unit_Allowance_Plan_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Proposed_Bonus_Plan_Assignment_Container_DataType Bonus_Plan_Data
		{
			get
			{
				return this.bonus_Plan_DataField;
			}
			set
			{
				this.bonus_Plan_DataField = value;
				this.RaisePropertyChanged("Bonus_Plan_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Proposed_Merit_Plan_Assignment_Container_DataType Merit_Plan_Data
		{
			get
			{
				return this.merit_Plan_DataField;
			}
			set
			{
				this.merit_Plan_DataField = value;
				this.RaisePropertyChanged("Merit_Plan_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Proposed_Commission_Plan_Assignment_Container_DataType Commission_Plan_Data
		{
			get
			{
				return this.commission_Plan_DataField;
			}
			set
			{
				this.commission_Plan_DataField = value;
				this.RaisePropertyChanged("Commission_Plan_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Proposed_Stock_Plan_Assignment_Container_DataType Stock_Plan_Data
		{
			get
			{
				return this.stock_Plan_DataField;
			}
			set
			{
				this.stock_Plan_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Proposed_Period_Salary_Plan_Assignment_Container_DataType Period_Salary_Plan_Data
		{
			get
			{
				return this.period_Salary_Plan_DataField;
			}
			set
			{
				this.period_Salary_Plan_DataField = value;
				this.RaisePropertyChanged("Period_Salary_Plan_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Proposed_Calculated_Plan_Assignment_Container_DataType Calculated_Plan_Data
		{
			get
			{
				return this.calculated_Plan_DataField;
			}
			set
			{
				this.calculated_Plan_DataField = value;
				this.RaisePropertyChanged("Calculated_Plan_Data");
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
