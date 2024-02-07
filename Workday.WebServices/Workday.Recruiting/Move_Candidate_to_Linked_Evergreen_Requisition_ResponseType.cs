using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Move_Candidate_to_Linked_Evergreen_Requisition_ResponseType : INotifyPropertyChanged
	{
		private Evergreen_Job_RequisitionObjectType evergreen_Requisition_ReferenceField;

		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private Job_ApplicationObjectType[] job_Application_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Evergreen_Job_RequisitionObjectType Evergreen_Requisition_Reference
		{
			get
			{
				return this.evergreen_Requisition_ReferenceField;
			}
			set
			{
				this.evergreen_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Evergreen_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Job_Application_Reference", Order = 2)]
		public Job_ApplicationObjectType[] Job_Application_Reference
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
