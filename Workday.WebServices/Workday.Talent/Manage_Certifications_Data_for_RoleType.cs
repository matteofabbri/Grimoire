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
	public class Manage_Certifications_Data_for_RoleType : INotifyPropertyChanged
	{
		private RoleObjectType role_ReferenceField;

		private Person_Skill_Source_CategoryObjectType source_ReferenceField;

		private Certification_AchievementType[] certificationField;

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

		[XmlElement("Certification", Order = 2)]
		public Certification_AchievementType[] Certification
		{
			get
			{
				return this.certificationField;
			}
			set
			{
				this.certificationField = value;
				this.RaisePropertyChanged("Certification");
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
