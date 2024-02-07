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
	public class Employee_Compensation_Salary_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private string salary_Plan_NameField;

		private Employee_Compensation_Salary_Plan_Assignment_Detail_DataType compensation_Element_Values_for_Base_Pay_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Salary_Plan_Name
		{
			get
			{
				return this.salary_Plan_NameField;
			}
			set
			{
				this.salary_Plan_NameField = value;
				this.RaisePropertyChanged("Salary_Plan_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Compensation_Salary_Plan_Assignment_Detail_DataType Compensation_Element_Values_for_Base_Pay_Data
		{
			get
			{
				return this.compensation_Element_Values_for_Base_Pay_DataField;
			}
			set
			{
				this.compensation_Element_Values_for_Base_Pay_DataField = value;
				this.RaisePropertyChanged("Compensation_Element_Values_for_Base_Pay_Data");
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
