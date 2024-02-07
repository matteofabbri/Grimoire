using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Stock_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Stock_PlanObjectType compensation_Plan_ReferenceField;

		private decimal percent_of_Target_as_OptionField;

		private bool percent_of_Target_as_OptionFieldSpecified;

		private decimal percent_of_Target_as_StockField;

		private bool percent_of_Target_as_StockFieldSpecified;

		private decimal target_SharesField;

		private bool target_SharesFieldSpecified;

		private decimal individual_Target_SharesField;

		private bool individual_Target_SharesFieldSpecified;

		private decimal target_PercentField;

		private bool target_PercentFieldSpecified;

		private decimal individual_Target_AmountField;

		private bool individual_Target_AmountFieldSpecified;

		private decimal target_AmountField;

		private bool target_AmountFieldSpecified;

		private decimal individual_Target_PercentField;

		private bool individual_Target_PercentFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Stock_Vesting_ScheduleObjectType vesting_Schedule_ReferenceField;

		private Compensation_MatrixObjectType compensation_Matrix_ReferenceField;

		private DateTime assignment_Effective_DateField;

		private bool assignment_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_PlanObjectType Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Percent_of_Target_as_Option
		{
			get
			{
				return this.percent_of_Target_as_OptionField;
			}
			set
			{
				this.percent_of_Target_as_OptionField = value;
				this.RaisePropertyChanged("Percent_of_Target_as_Option");
			}
		}

		[XmlIgnore]
		public bool Percent_of_Target_as_OptionSpecified
		{
			get
			{
				return this.percent_of_Target_as_OptionFieldSpecified;
			}
			set
			{
				this.percent_of_Target_as_OptionFieldSpecified = value;
				this.RaisePropertyChanged("Percent_of_Target_as_OptionSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Percent_of_Target_as_Stock
		{
			get
			{
				return this.percent_of_Target_as_StockField;
			}
			set
			{
				this.percent_of_Target_as_StockField = value;
				this.RaisePropertyChanged("Percent_of_Target_as_Stock");
			}
		}

		[XmlIgnore]
		public bool Percent_of_Target_as_StockSpecified
		{
			get
			{
				return this.percent_of_Target_as_StockFieldSpecified;
			}
			set
			{
				this.percent_of_Target_as_StockFieldSpecified = value;
				this.RaisePropertyChanged("Percent_of_Target_as_StockSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Target_Shares
		{
			get
			{
				return this.target_SharesField;
			}
			set
			{
				this.target_SharesField = value;
				this.RaisePropertyChanged("Target_Shares");
			}
		}

		[XmlIgnore]
		public bool Target_SharesSpecified
		{
			get
			{
				return this.target_SharesFieldSpecified;
			}
			set
			{
				this.target_SharesFieldSpecified = value;
				this.RaisePropertyChanged("Target_SharesSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Individual_Target_Shares
		{
			get
			{
				return this.individual_Target_SharesField;
			}
			set
			{
				this.individual_Target_SharesField = value;
				this.RaisePropertyChanged("Individual_Target_Shares");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_SharesSpecified
		{
			get
			{
				return this.individual_Target_SharesFieldSpecified;
			}
			set
			{
				this.individual_Target_SharesFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_SharesSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Individual_Target_Amount
		{
			get
			{
				return this.individual_Target_AmountField;
			}
			set
			{
				this.individual_Target_AmountField = value;
				this.RaisePropertyChanged("Individual_Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_AmountSpecified
		{
			get
			{
				return this.individual_Target_AmountFieldSpecified;
			}
			set
			{
				this.individual_Target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Individual_Target_Percent
		{
			get
			{
				return this.individual_Target_PercentField;
			}
			set
			{
				this.individual_Target_PercentField = value;
				this.RaisePropertyChanged("Individual_Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_PercentSpecified
		{
			get
			{
				return this.individual_Target_PercentFieldSpecified;
			}
			set
			{
				this.individual_Target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Stock_Vesting_ScheduleObjectType Vesting_Schedule_Reference
		{
			get
			{
				return this.vesting_Schedule_ReferenceField;
			}
			set
			{
				this.vesting_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Vesting_Schedule_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Compensation_MatrixObjectType Compensation_Matrix_Reference
		{
			get
			{
				return this.compensation_Matrix_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Assignment_Effective_Date
		{
			get
			{
				return this.assignment_Effective_DateField;
			}
			set
			{
				this.assignment_Effective_DateField = value;
				this.RaisePropertyChanged("Assignment_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_Effective_DateSpecified
		{
			get
			{
				return this.assignment_Effective_DateFieldSpecified;
			}
			set
			{
				this.assignment_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_Effective_DateSpecified");
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
