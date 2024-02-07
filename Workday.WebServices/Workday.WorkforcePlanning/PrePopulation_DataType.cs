using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Pre-Population_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class PrePopulation_DataType : INotifyPropertyChanged
	{
		private bool populate_with_Existing_DimensionsField;

		private bool populate_with_Existing_DimensionsFieldSpecified;

		private bool populate_with_Actual_HeadcountField;

		private bool populate_with_Actual_HeadcountFieldSpecified;

		private bool populate_with_Actual_FTEField;

		private bool populate_with_Actual_FTEFieldSpecified;

		private DateTime baseline_DateField;

		private bool baseline_DateFieldSpecified;

		private bool include_Baseline_ColumnField;

		private bool include_Baseline_ColumnFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Populate_with_Existing_Dimensions
		{
			get
			{
				return this.populate_with_Existing_DimensionsField;
			}
			set
			{
				this.populate_with_Existing_DimensionsField = value;
				this.RaisePropertyChanged("Populate_with_Existing_Dimensions");
			}
		}

		[XmlIgnore]
		public bool Populate_with_Existing_DimensionsSpecified
		{
			get
			{
				return this.populate_with_Existing_DimensionsFieldSpecified;
			}
			set
			{
				this.populate_with_Existing_DimensionsFieldSpecified = value;
				this.RaisePropertyChanged("Populate_with_Existing_DimensionsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Populate_with_Actual_Headcount
		{
			get
			{
				return this.populate_with_Actual_HeadcountField;
			}
			set
			{
				this.populate_with_Actual_HeadcountField = value;
				this.RaisePropertyChanged("Populate_with_Actual_Headcount");
			}
		}

		[XmlIgnore]
		public bool Populate_with_Actual_HeadcountSpecified
		{
			get
			{
				return this.populate_with_Actual_HeadcountFieldSpecified;
			}
			set
			{
				this.populate_with_Actual_HeadcountFieldSpecified = value;
				this.RaisePropertyChanged("Populate_with_Actual_HeadcountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Populate_with_Actual_FTE
		{
			get
			{
				return this.populate_with_Actual_FTEField;
			}
			set
			{
				this.populate_with_Actual_FTEField = value;
				this.RaisePropertyChanged("Populate_with_Actual_FTE");
			}
		}

		[XmlIgnore]
		public bool Populate_with_Actual_FTESpecified
		{
			get
			{
				return this.populate_with_Actual_FTEFieldSpecified;
			}
			set
			{
				this.populate_with_Actual_FTEFieldSpecified = value;
				this.RaisePropertyChanged("Populate_with_Actual_FTESpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Baseline_Date
		{
			get
			{
				return this.baseline_DateField;
			}
			set
			{
				this.baseline_DateField = value;
				this.RaisePropertyChanged("Baseline_Date");
			}
		}

		[XmlIgnore]
		public bool Baseline_DateSpecified
		{
			get
			{
				return this.baseline_DateFieldSpecified;
			}
			set
			{
				this.baseline_DateFieldSpecified = value;
				this.RaisePropertyChanged("Baseline_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Baseline_Column
		{
			get
			{
				return this.include_Baseline_ColumnField;
			}
			set
			{
				this.include_Baseline_ColumnField = value;
				this.RaisePropertyChanged("Include_Baseline_Column");
			}
		}

		[XmlIgnore]
		public bool Include_Baseline_ColumnSpecified
		{
			get
			{
				return this.include_Baseline_ColumnFieldSpecified;
			}
			set
			{
				this.include_Baseline_ColumnFieldSpecified = value;
				this.RaisePropertyChanged("Include_Baseline_ColumnSpecified");
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
