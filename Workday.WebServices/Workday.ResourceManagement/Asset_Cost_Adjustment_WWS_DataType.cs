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
	public class Asset_Cost_Adjustment_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private decimal cost_Adjustment_AmountField;

		private bool cost_Adjustment_AmountFieldSpecified;

		private Asset_Cost_Adjustment_ReasonObjectType cost_Adjustment_Reason_ReferenceField;

		private decimal residual_Value_AdjustmentField;

		private bool residual_Value_AdjustmentFieldSpecified;

		private Business_Document_LineObjectType supplier_Invoice_Line_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
		public decimal Cost_Adjustment_Amount
		{
			get
			{
				return this.cost_Adjustment_AmountField;
			}
			set
			{
				this.cost_Adjustment_AmountField = value;
				this.RaisePropertyChanged("Cost_Adjustment_Amount");
			}
		}

		[XmlIgnore]
		public bool Cost_Adjustment_AmountSpecified
		{
			get
			{
				return this.cost_Adjustment_AmountFieldSpecified;
			}
			set
			{
				this.cost_Adjustment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Cost_Adjustment_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Asset_Cost_Adjustment_ReasonObjectType Cost_Adjustment_Reason_Reference
		{
			get
			{
				return this.cost_Adjustment_Reason_ReferenceField;
			}
			set
			{
				this.cost_Adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Adjustment_Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Residual_Value_Adjustment
		{
			get
			{
				return this.residual_Value_AdjustmentField;
			}
			set
			{
				this.residual_Value_AdjustmentField = value;
				this.RaisePropertyChanged("Residual_Value_Adjustment");
			}
		}

		[XmlIgnore]
		public bool Residual_Value_AdjustmentSpecified
		{
			get
			{
				return this.residual_Value_AdjustmentFieldSpecified;
			}
			set
			{
				this.residual_Value_AdjustmentFieldSpecified = value;
				this.RaisePropertyChanged("Residual_Value_AdjustmentSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Business_Document_LineObjectType Supplier_Invoice_Line_Reference
		{
			get
			{
				return this.supplier_Invoice_Line_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Line_Reference");
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
