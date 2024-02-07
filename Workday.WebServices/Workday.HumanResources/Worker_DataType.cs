using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_DataType : INotifyPropertyChanged
	{
		private string worker_IDField;

		private string user_IDField;

		private string universal_IDField;

		private Personal_Information_DataType personal_DataField;

		private Worker_Employment_Information_DataType employment_DataField;

		private Worker_Compensation_DataType compensation_DataField;

		private Worker_Organization_Membership_DataType[] organization_DataField;

		private Worker_Role_DataType role_DataField;

		private Worker_Management_Chain_DataType management_Chain_DataField;

		private Worker_Benefit_Enrollment_DataType benefit_Enrollment_DataField;

		private Worker_Benefit_Eligibility_DataType benefit_Eligibility_DataField;

		private Worker_Related_Persons_DataType related_Person_DataField;

		private Person_Qualification_DataType qualification_DataField;

		private Employee_Review_DataType employee_Review_DataField;

		private Employee_Image_DataType photo_DataField;

		private Worker_Document_WWSType[] worker_Document_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private Transaction_Log_EntryType[] transaction_Log_Entry_DataField;

		private Corrected_Or_Rescinded_Transaction_DataType[] transaction_Log_Corrected_And_Rescinded_DataField;

		private Succession_Plan_Candidate_DataType[] succession_Profile_DataField;

		private Talent_Assessment_DataType talent_Assessment_DataField;

		private Worker_GoalType[] worker_Goal_DataField;

		private Worker_Development_ItemType[] development_Item_DataField;

		private SkillType[] skill_DataField;

		private Employee_Contract_DataType[] employee_Contracts_DataField;

		private Employee_Contract_DataType[] extended_Employee_Contracts_DataField;

		private Feedback_ReceivedType[] feedback_Received_DataField;

		private System_User_for_Worker_DataType user_Account_DataField;

		private Worker_Career_DataType career_DataField;

		private Provisioning_Group_Assignment_for_Person_DataType[] account_Provisioning_DataField;

		private Background_Check_Overall_Status_DataType[] background_Check_DataField;

		private Contingent_Worker_Tax_Authority_Form_Information_DataType[] contingent_Worker_Tax_Authority_Form_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Worker_ID
		{
			get
			{
				return this.worker_IDField;
			}
			set
			{
				this.worker_IDField = value;
				this.RaisePropertyChanged("Worker_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
			}
		}

		[XmlElement(Order = 3)]
		public Personal_Information_DataType Personal_Data
		{
			get
			{
				return this.personal_DataField;
			}
			set
			{
				this.personal_DataField = value;
				this.RaisePropertyChanged("Personal_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Worker_Employment_Information_DataType Employment_Data
		{
			get
			{
				return this.employment_DataField;
			}
			set
			{
				this.employment_DataField = value;
				this.RaisePropertyChanged("Employment_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Worker_Compensation_DataType Compensation_Data
		{
			get
			{
				return this.compensation_DataField;
			}
			set
			{
				this.compensation_DataField = value;
				this.RaisePropertyChanged("Compensation_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Worker_Organization_Data", IsNullable = false)]
		public Worker_Organization_Membership_DataType[] Organization_Data
		{
			get
			{
				return this.organization_DataField;
			}
			set
			{
				this.organization_DataField = value;
				this.RaisePropertyChanged("Organization_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Worker_Role_DataType Role_Data
		{
			get
			{
				return this.role_DataField;
			}
			set
			{
				this.role_DataField = value;
				this.RaisePropertyChanged("Role_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Worker_Management_Chain_DataType Management_Chain_Data
		{
			get
			{
				return this.management_Chain_DataField;
			}
			set
			{
				this.management_Chain_DataField = value;
				this.RaisePropertyChanged("Management_Chain_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Worker_Benefit_Enrollment_DataType Benefit_Enrollment_Data
		{
			get
			{
				return this.benefit_Enrollment_DataField;
			}
			set
			{
				this.benefit_Enrollment_DataField = value;
				this.RaisePropertyChanged("Benefit_Enrollment_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Worker_Benefit_Eligibility_DataType Benefit_Eligibility_Data
		{
			get
			{
				return this.benefit_Eligibility_DataField;
			}
			set
			{
				this.benefit_Eligibility_DataField = value;
				this.RaisePropertyChanged("Benefit_Eligibility_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Worker_Related_Persons_DataType Related_Person_Data
		{
			get
			{
				return this.related_Person_DataField;
			}
			set
			{
				this.related_Person_DataField = value;
				this.RaisePropertyChanged("Related_Person_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Person_Qualification_DataType Qualification_Data
		{
			get
			{
				return this.qualification_DataField;
			}
			set
			{
				this.qualification_DataField = value;
				this.RaisePropertyChanged("Qualification_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Employee_Review_DataType Employee_Review_Data
		{
			get
			{
				return this.employee_Review_DataField;
			}
			set
			{
				this.employee_Review_DataField = value;
				this.RaisePropertyChanged("Employee_Review_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Employee_Image_DataType Photo_Data
		{
			get
			{
				return this.photo_DataField;
			}
			set
			{
				this.photo_DataField = value;
				this.RaisePropertyChanged("Photo_Data");
			}
		}

		[XmlArray(Order = 15), XmlArrayItem("Worker_Document", IsNullable = false)]
		public Worker_Document_WWSType[] Worker_Document_Data
		{
			get
			{
				return this.worker_Document_DataField;
			}
			set
			{
				this.worker_Document_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 16)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
			}
		}

		[XmlArray(Order = 17), XmlArrayItem("Transaction_Log_Entry", IsNullable = false)]
		public Transaction_Log_EntryType[] Transaction_Log_Entry_Data
		{
			get
			{
				return this.transaction_Log_Entry_DataField;
			}
			set
			{
				this.transaction_Log_Entry_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Entry_Data");
			}
		}

		[XmlArray(Order = 18), XmlArrayItem("Corrected_Or_Rescinded_Transaction_Log_Data", typeof(Corrected_Or_Rescinded_Transaction_DataType), IsNullable = false)]
		public Corrected_Or_Rescinded_Transaction_DataType[] Transaction_Log_Corrected_And_Rescinded_Data
		{
			get
			{
				return this.transaction_Log_Corrected_And_Rescinded_DataField;
			}
			set
			{
				this.transaction_Log_Corrected_And_Rescinded_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Corrected_And_Rescinded_Data");
			}
		}

		[XmlArray(Order = 19), XmlArrayItem("Candidate_Data", IsNullable = false)]
		public Succession_Plan_Candidate_DataType[] Succession_Profile_Data
		{
			get
			{
				return this.succession_Profile_DataField;
			}
			set
			{
				this.succession_Profile_DataField = value;
				this.RaisePropertyChanged("Succession_Profile_Data");
			}
		}

		[XmlElement(Order = 20)]
		public Talent_Assessment_DataType Talent_Assessment_Data
		{
			get
			{
				return this.talent_Assessment_DataField;
			}
			set
			{
				this.talent_Assessment_DataField = value;
				this.RaisePropertyChanged("Talent_Assessment_Data");
			}
		}

		[XmlArray(Order = 21), XmlArrayItem("Goal", IsNullable = false)]
		public Worker_GoalType[] Worker_Goal_Data
		{
			get
			{
				return this.worker_Goal_DataField;
			}
			set
			{
				this.worker_Goal_DataField = value;
				this.RaisePropertyChanged("Worker_Goal_Data");
			}
		}

		[XmlArray(Order = 22), XmlArrayItem("Worker_Development_Item", IsNullable = false)]
		public Worker_Development_ItemType[] Development_Item_Data
		{
			get
			{
				return this.development_Item_DataField;
			}
			set
			{
				this.development_Item_DataField = value;
				this.RaisePropertyChanged("Development_Item_Data");
			}
		}

		[XmlArray(Order = 23), XmlArrayItem("Worker_Skill_Item", IsNullable = false)]
		public SkillType[] Skill_Data
		{
			get
			{
				return this.skill_DataField;
			}
			set
			{
				this.skill_DataField = value;
				this.RaisePropertyChanged("Skill_Data");
			}
		}

		[XmlArray(Order = 24), XmlArrayItem("Employee_Contract_Data", IsNullable = false)]
		public Employee_Contract_DataType[] Employee_Contracts_Data
		{
			get
			{
				return this.employee_Contracts_DataField;
			}
			set
			{
				this.employee_Contracts_DataField = value;
				this.RaisePropertyChanged("Employee_Contracts_Data");
			}
		}

		[XmlArray(Order = 25), XmlArrayItem("Extended_Employee_Contract_Data", IsNullable = false), XmlArrayItem("Employee_Contract_Data", IsNullable = false, NestingLevel = 1)]
		public Employee_Contract_DataType[] Extended_Employee_Contracts_Data
		{
			get
			{
				return this.extended_Employee_Contracts_DataField;
			}
			set
			{
				this.extended_Employee_Contracts_DataField = value;
				this.RaisePropertyChanged("Extended_Employee_Contracts_Data");
			}
		}

		[XmlArray(Order = 26), XmlArrayItem("Feedback_Received", IsNullable = false)]
		public Feedback_ReceivedType[] Feedback_Received_Data
		{
			get
			{
				return this.feedback_Received_DataField;
			}
			set
			{
				this.feedback_Received_DataField = value;
				this.RaisePropertyChanged("Feedback_Received_Data");
			}
		}

		[XmlElement(Order = 27)]
		public System_User_for_Worker_DataType User_Account_Data
		{
			get
			{
				return this.user_Account_DataField;
			}
			set
			{
				this.user_Account_DataField = value;
				this.RaisePropertyChanged("User_Account_Data");
			}
		}

		[XmlElement(Order = 28)]
		public Worker_Career_DataType Career_Data
		{
			get
			{
				return this.career_DataField;
			}
			set
			{
				this.career_DataField = value;
				this.RaisePropertyChanged("Career_Data");
			}
		}

		[XmlArray(Order = 29), XmlArrayItem("Provisioning_Group_Assignment_Data", IsNullable = false)]
		public Provisioning_Group_Assignment_for_Person_DataType[] Account_Provisioning_Data
		{
			get
			{
				return this.account_Provisioning_DataField;
			}
			set
			{
				this.account_Provisioning_DataField = value;
				this.RaisePropertyChanged("Account_Provisioning_Data");
			}
		}

		[XmlElement("Background_Check_Data", Order = 30)]
		public Background_Check_Overall_Status_DataType[] Background_Check_Data
		{
			get
			{
				return this.background_Check_DataField;
			}
			set
			{
				this.background_Check_DataField = value;
				this.RaisePropertyChanged("Background_Check_Data");
			}
		}

		[XmlElement("Contingent_Worker_Tax_Authority_Form_Type_Data", Order = 31)]
		public Contingent_Worker_Tax_Authority_Form_Information_DataType[] Contingent_Worker_Tax_Authority_Form_Type_Data
		{
			get
			{
				return this.contingent_Worker_Tax_Authority_Form_Type_DataField;
			}
			set
			{
				this.contingent_Worker_Tax_Authority_Form_Type_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Tax_Authority_Form_Type_Data");
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
