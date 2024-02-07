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
	public class International_Student_Person_DataType : INotifyPropertyChanged
	{
		private CountryObjectType[] country_of_Residence_ReferenceField;

		private LanguageObjectType[] language_Skill_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Country_of_Residence_Reference", Order = 0)]
		public CountryObjectType[] Country_of_Residence_Reference
		{
			get
			{
				return this.country_of_Residence_ReferenceField;
			}
			set
			{
				this.country_of_Residence_ReferenceField = value;
				this.RaisePropertyChanged("Country_of_Residence_Reference");
			}
		}

		[XmlElement("Language_Skill_Reference", Order = 1)]
		public LanguageObjectType[] Language_Skill_Reference
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
