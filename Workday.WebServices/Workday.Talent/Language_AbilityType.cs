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
	public class Language_AbilityType : INotifyPropertyChanged
	{
		private Language_AbilityObjectType language_Ability_ReferenceField;

		private Language_Ability_DataType[] language_Ability_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Language_AbilityObjectType Language_Ability_Reference
		{
			get
			{
				return this.language_Ability_ReferenceField;
			}
			set
			{
				this.language_Ability_ReferenceField = value;
				this.RaisePropertyChanged("Language_Ability_Reference");
			}
		}

		[XmlElement("Language_Ability_Data", Order = 1)]
		public Language_Ability_DataType[] Language_Ability_Data
		{
			get
			{
				return this.language_Ability_DataField;
			}
			set
			{
				this.language_Ability_DataField = value;
				this.RaisePropertyChanged("Language_Ability_Data");
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
