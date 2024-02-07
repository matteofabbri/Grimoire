using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Period_DataType : INotifyPropertyChanged
	{
		private Award_Posting_IntervalObjectType award_Posting_Interval_ReferenceField;

		private string award_Posting_Interval_IDField;

		private Award_Posting_Interval_NameObjectType award_Posting_Interval_Name_ReferenceField;

		private DateTime award_Interval_Start_DateField;

		private bool award_Interval_Start_DateFieldSpecified;

		private DateTime award_Interval_End_DateField;

		private bool award_Interval_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Posting_IntervalObjectType Award_Posting_Interval_Reference
		{
			get
			{
				return this.award_Posting_Interval_ReferenceField;
			}
			set
			{
				this.award_Posting_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Award_Posting_Interval_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Posting_Interval_ID
		{
			get
			{
				return this.award_Posting_Interval_IDField;
			}
			set
			{
				this.award_Posting_Interval_IDField = value;
				this.RaisePropertyChanged("Award_Posting_Interval_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Award_Posting_Interval_NameObjectType Award_Posting_Interval_Name_Reference
		{
			get
			{
				return this.award_Posting_Interval_Name_ReferenceField;
			}
			set
			{
				this.award_Posting_Interval_Name_ReferenceField = value;
				this.RaisePropertyChanged("Award_Posting_Interval_Name_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Award_Interval_Start_Date
		{
			get
			{
				return this.award_Interval_Start_DateField;
			}
			set
			{
				this.award_Interval_Start_DateField = value;
				this.RaisePropertyChanged("Award_Interval_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Interval_Start_DateSpecified
		{
			get
			{
				return this.award_Interval_Start_DateFieldSpecified;
			}
			set
			{
				this.award_Interval_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Interval_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Award_Interval_End_Date
		{
			get
			{
				return this.award_Interval_End_DateField;
			}
			set
			{
				this.award_Interval_End_DateField = value;
				this.RaisePropertyChanged("Award_Interval_End_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Interval_End_DateSpecified
		{
			get
			{
				return this.award_Interval_End_DateFieldSpecified;
			}
			set
			{
				this.award_Interval_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Interval_End_DateSpecified");
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
