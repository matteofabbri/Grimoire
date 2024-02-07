using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class History_Payment_DataType : INotifyPropertyChanged
	{
		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private DateTime payment_DateField;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		private decimal net_AmountField;

		private bool net_AmountFieldSpecified;

		private DateTime subPeriod_Start_DateField;

		private bool subPeriod_Start_DateFieldSpecified;

		private DateTime subPeriod_End_DateField;

		private bool subPeriod_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Gross_Amount
		{
			get
			{
				return this.gross_AmountField;
			}
			set
			{
				this.gross_AmountField = value;
				this.RaisePropertyChanged("Gross_Amount");
			}
		}

		[XmlIgnore]
		public bool Gross_AmountSpecified
		{
			get
			{
				return this.gross_AmountFieldSpecified;
			}
			set
			{
				this.gross_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Gross_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Net_Amount
		{
			get
			{
				return this.net_AmountField;
			}
			set
			{
				this.net_AmountField = value;
				this.RaisePropertyChanged("Net_Amount");
			}
		}

		[XmlIgnore]
		public bool Net_AmountSpecified
		{
			get
			{
				return this.net_AmountFieldSpecified;
			}
			set
			{
				this.net_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Net_AmountSpecified");
			}
		}

		[XmlElement("Sub-Period_Start_Date", DataType = "date", Order = 4)]
		public DateTime SubPeriod_Start_Date
		{
			get
			{
				return this.subPeriod_Start_DateField;
			}
			set
			{
				this.subPeriod_Start_DateField = value;
				this.RaisePropertyChanged("SubPeriod_Start_Date");
			}
		}

		[XmlIgnore]
		public bool SubPeriod_Start_DateSpecified
		{
			get
			{
				return this.subPeriod_Start_DateFieldSpecified;
			}
			set
			{
				this.subPeriod_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("SubPeriod_Start_DateSpecified");
			}
		}

		[XmlElement("Sub-Period_End_Date", DataType = "date", Order = 5)]
		public DateTime SubPeriod_End_Date
		{
			get
			{
				return this.subPeriod_End_DateField;
			}
			set
			{
				this.subPeriod_End_DateField = value;
				this.RaisePropertyChanged("SubPeriod_End_Date");
			}
		}

		[XmlIgnore]
		public bool SubPeriod_End_DateSpecified
		{
			get
			{
				return this.subPeriod_End_DateFieldSpecified;
			}
			set
			{
				this.subPeriod_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("SubPeriod_End_DateSpecified");
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
