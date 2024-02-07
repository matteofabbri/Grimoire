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
	public class Payroll_Timesheet_Total_HoursType : INotifyPropertyChanged
	{
		private Payroll_Timesheet_Total_HoursObjectType payroll_Timesheet_Total_Hours_ReferenceField;

		private Payroll_Timesheet_Total_Hours_Data_WWSType payroll_Timesheet_Total_Hours_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Timesheet_Total_HoursObjectType Payroll_Timesheet_Total_Hours_Reference
		{
			get
			{
				return this.payroll_Timesheet_Total_Hours_ReferenceField;
			}
			set
			{
				this.payroll_Timesheet_Total_Hours_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Total_Hours_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Timesheet_Total_Hours_Data_WWSType Payroll_Timesheet_Total_Hours_Data
		{
			get
			{
				return this.payroll_Timesheet_Total_Hours_DataField;
			}
			set
			{
				this.payroll_Timesheet_Total_Hours_DataField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Total_Hours_Data");
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
