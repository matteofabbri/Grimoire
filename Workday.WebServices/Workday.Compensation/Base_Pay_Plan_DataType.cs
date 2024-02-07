using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Base_Pay_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private bool exclude_from_MeritField;

		private bool exclude_from_MeritFieldSpecified;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Pay_EarningObjectType Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement("Setup_Security_Segment_Reference", Order = 1)]
		public Compensation_Setup_Security_SegmentObjectType[] Setup_Security_Segment_Reference
		{
			get
			{
				return this.setup_Security_Segment_ReferenceField;
			}
			set
			{
				this.setup_Security_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Setup_Security_Segment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Exclude_from_Merit
		{
			get
			{
				return this.exclude_from_MeritField;
			}
			set
			{
				this.exclude_from_MeritField = value;
				this.RaisePropertyChanged("Exclude_from_Merit");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_MeritSpecified
		{
			get
			{
				return this.exclude_from_MeritFieldSpecified;
			}
			set
			{
				this.exclude_from_MeritFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_MeritSpecified");
			}
		}

		[XmlElement("Hourly_Data", typeof(Hourly_Plan_DataType), Order = 5), XmlElement("Salary_Data", typeof(Salary_Plan_DataType), Order = 5), XmlElement("Unit_Data", typeof(Unit_Salary_Plan_DataType), Order = 5)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
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
