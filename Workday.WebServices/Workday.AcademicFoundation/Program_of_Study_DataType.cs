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
	public class Program_of_Study_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime effective_DateField;

		private Program_of_Study_TypeObjectType program_of_Study_Type_ReferenceField;

		private string program_of_Study_CodeField;

		private Program_of_StudyObjectType primary_Program_of_Study_ReferenceField;

		private Program_of_StudyObjectType secondary_Program_of_Study_ReferenceField;

		private Program_of_StudyObjectType parent_Program_of_Study_ReferenceField;

		private string program_NameField;

		private CIP_Code__Workday_Owned_ObjectType cIP_Code_ReferenceField;

		private Educational_Taxonomy_CodeObjectType[] educational_Taxonomy_Codes_ReferenceField;

		private LocationObjectType[] allowed_Locations_ReferenceField;

		private bool fast_Path_EnabledField;

		private bool fast_Path_EnabledFieldSpecified;

		private bool include_Type_in_NameField;

		private bool include_Type_in_NameFieldSpecified;

		private DateTime first_Entry_DateField;

		private DateTime last_Entry_DateField;

		private bool last_Entry_DateFieldSpecified;

		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private Academic_CalendarObjectType academic_Calendar_ReferenceField;

		private Academic_Curricular_DivisionObjectType coordinating_Academic_Unit_ReferenceField;

		private bool program_Focus_RequiredField;

		private bool program_Focus_RequiredFieldSpecified;

		private Program_AreaObjectType[] program_Area_ReferenceField;

		private Educational_CredentialObjectType[] educational_Credentials_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Program_of_Study_TypeObjectType Program_of_Study_Type_Reference
		{
			get
			{
				return this.program_of_Study_Type_ReferenceField;
			}
			set
			{
				this.program_of_Study_Type_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Program_of_Study_Code
		{
			get
			{
				return this.program_of_Study_CodeField;
			}
			set
			{
				this.program_of_Study_CodeField = value;
				this.RaisePropertyChanged("Program_of_Study_Code");
			}
		}

		[XmlElement(Order = 4)]
		public Program_of_StudyObjectType Primary_Program_of_Study_Reference
		{
			get
			{
				return this.primary_Program_of_Study_ReferenceField;
			}
			set
			{
				this.primary_Program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Program_of_StudyObjectType Secondary_Program_of_Study_Reference
		{
			get
			{
				return this.secondary_Program_of_Study_ReferenceField;
			}
			set
			{
				this.secondary_Program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Program_of_StudyObjectType Parent_Program_of_Study_Reference
		{
			get
			{
				return this.parent_Program_of_Study_ReferenceField;
			}
			set
			{
				this.parent_Program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Program_Name
		{
			get
			{
				return this.program_NameField;
			}
			set
			{
				this.program_NameField = value;
				this.RaisePropertyChanged("Program_Name");
			}
		}

		[XmlElement(Order = 8)]
		public CIP_Code__Workday_Owned_ObjectType CIP_Code_Reference
		{
			get
			{
				return this.cIP_Code_ReferenceField;
			}
			set
			{
				this.cIP_Code_ReferenceField = value;
				this.RaisePropertyChanged("CIP_Code_Reference");
			}
		}

		[XmlElement("Educational_Taxonomy_Codes_Reference", Order = 9)]
		public Educational_Taxonomy_CodeObjectType[] Educational_Taxonomy_Codes_Reference
		{
			get
			{
				return this.educational_Taxonomy_Codes_ReferenceField;
			}
			set
			{
				this.educational_Taxonomy_Codes_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Taxonomy_Codes_Reference");
			}
		}

		[XmlElement("Allowed_Locations_Reference", Order = 10)]
		public LocationObjectType[] Allowed_Locations_Reference
		{
			get
			{
				return this.allowed_Locations_ReferenceField;
			}
			set
			{
				this.allowed_Locations_ReferenceField = value;
				this.RaisePropertyChanged("Allowed_Locations_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool Fast_Path_Enabled
		{
			get
			{
				return this.fast_Path_EnabledField;
			}
			set
			{
				this.fast_Path_EnabledField = value;
				this.RaisePropertyChanged("Fast_Path_Enabled");
			}
		}

		[XmlIgnore]
		public bool Fast_Path_EnabledSpecified
		{
			get
			{
				return this.fast_Path_EnabledFieldSpecified;
			}
			set
			{
				this.fast_Path_EnabledFieldSpecified = value;
				this.RaisePropertyChanged("Fast_Path_EnabledSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Include_Type_in_Name
		{
			get
			{
				return this.include_Type_in_NameField;
			}
			set
			{
				this.include_Type_in_NameField = value;
				this.RaisePropertyChanged("Include_Type_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Type_in_NameSpecified
		{
			get
			{
				return this.include_Type_in_NameFieldSpecified;
			}
			set
			{
				this.include_Type_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Type_in_NameSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime First_Entry_Date
		{
			get
			{
				return this.first_Entry_DateField;
			}
			set
			{
				this.first_Entry_DateField = value;
				this.RaisePropertyChanged("First_Entry_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Last_Entry_Date
		{
			get
			{
				return this.last_Entry_DateField;
			}
			set
			{
				this.last_Entry_DateField = value;
				this.RaisePropertyChanged("Last_Entry_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Entry_DateSpecified
		{
			get
			{
				return this.last_Entry_DateFieldSpecified;
			}
			set
			{
				this.last_Entry_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Entry_DateSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Academic_LevelObjectType Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Academic_UnitObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Academic_CalendarObjectType Academic_Calendar_Reference
		{
			get
			{
				return this.academic_Calendar_ReferenceField;
			}
			set
			{
				this.academic_Calendar_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Calendar_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Academic_Curricular_DivisionObjectType Coordinating_Academic_Unit_Reference
		{
			get
			{
				return this.coordinating_Academic_Unit_ReferenceField;
			}
			set
			{
				this.coordinating_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Coordinating_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public bool Program_Focus_Required
		{
			get
			{
				return this.program_Focus_RequiredField;
			}
			set
			{
				this.program_Focus_RequiredField = value;
				this.RaisePropertyChanged("Program_Focus_Required");
			}
		}

		[XmlIgnore]
		public bool Program_Focus_RequiredSpecified
		{
			get
			{
				return this.program_Focus_RequiredFieldSpecified;
			}
			set
			{
				this.program_Focus_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Program_Focus_RequiredSpecified");
			}
		}

		[XmlElement("Program_Area_Reference", Order = 20)]
		public Program_AreaObjectType[] Program_Area_Reference
		{
			get
			{
				return this.program_Area_ReferenceField;
			}
			set
			{
				this.program_Area_ReferenceField = value;
				this.RaisePropertyChanged("Program_Area_Reference");
			}
		}

		[XmlElement("Educational_Credentials_Reference", Order = 21)]
		public Educational_CredentialObjectType[] Educational_Credentials_Reference
		{
			get
			{
				return this.educational_Credentials_ReferenceField;
			}
			set
			{
				this.educational_Credentials_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Credentials_Reference");
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
