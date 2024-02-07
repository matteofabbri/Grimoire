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
	public class Payroll_Result_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime start_DateField;

		private DateTime end_DateField;

		private Period_Date_IndicatorObjectType period_Selection_Date_ReferenceField;

		private EmployeeObjectType[] employee_ReferenceField;

		private CompanyObjectType[] company_ReferenceField;

		private Pay_Calculations_SelectedType pay_Calculation_CriteriaField;

		private Run_CategoryObjectType[] run_Category_ReferenceField;

		private Pay_GroupObjectType[] pay_Group_ReferenceField;

		private PeriodObjectType[] period_ReferenceField;

		private Unique_IdentifierObjectType[] settlement_ID_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Period_Date_IndicatorObjectType Period_Selection_Date_Reference
		{
			get
			{
				return this.period_Selection_Date_ReferenceField;
			}
			set
			{
				this.period_Selection_Date_ReferenceField = value;
				this.RaisePropertyChanged("Period_Selection_Date_Reference");
			}
		}

		[XmlElement("Employee_Reference", Order = 3)]
		public EmployeeObjectType[] Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement("Company_Reference", Order = 4)]
		public CompanyObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Pay_Calculations_SelectedType Pay_Calculation_Criteria
		{
			get
			{
				return this.pay_Calculation_CriteriaField;
			}
			set
			{
				this.pay_Calculation_CriteriaField = value;
				this.RaisePropertyChanged("Pay_Calculation_Criteria");
			}
		}

		[XmlElement("Run_Category_Reference", Order = 6)]
		public Run_CategoryObjectType[] Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlElement("Pay_Group_Reference", Order = 7)]
		public Pay_GroupObjectType[] Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement("Period_Reference", Order = 8)]
		public PeriodObjectType[] Period_Reference
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

		[XmlElement("Settlement_ID_Reference", Order = 9)]
		public Unique_IdentifierObjectType[] Settlement_ID_Reference
		{
			get
			{
				return this.settlement_ID_ReferenceField;
			}
			set
			{
				this.settlement_ID_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_ID_Reference");
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
