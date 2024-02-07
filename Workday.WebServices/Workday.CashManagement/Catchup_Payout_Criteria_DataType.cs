using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Catch-up_Payout_Criteria_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Catchup_Payout_Criteria_DataType : INotifyPropertyChanged
	{
		private Investment_PoolObjectType investment_Pool_ReferenceField;

		private DateTime transaction_DateField;

		private GiftObjectType[] gift_ReferenceField;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private Fiscal_YearObjectType fiscal_Year_ReferenceField;

		private decimal payout_per_unitField;

		private decimal administrative_fee_per_unitField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Gift_Reference", Order = 2)]
		public GiftObjectType[] Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Fiscal_Time_IntervalObjectType Fiscal_Time_Interval_Reference
		{
			get
			{
				return this.fiscal_Time_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Time_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Time_Interval_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Fiscal_YearObjectType Fiscal_Year_Reference
		{
			get
			{
				return this.fiscal_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Year_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Payout_per_unit
		{
			get
			{
				return this.payout_per_unitField;
			}
			set
			{
				this.payout_per_unitField = value;
				this.RaisePropertyChanged("Payout_per_unit");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Administrative_fee_per_unit
		{
			get
			{
				return this.administrative_fee_per_unitField;
			}
			set
			{
				this.administrative_fee_per_unitField = value;
				this.RaisePropertyChanged("Administrative_fee_per_unit");
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
