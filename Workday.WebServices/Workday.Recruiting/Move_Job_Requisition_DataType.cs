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
	public class Move_Job_Requisition_DataType : INotifyPropertyChanged
	{
		private Job_RequisitionObjectType job_Requisition_to_be_Moved_ReferenceField;

		private Supervisory_OrganizationObjectType new_Supervisory_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_RequisitionObjectType Job_Requisition_to_be_Moved_Reference
		{
			get
			{
				return this.job_Requisition_to_be_Moved_ReferenceField;
			}
			set
			{
				this.job_Requisition_to_be_Moved_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_to_be_Moved_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Supervisory_OrganizationObjectType New_Supervisory_Organization_Reference
		{
			get
			{
				return this.new_Supervisory_Organization_ReferenceField;
			}
			set
			{
				this.new_Supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("New_Supervisory_Organization_Reference");
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
