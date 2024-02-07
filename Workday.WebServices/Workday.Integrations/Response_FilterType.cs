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
	public class Response_FilterType : INotifyPropertyChanged
	{
		private DateTime as_Of_Effective_DateField;

		private bool as_Of_Effective_DateFieldSpecified;

		private DateTime as_Of_Entry_DateTimeField;

		private bool as_Of_Entry_DateTimeFieldSpecified;

		private decimal pageField;

		private bool pageFieldSpecified;

		private decimal countField;

		private bool countFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime As_Of_Effective_Date
		{
			get
			{
				return this.as_Of_Effective_DateField;
			}
			set
			{
				this.as_Of_Effective_DateField = value;
				this.RaisePropertyChanged("As_Of_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_Effective_DateSpecified
		{
			get
			{
				return this.as_Of_Effective_DateFieldSpecified;
			}
			set
			{
				this.as_Of_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime As_Of_Entry_DateTime
		{
			get
			{
				return this.as_Of_Entry_DateTimeField;
			}
			set
			{
				this.as_Of_Entry_DateTimeField = value;
				this.RaisePropertyChanged("As_Of_Entry_DateTime");
			}
		}

		[XmlIgnore]
		public bool As_Of_Entry_DateTimeSpecified
		{
			get
			{
				return this.as_Of_Entry_DateTimeFieldSpecified;
			}
			set
			{
				this.as_Of_Entry_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_Entry_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
				this.RaisePropertyChanged("Page");
			}
		}

		[XmlIgnore]
		public bool PageSpecified
		{
			get
			{
				return this.pageFieldSpecified;
			}
			set
			{
				this.pageFieldSpecified = value;
				this.RaisePropertyChanged("PageSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
				this.RaisePropertyChanged("Count");
			}
		}

		[XmlIgnore]
		public bool CountSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
				this.RaisePropertyChanged("CountSpecified");
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
