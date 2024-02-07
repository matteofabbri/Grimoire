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
	public class Award_Proposal_DataType : INotifyPropertyChanged
	{
		private string award_Proposal_Reference_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private string award_Proposal_NameField;

		private string award_Proposal_DescriptionField;

		private Award_Proposal_Lifecycle_StatusObjectType award_Proposal_Lifecycle_Status_ReferenceField;

		private Award_Proposal_Submission_TypeObjectType award_Proposal_Submission_Type_ReferenceField;

		private DateTime award_Proposal_Signed_DateField;

		private bool award_Proposal_Signed_DateFieldSpecified;

		private string award_Proposal_CFDA_NumberField;

		private string award_Proposal_CFDA_DescriptionField;

		private Sponsor_Award_TypeObjectType award_Proposal_Type_ReferenceField;

		private Award_Purpose_CodeObjectType[] award_Purpose_Code_ReferenceField;

		private string award_Proposal_Institutional_IDField;

		private Award_ProposalObjectType[] related_Award_Proposal_ReferenceField;

		private bool award_Proposal_is_SubProposalField;

		private bool award_Proposal_is_SubProposalFieldSpecified;

		private SponsorObjectType flow_Through_Sponsor_ReferenceField;

		private SponsorObjectType bill_To_Sponsor_ReferenceField;

		private SponsorObjectType sponsor_ReferenceField;

		private Payment_TypeObjectType award_Proposal_Payment_Type_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal award_Proposal_Sponsor_Direct_CostField;

		private bool award_Proposal_Sponsor_Direct_CostFieldSpecified;

		private decimal award_Proposal_Sponsor_Facilities_and_AdministrationField;

		private bool award_Proposal_Sponsor_Facilities_and_AdministrationFieldSpecified;

		private decimal award_Proposal_Sponsor_TotalField;

		private bool award_Proposal_Sponsor_TotalFieldSpecified;

		private decimal award_Proposal_Cost_Share_TotalField;

		private bool award_Proposal_Cost_Share_TotalFieldSpecified;

		private bool award_Proposal_Cost_Share_Required_by_SponsorField;

		private bool award_Proposal_Cost_Share_Required_by_SponsorFieldSpecified;

		private Award_ScheduleObjectType award_Schedule_ReferenceField;

		private string award_Proposal_NotesField;

		private Award_Proposal_Line_DataType[] award_Proposal_Line_DataField;

		private Special_Condition_Proposal_DataType[] special_Condition_Proposal_DataField;

		private Award_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Proposal_Reference_ID
		{
			get
			{
				return this.award_Proposal_Reference_IDField;
			}
			set
			{
				this.award_Proposal_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Proposal_Reference_ID");
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

		[XmlElement(Order = 3)]
		public string Award_Proposal_Name
		{
			get
			{
				return this.award_Proposal_NameField;
			}
			set
			{
				this.award_Proposal_NameField = value;
				this.RaisePropertyChanged("Award_Proposal_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Award_Proposal_Description
		{
			get
			{
				return this.award_Proposal_DescriptionField;
			}
			set
			{
				this.award_Proposal_DescriptionField = value;
				this.RaisePropertyChanged("Award_Proposal_Description");
			}
		}

		[XmlElement(Order = 5)]
		public Award_Proposal_Lifecycle_StatusObjectType Award_Proposal_Lifecycle_Status_Reference
		{
			get
			{
				return this.award_Proposal_Lifecycle_Status_ReferenceField;
			}
			set
			{
				this.award_Proposal_Lifecycle_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Lifecycle_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Award_Proposal_Submission_TypeObjectType Award_Proposal_Submission_Type_Reference
		{
			get
			{
				return this.award_Proposal_Submission_Type_ReferenceField;
			}
			set
			{
				this.award_Proposal_Submission_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Submission_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Award_Proposal_Signed_Date
		{
			get
			{
				return this.award_Proposal_Signed_DateField;
			}
			set
			{
				this.award_Proposal_Signed_DateField = value;
				this.RaisePropertyChanged("Award_Proposal_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Signed_DateSpecified
		{
			get
			{
				return this.award_Proposal_Signed_DateFieldSpecified;
			}
			set
			{
				this.award_Proposal_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Award_Proposal_CFDA_Number
		{
			get
			{
				return this.award_Proposal_CFDA_NumberField;
			}
			set
			{
				this.award_Proposal_CFDA_NumberField = value;
				this.RaisePropertyChanged("Award_Proposal_CFDA_Number");
			}
		}

		[XmlElement(Order = 9)]
		public string Award_Proposal_CFDA_Description
		{
			get
			{
				return this.award_Proposal_CFDA_DescriptionField;
			}
			set
			{
				this.award_Proposal_CFDA_DescriptionField = value;
				this.RaisePropertyChanged("Award_Proposal_CFDA_Description");
			}
		}

		[XmlElement(Order = 10)]
		public Sponsor_Award_TypeObjectType Award_Proposal_Type_Reference
		{
			get
			{
				return this.award_Proposal_Type_ReferenceField;
			}
			set
			{
				this.award_Proposal_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Type_Reference");
			}
		}

		[XmlElement("Award_Purpose_Code_Reference", Order = 11)]
		public Award_Purpose_CodeObjectType[] Award_Purpose_Code_Reference
		{
			get
			{
				return this.award_Purpose_Code_ReferenceField;
			}
			set
			{
				this.award_Purpose_Code_ReferenceField = value;
				this.RaisePropertyChanged("Award_Purpose_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public string Award_Proposal_Institutional_ID
		{
			get
			{
				return this.award_Proposal_Institutional_IDField;
			}
			set
			{
				this.award_Proposal_Institutional_IDField = value;
				this.RaisePropertyChanged("Award_Proposal_Institutional_ID");
			}
		}

		[XmlElement("Related_Award_Proposal_Reference", Order = 13)]
		public Award_ProposalObjectType[] Related_Award_Proposal_Reference
		{
			get
			{
				return this.related_Award_Proposal_ReferenceField;
			}
			set
			{
				this.related_Award_Proposal_ReferenceField = value;
				this.RaisePropertyChanged("Related_Award_Proposal_Reference");
			}
		}

		[XmlElement("Award_Proposal_is_Sub-Proposal", Order = 14)]
		public bool Award_Proposal_is_SubProposal
		{
			get
			{
				return this.award_Proposal_is_SubProposalField;
			}
			set
			{
				this.award_Proposal_is_SubProposalField = value;
				this.RaisePropertyChanged("Award_Proposal_is_SubProposal");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_is_SubProposalSpecified
		{
			get
			{
				return this.award_Proposal_is_SubProposalFieldSpecified;
			}
			set
			{
				this.award_Proposal_is_SubProposalFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_is_SubProposalSpecified");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public Payment_TypeObjectType Award_Proposal_Payment_Type_Reference
		{
			get
			{
				return this.award_Proposal_Payment_Type_ReferenceField;
			}
			set
			{
				this.award_Proposal_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public decimal Award_Proposal_Sponsor_Direct_Cost
		{
			get
			{
				return this.award_Proposal_Sponsor_Direct_CostField;
			}
			set
			{
				this.award_Proposal_Sponsor_Direct_CostField = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_Direct_Cost");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Sponsor_Direct_CostSpecified
		{
			get
			{
				return this.award_Proposal_Sponsor_Direct_CostFieldSpecified;
			}
			set
			{
				this.award_Proposal_Sponsor_Direct_CostFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_Direct_CostSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Award_Proposal_Sponsor_Facilities_and_Administration
		{
			get
			{
				return this.award_Proposal_Sponsor_Facilities_and_AdministrationField;
			}
			set
			{
				this.award_Proposal_Sponsor_Facilities_and_AdministrationField = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_Facilities_and_Administration");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Sponsor_Facilities_and_AdministrationSpecified
		{
			get
			{
				return this.award_Proposal_Sponsor_Facilities_and_AdministrationFieldSpecified;
			}
			set
			{
				this.award_Proposal_Sponsor_Facilities_and_AdministrationFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_Facilities_and_AdministrationSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Award_Proposal_Sponsor_Total
		{
			get
			{
				return this.award_Proposal_Sponsor_TotalField;
			}
			set
			{
				this.award_Proposal_Sponsor_TotalField = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_Total");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Sponsor_TotalSpecified
		{
			get
			{
				return this.award_Proposal_Sponsor_TotalFieldSpecified;
			}
			set
			{
				this.award_Proposal_Sponsor_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Sponsor_TotalSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Award_Proposal_Cost_Share_Total
		{
			get
			{
				return this.award_Proposal_Cost_Share_TotalField;
			}
			set
			{
				this.award_Proposal_Cost_Share_TotalField = value;
				this.RaisePropertyChanged("Award_Proposal_Cost_Share_Total");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Cost_Share_TotalSpecified
		{
			get
			{
				return this.award_Proposal_Cost_Share_TotalFieldSpecified;
			}
			set
			{
				this.award_Proposal_Cost_Share_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Cost_Share_TotalSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Award_Proposal_Cost_Share_Required_by_Sponsor
		{
			get
			{
				return this.award_Proposal_Cost_Share_Required_by_SponsorField;
			}
			set
			{
				this.award_Proposal_Cost_Share_Required_by_SponsorField = value;
				this.RaisePropertyChanged("Award_Proposal_Cost_Share_Required_by_Sponsor");
			}
		}

		[XmlIgnore]
		public bool Award_Proposal_Cost_Share_Required_by_SponsorSpecified
		{
			get
			{
				return this.award_Proposal_Cost_Share_Required_by_SponsorFieldSpecified;
			}
			set
			{
				this.award_Proposal_Cost_Share_Required_by_SponsorFieldSpecified = value;
				this.RaisePropertyChanged("Award_Proposal_Cost_Share_Required_by_SponsorSpecified");
			}
		}

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
		public string Award_Proposal_Notes
		{
			get
			{
				return this.award_Proposal_NotesField;
			}
			set
			{
				this.award_Proposal_NotesField = value;
				this.RaisePropertyChanged("Award_Proposal_Notes");
			}
		}

		[XmlElement("Award_Proposal_Line_Data", Order = 27)]
		public Award_Proposal_Line_DataType[] Award_Proposal_Line_Data
		{
			get
			{
				return this.award_Proposal_Line_DataField;
			}
			set
			{
				this.award_Proposal_Line_DataField = value;
				this.RaisePropertyChanged("Award_Proposal_Line_Data");
			}
		}

		[XmlElement("Special_Condition_Proposal_Data", Order = 28)]
		public Special_Condition_Proposal_DataType[] Special_Condition_Proposal_Data
		{
			get
			{
				return this.special_Condition_Proposal_DataField;
			}
			set
			{
				this.special_Condition_Proposal_DataField = value;
				this.RaisePropertyChanged("Special_Condition_Proposal_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 29)]
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
