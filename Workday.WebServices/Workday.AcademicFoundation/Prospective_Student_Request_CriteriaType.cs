using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prospective_Student_Request_CriteriaType : INotifyPropertyChanged
	{
		private bool return_Students_with_RecruitmentsField;

		private bool return_Students_with_RecruitmentsFieldSpecified;

		private bool return_Students_with_ApplicationsField;

		private bool return_Students_with_ApplicationsFieldSpecified;

		private bool return_Students_with_Education_TestsField;

		private bool return_Students_with_Education_TestsFieldSpecified;

		private bool return_Students_with_TranscriptsField;

		private bool return_Students_with_TranscriptsFieldSpecified;

		private Student_ApplicationObjectType[] student_Application_ReferenceField;

		private Education_Test_Registration_Number_CriteriaType[] education_Test_Registration_Number_CriteriaField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Return_Students_with_Recruitments
		{
			get
			{
				return this.return_Students_with_RecruitmentsField;
			}
			set
			{
				this.return_Students_with_RecruitmentsField = value;
				this.RaisePropertyChanged("Return_Students_with_Recruitments");
			}
		}

		[XmlIgnore]
		public bool Return_Students_with_RecruitmentsSpecified
		{
			get
			{
				return this.return_Students_with_RecruitmentsFieldSpecified;
			}
			set
			{
				this.return_Students_with_RecruitmentsFieldSpecified = value;
				this.RaisePropertyChanged("Return_Students_with_RecruitmentsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Return_Students_with_Applications
		{
			get
			{
				return this.return_Students_with_ApplicationsField;
			}
			set
			{
				this.return_Students_with_ApplicationsField = value;
				this.RaisePropertyChanged("Return_Students_with_Applications");
			}
		}

		[XmlIgnore]
		public bool Return_Students_with_ApplicationsSpecified
		{
			get
			{
				return this.return_Students_with_ApplicationsFieldSpecified;
			}
			set
			{
				this.return_Students_with_ApplicationsFieldSpecified = value;
				this.RaisePropertyChanged("Return_Students_with_ApplicationsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Return_Students_with_Education_Tests
		{
			get
			{
				return this.return_Students_with_Education_TestsField;
			}
			set
			{
				this.return_Students_with_Education_TestsField = value;
				this.RaisePropertyChanged("Return_Students_with_Education_Tests");
			}
		}

		[XmlIgnore]
		public bool Return_Students_with_Education_TestsSpecified
		{
			get
			{
				return this.return_Students_with_Education_TestsFieldSpecified;
			}
			set
			{
				this.return_Students_with_Education_TestsFieldSpecified = value;
				this.RaisePropertyChanged("Return_Students_with_Education_TestsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Return_Students_with_Transcripts
		{
			get
			{
				return this.return_Students_with_TranscriptsField;
			}
			set
			{
				this.return_Students_with_TranscriptsField = value;
				this.RaisePropertyChanged("Return_Students_with_Transcripts");
			}
		}

		[XmlIgnore]
		public bool Return_Students_with_TranscriptsSpecified
		{
			get
			{
				return this.return_Students_with_TranscriptsFieldSpecified;
			}
			set
			{
				this.return_Students_with_TranscriptsFieldSpecified = value;
				this.RaisePropertyChanged("Return_Students_with_TranscriptsSpecified");
			}
		}

		[XmlElement("Student_Application_Reference", Order = 4)]
		public Student_ApplicationObjectType[] Student_Application_Reference
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

		[XmlElement("Education_Test_Registration_Number_Criteria", Order = 5)]
		public Education_Test_Registration_Number_CriteriaType[] Education_Test_Registration_Number_Criteria
		{
			get
			{
				return this.education_Test_Registration_Number_CriteriaField;
			}
			set
			{
				this.education_Test_Registration_Number_CriteriaField = value;
				this.RaisePropertyChanged("Education_Test_Registration_Number_Criteria");
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
