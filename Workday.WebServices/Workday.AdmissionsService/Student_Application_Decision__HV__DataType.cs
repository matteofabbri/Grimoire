using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Decision__HV__DataType : INotifyPropertyChanged
	{
		private Student_ApplicationObjectType student_Application_ReferenceField;

		private DateTime decision_DateField;

		private Admission_DecisionObjectType admission_Decision_ReferenceField;

		private Admission_Decision_ReasonObjectType admission_Decision_Reason_ReferenceField;

		private Program_of_StudyObjectType[] admitted_Program_of_Study_ReferenceField;

		private Program_of_StudyObjectType[] admitted_to_Program_Focus_ReferenceField;

		private decimal decision_GPAField;

		private bool decision_GPAFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ApplicationObjectType Student_Application_Reference
		{
			get
			{
				return this.student_Application_ReferenceField;
			}
			set
			{
				this.student_Application_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Decision_Date
		{
			get
			{
				return this.decision_DateField;
			}
			set
			{
				this.decision_DateField = value;
				this.RaisePropertyChanged("Decision_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Admission_DecisionObjectType Admission_Decision_Reference
		{
			get
			{
				return this.admission_Decision_ReferenceField;
			}
			set
			{
				this.admission_Decision_ReferenceField = value;
				this.RaisePropertyChanged("Admission_Decision_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Admission_Decision_ReasonObjectType Admission_Decision_Reason_Reference
		{
			get
			{
				return this.admission_Decision_Reason_ReferenceField;
			}
			set
			{
				this.admission_Decision_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Admission_Decision_Reason_Reference");
			}
		}

		[XmlElement("Admitted_Program_of_Study_Reference", Order = 4)]
		public Program_of_StudyObjectType[] Admitted_Program_of_Study_Reference
		{
			get
			{
				return this.admitted_Program_of_Study_ReferenceField;
			}
			set
			{
				this.admitted_Program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Admitted_Program_of_Study_Reference");
			}
		}

		[XmlElement("Admitted_to_Program_Focus_Reference", Order = 5)]
		public Program_of_StudyObjectType[] Admitted_to_Program_Focus_Reference
		{
			get
			{
				return this.admitted_to_Program_Focus_ReferenceField;
			}
			set
			{
				this.admitted_to_Program_Focus_ReferenceField = value;
				this.RaisePropertyChanged("Admitted_to_Program_Focus_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Decision_GPA
		{
			get
			{
				return this.decision_GPAField;
			}
			set
			{
				this.decision_GPAField = value;
				this.RaisePropertyChanged("Decision_GPA");
			}
		}

		[XmlIgnore]
		public bool Decision_GPASpecified
		{
			get
			{
				return this.decision_GPAFieldSpecified;
			}
			set
			{
				this.decision_GPAFieldSpecified = value;
				this.RaisePropertyChanged("Decision_GPASpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
