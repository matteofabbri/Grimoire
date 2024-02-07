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
	public class Education_Profile_for_Job_DataType : INotifyPropertyChanged
	{
		private DegreeObjectType degree_ReferenceField;

		private Field_of_StudyObjectType field_Of_Study_ReferenceField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private Skill_Qualification_EnabledObjectType qualification_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
				this.RaisePropertyChanged("Required");
			}
		}

		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
				this.RaisePropertyChanged("RequiredSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Skill_Qualification_EnabledObjectType Qualification_Source_Reference
		{
			get
			{
				return this.qualification_Source_ReferenceField;
			}
			set
			{
				this.qualification_Source_ReferenceField = value;
				this.RaisePropertyChanged("Qualification_Source_Reference");
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
