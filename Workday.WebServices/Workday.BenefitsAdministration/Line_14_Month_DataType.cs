using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Line_14_Month_DataType : INotifyPropertyChanged
	{
		private string all_12_MonthsField;

		private string janField;

		private string febField;

		private string marField;

		private string aprField;

		private string mayField;

		private string junField;

		private string julField;

		private string augField;

		private string sepField;

		private string octField;

		private string novField;

		private string decField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string All_12_Months
		{
			get
			{
				return this.all_12_MonthsField;
			}
			set
			{
				this.all_12_MonthsField = value;
				this.RaisePropertyChanged("All_12_Months");
			}
		}

		[XmlElement(Order = 1)]
		public string Jan
		{
			get
			{
				return this.janField;
			}
			set
			{
				this.janField = value;
				this.RaisePropertyChanged("Jan");
			}
		}

		[XmlElement(Order = 2)]
		public string Feb
		{
			get
			{
				return this.febField;
			}
			set
			{
				this.febField = value;
				this.RaisePropertyChanged("Feb");
			}
		}

		[XmlElement(Order = 3)]
		public string Mar
		{
			get
			{
				return this.marField;
			}
			set
			{
				this.marField = value;
				this.RaisePropertyChanged("Mar");
			}
		}

		[XmlElement(Order = 4)]
		public string Apr
		{
			get
			{
				return this.aprField;
			}
			set
			{
				this.aprField = value;
				this.RaisePropertyChanged("Apr");
			}
		}

		[XmlElement(Order = 5)]
		public string May
		{
			get
			{
				return this.mayField;
			}
			set
			{
				this.mayField = value;
				this.RaisePropertyChanged("May");
			}
		}

		[XmlElement(Order = 6)]
		public string Jun
		{
			get
			{
				return this.junField;
			}
			set
			{
				this.junField = value;
				this.RaisePropertyChanged("Jun");
			}
		}

		[XmlElement(Order = 7)]
		public string Jul
		{
			get
			{
				return this.julField;
			}
			set
			{
				this.julField = value;
				this.RaisePropertyChanged("Jul");
			}
		}

		[XmlElement(Order = 8)]
		public string Aug
		{
			get
			{
				return this.augField;
			}
			set
			{
				this.augField = value;
				this.RaisePropertyChanged("Aug");
			}
		}

		[XmlElement(Order = 9)]
		public string Sep
		{
			get
			{
				return this.sepField;
			}
			set
			{
				this.sepField = value;
				this.RaisePropertyChanged("Sep");
			}
		}

		[XmlElement(Order = 10)]
		public string Oct
		{
			get
			{
				return this.octField;
			}
			set
			{
				this.octField = value;
				this.RaisePropertyChanged("Oct");
			}
		}

		[XmlElement(Order = 11)]
		public string Nov
		{
			get
			{
				return this.novField;
			}
			set
			{
				this.novField = value;
				this.RaisePropertyChanged("Nov");
			}
		}

		[XmlElement(Order = 12)]
		public string Dec
		{
			get
			{
				return this.decField;
			}
			set
			{
				this.decField = value;
				this.RaisePropertyChanged("Dec");
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
