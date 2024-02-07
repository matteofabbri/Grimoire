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
	public class Supporting_Document_Evaluation_DataType : INotifyPropertyChanged
	{
		private Manager_Supporting_Document_Evaluation_DataType[] manager_Supporting_Document_Evaluation_DataField;

		private Employee_Supporting_Document_Evaluation_DataType[] employee_Supporting_Document_Evaluation_DataField;

		private Additional_Manager_Supporting_Document_Evaluation_DataType[] additional_Manager_Supporting_Document_Evaluation_DataField;

		private Manager_Supporting_Document_Section_Evaluation_DataType manager_Section_Evaluation_DataField;

		private Employee_Supporting_Document_Section_Evaluation_DataType employee_Section_Evaluation_DataField;

		private Additional_Manager_Supporting_Documents_Section_Evaluation_DataType[] additional_Manager_Section_Evaluation_DataField;

		private Employee_Review_Section_Type__Mixed_ObjectType section_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Manager_Supporting_Document_Evaluation_Data", Order = 0)]
		public Manager_Supporting_Document_Evaluation_DataType[] Manager_Supporting_Document_Evaluation_Data
		{
			get
			{
				return this.manager_Supporting_Document_Evaluation_DataField;
			}
			set
			{
				this.manager_Supporting_Document_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Supporting_Document_Evaluation_Data");
			}
		}

		[XmlElement("Employee_Supporting_Document_Evaluation_Data", Order = 1)]
		public Employee_Supporting_Document_Evaluation_DataType[] Employee_Supporting_Document_Evaluation_Data
		{
			get
			{
				return this.employee_Supporting_Document_Evaluation_DataField;
			}
			set
			{
				this.employee_Supporting_Document_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Supporting_Document_Evaluation_Data");
			}
		}

		[XmlElement("Additional_Manager_Supporting_Document_Evaluation_Data", Order = 2)]
		public Additional_Manager_Supporting_Document_Evaluation_DataType[] Additional_Manager_Supporting_Document_Evaluation_Data
		{
			get
			{
				return this.additional_Manager_Supporting_Document_Evaluation_DataField;
			}
			set
			{
				this.additional_Manager_Supporting_Document_Evaluation_DataField = value;
				this.RaisePropertyChanged("Additional_Manager_Supporting_Document_Evaluation_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Manager_Supporting_Document_Section_Evaluation_DataType Manager_Section_Evaluation_Data
		{
			get
			{
				return this.manager_Section_Evaluation_DataField;
			}
			set
			{
				this.manager_Section_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Section_Evaluation_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Employee_Supporting_Document_Section_Evaluation_DataType Employee_Section_Evaluation_Data
		{
			get
			{
				return this.employee_Section_Evaluation_DataField;
			}
			set
			{
				this.employee_Section_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Section_Evaluation_Data");
			}
		}

		[XmlElement("Additional_Manager_Section_Evaluation_Data", Order = 5)]
		public Additional_Manager_Supporting_Documents_Section_Evaluation_DataType[] Additional_Manager_Section_Evaluation_Data
		{
			get
			{
				return this.additional_Manager_Section_Evaluation_DataField;
			}
			set
			{
				this.additional_Manager_Section_Evaluation_DataField = value;
				this.RaisePropertyChanged("Additional_Manager_Section_Evaluation_Data");
			}
		}

		[XmlElement(Order = 6)]
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
