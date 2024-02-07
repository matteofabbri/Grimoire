using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Education_History_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private SchoolObjectType school_ReferenceField;

		private string education_InstitutionField;

		private School_Type_ReferenceType educational_Institution_Type_ReferenceField;

		private Degree_ReferenceType degree_ReferenceField;

		private Degree_CompletedObjectType degree_Completed_ReferenceField;

		private Field_Of_Study_ReferenceType field_Of_Study_ReferenceField;

		private string education_Institution_LocationField;

		private string education_Grade_AverageField;

		private DateTime first_Year_AttendedField;

		private bool first_Year_AttendedFieldSpecified;

		private DateTime last_Year_AttendedField;

		private bool last_Year_AttendedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Education_Institution
		{
			get
			{
				return this.education_InstitutionField;
			}
			set
			{
				this.education_InstitutionField = value;
				this.RaisePropertyChanged("Education_Institution");
			}
		}

		[XmlElement(Order = 3)]
		public School_Type_ReferenceType Educational_Institution_Type_Reference
		{
			get
			{
				return this.educational_Institution_Type_ReferenceField;
			}
			set
			{
				this.educational_Institution_Type_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Degree_ReferenceType Degree_Reference
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

		[XmlElement(Order = 6)]
		public Field_Of_Study_ReferenceType Field_Of_Study_Reference
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

		[XmlElement(Order = 7)]
		public string Education_Institution_Location
		{
			get
			{
				return this.education_Institution_LocationField;
			}
			set
			{
				this.education_Institution_LocationField = value;
				this.RaisePropertyChanged("Education_Institution_Location");
			}
		}

		[XmlElement(Order = 8)]
		public string Education_Grade_Average
		{
			get
			{
				return this.education_Grade_AverageField;
			}
			set
			{
				this.education_Grade_AverageField = value;
				this.RaisePropertyChanged("Education_Grade_Average");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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
