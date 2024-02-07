using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assess_Candidate_Response_FilterType : INotifyPropertyChanged
	{
		private DateTime as_Of_Effective_DateField;

		private bool as_Of_Effective_DateFieldSpecified;

		private DateTime as_Of_Entry_DateTimeField;

		private bool as_Of_Entry_DateTimeFieldSpecified;

		private decimal pageField;

		private bool pageFieldSpecified;

		private decimal countField;

		private bool countFieldSpecified;

		private DateTime from_MomentField;

		private bool from_MomentFieldSpecified;

		private DateTime to_MomentField;

		private bool to_MomentFieldSpecified;

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

		[XmlElement(Order = 4)]
		public DateTime From_Moment
		{
			get
			{
				return this.from_MomentField;
			}
			set
			{
				this.from_MomentField = value;
				this.RaisePropertyChanged("From_Moment");
			}
		}

		[XmlIgnore]
		public bool From_MomentSpecified
		{
			get
			{
				return this.from_MomentFieldSpecified;
			}
			set
			{
				this.from_MomentFieldSpecified = value;
				this.RaisePropertyChanged("From_MomentSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime To_Moment
		{
			get
			{
				return this.to_MomentField;
			}
			set
			{
				this.to_MomentField = value;
				this.RaisePropertyChanged("To_Moment");
			}
		}

		[XmlIgnore]
		public bool To_MomentSpecified
		{
			get
			{
				return this.to_MomentFieldSpecified;
			}
			set
			{
				this.to_MomentFieldSpecified = value;
				this.RaisePropertyChanged("To_MomentSpecified");
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
