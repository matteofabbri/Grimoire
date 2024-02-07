using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Student_Recruiting_Event_Attendance_Record_RequestType : INotifyPropertyChanged
	{
		private Student_Recruiting_EventObjectType student_Recruiting_Event_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private decimal student_Recruiting_Event_Registration_Record_Guest_CountField;

		private bool student_Recruiting_Event_Registration_Record_Guest_CountFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Student_Recruiting_Event_Registration_Record_Guest_Count
		{
			get
			{
				return this.student_Recruiting_Event_Registration_Record_Guest_CountField;
			}
			set
			{
				this.student_Recruiting_Event_Registration_Record_Guest_CountField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Registration_Record_Guest_Count");
			}
		}

		[XmlIgnore]
		public bool Student_Recruiting_Event_Registration_Record_Guest_CountSpecified
		{
			get
			{
				return this.student_Recruiting_Event_Registration_Record_Guest_CountFieldSpecified;
			}
			set
			{
				this.student_Recruiting_Event_Registration_Record_Guest_CountFieldSpecified = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Registration_Record_Guest_CountSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
