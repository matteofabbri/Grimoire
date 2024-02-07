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
	public class Skill_Item_Proposal_DataType : INotifyPropertyChanged
	{
		private Skill_ItemObjectType skill_Item_ReferenceField;

		private bool remove_SkillField;

		private bool remove_SkillFieldSpecified;

		private string skill_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_ItemObjectType Skill_Item_Reference
		{
			get
			{
				return this.skill_Item_ReferenceField;
			}
			set
			{
				this.skill_Item_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Skill
		{
			get
			{
				return this.remove_SkillField;
			}
			set
			{
				this.remove_SkillField = value;
				this.RaisePropertyChanged("Remove_Skill");
			}
		}

		[XmlIgnore]
		public bool Remove_SkillSpecified
		{
			get
			{
				return this.remove_SkillFieldSpecified;
			}
			set
			{
				this.remove_SkillFieldSpecified = value;
				this.RaisePropertyChanged("Remove_SkillSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Skill_Name
		{
			get
			{
				return this.skill_NameField;
			}
			set
			{
				this.skill_NameField = value;
				this.RaisePropertyChanged("Skill_Name");
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
