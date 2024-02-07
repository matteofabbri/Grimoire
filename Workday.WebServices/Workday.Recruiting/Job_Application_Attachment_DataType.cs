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
	public class Job_Application_Attachment_DataType : INotifyPropertyChanged
	{
		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private Job_ApplicationObjectType job_Application_ReferenceField;

		private Attachment_WWS_DataType attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_RequisitionObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Attachment_WWS_DataType Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
