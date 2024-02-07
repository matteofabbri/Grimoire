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
	public class Educational_Institution_Course_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private string educational_Institution_Course_NumberField;

		private Educational_Institution_Course_Academic_AreaObjectType educational_Institution_Course_Academic_Area_ReferenceField;

		private string educational_Institution_Course_TitleField;

		private Educational_Institution_Course_DesignationObjectType[] educational_Institution_Course_Designations_ReferenceField;

		private decimal educational_Institution_Course_CreditsField;

		private bool educational_Institution_Course_CreditsFieldSpecified;

		private Other_Unit_TypeObjectType educational_Institution_Course_Unit_Type_ReferenceField;

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

		[XmlElement(Order = 2)]
		public string Educational_Institution_Course_Number
		{
			get
			{
				return this.educational_Institution_Course_NumberField;
			}
			set
			{
				this.educational_Institution_Course_NumberField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Educational_Institution_Course_Academic_AreaObjectType Educational_Institution_Course_Academic_Area_Reference
		{
			get
			{
				return this.educational_Institution_Course_Academic_Area_ReferenceField;
			}
			set
			{
				this.educational_Institution_Course_Academic_Area_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Academic_Area_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Educational_Institution_Course_Title
		{
			get
			{
				return this.educational_Institution_Course_TitleField;
			}
			set
			{
				this.educational_Institution_Course_TitleField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Title");
			}
		}

		[XmlElement("Educational_Institution_Course_Designations_Reference", Order = 5)]
		public Educational_Institution_Course_DesignationObjectType[] Educational_Institution_Course_Designations_Reference
		{
			get
			{
				return this.educational_Institution_Course_Designations_ReferenceField;
			}
			set
			{
				this.educational_Institution_Course_Designations_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Designations_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Educational_Institution_Course_Credits
		{
			get
			{
				return this.educational_Institution_Course_CreditsField;
			}
			set
			{
				this.educational_Institution_Course_CreditsField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Credits");
			}
		}

		[XmlIgnore]
		public bool Educational_Institution_Course_CreditsSpecified
		{
			get
			{
				return this.educational_Institution_Course_CreditsFieldSpecified;
			}
			set
			{
				this.educational_Institution_Course_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Educational_Institution_Course_CreditsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Other_Unit_TypeObjectType Educational_Institution_Course_Unit_Type_Reference
		{
			get
			{
				return this.educational_Institution_Course_Unit_Type_ReferenceField;
			}
			set
			{
				this.educational_Institution_Course_Unit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Course_Unit_Type_Reference");
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
