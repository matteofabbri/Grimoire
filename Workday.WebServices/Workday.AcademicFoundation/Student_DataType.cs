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
	public class Student_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string student_IDField;

		private string universal_IDField;

		private string account_User_NameField;

		private Student_Record_StatusObjectType student_Record_Status_ReferenceField;

		private Academic_UnitObjectType academic_Unit_ReferenceField;

		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Student_Prospect_Person_DataType[] student_Person_DataField;

		private Student_Program_of_Study_Record_DataType[] student_Program_of_Study_Record_DataField;

		private Registered_Registrations_Subedit_DataType[] registered_Registrations_DataField;

		private Student_Prospect_Proxy_DataType[] student_Friends_and_Family_DataField;

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

		[XmlElement(Order = 1)]
		public string Student_ID
		{
			get
			{
				return this.student_IDField;
			}
			set
			{
				this.student_IDField = value;
				this.RaisePropertyChanged("Student_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Account_User_Name
		{
			get
			{
				return this.account_User_NameField;
			}
			set
			{
				this.account_User_NameField = value;
				this.RaisePropertyChanged("Account_User_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Record_StatusObjectType Student_Record_Status_Reference
		{
			get
			{
				return this.student_Record_Status_ReferenceField;
			}
			set
			{
				this.student_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Record_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement("Student_Person_Data", Order = 7)]
		public Student_Prospect_Person_DataType[] Student_Person_Data
		{
			get
			{
				return this.student_Person_DataField;
			}
			set
			{
				this.student_Person_DataField = value;
				this.RaisePropertyChanged("Student_Person_Data");
			}
		}

		[XmlElement("Student_Program_of_Study_Record_Data", Order = 8)]
		public Student_Program_of_Study_Record_DataType[] Student_Program_of_Study_Record_Data
		{
			get
			{
				return this.student_Program_of_Study_Record_DataField;
			}
			set
			{
				this.student_Program_of_Study_Record_DataField = value;
				this.RaisePropertyChanged("Student_Program_of_Study_Record_Data");
			}
		}

		[XmlElement("Registered_Registrations_Data", Order = 9)]
		public Registered_Registrations_Subedit_DataType[] Registered_Registrations_Data
		{
			get
			{
				return this.registered_Registrations_DataField;
			}
			set
			{
				this.registered_Registrations_DataField = value;
				this.RaisePropertyChanged("Registered_Registrations_Data");
			}
		}

		[XmlElement("Student_Friends_and_Family_Data", Order = 10)]
		public Student_Prospect_Proxy_DataType[] Student_Friends_and_Family_Data
		{
			get
			{
				return this.student_Friends_and_Family_DataField;
			}
			set
			{
				this.student_Friends_and_Family_DataField = value;
				this.RaisePropertyChanged("Student_Friends_and_Family_Data");
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
