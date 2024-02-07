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
	public class Skill_ProfileType : INotifyPropertyChanged
	{
		private Skill_ProfileObjectType skill_Profile_ReferenceField;

		private Skill_Profile_DataType[] skill_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_ProfileObjectType Skill_Profile_Reference
		{
			get
			{
				return this.skill_Profile_ReferenceField;
			}
			set
			{
				this.skill_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Profile_Reference");
			}
		}

		[XmlElement("Skill_Profile_Data", Order = 1)]
		public Skill_Profile_DataType[] Skill_Profile_Data
		{
			get
			{
				return this.skill_Profile_DataField;
			}
			set
			{
				this.skill_Profile_DataField = value;
				this.RaisePropertyChanged("Skill_Profile_Data");
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
