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
	public class Skill_Source_PrecedenceType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType skill_Source_Precedence_ReferenceField;

		private Skill_Source_Precedence_DataType[] skill_Source_Precedence_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Skill_Source_Precedence_Reference
		{
			get
			{
				return this.skill_Source_Precedence_ReferenceField;
			}
			set
			{
				this.skill_Source_Precedence_ReferenceField = value;
				this.RaisePropertyChanged("Skill_Source_Precedence_Reference");
			}
		}

		[XmlElement("Skill_Source_Precedence_Data", Order = 1)]
		public Skill_Source_Precedence_DataType[] Skill_Source_Precedence_Data
		{
			get
			{
				return this.skill_Source_Precedence_DataField;
			}
			set
			{
				this.skill_Source_Precedence_DataField = value;
				this.RaisePropertyChanged("Skill_Source_Precedence_Data");
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
