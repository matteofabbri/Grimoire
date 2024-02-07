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
	public class Manage_Job_History_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Job_History_Event_ReferenceField;

		private Job_HistoryObjectType[] job_History_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Job_History_Event_Reference
		{
			get
			{
				return this.worker_Job_History_Event_ReferenceField;
			}
			set
			{
				this.worker_Job_History_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Job_History_Event_Reference");
			}
		}

		[XmlElement("Job_History_Reference", Order = 1)]
		public Job_HistoryObjectType[] Job_History_Reference
		{
			get
			{
				return this.job_History_ReferenceField;
			}
			set
			{
				this.job_History_ReferenceField = value;
				this.RaisePropertyChanged("Job_History_Reference");
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
