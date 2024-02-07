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
	public class Questions_Review_Section_DataType : INotifyPropertyChanged
	{
		private Review_Question_DataType[] review_Question_DataField;

		private Manager_Section_Evaluation_DataType manager_Section_Evaluation_DataField;

		private Employee_Section_Evaluation_DataType employee_Section_Evaluation_DataField;

		private Additional_Manager_Section_Evaluation_DataType[] additional_Manager_Section_Evaluation_DataField;

		private Employee_Review_Section_Type__Mixed_ObjectType section_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Review_Question_Data", Order = 0)]
		public Review_Question_DataType[] Review_Question_Data
		{
			get
			{
				return this.review_Question_DataField;
			}
			set
			{
				this.review_Question_DataField = value;
				this.RaisePropertyChanged("Review_Question_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Manager_Section_Evaluation_DataType Manager_Section_Evaluation_Data
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

		[XmlElement(Order = 2)]
		public Employee_Section_Evaluation_DataType Employee_Section_Evaluation_Data
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

		[XmlElement("Additional_Manager_Section_Evaluation_Data", Order = 3)]
		public Additional_Manager_Section_Evaluation_DataType[] Additional_Manager_Section_Evaluation_Data
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

		[XmlElement(Order = 4)]
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
