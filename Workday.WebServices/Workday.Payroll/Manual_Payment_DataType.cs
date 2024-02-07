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
	public class Manual_Payment_DataType : INotifyPropertyChanged
	{
		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private decimal net_AmountField;

		private bool net_AmountFieldSpecified;

		private string check_NumberField;

		private Bank_AccountObjectType bank_Account_ReferenceField;

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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Check_Number
		{
			get
			{
				return this.check_NumberField;
			}
			set
			{
				this.check_NumberField = value;
				this.RaisePropertyChanged("Check_Number");
			}
		}

		[XmlElement(Order = 3)]
		public Bank_AccountObjectType Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
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
