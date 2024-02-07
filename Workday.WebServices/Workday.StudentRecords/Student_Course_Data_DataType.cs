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
	public class Student_Course_Data_DataType : INotifyPropertyChanged
	{
		private DateTime first_AvailableField;

		private DateTime last_AvailableField;

		private bool last_AvailableFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime First_Available
		{
			get
			{
				return this.first_AvailableField;
			}
			set
			{
				this.first_AvailableField = value;
				this.RaisePropertyChanged("First_Available");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Last_Available
		{
			get
			{
				return this.last_AvailableField;
			}
			set
			{
				this.last_AvailableField = value;
				this.RaisePropertyChanged("Last_Available");
			}
		}

		[XmlIgnore]
		public bool Last_AvailableSpecified
		{
			get
			{
				return this.last_AvailableFieldSpecified;
			}
			set
			{
				this.last_AvailableFieldSpecified = value;
				this.RaisePropertyChanged("Last_AvailableSpecified");
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
