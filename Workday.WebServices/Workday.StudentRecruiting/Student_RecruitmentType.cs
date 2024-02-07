using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_RecruitmentType : INotifyPropertyChanged
	{
		private Student_RecruitmentObjectType student_Recruitment_ReferenceField;

		private Student_Recruitment_Data_W25Type student_Recruitment_DataField;

		private Non_Effective_Dated_Web_Service_Additional_DataType[] non_Effective_Dated_Web_Service_Additional_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_RecruitmentObjectType Student_Recruitment_Reference
		{
			get
			{
				return this.student_Recruitment_ReferenceField;
			}
			set
			{
				this.student_Recruitment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruitment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Recruitment_Data_W25Type Student_Recruitment_Data
		{
			get
			{
				return this.student_Recruitment_DataField;
			}
			set
			{
				this.student_Recruitment_DataField = value;
				this.RaisePropertyChanged("Student_Recruitment_Data");
			}
		}

		[XmlElement("Non_Effective_Dated_Web_Service_Additional_Data", Order = 2)]
		public Non_Effective_Dated_Web_Service_Additional_DataType[] Non_Effective_Dated_Web_Service_Additional_Data
		{
			get
			{
				return this.non_Effective_Dated_Web_Service_Additional_DataField;
			}
			set
			{
				this.non_Effective_Dated_Web_Service_Additional_DataField = value;
				this.RaisePropertyChanged("Non_Effective_Dated_Web_Service_Additional_Data");
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
