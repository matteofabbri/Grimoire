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
	public class Candidate_Skill_DataType : INotifyPropertyChanged
	{
		private Skill_ItemObjectType skill_ReferenceField;

		private string skill_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Skill_ItemObjectType Skill_Reference
		{
			get
			{
				return this.skill_ReferenceField;
			}
			set
			{
				this.skill_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Reference");
			}
		}

		[XmlElement(Order = 1)]
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
