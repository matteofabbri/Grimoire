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
	public class CC_Transaction_LineType : INotifyPropertyChanged
	{
		private decimal credit_Card_Transaction_Line_IDField;

		private bool credit_Card_Transaction_Line_IDFieldSpecified;

		private decimal purchase_Order_Line_NumberField;

		private bool purchase_Order_Line_NumberFieldSpecified;

		private string item_DescriptionField;

		private decimal uNSPSC_codeField;

		private bool uNSPSC_codeFieldSpecified;

		private string uPCField;

		private string vendor_Part_NumberField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private decimal tax_RateField;

		private bool tax_RateFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal handling_AmountField;

		private bool handling_AmountFieldSpecified;

		private decimal discount_AmountField;

		private bool discount_AmountFieldSpecified;

		private decimal flat_Rate_AmountField;

		private bool flat_Rate_AmountFieldSpecified;

		private decimal lost_or_Damaged_Items_AmountField;

		private bool lost_or_Damaged_Items_AmountFieldSpecified;

		private decimal one_Time_Miscellaneous_Charges_AmountField;

		private bool one_Time_Miscellaneous_Charges_AmountFieldSpecified;

		private decimal other_Charges_AmountField;

		private bool other_Charges_AmountFieldSpecified;

		private decimal miscellaneous_Charges_AmountField;

		private bool miscellaneous_Charges_AmountFieldSpecified;

		private string miscellaneous_Charges_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Credit_Card_Transaction_Line_ID
		{
			get
			{
				return this.credit_Card_Transaction_Line_IDField;
			}
			set
			{
				this.credit_Card_Transaction_Line_IDField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Line_ID");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_Transaction_Line_IDSpecified
		{
			get
			{
				return this.credit_Card_Transaction_Line_IDFieldSpecified;
			}
			set
			{
				this.credit_Card_Transaction_Line_IDFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Line_IDSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Purchase_Order_Line_Number
		{
			get
			{
				return this.purchase_Order_Line_NumberField;
			}
			set
			{
				this.purchase_Order_Line_NumberField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Line_NumberSpecified
		{
			get
			{
				return this.purchase_Order_Line_NumberFieldSpecified;
			}
			set
			{
				this.purchase_Order_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal UNSPSC_code
		{
			get
			{
				return this.uNSPSC_codeField;
			}
			set
			{
				this.uNSPSC_codeField = value;
				this.RaisePropertyChanged("UNSPSC_code");
			}
		}

		[XmlIgnore]
		public bool UNSPSC_codeSpecified
		{
			get
			{
				return this.uNSPSC_codeFieldSpecified;
			}
			set
			{
				this.uNSPSC_codeFieldSpecified = value;
				this.RaisePropertyChanged("UNSPSC_codeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string UPC
		{
			get
			{
				return this.uPCField;
			}
			set
			{
				this.uPCField = value;
				this.RaisePropertyChanged("UPC");
			}
		}

		[XmlElement(Order = 5)]
		public string Vendor_Part_Number
		{
			get
			{
				return this.vendor_Part_NumberField;
			}
			set
			{
				this.vendor_Part_NumberField = value;
				this.RaisePropertyChanged("Vendor_Part_Number");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Unit_Price
		{
			get
			{
				return this.unit_PriceField;
			}
			set
			{
				this.unit_PriceField = value;
				this.RaisePropertyChanged("Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Unit_PriceSpecified
		{
			get
			{
				return this.unit_PriceFieldSpecified;
			}
			set
			{
				this.unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Tax_Rate
		{
			get
			{
				return this.tax_RateField;
			}
			set
			{
				this.tax_RateField = value;
				this.RaisePropertyChanged("Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool Tax_RateSpecified
		{
			get
			{
				return this.tax_RateFieldSpecified;
			}
			set
			{
				this.tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_RateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Tax_Amount
		{
			get
			{
				return this.tax_AmountField;
			}
			set
			{
				this.tax_AmountField = value;
				this.RaisePropertyChanged("Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Tax_AmountSpecified
		{
			get
			{
				return this.tax_AmountFieldSpecified;
			}
			set
			{
				this.tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Freight_Amount
		{
			get
			{
				return this.freight_AmountField;
			}
			set
			{
				this.freight_AmountField = value;
				this.RaisePropertyChanged("Freight_Amount");
			}
		}

		[XmlIgnore]
		public bool Freight_AmountSpecified
		{
			get
			{
				return this.freight_AmountFieldSpecified;
			}
			set
			{
				this.freight_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Freight_AmountSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Handling_Amount
		{
			get
			{
				return this.handling_AmountField;
			}
			set
			{
				this.handling_AmountField = value;
				this.RaisePropertyChanged("Handling_Amount");
			}
		}

		[XmlIgnore]
		public bool Handling_AmountSpecified
		{
			get
			{
				return this.handling_AmountFieldSpecified;
			}
			set
			{
				this.handling_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Handling_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Discount_Amount
		{
			get
			{
				return this.discount_AmountField;
			}
			set
			{
				this.discount_AmountField = value;
				this.RaisePropertyChanged("Discount_Amount");
			}
		}

		[XmlIgnore]
		public bool Discount_AmountSpecified
		{
			get
			{
				return this.discount_AmountFieldSpecified;
			}
			set
			{
				this.discount_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Discount_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Flat_Rate_Amount
		{
			get
			{
				return this.flat_Rate_AmountField;
			}
			set
			{
				this.flat_Rate_AmountField = value;
				this.RaisePropertyChanged("Flat_Rate_Amount");
			}
		}

		[XmlIgnore]
		public bool Flat_Rate_AmountSpecified
		{
			get
			{
				return this.flat_Rate_AmountFieldSpecified;
			}
			set
			{
				this.flat_Rate_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Flat_Rate_AmountSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Lost_or_Damaged_Items_Amount
		{
			get
			{
				return this.lost_or_Damaged_Items_AmountField;
			}
			set
			{
				this.lost_or_Damaged_Items_AmountField = value;
				this.RaisePropertyChanged("Lost_or_Damaged_Items_Amount");
			}
		}

		[XmlIgnore]
		public bool Lost_or_Damaged_Items_AmountSpecified
		{
			get
			{
				return this.lost_or_Damaged_Items_AmountFieldSpecified;
			}
			set
			{
				this.lost_or_Damaged_Items_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Lost_or_Damaged_Items_AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal One_Time_Miscellaneous_Charges_Amount
		{
			get
			{
				return this.one_Time_Miscellaneous_Charges_AmountField;
			}
			set
			{
				this.one_Time_Miscellaneous_Charges_AmountField = value;
				this.RaisePropertyChanged("One_Time_Miscellaneous_Charges_Amount");
			}
		}

		[XmlIgnore]
		public bool One_Time_Miscellaneous_Charges_AmountSpecified
		{
			get
			{
				return this.one_Time_Miscellaneous_Charges_AmountFieldSpecified;
			}
			set
			{
				this.one_Time_Miscellaneous_Charges_AmountFieldSpecified = value;
				this.RaisePropertyChanged("One_Time_Miscellaneous_Charges_AmountSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Other_Charges_Amount
		{
			get
			{
				return this.other_Charges_AmountField;
			}
			set
			{
				this.other_Charges_AmountField = value;
				this.RaisePropertyChanged("Other_Charges_Amount");
			}
		}

		[XmlIgnore]
		public bool Other_Charges_AmountSpecified
		{
			get
			{
				return this.other_Charges_AmountFieldSpecified;
			}
			set
			{
				this.other_Charges_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Other_Charges_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Miscellaneous_Charges_Amount
		{
			get
			{
				return this.miscellaneous_Charges_AmountField;
			}
			set
			{
				this.miscellaneous_Charges_AmountField = value;
				this.RaisePropertyChanged("Miscellaneous_Charges_Amount");
			}
		}

		[XmlIgnore]
		public bool Miscellaneous_Charges_AmountSpecified
		{
			get
			{
				return this.miscellaneous_Charges_AmountFieldSpecified;
			}
			set
			{
				this.miscellaneous_Charges_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Miscellaneous_Charges_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public string Miscellaneous_Charges_Description
		{
			get
			{
				return this.miscellaneous_Charges_DescriptionField;
			}
			set
			{
				this.miscellaneous_Charges_DescriptionField = value;
				this.RaisePropertyChanged("Miscellaneous_Charges_Description");
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
