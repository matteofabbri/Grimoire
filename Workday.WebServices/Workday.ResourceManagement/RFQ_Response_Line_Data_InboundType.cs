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
	public class RFQ_Response_Line_Data_InboundType : INotifyPropertyChanged
	{
		private Request_for_Quote_LineObjectType rFQ_Line_ReferenceField;

		private bool no_BidField;

		private bool no_BidFieldSpecified;

		private string response_Line_DescriptionField;

		private decimal response_QuantityField;

		private bool response_QuantityFieldSpecified;

		private decimal response_PriceField;

		private bool response_PriceFieldSpecified;

		private decimal lead_Time_in_DaysField;

		private bool lead_Time_in_DaysFieldSpecified;

		private string response_Line_MemoField;

		private RFQ_Header_Or_Line_Bid_Response_Data_InboundType[] rFQ_Line_Bid_Response_DataField;

		private Financials_Attachment_DataType[] rFQ_Response_Line_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_LineObjectType RFQ_Line_Reference
		{
			get
			{
				return this.rFQ_Line_ReferenceField;
			}
			set
			{
				this.rFQ_Line_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool No_Bid
		{
			get
			{
				return this.no_BidField;
			}
			set
			{
				this.no_BidField = value;
				this.RaisePropertyChanged("No_Bid");
			}
		}

		[XmlIgnore]
		public bool No_BidSpecified
		{
			get
			{
				return this.no_BidFieldSpecified;
			}
			set
			{
				this.no_BidFieldSpecified = value;
				this.RaisePropertyChanged("No_BidSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Response_Line_Description
		{
			get
			{
				return this.response_Line_DescriptionField;
			}
			set
			{
				this.response_Line_DescriptionField = value;
				this.RaisePropertyChanged("Response_Line_Description");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Response_Quantity
		{
			get
			{
				return this.response_QuantityField;
			}
			set
			{
				this.response_QuantityField = value;
				this.RaisePropertyChanged("Response_Quantity");
			}
		}

		[XmlIgnore]
		public bool Response_QuantitySpecified
		{
			get
			{
				return this.response_QuantityFieldSpecified;
			}
			set
			{
				this.response_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Response_QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Response_Price
		{
			get
			{
				return this.response_PriceField;
			}
			set
			{
				this.response_PriceField = value;
				this.RaisePropertyChanged("Response_Price");
			}
		}

		[XmlIgnore]
		public bool Response_PriceSpecified
		{
			get
			{
				return this.response_PriceFieldSpecified;
			}
			set
			{
				this.response_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Response_PriceSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Lead_Time_in_Days
		{
			get
			{
				return this.lead_Time_in_DaysField;
			}
			set
			{
				this.lead_Time_in_DaysField = value;
				this.RaisePropertyChanged("Lead_Time_in_Days");
			}
		}

		[XmlIgnore]
		public bool Lead_Time_in_DaysSpecified
		{
			get
			{
				return this.lead_Time_in_DaysFieldSpecified;
			}
			set
			{
				this.lead_Time_in_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Lead_Time_in_DaysSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Response_Line_Memo
		{
			get
			{
				return this.response_Line_MemoField;
			}
			set
			{
				this.response_Line_MemoField = value;
				this.RaisePropertyChanged("Response_Line_Memo");
			}
		}

		[XmlElement("RFQ_Line_Bid_Response_Data", Order = 7)]
		public RFQ_Header_Or_Line_Bid_Response_Data_InboundType[] RFQ_Line_Bid_Response_Data
		{
			get
			{
				return this.rFQ_Line_Bid_Response_DataField;
			}
			set
			{
				this.rFQ_Line_Bid_Response_DataField = value;
				this.RaisePropertyChanged("RFQ_Line_Bid_Response_Data");
			}
		}

		[XmlElement("RFQ_Response_Line_Attachment_Data", Order = 8)]
		public Financials_Attachment_DataType[] RFQ_Response_Line_Attachment_Data
		{
			get
			{
				return this.rFQ_Response_Line_Attachment_DataField;
			}
			set
			{
				this.rFQ_Response_Line_Attachment_DataField = value;
				this.RaisePropertyChanged("RFQ_Response_Line_Attachment_Data");
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
