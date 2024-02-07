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
	public class Manage_Training_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Training_Event_ReferenceField;

		private TrainingObjectType[] training_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Training_Event_Reference
		{
			get
			{
				return this.worker_Training_Event_ReferenceField;
			}
			set
			{
				this.worker_Training_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Training_Event_Reference");
			}
		}

		[XmlElement("Training_Reference", Order = 1)]
		public TrainingObjectType[] Training_Reference
		{
			get
			{
				return this.training_ReferenceField;
			}
			set
			{
				this.training_ReferenceField = value;
				this.RaisePropertyChanged("Training_Reference");
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
