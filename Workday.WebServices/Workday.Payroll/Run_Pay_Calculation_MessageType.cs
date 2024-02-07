using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Run_Pay_Calculation_MessageType : INotifyPropertyChanged
	{
		private DateTime date_and_TimeField;

		private bool date_and_TimeFieldSpecified;

		private string severityField;

		private string messageField;

		private Background_Process_RuntimeObjectType background_Process_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Date_and_Time
		{
			get
			{
				return this.date_and_TimeField;
			}
			set
			{
				this.date_and_TimeField = value;
				this.RaisePropertyChanged("Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Date_and_TimeSpecified
		{
			get
			{
				return this.date_and_TimeFieldSpecified;
			}
			set
			{
				this.date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
				this.RaisePropertyChanged("Severity");
			}
		}

		[XmlElement(Order = 2)]
		public string Message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
				this.RaisePropertyChanged("Message");
			}
		}

		[XmlElement(Order = 3)]
		public Background_Process_RuntimeObjectType Background_Process_Reference
		{
			get
			{
				return this.background_Process_ReferenceField;
			}
			set
			{
				this.background_Process_ReferenceField = value;
				this.RaisePropertyChanged("Background_Process_Reference");
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
