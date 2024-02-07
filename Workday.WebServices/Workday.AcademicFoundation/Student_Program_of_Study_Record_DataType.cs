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
	public class Student_Program_of_Study_Record_DataType : INotifyPropertyChanged
	{
		private Program_of_Study_TypeObjectType program_of_Study_Type_ReferenceField;

		private Program_of_StudyObjectType program_of_Study_ReferenceField;

		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Program_Area_Subedit_DataType[] program_of_Study_Area_Subedit_DataField;

		private Educational_CredentialObjectType[] educational_Credentials_ReferenceField;

		private Student_Program_of_Study_Record_StatusObjectType student_Program_of_Study_Record_Status_ReferenceField;

		private DateTime declare_DateField;

		private bool declare_DateFieldSpecified;

		private DateTime expected_Completion_DateField;

		private bool expected_Completion_DateFieldSpecified;

		private DateTime requirements_EffectiveField;

		private bool requirements_EffectiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Program_of_StudyObjectType Program_of_Study_Reference
		{
			get
			{
				return this.program_of_Study_ReferenceField;
			}
			set
			{
				this.program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlArray(Order = 4), XmlArrayItem("Program_Area_Subedit_Data", typeof(Program_Area_Subedit_DataType), IsNullable = false)]
		public Program_Area_Subedit_DataType[] Program_of_Study_Area_Subedit_Data
		{
			get
			{
				return this.program_of_Study_Area_Subedit_DataField;
			}
			set
			{
				this.program_of_Study_Area_Subedit_DataField = value;
				this.RaisePropertyChanged("Program_of_Study_Area_Subedit_Data");
			}
		}

		[XmlElement("Educational_Credentials_Reference", Order = 5)]
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

		[XmlElement(Order = 6)]
		public Student_Program_of_Study_Record_StatusObjectType Student_Program_of_Study_Record_Status_Reference
		{
			get
			{
				return this.student_Program_of_Study_Record_Status_ReferenceField;
			}
			set
			{
				this.student_Program_of_Study_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Program_of_Study_Record_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Declare_Date
		{
			get
			{
				return this.declare_DateField;
			}
			set
			{
				this.declare_DateField = value;
				this.RaisePropertyChanged("Declare_Date");
			}
		}

		[XmlIgnore]
		public bool Declare_DateSpecified
		{
			get
			{
				return this.declare_DateFieldSpecified;
			}
			set
			{
				this.declare_DateFieldSpecified = value;
				this.RaisePropertyChanged("Declare_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Expected_Completion_Date
		{
			get
			{
				return this.expected_Completion_DateField;
			}
			set
			{
				this.expected_Completion_DateField = value;
				this.RaisePropertyChanged("Expected_Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Completion_DateSpecified
		{
			get
			{
				return this.expected_Completion_DateFieldSpecified;
			}
			set
			{
				this.expected_Completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Completion_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Requirements_Effective
		{
			get
			{
				return this.requirements_EffectiveField;
			}
			set
			{
				this.requirements_EffectiveField = value;
				this.RaisePropertyChanged("Requirements_Effective");
			}
		}

		[XmlIgnore]
		public bool Requirements_EffectiveSpecified
		{
			get
			{
				return this.requirements_EffectiveFieldSpecified;
			}
			set
			{
				this.requirements_EffectiveFieldSpecified = value;
				this.RaisePropertyChanged("Requirements_EffectiveSpecified");
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
