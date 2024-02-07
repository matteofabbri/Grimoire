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
	public class Run_Pay_Calculation_Process_HistoryType : INotifyPropertyChanged
	{
		private DateTime actual_Start_Date_and_TimeField;

		private bool actual_Start_Date_and_TimeFieldSpecified;

		private DateTime completed_Date_and_TimeField;

		private bool completed_Date_and_TimeFieldSpecified;

		private string total_Processing_Time__hour_min_sec_Field;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Actual_Start_Date_and_Time
		{
			get
			{
				return this.actual_Start_Date_and_TimeField;
			}
			set
			{
				this.actual_Start_Date_and_TimeField = value;
				this.RaisePropertyChanged("Actual_Start_Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Actual_Start_Date_and_TimeSpecified
		{
			get
			{
				return this.actual_Start_Date_and_TimeFieldSpecified;
			}
			set
			{
				this.actual_Start_Date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Start_Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Completed_Date_and_Time
		{
			get
			{
				return this.completed_Date_and_TimeField;
			}
			set
			{
				this.completed_Date_and_TimeField = value;
				this.RaisePropertyChanged("Completed_Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Completed_Date_and_TimeSpecified
		{
			get
			{
				return this.completed_Date_and_TimeFieldSpecified;
			}
			set
			{
				this.completed_Date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Completed_Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Total_Processing_Time__hour_min_sec_
		{
			get
			{
				return this.total_Processing_Time__hour_min_sec_Field;
			}
			set
			{
				this.total_Processing_Time__hour_min_sec_Field = value;
				this.RaisePropertyChanged("Total_Processing_Time__hour_min_sec_");
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
