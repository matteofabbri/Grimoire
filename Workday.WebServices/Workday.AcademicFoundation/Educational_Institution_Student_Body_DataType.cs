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
	public class Educational_Institution_Student_Body_DataType : INotifyPropertyChanged
	{
		private Educational_Institution_Student_BodyObjectType educational_Institution_Student_Body_ReferenceField;

		private DateTime school_YearField;

		private bool school_YearFieldSpecified;

		private decimal total_StudentsField;

		private bool total_StudentsFieldSpecified;

		private decimal fTE_TeachersField;

		private bool fTE_TeachersFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_Institution_Student_BodyObjectType Educational_Institution_Student_Body_Reference
		{
			get
			{
				return this.educational_Institution_Student_Body_ReferenceField;
			}
			set
			{
				this.educational_Institution_Student_Body_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Student_Body_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime School_Year
		{
			get
			{
				return this.school_YearField;
			}
			set
			{
				this.school_YearField = value;
				this.RaisePropertyChanged("School_Year");
			}
		}

		[XmlIgnore]
		public bool School_YearSpecified
		{
			get
			{
				return this.school_YearFieldSpecified;
			}
			set
			{
				this.school_YearFieldSpecified = value;
				this.RaisePropertyChanged("School_YearSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Total_Students
		{
			get
			{
				return this.total_StudentsField;
			}
			set
			{
				this.total_StudentsField = value;
				this.RaisePropertyChanged("Total_Students");
			}
		}

		[XmlIgnore]
		public bool Total_StudentsSpecified
		{
			get
			{
				return this.total_StudentsFieldSpecified;
			}
			set
			{
				this.total_StudentsFieldSpecified = value;
				this.RaisePropertyChanged("Total_StudentsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal FTE_Teachers
		{
			get
			{
				return this.fTE_TeachersField;
			}
			set
			{
				this.fTE_TeachersField = value;
				this.RaisePropertyChanged("FTE_Teachers");
			}
		}

		[XmlIgnore]
		public bool FTE_TeachersSpecified
		{
			get
			{
				return this.fTE_TeachersFieldSpecified;
			}
			set
			{
				this.fTE_TeachersFieldSpecified = value;
				this.RaisePropertyChanged("FTE_TeachersSpecified");
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
