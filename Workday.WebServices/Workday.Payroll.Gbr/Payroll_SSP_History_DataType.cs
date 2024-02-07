using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_SSP_History_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private decimal average_Weekly_EarningsField;

		private bool average_Weekly_EarningsFieldSpecified;

		private bool sSP_Absence_HistoryField;

		private bool sSP_Absence_HistoryFieldSpecified;

		private DateTime last_PIW_Start_DateField;

		private bool last_PIW_Start_DateFieldSpecified;

		private DateTime last_PIW_End_DateField;

		private bool last_PIW_End_DateFieldSpecified;

		private decimal total_Number_of_Waiting_DaysField;

		private bool total_Number_of_Waiting_DaysFieldSpecified;

		private decimal total_Number_of_Payment_Days_for_SSPField;

		private bool total_Number_of_Payment_Days_for_SSPFieldSpecified;

		private decimal number_of_SSP_Weeks_TakenField;

		private bool number_of_SSP_Weeks_TakenFieldSpecified;

		private decimal number_of_SSP_Days_TakenField;

		private bool number_of_SSP_Days_TakenFieldSpecified;

		private DateTime first_Day_of_SSPField;

		private bool first_Day_of_SSPFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Average_Weekly_Earnings
		{
			get
			{
				return this.average_Weekly_EarningsField;
			}
			set
			{
				this.average_Weekly_EarningsField = value;
				this.RaisePropertyChanged("Average_Weekly_Earnings");
			}
		}

		[XmlIgnore]
		public bool Average_Weekly_EarningsSpecified
		{
			get
			{
				return this.average_Weekly_EarningsFieldSpecified;
			}
			set
			{
				this.average_Weekly_EarningsFieldSpecified = value;
				this.RaisePropertyChanged("Average_Weekly_EarningsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool SSP_Absence_History
		{
			get
			{
				return this.sSP_Absence_HistoryField;
			}
			set
			{
				this.sSP_Absence_HistoryField = value;
				this.RaisePropertyChanged("SSP_Absence_History");
			}
		}

		[XmlIgnore]
		public bool SSP_Absence_HistorySpecified
		{
			get
			{
				return this.sSP_Absence_HistoryFieldSpecified;
			}
			set
			{
				this.sSP_Absence_HistoryFieldSpecified = value;
				this.RaisePropertyChanged("SSP_Absence_HistorySpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Last_PIW_Start_Date
		{
			get
			{
				return this.last_PIW_Start_DateField;
			}
			set
			{
				this.last_PIW_Start_DateField = value;
				this.RaisePropertyChanged("Last_PIW_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Last_PIW_Start_DateSpecified
		{
			get
			{
				return this.last_PIW_Start_DateFieldSpecified;
			}
			set
			{
				this.last_PIW_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_PIW_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Last_PIW_End_Date
		{
			get
			{
				return this.last_PIW_End_DateField;
			}
			set
			{
				this.last_PIW_End_DateField = value;
				this.RaisePropertyChanged("Last_PIW_End_Date");
			}
		}

		[XmlIgnore]
		public bool Last_PIW_End_DateSpecified
		{
			get
			{
				return this.last_PIW_End_DateFieldSpecified;
			}
			set
			{
				this.last_PIW_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_PIW_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Total_Number_of_Waiting_Days
		{
			get
			{
				return this.total_Number_of_Waiting_DaysField;
			}
			set
			{
				this.total_Number_of_Waiting_DaysField = value;
				this.RaisePropertyChanged("Total_Number_of_Waiting_Days");
			}
		}

		[XmlIgnore]
		public bool Total_Number_of_Waiting_DaysSpecified
		{
			get
			{
				return this.total_Number_of_Waiting_DaysFieldSpecified;
			}
			set
			{
				this.total_Number_of_Waiting_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Total_Number_of_Waiting_DaysSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Total_Number_of_Payment_Days_for_SSP
		{
			get
			{
				return this.total_Number_of_Payment_Days_for_SSPField;
			}
			set
			{
				this.total_Number_of_Payment_Days_for_SSPField = value;
				this.RaisePropertyChanged("Total_Number_of_Payment_Days_for_SSP");
			}
		}

		[XmlIgnore]
		public bool Total_Number_of_Payment_Days_for_SSPSpecified
		{
			get
			{
				return this.total_Number_of_Payment_Days_for_SSPFieldSpecified;
			}
			set
			{
				this.total_Number_of_Payment_Days_for_SSPFieldSpecified = value;
				this.RaisePropertyChanged("Total_Number_of_Payment_Days_for_SSPSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Number_of_SSP_Weeks_Taken
		{
			get
			{
				return this.number_of_SSP_Weeks_TakenField;
			}
			set
			{
				this.number_of_SSP_Weeks_TakenField = value;
				this.RaisePropertyChanged("Number_of_SSP_Weeks_Taken");
			}
		}

		[XmlIgnore]
		public bool Number_of_SSP_Weeks_TakenSpecified
		{
			get
			{
				return this.number_of_SSP_Weeks_TakenFieldSpecified;
			}
			set
			{
				this.number_of_SSP_Weeks_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_SSP_Weeks_TakenSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Number_of_SSP_Days_Taken
		{
			get
			{
				return this.number_of_SSP_Days_TakenField;
			}
			set
			{
				this.number_of_SSP_Days_TakenField = value;
				this.RaisePropertyChanged("Number_of_SSP_Days_Taken");
			}
		}

		[XmlIgnore]
		public bool Number_of_SSP_Days_TakenSpecified
		{
			get
			{
				return this.number_of_SSP_Days_TakenFieldSpecified;
			}
			set
			{
				this.number_of_SSP_Days_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_SSP_Days_TakenSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime First_Day_of_SSP
		{
			get
			{
				return this.first_Day_of_SSPField;
			}
			set
			{
				this.first_Day_of_SSPField = value;
				this.RaisePropertyChanged("First_Day_of_SSP");
			}
		}

		[XmlIgnore]
		public bool First_Day_of_SSPSpecified
		{
			get
			{
				return this.first_Day_of_SSPFieldSpecified;
			}
			set
			{
				this.first_Day_of_SSPFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_of_SSPSpecified");
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
