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
	public class Job_Application_Attachment_ResponseType : INotifyPropertyChanged
	{
		private Job_ApplicationObjectType job_Application_ReferenceField;

		private Resume_AttachmentObjectType[] job_Application_Attachment_ReferenceField;

		private string job_Applications_UpdatedField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_ApplicationObjectType Job_Application_Reference
		{
			get
			{
				return this.job_Application_ReferenceField;
			}
			set
			{
				this.job_Application_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Reference");
			}
		}

		[XmlElement("Job_Application_Attachment_Reference", Order = 1)]
		public Resume_AttachmentObjectType[] Job_Application_Attachment_Reference
		{
			get
			{
				return this.job_Application_Attachment_ReferenceField;
			}
			set
			{
				this.job_Application_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Attachment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Applications_Updated
		{
			get
			{
				return this.job_Applications_UpdatedField;
			}
			set
			{
				this.job_Applications_UpdatedField = value;
				this.RaisePropertyChanged("Job_Applications_Updated");
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
