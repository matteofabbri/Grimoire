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
	public class Request_for_Quote_Line_DataType : INotifyPropertyChanged
	{
		private string request_for_Quote_Line_IDField;

		private Request_for_Quote_LineObjectType request_for_Quote_Line_ReferenceField;

		private Request_for_Quote_Line_TypeObjectType line_Type_ReferenceField;

		private Requisition_LineObjectType requisition_Line_ReferenceField;

		private decimal line_NumberField;

		private Purchase_ItemObjectType item_ReferenceField;

		private string item_DescriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private decimal target_PriceField;

		private bool target_PriceFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private bool response_RequiredField;

		private bool response_RequiredFieldSpecified;

		private bool unit_Price_RequiredField;

		private bool unit_Price_RequiredFieldSpecified;

		private bool lead_Time_RequiredField;

		private bool lead_Time_RequiredFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

		private Request_for_Quote_Line_Bid_Requirement_DataType[] request_for_Quote_Line_Bid_Requirement_DataField;

		private Request_for_Quote_Line_Splits_DataType[] request_for_Quote_Line_Split_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Line_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Request_for_Quote_Line_ID
		{
			get
			{
				return this.request_for_Quote_Line_IDField;
			}
			set
			{
				this.request_for_Quote_Line_IDField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Request_for_Quote_LineObjectType Request_for_Quote_Line_Reference
		{
			get
			{
				return this.request_for_Quote_Line_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Line_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Reference");
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
		public Requisition_LineObjectType Requisition_Line_Reference
		{
			get
			{
				return this.requisition_Line_ReferenceField;
			}
			set
			{
				this.requisition_Line_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Line_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlElement(Order = 5)]
		public Purchase_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 7)]
		public Spend_CategoryObjectType Spend_Category_Reference
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
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

		[XmlElement(DataType = "date", Order = 15)]
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

		[XmlElement(Order = 16)]
		public bool Response_Required
		{
			get
			{
				return this.response_RequiredField;
			}
			set
			{
				this.response_RequiredField = value;
				this.RaisePropertyChanged("Response_Required");
			}
		}

		[XmlIgnore]
		public bool Response_RequiredSpecified
		{
			get
			{
				return this.response_RequiredFieldSpecified;
			}
			set
			{
				this.response_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Response_RequiredSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Unit_Price_Required
		{
			get
			{
				return this.unit_Price_RequiredField;
			}
			set
			{
				this.unit_Price_RequiredField = value;
				this.RaisePropertyChanged("Unit_Price_Required");
			}
		}

		[XmlIgnore]
		public bool Unit_Price_RequiredSpecified
		{
			get
			{
				return this.unit_Price_RequiredFieldSpecified;
			}
			set
			{
				this.unit_Price_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Unit_Price_RequiredSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Lead_Time_Required
		{
			get
			{
				return this.lead_Time_RequiredField;
			}
			set
			{
				this.lead_Time_RequiredField = value;
				this.RaisePropertyChanged("Lead_Time_Required");
			}
		}

		[XmlIgnore]
		public bool Lead_Time_RequiredSpecified
		{
			get
			{
				return this.lead_Time_RequiredFieldSpecified;
			}
			set
			{
				this.lead_Time_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Lead_Time_RequiredSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 19)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 20)]
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

		[XmlElement("Request_for_Quote_Line_Bid_Requirement_Data", Order = 21)]
		public Request_for_Quote_Line_Bid_Requirement_DataType[] Request_for_Quote_Line_Bid_Requirement_Data
		{
			get
			{
				return this.request_for_Quote_Line_Bid_Requirement_DataField;
			}
			set
			{
				this.request_for_Quote_Line_Bid_Requirement_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Bid_Requirement_Data");
			}
		}

		[XmlElement("Request_for_Quote_Line_Split_Data", Order = 22)]
		public Request_for_Quote_Line_Splits_DataType[] Request_for_Quote_Line_Split_Data
		{
			get
			{
				return this.request_for_Quote_Line_Split_DataField;
			}
			set
			{
				this.request_for_Quote_Line_Split_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Line_Split_Data");
			}
		}

		[XmlElement("Business_Document_Line_Attachment_Data", Order = 23)]
		public Business_Document_Attachment_with_External_Option_DataType[] Business_Document_Line_Attachment_Data
		{
			get
			{
				return this.business_Document_Line_Attachment_DataField;
			}
			set
			{
				this.business_Document_Line_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Line_Attachment_Data");
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
