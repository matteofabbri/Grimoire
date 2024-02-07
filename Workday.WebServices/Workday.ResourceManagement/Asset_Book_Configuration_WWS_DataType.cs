using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Book_Configuration_WWS_DataType : INotifyPropertyChanged
	{
		private Depreciation_ProfileObjectType depreciation_Profile_Override_ReferenceField;

		private Depreciation_MethodObjectType depreciation_Method_Override_ReferenceField;

		private decimal depreciation_Percent_OverrideField;

		private bool depreciation_Percent_OverrideFieldSpecified;

		private decimal useful_Life_in_Periods_OverrideField;

		private bool useful_Life_in_Periods_OverrideFieldSpecified;

		private decimal depreciation_Threshold_OverrideField;

		private bool depreciation_Threshold_OverrideFieldSpecified;

		private DateTime depreciation_Start_DateField;

		private bool depreciation_Start_DateFieldSpecified;

		private decimal remaining_Depreciation_PeriodsField;

		private bool remaining_Depreciation_PeriodsFieldSpecified;

		private decimal accumulated_DepreciationField;

		private bool accumulated_DepreciationFieldSpecified;

		private decimal year_To_Date_DepreciationField;

		private bool year_To_Date_DepreciationFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Depreciation_ProfileObjectType Depreciation_Profile_Override_Reference
		{
			get
			{
				return this.depreciation_Profile_Override_ReferenceField;
			}
			set
			{
				this.depreciation_Profile_Override_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Profile_Override_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Depreciation_MethodObjectType Depreciation_Method_Override_Reference
		{
			get
			{
				return this.depreciation_Method_Override_ReferenceField;
			}
			set
			{
				this.depreciation_Method_Override_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Method_Override_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Depreciation_Percent_Override
		{
			get
			{
				return this.depreciation_Percent_OverrideField;
			}
			set
			{
				this.depreciation_Percent_OverrideField = value;
				this.RaisePropertyChanged("Depreciation_Percent_Override");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Percent_OverrideSpecified
		{
			get
			{
				return this.depreciation_Percent_OverrideFieldSpecified;
			}
			set
			{
				this.depreciation_Percent_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Percent_OverrideSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Useful_Life_in_Periods_Override
		{
			get
			{
				return this.useful_Life_in_Periods_OverrideField;
			}
			set
			{
				this.useful_Life_in_Periods_OverrideField = value;
				this.RaisePropertyChanged("Useful_Life_in_Periods_Override");
			}
		}

		[XmlIgnore]
		public bool Useful_Life_in_Periods_OverrideSpecified
		{
			get
			{
				return this.useful_Life_in_Periods_OverrideFieldSpecified;
			}
			set
			{
				this.useful_Life_in_Periods_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Useful_Life_in_Periods_OverrideSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Depreciation_Threshold_Override
		{
			get
			{
				return this.depreciation_Threshold_OverrideField;
			}
			set
			{
				this.depreciation_Threshold_OverrideField = value;
				this.RaisePropertyChanged("Depreciation_Threshold_Override");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Threshold_OverrideSpecified
		{
			get
			{
				return this.depreciation_Threshold_OverrideFieldSpecified;
			}
			set
			{
				this.depreciation_Threshold_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Threshold_OverrideSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Depreciation_Start_Date
		{
			get
			{
				return this.depreciation_Start_DateField;
			}
			set
			{
				this.depreciation_Start_DateField = value;
				this.RaisePropertyChanged("Depreciation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Start_DateSpecified
		{
			get
			{
				return this.depreciation_Start_DateFieldSpecified;
			}
			set
			{
				this.depreciation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Remaining_Depreciation_Periods
		{
			get
			{
				return this.remaining_Depreciation_PeriodsField;
			}
			set
			{
				this.remaining_Depreciation_PeriodsField = value;
				this.RaisePropertyChanged("Remaining_Depreciation_Periods");
			}
		}

		[XmlIgnore]
		public bool Remaining_Depreciation_PeriodsSpecified
		{
			get
			{
				return this.remaining_Depreciation_PeriodsFieldSpecified;
			}
			set
			{
				this.remaining_Depreciation_PeriodsFieldSpecified = value;
				this.RaisePropertyChanged("Remaining_Depreciation_PeriodsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Accumulated_Depreciation
		{
			get
			{
				return this.accumulated_DepreciationField;
			}
			set
			{
				this.accumulated_DepreciationField = value;
				this.RaisePropertyChanged("Accumulated_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Accumulated_DepreciationSpecified
		{
			get
			{
				return this.accumulated_DepreciationFieldSpecified;
			}
			set
			{
				this.accumulated_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Accumulated_DepreciationSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Year_To_Date_Depreciation
		{
			get
			{
				return this.year_To_Date_DepreciationField;
			}
			set
			{
				this.year_To_Date_DepreciationField = value;
				this.RaisePropertyChanged("Year_To_Date_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Year_To_Date_DepreciationSpecified
		{
			get
			{
				return this.year_To_Date_DepreciationFieldSpecified;
			}
			set
			{
				this.year_To_Date_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Year_To_Date_DepreciationSpecified");
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
