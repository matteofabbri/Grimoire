using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Language_Ability_DataType : INotifyPropertyChanged
	{
		private Language_ProficiencyObjectType language_Proficiency_ReferenceField;

		private Language_Ability_TypeObjectType language_Ability_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Language_ProficiencyObjectType Language_Proficiency_Reference
		{
			get
			{
				return this.language_Proficiency_ReferenceField;
			}
			set
			{
				this.language_Proficiency_ReferenceField = value;
				this.RaisePropertyChanged("Language_Proficiency_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Language_Ability_TypeObjectType Language_Ability_Type_Reference
		{
			get
			{
				return this.language_Ability_Type_ReferenceField;
			}
			set
			{
				this.language_Ability_Type_ReferenceField = value;
				this.RaisePropertyChanged("Language_Ability_Type_Reference");
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
