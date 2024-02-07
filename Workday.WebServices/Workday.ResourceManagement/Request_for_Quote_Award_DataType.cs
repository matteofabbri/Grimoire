using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_for_Quote_Award_DataType : INotifyPropertyChanged
	{
		private string request_for_Quote_Award_IDField;

		private string rFQ_Award_NumberField;

		private Request_for_Quote_Award_TypeObjectType rFQ_Award_Type_ReferenceField;

		private Document_StatusObjectType rFQ_Award_Status_ReferenceField;

		private DateTime approved_On_DateField;

		private bool approved_On_DateFieldSpecified;

		private Business_DocumentObjectType awarded_Business_Document_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Request_for_QuoteObjectType request_for_Quote_ReferenceField;

		private Request_for_Quote_ResponseObjectType rFQ_Response_ReferenceField;

		private Abstract_Request_for_Quote_ParticipantObjectType supplier_ReferenceField;

		private WorkerObjectType sourcing_Buyer_ReferenceField;

		private DateTime award_DateField;

		private bool award_DateFieldSpecified;

		private Procurement_Award_ReasonObjectType request_for_Quote_Award_Reason_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string memoField;

		private bool autosubmit_Award_Outcome_for_ApprovalField;

		private bool autosubmit_Award_Outcome_for_ApprovalFieldSpecified;

		private RFQ_Award_PO_Defaults_DataType[] rFQ_Award_PO_Defaults_DataField;

		private RFQ_Award_Contract_Defaults_DataType[] rFQ_Award_Contract_Defaults_DataField;

		private Request_for_Quote_Award_Line_DataType[] request_for_Quote_Award_Line_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Request_for_Quote_Award_ID
		{
			get
			{
				return this.request_for_Quote_Award_IDField;
			}
			set
			{
				this.request_for_Quote_Award_IDField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string RFQ_Award_Number
		{
			get
			{
				return this.rFQ_Award_NumberField;
			}
			set
			{
				this.rFQ_Award_NumberField = value;
				this.RaisePropertyChanged("RFQ_Award_Number");
			}
		}

		[XmlElement(Order = 2)]
		public Request_for_Quote_Award_TypeObjectType RFQ_Award_Type_Reference
		{
			get
			{
				return this.rFQ_Award_Type_ReferenceField;
			}
			set
			{
				this.rFQ_Award_Type_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Award_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType RFQ_Award_Status_Reference
		{
			get
			{
				return this.rFQ_Award_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Award_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Award_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Approved_On_Date
		{
			get
			{
				return this.approved_On_DateField;
			}
			set
			{
				this.approved_On_DateField = value;
				this.RaisePropertyChanged("Approved_On_Date");
			}
		}

		[XmlIgnore]
		public bool Approved_On_DateSpecified
		{
			get
			{
				return this.approved_On_DateFieldSpecified;
			}
			set
			{
				this.approved_On_DateFieldSpecified = value;
				this.RaisePropertyChanged("Approved_On_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Business_DocumentObjectType Awarded_Business_Document_Reference
		{
			get
			{
				return this.awarded_Business_Document_ReferenceField;
			}
			set
			{
				this.awarded_Business_Document_ReferenceField = value;
				this.RaisePropertyChanged("Awarded_Business_Document_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Request_for_QuoteObjectType Request_for_Quote_Reference
		{
			get
			{
				return this.request_for_Quote_ReferenceField;
			}
			set
			{
				this.request_for_Quote_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Request_for_Quote_ResponseObjectType RFQ_Response_Reference
		{
			get
			{
				return this.rFQ_Response_ReferenceField;
			}
			set
			{
				this.rFQ_Response_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Response_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Abstract_Request_for_Quote_ParticipantObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public WorkerObjectType Sourcing_Buyer_Reference
		{
			get
			{
				return this.sourcing_Buyer_ReferenceField;
			}
			set
			{
				this.sourcing_Buyer_ReferenceField = value;
				this.RaisePropertyChanged("Sourcing_Buyer_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Award_Date
		{
			get
			{
				return this.award_DateField;
			}
			set
			{
				this.award_DateField = value;
				this.RaisePropertyChanged("Award_Date");
			}
		}

		[XmlIgnore]
		public bool Award_DateSpecified
		{
			get
			{
				return this.award_DateFieldSpecified;
			}
			set
			{
				this.award_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public Procurement_Award_ReasonObjectType Request_for_Quote_Award_Reason_Reference
		{
			get
			{
				return this.request_for_Quote_Award_Reason_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Award_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Reason_Reference");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Auto-submit_Award_Outcome_for_Approval", Order = 15)]
		public bool Autosubmit_Award_Outcome_for_Approval
		{
			get
			{
				return this.autosubmit_Award_Outcome_for_ApprovalField;
			}
			set
			{
				this.autosubmit_Award_Outcome_for_ApprovalField = value;
				this.RaisePropertyChanged("Autosubmit_Award_Outcome_for_Approval");
			}
		}

		[XmlIgnore]
		public bool Autosubmit_Award_Outcome_for_ApprovalSpecified
		{
			get
			{
				return this.autosubmit_Award_Outcome_for_ApprovalFieldSpecified;
			}
			set
			{
				this.autosubmit_Award_Outcome_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Autosubmit_Award_Outcome_for_ApprovalSpecified");
			}
		}

		[XmlElement("RFQ_Award_PO_Defaults_Data", Order = 16)]
		public RFQ_Award_PO_Defaults_DataType[] RFQ_Award_PO_Defaults_Data
		{
			get
			{
				return this.rFQ_Award_PO_Defaults_DataField;
			}
			set
			{
				this.rFQ_Award_PO_Defaults_DataField = value;
				this.RaisePropertyChanged("RFQ_Award_PO_Defaults_Data");
			}
		}

		[XmlElement("RFQ_Award_Contract_Defaults_Data", Order = 17)]
		public RFQ_Award_Contract_Defaults_DataType[] RFQ_Award_Contract_Defaults_Data
		{
			get
			{
				return this.rFQ_Award_Contract_Defaults_DataField;
			}
			set
			{
				this.rFQ_Award_Contract_Defaults_DataField = value;
				this.RaisePropertyChanged("RFQ_Award_Contract_Defaults_Data");
			}
		}

		[XmlElement("Request_for_Quote_Award_Line_Data", Order = 18)]
		public Request_for_Quote_Award_Line_DataType[] Request_for_Quote_Award_Line_Data
		{
			get
			{
				return this.request_for_Quote_Award_Line_DataField;
			}
			set
			{
				this.request_for_Quote_Award_Line_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Line_Data");
			}
		}

		[XmlElement("Business_Document_Attachment_Data", Order = 19)]
		public Business_Document_Attachment_with_External_Option_DataType[] Business_Document_Attachment_Data
		{
			get
			{
				return this.business_Document_Attachment_DataField;
			}
			set
			{
				this.business_Document_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Attachment_Data");
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
