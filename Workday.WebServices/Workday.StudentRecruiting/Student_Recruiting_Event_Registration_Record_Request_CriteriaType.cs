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
	public class Student_Recruiting_Event_Registration_Record_Request_CriteriaType : INotifyPropertyChanged
	{
		private StudentObjectType student_Prospect_ReferenceField;

		private Student_Recruiting_EventObjectType student_Recruiting_Event_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StudentObjectType Student_Prospect_Reference
		{
			get
			{
				return this.student_Prospect_ReferenceField;
			}
			set
			{
				this.student_Prospect_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Recruiting_EventObjectType Student_Recruiting_Event_Reference
		{
			get
			{
				return this.student_Recruiting_Event_ReferenceField;
			}
			set
			{
				this.student_Recruiting_Event_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Reference");
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
