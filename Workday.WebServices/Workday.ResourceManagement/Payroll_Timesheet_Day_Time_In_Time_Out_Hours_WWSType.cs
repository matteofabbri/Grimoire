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
	public class Payroll_Timesheet_Day_Time_In_Time_Out_Hours_WWSType : INotifyPropertyChanged
	{
		private DateTime time_InField;

		private DateTime time_OutField;

		private Time_Entry_CodeObjectType time_Code_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Time_In
		{
			get
			{
				return this.time_InField;
			}
			set
			{
				this.time_InField = value;
				this.RaisePropertyChanged("Time_In");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Time_Out
		{
			get
			{
				return this.time_OutField;
			}
			set
			{
				this.time_OutField = value;
				this.RaisePropertyChanged("Time_Out");
			}
		}

		[XmlElement(Order = 2)]
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
