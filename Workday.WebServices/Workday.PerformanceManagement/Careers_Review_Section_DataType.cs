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
	public class Careers_Review_Section_DataType : INotifyPropertyChanged
	{
		private Review_Career_Career_Interests_DataType review_Career_DataField;

		private Job_ProfileObjectType[] review_Job_Interests_DataField;

		private Review_Career_Travel_Preferences_DataType review_Travel_Preferences_DataField;

		private Review_Career_Relocation_Preferences_DataType review_Relocation_Preferences_DataField;

		private Manager_Section_Evaluation_DataType manager_Section_Evaluation_DataField;

		private Employee_Section_Evaluation_DataType employee_Section_Evaluation_DataField;

		private Additional_Manager_Section_Evaluation_DataType[] additional_Manager_Section_Evaluation_DataField;

		private Employee_Review_Section_Type__Mixed_ObjectType section_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Review_Career_Career_Interests_DataType Review_Career_Data
		{
			get
			{
				return this.review_Career_DataField;
			}
			set
			{
				this.review_Career_DataField = value;
				this.RaisePropertyChanged("Review_Career_Data");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Job_Interest_Job_Profile_Reference", IsNullable = false)]
		public Job_ProfileObjectType[] Review_Job_Interests_Data
		{
			get
			{
				return this.review_Job_Interests_DataField;
			}
			set
			{
				this.review_Job_Interests_DataField = value;
				this.RaisePropertyChanged("Review_Job_Interests_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Review_Career_Travel_Preferences_DataType Review_Travel_Preferences_Data
		{
			get
			{
				return this.review_Travel_Preferences_DataField;
			}
			set
			{
				this.review_Travel_Preferences_DataField = value;
				this.RaisePropertyChanged("Review_Travel_Preferences_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Review_Career_Relocation_Preferences_DataType Review_Relocation_Preferences_Data
		{
			get
			{
				return this.review_Relocation_Preferences_DataField;
			}
			set
			{
				this.review_Relocation_Preferences_DataField = value;
				this.RaisePropertyChanged("Review_Relocation_Preferences_Data");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Additional_Manager_Section_Evaluation_Data", Order = 6)]
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

		[XmlElement(Order = 7)]
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
