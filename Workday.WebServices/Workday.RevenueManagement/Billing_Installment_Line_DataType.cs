using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Billing_Installment_Line_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private bool overrride_LineField;

		private bool overrride_LineFieldSpecified;

		private Installment_ItemObjectType contract_Line_ReferenceField;

		private string line_Item_DescriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantity_2Field;

		private bool quantity_2FieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_2_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal amountField;

		private bool amountFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private Tax_ApplicabilityObjectType[] tax_Applicability_ReferenceField;

		private Tax_CodeObjectType[] tax_Code_ReferenceField;

		private bool deferred_RevenueField;

		private bool deferred_RevenueFieldSpecified;

		private string memoField;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public bool Overrride_Line
		{
			get
			{
				return this.overrride_LineField;
			}
			set
			{
				this.overrride_LineField = value;
				this.RaisePropertyChanged("Overrride_Line");
			}
		}

		[XmlIgnore]
		public bool Overrride_LineSpecified
		{
			get
			{
				return this.overrride_LineFieldSpecified;
			}
			set
			{
				this.overrride_LineFieldSpecified = value;
				this.RaisePropertyChanged("Overrride_LineSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Installment_ItemObjectType Contract_Line_Reference
		{
			get
			{
				return this.contract_Line_ReferenceField;
			}
			set
			{
				this.contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Quantity_2
		{
			get
			{
				return this.quantity_2Field;
			}
			set
			{
				this.quantity_2Field = value;
				this.RaisePropertyChanged("Quantity_2");
			}
		}

		[XmlIgnore]
		public bool Quantity_2Specified
		{
			get
			{
				return this.quantity_2FieldSpecified;
			}
			set
			{
				this.quantity_2FieldSpecified = value;
				this.RaisePropertyChanged("Quantity_2Specified");
			}
		}

		[XmlElement(Order = 7)]
		public Unit_of_MeasureObjectType Unit_of_Measure_2_Reference
		{
			get
			{
				return this.unit_of_Measure_2_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_2_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_2_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(DataType = "date", Order = 11)]
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

		[XmlElement("Tax_Applicability_Reference", Order = 12)]
		public Tax_ApplicabilityObjectType[] Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement("Tax_Code_Reference", Order = 13)]
		public Tax_CodeObjectType[] Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Deferred_Revenue
		{
			get
			{
				return this.deferred_RevenueField;
			}
			set
			{
				this.deferred_RevenueField = value;
				this.RaisePropertyChanged("Deferred_Revenue");
			}
		}

		[XmlIgnore]
		public bool Deferred_RevenueSpecified
		{
			get
			{
				return this.deferred_RevenueFieldSpecified;
			}
			set
			{
				this.deferred_RevenueFieldSpecified = value;
				this.RaisePropertyChanged("Deferred_RevenueSpecified");
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

		[XmlElement("Worktags_Reference", Order = 16)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
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
