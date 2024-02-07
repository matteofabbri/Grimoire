using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Health_Savings_Account_Coverage_DataType : INotifyPropertyChanged
	{
		private Worker_Benefit_Election_DataType benefit_Election_DataField;

		private Health_Savings_Account_Election_Info_DataType health_Savings_Account_Election_Info_DataField;

		private Employee_Contribution_DataType employee_Contribution_DataField;

		private Employer_Contribution_DataType employer_Contribution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Benefit_Election_DataType Benefit_Election_Data
		{
			get
			{
				return this.benefit_Election_DataField;
			}
			set
			{
				this.benefit_Election_DataField = value;
				this.RaisePropertyChanged("Benefit_Election_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Health_Savings_Account_Election_Info_DataType Health_Savings_Account_Election_Info_Data
		{
			get
			{
				return this.health_Savings_Account_Election_Info_DataField;
			}
			set
			{
				this.health_Savings_Account_Election_Info_DataField = value;
				this.RaisePropertyChanged("Health_Savings_Account_Election_Info_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Employee_Contribution_DataType Employee_Contribution_Data
		{
			get
			{
				return this.employee_Contribution_DataField;
			}
			set
			{
				this.employee_Contribution_DataField = value;
				this.RaisePropertyChanged("Employee_Contribution_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employer_Contribution_DataType Employer_Contribution_Data
		{
			get
			{
				return this.employer_Contribution_DataField;
			}
			set
			{
				this.employer_Contribution_DataField = value;
				this.RaisePropertyChanged("Employer_Contribution_Data");
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
