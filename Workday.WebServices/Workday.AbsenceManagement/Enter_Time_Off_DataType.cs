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
	public class Enter_Time_Off_DataType : INotifyPropertyChanged
	{
		private bool turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalField;

		private bool turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalFieldSpecified;

		private EmployeeObjectType employee_ReferenceField;

		private Enter_Time_Off_Entry_DataType[] enter_Time_Off_Entry_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Turn_Off_Run_Time_Calculations_with_Time_Off_Approval
		{
			get
			{
				return this.turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalField;
			}
			set
			{
				this.turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalField = value;
				this.RaisePropertyChanged("Turn_Off_Run_Time_Calculations_with_Time_Off_Approval");
			}
		}

		[XmlIgnore]
		public bool Turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalSpecified
		{
			get
			{
				return this.turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalFieldSpecified;
			}
			set
			{
				this.turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Turn_Off_Run_Time_Calculations_with_Time_Off_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public EmployeeObjectType Employee_Reference
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

		[XmlElement("Enter_Time_Off_Entry_Data", Order = 2)]
		public Enter_Time_Off_Entry_DataType[] Enter_Time_Off_Entry_Data
		{
			get
			{
				return this.enter_Time_Off_Entry_DataField;
			}
			set
			{
				this.enter_Time_Off_Entry_DataField = value;
				this.RaisePropertyChanged("Enter_Time_Off_Entry_Data");
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
