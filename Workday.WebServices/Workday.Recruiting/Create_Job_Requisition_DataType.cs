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
	public class Create_Job_Requisition_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Event_Classification_SubcategoryObjectType create_Job_Requisition_Reason_ReferenceField;

		private decimal number_of_OpeningsField;

		private bool number_of_OpeningsFieldSpecified;

		private Job_Requisition_Data_for_Create_and_EditType job_Requisition_DataField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Post_Job_Sub_Business_ProcessType post_Job_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		private Request_Requisition_Compensation_Sub_ProcessType request_Requisition_Compensation_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Restriction_Reference", typeof(Position_GroupObjectType), Order = 0), XmlElement("Supervisory_Organization_Reference", typeof(Supervisory_OrganizationObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Create_Job_Requisition_Reason_Reference
		{
			get
			{
				return this.create_Job_Requisition_Reason_ReferenceField;
			}
			set
			{
				this.create_Job_Requisition_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Create_Job_Requisition_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_of_Openings
		{
			get
			{
				return this.number_of_OpeningsField;
			}
			set
			{
				this.number_of_OpeningsField = value;
				this.RaisePropertyChanged("Number_of_Openings");
			}
		}

		[XmlIgnore]
		public bool Number_of_OpeningsSpecified
		{
			get
			{
				return this.number_of_OpeningsFieldSpecified;
			}
			set
			{
				this.number_of_OpeningsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_OpeningsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Job_Requisition_Data_for_Create_and_EditType Job_Requisition_Data
		{
			get
			{
				return this.job_Requisition_DataField;
			}
			set
			{
				this.job_Requisition_DataField = value;
				this.RaisePropertyChanged("Job_Requisition_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Check_Position_Budget_Sub_Business_ProcessType Check_Position_Budget_Sub_Process
		{
			get
			{
				return this.check_Position_Budget_Sub_ProcessField;
			}
			set
			{
				this.check_Position_Budget_Sub_ProcessField = value;
				this.RaisePropertyChanged("Check_Position_Budget_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
		public Post_Job_Sub_Business_ProcessType Post_Job_Sub_Process
		{
			get
			{
				return this.post_Job_Sub_ProcessField;
			}
			set
			{
				this.post_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Post_Job_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
		public Assign_Organization_Roles_Sub_Business_ProcessType Assign_Organization_Roles_Sub_Process
		{
			get
			{
				return this.assign_Organization_Roles_Sub_ProcessField;
			}
			set
			{
				this.assign_Organization_Roles_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Organization_Roles_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Request_Requisition_Compensation_Sub_ProcessType Request_Requisition_Compensation_Sub_Process
		{
			get
			{
				return this.request_Requisition_Compensation_Sub_ProcessField;
			}
			set
			{
				this.request_Requisition_Compensation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Requisition_Compensation_Sub_Process");
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
