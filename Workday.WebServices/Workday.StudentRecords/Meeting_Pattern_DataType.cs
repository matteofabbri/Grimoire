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
	public class Meeting_Pattern_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string sort_OrderField;

		private Meeting_Day_PatternObjectType meeting_Day_Pattern_ReferenceField;

		private DateTime start_TimeField;

		private DateTime end_TimeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sort_Order
		{
			get
			{
				return this.sort_OrderField;
			}
			set
			{
				this.sort_OrderField = value;
				this.RaisePropertyChanged("Sort_Order");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "time", Order = 3)]
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
