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
	public class RFQ_Response_DataType : INotifyPropertyChanged
	{
		private string request_for_Quote_Response_IDField;

		private Request_for_QuoteObjectType request_for_Quote_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Document_StatusObjectType rFQ_Response_Status_ReferenceField;

		private DateTime response_DateField;

		private bool response_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string recorded_ByField;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private string shipping_InstructionField;

		private string response_MemoField;

		private DateTime rFQ_Document_DateField;

		private bool rFQ_Document_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private WorkerObjectType sourcing_Buyer_ReferenceField;

		private string rFQ_Document_MemoField;

		private string request_for_Quote_Terms_and_ConditionsField;

		private RFQ_Response_Line_DataType[] request_for_Quote_Response_Line_DataField;

		private RFQ_Header_or_Line_Bid_Response_DataType[] rFQ_Response_Bid_Response_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Request_for_Quote_Response_ID
		{
			get
			{
				return this.request_for_Quote_Response_IDField;
			}
			set
			{
				this.request_for_Quote_Response_IDField = value;
				this.RaisePropertyChanged("Request_for_Quote_Response_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 4)]
		public Document_StatusObjectType RFQ_Response_Status_Reference
		{
			get
			{
				return this.rFQ_Response_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Response_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Response_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Response_Date
		{
			get
			{
				return this.response_DateField;
			}
			set
			{
				this.response_DateField = value;
				this.RaisePropertyChanged("Response_Date");
			}
		}

		[XmlIgnore]
		public bool Response_DateSpecified
		{
			get
			{
				return this.response_DateFieldSpecified;
			}
			set
			{
				this.response_DateFieldSpecified = value;
				this.RaisePropertyChanged("Response_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Recorded_By
		{
			get
			{
				return this.recorded_ByField;
			}
			set
			{
				this.recorded_ByField = value;
				this.RaisePropertyChanged("Recorded_By");
			}
		}

		[XmlElement(Order = 8)]
		public Shipping_TermsObjectType Shipping_Terms_Reference
		{
			get
			{
				return this.shipping_Terms_ReferenceField;
			}
			set
			{
				this.shipping_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Terms_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Shipping_MethodObjectType Shipping_Method_Reference
		{
			get
			{
				return this.shipping_Method_ReferenceField;
			}
			set
			{
				this.shipping_Method_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Method_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Shipping_Instruction
		{
			get
			{
				return this.shipping_InstructionField;
			}
			set
			{
				this.shipping_InstructionField = value;
				this.RaisePropertyChanged("Shipping_Instruction");
			}
		}

		[XmlElement(Order = 11)]
		public string Response_Memo
		{
			get
			{
				return this.response_MemoField;
			}
			set
			{
				this.response_MemoField = value;
				this.RaisePropertyChanged("Response_Memo");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime RFQ_Document_Date
		{
			get
			{
				return this.rFQ_Document_DateField;
			}
			set
			{
				this.rFQ_Document_DateField = value;
				this.RaisePropertyChanged("RFQ_Document_Date");
			}
		}

		[XmlIgnore]
		public bool RFQ_Document_DateSpecified
		{
			get
			{
				return this.rFQ_Document_DateFieldSpecified;
			}
			set
			{
				this.rFQ_Document_DateFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Document_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public string RFQ_Document_Memo
		{
			get
			{
				return this.rFQ_Document_MemoField;
			}
			set
			{
				this.rFQ_Document_MemoField = value;
				this.RaisePropertyChanged("RFQ_Document_Memo");
			}
		}

		[XmlElement(Order = 17)]
		public string Request_for_Quote_Terms_and_Conditions
		{
			get
			{
				return this.request_for_Quote_Terms_and_ConditionsField;
			}
			set
			{
				this.request_for_Quote_Terms_and_ConditionsField = value;
				this.RaisePropertyChanged("Request_for_Quote_Terms_and_Conditions");
			}
		}

		[XmlElement("Request_for_Quote_Response_Line_Data", Order = 18)]
		public RFQ_Response_Line_DataType[] Request_for_Quote_Response_Line_Data
		{
			get
			{
				return this.request_for_Quote_Response_Line_DataField;
			}
			set
			{
				this.request_for_Quote_Response_Line_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Response_Line_Data");
			}
		}

		[XmlElement("RFQ_Response_Bid_Response_Data", Order = 19)]
		public RFQ_Header_or_Line_Bid_Response_DataType[] RFQ_Response_Bid_Response_Data
		{
			get
			{
				return this.rFQ_Response_Bid_Response_DataField;
			}
			set
			{
				this.rFQ_Response_Bid_Response_DataField = value;
				this.RaisePropertyChanged("RFQ_Response_Bid_Response_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 20)]
		public Financials_Attachment_DataType[] Attachment_Data
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
