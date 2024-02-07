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
	public class Unit_Salary_Plan_DataType : INotifyPropertyChanged
	{
		private decimal per_Unit_AmountField;

		private bool per_Unit_AmountFieldSpecified;

		private decimal default_UnitsField;

		private bool default_UnitsFieldSpecified;

		private Unit_of_MeasureObjectType unit_Of_Measure_ReferenceField;

		private bool no_Individual_OverrideField;

		private bool no_Individual_OverrideFieldSpecified;

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

		[XmlElement(Order = 3)]
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
