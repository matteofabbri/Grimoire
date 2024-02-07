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
	public class Business_Asset_Cost_Adjustment_DataType : INotifyPropertyChanged
	{
		private bool post_Acquisition_AdjustmentField;

		private bool post_Acquisition_AdjustmentFieldSpecified;

		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private decimal adjustment_AmountField;

		private bool adjustment_AmountFieldSpecified;

		private decimal adjustment_QuantityField;

		private bool adjustment_QuantityFieldSpecified;

		private decimal adjustment_Residual_ValueField;

		private bool adjustment_Residual_ValueFieldSpecified;

		private DateTime itemField;

		private Asset_BookObjectType[] restricted_to_Books_ReferenceField;

		private Asset_Cost_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private string supplier_Invoice_Line_Reference_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Post_Acquisition_Adjustment
		{
			get
			{
				return this.post_Acquisition_AdjustmentField;
			}
			set
			{
				this.post_Acquisition_AdjustmentField = value;
				this.RaisePropertyChanged("Post_Acquisition_Adjustment");
			}
		}

		[XmlIgnore]
		public bool Post_Acquisition_AdjustmentSpecified
		{
			get
			{
				return this.post_Acquisition_AdjustmentFieldSpecified;
			}
			set
			{
				this.post_Acquisition_AdjustmentFieldSpecified = value;
				this.RaisePropertyChanged("Post_Acquisition_AdjustmentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Adjustment_Amount
		{
			get
			{
				return this.adjustment_AmountField;
			}
			set
			{
				this.adjustment_AmountField = value;
				this.RaisePropertyChanged("Adjustment_Amount");
			}
		}

		[XmlIgnore]
		public bool Adjustment_AmountSpecified
		{
			get
			{
				return this.adjustment_AmountFieldSpecified;
			}
			set
			{
				this.adjustment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Adjustment_Quantity
		{
			get
			{
				return this.adjustment_QuantityField;
			}
			set
			{
				this.adjustment_QuantityField = value;
				this.RaisePropertyChanged("Adjustment_Quantity");
			}
		}

		[XmlIgnore]
		public bool Adjustment_QuantitySpecified
		{
			get
			{
				return this.adjustment_QuantityFieldSpecified;
			}
			set
			{
				this.adjustment_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Adjustment_Residual_Value
		{
			get
			{
				return this.adjustment_Residual_ValueField;
			}
			set
			{
				this.adjustment_Residual_ValueField = value;
				this.RaisePropertyChanged("Adjustment_Residual_Value");
			}
		}

		[XmlIgnore]
		public bool Adjustment_Residual_ValueSpecified
		{
			get
			{
				return this.adjustment_Residual_ValueFieldSpecified;
			}
			set
			{
				this.adjustment_Residual_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_Residual_ValueSpecified");
			}
		}

		[XmlElement("Accounting_Date", DataType = "date", Order = 5)]
		public DateTime Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Restricted_to_Books_Reference", Order = 6)]
		public Asset_BookObjectType[] Restricted_to_Books_Reference
		{
			get
			{
				return this.restricted_to_Books_ReferenceField;
			}
			set
			{
				this.restricted_to_Books_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Books_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Asset_Cost_Adjustment_ReasonObjectType Adjustment_Reason_Reference
		{
			get
			{
				return this.adjustment_Reason_ReferenceField;
			}
			set
			{
				this.adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reason_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Supplier_Invoice_Line_Reference_ID
		{
			get
			{
				return this.supplier_Invoice_Line_Reference_IDField;
			}
			set
			{
				this.supplier_Invoice_Line_Reference_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Line_Reference_ID");
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
