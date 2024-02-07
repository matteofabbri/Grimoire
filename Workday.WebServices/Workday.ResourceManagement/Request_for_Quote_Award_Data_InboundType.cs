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
	public class Request_for_Quote_Award_Data_InboundType : INotifyPropertyChanged
	{
		private string request_for_Quote_Award_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Request_for_QuoteObjectType request_for_Quote_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private DateTime award_DateField;

		private Procurement_Award_ReasonObjectType award_Reason_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Request_for_Quote_Award_TypeObjectType rFQ_Award_Type_ReferenceField;

		private string memoField;

		private bool autosubmit_Award_Outcome_for_ApprovalField;

		private bool autosubmit_Award_Outcome_for_ApprovalFieldSpecified;

		private RFQ_Award_PO_Defaults_Data_InboundType rFQ_Award_PO_Defaults_DataField;

		private RFQ_Award_Contract_Defaults_Data_InboundType rFQ_Award_Contract_Defaults_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Attachment_DataField;

		private Request_for_Quote_Award_Line_Data_InboundType[] request_for_Quote_Award_Line_DataField;

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

		[XmlElement(Order = 4)]
		public Resource_ProviderObjectType Supplier_Reference
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 6)]
		public Procurement_Award_ReasonObjectType Award_Reason_Reference
		{
			get
			{
				return this.award_Reason_ReferenceField;
			}
			set
			{
				this.award_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reason_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement("Auto-submit_Award_Outcome_for_Approval", Order = 10)]
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

		[XmlElement(Order = 11)]
		public RFQ_Award_PO_Defaults_Data_InboundType RFQ_Award_PO_Defaults_Data
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

		[XmlElement(Order = 12)]
		public RFQ_Award_Contract_Defaults_Data_InboundType RFQ_Award_Contract_Defaults_Data
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

		[XmlElement("Business_Document_Attachment_Data", Order = 13)]
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

		[XmlElement("Request_for_Quote_Award_Line_Data", Order = 14)]
		public Request_for_Quote_Award_Line_Data_InboundType[] Request_for_Quote_Award_Line_Data
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
