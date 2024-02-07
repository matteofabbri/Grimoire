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
	public class Customer_Balance_DataType : INotifyPropertyChanged
	{
		private CurrencyObjectType default_Currency_ReferenceField;

		private decimal yTD_Sales_AmountField;

		private bool yTD_Sales_AmountFieldSpecified;

		private decimal total_BalanceField;

		private bool total_BalanceFieldSpecified;

		private decimal last_12_Months_Sales_AmountField;

		private bool last_12_Months_Sales_AmountFieldSpecified;

		private decimal overdue_BalanceField;

		private bool overdue_BalanceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CurrencyObjectType Default_Currency_Reference
		{
			get
			{
				return this.default_Currency_ReferenceField;
			}
			set
			{
				this.default_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Currency_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal YTD_Sales_Amount
		{
			get
			{
				return this.yTD_Sales_AmountField;
			}
			set
			{
				this.yTD_Sales_AmountField = value;
				this.RaisePropertyChanged("YTD_Sales_Amount");
			}
		}

		[XmlIgnore]
		public bool YTD_Sales_AmountSpecified
		{
			get
			{
				return this.yTD_Sales_AmountFieldSpecified;
			}
			set
			{
				this.yTD_Sales_AmountFieldSpecified = value;
				this.RaisePropertyChanged("YTD_Sales_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Total_Balance
		{
			get
			{
				return this.total_BalanceField;
			}
			set
			{
				this.total_BalanceField = value;
				this.RaisePropertyChanged("Total_Balance");
			}
		}

		[XmlIgnore]
		public bool Total_BalanceSpecified
		{
			get
			{
				return this.total_BalanceFieldSpecified;
			}
			set
			{
				this.total_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Total_BalanceSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Last_12_Months_Sales_Amount
		{
			get
			{
				return this.last_12_Months_Sales_AmountField;
			}
			set
			{
				this.last_12_Months_Sales_AmountField = value;
				this.RaisePropertyChanged("Last_12_Months_Sales_Amount");
			}
		}

		[XmlIgnore]
		public bool Last_12_Months_Sales_AmountSpecified
		{
			get
			{
				return this.last_12_Months_Sales_AmountFieldSpecified;
			}
			set
			{
				this.last_12_Months_Sales_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Last_12_Months_Sales_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Overdue_Balance
		{
			get
			{
				return this.overdue_BalanceField;
			}
			set
			{
				this.overdue_BalanceField = value;
				this.RaisePropertyChanged("Overdue_Balance");
			}
		}

		[XmlIgnore]
		public bool Overdue_BalanceSpecified
		{
			get
			{
				return this.overdue_BalanceFieldSpecified;
			}
			set
			{
				this.overdue_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Overdue_BalanceSpecified");
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
