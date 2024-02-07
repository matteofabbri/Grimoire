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
	public class Allowance_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private bool no_Individual_OverrideField;

		private bool no_Individual_OverrideFieldSpecified;

		private bool apply_Full_Time_EquivalentField;

		private bool apply_Full_Time_EquivalentFieldSpecified;

		private bool exclude_from_MeritField;

		private bool exclude_from_MeritFieldSpecified;

		private object itemField;

		private Allowance_Plan_Reimbursable_DataType reimbursable_DataField;

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
		public bool No_Individual_Override
		{
			get
			{
				return this.no_Individual_OverrideField;
			}
			set
			{
				this.no_Individual_OverrideField = value;
				this.RaisePropertyChanged("No_Individual_Override");
			}
		}

		[XmlIgnore]
		public bool No_Individual_OverrideSpecified
		{
			get
			{
				return this.no_Individual_OverrideFieldSpecified;
			}
			set
			{
				this.no_Individual_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("No_Individual_OverrideSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Apply_Full_Time_Equivalent
		{
			get
			{
				return this.apply_Full_Time_EquivalentField;
			}
			set
			{
				this.apply_Full_Time_EquivalentField = value;
				this.RaisePropertyChanged("Apply_Full_Time_Equivalent");
			}
		}

		[XmlIgnore]
		public bool Apply_Full_Time_EquivalentSpecified
		{
			get
			{
				return this.apply_Full_Time_EquivalentFieldSpecified;
			}
			set
			{
				this.apply_Full_Time_EquivalentFieldSpecified = value;
				this.RaisePropertyChanged("Apply_Full_Time_EquivalentSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Amount_Data", typeof(Allowance_Plan_Amount_DataType), Order = 7), XmlElement("Percent_Data", typeof(Allowance_Plan_Percent_DataType), Order = 7), XmlElement("Unit_Data", typeof(Allowance_Plan_Unit_DataType), Order = 7)]
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

		[XmlElement(Order = 8)]
		public Allowance_Plan_Reimbursable_DataType Reimbursable_Data
		{
			get
			{
				return this.reimbursable_DataField;
			}
			set
			{
				this.reimbursable_DataField = value;
				this.RaisePropertyChanged("Reimbursable_Data");
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
