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
	public class Student_Application_Details_Recruitable_Language_Subedit_DataType : INotifyPropertyChanged
	{
		private Recruitable_LanguageObjectType recruitable_Language_ReferenceField;

		private LanguageObjectType language_Skill_ReferenceField;

		private bool native_LanguageField;

		private bool native_LanguageFieldSpecified;

		private Student_Application_Details_Language_Ability_Subedit_DataType[] student_Application_Details_Language_Ability_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruitable_LanguageObjectType Recruitable_Language_Reference
		{
			get
			{
				return this.recruitable_Language_ReferenceField;
			}
			set
			{
				this.recruitable_Language_ReferenceField = value;
				this.RaisePropertyChanged("Recruitable_Language_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LanguageObjectType Language_Skill_Reference
		{
			get
			{
				return this.language_Skill_ReferenceField;
			}
			set
			{
				this.language_Skill_ReferenceField = value;
				this.RaisePropertyChanged("Language_Skill_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Native_Language
		{
			get
			{
				return this.native_LanguageField;
			}
			set
			{
				this.native_LanguageField = value;
				this.RaisePropertyChanged("Native_Language");
			}
		}

		[XmlIgnore]
		public bool Native_LanguageSpecified
		{
			get
			{
				return this.native_LanguageFieldSpecified;
			}
			set
			{
				this.native_LanguageFieldSpecified = value;
				this.RaisePropertyChanged("Native_LanguageSpecified");
			}
		}

		[XmlElement("Student_Application_Details_Language_Ability_Data", Order = 3)]
		public Student_Application_Details_Language_Ability_Subedit_DataType[] Student_Application_Details_Language_Ability_Data
		{
			get
			{
				return this.student_Application_Details_Language_Ability_DataField;
			}
			set
			{
				this.student_Application_Details_Language_Ability_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Language_Ability_Data");
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
