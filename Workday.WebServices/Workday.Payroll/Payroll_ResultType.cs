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
	public class Payroll_ResultType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Name_DataType[] employee_Name_DataField;

		private National_ID_DataType[] national_ID_DataField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_IDObjectType payroll_ID_ReferenceField;

		private string payroll_Account_NumberField;

		private EstablishmentObjectType establishment_ReferenceField;

		private Pay_Group_DetailObjectType pay_Group_ReferenceField;

		private Run_CategoryObjectType run_Category_ReferenceField;

		private decimal pay_Period_FrequencyField;

		private bool pay_Period_FrequencyFieldSpecified;

		private Payroll_Offcycle_TypeObjectType offcycle_Type_ReferenceField;

		private bool for_Additional_PayField;

		private bool for_Additional_PayFieldSpecified;

		private DateTime result_Completed_Date_TimeField;

		private bool result_Completed_Date_TimeFieldSpecified;

		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private DateTime subperiod_Start_DateField;

		private bool subperiod_Start_DateFieldSpecified;

		private DateTime subperiod_End_DateField;

		private bool subperiod_End_DateFieldSpecified;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		private decimal net_AmountField;

		private bool net_AmountFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		private Result_Line_Details_for_Get_Payroll_ResultsType[] payroll_Result_DataField;

		private Pay_Accumulation_Data_for_Get_Payroll_ResultsType[] pay_Accumulation_DataField;

		private DateTime payment_Date_of_Original_Payroll_ResultField;

		private bool payment_Date_of_Original_Payroll_ResultFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Name_Data", IsNullable = false)]
		public Name_DataType[] Employee_Name_Data
		{
			get
			{
				return this.employee_Name_DataField;
			}
			set
			{
				this.employee_Name_DataField = value;
				this.RaisePropertyChanged("Employee_Name_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("National_ID_Data", IsNullable = false)]
		public National_ID_DataType[] National_ID_Data
		{
			get
			{
				return this.national_ID_DataField;
			}
			set
			{
				this.national_ID_DataField = value;
				this.RaisePropertyChanged("National_ID_Data");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_IDObjectType Payroll_ID_Reference
		{
			get
			{
				return this.payroll_ID_ReferenceField;
			}
			set
			{
				this.payroll_ID_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_ID_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Payroll_Account_Number
		{
			get
			{
				return this.payroll_Account_NumberField;
			}
			set
			{
				this.payroll_Account_NumberField = value;
				this.RaisePropertyChanged("Payroll_Account_Number");
			}
		}

		[XmlElement(Order = 6)]
		public EstablishmentObjectType Establishment_Reference
		{
			get
			{
				return this.establishment_ReferenceField;
			}
			set
			{
				this.establishment_ReferenceField = value;
				this.RaisePropertyChanged("Establishment_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Pay_Group_DetailObjectType Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Run_CategoryObjectType Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Pay_Period_Frequency
		{
			get
			{
				return this.pay_Period_FrequencyField;
			}
			set
			{
				this.pay_Period_FrequencyField = value;
				this.RaisePropertyChanged("Pay_Period_Frequency");
			}
		}

		[XmlIgnore]
		public bool Pay_Period_FrequencySpecified
		{
			get
			{
				return this.pay_Period_FrequencyFieldSpecified;
			}
			set
			{
				this.pay_Period_FrequencyFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Period_FrequencySpecified");
			}
		}

		[XmlElement("Off-cycle_Type_Reference", Order = 10)]
		public Payroll_Offcycle_TypeObjectType Offcycle_Type_Reference
		{
			get
			{
				return this.offcycle_Type_ReferenceField;
			}
			set
			{
				this.offcycle_Type_ReferenceField = value;
				this.RaisePropertyChanged("Offcycle_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool For_Additional_Pay
		{
			get
			{
				return this.for_Additional_PayField;
			}
			set
			{
				this.for_Additional_PayField = value;
				this.RaisePropertyChanged("For_Additional_Pay");
			}
		}

		[XmlIgnore]
		public bool For_Additional_PaySpecified
		{
			get
			{
				return this.for_Additional_PayFieldSpecified;
			}
			set
			{
				this.for_Additional_PayFieldSpecified = value;
				this.RaisePropertyChanged("For_Additional_PaySpecified");
			}
		}

		[XmlElement(Order = 12)]
		public DateTime Result_Completed_Date_Time
		{
			get
			{
				return this.result_Completed_Date_TimeField;
			}
			set
			{
				this.result_Completed_Date_TimeField = value;
				this.RaisePropertyChanged("Result_Completed_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Result_Completed_Date_TimeSpecified
		{
			get
			{
				return this.result_Completed_Date_TimeFieldSpecified;
			}
			set
			{
				this.result_Completed_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Result_Completed_Date_TimeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Start_DateSpecified
		{
			get
			{
				return this.period_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
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

		[XmlElement(DataType = "date", Order = 16)]
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

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Gross_Amount
		{
			get
			{
				return this.gross_AmountField;
			}
			set
			{
				this.gross_AmountField = value;
				this.RaisePropertyChanged("Gross_Amount");
			}
		}

		[XmlIgnore]
		public bool Gross_AmountSpecified
		{
			get
			{
				return this.gross_AmountFieldSpecified;
			}
			set
			{
				this.gross_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Gross_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Net_Amount
		{
			get
			{
				return this.net_AmountField;
			}
			set
			{
				this.net_AmountField = value;
				this.RaisePropertyChanged("Net_Amount");
			}
		}

		[XmlIgnore]
		public bool Net_AmountSpecified
		{
			get
			{
				return this.net_AmountFieldSpecified;
			}
			set
			{
				this.net_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Net_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Currency_Reference_DataType Currency_Reference
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

		[XmlElement("Payroll_Result_Data", Order = 21)]
		public Result_Line_Details_for_Get_Payroll_ResultsType[] Payroll_Result_Data
		{
			get
			{
				return this.payroll_Result_DataField;
			}
			set
			{
				this.payroll_Result_DataField = value;
				this.RaisePropertyChanged("Payroll_Result_Data");
			}
		}

		[XmlElement("Pay_Accumulation_Data", Order = 22)]
		public Pay_Accumulation_Data_for_Get_Payroll_ResultsType[] Pay_Accumulation_Data
		{
			get
			{
				return this.pay_Accumulation_DataField;
			}
			set
			{
				this.pay_Accumulation_DataField = value;
				this.RaisePropertyChanged("Pay_Accumulation_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 23)]
		public DateTime Payment_Date_of_Original_Payroll_Result
		{
			get
			{
				return this.payment_Date_of_Original_Payroll_ResultField;
			}
			set
			{
				this.payment_Date_of_Original_Payroll_ResultField = value;
				this.RaisePropertyChanged("Payment_Date_of_Original_Payroll_Result");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_of_Original_Payroll_ResultSpecified
		{
			get
			{
				return this.payment_Date_of_Original_Payroll_ResultFieldSpecified;
			}
			set
			{
				this.payment_Date_of_Original_Payroll_ResultFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_of_Original_Payroll_ResultSpecified");
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
