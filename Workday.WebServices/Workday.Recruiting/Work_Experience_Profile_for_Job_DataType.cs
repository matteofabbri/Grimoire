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
	public class Work_Experience_Profile_for_Job_DataType : INotifyPropertyChanged
	{
		private Work_Experience_SkillObjectType work_Experience_ReferenceField;

		private Work_Experience_RatingObjectType work_Experience_Rating_ReferenceField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private Skill_Qualification_EnabledObjectType qualification_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Experience_SkillObjectType Work_Experience_Reference
		{
			get
			{
				return this.work_Experience_ReferenceField;
			}
			set
			{
				this.work_Experience_ReferenceField = value;
				this.RaisePropertyChanged("Work_Experience_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Work_Experience_RatingObjectType Work_Experience_Rating_Reference
		{
			get
			{
				return this.work_Experience_Rating_ReferenceField;
			}
			set
			{
				this.work_Experience_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Work_Experience_Rating_Reference");
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
