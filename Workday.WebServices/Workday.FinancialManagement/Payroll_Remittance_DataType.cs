using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Remittance_DataType : INotifyPropertyChanged
	{
		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private Payroll_Withholding_StatusObjectType federal_Marital_Status_ReferenceField;

		private decimal federal_AllowanceField;

		private bool federal_AllowanceFieldSpecified;

		private decimal federal_Additional_AllowanceField;

		private bool federal_Additional_AllowanceFieldSpecified;

		private Payroll_Withholding_StatusObjectType work_State_Marital_Status_ReferenceField;

		private decimal work_State_AllowanceField;

		private bool work_State_AllowanceFieldSpecified;

		private decimal work_State_Additional_AmountField;

		private bool work_State_Additional_AmountFieldSpecified;

		private decimal calculated_Federal_Total_Claim_AmountField;

		private bool calculated_Federal_Total_Claim_AmountFieldSpecified;

		private decimal calculated_Provincial_Total_Claim_AmountField;

		private bool calculated_Provincial_Total_Claim_AmountFieldSpecified;

		private decimal federal_Total_Claim_AmountField;

		private bool federal_Total_Claim_AmountFieldSpecified;

		private decimal province_Total_Claim_AmountField;

		private bool province_Total_Claim_AmountFieldSpecified;

		private decimal federal_Living_Prescribed_ZoneField;

		private bool federal_Living_Prescribed_ZoneFieldSpecified;

		private decimal province_Living_Prescribed_ZoneField;

		private bool province_Living_Prescribed_ZoneFieldSpecified;

		private decimal federal_Additional_Tax_AmountsField;

		private bool federal_Additional_Tax_AmountsFieldSpecified;

		private decimal province_Additional_Tax_AmountsField;

		private bool province_Additional_Tax_AmountsFieldSpecified;

		private decimal federal_Annual_Deductions_CreditsField;

		private bool federal_Annual_Deductions_CreditsFieldSpecified;

		private decimal province_Annual_Deductions_CreditsField;

		private bool province_Annual_Deductions_CreditsFieldSpecified;

		private decimal federal_Labour_Sponsored_FundField;

		private bool federal_Labour_Sponsored_FundFieldSpecified;

		private decimal province_Labour_Sponsored_FundField;

		private bool province_Labour_Sponsored_FundFieldSpecified;

		private Pay_Group_DetailObjectType pay_Group_Detail_ReferenceField;

		private string frequency_NameField;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		private decimal total_UnitsField;

		private bool total_UnitsFieldSpecified;

		private decimal net_PayField;

		private bool net_PayFieldSpecified;

		private decimal taxes_DeductionsField;

		private bool taxes_DeductionsFieldSpecified;

		private bool print_PayslipField;

		private bool print_PayslipFieldSpecified;

		private bool print_Check_on_PayslipField;

		private bool print_Check_on_PayslipFieldSpecified;

		private string payslip_Distribution_Sorting_CriteriaField;

		private string oregon_Business_Identification_NumberField;

		private Pay_Rate_TypeObjectType pay_Rate_Type_ReferenceField;

		private Payroll_Remittance_Worker_DataType[] worker_DataField;

		private Address_Information_DataType[] work_Address_DataField;

		private Payroll_Remittance_Gross_And_Net_DataType[] gross_And_Net_DataField;

		private Payroll_Remittance_Total_DataType[] total_DataField;

		private Payroll_Remittance_Earnings_DataType[] earnings_DataField;

		private Payroll_Remittance_Pre_Tax_Deduction_DataType[] pre_Tax_Deductions_DataField;

		private Payroll_Remittance_Post_Tax_DataType[] post_Tax_Deductions_DataField;

		private Payroll_Remittance_Employee_Taxes_DataType[] employee_Taxes_DataField;

		private Payroll_Remittance_Employer_Paid_Benefits_DataType[] employer_Paid_Benefits_DataField;

		private Payroll_Remittance_Taxable_Wages_DataType[] taxable_Wages_DataField;

		private Payroll_Remittance_Absence_PlanType[] absence_Plans_DataField;

		private Payroll_Remittance_Payslip_Message_DataType[] payslip_Message_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public Payroll_Withholding_StatusObjectType Federal_Marital_Status_Reference
		{
			get
			{
				return this.federal_Marital_Status_ReferenceField;
			}
			set
			{
				this.federal_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Federal_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Federal_Allowance
		{
			get
			{
				return this.federal_AllowanceField;
			}
			set
			{
				this.federal_AllowanceField = value;
				this.RaisePropertyChanged("Federal_Allowance");
			}
		}

		[XmlIgnore]
		public bool Federal_AllowanceSpecified
		{
			get
			{
				return this.federal_AllowanceFieldSpecified;
			}
			set
			{
				this.federal_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Federal_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Federal_Additional_Allowance
		{
			get
			{
				return this.federal_Additional_AllowanceField;
			}
			set
			{
				this.federal_Additional_AllowanceField = value;
				this.RaisePropertyChanged("Federal_Additional_Allowance");
			}
		}

		[XmlIgnore]
		public bool Federal_Additional_AllowanceSpecified
		{
			get
			{
				return this.federal_Additional_AllowanceFieldSpecified;
			}
			set
			{
				this.federal_Additional_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Additional_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Payroll_Withholding_StatusObjectType Work_State_Marital_Status_Reference
		{
			get
			{
				return this.work_State_Marital_Status_ReferenceField;
			}
			set
			{
				this.work_State_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Work_State_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Work_State_Allowance
		{
			get
			{
				return this.work_State_AllowanceField;
			}
			set
			{
				this.work_State_AllowanceField = value;
				this.RaisePropertyChanged("Work_State_Allowance");
			}
		}

		[XmlIgnore]
		public bool Work_State_AllowanceSpecified
		{
			get
			{
				return this.work_State_AllowanceFieldSpecified;
			}
			set
			{
				this.work_State_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Work_State_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Work_State_Additional_Amount
		{
			get
			{
				return this.work_State_Additional_AmountField;
			}
			set
			{
				this.work_State_Additional_AmountField = value;
				this.RaisePropertyChanged("Work_State_Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Work_State_Additional_AmountSpecified
		{
			get
			{
				return this.work_State_Additional_AmountFieldSpecified;
			}
			set
			{
				this.work_State_Additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Work_State_Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Calculated_Federal_Total_Claim_Amount
		{
			get
			{
				return this.calculated_Federal_Total_Claim_AmountField;
			}
			set
			{
				this.calculated_Federal_Total_Claim_AmountField = value;
				this.RaisePropertyChanged("Calculated_Federal_Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Calculated_Federal_Total_Claim_AmountSpecified
		{
			get
			{
				return this.calculated_Federal_Total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.calculated_Federal_Total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Calculated_Federal_Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Calculated_Provincial_Total_Claim_Amount
		{
			get
			{
				return this.calculated_Provincial_Total_Claim_AmountField;
			}
			set
			{
				this.calculated_Provincial_Total_Claim_AmountField = value;
				this.RaisePropertyChanged("Calculated_Provincial_Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Calculated_Provincial_Total_Claim_AmountSpecified
		{
			get
			{
				return this.calculated_Provincial_Total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.calculated_Provincial_Total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Calculated_Provincial_Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Federal_Total_Claim_Amount
		{
			get
			{
				return this.federal_Total_Claim_AmountField;
			}
			set
			{
				this.federal_Total_Claim_AmountField = value;
				this.RaisePropertyChanged("Federal_Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Federal_Total_Claim_AmountSpecified
		{
			get
			{
				return this.federal_Total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.federal_Total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Province_Total_Claim_Amount
		{
			get
			{
				return this.province_Total_Claim_AmountField;
			}
			set
			{
				this.province_Total_Claim_AmountField = value;
				this.RaisePropertyChanged("Province_Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Province_Total_Claim_AmountSpecified
		{
			get
			{
				return this.province_Total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.province_Total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Province_Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Federal_Living_Prescribed_Zone
		{
			get
			{
				return this.federal_Living_Prescribed_ZoneField;
			}
			set
			{
				this.federal_Living_Prescribed_ZoneField = value;
				this.RaisePropertyChanged("Federal_Living_Prescribed_Zone");
			}
		}

		[XmlIgnore]
		public bool Federal_Living_Prescribed_ZoneSpecified
		{
			get
			{
				return this.federal_Living_Prescribed_ZoneFieldSpecified;
			}
			set
			{
				this.federal_Living_Prescribed_ZoneFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Living_Prescribed_ZoneSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Province_Living_Prescribed_Zone
		{
			get
			{
				return this.province_Living_Prescribed_ZoneField;
			}
			set
			{
				this.province_Living_Prescribed_ZoneField = value;
				this.RaisePropertyChanged("Province_Living_Prescribed_Zone");
			}
		}

		[XmlIgnore]
		public bool Province_Living_Prescribed_ZoneSpecified
		{
			get
			{
				return this.province_Living_Prescribed_ZoneFieldSpecified;
			}
			set
			{
				this.province_Living_Prescribed_ZoneFieldSpecified = value;
				this.RaisePropertyChanged("Province_Living_Prescribed_ZoneSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Federal_Additional_Tax_Amounts
		{
			get
			{
				return this.federal_Additional_Tax_AmountsField;
			}
			set
			{
				this.federal_Additional_Tax_AmountsField = value;
				this.RaisePropertyChanged("Federal_Additional_Tax_Amounts");
			}
		}

		[XmlIgnore]
		public bool Federal_Additional_Tax_AmountsSpecified
		{
			get
			{
				return this.federal_Additional_Tax_AmountsFieldSpecified;
			}
			set
			{
				this.federal_Additional_Tax_AmountsFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Additional_Tax_AmountsSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Province_Additional_Tax_Amounts
		{
			get
			{
				return this.province_Additional_Tax_AmountsField;
			}
			set
			{
				this.province_Additional_Tax_AmountsField = value;
				this.RaisePropertyChanged("Province_Additional_Tax_Amounts");
			}
		}

		[XmlIgnore]
		public bool Province_Additional_Tax_AmountsSpecified
		{
			get
			{
				return this.province_Additional_Tax_AmountsFieldSpecified;
			}
			set
			{
				this.province_Additional_Tax_AmountsFieldSpecified = value;
				this.RaisePropertyChanged("Province_Additional_Tax_AmountsSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Federal_Annual_Deductions_Credits
		{
			get
			{
				return this.federal_Annual_Deductions_CreditsField;
			}
			set
			{
				this.federal_Annual_Deductions_CreditsField = value;
				this.RaisePropertyChanged("Federal_Annual_Deductions_Credits");
			}
		}

		[XmlIgnore]
		public bool Federal_Annual_Deductions_CreditsSpecified
		{
			get
			{
				return this.federal_Annual_Deductions_CreditsFieldSpecified;
			}
			set
			{
				this.federal_Annual_Deductions_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Annual_Deductions_CreditsSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Province_Annual_Deductions_Credits
		{
			get
			{
				return this.province_Annual_Deductions_CreditsField;
			}
			set
			{
				this.province_Annual_Deductions_CreditsField = value;
				this.RaisePropertyChanged("Province_Annual_Deductions_Credits");
			}
		}

		[XmlIgnore]
		public bool Province_Annual_Deductions_CreditsSpecified
		{
			get
			{
				return this.province_Annual_Deductions_CreditsFieldSpecified;
			}
			set
			{
				this.province_Annual_Deductions_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Province_Annual_Deductions_CreditsSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Federal_Labour_Sponsored_Fund
		{
			get
			{
				return this.federal_Labour_Sponsored_FundField;
			}
			set
			{
				this.federal_Labour_Sponsored_FundField = value;
				this.RaisePropertyChanged("Federal_Labour_Sponsored_Fund");
			}
		}

		[XmlIgnore]
		public bool Federal_Labour_Sponsored_FundSpecified
		{
			get
			{
				return this.federal_Labour_Sponsored_FundFieldSpecified;
			}
			set
			{
				this.federal_Labour_Sponsored_FundFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Labour_Sponsored_FundSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Province_Labour_Sponsored_Fund
		{
			get
			{
				return this.province_Labour_Sponsored_FundField;
			}
			set
			{
				this.province_Labour_Sponsored_FundField = value;
				this.RaisePropertyChanged("Province_Labour_Sponsored_Fund");
			}
		}

		[XmlIgnore]
		public bool Province_Labour_Sponsored_FundSpecified
		{
			get
			{
				return this.province_Labour_Sponsored_FundFieldSpecified;
			}
			set
			{
				this.province_Labour_Sponsored_FundFieldSpecified = value;
				this.RaisePropertyChanged("Province_Labour_Sponsored_FundSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Pay_Group_DetailObjectType Pay_Group_Detail_Reference
		{
			get
			{
				return this.pay_Group_Detail_ReferenceField;
			}
			set
			{
				this.pay_Group_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Detail_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public string Frequency_Name
		{
			get
			{
				return this.frequency_NameField;
			}
			set
			{
				this.frequency_NameField = value;
				this.RaisePropertyChanged("Frequency_Name");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public decimal Total_Units
		{
			get
			{
				return this.total_UnitsField;
			}
			set
			{
				this.total_UnitsField = value;
				this.RaisePropertyChanged("Total_Units");
			}
		}

		[XmlIgnore]
		public bool Total_UnitsSpecified
		{
			get
			{
				return this.total_UnitsFieldSpecified;
			}
			set
			{
				this.total_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Total_UnitsSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Net_Pay
		{
			get
			{
				return this.net_PayField;
			}
			set
			{
				this.net_PayField = value;
				this.RaisePropertyChanged("Net_Pay");
			}
		}

		[XmlIgnore]
		public bool Net_PaySpecified
		{
			get
			{
				return this.net_PayFieldSpecified;
			}
			set
			{
				this.net_PayFieldSpecified = value;
				this.RaisePropertyChanged("Net_PaySpecified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Taxes_Deductions
		{
			get
			{
				return this.taxes_DeductionsField;
			}
			set
			{
				this.taxes_DeductionsField = value;
				this.RaisePropertyChanged("Taxes_Deductions");
			}
		}

		[XmlIgnore]
		public bool Taxes_DeductionsSpecified
		{
			get
			{
				return this.taxes_DeductionsFieldSpecified;
			}
			set
			{
				this.taxes_DeductionsFieldSpecified = value;
				this.RaisePropertyChanged("Taxes_DeductionsSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public bool Print_Payslip
		{
			get
			{
				return this.print_PayslipField;
			}
			set
			{
				this.print_PayslipField = value;
				this.RaisePropertyChanged("Print_Payslip");
			}
		}

		[XmlIgnore]
		public bool Print_PayslipSpecified
		{
			get
			{
				return this.print_PayslipFieldSpecified;
			}
			set
			{
				this.print_PayslipFieldSpecified = value;
				this.RaisePropertyChanged("Print_PayslipSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Print_Check_on_Payslip
		{
			get
			{
				return this.print_Check_on_PayslipField;
			}
			set
			{
				this.print_Check_on_PayslipField = value;
				this.RaisePropertyChanged("Print_Check_on_Payslip");
			}
		}

		[XmlIgnore]
		public bool Print_Check_on_PayslipSpecified
		{
			get
			{
				return this.print_Check_on_PayslipFieldSpecified;
			}
			set
			{
				this.print_Check_on_PayslipFieldSpecified = value;
				this.RaisePropertyChanged("Print_Check_on_PayslipSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public string Payslip_Distribution_Sorting_Criteria
		{
			get
			{
				return this.payslip_Distribution_Sorting_CriteriaField;
			}
			set
			{
				this.payslip_Distribution_Sorting_CriteriaField = value;
				this.RaisePropertyChanged("Payslip_Distribution_Sorting_Criteria");
			}
		}

		[XmlElement(Order = 29)]
		public string Oregon_Business_Identification_Number
		{
			get
			{
				return this.oregon_Business_Identification_NumberField;
			}
			set
			{
				this.oregon_Business_Identification_NumberField = value;
				this.RaisePropertyChanged("Oregon_Business_Identification_Number");
			}
		}

		[XmlElement(Order = 30)]
		public Pay_Rate_TypeObjectType Pay_Rate_Type_Reference
		{
			get
			{
				return this.pay_Rate_Type_ReferenceField;
			}
			set
			{
				this.pay_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Rate_Type_Reference");
			}
		}

		[XmlElement("Worker_Data", Order = 31)]
		public Payroll_Remittance_Worker_DataType[] Worker_Data
		{
			get
			{
				return this.worker_DataField;
			}
			set
			{
				this.worker_DataField = value;
				this.RaisePropertyChanged("Worker_Data");
			}
		}

		[XmlElement("Work_Address_Data", Order = 32)]
		public Address_Information_DataType[] Work_Address_Data
		{
			get
			{
				return this.work_Address_DataField;
			}
			set
			{
				this.work_Address_DataField = value;
				this.RaisePropertyChanged("Work_Address_Data");
			}
		}

		[XmlElement("Gross_And_Net_Data", Order = 33)]
		public Payroll_Remittance_Gross_And_Net_DataType[] Gross_And_Net_Data
		{
			get
			{
				return this.gross_And_Net_DataField;
			}
			set
			{
				this.gross_And_Net_DataField = value;
				this.RaisePropertyChanged("Gross_And_Net_Data");
			}
		}

		[XmlElement("Total_Data", Order = 34)]
		public Payroll_Remittance_Total_DataType[] Total_Data
		{
			get
			{
				return this.total_DataField;
			}
			set
			{
				this.total_DataField = value;
				this.RaisePropertyChanged("Total_Data");
			}
		}

		[XmlElement("Earnings_Data", Order = 35)]
		public Payroll_Remittance_Earnings_DataType[] Earnings_Data
		{
			get
			{
				return this.earnings_DataField;
			}
			set
			{
				this.earnings_DataField = value;
				this.RaisePropertyChanged("Earnings_Data");
			}
		}

		[XmlElement("Pre_Tax_Deductions_Data", Order = 36)]
		public Payroll_Remittance_Pre_Tax_Deduction_DataType[] Pre_Tax_Deductions_Data
		{
			get
			{
				return this.pre_Tax_Deductions_DataField;
			}
			set
			{
				this.pre_Tax_Deductions_DataField = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_Data");
			}
		}

		[XmlElement("Post_Tax_Deductions_Data", Order = 37)]
		public Payroll_Remittance_Post_Tax_DataType[] Post_Tax_Deductions_Data
		{
			get
			{
				return this.post_Tax_Deductions_DataField;
			}
			set
			{
				this.post_Tax_Deductions_DataField = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_Data");
			}
		}

		[XmlElement("Employee_Taxes_Data", Order = 38)]
		public Payroll_Remittance_Employee_Taxes_DataType[] Employee_Taxes_Data
		{
			get
			{
				return this.employee_Taxes_DataField;
			}
			set
			{
				this.employee_Taxes_DataField = value;
				this.RaisePropertyChanged("Employee_Taxes_Data");
			}
		}

		[XmlElement("Employer_Paid_Benefits_Data", Order = 39)]
		public Payroll_Remittance_Employer_Paid_Benefits_DataType[] Employer_Paid_Benefits_Data
		{
			get
			{
				return this.employer_Paid_Benefits_DataField;
			}
			set
			{
				this.employer_Paid_Benefits_DataField = value;
				this.RaisePropertyChanged("Employer_Paid_Benefits_Data");
			}
		}

		[XmlElement("Taxable_Wages_Data", Order = 40)]
		public Payroll_Remittance_Taxable_Wages_DataType[] Taxable_Wages_Data
		{
			get
			{
				return this.taxable_Wages_DataField;
			}
			set
			{
				this.taxable_Wages_DataField = value;
				this.RaisePropertyChanged("Taxable_Wages_Data");
			}
		}

		[XmlElement("Absence_Plans_Data", Order = 41)]
		public Payroll_Remittance_Absence_PlanType[] Absence_Plans_Data
		{
			get
			{
				return this.absence_Plans_DataField;
			}
			set
			{
				this.absence_Plans_DataField = value;
				this.RaisePropertyChanged("Absence_Plans_Data");
			}
		}

		[XmlElement("Payslip_Message_Data", Order = 42)]
		public Payroll_Remittance_Payslip_Message_DataType[] Payslip_Message_Data
		{
			get
			{
				return this.payslip_Message_DataField;
			}
			set
			{
				this.payslip_Message_DataField = value;
				this.RaisePropertyChanged("Payslip_Message_Data");
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
