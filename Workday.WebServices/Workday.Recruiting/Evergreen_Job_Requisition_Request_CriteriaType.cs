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
	public class Evergreen_Job_Requisition_Request_CriteriaType : INotifyPropertyChanged
	{
		private Transaction_Log_CriteriaType[] transaction_Log_Criteria_DataField;

		private Job_Requisition_StatusObjectType[] job_Requisition_Status_ReferenceField;

		private Supervisory_OrganizationObjectType[] supervisory_Organization_ReferenceField;

		private LocationObjectType[] primary_Location_ReferenceField;

		private LocationObjectType[] additional_Locations_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Log_Criteria_Data", Order = 0)]
		public Transaction_Log_CriteriaType[] Transaction_Log_Criteria_Data
		{
			get
			{
				return this.transaction_Log_Criteria_DataField;
			}
			set
			{
				this.transaction_Log_Criteria_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Criteria_Data");
			}
		}

		[XmlElement("Job_Requisition_Status_Reference", Order = 1)]
		public Job_Requisition_StatusObjectType[] Job_Requisition_Status_Reference
		{
			get
			{
				return this.job_Requisition_Status_ReferenceField;
			}
			set
			{
				this.job_Requisition_Status_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Status_Reference");
			}
		}

		[XmlElement("Supervisory_Organization_Reference", Order = 2)]
		public Supervisory_OrganizationObjectType[] Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Primary_Location_Reference", Order = 3)]
		public LocationObjectType[] Primary_Location_Reference
		{
			get
			{
				return this.primary_Location_ReferenceField;
			}
			set
			{
				this.primary_Location_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Location_Reference");
			}
		}

		[XmlElement("Additional_Locations_Reference", Order = 4)]
		public LocationObjectType[] Additional_Locations_Reference
		{
			get
			{
				return this.additional_Locations_ReferenceField;
			}
			set
			{
				this.additional_Locations_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Locations_Reference");
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
