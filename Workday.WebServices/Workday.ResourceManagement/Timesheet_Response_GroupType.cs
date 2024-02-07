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
	public class Timesheet_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Worker_Time_Card_DataField;

		private bool include_Worker_Time_Card_DataFieldSpecified;

		private bool include_Time_Card_Daily_DataField;

		private bool include_Time_Card_Daily_DataFieldSpecified;

		private bool include_Time_In_Time_Out_DataField;

		private bool include_Time_In_Time_Out_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Worker_Time_Card_Data
		{
			get
			{
				return this.include_Worker_Time_Card_DataField;
			}
			set
			{
				this.include_Worker_Time_Card_DataField = value;
				this.RaisePropertyChanged("Include_Worker_Time_Card_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Worker_Time_Card_DataSpecified
		{
			get
			{
				return this.include_Worker_Time_Card_DataFieldSpecified;
			}
			set
			{
				this.include_Worker_Time_Card_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Worker_Time_Card_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Time_Card_Daily_Data
		{
			get
			{
				return this.include_Time_Card_Daily_DataField;
			}
			set
			{
				this.include_Time_Card_Daily_DataField = value;
				this.RaisePropertyChanged("Include_Time_Card_Daily_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Time_Card_Daily_DataSpecified
		{
			get
			{
				return this.include_Time_Card_Daily_DataFieldSpecified;
			}
			set
			{
				this.include_Time_Card_Daily_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Time_Card_Daily_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Time_In_Time_Out_Data
		{
			get
			{
				return this.include_Time_In_Time_Out_DataField;
			}
			set
			{
				this.include_Time_In_Time_Out_DataField = value;
				this.RaisePropertyChanged("Include_Time_In_Time_Out_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Time_In_Time_Out_DataSpecified
		{
			get
			{
				return this.include_Time_In_Time_Out_DataFieldSpecified;
			}
			set
			{
				this.include_Time_In_Time_Out_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Time_In_Time_Out_DataSpecified");
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
