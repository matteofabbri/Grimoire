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
	public class End_International_Assignment_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime end_International_Assignment_DateField;

		private End_International_Assignment_Event_DataType end_International_Assignment_Event_DataField;

		private Create_Job_Requisition_Sub_ProcessType create_Job_Requisition_Sub_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

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
		public DateTime End_International_Assignment_Date
		{
			get
			{
				return this.end_International_Assignment_DateField;
			}
			set
			{
				this.end_International_Assignment_DateField = value;
				this.RaisePropertyChanged("End_International_Assignment_Date");
			}
		}

		[XmlElement(Order = 3)]
		public End_International_Assignment_Event_DataType End_International_Assignment_Event_Data
		{
			get
			{
				return this.end_International_Assignment_Event_DataField;
			}
			set
			{
				this.end_International_Assignment_Event_DataField = value;
				this.RaisePropertyChanged("End_International_Assignment_Event_Data");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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
