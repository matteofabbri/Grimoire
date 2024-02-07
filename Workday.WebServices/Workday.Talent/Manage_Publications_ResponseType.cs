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
	public class Manage_Publications_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType publication_Event_ReferenceField;

		private Publication_SkillObjectType[] publication_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Publication_Event_Reference
		{
			get
			{
				return this.publication_Event_ReferenceField;
			}
			set
			{
				this.publication_Event_ReferenceField = value;
				this.RaisePropertyChanged("Publication_Event_Reference");
			}
		}

		[XmlElement("Publication_Reference", Order = 1)]
		public Publication_SkillObjectType[] Publication_Reference
		{
			get
			{
				return this.publication_ReferenceField;
			}
			set
			{
				this.publication_ReferenceField = value;
				this.RaisePropertyChanged("Publication_Reference");
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
