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
	public class Payroll_Timesheet_Line_DataType : INotifyPropertyChanged
	{
		private Time_Entry_CodeObjectType time_Code_ReferenceField;

		private Cost_CenterObjectType cost_Center_ReferenceField;

		private PositionObjectType position_ReferenceField;

		private string memoField;

		private Payroll_Timesheet_Day_Total_Hours_DataType[] payroll_Timesheet_Day_Total_Hours_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Time_Entry_CodeObjectType Time_Code_Reference
		{
			get
			{
				return this.time_Code_ReferenceField;
			}
			set
			{
				this.time_Code_ReferenceField = value;
				this.RaisePropertyChanged("Time_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cost_CenterObjectType Cost_Center_Reference
		{
			get
			{
				return this.cost_Center_ReferenceField;
			}
			set
			{
				this.cost_Center_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public PositionObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Payroll_Timesheet_Day_Total_Hours_Data", Order = 4)]
		public Payroll_Timesheet_Day_Total_Hours_DataType[] Payroll_Timesheet_Day_Total_Hours_Data
		{
			get
			{
				return this.payroll_Timesheet_Day_Total_Hours_DataField;
			}
			set
			{
				this.payroll_Timesheet_Day_Total_Hours_DataField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Day_Total_Hours_Data");
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
