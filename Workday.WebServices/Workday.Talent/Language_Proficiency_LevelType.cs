using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Language_Proficiency_LevelType : INotifyPropertyChanged
	{
		private Language_ProficiencyObjectType language_Proficiency_Level_ReferenceField;

		private Language_Proficiency_Level_DataType[] language_Proficiency_Level_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Language_ProficiencyObjectType Language_Proficiency_Level_Reference
		{
			get
			{
				return this.language_Proficiency_Level_ReferenceField;
			}
			set
			{
				this.language_Proficiency_Level_ReferenceField = value;
				this.RaisePropertyChanged("Language_Proficiency_Level_Reference");
			}
		}

		[XmlElement("Language_Proficiency_Level_Data", Order = 1)]
		public Language_Proficiency_Level_DataType[] Language_Proficiency_Level_Data
		{
			get
			{
				return this.language_Proficiency_Level_DataField;
			}
			set
			{
				this.language_Proficiency_Level_DataField = value;
				this.RaisePropertyChanged("Language_Proficiency_Level_Data");
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
