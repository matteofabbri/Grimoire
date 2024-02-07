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
	public class Resource_Forecast_Configuration_DataType : INotifyPropertyChanged
	{
		private bool project_Forecast_LevelField;

		private bool project_Forecast_LevelFieldSpecified;

		private bool task_Forecast_LevelField;

		private bool task_Forecast_LevelFieldSpecified;

		private bool forecast_Frequency_DayField;

		private bool forecast_Frequency_DayFieldSpecified;

		private bool forecast_Frequency_WeekField;

		private bool forecast_Frequency_WeekFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Project_Forecast_Level
		{
			get
			{
				return this.project_Forecast_LevelField;
			}
			set
			{
				this.project_Forecast_LevelField = value;
				this.RaisePropertyChanged("Project_Forecast_Level");
			}
		}

		[XmlIgnore]
		public bool Project_Forecast_LevelSpecified
		{
			get
			{
				return this.project_Forecast_LevelFieldSpecified;
			}
			set
			{
				this.project_Forecast_LevelFieldSpecified = value;
				this.RaisePropertyChanged("Project_Forecast_LevelSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Task_Forecast_Level
		{
			get
			{
				return this.task_Forecast_LevelField;
			}
			set
			{
				this.task_Forecast_LevelField = value;
				this.RaisePropertyChanged("Task_Forecast_Level");
			}
		}

		[XmlIgnore]
		public bool Task_Forecast_LevelSpecified
		{
			get
			{
				return this.task_Forecast_LevelFieldSpecified;
			}
			set
			{
				this.task_Forecast_LevelFieldSpecified = value;
				this.RaisePropertyChanged("Task_Forecast_LevelSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Forecast_Frequency_Day
		{
			get
			{
				return this.forecast_Frequency_DayField;
			}
			set
			{
				this.forecast_Frequency_DayField = value;
				this.RaisePropertyChanged("Forecast_Frequency_Day");
			}
		}

		[XmlIgnore]
		public bool Forecast_Frequency_DaySpecified
		{
			get
			{
				return this.forecast_Frequency_DayFieldSpecified;
			}
			set
			{
				this.forecast_Frequency_DayFieldSpecified = value;
				this.RaisePropertyChanged("Forecast_Frequency_DaySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Forecast_Frequency_Week
		{
			get
			{
				return this.forecast_Frequency_WeekField;
			}
			set
			{
				this.forecast_Frequency_WeekField = value;
				this.RaisePropertyChanged("Forecast_Frequency_Week");
			}
		}

		[XmlIgnore]
		public bool Forecast_Frequency_WeekSpecified
		{
			get
			{
				return this.forecast_Frequency_WeekFieldSpecified;
			}
			set
			{
				this.forecast_Frequency_WeekFieldSpecified = value;
				this.RaisePropertyChanged("Forecast_Frequency_WeekSpecified");
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
