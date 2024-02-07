using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Background_Process_Message_Data_WSType : INotifyPropertyChanged
	{
		private DateTime timestampField;

		private bool timestampFieldSpecified;

		private string severityField;

		private string message_SummaryField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private string line_IdentifierField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
				this.RaisePropertyChanged("Timestamp");
			}
		}

		[XmlIgnore]
		public bool TimestampSpecified
		{
			get
			{
				return this.timestampFieldSpecified;
			}
			set
			{
				this.timestampFieldSpecified = value;
				this.RaisePropertyChanged("TimestampSpecified");
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
		public string Message_Summary
		{
			get
			{
				return this.message_SummaryField;
			}
			set
			{
				this.message_SummaryField = value;
				this.RaisePropertyChanged("Message_Summary");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Line_Identifier
		{
			get
			{
				return this.line_IdentifierField;
			}
			set
			{
				this.line_IdentifierField = value;
				this.RaisePropertyChanged("Line_Identifier");
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
