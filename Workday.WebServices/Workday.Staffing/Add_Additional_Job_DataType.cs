using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Add_Additional_Job_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Supervisory_OrganizationObjectType organization_ReferenceField;

		private object itemField;

		private bool exclude_from_HeadcountField;

		private bool exclude_from_HeadcountFieldSpecified;

		private Add_Additional_Job_Event_DataType add_Additional_Job_Event_DataField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Assign_Matrix_Organization_Sub_Business_ProcessType assign_Matrix_Organization_Sub_ProcessField;

		private Assign_Pay_Group_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		private Propose_Compensation_For_Employment_Sub_Business_ProcessType propose_Compensation_for_Additional_Job_Sub_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Onboarding_Setup_Sub_Business_ProcessType onboarding_Setup_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

		private Switch_Primary_Job_Sub_ProcessType switch_Primary_Job_Sub_ProcessField;

		private Add_Academic_Appointment_Sub_Business_ProcessType add_Academic_Appointment_Sub_ProcessField;

		private Student_Employment_Eligibility_Sub_Business_ProcessType student_Employment_Eligibility_Sub_ProcessField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

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
		public Supervisory_OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Job_Requisition_Reference", typeof(Job_RequisitionObjectType), Order = 2), XmlElement("Position_Reference", typeof(Position_RestrictionsObjectType), Order = 2)]
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

		[XmlElement(Order = 3)]
		public bool Exclude_from_Headcount
		{
			get
			{
				return this.exclude_from_HeadcountField;
			}
			set
			{
				this.exclude_from_HeadcountField = value;
				this.RaisePropertyChanged("Exclude_from_Headcount");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_HeadcountSpecified
		{
			get
			{
				return this.exclude_from_HeadcountFieldSpecified;
			}
			set
			{
				this.exclude_from_HeadcountFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_HeadcountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Add_Additional_Job_Event_DataType Add_Additional_Job_Event_Data
		{
			get
			{
				return this.add_Additional_Job_Event_DataField;
			}
			set
			{
				this.add_Additional_Job_Event_DataField = value;
				this.RaisePropertyChanged("Add_Additional_Job_Event_Data");
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
		public Assign_Matrix_Organization_Sub_Business_ProcessType Assign_Matrix_Organization_Sub_Process
		{
			get
			{
				return this.assign_Matrix_Organization_Sub_ProcessField;
			}
			set
			{
				this.assign_Matrix_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Matrix_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Assign_Pay_Group_Sub_Business_ProcessType Assign_Pay_Group_Sub_Process
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
		public Propose_Compensation_For_Employment_Sub_Business_ProcessType Propose_Compensation_for_Additional_Job_Sub_Process
		{
			get
			{
				return this.propose_Compensation_for_Additional_Job_Sub_ProcessField;
			}
			set
			{
				this.propose_Compensation_for_Additional_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Propose_Compensation_for_Additional_Job_Sub_Process");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Onboarding_Setup_Sub_Business_ProcessType Onboarding_Setup_Sub_Process
		{
			get
			{
				return this.onboarding_Setup_Sub_ProcessField;
			}
			set
			{
				this.onboarding_Setup_Sub_ProcessField = value;
				this.RaisePropertyChanged("Onboarding_Setup_Sub_Process");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Switch_Primary_Job_Sub_ProcessType Switch_Primary_Job_Sub_Process
		{
			get
			{
				return this.switch_Primary_Job_Sub_ProcessField;
			}
			set
			{
				this.switch_Primary_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Switch_Primary_Job_Sub_Process");
			}
		}

		[XmlElement(Order = 13)]
		public Add_Academic_Appointment_Sub_Business_ProcessType Add_Academic_Appointment_Sub_Process
		{
			get
			{
				return this.add_Academic_Appointment_Sub_ProcessField;
			}
			set
			{
				this.add_Academic_Appointment_Sub_ProcessField = value;
				this.RaisePropertyChanged("Add_Academic_Appointment_Sub_Process");
			}
		}

		[XmlElement(Order = 14)]
		public Student_Employment_Eligibility_Sub_Business_ProcessType Student_Employment_Eligibility_Sub_Process
		{
			get
			{
				return this.student_Employment_Eligibility_Sub_ProcessField;
			}
			set
			{
				this.student_Employment_Eligibility_Sub_ProcessField = value;
				this.RaisePropertyChanged("Student_Employment_Eligibility_Sub_Process");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
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
