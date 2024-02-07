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
	public class Invoicing_Schedule_Line_for_Opportunity_Line_DataType : INotifyPropertyChanged
	{
		private DateTime recurring_Schedule_DateField;

		private string recurring_Schedule_CommentField;

		private decimal billing_Schedule_Line_QuantityField;

		private bool billing_Schedule_Line_QuantityFieldSpecified;

		private decimal billing_Schedule_Line_AmountField;

		private bool billing_Schedule_Line_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Recurring_Schedule_Date
		{
			get
			{
				return this.recurring_Schedule_DateField;
			}
			set
			{
				this.recurring_Schedule_DateField = value;
				this.RaisePropertyChanged("Recurring_Schedule_Date");
			}
		}

		[XmlElement(Order = 1)]
		public string Recurring_Schedule_Comment
		{
			get
			{
				return this.recurring_Schedule_CommentField;
			}
			set
			{
				this.recurring_Schedule_CommentField = value;
				this.RaisePropertyChanged("Recurring_Schedule_Comment");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Billing_Schedule_Line_Quantity
		{
			get
			{
				return this.billing_Schedule_Line_QuantityField;
			}
			set
			{
				this.billing_Schedule_Line_QuantityField = value;
				this.RaisePropertyChanged("Billing_Schedule_Line_Quantity");
			}
		}

		[XmlIgnore]
		public bool Billing_Schedule_Line_QuantitySpecified
		{
			get
			{
				return this.billing_Schedule_Line_QuantityFieldSpecified;
			}
			set
			{
				this.billing_Schedule_Line_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Billing_Schedule_Line_QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Billing_Schedule_Line_Amount
		{
			get
			{
				return this.billing_Schedule_Line_AmountField;
			}
			set
			{
				this.billing_Schedule_Line_AmountField = value;
				this.RaisePropertyChanged("Billing_Schedule_Line_Amount");
			}
		}

		[XmlIgnore]
		public bool Billing_Schedule_Line_AmountSpecified
		{
			get
			{
				return this.billing_Schedule_Line_AmountFieldSpecified;
			}
			set
			{
				this.billing_Schedule_Line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Billing_Schedule_Line_AmountSpecified");
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
