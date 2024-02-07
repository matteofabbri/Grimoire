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
	public class Payee_Benefit_Plan_DataType : INotifyPropertyChanged
	{
		private Benefit_PlanObjectType benefit_Plan_ReferenceField;

		private bool covered_Person_Is_EmployeeField;

		private bool covered_Person_Is_EmployeeFieldSpecified;

		private decimal frequency_Annual_FactorField;

		private bool frequency_Annual_FactorFieldSpecified;

		private Benefit_Plan_Earning_Deduction_Details_DataType[] benefit_Plan_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_PlanObjectType Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Covered_Person_Is_Employee
		{
			get
			{
				return this.covered_Person_Is_EmployeeField;
			}
			set
			{
				this.covered_Person_Is_EmployeeField = value;
				this.RaisePropertyChanged("Covered_Person_Is_Employee");
			}
		}

		[XmlIgnore]
		public bool Covered_Person_Is_EmployeeSpecified
		{
			get
			{
				return this.covered_Person_Is_EmployeeFieldSpecified;
			}
			set
			{
				this.covered_Person_Is_EmployeeFieldSpecified = value;
				this.RaisePropertyChanged("Covered_Person_Is_EmployeeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Frequency_Annual_Factor
		{
			get
			{
				return this.frequency_Annual_FactorField;
			}
			set
			{
				this.frequency_Annual_FactorField = value;
				this.RaisePropertyChanged("Frequency_Annual_Factor");
			}
		}

		[XmlIgnore]
		public bool Frequency_Annual_FactorSpecified
		{
			get
			{
				return this.frequency_Annual_FactorFieldSpecified;
			}
			set
			{
				this.frequency_Annual_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Frequency_Annual_FactorSpecified");
			}
		}

		[XmlElement("Benefit_Plan_Details_Data", Order = 3)]
		public Benefit_Plan_Earning_Deduction_Details_DataType[] Benefit_Plan_Details_Data
		{
			get
			{
				return this.benefit_Plan_Details_DataField;
			}
			set
			{
				this.benefit_Plan_Details_DataField = value;
				this.RaisePropertyChanged("Benefit_Plan_Details_Data");
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
