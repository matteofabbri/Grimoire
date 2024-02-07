using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Overall_Evaluation_DataType : INotifyPropertyChanged
	{
		private Manager_Overall_Evaluation_DataType manager_Overall_Evaluation_DataField;

		private Employee_Overall_Evaluation_DataType employee_Overall_Evaluation_DataField;

		private Additional_Manager_Overall_Evaluation_DataType[] additional_Manager_Overall_Evaluation_DataField;

		private Employee_Review_Section_Type__Mixed_ObjectType section_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Manager_Overall_Evaluation_DataType Manager_Overall_Evaluation_Data
		{
			get
			{
				return this.manager_Overall_Evaluation_DataField;
			}
			set
			{
				this.manager_Overall_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Overall_Evaluation_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Overall_Evaluation_DataType Employee_Overall_Evaluation_Data
		{
			get
			{
				return this.employee_Overall_Evaluation_DataField;
			}
			set
			{
				this.employee_Overall_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Overall_Evaluation_Data");
			}
		}

		[XmlElement("Additional_Manager_Overall_Evaluation_Data", Order = 2)]
		public Additional_Manager_Overall_Evaluation_DataType[] Additional_Manager_Overall_Evaluation_Data
		{
			get
			{
				return this.additional_Manager_Overall_Evaluation_DataField;
			}
			set
			{
				this.additional_Manager_Overall_Evaluation_DataField = value;
				this.RaisePropertyChanged("Additional_Manager_Overall_Evaluation_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Review_Section_Type__Mixed_ObjectType Section_Type_Reference
		{
			get
			{
				return this.section_Type_ReferenceField;
			}
			set
			{
				this.section_Type_ReferenceField = value;
				this.RaisePropertyChanged("Section_Type_Reference");
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
