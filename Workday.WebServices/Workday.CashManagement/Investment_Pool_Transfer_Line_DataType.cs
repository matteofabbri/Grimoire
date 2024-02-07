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
	public class Investment_Pool_Transfer_Line_DataType : INotifyPropertyChanged
	{
		private Investment_Pool_TransactionObjectType investment_Pool_Transaction_ReferenceField;

		private Donor_ContributionObjectType donor_Contribution_ReferenceField;

		private string typeField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private decimal unitsField;

		private bool unitsFieldSpecified;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal amount_WithdrawnField;

		private bool amount_WithdrawnFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Investment_Pool_TransactionObjectType Investment_Pool_Transaction_Reference
		{
			get
			{
				return this.investment_Pool_Transaction_ReferenceField;
			}
			set
			{
				this.investment_Pool_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Transaction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Donor_ContributionObjectType Donor_Contribution_Reference
		{
			get
			{
				return this.donor_Contribution_ReferenceField;
			}
			set
			{
				this.donor_Contribution_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Contribution_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Units
		{
			get
			{
				return this.unitsField;
			}
			set
			{
				this.unitsField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		[XmlIgnore]
		public bool UnitsSpecified
		{
			get
			{
				return this.unitsFieldSpecified;
			}
			set
			{
				this.unitsFieldSpecified = value;
				this.RaisePropertyChanged("UnitsSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Amount_Withdrawn
		{
			get
			{
				return this.amount_WithdrawnField;
			}
			set
			{
				this.amount_WithdrawnField = value;
				this.RaisePropertyChanged("Amount_Withdrawn");
			}
		}

		[XmlIgnore]
		public bool Amount_WithdrawnSpecified
		{
			get
			{
				return this.amount_WithdrawnFieldSpecified;
			}
			set
			{
				this.amount_WithdrawnFieldSpecified = value;
				this.RaisePropertyChanged("Amount_WithdrawnSpecified");
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
