using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Request_CriteriaType : INotifyPropertyChanged
	{
		private Transaction_Log_CriteriaType[] transaction_Log_Criteria_DataField;

		private Supervisory_OrganizationObjectType[] supervisory_Organization_ReferenceField;

		private Job_RequisitionObjectType[] job_Requisition_ReferenceField;

		private bool exclude_Filled_PositionsField;

		private bool exclude_Filled_PositionsFieldSpecified;

		private bool exclude_NonRecruitable_PositionsField;

		private bool exclude_NonRecruitable_PositionsFieldSpecified;

		private bool ignore_Future_PositionsField;

		private bool ignore_Future_PositionsFieldSpecified;

		private EventObjectType event_ReferenceField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		private LocationObjectType[] location_ReferenceField;

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

		[XmlElement("Supervisory_Organization_Reference", Order = 1)]
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

		[XmlElement("Job_Requisition_Reference", Order = 2)]
		public Job_RequisitionObjectType[] Job_Requisition_Reference
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

		[XmlElement(Order = 3)]
		public bool Exclude_Filled_Positions
		{
			get
			{
				return this.exclude_Filled_PositionsField;
			}
			set
			{
				this.exclude_Filled_PositionsField = value;
				this.RaisePropertyChanged("Exclude_Filled_Positions");
			}
		}

		[XmlIgnore]
		public bool Exclude_Filled_PositionsSpecified
		{
			get
			{
				return this.exclude_Filled_PositionsFieldSpecified;
			}
			set
			{
				this.exclude_Filled_PositionsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Filled_PositionsSpecified");
			}
		}

		[XmlElement("Exclude_Non-Recruitable_Positions", Order = 4)]
		public bool Exclude_NonRecruitable_Positions
		{
			get
			{
				return this.exclude_NonRecruitable_PositionsField;
			}
			set
			{
				this.exclude_NonRecruitable_PositionsField = value;
				this.RaisePropertyChanged("Exclude_NonRecruitable_Positions");
			}
		}

		[XmlIgnore]
		public bool Exclude_NonRecruitable_PositionsSpecified
		{
			get
			{
				return this.exclude_NonRecruitable_PositionsFieldSpecified;
			}
			set
			{
				this.exclude_NonRecruitable_PositionsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_NonRecruitable_PositionsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Ignore_Future_Positions
		{
			get
			{
				return this.ignore_Future_PositionsField;
			}
			set
			{
				this.ignore_Future_PositionsField = value;
				this.RaisePropertyChanged("Ignore_Future_Positions");
			}
		}

		[XmlIgnore]
		public bool Ignore_Future_PositionsSpecified
		{
			get
			{
				return this.ignore_Future_PositionsFieldSpecified;
			}
			set
			{
				this.ignore_Future_PositionsFieldSpecified = value;
				this.RaisePropertyChanged("Ignore_Future_PositionsSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public EventObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
			}
		}

		[XmlElement("Location_Reference", Order = 8)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Additional_Locations_Reference", Order = 9)]
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
