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
	public class Manage_Work_Experiences_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Work_Experience_Event_ReferenceField;

		private Work_Experience_SkillObjectType[] work_Experience_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Work_Experience_Event_Reference
		{
			get
			{
				return this.worker_Work_Experience_Event_ReferenceField;
			}
			set
			{
				this.worker_Work_Experience_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Work_Experience_Event_Reference");
			}
		}

		[XmlElement("Work_Experience_Reference", Order = 1)]
		public Work_Experience_SkillObjectType[] Work_Experience_Reference
		{
			get
			{
				return this.work_Experience_ReferenceField;
			}
			set
			{
				this.work_Experience_ReferenceField = value;
				this.RaisePropertyChanged("Work_Experience_Reference");
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
