using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_Meeting_Pattern_DataType : INotifyPropertyChanged
	{
		private DateTime start_DateField;

		private DateTime end_DateField;

		private DateTime start_TimeField;

		private DateTime end_TimeField;

		private Meeting_Day_PatternObjectType meeting_Day_Pattern_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(DataType = "time", Order = 3)]
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

		[XmlElement(Order = 4)]
		public Meeting_Day_PatternObjectType Meeting_Day_Pattern_Reference
		{
			get
			{
				return this.meeting_Day_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Day_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Day_Pattern_Reference");
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
