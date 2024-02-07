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
	public class Stock_Plan_Percent_DataType : INotifyPropertyChanged
	{
		private Compensation_Rounding_RuleObjectType rounding_Rule_ReferenceField;

		private decimal target_PercentField;

		private bool target_PercentFieldSpecified;

		private Stock_Vesting_ScheduleObjectType stock_Vesting_Schedule_ReferenceField;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private Grant_Type_Split_Replacement_DataType[] grant_Split_Replacement_DataField;

		private Stock_Plan_Percent_Profile_Replacement_DataType[] stock_Plan_Percent_Profile_Default_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Rounding_RuleObjectType Rounding_Rule_Reference
		{
			get
			{
				return this.rounding_Rule_ReferenceField;
			}
			set
			{
				this.rounding_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Rounding_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Target_Percent
		{
			get
			{
				return this.target_PercentField;
			}
			set
			{
				this.target_PercentField = value;
				this.RaisePropertyChanged("Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Target_PercentSpecified
		{
			get
			{
				return this.target_PercentFieldSpecified;
			}
			set
			{
				this.target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Stock_Vesting_ScheduleObjectType Stock_Vesting_Schedule_Reference
		{
			get
			{
				return this.stock_Vesting_Schedule_ReferenceField;
			}
			set
			{
				this.stock_Vesting_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Vesting_Schedule_Reference");
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

		[XmlElement("Grant_Split_Replacement_Data", Order = 4)]
		public Grant_Type_Split_Replacement_DataType[] Grant_Split_Replacement_Data
		{
			get
			{
				return this.grant_Split_Replacement_DataField;
			}
			set
			{
				this.grant_Split_Replacement_DataField = value;
				this.RaisePropertyChanged("Grant_Split_Replacement_Data");
			}
		}

		[XmlElement("Stock_Plan_Percent_Profile_Default_Replacement_Data", Order = 5)]
		public Stock_Plan_Percent_Profile_Replacement_DataType[] Stock_Plan_Percent_Profile_Default_Replacement_Data
		{
			get
			{
				return this.stock_Plan_Percent_Profile_Default_Replacement_DataField;
			}
			set
			{
				this.stock_Plan_Percent_Profile_Default_Replacement_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Percent_Profile_Default_Replacement_Data");
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
