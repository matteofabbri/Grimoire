using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Professional_Affiliations_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Professional_Affiliation_Event_ReferenceField;

		private Professional_Affiliation_SkillObjectType[] professional_Affiliation_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Professional_Affiliation_Event_Reference
		{
			get
			{
				return this.worker_Professional_Affiliation_Event_ReferenceField;
			}
			set
			{
				this.worker_Professional_Affiliation_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Professional_Affiliation_Event_Reference");
			}
		}

		[XmlElement("Professional_Affiliation_Reference", Order = 1)]
		public Professional_Affiliation_SkillObjectType[] Professional_Affiliation_Reference
		{
			get
			{
				return this.professional_Affiliation_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
