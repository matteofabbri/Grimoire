using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Academic_Progress_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType student_Academic_Requirement_Assignment_ReferenceField;

		private Academic_RequirementObjectType academic_Requirement_ReferenceField;

		private string academic_Requirement_NameField;

		private Requirement_Completion_StatusObjectType[] requirement_Completion_Status_ReferenceField;

		private InstanceObjectType[] course_Definition_ReferenceField;

		private string remainingField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Student_Academic_Requirement_Assignment_Reference
		{
			get
			{
				return this.student_Academic_Requirement_Assignment_ReferenceField;
			}
			set
			{
				this.student_Academic_Requirement_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Academic_Requirement_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_RequirementObjectType Academic_Requirement_Reference
		{
			get
			{
				return this.academic_Requirement_ReferenceField;
			}
			set
			{
				this.academic_Requirement_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Requirement_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Academic_Requirement_Name
		{
			get
			{
				return this.academic_Requirement_NameField;
			}
			set
			{
				this.academic_Requirement_NameField = value;
				this.RaisePropertyChanged("Academic_Requirement_Name");
			}
		}

		[XmlElement("Requirement_Completion_Status_Reference", Order = 3)]
		public Requirement_Completion_StatusObjectType[] Requirement_Completion_Status_Reference
		{
			get
			{
				return this.requirement_Completion_Status_ReferenceField;
			}
			set
			{
				this.requirement_Completion_Status_ReferenceField = value;
				this.RaisePropertyChanged("Requirement_Completion_Status_Reference");
			}
		}

		[XmlElement("Course_Definition_Reference", Order = 4)]
		public InstanceObjectType[] Course_Definition_Reference
		{
			get
			{
				return this.course_Definition_ReferenceField;
			}
			set
			{
				this.course_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Course_Definition_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Remaining
		{
			get
			{
				return this.remainingField;
			}
			set
			{
				this.remainingField = value;
				this.RaisePropertyChanged("Remaining");
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
