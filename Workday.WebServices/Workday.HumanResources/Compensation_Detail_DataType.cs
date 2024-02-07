using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Detail_DataType : INotifyPropertyChanged
	{
		private Compensation_Package_ReferenceType compensation_Package_ReferenceField;

		private Compensation_Grade_ReferenceType compensation_Grade_ReferenceField;

		private Compensation_Grade_Profile_ReferenceType compensation_Grade_Profile_ReferenceField;

		private Compensation_Step_Reference_DataType compensation_Step_ReferenceField;

		private Employee_Compensation_Salary_Plan_Assignment_DataType[] salary_Plan_for_Compensation_DataField;

		private Employee_Compensation_Hourly_Plan_Assignment_DataType[] hourly_Plan_for_Compensation_DataField;

		private Employee_Compensation_Salary_Unit_Plan_Assignment_DataType[] unit_Salary_Plan_for_Compensation_DataField;

		private Employee_Compensation_Allowance_Plan_Assignment_DataType[] allowance_Plan_for_Compensation_DataField;

		private Employee_Compensation_Allowance_Unit_Plan_Assignment_DataType[] unit_Allowance_Plan_for_Compensation_DataField;

		private Employee_Compensation_Bonus_Plan_Assignment_DataType[] bonus_Plan_for_Compensation_DataField;

		private Employee_Compensation_Merit_Plan_Assignment_DataType[] merit_Plan_for_Compensation_DataField;

		private Employee_Compensation_Commission_Plan_Assignment_DataType[] commission_Plan_for_Compensation_DataField;

		private Employee_Compensation_Period_Salary_Plan_Assignment_DataType[] period_Salary_Plan_for_Compensation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Package_ReferenceType Compensation_Package_Reference
		{
			get
			{
				return this.compensation_Package_ReferenceField;
			}
			set
			{
				this.compensation_Package_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Package_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_Grade_ReferenceType Compensation_Grade_Reference
		{
			get
			{
				return this.compensation_Grade_ReferenceField;
			}
			set
			{
				this.compensation_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Compensation_Grade_Profile_ReferenceType Compensation_Grade_Profile_Reference
		{
			get
			{
				return this.compensation_Grade_Profile_ReferenceField;
			}
			set
			{
				this.compensation_Grade_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Profile_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Compensation_Step_Reference_DataType Compensation_Step_Reference
		{
			get
			{
				return this.compensation_Step_ReferenceField;
			}
			set
			{
				this.compensation_Step_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Step_Reference");
			}
		}

		[XmlElement("Salary_Plan_for_Compensation_Data", Order = 4)]
		public Employee_Compensation_Salary_Plan_Assignment_DataType[] Salary_Plan_for_Compensation_Data
		{
			get
			{
				return this.salary_Plan_for_Compensation_DataField;
			}
			set
			{
				this.salary_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Salary_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Hourly_Plan_for_Compensation_Data", Order = 5)]
		public Employee_Compensation_Hourly_Plan_Assignment_DataType[] Hourly_Plan_for_Compensation_Data
		{
			get
			{
				return this.hourly_Plan_for_Compensation_DataField;
			}
			set
			{
				this.hourly_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Hourly_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Unit_Salary_Plan_for_Compensation_Data", Order = 6)]
		public Employee_Compensation_Salary_Unit_Plan_Assignment_DataType[] Unit_Salary_Plan_for_Compensation_Data
		{
			get
			{
				return this.unit_Salary_Plan_for_Compensation_DataField;
			}
			set
			{
				this.unit_Salary_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Unit_Salary_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Allowance_Plan_for_Compensation_Data", Order = 7)]
		public Employee_Compensation_Allowance_Plan_Assignment_DataType[] Allowance_Plan_for_Compensation_Data
		{
			get
			{
				return this.allowance_Plan_for_Compensation_DataField;
			}
			set
			{
				this.allowance_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Unit_Allowance_Plan_for_Compensation_Data", Order = 8)]
		public Employee_Compensation_Allowance_Unit_Plan_Assignment_DataType[] Unit_Allowance_Plan_for_Compensation_Data
		{
			get
			{
				return this.unit_Allowance_Plan_for_Compensation_DataField;
			}
			set
			{
				this.unit_Allowance_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Unit_Allowance_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Bonus_Plan_for_Compensation_Data", Order = 9)]
		public Employee_Compensation_Bonus_Plan_Assignment_DataType[] Bonus_Plan_for_Compensation_Data
		{
			get
			{
				return this.bonus_Plan_for_Compensation_DataField;
			}
			set
			{
				this.bonus_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Bonus_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Merit_Plan_for_Compensation_Data", Order = 10)]
		public Employee_Compensation_Merit_Plan_Assignment_DataType[] Merit_Plan_for_Compensation_Data
		{
			get
			{
				return this.merit_Plan_for_Compensation_DataField;
			}
			set
			{
				this.merit_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Merit_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Commission_Plan_for_Compensation_Data", Order = 11)]
		public Employee_Compensation_Commission_Plan_Assignment_DataType[] Commission_Plan_for_Compensation_Data
		{
			get
			{
				return this.commission_Plan_for_Compensation_DataField;
			}
			set
			{
				this.commission_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Commission_Plan_for_Compensation_Data");
			}
		}

		[XmlElement("Period_Salary_Plan_for_Compensation_Data", Order = 12)]
		public Employee_Compensation_Period_Salary_Plan_Assignment_DataType[] Period_Salary_Plan_for_Compensation_Data
		{
			get
			{
				return this.period_Salary_Plan_for_Compensation_DataField;
			}
			set
			{
				this.period_Salary_Plan_for_Compensation_DataField = value;
				this.RaisePropertyChanged("Period_Salary_Plan_for_Compensation_Data");
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
