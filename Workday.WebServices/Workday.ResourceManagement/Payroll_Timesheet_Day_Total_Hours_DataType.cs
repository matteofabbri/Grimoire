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
	public class Payroll_Timesheet_Day_Total_Hours_DataType : INotifyPropertyChanged
	{
		private DateTime timesheet_Day_DateField;

		private decimal hours_WorkedField;

		private bool hours_WorkedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Timesheet_Day_Date
		{
			get
			{
				return this.timesheet_Day_DateField;
			}
			set
			{
				this.timesheet_Day_DateField = value;
				this.RaisePropertyChanged("Timesheet_Day_Date");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Hours_Worked
		{
			get
			{
				return this.hours_WorkedField;
			}
			set
			{
				this.hours_WorkedField = value;
				this.RaisePropertyChanged("Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Hours_WorkedSpecified
		{
			get
			{
				return this.hours_WorkedFieldSpecified;
			}
			set
			{
				this.hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Hours_WorkedSpecified");
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
