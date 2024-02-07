using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Response_ResultsType : INotifyPropertyChanged
	{
		private decimal total_ResultsField;

		private bool total_ResultsFieldSpecified;

		private decimal total_PagesField;

		private bool total_PagesFieldSpecified;

		private decimal page_ResultsField;

		private bool page_ResultsFieldSpecified;

		private decimal pageField;

		private bool pageFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Total_Results
		{
			get
			{
				return this.total_ResultsField;
			}
			set
			{
				this.total_ResultsField = value;
				this.RaisePropertyChanged("Total_Results");
			}
		}

		[XmlIgnore]
		public bool Total_ResultsSpecified
		{
			get
			{
				return this.total_ResultsFieldSpecified;
			}
			set
			{
				this.total_ResultsFieldSpecified = value;
				this.RaisePropertyChanged("Total_ResultsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Total_Pages
		{
			get
			{
				return this.total_PagesField;
			}
			set
			{
				this.total_PagesField = value;
				this.RaisePropertyChanged("Total_Pages");
			}
		}

		[XmlIgnore]
		public bool Total_PagesSpecified
		{
			get
			{
				return this.total_PagesFieldSpecified;
			}
			set
			{
				this.total_PagesFieldSpecified = value;
				this.RaisePropertyChanged("Total_PagesSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Page_Results
		{
			get
			{
				return this.page_ResultsField;
			}
			set
			{
				this.page_ResultsField = value;
				this.RaisePropertyChanged("Page_Results");
			}
		}

		[XmlIgnore]
		public bool Page_ResultsSpecified
		{
			get
			{
				return this.page_ResultsFieldSpecified;
			}
			set
			{
				this.page_ResultsFieldSpecified = value;
				this.RaisePropertyChanged("Page_ResultsSpecified");
			}
		}

		[XmlElement(Order = 3)]
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
