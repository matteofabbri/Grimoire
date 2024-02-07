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
	public class Internal_Service_Delivery_Line_Data_OutboundType : INotifyPropertyChanged
	{
		private string internal_Service_Delivery_Line_IDField;

		private Internal_Service_Delivery_LineObjectType internal_Service_Delivery_Line_ReferenceField;

		private decimal internal_Service_Delivery_Line_NumberField;

		private bool internal_Service_Delivery_Line_NumberFieldSpecified;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Item_DescriptorObjectType catalog_Item_ReferenceField;

		private string item_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private WorkerObjectType requester_ReferenceField;

		private DateTime delivery_DateField;

		private bool delivery_DateFieldSpecified;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Internal_Service_Delivery_Line_Split_Data_OutboundType[] internal_Service_Delivery_Line_Splits_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Internal_Service_Delivery_Line_ID
		{
			get
			{
				return this.internal_Service_Delivery_Line_IDField;
			}
			set
			{
				this.internal_Service_Delivery_Line_IDField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Internal_Service_Delivery_LineObjectType Internal_Service_Delivery_Line_Reference
		{
			get
			{
				return this.internal_Service_Delivery_Line_ReferenceField;
			}
			set
			{
				this.internal_Service_Delivery_Line_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Internal_Service_Delivery_Line_Number
		{
			get
			{
				return this.internal_Service_Delivery_Line_NumberField;
			}
			set
			{
				this.internal_Service_Delivery_Line_NumberField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Internal_Service_Delivery_Line_NumberSpecified
		{
			get
			{
				return this.internal_Service_Delivery_Line_NumberFieldSpecified;
			}
			set
			{
				this.internal_Service_Delivery_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Intercompany_Affiliate_Reference
		{
			get
			{
				return this.intercompany_Affiliate_ReferenceField;
			}
			set
			{
				this.intercompany_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Affiliate_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Item_DescriptorObjectType Catalog_Item_Reference
		{
			get
			{
				return this.catalog_Item_ReferenceField;
			}
			set
			{
				this.catalog_Item_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Item_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Revenue_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
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
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Delivery_Date
		{
			get
			{
				return this.delivery_DateField;
			}
			set
			{
				this.delivery_DateField = value;
				this.RaisePropertyChanged("Delivery_Date");
			}
		}

		[XmlIgnore]
		public bool Delivery_DateSpecified
		{
			get
			{
				return this.delivery_DateFieldSpecified;
			}
			set
			{
				this.delivery_DateFieldSpecified = value;
				this.RaisePropertyChanged("Delivery_DateSpecified");
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

		[XmlElement("Worktags_Reference", Order = 15)]
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

		[XmlElement("Internal_Service_Delivery_Line_Splits_Data", Order = 16)]
		public Internal_Service_Delivery_Line_Split_Data_OutboundType[] Internal_Service_Delivery_Line_Splits_Data
		{
			get
			{
				return this.internal_Service_Delivery_Line_Splits_DataField;
			}
			set
			{
				this.internal_Service_Delivery_Line_Splits_DataField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Line_Splits_Data");
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
