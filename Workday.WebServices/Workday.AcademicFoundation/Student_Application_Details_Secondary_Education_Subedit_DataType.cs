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
	public class Student_Application_Details_Secondary_Education_Subedit_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType educational_Institution_Attendance_ReferenceField;

		private DateTime graduation_DateField;

		private bool graduation_DateFieldSpecified;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime exit_DateField;

		private bool exit_DateFieldSpecified;

		private bool most_Recently_AttendedField;

		private bool most_Recently_AttendedFieldSpecified;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Graduation_Date
		{
			get
			{
				return this.graduation_DateField;
			}
			set
			{
				this.graduation_DateField = value;
				this.RaisePropertyChanged("Graduation_Date");
			}
		}

		[XmlIgnore]
		public bool Graduation_DateSpecified
		{
			get
			{
				return this.graduation_DateFieldSpecified;
			}
			set
			{
				this.graduation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Graduation_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(Order = 5)]
		public bool Most_Recently_Attended
		{
			get
			{
				return this.most_Recently_AttendedField;
			}
			set
			{
				this.most_Recently_AttendedField = value;
				this.RaisePropertyChanged("Most_Recently_Attended");
			}
		}

		[XmlIgnore]
		public bool Most_Recently_AttendedSpecified
		{
			get
			{
				return this.most_Recently_AttendedFieldSpecified;
			}
			set
			{
				this.most_Recently_AttendedFieldSpecified = value;
				this.RaisePropertyChanged("Most_Recently_AttendedSpecified");
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
