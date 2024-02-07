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
	public class Manage_Internal_Projects_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Internal_Project_Event_ReferenceField;

		private Internal_Project_ExperienceObjectType[] internal_Project_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Internal_Project_Event_Reference
		{
			get
			{
				return this.worker_Internal_Project_Event_ReferenceField;
			}
			set
			{
				this.worker_Internal_Project_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Internal_Project_Event_Reference");
			}
		}

		[XmlElement("Internal_Project_Reference", Order = 1)]
		public Internal_Project_ExperienceObjectType[] Internal_Project_Reference
		{
			get
			{
				return this.internal_Project_ReferenceField;
			}
			set
			{
				this.internal_Project_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Project_Reference");
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
