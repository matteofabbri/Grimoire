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
	public class Allowance_Plan_Unit_DataType : INotifyPropertyChanged
	{
		private decimal per_Unit_AmountField;

		private bool per_Unit_AmountFieldSpecified;

		private decimal default_UnitsField;

		private bool default_UnitsFieldSpecified;

		private Unit_of_MeasureObjectType unit_Of_Measure_ReferenceField;

		private Allowance_Plan_Unit_Based_Profile_Replacement_DataType[] allowance_Plan_Unit_Based_Profile_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Per_Unit_Amount
		{
			get
			{
				return this.per_Unit_AmountField;
			}
			set
			{
				this.per_Unit_AmountField = value;
				this.RaisePropertyChanged("Per_Unit_Amount");
			}
		}

		[XmlIgnore]
		public bool Per_Unit_AmountSpecified
		{
			get
			{
				return this.per_Unit_AmountFieldSpecified;
			}
			set
			{
				this.per_Unit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Per_Unit_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Default_Units
		{
			get
			{
				return this.default_UnitsField;
			}
			set
			{
				this.default_UnitsField = value;
				this.RaisePropertyChanged("Default_Units");
			}
		}

		[XmlIgnore]
		public bool Default_UnitsSpecified
		{
			get
			{
				return this.default_UnitsFieldSpecified;
			}
			set
			{
				this.default_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Default_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Unit_of_MeasureObjectType Unit_Of_Measure_Reference
		{
			get
			{
				return this.unit_Of_Measure_ReferenceField;
			}
			set
			{
				this.unit_Of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Of_Measure_Reference");
			}
		}

		[XmlElement("Allowance_Plan_Unit_Based_Profile_Replacement_Data", Order = 3)]
		public Allowance_Plan_Unit_Based_Profile_Replacement_DataType[] Allowance_Plan_Unit_Based_Profile_Replacement_Data
		{
			get
			{
				return this.allowance_Plan_Unit_Based_Profile_Replacement_DataField;
			}
			set
			{
				this.allowance_Plan_Unit_Based_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Unit_Based_Profile_Replacement_Data");
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
