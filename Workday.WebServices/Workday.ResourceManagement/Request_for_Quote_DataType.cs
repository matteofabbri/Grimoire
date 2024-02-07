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
	public class Request_for_Quote_DataType : INotifyPropertyChanged
	{
		private string request_for_Quote_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private string rFQ_NumberField;

		private Document_StatusObjectType rFQ_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Request_for_Quote_TypeObjectType rFQ_Type_ReferenceField;

		private string titleField;

		private DateTime document_DateField;

		private DateTime rFQ_Start_DateField;

		private DateTime rFQ_End_DateField;

		private Time_ZoneObjectType time_Zone_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private WorkerObjectType sourcing_Buyer_ReferenceField;

		private bool exclude_Target_PriceField;

		private bool exclude_Target_PriceFieldSpecified;

		private string request_for_Quote_Terms_and_ConditionsField;

		private string memoField;

		private Request_for_Quote_Line_DataType[] request_for_Quote_Line_DataField;

		private Request_for_Quote_Participant_List_DataType[] request_for_Quote_Participant_List_DataField;

		private Request_for_Quote_Bid_Requirement_DataType[] request_for_Quote_Bid_Requirement_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Request_for_Quote_ID
		{
			get
			{
				return this.request_for_Quote_IDField;
			}
			set
			{
				this.request_for_Quote_IDField = value;
				this.RaisePropertyChanged("Request_for_Quote_ID");
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
		public string RFQ_Number
		{
			get
			{
				return this.rFQ_NumberField;
			}
			set
			{
				this.rFQ_NumberField = value;
				this.RaisePropertyChanged("RFQ_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType RFQ_Status_Reference
		{
			get
			{
				return this.rFQ_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Status_Reference");
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
		public Request_for_Quote_TypeObjectType RFQ_Type_Reference
		{
			get
			{
				return this.rFQ_Type_ReferenceField;
			}
			set
			{
				this.rFQ_Type_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime RFQ_Start_Date
		{
			get
			{
				return this.rFQ_Start_DateField;
			}
			set
			{
				this.rFQ_Start_DateField = value;
				this.RaisePropertyChanged("RFQ_Start_Date");
			}
		}

		[XmlElement(Order = 9)]
		public DateTime RFQ_End_Date
		{
			get
			{
				return this.rFQ_End_DateField;
			}
			set
			{
				this.rFQ_End_DateField = value;
				this.RaisePropertyChanged("RFQ_End_Date");
			}
		}

		[XmlElement(Order = 10)]
		public Time_ZoneObjectType Time_Zone_Reference
		{
			get
			{
				return this.time_Zone_ReferenceField;
			}
			set
			{
				this.time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public bool Exclude_Target_Price
		{
			get
			{
				return this.exclude_Target_PriceField;
			}
			set
			{
				this.exclude_Target_PriceField = value;
				this.RaisePropertyChanged("Exclude_Target_Price");
			}
		}

		[XmlIgnore]
		public bool Exclude_Target_PriceSpecified
		{
			get
			{
				return this.exclude_Target_PriceFieldSpecified;
			}
			set
			{
				this.exclude_Target_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Target_PriceSpecified");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement("Request_for_Quote_Line_Data", Order = 16)]
		public Request_for_Quote_Line_DataType[] Request_for_Quote_Line_Data
		{
			get
			{
				return this.request_for_Quote_Line_DataField;
			}
			set
			{
				this.request_for_Quote_Line_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Data");
			}
		}

		[XmlElement("Request_for_Quote_Participant_List_Data", Order = 17)]
		public Request_for_Quote_Participant_List_DataType[] Request_for_Quote_Participant_List_Data
		{
			get
			{
				return this.request_for_Quote_Participant_List_DataField;
			}
			set
			{
				this.request_for_Quote_Participant_List_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Participant_List_Data");
			}
		}

		[XmlElement("Request_for_Quote_Bid_Requirement_Data", Order = 18)]
		public Request_for_Quote_Bid_Requirement_DataType[] Request_for_Quote_Bid_Requirement_Data
		{
			get
			{
				return this.request_for_Quote_Bid_Requirement_DataField;
			}
			set
			{
				this.request_for_Quote_Bid_Requirement_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Bid_Requirement_Data");
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
