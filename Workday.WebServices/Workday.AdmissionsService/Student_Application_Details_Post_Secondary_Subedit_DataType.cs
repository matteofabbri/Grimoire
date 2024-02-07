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
	public class Student_Application_Details_Post_Secondary_Subedit_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType educational_Institution_Attendance_ReferenceField;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime exit_DateField;

		private bool exit_DateFieldSpecified;

		private Student_External_Credential_TypeObjectType[] credentials_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Educational_Institution_Attendance_Reference
		{
			get
			{
				return this.educational_Institution_Attendance_ReferenceField;
			}
			set
			{
				this.educational_Institution_Attendance_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Attendance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Educational_InstitutionObjectType Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Exit_Date
		{
			get
			{
				return this.exit_DateField;
			}
			set
			{
				this.exit_DateField = value;
				this.RaisePropertyChanged("Exit_Date");
			}
		}

		[XmlIgnore]
		public bool Exit_DateSpecified
		{
			get
			{
				return this.exit_DateFieldSpecified;
			}
			set
			{
				this.exit_DateFieldSpecified = value;
				this.RaisePropertyChanged("Exit_DateSpecified");
			}
		}

		[XmlElement("Credentials_Reference", Order = 4)]
		public Student_External_Credential_TypeObjectType[] Credentials_Reference
		{
			get
			{
				return this.credentials_ReferenceField;
			}
			set
			{
				this.credentials_ReferenceField = value;
				this.RaisePropertyChanged("Credentials_Reference");
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
