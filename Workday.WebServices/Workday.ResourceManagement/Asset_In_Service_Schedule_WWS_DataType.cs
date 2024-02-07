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
	public class Asset_In_Service_Schedule_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime in_Service_From_DateField;

		private bool in_Service_From_DateFieldSpecified;

		private DateTime in_Service_To_DateField;

		private bool in_Service_To_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime In_Service_From_Date
		{
			get
			{
				return this.in_Service_From_DateField;
			}
			set
			{
				this.in_Service_From_DateField = value;
				this.RaisePropertyChanged("In_Service_From_Date");
			}
		}

		[XmlIgnore]
		public bool In_Service_From_DateSpecified
		{
			get
			{
				return this.in_Service_From_DateFieldSpecified;
			}
			set
			{
				this.in_Service_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("In_Service_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime In_Service_To_Date
		{
			get
			{
				return this.in_Service_To_DateField;
			}
			set
			{
				this.in_Service_To_DateField = value;
				this.RaisePropertyChanged("In_Service_To_Date");
			}
		}

		[XmlIgnore]
		public bool In_Service_To_DateSpecified
		{
			get
			{
				return this.in_Service_To_DateFieldSpecified;
			}
			set
			{
				this.in_Service_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("In_Service_To_DateSpecified");
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
