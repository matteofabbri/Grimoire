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
	public class Request_for_Quote_Award_Line_DataType : INotifyPropertyChanged
	{
		private Request_for_Quote_Award_LineObjectType rFQ_Award_Line_ReferenceField;

		private Request_for_Quote_LineObjectType rFQ_Line_ReferenceField;

		private Request_for_Quote_Response_LineObjectType rFQ_Response_Line_ReferenceField;

		private Business_Document_LineObjectType[] awarded_Document_Line_ReferenceField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private Request_for_Quote_Line_TypeObjectType line_Type_ReferenceField;

		private Item_DescriptorObjectType item_ReferenceField;

		private string item_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private decimal rFQ_Line_QuantityField;

		private bool rFQ_Line_QuantityFieldSpecified;

		private decimal rFQ_Line_Quantity_AwardedField;

		private bool rFQ_Line_Quantity_AwardedFieldSpecified;

		private decimal award_QuantityField;

		private bool award_QuantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal rFQ_Line_Unit_CostField;

		private bool rFQ_Line_Unit_CostFieldSpecified;

		private decimal rFQ_Line_AmountField;

		private bool rFQ_Line_AmountFieldSpecified;

		private decimal amount_AwardedField;

		private bool amount_AwardedFieldSpecified;

		private decimal target_PriceField;

		private bool target_PriceFieldSpecified;

		private decimal response_PriceField;

		private bool response_PriceFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal award_AmountField;

		private bool award_AmountFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

		private string memoField;

		private Request_for_Quote_Award_Line_Splits_DataType[] request_for_Quote_Award_Line_Splits_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Line_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_Award_LineObjectType RFQ_Award_Line_Reference
		{
			get
			{
				return this.rFQ_Award_Line_ReferenceField;
			}
			set
			{
				this.rFQ_Award_Line_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Award_Line_Reference");
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

		[XmlElement("Awarded_Document_Line_Reference", Order = 3)]
		public Business_Document_LineObjectType[] Awarded_Document_Line_Reference
		{
			get
			{
				return this.awarded_Document_Line_ReferenceField;
			}
			set
			{
				this.awarded_Document_Line_ReferenceField = value;
				this.RaisePropertyChanged("Awarded_Document_Line_Reference");
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

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Item_DescriptorObjectType Item_Reference
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal RFQ_Line_Quantity
		{
			get
			{
				return this.rFQ_Line_QuantityField;
			}
			set
			{
				this.rFQ_Line_QuantityField = value;
				this.RaisePropertyChanged("RFQ_Line_Quantity");
			}
		}

		[XmlIgnore]
		public bool RFQ_Line_QuantitySpecified
		{
			get
			{
				return this.rFQ_Line_QuantityFieldSpecified;
			}
			set
			{
				this.rFQ_Line_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Line_QuantitySpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal RFQ_Line_Quantity_Awarded
		{
			get
			{
				return this.rFQ_Line_Quantity_AwardedField;
			}
			set
			{
				this.rFQ_Line_Quantity_AwardedField = value;
				this.RaisePropertyChanged("RFQ_Line_Quantity_Awarded");
			}
		}

		[XmlIgnore]
		public bool RFQ_Line_Quantity_AwardedSpecified
		{
			get
			{
				return this.rFQ_Line_Quantity_AwardedFieldSpecified;
			}
			set
			{
				this.rFQ_Line_Quantity_AwardedFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Line_Quantity_AwardedSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Award_Quantity
		{
			get
			{
				return this.award_QuantityField;
			}
			set
			{
				this.award_QuantityField = value;
				this.RaisePropertyChanged("Award_Quantity");
			}
		}

		[XmlIgnore]
		public bool Award_QuantitySpecified
		{
			get
			{
				return this.award_QuantityFieldSpecified;
			}
			set
			{
				this.award_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Award_QuantitySpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public decimal RFQ_Line_Unit_Cost
		{
			get
			{
				return this.rFQ_Line_Unit_CostField;
			}
			set
			{
				this.rFQ_Line_Unit_CostField = value;
				this.RaisePropertyChanged("RFQ_Line_Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool RFQ_Line_Unit_CostSpecified
		{
			get
			{
				return this.rFQ_Line_Unit_CostFieldSpecified;
			}
			set
			{
				this.rFQ_Line_Unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Line_Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal RFQ_Line_Amount
		{
			get
			{
				return this.rFQ_Line_AmountField;
			}
			set
			{
				this.rFQ_Line_AmountField = value;
				this.RaisePropertyChanged("RFQ_Line_Amount");
			}
		}

		[XmlIgnore]
		public bool RFQ_Line_AmountSpecified
		{
			get
			{
				return this.rFQ_Line_AmountFieldSpecified;
			}
			set
			{
				this.rFQ_Line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Line_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Amount_Awarded
		{
			get
			{
				return this.amount_AwardedField;
			}
			set
			{
				this.amount_AwardedField = value;
				this.RaisePropertyChanged("Amount_Awarded");
			}
		}

		[XmlIgnore]
		public bool Amount_AwardedSpecified
		{
			get
			{
				return this.amount_AwardedFieldSpecified;
			}
			set
			{
				this.amount_AwardedFieldSpecified = value;
				this.RaisePropertyChanged("Amount_AwardedSpecified");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public decimal Award_Amount
		{
			get
			{
				return this.award_AmountField;
			}
			set
			{
				this.award_AmountField = value;
				this.RaisePropertyChanged("Award_Amount");
			}
		}

		[XmlIgnore]
		public bool Award_AmountSpecified
		{
			get
			{
				return this.award_AmountFieldSpecified;
			}
			set
			{
				this.award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Award_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
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

		[XmlElement(DataType = "date", Order = 21)]
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

		[XmlElement(DataType = "date", Order = 22)]
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

		[XmlElement(Order = 23)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public LocationObjectType Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 26)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 27)]
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

		[XmlElement("Request_for_Quote_Award_Line_Splits_Data", Order = 28)]
		public Request_for_Quote_Award_Line_Splits_DataType[] Request_for_Quote_Award_Line_Splits_Data
		{
			get
			{
				return this.request_for_Quote_Award_Line_Splits_DataField;
			}
			set
			{
				this.request_for_Quote_Award_Line_Splits_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Line_Splits_Data");
			}
		}

		[XmlElement("Business_Document_Line_Attachment_Data", Order = 29)]
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
