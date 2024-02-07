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
	public class Payroll_Balance_Request_CriteriaType : INotifyPropertyChanged
	{
		private EmployeeObjectType[] employee_ReferenceField;

		private CompanyObjectType[] company_ReferenceField;

		private Pay_Calculation_SelectionType pay_Calculation_CriteriaField;

		private Balance_Period__All_ObjectType[] balance_Period_Definition_ReferenceField;

		private DateTime balance_Period_As_of_DateField;

		private DateTime balance_Period_Cutoff_DateField;

		private bool balance_Period_Cutoff_DateFieldSpecified;

		private PeriodObjectType period_for_Balance_ReferenceField;

		private DateTime include_Results_Processed_by_ReferenceField;

		private bool include_Results_Processed_by_ReferenceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Employee_Reference", Order = 0)]
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

		[XmlElement("Company_Reference", Order = 1)]
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

		[XmlElement(Order = 2)]
		public Pay_Calculation_SelectionType Pay_Calculation_Criteria
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

		[XmlElement("Balance_Period_Definition_Reference", Order = 3)]
		public Balance_Period__All_ObjectType[] Balance_Period_Definition_Reference
		{
			get
			{
				return this.balance_Period_Definition_ReferenceField;
			}
			set
			{
				this.balance_Period_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Balance_Period_Definition_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Balance_Period_As_of_Date
		{
			get
			{
				return this.balance_Period_As_of_DateField;
			}
			set
			{
				this.balance_Period_As_of_DateField = value;
				this.RaisePropertyChanged("Balance_Period_As_of_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Balance_Period_Cutoff_Date
		{
			get
			{
				return this.balance_Period_Cutoff_DateField;
			}
			set
			{
				this.balance_Period_Cutoff_DateField = value;
				this.RaisePropertyChanged("Balance_Period_Cutoff_Date");
			}
		}

		[XmlIgnore]
		public bool Balance_Period_Cutoff_DateSpecified
		{
			get
			{
				return this.balance_Period_Cutoff_DateFieldSpecified;
			}
			set
			{
				this.balance_Period_Cutoff_DateFieldSpecified = value;
				this.RaisePropertyChanged("Balance_Period_Cutoff_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public PeriodObjectType Period_for_Balance_Reference
		{
			get
			{
				return this.period_for_Balance_ReferenceField;
			}
			set
			{
				this.period_for_Balance_ReferenceField = value;
				this.RaisePropertyChanged("Period_for_Balance_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Include_Results_Processed_by_Reference
		{
			get
			{
				return this.include_Results_Processed_by_ReferenceField;
			}
			set
			{
				this.include_Results_Processed_by_ReferenceField = value;
				this.RaisePropertyChanged("Include_Results_Processed_by_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_Results_Processed_by_ReferenceSpecified
		{
			get
			{
				return this.include_Results_Processed_by_ReferenceFieldSpecified;
			}
			set
			{
				this.include_Results_Processed_by_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_Results_Processed_by_ReferenceSpecified");
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
