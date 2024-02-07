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
	public class Create_Position_DataType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Event_Classification_SubcategoryObjectType position_Request_Reason_ReferenceField;

		private Position_Definition_DataType position_DataField;

		private Qualification_Data_for_Position_Restriction_or_Job_ProfileType qualification_Replacement_DataField;

		private Position_Group_Restriction_DataType position_Group_Restrictions_DataField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Request_Compensation_Default_Sub_Business_ProcessType request_Default_Compensation_Sub_ProcessField;

		private Assign_Pay_Group_for_Position_Restrictions_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
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

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Position_Request_Reason_Reference
		{
			get
			{
				return this.position_Request_Reason_ReferenceField;
			}
			set
			{
				this.position_Request_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Position_Request_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Definition_DataType Position_Data
		{
			get
			{
				return this.position_DataField;
			}
			set
			{
				this.position_DataField = value;
				this.RaisePropertyChanged("Position_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Qualification_Data_for_Position_Restriction_or_Job_ProfileType Qualification_Replacement_Data
		{
			get
			{
				return this.qualification_Replacement_DataField;
			}
			set
			{
				this.qualification_Replacement_DataField = value;
				this.RaisePropertyChanged("Qualification_Replacement_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Position_Group_Restriction_DataType Position_Group_Restrictions_Data
		{
			get
			{
				return this.position_Group_Restrictions_DataField;
			}
			set
			{
				this.position_Group_Restrictions_DataField = value;
				this.RaisePropertyChanged("Position_Group_Restrictions_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Edit_Assign_Position_Organization_Sub_Business_ProcessType Edit_Assign_Organization_Sub_Process
		{
			get
			{
				return this.edit_Assign_Organization_Sub_ProcessField;
			}
			set
			{
				this.edit_Assign_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Assign_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
		public Request_Compensation_Default_Sub_Business_ProcessType Request_Default_Compensation_Sub_Process
		{
			get
			{
				return this.request_Default_Compensation_Sub_ProcessField;
			}
			set
			{
				this.request_Default_Compensation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Default_Compensation_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Assign_Pay_Group_for_Position_Restrictions_Sub_Business_ProcessType Assign_Pay_Group_Sub_Process
		{
			get
			{
				return this.assign_Pay_Group_Sub_ProcessField;
			}
			set
			{
				this.assign_Pay_Group_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Pay_Group_Sub_Process");
			}
		}

		[XmlElement(Order = 8)]
		public Assign_Costing_Allocation_Sub_Business_ProcessType Assign_Costing_Allocation_Sub_Process
		{
			get
			{
				return this.assign_Costing_Allocation_Sub_ProcessField;
			}
			set
			{
				this.assign_Costing_Allocation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Costing_Allocation_Sub_Process");
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
