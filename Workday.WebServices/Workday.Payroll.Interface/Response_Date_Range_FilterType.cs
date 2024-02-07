using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Response_Date_Range_FilterType : INotifyPropertyChanged
	{
		private DateTime begin_Effective_DateField;

		private bool begin_Effective_DateFieldSpecified;

		private DateTime begin_Entry_DateTimeField;

		private bool begin_Entry_DateTimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Begin_Effective_Date
		{
			get
			{
				return this.begin_Effective_DateField;
			}
			set
			{
				this.begin_Effective_DateField = value;
				this.RaisePropertyChanged("Begin_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Begin_Effective_DateSpecified
		{
			get
			{
				return this.begin_Effective_DateFieldSpecified;
			}
			set
			{
				this.begin_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Begin_Entry_DateTime
		{
			get
			{
				return this.begin_Entry_DateTimeField;
			}
			set
			{
				this.begin_Entry_DateTimeField = value;
				this.RaisePropertyChanged("Begin_Entry_DateTime");
			}
		}

		[XmlIgnore]
		public bool Begin_Entry_DateTimeSpecified
		{
			get
			{
				return this.begin_Entry_DateTimeFieldSpecified;
			}
			set
			{
				this.begin_Entry_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Entry_DateTimeSpecified");
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
