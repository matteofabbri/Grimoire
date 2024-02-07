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
	public class Close_Evergreen_Requisition_DataType : INotifyPropertyChanged
	{
		private Evergreen_Job_RequisitionObjectType evergreen_Requisition_ReferenceField;

		private Event_Classification_SubcategoryObjectType close_Evergreen_Requisition_Reason_ReferenceField;

		private DateTime evergreen_Requisition_Close_DateField;

		private Unpost_Job_Sub_Business_ProcessType unpost_Job_Sub_Business_ProcessField;

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
		public Event_Classification_SubcategoryObjectType Close_Evergreen_Requisition_Reason_Reference
		{
			get
			{
				return this.close_Evergreen_Requisition_Reason_ReferenceField;
			}
			set
			{
				this.close_Evergreen_Requisition_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Close_Evergreen_Requisition_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Evergreen_Requisition_Close_Date
		{
			get
			{
				return this.evergreen_Requisition_Close_DateField;
			}
			set
			{
				this.evergreen_Requisition_Close_DateField = value;
				this.RaisePropertyChanged("Evergreen_Requisition_Close_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Unpost_Job_Sub_Business_ProcessType Unpost_Job_Sub_Business_Process
		{
			get
			{
				return this.unpost_Job_Sub_Business_ProcessField;
			}
			set
			{
				this.unpost_Job_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Unpost_Job_Sub_Business_Process");
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
