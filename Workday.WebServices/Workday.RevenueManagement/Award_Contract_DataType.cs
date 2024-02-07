using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Contract_DataType : INotifyPropertyChanged
	{
		private string award_Reference_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string award_NumberField;

		private CompanyObjectType company_ReferenceField;

		private string sponsor_Award_Reference_NumberField;

		private string award_NameField;

		private string award_DescriptionField;

		private DateTime award_Effective_DateField;

		private DateTime award_Signed_DateField;

		private bool award_Signed_DateFieldSpecified;

		private Sponsor_Award_TypeObjectType award_Type_ReferenceField;

		private Award_Purpose_CodeObjectType[] purpose_Code_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private string institutional_IDField;

		private Payroll_LimitObjectType award_Salary_Cap_Default_ReferenceField;

		private Spend_RestrictionObjectType[] spend_Restriction_Default_ReferenceField;

		private Award_ContractObjectType related_Award_ReferenceField;

		private Award_GroupObjectType[] award_Group_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] organizations_for_Award_ReferenceField;

		private WorkerObjectType award_Contract_Owner_ReferenceField;

		private Award_Lifecycle_StatusObjectType award_Lifecycle_Status_ReferenceField;

		private bool sub_AwardField;

		private bool sub_AwardFieldSpecified;

		private SponsorObjectType flow_Through_Sponsor_ReferenceField;

		private SponsorObjectType sponsor_ReferenceField;

		private SponsorObjectType bill_To_Sponsor_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Letter_Of_CreditObjectType letter_Of_Credit_ReferenceField;

		private string letter_of_Credit_Document_IDField;

		private bool award_Sequence_Billing_Active_ReferenceField;

		private bool award_Sequence_Billing_Active_ReferenceFieldSpecified;

		private string award_Billing_Sequence_Number_Format_Syntax_ReferenceField;

		private decimal current_Award_Billing_Sequence_Number_Used_ReferenceField;

		private bool current_Award_Billing_Sequence_Number_Used_ReferenceFieldSpecified;

		private Sequence_Generator_Rule_ConfigurationObjectType award_Billing_Sequence_Generator_Rule_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal sponsor_Direct_Cost_AmountField;

		private bool sponsor_Direct_Cost_AmountFieldSpecified;

		private decimal sponsor_Facilities_and_Administration_AmountField;

		private bool sponsor_Facilities_and_Administration_AmountFieldSpecified;

		private decimal cost_Share_Total_AmountField;

		private bool cost_Share_Total_AmountFieldSpecified;

		private decimal authorized_AmountField;

		private decimal billing_Limit_OverrideField;

		private bool billing_Limit_OverrideFieldSpecified;

		private bool cost_Share_Required_by_SponsorField;

		private bool cost_Share_Required_by_SponsorFieldSpecified;

		private decimal anticipated_Sponsor_Direct_Cost_AmountField;

		private bool anticipated_Sponsor_Direct_Cost_AmountFieldSpecified;

		private decimal anticipated_Facilities_and_Administration_AmountField;

		private bool anticipated_Facilities_and_Administration_AmountFieldSpecified;

		private Award_ScheduleObjectType award_Schedule_ReferenceField;

		private string federal_Award_ID_NumberField;

		private string cFDA_NumberField;

		private Catalog_of_Federal_Domestic_AssistanceObjectType cFDA_Number_ReferenceField;

		private string cFDA_DescriptionField;

		private NSF_CodeObjectType[] nSF_Code_ReferenceField;

		private string proposal_IDField;

		private string proposal_VersionField;

		private Award_ProposalObjectType original_Proposal_ReferenceField;

		private Award_ProposalObjectType[] related_Proposals_ReferenceField;

		private string award_NotesField;

		private string billing_NotesField;

		private Award_Contract_Line_DataType[] award_Line_DataField;

		private Special_Condition_DataType[] special_Condition_DataField;

		private Award_Personnel_DataType[] award_Personnel_DataField;

		private Award_Budget_DataType[] award_Budget_DataField;

		private Award_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Reference_ID
		{
			get
			{
				return this.award_Reference_IDField;
			}
			set
			{
				this.award_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Award_Number
		{
			get
			{
				return this.award_NumberField;
			}
			set
			{
				this.award_NumberField = value;
				this.RaisePropertyChanged("Award_Number");
			}
		}

		[XmlElement(Order = 4)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Sponsor_Award_Reference_Number
		{
			get
			{
				return this.sponsor_Award_Reference_NumberField;
			}
			set
			{
				this.sponsor_Award_Reference_NumberField = value;
				this.RaisePropertyChanged("Sponsor_Award_Reference_Number");
			}
		}

		[XmlElement(Order = 6)]
		public string Award_Name
		{
			get
			{
				return this.award_NameField;
			}
			set
			{
				this.award_NameField = value;
				this.RaisePropertyChanged("Award_Name");
			}
		}

		[XmlElement(Order = 7)]
		public string Award_Description
		{
			get
			{
				return this.award_DescriptionField;
			}
			set
			{
				this.award_DescriptionField = value;
				this.RaisePropertyChanged("Award_Description");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Award_Effective_Date
		{
			get
			{
				return this.award_Effective_DateField;
			}
			set
			{
				this.award_Effective_DateField = value;
				this.RaisePropertyChanged("Award_Effective_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Award_Signed_Date
		{
			get
			{
				return this.award_Signed_DateField;
			}
			set
			{
				this.award_Signed_DateField = value;
				this.RaisePropertyChanged("Award_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Signed_DateSpecified
		{
			get
			{
				return this.award_Signed_DateFieldSpecified;
			}
			set
			{
				this.award_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Sponsor_Award_TypeObjectType Award_Type_Reference
		{
			get
			{
				return this.award_Type_ReferenceField;
			}
			set
			{
				this.award_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Type_Reference");
			}
		}

		[XmlElement("Purpose_Code_Reference", Order = 11)]
		public Award_Purpose_CodeObjectType[] Purpose_Code_Reference
		{
			get
			{
				return this.purpose_Code_ReferenceField;
			}
			set
			{
				this.purpose_Code_ReferenceField = value;
				this.RaisePropertyChanged("Purpose_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Institutional_ID
		{
			get
			{
				return this.institutional_IDField;
			}
			set
			{
				this.institutional_IDField = value;
				this.RaisePropertyChanged("Institutional_ID");
			}
		}

		[XmlElement(Order = 14)]
		public Payroll_LimitObjectType Award_Salary_Cap_Default_Reference
		{
			get
			{
				return this.award_Salary_Cap_Default_ReferenceField;
			}
			set
			{
				this.award_Salary_Cap_Default_ReferenceField = value;
				this.RaisePropertyChanged("Award_Salary_Cap_Default_Reference");
			}
		}

		[XmlElement("Spend_Restriction_Default_Reference", Order = 15)]
		public Spend_RestrictionObjectType[] Spend_Restriction_Default_Reference
		{
			get
			{
				return this.spend_Restriction_Default_ReferenceField;
			}
			set
			{
				this.spend_Restriction_Default_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Default_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Award_ContractObjectType Related_Award_Reference
		{
			get
			{
				return this.related_Award_ReferenceField;
			}
			set
			{
				this.related_Award_ReferenceField = value;
				this.RaisePropertyChanged("Related_Award_Reference");
			}
		}

		[XmlElement("Award_Group_Reference", Order = 17)]
		public Award_GroupObjectType[] Award_Group_Reference
		{
			get
			{
				return this.award_Group_ReferenceField;
			}
			set
			{
				this.award_Group_ReferenceField = value;
				this.RaisePropertyChanged("Award_Group_Reference");
			}
		}

		[XmlElement("Organizations_for_Award_Reference", Order = 18)]
		public Audited_Accounting_WorktagObjectType[] Organizations_for_Award_Reference
		{
			get
			{
				return this.organizations_for_Award_ReferenceField;
			}
			set
			{
				this.organizations_for_Award_ReferenceField = value;
				this.RaisePropertyChanged("Organizations_for_Award_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public WorkerObjectType Award_Contract_Owner_Reference
		{
			get
			{
				return this.award_Contract_Owner_ReferenceField;
			}
			set
			{
				this.award_Contract_Owner_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Owner_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Award_Lifecycle_StatusObjectType Award_Lifecycle_Status_Reference
		{
			get
			{
				return this.award_Lifecycle_Status_ReferenceField;
			}
			set
			{
				this.award_Lifecycle_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public bool Sub_Award
		{
			get
			{
				return this.sub_AwardField;
			}
			set
			{
				this.sub_AwardField = value;
				this.RaisePropertyChanged("Sub_Award");
			}
		}

		[XmlIgnore]
		public bool Sub_AwardSpecified
		{
			get
			{
				return this.sub_AwardFieldSpecified;
			}
			set
			{
				this.sub_AwardFieldSpecified = value;
				this.RaisePropertyChanged("Sub_AwardSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public SponsorObjectType Flow_Through_Sponsor_Reference
		{
			get
			{
				return this.flow_Through_Sponsor_ReferenceField;
			}
			set
			{
				this.flow_Through_Sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Flow_Through_Sponsor_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public SponsorObjectType Sponsor_Reference
		{
			get
			{
				return this.sponsor_ReferenceField;
			}
			set
			{
				this.sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public SponsorObjectType Bill_To_Sponsor_Reference
		{
			get
			{
				return this.bill_To_Sponsor_ReferenceField;
			}
			set
			{
				this.bill_To_Sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Sponsor_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Letter_Of_CreditObjectType Letter_Of_Credit_Reference
		{
			get
			{
				return this.letter_Of_Credit_ReferenceField;
			}
			set
			{
				this.letter_Of_Credit_ReferenceField = value;
				this.RaisePropertyChanged("Letter_Of_Credit_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string Letter_of_Credit_Document_ID
		{
			get
			{
				return this.letter_of_Credit_Document_IDField;
			}
			set
			{
				this.letter_of_Credit_Document_IDField = value;
				this.RaisePropertyChanged("Letter_of_Credit_Document_ID");
			}
		}

		[XmlElement(Order = 28)]
		public bool Award_Sequence_Billing_Active_Reference
		{
			get
			{
				return this.award_Sequence_Billing_Active_ReferenceField;
			}
			set
			{
				this.award_Sequence_Billing_Active_ReferenceField = value;
				this.RaisePropertyChanged("Award_Sequence_Billing_Active_Reference");
			}
		}

		[XmlIgnore]
		public bool Award_Sequence_Billing_Active_ReferenceSpecified
		{
			get
			{
				return this.award_Sequence_Billing_Active_ReferenceFieldSpecified;
			}
			set
			{
				this.award_Sequence_Billing_Active_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Award_Sequence_Billing_Active_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public string Award_Billing_Sequence_Number_Format_Syntax_Reference
		{
			get
			{
				return this.award_Billing_Sequence_Number_Format_Syntax_ReferenceField;
			}
			set
			{
				this.award_Billing_Sequence_Number_Format_Syntax_ReferenceField = value;
				this.RaisePropertyChanged("Award_Billing_Sequence_Number_Format_Syntax_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public decimal Current_Award_Billing_Sequence_Number_Used_Reference
		{
			get
			{
				return this.current_Award_Billing_Sequence_Number_Used_ReferenceField;
			}
			set
			{
				this.current_Award_Billing_Sequence_Number_Used_ReferenceField = value;
				this.RaisePropertyChanged("Current_Award_Billing_Sequence_Number_Used_Reference");
			}
		}

		[XmlIgnore]
		public bool Current_Award_Billing_Sequence_Number_Used_ReferenceSpecified
		{
			get
			{
				return this.current_Award_Billing_Sequence_Number_Used_ReferenceFieldSpecified;
			}
			set
			{
				this.current_Award_Billing_Sequence_Number_Used_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Current_Award_Billing_Sequence_Number_Used_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public Sequence_Generator_Rule_ConfigurationObjectType Award_Billing_Sequence_Generator_Rule_Reference
		{
			get
			{
				return this.award_Billing_Sequence_Generator_Rule_ReferenceField;
			}
			set
			{
				this.award_Billing_Sequence_Generator_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Award_Billing_Sequence_Generator_Rule_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public decimal Sponsor_Direct_Cost_Amount
		{
			get
			{
				return this.sponsor_Direct_Cost_AmountField;
			}
			set
			{
				this.sponsor_Direct_Cost_AmountField = value;
				this.RaisePropertyChanged("Sponsor_Direct_Cost_Amount");
			}
		}

		[XmlIgnore]
		public bool Sponsor_Direct_Cost_AmountSpecified
		{
			get
			{
				return this.sponsor_Direct_Cost_AmountFieldSpecified;
			}
			set
			{
				this.sponsor_Direct_Cost_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Sponsor_Direct_Cost_AmountSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public decimal Sponsor_Facilities_and_Administration_Amount
		{
			get
			{
				return this.sponsor_Facilities_and_Administration_AmountField;
			}
			set
			{
				this.sponsor_Facilities_and_Administration_AmountField = value;
				this.RaisePropertyChanged("Sponsor_Facilities_and_Administration_Amount");
			}
		}

		[XmlIgnore]
		public bool Sponsor_Facilities_and_Administration_AmountSpecified
		{
			get
			{
				return this.sponsor_Facilities_and_Administration_AmountFieldSpecified;
			}
			set
			{
				this.sponsor_Facilities_and_Administration_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Sponsor_Facilities_and_Administration_AmountSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public decimal Cost_Share_Total_Amount
		{
			get
			{
				return this.cost_Share_Total_AmountField;
			}
			set
			{
				this.cost_Share_Total_AmountField = value;
				this.RaisePropertyChanged("Cost_Share_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Cost_Share_Total_AmountSpecified
		{
			get
			{
				return this.cost_Share_Total_AmountFieldSpecified;
			}
			set
			{
				this.cost_Share_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Cost_Share_Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public decimal Authorized_Amount
		{
			get
			{
				return this.authorized_AmountField;
			}
			set
			{
				this.authorized_AmountField = value;
				this.RaisePropertyChanged("Authorized_Amount");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Billing_Limit_Override
		{
			get
			{
				return this.billing_Limit_OverrideField;
			}
			set
			{
				this.billing_Limit_OverrideField = value;
				this.RaisePropertyChanged("Billing_Limit_Override");
			}
		}

		[XmlIgnore]
		public bool Billing_Limit_OverrideSpecified
		{
			get
			{
				return this.billing_Limit_OverrideFieldSpecified;
			}
			set
			{
				this.billing_Limit_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Billing_Limit_OverrideSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool Cost_Share_Required_by_Sponsor
		{
			get
			{
				return this.cost_Share_Required_by_SponsorField;
			}
			set
			{
				this.cost_Share_Required_by_SponsorField = value;
				this.RaisePropertyChanged("Cost_Share_Required_by_Sponsor");
			}
		}

		[XmlIgnore]
		public bool Cost_Share_Required_by_SponsorSpecified
		{
			get
			{
				return this.cost_Share_Required_by_SponsorFieldSpecified;
			}
			set
			{
				this.cost_Share_Required_by_SponsorFieldSpecified = value;
				this.RaisePropertyChanged("Cost_Share_Required_by_SponsorSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public decimal Anticipated_Sponsor_Direct_Cost_Amount
		{
			get
			{
				return this.anticipated_Sponsor_Direct_Cost_AmountField;
			}
			set
			{
				this.anticipated_Sponsor_Direct_Cost_AmountField = value;
				this.RaisePropertyChanged("Anticipated_Sponsor_Direct_Cost_Amount");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Sponsor_Direct_Cost_AmountSpecified
		{
			get
			{
				return this.anticipated_Sponsor_Direct_Cost_AmountFieldSpecified;
			}
			set
			{
				this.anticipated_Sponsor_Direct_Cost_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Sponsor_Direct_Cost_AmountSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public decimal Anticipated_Facilities_and_Administration_Amount
		{
			get
			{
				return this.anticipated_Facilities_and_Administration_AmountField;
			}
			set
			{
				this.anticipated_Facilities_and_Administration_AmountField = value;
				this.RaisePropertyChanged("Anticipated_Facilities_and_Administration_Amount");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Facilities_and_Administration_AmountSpecified
		{
			get
			{
				return this.anticipated_Facilities_and_Administration_AmountFieldSpecified;
			}
			set
			{
				this.anticipated_Facilities_and_Administration_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Facilities_and_Administration_AmountSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public Award_ScheduleObjectType Award_Schedule_Reference
		{
			get
			{
				return this.award_Schedule_ReferenceField;
			}
			set
			{
				this.award_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Award_Schedule_Reference");
			}
		}

		[XmlElement(Order = 42)]
		public string Federal_Award_ID_Number
		{
			get
			{
				return this.federal_Award_ID_NumberField;
			}
			set
			{
				this.federal_Award_ID_NumberField = value;
				this.RaisePropertyChanged("Federal_Award_ID_Number");
			}
		}

		[XmlElement(Order = 43)]
		public string CFDA_Number
		{
			get
			{
				return this.cFDA_NumberField;
			}
			set
			{
				this.cFDA_NumberField = value;
				this.RaisePropertyChanged("CFDA_Number");
			}
		}

		[XmlElement(Order = 44)]
		public Catalog_of_Federal_Domestic_AssistanceObjectType CFDA_Number_Reference
		{
			get
			{
				return this.cFDA_Number_ReferenceField;
			}
			set
			{
				this.cFDA_Number_ReferenceField = value;
				this.RaisePropertyChanged("CFDA_Number_Reference");
			}
		}

		[XmlElement(Order = 45)]
		public string CFDA_Description
		{
			get
			{
				return this.cFDA_DescriptionField;
			}
			set
			{
				this.cFDA_DescriptionField = value;
				this.RaisePropertyChanged("CFDA_Description");
			}
		}

		[XmlElement("NSF_Code_Reference", Order = 46)]
		public NSF_CodeObjectType[] NSF_Code_Reference
		{
			get
			{
				return this.nSF_Code_ReferenceField;
			}
			set
			{
				this.nSF_Code_ReferenceField = value;
				this.RaisePropertyChanged("NSF_Code_Reference");
			}
		}

		[XmlElement(Order = 47)]
		public string Proposal_ID
		{
			get
			{
				return this.proposal_IDField;
			}
			set
			{
				this.proposal_IDField = value;
				this.RaisePropertyChanged("Proposal_ID");
			}
		}

		[XmlElement(Order = 48)]
		public string Proposal_Version
		{
			get
			{
				return this.proposal_VersionField;
			}
			set
			{
				this.proposal_VersionField = value;
				this.RaisePropertyChanged("Proposal_Version");
			}
		}

		[XmlElement(Order = 49)]
		public Award_ProposalObjectType Original_Proposal_Reference
		{
			get
			{
				return this.original_Proposal_ReferenceField;
			}
			set
			{
				this.original_Proposal_ReferenceField = value;
				this.RaisePropertyChanged("Original_Proposal_Reference");
			}
		}

		[XmlElement("Related_Proposals_Reference", Order = 50)]
		public Award_ProposalObjectType[] Related_Proposals_Reference
		{
			get
			{
				return this.related_Proposals_ReferenceField;
			}
			set
			{
				this.related_Proposals_ReferenceField = value;
				this.RaisePropertyChanged("Related_Proposals_Reference");
			}
		}

		[XmlElement(Order = 51)]
		public string Award_Notes
		{
			get
			{
				return this.award_NotesField;
			}
			set
			{
				this.award_NotesField = value;
				this.RaisePropertyChanged("Award_Notes");
			}
		}

		[XmlElement(Order = 52)]
		public string Billing_Notes
		{
			get
			{
				return this.billing_NotesField;
			}
			set
			{
				this.billing_NotesField = value;
				this.RaisePropertyChanged("Billing_Notes");
			}
		}

		[XmlElement("Award_Line_Data", Order = 53)]
		public Award_Contract_Line_DataType[] Award_Line_Data
		{
			get
			{
				return this.award_Line_DataField;
			}
			set
			{
				this.award_Line_DataField = value;
				this.RaisePropertyChanged("Award_Line_Data");
			}
		}

		[XmlElement("Special_Condition_Data", Order = 54)]
		public Special_Condition_DataType[] Special_Condition_Data
		{
			get
			{
				return this.special_Condition_DataField;
			}
			set
			{
				this.special_Condition_DataField = value;
				this.RaisePropertyChanged("Special_Condition_Data");
			}
		}

		[XmlElement("Award_Personnel_Data", Order = 55)]
		public Award_Personnel_DataType[] Award_Personnel_Data
		{
			get
			{
				return this.award_Personnel_DataField;
			}
			set
			{
				this.award_Personnel_DataField = value;
				this.RaisePropertyChanged("Award_Personnel_Data");
			}
		}

		[XmlElement("Award_Budget_Data", Order = 56)]
		public Award_Budget_DataType[] Award_Budget_Data
		{
			get
			{
				return this.award_Budget_DataField;
			}
			set
			{
				this.award_Budget_DataField = value;
				this.RaisePropertyChanged("Award_Budget_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 57)]
		public Award_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
