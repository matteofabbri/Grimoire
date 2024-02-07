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
	public class Stock_Plan_Amount_DataType : INotifyPropertyChanged
	{
		private Compensation_Rounding_RuleObjectType rounding_Rule_ReferenceField;

		private bool use_Target_CurrencyField;

		private bool use_Target_CurrencyFieldSpecified;

		private decimal target_AmountField;

		private bool target_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Stock_Vesting_ScheduleObjectType stock_Vesting_Schedule_ReferenceField;

		private Grant_Type_Split_Replacement_DataType[] grant_Split_Replacement_DataField;

		private Stock_Plan_Amount_Profile_Replacement_DataType[] stock_Plan_Amount_Profile_Replacement_DataField;

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
		public bool Use_Target_Currency
		{
			get
			{
				return this.use_Target_CurrencyField;
			}
			set
			{
				this.use_Target_CurrencyField = value;
				this.RaisePropertyChanged("Use_Target_Currency");
			}
		}

		[XmlIgnore]
		public bool Use_Target_CurrencySpecified
		{
			get
			{
				return this.use_Target_CurrencyFieldSpecified;
			}
			set
			{
				this.use_Target_CurrencyFieldSpecified = value;
				this.RaisePropertyChanged("Use_Target_CurrencySpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Grant_Split_Replacement_Data", Order = 5)]
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

		[XmlElement("Stock_Plan_Amount_Profile_Replacement_Data", Order = 6)]
		public Stock_Plan_Amount_Profile_Replacement_DataType[] Stock_Plan_Amount_Profile_Replacement_Data
		{
			get
			{
				return this.stock_Plan_Amount_Profile_Replacement_DataField;
			}
			set
			{
				this.stock_Plan_Amount_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Amount_Profile_Replacement_Data");
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
