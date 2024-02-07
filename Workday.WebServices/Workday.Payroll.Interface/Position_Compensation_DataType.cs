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
	public class Position_Compensation_DataType : INotifyPropertyChanged
	{
		private DateTime compensation_Effective_DateField;

		private bool compensation_Effective_DateFieldSpecified;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Compensatable_Guidelines_DataType[] compensation_Guidelines_DataField;

		private Employee_Base_Pay_Plan_Assignment_DataType[] salary_and_Hourly_DataField;

		private Employee_Salary_Unit_Plan_Assignment_DataType[] unit_Salary_Plan_DataField;

		private Employee_Allowance_Plan_Assignment_DataType[] allowance_Plan_DataField;

		private Employee_Allowance_Unit_Plan_Assignment_DataType[] unit_Allowance_Plan_DataField;

		private Employee_Bonus_Plan_Assignment_DataType[] bonus_Plan_DataField;

		private Employee_Merit_Plan_Assignment_DataType[] merit_Plan_DataField;

		private Employee_Commission_Plan_Assignment_DataType[] commission_Plan_DataField;

		private Employee_Stock_Plan_Assignment_DataType[] stock_Plan_DataField;

		private Future_Payment_Plan_Assignment_DataType[] future_Payment_Plan_DataField;

		private Employee_Period_Salary_Plan_Assignment_DataType[] period_Salary_Plan_DataField;

		private Employee_Calculated_Plan_Assignment_DataType[] calculated_Plan_DataField;

		private Compensatable_Summary_DataType position_Compensation_Summary_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Compensation_Effective_Date
		{
			get
			{
				return this.compensation_Effective_DateField;
			}
			set
			{
				this.compensation_Effective_DateField = value;
				this.RaisePropertyChanged("Compensation_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Compensation_Effective_DateSpecified
		{
			get
			{
				return this.compensation_Effective_DateFieldSpecified;
			}
			set
			{
				this.compensation_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Compensation_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement("Compensation_Guidelines_Data", Order = 2)]
		public Compensatable_Guidelines_DataType[] Compensation_Guidelines_Data
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

		[XmlElement("Salary_and_Hourly_Data", Order = 3)]
		public Employee_Base_Pay_Plan_Assignment_DataType[] Salary_and_Hourly_Data
		{
			get
			{
				return this.salary_and_Hourly_DataField;
			}
			set
			{
				this.salary_and_Hourly_DataField = value;
				this.RaisePropertyChanged("Salary_and_Hourly_Data");
			}
		}

		[XmlElement("Unit_Salary_Plan_Data", Order = 4)]
		public Employee_Salary_Unit_Plan_Assignment_DataType[] Unit_Salary_Plan_Data
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

		[XmlElement("Allowance_Plan_Data", Order = 5)]
		public Employee_Allowance_Plan_Assignment_DataType[] Allowance_Plan_Data
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

		[XmlElement("Unit_Allowance_Plan_Data", Order = 6)]
		public Employee_Allowance_Unit_Plan_Assignment_DataType[] Unit_Allowance_Plan_Data
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

		[XmlElement("Bonus_Plan_Data", Order = 7)]
		public Employee_Bonus_Plan_Assignment_DataType[] Bonus_Plan_Data
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

		[XmlElement("Merit_Plan_Data", Order = 8)]
		public Employee_Merit_Plan_Assignment_DataType[] Merit_Plan_Data
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

		[XmlElement("Commission_Plan_Data", Order = 9)]
		public Employee_Commission_Plan_Assignment_DataType[] Commission_Plan_Data
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

		[XmlElement("Stock_Plan_Data", Order = 10)]
		public Employee_Stock_Plan_Assignment_DataType[] Stock_Plan_Data
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

		[XmlElement("Future_Payment_Plan_Data", Order = 11)]
		public Future_Payment_Plan_Assignment_DataType[] Future_Payment_Plan_Data
		{
			get
			{
				return this.future_Payment_Plan_DataField;
			}
			set
			{
				this.future_Payment_Plan_DataField = value;
				this.RaisePropertyChanged("Future_Payment_Plan_Data");
			}
		}

		[XmlElement("Period_Salary_Plan_Data", Order = 12)]
		public Employee_Period_Salary_Plan_Assignment_DataType[] Period_Salary_Plan_Data
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

		[XmlElement("Calculated_Plan_Data", Order = 13)]
		public Employee_Calculated_Plan_Assignment_DataType[] Calculated_Plan_Data
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

		[XmlElement(Order = 14)]
		public Compensatable_Summary_DataType Position_Compensation_Summary_Data
		{
			get
			{
				return this.position_Compensation_Summary_DataField;
			}
			set
			{
				this.position_Compensation_Summary_DataField = value;
				this.RaisePropertyChanged("Position_Compensation_Summary_Data");
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
