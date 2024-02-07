using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Education_Achievement_DataType : INotifyPropertyChanged
	{
		private string education_IDField;

		private bool remove_EducationField;

		private bool remove_EducationFieldSpecified;

		private CountryObjectType country_ReferenceField;

		private SchoolObjectType school_ReferenceField;

		private string school_NameField;

		private School_TypeObjectType school_Type_ReferenceField;

		private string locationField;

		private DegreeObjectType degree_ReferenceField;

		private Degree_CompletedObjectType degree_Completed_ReferenceField;

		private DateTime date_Degree_ReceivedField;

		private bool date_Degree_ReceivedFieldSpecified;

		private Field_of_StudyObjectType field_Of_Study_ReferenceField;

		private string grade_AverageField;

		private DateTime first_Year_AttendedField;

		private bool first_Year_AttendedFieldSpecified;

		private DateTime last_Year_AttendedField;

		private bool last_Year_AttendedFieldSpecified;

		private bool is_Highest_Level_of_EducationField;

		private bool is_Highest_Level_of_EducationFieldSpecified;

		private DateTime first_Day_AttendedField;

		private bool first_Day_AttendedFieldSpecified;

		private DateTime last_Day_AttendedField;

		private bool last_Day_AttendedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Education_ID
		{
			get
			{
				return this.education_IDField;
			}
			set
			{
				this.education_IDField = value;
				this.RaisePropertyChanged("Education_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Education
		{
			get
			{
				return this.remove_EducationField;
			}
			set
			{
				this.remove_EducationField = value;
				this.RaisePropertyChanged("Remove_Education");
			}
		}

		[XmlIgnore]
		public bool Remove_EducationSpecified
		{
			get
			{
				return this.remove_EducationFieldSpecified;
			}
			set
			{
				this.remove_EducationFieldSpecified = value;
				this.RaisePropertyChanged("Remove_EducationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public School_TypeObjectType School_Type_Reference
		{
			get
			{
				return this.school_Type_ReferenceField;
			}
			set
			{
				this.school_Type_ReferenceField = value;
				this.RaisePropertyChanged("School_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				this.RaisePropertyChanged("Location");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Degree_CompletedObjectType Degree_Completed_Reference
		{
			get
			{
				return this.degree_Completed_ReferenceField;
			}
			set
			{
				this.degree_Completed_ReferenceField = value;
				this.RaisePropertyChanged("Degree_Completed_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Date_Degree_Received
		{
			get
			{
				return this.date_Degree_ReceivedField;
			}
			set
			{
				this.date_Degree_ReceivedField = value;
				this.RaisePropertyChanged("Date_Degree_Received");
			}
		}

		[XmlIgnore]
		public bool Date_Degree_ReceivedSpecified
		{
			get
			{
				return this.date_Degree_ReceivedFieldSpecified;
			}
			set
			{
				this.date_Degree_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Degree_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Field_of_StudyObjectType Field_Of_Study_Reference
		{
			get
			{
				return this.field_Of_Study_ReferenceField;
			}
			set
			{
				this.field_Of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Field_Of_Study_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime First_Year_Attended
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

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Last_Year_Attended
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

		[XmlElement(Order = 14)]
		public bool Is_Highest_Level_of_Education
		{
			get
			{
				return this.is_Highest_Level_of_EducationField;
			}
			set
			{
				this.is_Highest_Level_of_EducationField = value;
				this.RaisePropertyChanged("Is_Highest_Level_of_Education");
			}
		}

		[XmlIgnore]
		public bool Is_Highest_Level_of_EducationSpecified
		{
			get
			{
				return this.is_Highest_Level_of_EducationFieldSpecified;
			}
			set
			{
				this.is_Highest_Level_of_EducationFieldSpecified = value;
				this.RaisePropertyChanged("Is_Highest_Level_of_EducationSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime First_Day_Attended
		{
			get
			{
				return this.first_Day_AttendedField;
			}
			set
			{
				this.first_Day_AttendedField = value;
				this.RaisePropertyChanged("First_Day_Attended");
			}
		}

		[XmlIgnore]
		public bool First_Day_AttendedSpecified
		{
			get
			{
				return this.first_Day_AttendedFieldSpecified;
			}
			set
			{
				this.first_Day_AttendedFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_AttendedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Last_Day_Attended
		{
			get
			{
				return this.last_Day_AttendedField;
			}
			set
			{
				this.last_Day_AttendedField = value;
				this.RaisePropertyChanged("Last_Day_Attended");
			}
		}

		[XmlIgnore]
		public bool Last_Day_AttendedSpecified
		{
			get
			{
				return this.last_Day_AttendedFieldSpecified;
			}
			set
			{
				this.last_Day_AttendedFieldSpecified = value;
				this.RaisePropertyChanged("Last_Day_AttendedSpecified");
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
