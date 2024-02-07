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
	public class Asset_Depreciation_Detail_Line_DataType : INotifyPropertyChanged
	{
		private decimal depreciation_PeriodField;

		private bool depreciation_PeriodFieldSpecified;

		private DateTime period_Ending_DateField;

		private bool period_Ending_DateFieldSpecified;

		private decimal depreciation_Number_Of_DaysField;

		private bool depreciation_Number_Of_DaysFieldSpecified;

		private decimal period_Depreciation_AmountField;

		private bool period_Depreciation_AmountFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private string depreciation_Adjustment_Transaction_TypeField;

		private bool bonus_DepreciationField;

		private bool bonus_DepreciationFieldSpecified;

		private DateTime recorded_On_DateField;

		private bool recorded_On_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Depreciation_Period
		{
			get
			{
				return this.depreciation_PeriodField;
			}
			set
			{
				this.depreciation_PeriodField = value;
				this.RaisePropertyChanged("Depreciation_Period");
			}
		}

		[XmlIgnore]
		public bool Depreciation_PeriodSpecified
		{
			get
			{
				return this.depreciation_PeriodFieldSpecified;
			}
			set
			{
				this.depreciation_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_PeriodSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Period_Ending_Date
		{
			get
			{
				return this.period_Ending_DateField;
			}
			set
			{
				this.period_Ending_DateField = value;
				this.RaisePropertyChanged("Period_Ending_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Ending_DateSpecified
		{
			get
			{
				return this.period_Ending_DateFieldSpecified;
			}
			set
			{
				this.period_Ending_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Ending_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Depreciation_Number_Of_Days
		{
			get
			{
				return this.depreciation_Number_Of_DaysField;
			}
			set
			{
				this.depreciation_Number_Of_DaysField = value;
				this.RaisePropertyChanged("Depreciation_Number_Of_Days");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Number_Of_DaysSpecified
		{
			get
			{
				return this.depreciation_Number_Of_DaysFieldSpecified;
			}
			set
			{
				this.depreciation_Number_Of_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Number_Of_DaysSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Period_Depreciation_Amount
		{
			get
			{
				return this.period_Depreciation_AmountField;
			}
			set
			{
				this.period_Depreciation_AmountField = value;
				this.RaisePropertyChanged("Period_Depreciation_Amount");
			}
		}

		[XmlIgnore]
		public bool Period_Depreciation_AmountSpecified
		{
			get
			{
				return this.period_Depreciation_AmountFieldSpecified;
			}
			set
			{
				this.period_Depreciation_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Period_Depreciation_AmountSpecified");
			}
		}

		[XmlElement("Worktag_Reference", Order = 4)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Depreciation_Adjustment_Transaction_Type
		{
			get
			{
				return this.depreciation_Adjustment_Transaction_TypeField;
			}
			set
			{
				this.depreciation_Adjustment_Transaction_TypeField = value;
				this.RaisePropertyChanged("Depreciation_Adjustment_Transaction_Type");
			}
		}

		[XmlElement(Order = 6)]
		public bool Bonus_Depreciation
		{
			get
			{
				return this.bonus_DepreciationField;
			}
			set
			{
				this.bonus_DepreciationField = value;
				this.RaisePropertyChanged("Bonus_Depreciation");
			}
		}

		[XmlIgnore]
		public bool Bonus_DepreciationSpecified
		{
			get
			{
				return this.bonus_DepreciationFieldSpecified;
			}
			set
			{
				this.bonus_DepreciationFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_DepreciationSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Recorded_On_Date
		{
			get
			{
				return this.recorded_On_DateField;
			}
			set
			{
				this.recorded_On_DateField = value;
				this.RaisePropertyChanged("Recorded_On_Date");
			}
		}

		[XmlIgnore]
		public bool Recorded_On_DateSpecified
		{
			get
			{
				return this.recorded_On_DateFieldSpecified;
			}
			set
			{
				this.recorded_On_DateFieldSpecified = value;
				this.RaisePropertyChanged("Recorded_On_DateSpecified");
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
