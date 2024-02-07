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
	public class Resource_Forecast_Line_Allocation__HV__DataType : INotifyPropertyChanged
	{
		private DateTime period_Start_DateField;

		private decimal forecasted_HoursField;

		private bool forecasted_HoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Forecasted_Hours
		{
			get
			{
				return this.forecasted_HoursField;
			}
			set
			{
				this.forecasted_HoursField = value;
				this.RaisePropertyChanged("Forecasted_Hours");
			}
		}

		[XmlIgnore]
		public bool Forecasted_HoursSpecified
		{
			get
			{
				return this.forecasted_HoursFieldSpecified;
			}
			set
			{
				this.forecasted_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Forecasted_HoursSpecified");
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
