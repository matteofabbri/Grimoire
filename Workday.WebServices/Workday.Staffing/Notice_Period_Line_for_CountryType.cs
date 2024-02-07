using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notice_Period_Line_for_CountryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType notice_Period_Line_ReferenceField;

		private Notice_Period_Line_Data__old_Type[] notice_Period_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Notice_Period_Line_Reference
		{
			get
			{
				return this.notice_Period_Line_ReferenceField;
			}
			set
			{
				this.notice_Period_Line_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Line_Reference");
			}
		}

		[XmlElement("Notice_Period_Line_Data", Order = 1)]
		public Notice_Period_Line_Data__old_Type[] Notice_Period_Line_Data
		{
			get
			{
				return this.notice_Period_Line_DataField;
			}
			set
			{
				this.notice_Period_Line_DataField = value;
				this.RaisePropertyChanged("Notice_Period_Line_Data");
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
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notice_Period_Line_For_CountryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType notice_Period_Line_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private string orderField;

		private Condition_RuleObjectType notice_Period_Eligibility_Rule_ReferenceField;

		private bool has_Notice_PeriodField;

		private bool has_Notice_PeriodFieldSpecified;

		private Notice_Periods_ForType notice_Periods_ForField;

		private decimal notice_Period_DurationField;

		private bool notice_Period_DurationFieldSpecified;

		private Unique_IdentifierObjectType notice_Period_Unit_ReferenceField;

		private bool notice_Period_InactiveField;

		private bool notice_Period_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Notice_Period_Line_Reference
		{
			get
			{
				return this.notice_Period_Line_ReferenceField;
			}
			set
			{
				this.notice_Period_Line_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 3)]
		public Condition_RuleObjectType Notice_Period_Eligibility_Rule_Reference
		{
			get
			{
				return this.notice_Period_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.notice_Period_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Has_Notice_Period
		{
			get
			{
				return this.has_Notice_PeriodField;
			}
			set
			{
				this.has_Notice_PeriodField = value;
				this.RaisePropertyChanged("Has_Notice_Period");
			}
		}

		[XmlIgnore]
		public bool Has_Notice_PeriodSpecified
		{
			get
			{
				return this.has_Notice_PeriodFieldSpecified;
			}
			set
			{
				this.has_Notice_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Has_Notice_PeriodSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Notice_Periods_ForType Notice_Periods_For
		{
			get
			{
				return this.notice_Periods_ForField;
			}
			set
			{
				this.notice_Periods_ForField = value;
				this.RaisePropertyChanged("Notice_Periods_For");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Notice_Period_Duration
		{
			get
			{
				return this.notice_Period_DurationField;
			}
			set
			{
				this.notice_Period_DurationField = value;
				this.RaisePropertyChanged("Notice_Period_Duration");
			}
		}

		[XmlIgnore]
		public bool Notice_Period_DurationSpecified
		{
			get
			{
				return this.notice_Period_DurationFieldSpecified;
			}
			set
			{
				this.notice_Period_DurationFieldSpecified = value;
				this.RaisePropertyChanged("Notice_Period_DurationSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Notice_Period_Unit_Reference
		{
			get
			{
				return this.notice_Period_Unit_ReferenceField;
			}
			set
			{
				this.notice_Period_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Unit_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Notice_Period_Inactive
		{
			get
			{
				return this.notice_Period_InactiveField;
			}
			set
			{
				this.notice_Period_InactiveField = value;
				this.RaisePropertyChanged("Notice_Period_Inactive");
			}
		}

		[XmlIgnore]
		public bool Notice_Period_InactiveSpecified
		{
			get
			{
				return this.notice_Period_InactiveFieldSpecified;
			}
			set
			{
				this.notice_Period_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Notice_Period_InactiveSpecified");
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
