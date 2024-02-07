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
	public class Asset_Disposal_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private decimal disposal_CostField;

		private bool disposal_CostFieldSpecified;

		private decimal disposal_PercentField;

		private bool disposal_PercentFieldSpecified;

		private Asset_Disposal_TypeObjectType disposal_Type_ReferenceField;

		private decimal disposal_Fair_Market_ValueField;

		private bool disposal_Fair_Market_ValueFieldSpecified;

		private decimal sale_PriceField;

		private bool sale_PriceFieldSpecified;

		private decimal net_Book_Value_at_DisposalField;

		private bool net_Book_Value_at_DisposalFieldSpecified;

		private decimal disposal_GainField;

		private bool disposal_GainFieldSpecified;

		private decimal disposal_LossField;

		private bool disposal_LossFieldSpecified;

		private decimal donation_AmountField;

		private bool donation_AmountFieldSpecified;

		private string commentField;

		private Accounting_WorktagObjectType[] disposal_Worktags_ReferenceField;

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
		public decimal Disposal_Cost
		{
			get
			{
				return this.disposal_CostField;
			}
			set
			{
				this.disposal_CostField = value;
				this.RaisePropertyChanged("Disposal_Cost");
			}
		}

		[XmlIgnore]
		public bool Disposal_CostSpecified
		{
			get
			{
				return this.disposal_CostFieldSpecified;
			}
			set
			{
				this.disposal_CostFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_CostSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Disposal_Percent
		{
			get
			{
				return this.disposal_PercentField;
			}
			set
			{
				this.disposal_PercentField = value;
				this.RaisePropertyChanged("Disposal_Percent");
			}
		}

		[XmlIgnore]
		public bool Disposal_PercentSpecified
		{
			get
			{
				return this.disposal_PercentFieldSpecified;
			}
			set
			{
				this.disposal_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_PercentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Asset_Disposal_TypeObjectType Disposal_Type_Reference
		{
			get
			{
				return this.disposal_Type_ReferenceField;
			}
			set
			{
				this.disposal_Type_ReferenceField = value;
				this.RaisePropertyChanged("Disposal_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Disposal_Fair_Market_Value
		{
			get
			{
				return this.disposal_Fair_Market_ValueField;
			}
			set
			{
				this.disposal_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Disposal_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Disposal_Fair_Market_ValueSpecified
		{
			get
			{
				return this.disposal_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.disposal_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Sale_Price
		{
			get
			{
				return this.sale_PriceField;
			}
			set
			{
				this.sale_PriceField = value;
				this.RaisePropertyChanged("Sale_Price");
			}
		}

		[XmlIgnore]
		public bool Sale_PriceSpecified
		{
			get
			{
				return this.sale_PriceFieldSpecified;
			}
			set
			{
				this.sale_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Sale_PriceSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Net_Book_Value_at_Disposal
		{
			get
			{
				return this.net_Book_Value_at_DisposalField;
			}
			set
			{
				this.net_Book_Value_at_DisposalField = value;
				this.RaisePropertyChanged("Net_Book_Value_at_Disposal");
			}
		}

		[XmlIgnore]
		public bool Net_Book_Value_at_DisposalSpecified
		{
			get
			{
				return this.net_Book_Value_at_DisposalFieldSpecified;
			}
			set
			{
				this.net_Book_Value_at_DisposalFieldSpecified = value;
				this.RaisePropertyChanged("Net_Book_Value_at_DisposalSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Disposal_Gain
		{
			get
			{
				return this.disposal_GainField;
			}
			set
			{
				this.disposal_GainField = value;
				this.RaisePropertyChanged("Disposal_Gain");
			}
		}

		[XmlIgnore]
		public bool Disposal_GainSpecified
		{
			get
			{
				return this.disposal_GainFieldSpecified;
			}
			set
			{
				this.disposal_GainFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_GainSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Disposal_Loss
		{
			get
			{
				return this.disposal_LossField;
			}
			set
			{
				this.disposal_LossField = value;
				this.RaisePropertyChanged("Disposal_Loss");
			}
		}

		[XmlIgnore]
		public bool Disposal_LossSpecified
		{
			get
			{
				return this.disposal_LossFieldSpecified;
			}
			set
			{
				this.disposal_LossFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_LossSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Donation_Amount
		{
			get
			{
				return this.donation_AmountField;
			}
			set
			{
				this.donation_AmountField = value;
				this.RaisePropertyChanged("Donation_Amount");
			}
		}

		[XmlIgnore]
		public bool Donation_AmountSpecified
		{
			get
			{
				return this.donation_AmountFieldSpecified;
			}
			set
			{
				this.donation_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Donation_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement("Disposal_Worktags_Reference", Order = 11)]
		public Accounting_WorktagObjectType[] Disposal_Worktags_Reference
		{
			get
			{
				return this.disposal_Worktags_ReferenceField;
			}
			set
			{
				this.disposal_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Disposal_Worktags_Reference");
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
