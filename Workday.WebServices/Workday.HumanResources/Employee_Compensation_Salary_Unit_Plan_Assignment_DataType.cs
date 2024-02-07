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
	public class Employee_Compensation_Salary_Unit_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private string unit_Salary_Plan_NameField;

		private Employee_Compensation_Salary_Unit_Plan_Assignment_Detail_DataType compensation_Element_Values_for_Unit_Salary_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Unit_Salary_Plan_Name
		{
			get
			{
				return this.unit_Salary_Plan_NameField;
			}
			set
			{
				this.unit_Salary_Plan_NameField = value;
				this.RaisePropertyChanged("Unit_Salary_Plan_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Compensation_Salary_Unit_Plan_Assignment_Detail_DataType Compensation_Element_Values_for_Unit_Salary_Plan_Data
		{
			get
			{
				return this.compensation_Element_Values_for_Unit_Salary_Plan_DataField;
			}
			set
			{
				this.compensation_Element_Values_for_Unit_Salary_Plan_DataField = value;
				this.RaisePropertyChanged("Compensation_Element_Values_for_Unit_Salary_Plan_Data");
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
