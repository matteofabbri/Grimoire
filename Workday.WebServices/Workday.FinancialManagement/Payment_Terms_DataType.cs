using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Terms_DataType : INotifyPropertyChanged
	{
		private string payment_Terms_IDField;

		private string payment_Terms_NameField;

		private decimal due_DaysField;

		private bool due_DaysFieldSpecified;

		private decimal payment_Discount_DaysField;

		private bool payment_Discount_DaysFieldSpecified;

		private decimal payment_Discount_PercentField;

		private bool payment_Discount_PercentFieldSpecified;

		private decimal grace_DaysField;

		private bool grace_DaysFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_Terms_ID
		{
			get
			{
				return this.payment_Terms_IDField;
			}
			set
			{
				this.payment_Terms_IDField = value;
				this.RaisePropertyChanged("Payment_Terms_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Payment_Terms_Name
		{
			get
			{
				return this.payment_Terms_NameField;
			}
			set
			{
				this.payment_Terms_NameField = value;
				this.RaisePropertyChanged("Payment_Terms_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Due_Days
		{
			get
			{
				return this.due_DaysField;
			}
			set
			{
				this.due_DaysField = value;
				this.RaisePropertyChanged("Due_Days");
			}
		}

		[XmlIgnore]
		public bool Due_DaysSpecified
		{
			get
			{
				return this.due_DaysFieldSpecified;
			}
			set
			{
				this.due_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Due_DaysSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Payment_Discount_Days
		{
			get
			{
				return this.payment_Discount_DaysField;
			}
			set
			{
				this.payment_Discount_DaysField = value;
				this.RaisePropertyChanged("Payment_Discount_Days");
			}
		}

		[XmlIgnore]
		public bool Payment_Discount_DaysSpecified
		{
			get
			{
				return this.payment_Discount_DaysFieldSpecified;
			}
			set
			{
				this.payment_Discount_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Discount_DaysSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Payment_Discount_Percent
		{
			get
			{
				return this.payment_Discount_PercentField;
			}
			set
			{
				this.payment_Discount_PercentField = value;
				this.RaisePropertyChanged("Payment_Discount_Percent");
			}
		}

		[XmlIgnore]
		public bool Payment_Discount_PercentSpecified
		{
			get
			{
				return this.payment_Discount_PercentFieldSpecified;
			}
			set
			{
				this.payment_Discount_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Discount_PercentSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Grace_Days
		{
			get
			{
				return this.grace_DaysField;
			}
			set
			{
				this.grace_DaysField = value;
				this.RaisePropertyChanged("Grace_Days");
			}
		}

		[XmlIgnore]
		public bool Grace_DaysSpecified
		{
			get
			{
				return this.grace_DaysFieldSpecified;
			}
			set
			{
				this.grace_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Grace_DaysSpecified");
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
