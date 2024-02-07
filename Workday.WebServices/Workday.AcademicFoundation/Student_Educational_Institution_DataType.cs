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
	public class Student_Educational_Institution_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string educational_Institution_NameField;

		private Educational_Institution_School_LevelObjectType educational_Institution_School_Level_ReferenceField;

		private Educational_Institution_CategoryObjectType educational_Institution_Category_ReferenceField;

		private Educational_Institution_TypeObjectType educational_Institution_Type_ReferenceField;

		private Educational_Institution_Students_In_Grade_DataType[] educational_Institution_Students_In_Grade_DataField;

		private Educational_Institution_LocaleObjectType educational_Institution_Locale_ReferenceField;

		private Educational_DesignationObjectType[] educational_Designation_ReferenceField;

		private Educational_Institution_Ethnicity_Information_DataType[] educational_Institution_Ethnicity_Information_DataField;

		private Educational_Institution_Religious_OrientationObjectType educational_Institution_Religious_Orientation_ReferenceField;

		private Academic_ContactObjectType[] educational_Institution_Representative_ReferenceField;

		private Contact_Information_DataType[] contact_Information_DataField;

		private Educational_Institution_Operational_StatusObjectType educational_Institution_Operational_Status_ReferenceField;

		private External_Institution_Grading_SchemeObjectType[] external_Institution_Grading_Scheme_ReferenceField;

		private Educational_Institution_Session_TypeObjectType[] educational_Institution_Session_Type_ReferenceField;

		private Educational_Institution_Student_Body_DataType[] educational_Institution_Student_Body_DataField;

		private object itemField;

		private Educational_Institution_Accreditation_DataType[] educational_Institution_Accreditation_DataField;

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
		public string Educational_Institution_Name
		{
			get
			{
				return this.educational_Institution_NameField;
			}
			set
			{
				this.educational_Institution_NameField = value;
				this.RaisePropertyChanged("Educational_Institution_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Educational_Institution_School_LevelObjectType Educational_Institution_School_Level_Reference
		{
			get
			{
				return this.educational_Institution_School_Level_ReferenceField;
			}
			set
			{
				this.educational_Institution_School_Level_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_School_Level_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Educational_Institution_CategoryObjectType Educational_Institution_Category_Reference
		{
			get
			{
				return this.educational_Institution_Category_ReferenceField;
			}
			set
			{
				this.educational_Institution_Category_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Educational_Institution_TypeObjectType Educational_Institution_Type_Reference
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

		[XmlElement("Educational_Institution_Students_In_Grade_Data", Order = 5)]
		public Educational_Institution_Students_In_Grade_DataType[] Educational_Institution_Students_In_Grade_Data
		{
			get
			{
				return this.educational_Institution_Students_In_Grade_DataField;
			}
			set
			{
				this.educational_Institution_Students_In_Grade_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_Students_In_Grade_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Educational_Institution_LocaleObjectType Educational_Institution_Locale_Reference
		{
			get
			{
				return this.educational_Institution_Locale_ReferenceField;
			}
			set
			{
				this.educational_Institution_Locale_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Locale_Reference");
			}
		}

		[XmlElement("Educational_Designation_Reference", Order = 7)]
		public Educational_DesignationObjectType[] Educational_Designation_Reference
		{
			get
			{
				return this.educational_Designation_ReferenceField;
			}
			set
			{
				this.educational_Designation_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Designation_Reference");
			}
		}

		[XmlElement("Educational_Institution_Ethnicity_Information_Data", Order = 8)]
		public Educational_Institution_Ethnicity_Information_DataType[] Educational_Institution_Ethnicity_Information_Data
		{
			get
			{
				return this.educational_Institution_Ethnicity_Information_DataField;
			}
			set
			{
				this.educational_Institution_Ethnicity_Information_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_Ethnicity_Information_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Educational_Institution_Religious_OrientationObjectType Educational_Institution_Religious_Orientation_Reference
		{
			get
			{
				return this.educational_Institution_Religious_Orientation_ReferenceField;
			}
			set
			{
				this.educational_Institution_Religious_Orientation_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Religious_Orientation_Reference");
			}
		}

		[XmlElement("Educational_Institution_Representative_Reference", Order = 10)]
		public Academic_ContactObjectType[] Educational_Institution_Representative_Reference
		{
			get
			{
				return this.educational_Institution_Representative_ReferenceField;
			}
			set
			{
				this.educational_Institution_Representative_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Representative_Reference");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 11)]
		public Contact_Information_DataType[] Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Educational_Institution_Operational_StatusObjectType Educational_Institution_Operational_Status_Reference
		{
			get
			{
				return this.educational_Institution_Operational_Status_ReferenceField;
			}
			set
			{
				this.educational_Institution_Operational_Status_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Operational_Status_Reference");
			}
		}

		[XmlElement("External_Institution_Grading_Scheme_Reference", Order = 13)]
		public External_Institution_Grading_SchemeObjectType[] External_Institution_Grading_Scheme_Reference
		{
			get
			{
				return this.external_Institution_Grading_Scheme_ReferenceField;
			}
			set
			{
				this.external_Institution_Grading_Scheme_ReferenceField = value;
				this.RaisePropertyChanged("External_Institution_Grading_Scheme_Reference");
			}
		}

		[XmlElement("Educational_Institution_Session_Type_Reference", Order = 14)]
		public Educational_Institution_Session_TypeObjectType[] Educational_Institution_Session_Type_Reference
		{
			get
			{
				return this.educational_Institution_Session_Type_ReferenceField;
			}
			set
			{
				this.educational_Institution_Session_Type_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Session_Type_Reference");
			}
		}

		[XmlElement("Educational_Institution_Student_Body_Data", Order = 15)]
		public Educational_Institution_Student_Body_DataType[] Educational_Institution_Student_Body_Data
		{
			get
			{
				return this.educational_Institution_Student_Body_DataField;
			}
			set
			{
				this.educational_Institution_Student_Body_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_Student_Body_Data");
			}
		}

		[XmlElement("Educational_Institution_Postsecondary_Data", typeof(Postsecondary_Educational_Institution_DataType), Order = 16), XmlElement("Educational_Institution_Secondary_Data", typeof(Secondary_Educational_Institution_DataType), Order = 16)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Educational_Institution_Accreditation_Data", Order = 17)]
		public Educational_Institution_Accreditation_DataType[] Educational_Institution_Accreditation_Data
		{
			get
			{
				return this.educational_Institution_Accreditation_DataField;
			}
			set
			{
				this.educational_Institution_Accreditation_DataField = value;
				this.RaisePropertyChanged("Educational_Institution_Accreditation_Data");
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
