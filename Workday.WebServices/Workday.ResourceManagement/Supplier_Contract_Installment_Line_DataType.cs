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
	public class Supplier_Contract_Installment_Line_DataType : INotifyPropertyChanged
	{
		private Supplier_Contract_LineObjectType supplier_Contract_Line_ReferenceField;

		private string line_OrderField;

		private bool use_Line_OverridesField;

		private bool use_Line_OverridesFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private decimal retention_AmountField;

		private bool retention_AmountFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private string line_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_Contract_LineObjectType Supplier_Contract_Line_Reference
		{
			get
			{
				return this.supplier_Contract_Line_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
			}
		}

		[XmlElement(Order = 2)]
		public bool Use_Line_Overrides
		{
			get
			{
				return this.use_Line_OverridesField;
			}
			set
			{
				this.use_Line_OverridesField = value;
				this.RaisePropertyChanged("Use_Line_Overrides");
			}
		}

		[XmlIgnore]
		public bool Use_Line_OverridesSpecified
		{
			get
			{
				return this.use_Line_OverridesFieldSpecified;
			}
			set
			{
				this.use_Line_OverridesFieldSpecified = value;
				this.RaisePropertyChanged("Use_Line_OverridesSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Payment_Amount
		{
			get
			{
				return this.payment_AmountField;
			}
			set
			{
				this.payment_AmountField = value;
				this.RaisePropertyChanged("Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Payment_AmountSpecified
		{
			get
			{
				return this.payment_AmountFieldSpecified;
			}
			set
			{
				this.payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Total_Amount
		{
			get
			{
				return this.total_AmountField;
			}
			set
			{
				this.total_AmountField = value;
				this.RaisePropertyChanged("Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_AmountSpecified
		{
			get
			{
				return this.total_AmountFieldSpecified;
			}
			set
			{
				this.total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Retention_Amount
		{
			get
			{
				return this.retention_AmountField;
			}
			set
			{
				this.retention_AmountField = value;
				this.RaisePropertyChanged("Retention_Amount");
			}
		}

		[XmlIgnore]
		public bool Retention_AmountSpecified
		{
			get
			{
				return this.retention_AmountFieldSpecified;
			}
			set
			{
				this.retention_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Retention_AmountSpecified");
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
		public string Line_Description
		{
			get
			{
				return this.line_DescriptionField;
			}
			set
			{
				this.line_DescriptionField = value;
				this.RaisePropertyChanged("Line_Description");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement("Worktags_Reference", Order = 13)]
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
