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
	public class End_Contingent_Worker_Contract_DataType : INotifyPropertyChanged
	{
		private Contingent_WorkerObjectType contingent_Worker_ReferenceField;

		private DateTime contract_End_DateField;

		private End_Contingent_Worker_Contract_Event_DataType end_Contract_Event_DataField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		private Create_Job_Requisition_Sub_ProcessType[] create_Job_Requisition_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contingent_WorkerObjectType Contingent_Worker_Reference
		{
			get
			{
				return this.contingent_Worker_ReferenceField;
			}
			set
			{
				this.contingent_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Contingent_Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlElement(Order = 2)]
		public End_Contingent_Worker_Contract_Event_DataType End_Contract_Event_Data
		{
			get
			{
				return this.end_Contract_Event_DataField;
			}
			set
			{
				this.end_Contract_Event_DataField = value;
				this.RaisePropertyChanged("End_Contract_Event_Data");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Create_Job_Requisition_Sub_Process", Order = 4)]
		public Create_Job_Requisition_Sub_ProcessType[] Create_Job_Requisition_Sub_Process
		{
			get
			{
				return this.create_Job_Requisition_Sub_ProcessField;
			}
			set
			{
				this.create_Job_Requisition_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Job_Requisition_Sub_Process");
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
