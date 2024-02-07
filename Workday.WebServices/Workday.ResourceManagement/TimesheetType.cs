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
	public class TimesheetType : INotifyPropertyChanged
	{
		private TimesheetObjectType timesheet_ReferenceField;

		private Worker_Time_Card_WWS_DataType timesheet_DataField;

		private Timesheet_Daily_WWS_DataType[] timesheet_Daily_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public TimesheetObjectType Timesheet_Reference
		{
			get
			{
				return this.timesheet_ReferenceField;
			}
			set
			{
				this.timesheet_ReferenceField = value;
				this.RaisePropertyChanged("Timesheet_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Time_Card_WWS_DataType Timesheet_Data
		{
			get
			{
				return this.timesheet_DataField;
			}
			set
			{
				this.timesheet_DataField = value;
				this.RaisePropertyChanged("Timesheet_Data");
			}
		}

		[XmlElement("Timesheet_Daily_Data", Order = 2)]
		public Timesheet_Daily_WWS_DataType[] Timesheet_Daily_Data
		{
			get
			{
				return this.timesheet_Daily_DataField;
			}
			set
			{
				this.timesheet_Daily_DataField = value;
				this.RaisePropertyChanged("Timesheet_Daily_Data");
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
