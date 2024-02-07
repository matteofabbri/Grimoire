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
	public class End_Additional_Job_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime end_Additional_Job_DateField;

		private End_Additional_Job_Event_DataType end_Additional_Job_Event_DataField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		private Create_Job_Requisition_Sub_ProcessType create_Job_Requisition_Sub_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private End_Academic_Appointment_Sub_Business_ProcessType end_Academic_Appointment_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime End_Additional_Job_Date
		{
			get
			{
				return this.end_Additional_Job_DateField;
			}
			set
			{
				this.end_Additional_Job_DateField = value;
				this.RaisePropertyChanged("End_Additional_Job_Date");
			}
		}

		[XmlElement(Order = 3)]
		public End_Additional_Job_Event_DataType End_Additional_Job_Event_Data
		{
			get
			{
				return this.end_Additional_Job_Event_DataField;
			}
			set
			{
				this.end_Additional_Job_Event_DataField = value;
				this.RaisePropertyChanged("End_Additional_Job_Event_Data");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Create_Job_Requisition_Sub_ProcessType Create_Job_Requisition_Sub_Process
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public End_Academic_Appointment_Sub_Business_ProcessType End_Academic_Appointment_Sub_Process
		{
			get
			{
				return this.end_Academic_Appointment_Sub_ProcessField;
			}
			set
			{
				this.end_Academic_Appointment_Sub_ProcessField = value;
				this.RaisePropertyChanged("End_Academic_Appointment_Sub_Process");
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
