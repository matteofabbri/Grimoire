using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Time_Off_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private decimal time_Off_PaidField;

		private bool time_Off_PaidFieldSpecified;

		private decimal time_Off_UnpaidField;

		private bool time_Off_UnpaidFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Start_DateSpecified
		{
			get
			{
				return this.period_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Time_Off_Paid
		{
			get
			{
				return this.time_Off_PaidField;
			}
			set
			{
				this.time_Off_PaidField = value;
				this.RaisePropertyChanged("Time_Off_Paid");
			}
		}

		[XmlIgnore]
		public bool Time_Off_PaidSpecified
		{
			get
			{
				return this.time_Off_PaidFieldSpecified;
			}
			set
			{
				this.time_Off_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_PaidSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Time_Off_Unpaid
		{
			get
			{
				return this.time_Off_UnpaidField;
			}
			set
			{
				this.time_Off_UnpaidField = value;
				this.RaisePropertyChanged("Time_Off_Unpaid");
			}
		}

		[XmlIgnore]
		public bool Time_Off_UnpaidSpecified
		{
			get
			{
				return this.time_Off_UnpaidFieldSpecified;
			}
			set
			{
				this.time_Off_UnpaidFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_UnpaidSpecified");
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
