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
	public class RFQ_Response_Line_DataType : INotifyPropertyChanged
	{
		private Request_for_Quote_Response_LineObjectType rFQ_Response_Line_ReferenceField;

		private Request_for_Quote_LineObjectType rFQ_Line_ReferenceField;

		private Request_for_Quote_Line_TypeObjectType line_Type_ReferenceField;

		private decimal rFQ_Line_NumberField;

		private bool rFQ_Line_NumberFieldSpecified;

		private Item_DescriptorObjectType item_Descriptor_ReferenceField;

		private string line_Item_DescriptionField;

		private string response_Line_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private bool no_BidField;

		private bool no_BidFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal target_PriceField;

		private bool target_PriceFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string rFQ_Line_MemoField;

		private decimal response_PriceField;

		private bool response_PriceFieldSpecified;

		private decimal response_QuantityField;

		private bool response_QuantityFieldSpecified;

		private decimal response_Lead_TimeField;

		private bool response_Lead_TimeFieldSpecified;

		private string response_MemoField;

		private RFQ_Header_or_Line_Bid_Response_DataType[] rFQ_Line_Bid_Response_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_Response_LineObjectType RFQ_Response_Line_Reference
		{
			get
			{
				return this.rFQ_Response_Line_ReferenceField;
			}
			set
			{
				this.rFQ_Response_Line_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Response_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Request_for_Quote_Line_TypeObjectType Line_Type_Reference
		{
			get
			{
				return this.line_Type_ReferenceField;
			}
			set
			{
				this.line_Type_ReferenceField = value;
				this.RaisePropertyChanged("Line_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal RFQ_Line_Number
		{
			get
			{
				return this.rFQ_Line_NumberField;
			}
			set
			{
				this.rFQ_Line_NumberField = value;
				this.RaisePropertyChanged("RFQ_Line_Number");
			}
		}

		[XmlIgnore]
		public bool RFQ_Line_NumberSpecified
		{
			get
			{
				return this.rFQ_Line_NumberFieldSpecified;
			}
			set
			{
				this.rFQ_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Item_DescriptorObjectType Item_Descriptor_Reference
		{
			get
			{
				return this.item_Descriptor_ReferenceField;
			}
			set
			{
				this.item_Descriptor_ReferenceField = value;
				this.RaisePropertyChanged("Item_Descriptor_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Accounting_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Target_Price
		{
			get
			{
				return this.target_PriceField;
			}
			set
			{
				this.target_PriceField = value;
				this.RaisePropertyChanged("Target_Price");
			}
		}

		[XmlIgnore]
		public bool Target_PriceSpecified
		{
			get
			{
				return this.target_PriceFieldSpecified;
			}
			set
			{
				this.target_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Target_PriceSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Requested_Delivery_Date
		{
			get
			{
				return this.requested_Delivery_DateField;
			}
			set
			{
				this.requested_Delivery_DateField = value;
				this.RaisePropertyChanged("Requested_Delivery_Date");
			}
		}

		[XmlIgnore]
		public bool Requested_Delivery_DateSpecified
		{
			get
			{
				return this.requested_Delivery_DateFieldSpecified;
			}
			set
			{
				this.requested_Delivery_DateFieldSpecified = value;
				this.RaisePropertyChanged("Requested_Delivery_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
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
		public string RFQ_Line_Memo
		{
			get
			{
				return this.rFQ_Line_MemoField;
			}
			set
			{
				this.rFQ_Line_MemoField = value;
				this.RaisePropertyChanged("RFQ_Line_Memo");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public decimal Response_Lead_Time
		{
			get
			{
				return this.response_Lead_TimeField;
			}
			set
			{
				this.response_Lead_TimeField = value;
				this.RaisePropertyChanged("Response_Lead_Time");
			}
		}

		[XmlIgnore]
		public bool Response_Lead_TimeSpecified
		{
			get
			{
				return this.response_Lead_TimeFieldSpecified;
			}
			set
			{
				this.response_Lead_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Response_Lead_TimeSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement("RFQ_Line_Bid_Response_Data", Order = 20)]
		public RFQ_Header_or_Line_Bid_Response_DataType[] RFQ_Line_Bid_Response_Data
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

		[XmlElement("Attachment_Data", Order = 21)]
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
