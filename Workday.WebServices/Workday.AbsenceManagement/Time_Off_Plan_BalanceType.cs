using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Time_Off_Plan_BalanceType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private Time_Off_Plan_Balance_RecordType[] time_Off_Plan_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Time_Off_Plan_Balance_Record", IsNullable = false)]
		public Time_Off_Plan_Balance_RecordType[] Time_Off_Plan_Balance_Data
		{
			get
			{
				return this.time_Off_Plan_Balance_DataField;
			}
			set
			{
				this.time_Off_Plan_Balance_DataField = value;
				this.RaisePropertyChanged("Time_Off_Plan_Balance_Data");
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
