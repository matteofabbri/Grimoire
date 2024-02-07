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
	public class Payee_Time_Tracking_Summary_DataType : INotifyPropertyChanged
	{
		private DateTime time_Tracking_Start_DateField;

		private bool time_Tracking_Start_DateFieldSpecified;

		private DateTime time_Tracking_End_DateField;

		private bool time_Tracking_End_DateFieldSpecified;

		private Payee_Time_Tracking_DataType[] payee_Time_Tracking_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Time_Tracking_Start_Date
		{
			get
			{
				return this.time_Tracking_Start_DateField;
			}
			set
			{
				this.time_Tracking_Start_DateField = value;
				this.RaisePropertyChanged("Time_Tracking_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Time_Tracking_Start_DateSpecified
		{
			get
			{
				return this.time_Tracking_Start_DateFieldSpecified;
			}
			set
			{
				this.time_Tracking_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Time_Tracking_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Time_Tracking_End_Date
		{
			get
			{
				return this.time_Tracking_End_DateField;
			}
			set
			{
				this.time_Tracking_End_DateField = value;
				this.RaisePropertyChanged("Time_Tracking_End_Date");
			}
		}

		[XmlIgnore]
		public bool Time_Tracking_End_DateSpecified
		{
			get
			{
				return this.time_Tracking_End_DateFieldSpecified;
			}
			set
			{
				this.time_Tracking_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Time_Tracking_End_DateSpecified");
			}
		}

		[XmlElement("Payee_Time_Tracking_Data", Order = 2)]
		public Payee_Time_Tracking_DataType[] Payee_Time_Tracking_Data
		{
			get
			{
				return this.payee_Time_Tracking_DataField;
			}
			set
			{
				this.payee_Time_Tracking_DataField = value;
				this.RaisePropertyChanged("Payee_Time_Tracking_Data");
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
