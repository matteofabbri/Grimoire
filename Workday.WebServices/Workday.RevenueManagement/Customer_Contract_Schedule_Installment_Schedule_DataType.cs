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
	public class Customer_Contract_Schedule_Installment_Schedule_DataType : INotifyPropertyChanged
	{
		private Customer_Installment_ItemObjectType line_ReferenceField;

		private decimal regular_Installment_AmountField;

		private bool regular_Installment_AmountFieldSpecified;

		private decimal first_Installment_AmountField;

		private bool first_Installment_AmountFieldSpecified;

		private decimal last_Installment_AmountField;

		private bool last_Installment_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Installment_ItemObjectType Line_Reference
		{
			get
			{
				return this.line_ReferenceField;
			}
			set
			{
				this.line_ReferenceField = value;
				this.RaisePropertyChanged("Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Regular_Installment_Amount
		{
			get
			{
				return this.regular_Installment_AmountField;
			}
			set
			{
				this.regular_Installment_AmountField = value;
				this.RaisePropertyChanged("Regular_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool Regular_Installment_AmountSpecified
		{
			get
			{
				return this.regular_Installment_AmountFieldSpecified;
			}
			set
			{
				this.regular_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Regular_Installment_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal First_Installment_Amount
		{
			get
			{
				return this.first_Installment_AmountField;
			}
			set
			{
				this.first_Installment_AmountField = value;
				this.RaisePropertyChanged("First_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool First_Installment_AmountSpecified
		{
			get
			{
				return this.first_Installment_AmountFieldSpecified;
			}
			set
			{
				this.first_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("First_Installment_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Last_Installment_Amount
		{
			get
			{
				return this.last_Installment_AmountField;
			}
			set
			{
				this.last_Installment_AmountField = value;
				this.RaisePropertyChanged("Last_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool Last_Installment_AmountSpecified
		{
			get
			{
				return this.last_Installment_AmountFieldSpecified;
			}
			set
			{
				this.last_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Last_Installment_AmountSpecified");
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
