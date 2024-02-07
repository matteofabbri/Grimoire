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
	public class Period_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private decimal default_Compensation_Period_MultiplierField;

		private bool default_Compensation_Period_MultiplierFieldSpecified;

		private Compensation_PeriodObjectType unit_of_Duration_ReferenceField;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private Period_Plan_Profile_Replacement_DataType[] period_Plan_Profile_Replacement_DataField;

		private Compensation_Setup_Security_SegmentObjectType[] compensation_Setup_Security_Segment_ReferenceField;

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

		[XmlElement(Order = 1)]
		public decimal Default_Compensation_Period_Multiplier
		{
			get
			{
				return this.default_Compensation_Period_MultiplierField;
			}
			set
			{
				this.default_Compensation_Period_MultiplierField = value;
				this.RaisePropertyChanged("Default_Compensation_Period_Multiplier");
			}
		}

		[XmlIgnore]
		public bool Default_Compensation_Period_MultiplierSpecified
		{
			get
			{
				return this.default_Compensation_Period_MultiplierFieldSpecified;
			}
			set
			{
				this.default_Compensation_Period_MultiplierFieldSpecified = value;
				this.RaisePropertyChanged("Default_Compensation_Period_MultiplierSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Compensation_PeriodObjectType Unit_of_Duration_Reference
		{
			get
			{
				return this.unit_of_Duration_ReferenceField;
			}
			set
			{
				this.unit_of_Duration_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Duration_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Compensation_BasisObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement("Period_Plan_Profile_Replacement_Data", Order = 4)]
		public Period_Plan_Profile_Replacement_DataType[] Period_Plan_Profile_Replacement_Data
		{
			get
			{
				return this.period_Plan_Profile_Replacement_DataField;
			}
			set
			{
				this.period_Plan_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Period_Plan_Profile_Replacement_Data");
			}
		}

		[XmlElement("Compensation_Setup_Security_Segment_Reference", Order = 5)]
		public Compensation_Setup_Security_SegmentObjectType[] Compensation_Setup_Security_Segment_Reference
		{
			get
			{
				return this.compensation_Setup_Security_Segment_ReferenceField;
			}
			set
			{
				this.compensation_Setup_Security_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Setup_Security_Segment_Reference");
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
