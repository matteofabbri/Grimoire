using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Start_End_Minute_Support_DataType : INotifyPropertyChanged
	{
		private bool all_Day_EventField;

		private bool all_Day_EventFieldSpecified;

		private DateTime start_DateField;

		private DateTime start_TimeField;

		private bool start_TimeFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime end_TimeField;

		private bool end_TimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool All_Day_Event
		{
			get
			{
				return this.all_Day_EventField;
			}
			set
			{
				this.all_Day_EventField = value;
				this.RaisePropertyChanged("All_Day_Event");
			}
		}

		[XmlIgnore]
		public bool All_Day_EventSpecified
		{
			get
			{
				return this.all_Day_EventFieldSpecified;
			}
			set
			{
				this.all_Day_EventFieldSpecified = value;
				this.RaisePropertyChanged("All_Day_EventSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlElement(DataType = "time", Order = 2)]
		public DateTime Start_Time
		{
			get
			{
				return this.start_TimeField;
			}
			set
			{
				this.start_TimeField = value;
				this.RaisePropertyChanged("Start_Time");
			}
		}

		[XmlIgnore]
		public bool Start_TimeSpecified
		{
			get
			{
				return this.start_TimeFieldSpecified;
			}
			set
			{
				this.start_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Start_TimeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 4)]
		public DateTime End_Time
		{
			get
			{
				return this.end_TimeField;
			}
			set
			{
				this.end_TimeField = value;
				this.RaisePropertyChanged("End_Time");
			}
		}

		[XmlIgnore]
		public bool End_TimeSpecified
		{
			get
			{
				return this.end_TimeFieldSpecified;
			}
			set
			{
				this.end_TimeFieldSpecified = value;
				this.RaisePropertyChanged("End_TimeSpecified");
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
