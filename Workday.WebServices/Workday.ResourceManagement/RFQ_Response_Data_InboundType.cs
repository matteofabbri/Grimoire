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
	public class RFQ_Response_Data_InboundType : INotifyPropertyChanged
	{
		private string request_for_Quote_Response_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Request_for_QuoteObjectType rFQ_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private string response_Recorded_ByField;

		private DateTime response_DateField;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private string shipping_InstructionField;

		private string response_MemoField;

		private RFQ_Response_Line_Data_InboundType[] request_for_Quote_Response_Line_DataField;

		private RFQ_Header_Or_Line_Bid_Response_Data_InboundType[] rFQ_Header_Bid_Response_DataField;

		private Financials_Attachment_DataType[] rFQ_Response_Attachment_DataField;

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
		public Request_for_QuoteObjectType RFQ_Reference
		{
			get
			{
				return this.rFQ_ReferenceField;
			}
			set
			{
				this.rFQ_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Reference");
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

		[XmlElement(Order = 5)]
		public string Response_Recorded_By
		{
			get
			{
				return this.response_Recorded_ByField;
			}
			set
			{
				this.response_Recorded_ByField = value;
				this.RaisePropertyChanged("Response_Recorded_By");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement("Request_for_Quote_Response_Line_Data", Order = 11)]
		public RFQ_Response_Line_Data_InboundType[] Request_for_Quote_Response_Line_Data
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

		[XmlElement("RFQ_Header_Bid_Response_Data", Order = 12)]
		public RFQ_Header_Or_Line_Bid_Response_Data_InboundType[] RFQ_Header_Bid_Response_Data
		{
			get
			{
				return this.rFQ_Header_Bid_Response_DataField;
			}
			set
			{
				this.rFQ_Header_Bid_Response_DataField = value;
				this.RaisePropertyChanged("RFQ_Header_Bid_Response_Data");
			}
		}

		[XmlElement("RFQ_Response_Attachment_Data", Order = 13)]
		public Financials_Attachment_DataType[] RFQ_Response_Attachment_Data
		{
			get
			{
				return this.rFQ_Response_Attachment_DataField;
			}
			set
			{
				this.rFQ_Response_Attachment_DataField = value;
				this.RaisePropertyChanged("RFQ_Response_Attachment_Data");
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
