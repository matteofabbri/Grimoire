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
	public class Percent_Complete_Line_DataType : INotifyPropertyChanged
	{
		private Percent_Complete_LineObjectType percent_Complete_Line_ReferenceField;

		private Receivable_Contract_Line_AbstractObjectType[] customer_Contract_Line_ReferenceField;

		private decimal contract_Line_AmountField;

		private bool contract_Line_AmountFieldSpecified;

		private CurrencyObjectType contract_Line_Currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Percent_Complete_LineObjectType Percent_Complete_Line_Reference
		{
			get
			{
				return this.percent_Complete_Line_ReferenceField;
			}
			set
			{
				this.percent_Complete_Line_ReferenceField = value;
				this.RaisePropertyChanged("Percent_Complete_Line_Reference");
			}
		}

		[XmlElement("Customer_Contract_Line_Reference", Order = 1)]
		public Receivable_Contract_Line_AbstractObjectType[] Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Contract_Line_Amount
		{
			get
			{
				return this.contract_Line_AmountField;
			}
			set
			{
				this.contract_Line_AmountField = value;
				this.RaisePropertyChanged("Contract_Line_Amount");
			}
		}

		[XmlIgnore]
		public bool Contract_Line_AmountSpecified
		{
			get
			{
				return this.contract_Line_AmountFieldSpecified;
			}
			set
			{
				this.contract_Line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Line_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Contract_Line_Currency_Reference
		{
			get
			{
				return this.contract_Line_Currency_ReferenceField;
			}
			set
			{
				this.contract_Line_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Currency_Reference");
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
