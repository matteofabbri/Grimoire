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
	public class Work_Experience_SkillType : INotifyPropertyChanged
	{
		private Work_Experience_SkillObjectType work_Experience_Skill_ReferenceField;

		private Work_Experience_Skill_DataType[] work_Experience_Skill_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Experience_SkillObjectType Work_Experience_Skill_Reference
		{
			get
			{
				return this.work_Experience_Skill_ReferenceField;
			}
			set
			{
				this.work_Experience_Skill_ReferenceField = value;
				this.RaisePropertyChanged("Work_Experience_Skill_Reference");
			}
		}

		[XmlElement("Work_Experience_Skill_Data", Order = 1)]
		public Work_Experience_Skill_DataType[] Work_Experience_Skill_Data
		{
			get
			{
				return this.work_Experience_Skill_DataField;
			}
			set
			{
				this.work_Experience_Skill_DataField = value;
				this.RaisePropertyChanged("Work_Experience_Skill_Data");
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
