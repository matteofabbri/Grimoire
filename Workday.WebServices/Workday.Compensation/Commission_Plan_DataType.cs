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
	public class Commission_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal target_AmountField;

		private bool target_AmountFieldSpecified;

		private decimal draw_AmountField;

		private bool draw_AmountFieldSpecified;

		private FrequencyObjectType draw_Frequency_ReferenceField;

		private string draw_DurationField;

		private bool recoverableField;

		private bool recoverableFieldSpecified;

		private Commission_Plan_Profile_Replacement_DataType[] commission_Plan_Profile_Replacement_DataField;

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
		public decimal Target_Amount
		{
			get
			{
				return this.target_AmountField;
			}
			set
			{
				this.target_AmountField = value;
				this.RaisePropertyChanged("Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Target_AmountSpecified
		{
			get
			{
				return this.target_AmountFieldSpecified;
			}
			set
			{
				this.target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Draw_Amount
		{
			get
			{
				return this.draw_AmountField;
			}
			set
			{
				this.draw_AmountField = value;
				this.RaisePropertyChanged("Draw_Amount");
			}
		}

		[XmlIgnore]
		public bool Draw_AmountSpecified
		{
			get
			{
				return this.draw_AmountFieldSpecified;
			}
			set
			{
				this.draw_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Draw_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public FrequencyObjectType Draw_Frequency_Reference
		{
			get
			{
				return this.draw_Frequency_ReferenceField;
			}
			set
			{
				this.draw_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Draw_Frequency_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Draw_Duration
		{
			get
			{
				return this.draw_DurationField;
			}
			set
			{
				this.draw_DurationField = value;
				this.RaisePropertyChanged("Draw_Duration");
			}
		}

		[XmlElement(Order = 8)]
		public bool Recoverable
		{
			get
			{
				return this.recoverableField;
			}
			set
			{
				this.recoverableField = value;
				this.RaisePropertyChanged("Recoverable");
			}
		}

		[XmlIgnore]
		public bool RecoverableSpecified
		{
			get
			{
				return this.recoverableFieldSpecified;
			}
			set
			{
				this.recoverableFieldSpecified = value;
				this.RaisePropertyChanged("RecoverableSpecified");
			}
		}

		[XmlElement("Commission_Plan_Profile_Replacement_Data", Order = 9)]
		public Commission_Plan_Profile_Replacement_DataType[] Commission_Plan_Profile_Replacement_Data
		{
			get
			{
				return this.commission_Plan_Profile_Replacement_DataField;
			}
			set
			{
				this.commission_Plan_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Commission_Plan_Profile_Replacement_Data");
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
