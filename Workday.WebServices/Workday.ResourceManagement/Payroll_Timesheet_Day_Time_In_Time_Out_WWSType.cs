using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Timesheet_Day_Time_In_Time_Out_WWSType : INotifyPropertyChanged
	{
		private DateTime dateField;

		private bool dateFieldSpecified;

		private Payroll_Timesheet_Day_Time_In_Time_Out_Hours_WWSType[] payroll_Timesheet_Day_Time_In_Time_Out_HoursField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlIgnore]
		public bool DateSpecified
		{
			get
			{
				return this.dateFieldSpecified;
			}
			set
			{
				this.dateFieldSpecified = value;
				this.RaisePropertyChanged("DateSpecified");
			}
		}

		[XmlElement("Payroll_Timesheet_Day_Time_In_Time_Out_Hours", Order = 1)]
		public Payroll_Timesheet_Day_Time_In_Time_Out_Hours_WWSType[] Payroll_Timesheet_Day_Time_In_Time_Out_Hours
		{
			get
			{
				return this.payroll_Timesheet_Day_Time_In_Time_Out_HoursField;
			}
			set
			{
				this.payroll_Timesheet_Day_Time_In_Time_Out_HoursField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Day_Time_In_Time_Out_Hours");
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
