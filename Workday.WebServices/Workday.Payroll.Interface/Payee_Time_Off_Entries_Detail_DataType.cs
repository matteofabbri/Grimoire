using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Time_Off_Entries_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime time_Off_Entry_DateField;

		private bool time_Off_Entry_DateFieldSpecified;

		private decimal time_Off_UnitsField;

		private bool time_Off_UnitsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Time_Off_Entry_Date
		{
			get
			{
				return this.time_Off_Entry_DateField;
			}
			set
			{
				this.time_Off_Entry_DateField = value;
				this.RaisePropertyChanged("Time_Off_Entry_Date");
			}
		}

		[XmlIgnore]
		public bool Time_Off_Entry_DateSpecified
		{
			get
			{
				return this.time_Off_Entry_DateFieldSpecified;
			}
			set
			{
				this.time_Off_Entry_DateFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_Entry_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Time_Off_Units
		{
			get
			{
				return this.time_Off_UnitsField;
			}
			set
			{
				this.time_Off_UnitsField = value;
				this.RaisePropertyChanged("Time_Off_Units");
			}
		}

		[XmlIgnore]
		public bool Time_Off_UnitsSpecified
		{
			get
			{
				return this.time_Off_UnitsFieldSpecified;
			}
			set
			{
				this.time_Off_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_UnitsSpecified");
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
