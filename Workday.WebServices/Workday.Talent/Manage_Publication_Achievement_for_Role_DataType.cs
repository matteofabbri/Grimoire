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
	public class Manage_Publication_Achievement_for_Role_DataType : INotifyPropertyChanged
	{
		private RoleObjectType role_ReferenceField;

		private Person_Skill_Source_CategoryObjectType source_ReferenceField;

		private PublicationType[] publication_AchievementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Role_Reference
		{
			get
			{
				return this.role_ReferenceField;
			}
			set
			{
				this.role_ReferenceField = value;
				this.RaisePropertyChanged("Role_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Person_Skill_Source_CategoryObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement("Publication_Achievement", Order = 2)]
		public PublicationType[] Publication_Achievement
		{
			get
			{
				return this.publication_AchievementField;
			}
			set
			{
				this.publication_AchievementField = value;
				this.RaisePropertyChanged("Publication_Achievement");
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
