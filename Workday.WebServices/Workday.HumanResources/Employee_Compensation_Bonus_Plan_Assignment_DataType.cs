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
	public class Employee_Compensation_Bonus_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private string bonus_Plan_NameField;

		private Employee_Compensation_Bonus_Plan_Assignment_Detail_DataType compensation_Element_Values_for_Bonus_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bonus_Plan_Name
		{
			get
			{
				return this.bonus_Plan_NameField;
			}
			set
			{
				this.bonus_Plan_NameField = value;
				this.RaisePropertyChanged("Bonus_Plan_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Compensation_Bonus_Plan_Assignment_Detail_DataType Compensation_Element_Values_for_Bonus_Plan_Data
		{
			get
			{
				return this.compensation_Element_Values_for_Bonus_Plan_DataField;
			}
			set
			{
				this.compensation_Element_Values_for_Bonus_Plan_DataField = value;
				this.RaisePropertyChanged("Compensation_Element_Values_for_Bonus_Plan_Data");
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
