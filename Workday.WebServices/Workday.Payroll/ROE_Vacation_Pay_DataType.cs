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
	public class ROE_Vacation_Pay_DataType : INotifyPropertyChanged
	{
		private string vacation_Pay_CodeField;

		private DateTime vacation_Pay_Start_DateField;

		private bool vacation_Pay_Start_DateFieldSpecified;

		private DateTime vacation_Pay_End_DateField;

		private bool vacation_Pay_End_DateFieldSpecified;

		private decimal vacation_Pay_AmountField;

		private bool vacation_Pay_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Vacation_Pay_Code
		{
			get
			{
				return this.vacation_Pay_CodeField;
			}
			set
			{
				this.vacation_Pay_CodeField = value;
				this.RaisePropertyChanged("Vacation_Pay_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Vacation_Pay_Start_Date
		{
			get
			{
				return this.vacation_Pay_Start_DateField;
			}
			set
			{
				this.vacation_Pay_Start_DateField = value;
				this.RaisePropertyChanged("Vacation_Pay_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Vacation_Pay_Start_DateSpecified
		{
			get
			{
				return this.vacation_Pay_Start_DateFieldSpecified;
			}
			set
			{
				this.vacation_Pay_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vacation_Pay_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Vacation_Pay_End_Date
		{
			get
			{
				return this.vacation_Pay_End_DateField;
			}
			set
			{
				this.vacation_Pay_End_DateField = value;
				this.RaisePropertyChanged("Vacation_Pay_End_Date");
			}
		}

		[XmlIgnore]
		public bool Vacation_Pay_End_DateSpecified
		{
			get
			{
				return this.vacation_Pay_End_DateFieldSpecified;
			}
			set
			{
				this.vacation_Pay_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vacation_Pay_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Vacation_Pay_Amount
		{
			get
			{
				return this.vacation_Pay_AmountField;
			}
			set
			{
				this.vacation_Pay_AmountField = value;
				this.RaisePropertyChanged("Vacation_Pay_Amount");
			}
		}

		[XmlIgnore]
		public bool Vacation_Pay_AmountSpecified
		{
			get
			{
				return this.vacation_Pay_AmountFieldSpecified;
			}
			set
			{
				this.vacation_Pay_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Vacation_Pay_AmountSpecified");
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
