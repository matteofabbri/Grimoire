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
	public class Professional_Affiliation_SkillType : INotifyPropertyChanged
	{
		private Professional_Affiliation_SkillObjectType organization_Professional_Affiliation_ReferenceField;

		private Professional_Affiliation_Organization_DataType[] organization_Professional_Affiliation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Professional_Affiliation_SkillObjectType Organization_Professional_Affiliation_Reference
		{
			get
			{
				return this.organization_Professional_Affiliation_ReferenceField;
			}
			set
			{
				this.organization_Professional_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Professional_Affiliation_Reference");
			}
		}

		[XmlElement("Organization_Professional_Affiliation_Data", Order = 1)]
		public Professional_Affiliation_Organization_DataType[] Organization_Professional_Affiliation_Data
		{
			get
			{
				return this.organization_Professional_Affiliation_DataField;
			}
			set
			{
				this.organization_Professional_Affiliation_DataField = value;
				this.RaisePropertyChanged("Organization_Professional_Affiliation_Data");
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
