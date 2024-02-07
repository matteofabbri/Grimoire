using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_Transfer_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime transaction_DateField;

		private string statusField;

		private GiftObjectType source_Gift_ReferenceField;

		private GiftObjectType destination_Gift_ReferenceField;

		private Investment_PoolObjectType investment_Pool_ReferenceField;

		private Unique_IdentifierObjectType investment_Pool_Valuation_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private decimal total_Units_TransferredField;

		private bool total_Units_TransferredFieldSpecified;

		private decimal fair_Market_ValueField;

		private bool fair_Market_ValueFieldSpecified;

		private decimal net_Book_ValueField;

		private bool net_Book_ValueFieldSpecified;

		private Unique_IdentifierObjectType unit_Selection_Method_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Investment_Pool_Transfer_Line_DataType[] unit_Source_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(Order = 2)]
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		[XmlElement(Order = 3)]
		public GiftObjectType Source_Gift_Reference
		{
			get
			{
				return this.source_Gift_ReferenceField;
			}
			set
			{
				this.source_Gift_ReferenceField = value;
				this.RaisePropertyChanged("Source_Gift_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public GiftObjectType Destination_Gift_Reference
		{
			get
			{
				return this.destination_Gift_ReferenceField;
			}
			set
			{
				this.destination_Gift_ReferenceField = value;
				this.RaisePropertyChanged("Destination_Gift_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Investment_PoolObjectType Investment_Pool_Reference
		{
			get
			{
				return this.investment_Pool_ReferenceField;
			}
			set
			{
				this.investment_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Investment_Pool_Valuation_Reference
		{
			get
			{
				return this.investment_Pool_Valuation_ReferenceField;
			}
			set
			{
				this.investment_Pool_Valuation_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Valuation_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
		public decimal Total_Units_Transferred
		{
			get
			{
				return this.total_Units_TransferredField;
			}
			set
			{
				this.total_Units_TransferredField = value;
				this.RaisePropertyChanged("Total_Units_Transferred");
			}
		}

		[XmlIgnore]
		public bool Total_Units_TransferredSpecified
		{
			get
			{
				return this.total_Units_TransferredFieldSpecified;
			}
			set
			{
				this.total_Units_TransferredFieldSpecified = value;
				this.RaisePropertyChanged("Total_Units_TransferredSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Fair_Market_Value
		{
			get
			{
				return this.fair_Market_ValueField;
			}
			set
			{
				this.fair_Market_ValueField = value;
				this.RaisePropertyChanged("Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Fair_Market_ValueSpecified
		{
			get
			{
				return this.fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Net_Book_Value
		{
			get
			{
				return this.net_Book_ValueField;
			}
			set
			{
				this.net_Book_ValueField = value;
				this.RaisePropertyChanged("Net_Book_Value");
			}
		}

		[XmlIgnore]
		public bool Net_Book_ValueSpecified
		{
			get
			{
				return this.net_Book_ValueFieldSpecified;
			}
			set
			{
				this.net_Book_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Net_Book_ValueSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public Unique_IdentifierObjectType Unit_Selection_Method_Reference
		{
			get
			{
				return this.unit_Selection_Method_ReferenceField;
			}
			set
			{
				this.unit_Selection_Method_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Selection_Method_Reference");
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

		[XmlElement("Unit_Source_Data", Order = 14)]
		public Investment_Pool_Transfer_Line_DataType[] Unit_Source_Data
		{
			get
			{
				return this.unit_Source_DataField;
			}
			set
			{
				this.unit_Source_DataField = value;
				this.RaisePropertyChanged("Unit_Source_Data");
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
