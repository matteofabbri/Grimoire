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
	public class Canadian_Record_of_Employment_Paid_Sick_Leave__Maternity_and_Wage_Loss_Detail_DataType : INotifyPropertyChanged
	{
		private string rOE_Special_Payment_CodeField;

		private DateTime special_Payment_DateField;

		private bool special_Payment_DateFieldSpecified;

		private DateTime special_Payment_Start_DateField;

		private bool special_Payment_Start_DateFieldSpecified;

		private DateTime special_Payment_End_DateField;

		private bool special_Payment_End_DateFieldSpecified;

		private decimal special_Payment_AmountField;

		private bool special_Payment_AmountFieldSpecified;

		private bool per_DayField;

		private bool per_DayFieldSpecified;

		private bool per_WeekField;

		private bool per_WeekFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ROE_Special_Payment_Code
		{
			get
			{
				return this.rOE_Special_Payment_CodeField;
			}
			set
			{
				this.rOE_Special_Payment_CodeField = value;
				this.RaisePropertyChanged("ROE_Special_Payment_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Special_Payment_Date
		{
			get
			{
				return this.special_Payment_DateField;
			}
			set
			{
				this.special_Payment_DateField = value;
				this.RaisePropertyChanged("Special_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Special_Payment_DateSpecified
		{
			get
			{
				return this.special_Payment_DateFieldSpecified;
			}
			set
			{
				this.special_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Special_Payment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Special_Payment_Start_Date
		{
			get
			{
				return this.special_Payment_Start_DateField;
			}
			set
			{
				this.special_Payment_Start_DateField = value;
				this.RaisePropertyChanged("Special_Payment_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Special_Payment_Start_DateSpecified
		{
			get
			{
				return this.special_Payment_Start_DateFieldSpecified;
			}
			set
			{
				this.special_Payment_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Special_Payment_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Special_Payment_End_Date
		{
			get
			{
				return this.special_Payment_End_DateField;
			}
			set
			{
				this.special_Payment_End_DateField = value;
				this.RaisePropertyChanged("Special_Payment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Special_Payment_End_DateSpecified
		{
			get
			{
				return this.special_Payment_End_DateFieldSpecified;
			}
			set
			{
				this.special_Payment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Special_Payment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Special_Payment_Amount
		{
			get
			{
				return this.special_Payment_AmountField;
			}
			set
			{
				this.special_Payment_AmountField = value;
				this.RaisePropertyChanged("Special_Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Special_Payment_AmountSpecified
		{
			get
			{
				return this.special_Payment_AmountFieldSpecified;
			}
			set
			{
				this.special_Payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Special_Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Per_Day
		{
			get
			{
				return this.per_DayField;
			}
			set
			{
				this.per_DayField = value;
				this.RaisePropertyChanged("Per_Day");
			}
		}

		[XmlIgnore]
		public bool Per_DaySpecified
		{
			get
			{
				return this.per_DayFieldSpecified;
			}
			set
			{
				this.per_DayFieldSpecified = value;
				this.RaisePropertyChanged("Per_DaySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Per_Week
		{
			get
			{
				return this.per_WeekField;
			}
			set
			{
				this.per_WeekField = value;
				this.RaisePropertyChanged("Per_Week");
			}
		}

		[XmlIgnore]
		public bool Per_WeekSpecified
		{
			get
			{
				return this.per_WeekFieldSpecified;
			}
			set
			{
				this.per_WeekFieldSpecified = value;
				this.RaisePropertyChanged("Per_WeekSpecified");
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
