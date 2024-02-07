using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Education_DataType : INotifyPropertyChanged
	{
		private SchoolObjectType school_ReferenceField;

		private string school_NameField;

		private decimal first_Year_AttendedField;

		private bool first_Year_AttendedFieldSpecified;

		private decimal last_Year_AttendedField;

		private bool last_Year_AttendedFieldSpecified;

		private DegreeObjectType degree_ReferenceField;

		private Field_of_StudyObjectType field_of_Study_ReferenceField;

		private string grade_AverageField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public SchoolObjectType School_Reference
		{
			get
			{
				return this.school_ReferenceField;
			}
			set
			{
				this.school_ReferenceField = value;
				this.RaisePropertyChanged("School_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string School_Name
		{
			get
			{
				return this.school_NameField;
			}
			set
			{
				this.school_NameField = value;
				this.RaisePropertyChanged("School_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal First_Year_Attended
		{
			get
			{
				return this.first_Year_AttendedField;
			}
			set
			{
				this.first_Year_AttendedField = value;
				this.RaisePropertyChanged("First_Year_Attended");
			}
		}

		[XmlIgnore]
		public bool First_Year_AttendedSpecified
		{
			get
			{
				return this.first_Year_AttendedFieldSpecified;
			}
			set
			{
				this.first_Year_AttendedFieldSpecified = value;
				this.RaisePropertyChanged("First_Year_AttendedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Last_Year_Attended
		{
			get
			{
				return this.last_Year_AttendedField;
			}
			set
			{
				this.last_Year_AttendedField = value;
				this.RaisePropertyChanged("Last_Year_Attended");
			}
		}

		[XmlIgnore]
		public bool Last_Year_AttendedSpecified
		{
			get
			{
				return this.last_Year_AttendedFieldSpecified;
			}
			set
			{
				this.last_Year_AttendedFieldSpecified = value;
				this.RaisePropertyChanged("Last_Year_AttendedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public DegreeObjectType Degree_Reference
		{
			get
			{
				return this.degree_ReferenceField;
			}
			set
			{
				this.degree_ReferenceField = value;
				this.RaisePropertyChanged("Degree_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Field_of_StudyObjectType Field_of_Study_Reference
		{
			get
			{
				return this.field_of_Study_ReferenceField;
			}
			set
			{
				this.field_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Field_of_Study_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Grade_Average
		{
			get
			{
				return this.grade_AverageField;
			}
			set
			{
				this.grade_AverageField = value;
				this.RaisePropertyChanged("Grade_Average");
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
