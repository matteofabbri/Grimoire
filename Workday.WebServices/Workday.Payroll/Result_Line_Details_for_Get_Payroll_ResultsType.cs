using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Result_Line_Details_for_Get_Payroll_ResultsType : INotifyPropertyChanged
	{
		private Pay_Component_ReferenceType[] pay_Component_ReferenceField;

		private decimal pay_Component_FrequencyField;

		private bool pay_Component_FrequencyFieldSpecified;

		private decimal periods_Remaining_In_Calendar_YearField;

		private bool periods_Remaining_In_Calendar_YearFieldSpecified;

		private DateTime subperiod_Start_DateField;

		private bool subperiod_Start_DateFieldSpecified;

		private DateTime subperiod_End_DateField;

		private bool subperiod_End_DateFieldSpecified;

		private Payroll_Worktag_DataType payroll_Worktag_DataField;

		private decimal result_Line_AmountField;

		private bool result_Line_AmountFieldSpecified;

		private decimal result_Line_QTD_AmountField;

		private bool result_Line_QTD_AmountFieldSpecified;

		private decimal result_Line_YTD_AmountField;

		private bool result_Line_YTD_AmountFieldSpecified;

		private decimal result_Line_Arrears_AmountField;

		private bool result_Line_Arrears_AmountFieldSpecified;

		private Related_Calculation_Data_for_Get_Payroll_ResultsType[] related_Calculation_Result_DataField;

		private Withholding_Order_Data_for_Get_Payroll_ResultsType withholding_Order_DataField;

		private string payroll_Input_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Pay_Component_Reference", Order = 0)]
		public Pay_Component_ReferenceType[] Pay_Component_Reference
		{
			get
			{
				return this.pay_Component_ReferenceField;
			}
			set
			{
				this.pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Pay_Component_Frequency
		{
			get
			{
				return this.pay_Component_FrequencyField;
			}
			set
			{
				this.pay_Component_FrequencyField = value;
				this.RaisePropertyChanged("Pay_Component_Frequency");
			}
		}

		[XmlIgnore]
		public bool Pay_Component_FrequencySpecified
		{
			get
			{
				return this.pay_Component_FrequencyFieldSpecified;
			}
			set
			{
				this.pay_Component_FrequencyFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Component_FrequencySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Periods_Remaining_In_Calendar_Year
		{
			get
			{
				return this.periods_Remaining_In_Calendar_YearField;
			}
			set
			{
				this.periods_Remaining_In_Calendar_YearField = value;
				this.RaisePropertyChanged("Periods_Remaining_In_Calendar_Year");
			}
		}

		[XmlIgnore]
		public bool Periods_Remaining_In_Calendar_YearSpecified
		{
			get
			{
				return this.periods_Remaining_In_Calendar_YearFieldSpecified;
			}
			set
			{
				this.periods_Remaining_In_Calendar_YearFieldSpecified = value;
				this.RaisePropertyChanged("Periods_Remaining_In_Calendar_YearSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Subperiod_Start_Date
		{
			get
			{
				return this.subperiod_Start_DateField;
			}
			set
			{
				this.subperiod_Start_DateField = value;
				this.RaisePropertyChanged("Subperiod_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Subperiod_Start_DateSpecified
		{
			get
			{
				return this.subperiod_Start_DateFieldSpecified;
			}
			set
			{
				this.subperiod_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Subperiod_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Subperiod_End_Date
		{
			get
			{
				return this.subperiod_End_DateField;
			}
			set
			{
				this.subperiod_End_DateField = value;
				this.RaisePropertyChanged("Subperiod_End_Date");
			}
		}

		[XmlIgnore]
		public bool Subperiod_End_DateSpecified
		{
			get
			{
				return this.subperiod_End_DateFieldSpecified;
			}
			set
			{
				this.subperiod_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Subperiod_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Payroll_Worktag_DataType Payroll_Worktag_Data
		{
			get
			{
				return this.payroll_Worktag_DataField;
			}
			set
			{
				this.payroll_Worktag_DataField = value;
				this.RaisePropertyChanged("Payroll_Worktag_Data");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Result_Line_Amount
		{
			get
			{
				return this.result_Line_AmountField;
			}
			set
			{
				this.result_Line_AmountField = value;
				this.RaisePropertyChanged("Result_Line_Amount");
			}
		}

		[XmlIgnore]
		public bool Result_Line_AmountSpecified
		{
			get
			{
				return this.result_Line_AmountFieldSpecified;
			}
			set
			{
				this.result_Line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Result_Line_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Result_Line_QTD_Amount
		{
			get
			{
				return this.result_Line_QTD_AmountField;
			}
			set
			{
				this.result_Line_QTD_AmountField = value;
				this.RaisePropertyChanged("Result_Line_QTD_Amount");
			}
		}

		[XmlIgnore]
		public bool Result_Line_QTD_AmountSpecified
		{
			get
			{
				return this.result_Line_QTD_AmountFieldSpecified;
			}
			set
			{
				this.result_Line_QTD_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Result_Line_QTD_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Result_Line_YTD_Amount
		{
			get
			{
				return this.result_Line_YTD_AmountField;
			}
			set
			{
				this.result_Line_YTD_AmountField = value;
				this.RaisePropertyChanged("Result_Line_YTD_Amount");
			}
		}

		[XmlIgnore]
		public bool Result_Line_YTD_AmountSpecified
		{
			get
			{
				return this.result_Line_YTD_AmountFieldSpecified;
			}
			set
			{
				this.result_Line_YTD_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Result_Line_YTD_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Result_Line_Arrears_Amount
		{
			get
			{
				return this.result_Line_Arrears_AmountField;
			}
			set
			{
				this.result_Line_Arrears_AmountField = value;
				this.RaisePropertyChanged("Result_Line_Arrears_Amount");
			}
		}

		[XmlIgnore]
		public bool Result_Line_Arrears_AmountSpecified
		{
			get
			{
				return this.result_Line_Arrears_AmountFieldSpecified;
			}
			set
			{
				this.result_Line_Arrears_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Result_Line_Arrears_AmountSpecified");
			}
		}

		[XmlElement("Related_Calculation_Result_Data", Order = 10)]
		public Related_Calculation_Data_for_Get_Payroll_ResultsType[] Related_Calculation_Result_Data
		{
			get
			{
				return this.related_Calculation_Result_DataField;
			}
			set
			{
				this.related_Calculation_Result_DataField = value;
				this.RaisePropertyChanged("Related_Calculation_Result_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Withholding_Order_Data_for_Get_Payroll_ResultsType Withholding_Order_Data
		{
			get
			{
				return this.withholding_Order_DataField;
			}
			set
			{
				this.withholding_Order_DataField = value;
				this.RaisePropertyChanged("Withholding_Order_Data");
			}
		}

		[XmlElement(Order = 12)]
		public string Payroll_Input_Comment
		{
			get
			{
				return this.payroll_Input_CommentField;
			}
			set
			{
				this.payroll_Input_CommentField = value;
				this.RaisePropertyChanged("Payroll_Input_Comment");
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
