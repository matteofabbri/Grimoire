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
	public class Payroll_Timesheet_Time_In_Time_Out_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Timesheet_Time_In_Time_OutObjectType[] payroll_Timesheet_Time_In_Time_Out_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Timesheet_Time_In_Time_Out_Reference", Order = 0)]
		public Payroll_Timesheet_Time_In_Time_OutObjectType[] Payroll_Timesheet_Time_In_Time_Out_Reference
		{
			get
			{
				return this.payroll_Timesheet_Time_In_Time_Out_ReferenceField;
			}
			set
			{
				this.payroll_Timesheet_Time_In_Time_Out_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Time_In_Time_Out_Reference");
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
