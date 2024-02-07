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
	public class Payroll_ROE_Prior_History_Results_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_Reference_NumberObjectType payroll_Reference_Number_ReferenceField;

		private PeriodObjectType reporting_Period_ReferenceField;

		private decimal eI_WagesField;

		private bool eI_WagesFieldSpecified;

		private decimal eI_HoursField;

		private bool eI_HoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
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

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_Reference
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
		public Payroll_Reference_NumberObjectType Payroll_Reference_Number_Reference
		{
			get
			{
				return this.payroll_Reference_Number_ReferenceField;
			}
			set
			{
				this.payroll_Reference_Number_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reference_Number_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public PeriodObjectType Reporting_Period_Reference
		{
			get
			{
				return this.reporting_Period_ReferenceField;
			}
			set
			{
				this.reporting_Period_ReferenceField = value;
				this.RaisePropertyChanged("Reporting_Period_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal EI_Wages
		{
			get
			{
				return this.eI_WagesField;
			}
			set
			{
				this.eI_WagesField = value;
				this.RaisePropertyChanged("EI_Wages");
			}
		}

		[XmlIgnore]
		public bool EI_WagesSpecified
		{
			get
			{
				return this.eI_WagesFieldSpecified;
			}
			set
			{
				this.eI_WagesFieldSpecified = value;
				this.RaisePropertyChanged("EI_WagesSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal EI_Hours
		{
			get
			{
				return this.eI_HoursField;
			}
			set
			{
				this.eI_HoursField = value;
				this.RaisePropertyChanged("EI_Hours");
			}
		}

		[XmlIgnore]
		public bool EI_HoursSpecified
		{
			get
			{
				return this.eI_HoursFieldSpecified;
			}
			set
			{
				this.eI_HoursFieldSpecified = value;
				this.RaisePropertyChanged("EI_HoursSpecified");
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
