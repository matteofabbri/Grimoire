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
	public class Contract_Contingent_Worker_Business_Process_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Supervisory_OrganizationObjectType organization_ReferenceField;

		private object item1Field;

		private DateTime contract_Start_DateField;

		private Contract_Contingent_Worker_Event_DataType contract_Contingent_Worker_Event_DataField;

		private Update_ID_Information_Sub_Business_ProcessType update_ID_Information_Sub_ProcessField;

		private Edit_Government_IDs_Sub_Business_ProcessType edit_Government_IDs_Sub_ProcessField;

		private Edit_Passports_and_Visas_Sub_Business_ProcessType edit_Passports_and_Visas_Sub_ProcessField;

		private Edit_Licenses_Sub_Business_ProcessType edit_License_Sub_ProcessField;

		private Edit_Custom_IDs_Sub_Business_ProcessType edit_Custom_IDs_Sub_ProcessField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Create_Workday_Account_Sub_Business_ProcessType create_Workday_Account_Sub_ProcessField;

		private Assign_Matrix_Organization_Sub_Business_ProcessType assign_Matrix_Organization_Sub_ProcessField;

		private Change_Personal_Information_Sub_Business_ProcessType change_Personal_Information_Sub_ProcessField;

		private Edit_Service_Dates_Sub_Business_ProcessType edit_Service_Dates_Sub_ProcessField;

		private Remove_Retiree_Status_Sub_Business_ProcessType remove_Retiree_Status_Sub_ProcessField;

		private Onboarding_Setup_Sub_Business_ProcessType onboarding_Setup_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Applicant_Data", typeof(Create_Applicant_DataType), Order = 0), XmlElement("Applicant_Reference", typeof(ApplicantObjectType), Order = 0), XmlElement("Former_Worker_Reference", typeof(Former_WorkerObjectType), Order = 0)]
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
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Contract_Start_Date
		{
			get
			{
				return this.contract_Start_DateField;
			}
			set
			{
				this.contract_Start_DateField = value;
				this.RaisePropertyChanged("Contract_Start_Date");
			}
		}

		[XmlElement(Order = 4)]
		public Contract_Contingent_Worker_Event_DataType Contract_Contingent_Worker_Event_Data
		{
			get
			{
				return this.contract_Contingent_Worker_Event_DataField;
			}
			set
			{
				this.contract_Contingent_Worker_Event_DataField = value;
				this.RaisePropertyChanged("Contract_Contingent_Worker_Event_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Update_ID_Information_Sub_Business_ProcessType Update_ID_Information_Sub_Process
		{
			get
			{
				return this.update_ID_Information_Sub_ProcessField;
			}
			set
			{
				this.update_ID_Information_Sub_ProcessField = value;
				this.RaisePropertyChanged("Update_ID_Information_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
		public Edit_Government_IDs_Sub_Business_ProcessType Edit_Government_IDs_Sub_Process
		{
			get
			{
				return this.edit_Government_IDs_Sub_ProcessField;
			}
			set
			{
				this.edit_Government_IDs_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Government_IDs_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Edit_Passports_and_Visas_Sub_Business_ProcessType Edit_Passports_and_Visas_Sub_Process
		{
			get
			{
				return this.edit_Passports_and_Visas_Sub_ProcessField;
			}
			set
			{
				this.edit_Passports_and_Visas_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Passports_and_Visas_Sub_Process");
			}
		}

		[XmlElement(Order = 8)]
		public Edit_Licenses_Sub_Business_ProcessType Edit_License_Sub_Process
		{
			get
			{
				return this.edit_License_Sub_ProcessField;
			}
			set
			{
				this.edit_License_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_License_Sub_Process");
			}
		}

		[XmlElement(Order = 9)]
		public Edit_Custom_IDs_Sub_Business_ProcessType Edit_Custom_IDs_Sub_Process
		{
			get
			{
				return this.edit_Custom_IDs_Sub_ProcessField;
			}
			set
			{
				this.edit_Custom_IDs_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Custom_IDs_Sub_Process");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public Create_Workday_Account_Sub_Business_ProcessType Create_Workday_Account_Sub_Process
		{
			get
			{
				return this.create_Workday_Account_Sub_ProcessField;
			}
			set
			{
				this.create_Workday_Account_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Workday_Account_Sub_Process");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public Change_Personal_Information_Sub_Business_ProcessType Change_Personal_Information_Sub_Process
		{
			get
			{
				return this.change_Personal_Information_Sub_ProcessField;
			}
			set
			{
				this.change_Personal_Information_Sub_ProcessField = value;
				this.RaisePropertyChanged("Change_Personal_Information_Sub_Process");
			}
		}

		[XmlElement(Order = 14)]
		public Edit_Service_Dates_Sub_Business_ProcessType Edit_Service_Dates_Sub_Process
		{
			get
			{
				return this.edit_Service_Dates_Sub_ProcessField;
			}
			set
			{
				this.edit_Service_Dates_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Service_Dates_Sub_Process");
			}
		}

		[XmlElement(Order = 15)]
		public Remove_Retiree_Status_Sub_Business_ProcessType Remove_Retiree_Status_Sub_Process
		{
			get
			{
				return this.remove_Retiree_Status_Sub_ProcessField;
			}
			set
			{
				this.remove_Retiree_Status_Sub_ProcessField = value;
				this.RaisePropertyChanged("Remove_Retiree_Status_Sub_Process");
			}
		}

		[XmlElement(Order = 16)]
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
