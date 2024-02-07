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
	public class Compensation_Grade_Profile_DataType : INotifyPropertyChanged
	{
		private string compensation_Grade_Profile_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string nameField;

		private string descriptionField;

		private Compensation_Pay_EarningObjectType[] compensation_Element_ReferenceField;

		private Condition_RuleObjectType[] eligibility_Rule_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Compensation_Pay_Range_DataType compensation_Pay_Range_DataField;

		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private Alternative_Pay_RangeType[] alternative_Pay_RangeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Compensation_Grade_Profile_ID
		{
			get
			{
				return this.compensation_Grade_Profile_IDField;
			}
			set
			{
				this.compensation_Grade_Profile_IDField = value;
				this.RaisePropertyChanged("Compensation_Grade_Profile_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Compensation_Element_Reference", Order = 4)]
		public Compensation_Pay_EarningObjectType[] Compensation_Element_Reference
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

		[XmlElement("Eligibility_Rule_Reference", Order = 5)]
		public Condition_RuleObjectType[] Eligibility_Rule_Reference
		{
			get
			{
				return this.eligibility_Rule_ReferenceField;
			}
			set
			{
				this.eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Compensation_Pay_Range_DataType Compensation_Pay_Range_Data
		{
			get
			{
				return this.compensation_Pay_Range_DataField;
			}
			set
			{
				this.compensation_Pay_Range_DataField = value;
				this.RaisePropertyChanged("Compensation_Pay_Range_Data");
			}
		}

		[XmlElement("Setup_Security_Segment_Reference", Order = 8)]
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

		[XmlElement("Alternative_Pay_Range", Order = 9)]
		public Alternative_Pay_RangeType[] Alternative_Pay_Range
		{
			get
			{
				return this.alternative_Pay_RangeField;
			}
			set
			{
				this.alternative_Pay_RangeField = value;
				this.RaisePropertyChanged("Alternative_Pay_Range");
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
