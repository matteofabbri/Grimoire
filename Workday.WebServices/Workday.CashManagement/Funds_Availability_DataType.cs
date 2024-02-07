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
	public class Funds_Availability_DataType : INotifyPropertyChanged
	{
		private decimal amountField;

		private bool amountFieldSpecified;

		private DateTime availability_Date_TimeField;

		private bool availability_Date_TimeFieldSpecified;

		private decimal number_of_Days_until_AvailableField;

		private bool number_of_Days_until_AvailableFieldSpecified;

		private bool unknown_Number_of_DaysField;

		private bool unknown_Number_of_DaysFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public DateTime Availability_Date_Time
		{
			get
			{
				return this.availability_Date_TimeField;
			}
			set
			{
				this.availability_Date_TimeField = value;
				this.RaisePropertyChanged("Availability_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Availability_Date_TimeSpecified
		{
			get
			{
				return this.availability_Date_TimeFieldSpecified;
			}
			set
			{
				this.availability_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Availability_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_of_Days_until_Available
		{
			get
			{
				return this.number_of_Days_until_AvailableField;
			}
			set
			{
				this.number_of_Days_until_AvailableField = value;
				this.RaisePropertyChanged("Number_of_Days_until_Available");
			}
		}

		[XmlIgnore]
		public bool Number_of_Days_until_AvailableSpecified
		{
			get
			{
				return this.number_of_Days_until_AvailableFieldSpecified;
			}
			set
			{
				this.number_of_Days_until_AvailableFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Days_until_AvailableSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Unknown_Number_of_Days
		{
			get
			{
				return this.unknown_Number_of_DaysField;
			}
			set
			{
				this.unknown_Number_of_DaysField = value;
				this.RaisePropertyChanged("Unknown_Number_of_Days");
			}
		}

		[XmlIgnore]
		public bool Unknown_Number_of_DaysSpecified
		{
			get
			{
				return this.unknown_Number_of_DaysFieldSpecified;
			}
			set
			{
				this.unknown_Number_of_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Unknown_Number_of_DaysSpecified");
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
