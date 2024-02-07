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
	public class Asset_Depreciation_Schedule_DataType : INotifyPropertyChanged
	{
		private string asset_IDField;

		private Asset_BookObjectType asset_Book_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private Depreciation_ProfileObjectType depreciation_Profile_ReferenceField;

		private Depreciation_ConventionObjectType depreciation_Convention_ReferenceField;

		private Depreciation_MethodObjectType depreciation_Method_ReferenceField;

		private decimal depreciation_PercentField;

		private bool depreciation_PercentFieldSpecified;

		private decimal useful_Life__Periods_Field;

		private bool useful_Life__Periods_FieldSpecified;

		private decimal depreciation_ThresholdField;

		private bool depreciation_ThresholdFieldSpecified;

		private DateTime date_Placed_in_ServiceField;

		private bool date_Placed_in_ServiceFieldSpecified;

		private decimal bonus_Depreciation_PercentField;

		private bool bonus_Depreciation_PercentFieldSpecified;

		private decimal max_Bonus_Depreciable_BasisField;

		private bool max_Bonus_Depreciable_BasisFieldSpecified;

		private DateTime depreciation_Start_DateField;

		private bool depreciation_Start_DateFieldSpecified;

		private decimal remaining_Depreciation_PeriodsField;

		private bool remaining_Depreciation_PeriodsFieldSpecified;

		private decimal accumulated_DepreciationField;

		private bool accumulated_DepreciationFieldSpecified;

		private decimal year_to_Date_DepreciationField;

		private bool year_to_Date_DepreciationFieldSpecified;

		private decimal historical_Bonus_DepreciationField;

		private bool historical_Bonus_DepreciationFieldSpecified;

		private Asset_Depreciation_Schedule_Additional_InformationType asset_Book_Configuration_Additional_DataField;

		private Asset_for_Depreciation_Schedule_DataType asset_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Asset_ID
		{
			get
			{
				return this.asset_IDField;
			}
			set
			{
				this.asset_IDField = value;
				this.RaisePropertyChanged("Asset_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Asset_BookObjectType Asset_Book_Reference
		{
			get
			{
				return this.asset_Book_ReferenceField;
			}
			set
			{
				this.asset_Book_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Accounting_TreatmentObjectType Accounting_Treatment_Reference
		{
			get
			{
				return this.accounting_Treatment_ReferenceField;
			}
			set
			{
				this.accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Treatment_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Depreciation_ProfileObjectType Depreciation_Profile_Reference
		{
			get
			{
				return this.depreciation_Profile_ReferenceField;
			}
			set
			{
				this.depreciation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Profile_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Depreciation_ConventionObjectType Depreciation_Convention_Reference
		{
			get
			{
				return this.depreciation_Convention_ReferenceField;
			}
			set
			{
				this.depreciation_Convention_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Convention_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Depreciation_MethodObjectType Depreciation_Method_Reference
		{
			get
			{
				return this.depreciation_Method_ReferenceField;
			}
			set
			{
				this.depreciation_Method_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Method_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Depreciation_Percent
		{
			get
			{
				return this.depreciation_PercentField;
			}
			set
			{
				this.depreciation_PercentField = value;
				this.RaisePropertyChanged("Depreciation_Percent");
			}
		}

		[XmlIgnore]
		public bool Depreciation_PercentSpecified
		{
			get
			{
				return this.depreciation_PercentFieldSpecified;
			}
			set
			{
				this.depreciation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_PercentSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Useful_Life__Periods_
		{
			get
			{
				return this.useful_Life__Periods_Field;
			}
			set
			{
				this.useful_Life__Periods_Field = value;
				this.RaisePropertyChanged("Useful_Life__Periods_");
			}
		}

		[XmlIgnore]
		public bool Useful_Life__Periods_Specified
		{
			get
			{
				return this.useful_Life__Periods_FieldSpecified;
			}
			set
			{
				this.useful_Life__Periods_FieldSpecified = value;
				this.RaisePropertyChanged("Useful_Life__Periods_Specified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Depreciation_Threshold
		{
			get
			{
				return this.depreciation_ThresholdField;
			}
			set
			{
				this.depreciation_ThresholdField = value;
				this.RaisePropertyChanged("Depreciation_Threshold");
			}
		}

		[XmlIgnore]
		public bool Depreciation_ThresholdSpecified
		{
			get
			{
				return this.depreciation_ThresholdFieldSpecified;
			}
			set
			{
				this.depreciation_ThresholdFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_ThresholdSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Date_Placed_in_Service
		{
			get
			{
				return this.date_Placed_in_ServiceField;
			}
			set
			{
				this.date_Placed_in_ServiceField = value;
				this.RaisePropertyChanged("Date_Placed_in_Service");
			}
		}

		[XmlIgnore]
		public bool Date_Placed_in_ServiceSpecified
		{
			get
			{
				return this.date_Placed_in_ServiceFieldSpecified;
			}
			set
			{
				this.date_Placed_in_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Date_Placed_in_ServiceSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Bonus_Depreciation_Percent
		{
			get
			{
				return this.bonus_Depreciation_PercentField;
			}
			set
			{
				this.bonus_Depreciation_PercentField = value;
				this.RaisePropertyChanged("Bonus_Depreciation_Percent");
			}
		}

		[XmlIgnore]
		public bool Bonus_Depreciation_PercentSpecified
		{
			get
			{
				return this.bonus_Depreciation_PercentFieldSpecified;
			}
			set
			{
				this.bonus_Depreciation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Depreciation_PercentSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Max_Bonus_Depreciable_Basis
		{
			get
			{
				return this.max_Bonus_Depreciable_BasisField;
			}
			set
			{
				this.max_Bonus_Depreciable_BasisField = value;
				this.RaisePropertyChanged("Max_Bonus_Depreciable_Basis");
			}
		}

		[XmlIgnore]
		public bool Max_Bonus_Depreciable_BasisSpecified
		{
			get
			{
				return this.max_Bonus_Depreciable_BasisFieldSpecified;
			}
			set
			{
				this.max_Bonus_Depreciable_BasisFieldSpecified = value;
				this.RaisePropertyChanged("Max_Bonus_Depreciable_BasisSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public decimal Year_to_Date_Depreciation
		{
			get
			{
				return this.year_to_Date_DepreciationField;
			}
			set
			{
				this.year_to_Date_DepreciationField = value;
				this.RaisePropertyChanged("Year_to_Date_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Year_to_Date_DepreciationSpecified
		{
			get
			{
				return this.year_to_Date_DepreciationFieldSpecified;
			}
			set
			{
				this.year_to_Date_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Year_to_Date_DepreciationSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Historical_Bonus_Depreciation
		{
			get
			{
				return this.historical_Bonus_DepreciationField;
			}
			set
			{
				this.historical_Bonus_DepreciationField = value;
				this.RaisePropertyChanged("Historical_Bonus_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Historical_Bonus_DepreciationSpecified
		{
			get
			{
				return this.historical_Bonus_DepreciationFieldSpecified;
			}
			set
			{
				this.historical_Bonus_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Historical_Bonus_DepreciationSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Asset_Depreciation_Schedule_Additional_InformationType Asset_Book_Configuration_Additional_Data
		{
			get
			{
				return this.asset_Book_Configuration_Additional_DataField;
			}
			set
			{
				this.asset_Book_Configuration_Additional_DataField = value;
				this.RaisePropertyChanged("Asset_Book_Configuration_Additional_Data");
			}
		}

		[XmlElement(Order = 18)]
		public Asset_for_Depreciation_Schedule_DataType Asset_Data
		{
			get
			{
				return this.asset_DataField;
			}
			set
			{
				this.asset_DataField = value;
				this.RaisePropertyChanged("Asset_Data");
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
