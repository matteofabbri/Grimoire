using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class NSLDS_Transaction__HV__DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime date_Last_UpdatedField;

		private bool date_Last_UpdatedFieldSpecified;

		private bool defaulted_Loan_FlagField;

		private bool defaulted_Loan_FlagFieldSpecified;

		private NSLDS_Discharged_Loan_FlagObjectType discharged_Loan_Flag_ReferenceField;

		private bool fraud_Loan_FlagField;

		private bool fraud_Loan_FlagFieldSpecified;

		private bool loan_Satisfactory_Repayment_FlagField;

		private bool loan_Satisfactory_Repayment_FlagFieldSpecified;

		private bool active_Bankruptcy_FlagField;

		private bool active_Bankruptcy_FlagFieldSpecified;

		private decimal aggregate_Subsidized_Outstanding_Principal_BalanceField;

		private bool aggregate_Subsidized_Outstanding_Principal_BalanceFieldSpecified;

		private decimal aggregate_Unsubsidized_Outstanding_Principal_BalanceField;

		private bool aggregate_Unsubsidized_Outstanding_Principal_BalanceFieldSpecified;

		private decimal aggregate_Combined_Outstanding_Principal_BalanceField;

		private bool aggregate_Combined_Outstanding_Principal_BalanceFieldSpecified;

		private decimal perkins_Total_Outstanding_Principal_BalanceField;

		private bool perkins_Total_Outstanding_Principal_BalanceFieldSpecified;

		private decimal aggregate_Teach_Undergraduate_Disbursement_AmountField;

		private bool aggregate_Teach_Undergraduate_Disbursement_AmountFieldSpecified;

		private decimal aggregate_TEACH_Graduate_Disbursement_AmountField;

		private bool aggregate_TEACH_Graduate_Disbursement_AmountFieldSpecified;

		private bool loan_Change_FlagField;

		private bool loan_Change_FlagFieldSpecified;

		private bool defaulted_Loan_Change_FlagField;

		private bool defaulted_Loan_Change_FlagFieldSpecified;

		private bool fraud_Loan_Change_FlagField;

		private bool fraud_Loan_Change_FlagFieldSpecified;

		private bool discharged_Loan_Change_FlagField;

		private bool discharged_Loan_Change_FlagFieldSpecified;

		private bool loan_Satisfactory_Repayment_Change_FlagField;

		private bool loan_Satisfactory_Repayment_Change_FlagFieldSpecified;

		private bool active_Bankruptcy_Change_FlagField;

		private bool active_Bankruptcy_Change_FlagFieldSpecified;

		private bool tEACH_Grant_to_Loan_Conversion_Change_FlagField;

		private bool tEACH_Grant_to_Loan_Conversion_Change_FlagFieldSpecified;

		private bool overpayments_Change_FlagField;

		private bool overpayments_Change_FlagFieldSpecified;

		private bool aggregate_Loan_Change_FlagField;

		private bool aggregate_Loan_Change_FlagFieldSpecified;

		private bool perkins_Loan_Change_FlagField;

		private bool perkins_Loan_Change_FlagFieldSpecified;

		private bool pell_Payment_Change_FlagField;

		private bool pell_Payment_Change_FlagFieldSpecified;

		private bool tEACH_Grant_Change_FlagField;

		private bool tEACH_Grant_Change_FlagFieldSpecified;

		private NSLDS_Direct_Loan_Master_Promissory_Note_FlagObjectType direct_Loan_Master_Promissory_Note_Flag_ReferenceField;

		private NSLDS_Direct_Loan_PLUS_Master_Promissory_Note_FlagObjectType direct_Loan_PLUS_Master_Promissory_Note_Flag_ReferenceField;

		private NSLDS_Direct_Loan_PLUS_Master_Promissory_Note_FlagObjectType direct_Loan_Graduate_PLUS_Master_Promissory_Note_Flag_ReferenceField;

		private NSLDS_Loan_Limit_FlagObjectType undergraduate_Subsidized_Loan_Limit_Flag_ReferenceField;

		private NSLDS_Loan_Limit_FlagObjectType undergraduate_Combined_Loan_Limit_Flag_ReferenceField;

		private NSLDS_Loan_Limit_FlagObjectType graduate_Subsidized_Loan_Limit_Flag_ReferenceField;

		private NSLDS_Loan_Limit_FlagObjectType graduate_Combined_Loan_Limit_Flag_ReferenceField;

		private decimal pell_Lifetime_Eligibility_UsedField;

		private bool pell_Lifetime_Eligibility_UsedFieldSpecified;

		private bool subsidized_Usage_Limit_Applies_FlagField;

		private bool subsidized_Usage_Limit_Applies_FlagFieldSpecified;

		private decimal subsidized_Usage_PeriodField;

		private bool subsidized_Usage_PeriodFieldSpecified;

		private NSLDS_Overpayment_FlagObjectType pell_Overpayment_Flag_ReferenceField;

		private NSLDS_Overpayment_FlagObjectType sEOG_Overpayment_Flag_ReferenceField;

		private NSLDS_Overpayment_FlagObjectType perkins_Overpayment_Flag_ReferenceField;

		private NSLDS_Overpayment_FlagObjectType tEACH_Grant_Overpayment_Flag_ReferenceField;

		private NSLDS_Overpayment_FlagObjectType iraq_and_Afghanistan_Service_Grant_Overpayment_Flag_ReferenceField;

		private NSLDS_Limit_FlagObjectType pell_Lifetime_Limit_Flag_ReferenceField;

		private NSLDS_Pell_Grant_DataType[] nSLDS_Pell_Grant_DataField;

		private NSLDS_TEACH_Grant_DataType[] nSLDS_TEACH_Grant_DataField;

		private NSLDS_Loan_DataType[] nSLDS_Loan_DataField;

		private NSLDS_Student_DataType nSLDS_Student_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_Last_Updated
		{
			get
			{
				return this.date_Last_UpdatedField;
			}
			set
			{
				this.date_Last_UpdatedField = value;
				this.RaisePropertyChanged("Date_Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Date_Last_UpdatedSpecified
		{
			get
			{
				return this.date_Last_UpdatedFieldSpecified;
			}
			set
			{
				this.date_Last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Last_UpdatedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Defaulted_Loan_Flag
		{
			get
			{
				return this.defaulted_Loan_FlagField;
			}
			set
			{
				this.defaulted_Loan_FlagField = value;
				this.RaisePropertyChanged("Defaulted_Loan_Flag");
			}
		}

		[XmlIgnore]
		public bool Defaulted_Loan_FlagSpecified
		{
			get
			{
				return this.defaulted_Loan_FlagFieldSpecified;
			}
			set
			{
				this.defaulted_Loan_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Defaulted_Loan_FlagSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public NSLDS_Discharged_Loan_FlagObjectType Discharged_Loan_Flag_Reference
		{
			get
			{
				return this.discharged_Loan_Flag_ReferenceField;
			}
			set
			{
				this.discharged_Loan_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Discharged_Loan_Flag_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Fraud_Loan_Flag
		{
			get
			{
				return this.fraud_Loan_FlagField;
			}
			set
			{
				this.fraud_Loan_FlagField = value;
				this.RaisePropertyChanged("Fraud_Loan_Flag");
			}
		}

		[XmlIgnore]
		public bool Fraud_Loan_FlagSpecified
		{
			get
			{
				return this.fraud_Loan_FlagFieldSpecified;
			}
			set
			{
				this.fraud_Loan_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Fraud_Loan_FlagSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Loan_Satisfactory_Repayment_Flag
		{
			get
			{
				return this.loan_Satisfactory_Repayment_FlagField;
			}
			set
			{
				this.loan_Satisfactory_Repayment_FlagField = value;
				this.RaisePropertyChanged("Loan_Satisfactory_Repayment_Flag");
			}
		}

		[XmlIgnore]
		public bool Loan_Satisfactory_Repayment_FlagSpecified
		{
			get
			{
				return this.loan_Satisfactory_Repayment_FlagFieldSpecified;
			}
			set
			{
				this.loan_Satisfactory_Repayment_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Satisfactory_Repayment_FlagSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Active_Bankruptcy_Flag
		{
			get
			{
				return this.active_Bankruptcy_FlagField;
			}
			set
			{
				this.active_Bankruptcy_FlagField = value;
				this.RaisePropertyChanged("Active_Bankruptcy_Flag");
			}
		}

		[XmlIgnore]
		public bool Active_Bankruptcy_FlagSpecified
		{
			get
			{
				return this.active_Bankruptcy_FlagFieldSpecified;
			}
			set
			{
				this.active_Bankruptcy_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Active_Bankruptcy_FlagSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Aggregate_Subsidized_Outstanding_Principal_Balance
		{
			get
			{
				return this.aggregate_Subsidized_Outstanding_Principal_BalanceField;
			}
			set
			{
				this.aggregate_Subsidized_Outstanding_Principal_BalanceField = value;
				this.RaisePropertyChanged("Aggregate_Subsidized_Outstanding_Principal_Balance");
			}
		}

		[XmlIgnore]
		public bool Aggregate_Subsidized_Outstanding_Principal_BalanceSpecified
		{
			get
			{
				return this.aggregate_Subsidized_Outstanding_Principal_BalanceFieldSpecified;
			}
			set
			{
				this.aggregate_Subsidized_Outstanding_Principal_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_Subsidized_Outstanding_Principal_BalanceSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Aggregate_Unsubsidized_Outstanding_Principal_Balance
		{
			get
			{
				return this.aggregate_Unsubsidized_Outstanding_Principal_BalanceField;
			}
			set
			{
				this.aggregate_Unsubsidized_Outstanding_Principal_BalanceField = value;
				this.RaisePropertyChanged("Aggregate_Unsubsidized_Outstanding_Principal_Balance");
			}
		}

		[XmlIgnore]
		public bool Aggregate_Unsubsidized_Outstanding_Principal_BalanceSpecified
		{
			get
			{
				return this.aggregate_Unsubsidized_Outstanding_Principal_BalanceFieldSpecified;
			}
			set
			{
				this.aggregate_Unsubsidized_Outstanding_Principal_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_Unsubsidized_Outstanding_Principal_BalanceSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Aggregate_Combined_Outstanding_Principal_Balance
		{
			get
			{
				return this.aggregate_Combined_Outstanding_Principal_BalanceField;
			}
			set
			{
				this.aggregate_Combined_Outstanding_Principal_BalanceField = value;
				this.RaisePropertyChanged("Aggregate_Combined_Outstanding_Principal_Balance");
			}
		}

		[XmlIgnore]
		public bool Aggregate_Combined_Outstanding_Principal_BalanceSpecified
		{
			get
			{
				return this.aggregate_Combined_Outstanding_Principal_BalanceFieldSpecified;
			}
			set
			{
				this.aggregate_Combined_Outstanding_Principal_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_Combined_Outstanding_Principal_BalanceSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Perkins_Total_Outstanding_Principal_Balance
		{
			get
			{
				return this.perkins_Total_Outstanding_Principal_BalanceField;
			}
			set
			{
				this.perkins_Total_Outstanding_Principal_BalanceField = value;
				this.RaisePropertyChanged("Perkins_Total_Outstanding_Principal_Balance");
			}
		}

		[XmlIgnore]
		public bool Perkins_Total_Outstanding_Principal_BalanceSpecified
		{
			get
			{
				return this.perkins_Total_Outstanding_Principal_BalanceFieldSpecified;
			}
			set
			{
				this.perkins_Total_Outstanding_Principal_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Perkins_Total_Outstanding_Principal_BalanceSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Aggregate_Teach_Undergraduate_Disbursement_Amount
		{
			get
			{
				return this.aggregate_Teach_Undergraduate_Disbursement_AmountField;
			}
			set
			{
				this.aggregate_Teach_Undergraduate_Disbursement_AmountField = value;
				this.RaisePropertyChanged("Aggregate_Teach_Undergraduate_Disbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Aggregate_Teach_Undergraduate_Disbursement_AmountSpecified
		{
			get
			{
				return this.aggregate_Teach_Undergraduate_Disbursement_AmountFieldSpecified;
			}
			set
			{
				this.aggregate_Teach_Undergraduate_Disbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_Teach_Undergraduate_Disbursement_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Aggregate_TEACH_Graduate_Disbursement_Amount
		{
			get
			{
				return this.aggregate_TEACH_Graduate_Disbursement_AmountField;
			}
			set
			{
				this.aggregate_TEACH_Graduate_Disbursement_AmountField = value;
				this.RaisePropertyChanged("Aggregate_TEACH_Graduate_Disbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Aggregate_TEACH_Graduate_Disbursement_AmountSpecified
		{
			get
			{
				return this.aggregate_TEACH_Graduate_Disbursement_AmountFieldSpecified;
			}
			set
			{
				this.aggregate_TEACH_Graduate_Disbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_TEACH_Graduate_Disbursement_AmountSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Loan_Change_Flag
		{
			get
			{
				return this.loan_Change_FlagField;
			}
			set
			{
				this.loan_Change_FlagField = value;
				this.RaisePropertyChanged("Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Loan_Change_FlagSpecified
		{
			get
			{
				return this.loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Defaulted_Loan_Change_Flag
		{
			get
			{
				return this.defaulted_Loan_Change_FlagField;
			}
			set
			{
				this.defaulted_Loan_Change_FlagField = value;
				this.RaisePropertyChanged("Defaulted_Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Defaulted_Loan_Change_FlagSpecified
		{
			get
			{
				return this.defaulted_Loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.defaulted_Loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Defaulted_Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Fraud_Loan_Change_Flag
		{
			get
			{
				return this.fraud_Loan_Change_FlagField;
			}
			set
			{
				this.fraud_Loan_Change_FlagField = value;
				this.RaisePropertyChanged("Fraud_Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Fraud_Loan_Change_FlagSpecified
		{
			get
			{
				return this.fraud_Loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.fraud_Loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Fraud_Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Discharged_Loan_Change_Flag
		{
			get
			{
				return this.discharged_Loan_Change_FlagField;
			}
			set
			{
				this.discharged_Loan_Change_FlagField = value;
				this.RaisePropertyChanged("Discharged_Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Discharged_Loan_Change_FlagSpecified
		{
			get
			{
				return this.discharged_Loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.discharged_Loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Discharged_Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Loan_Satisfactory_Repayment_Change_Flag
		{
			get
			{
				return this.loan_Satisfactory_Repayment_Change_FlagField;
			}
			set
			{
				this.loan_Satisfactory_Repayment_Change_FlagField = value;
				this.RaisePropertyChanged("Loan_Satisfactory_Repayment_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Loan_Satisfactory_Repayment_Change_FlagSpecified
		{
			get
			{
				return this.loan_Satisfactory_Repayment_Change_FlagFieldSpecified;
			}
			set
			{
				this.loan_Satisfactory_Repayment_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Loan_Satisfactory_Repayment_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Active_Bankruptcy_Change_Flag
		{
			get
			{
				return this.active_Bankruptcy_Change_FlagField;
			}
			set
			{
				this.active_Bankruptcy_Change_FlagField = value;
				this.RaisePropertyChanged("Active_Bankruptcy_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Active_Bankruptcy_Change_FlagSpecified
		{
			get
			{
				return this.active_Bankruptcy_Change_FlagFieldSpecified;
			}
			set
			{
				this.active_Bankruptcy_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Active_Bankruptcy_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool TEACH_Grant_to_Loan_Conversion_Change_Flag
		{
			get
			{
				return this.tEACH_Grant_to_Loan_Conversion_Change_FlagField;
			}
			set
			{
				this.tEACH_Grant_to_Loan_Conversion_Change_FlagField = value;
				this.RaisePropertyChanged("TEACH_Grant_to_Loan_Conversion_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_to_Loan_Conversion_Change_FlagSpecified
		{
			get
			{
				return this.tEACH_Grant_to_Loan_Conversion_Change_FlagFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_to_Loan_Conversion_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_to_Loan_Conversion_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Overpayments_Change_Flag
		{
			get
			{
				return this.overpayments_Change_FlagField;
			}
			set
			{
				this.overpayments_Change_FlagField = value;
				this.RaisePropertyChanged("Overpayments_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Overpayments_Change_FlagSpecified
		{
			get
			{
				return this.overpayments_Change_FlagFieldSpecified;
			}
			set
			{
				this.overpayments_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Overpayments_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Aggregate_Loan_Change_Flag
		{
			get
			{
				return this.aggregate_Loan_Change_FlagField;
			}
			set
			{
				this.aggregate_Loan_Change_FlagField = value;
				this.RaisePropertyChanged("Aggregate_Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Aggregate_Loan_Change_FlagSpecified
		{
			get
			{
				return this.aggregate_Loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.aggregate_Loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Aggregate_Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Perkins_Loan_Change_Flag
		{
			get
			{
				return this.perkins_Loan_Change_FlagField;
			}
			set
			{
				this.perkins_Loan_Change_FlagField = value;
				this.RaisePropertyChanged("Perkins_Loan_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Perkins_Loan_Change_FlagSpecified
		{
			get
			{
				return this.perkins_Loan_Change_FlagFieldSpecified;
			}
			set
			{
				this.perkins_Loan_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Perkins_Loan_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Pell_Payment_Change_Flag
		{
			get
			{
				return this.pell_Payment_Change_FlagField;
			}
			set
			{
				this.pell_Payment_Change_FlagField = value;
				this.RaisePropertyChanged("Pell_Payment_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Pell_Payment_Change_FlagSpecified
		{
			get
			{
				return this.pell_Payment_Change_FlagFieldSpecified;
			}
			set
			{
				this.pell_Payment_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Payment_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool TEACH_Grant_Change_Flag
		{
			get
			{
				return this.tEACH_Grant_Change_FlagField;
			}
			set
			{
				this.tEACH_Grant_Change_FlagField = value;
				this.RaisePropertyChanged("TEACH_Grant_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_Change_FlagSpecified
		{
			get
			{
				return this.tEACH_Grant_Change_FlagFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public NSLDS_Direct_Loan_Master_Promissory_Note_FlagObjectType Direct_Loan_Master_Promissory_Note_Flag_Reference
		{
			get
			{
				return this.direct_Loan_Master_Promissory_Note_Flag_ReferenceField;
			}
			set
			{
				this.direct_Loan_Master_Promissory_Note_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Direct_Loan_Master_Promissory_Note_Flag_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public NSLDS_Direct_Loan_PLUS_Master_Promissory_Note_FlagObjectType Direct_Loan_PLUS_Master_Promissory_Note_Flag_Reference
		{
			get
			{
				return this.direct_Loan_PLUS_Master_Promissory_Note_Flag_ReferenceField;
			}
			set
			{
				this.direct_Loan_PLUS_Master_Promissory_Note_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Direct_Loan_PLUS_Master_Promissory_Note_Flag_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public NSLDS_Direct_Loan_PLUS_Master_Promissory_Note_FlagObjectType Direct_Loan_Graduate_PLUS_Master_Promissory_Note_Flag_Reference
		{
			get
			{
				return this.direct_Loan_Graduate_PLUS_Master_Promissory_Note_Flag_ReferenceField;
			}
			set
			{
				this.direct_Loan_Graduate_PLUS_Master_Promissory_Note_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Direct_Loan_Graduate_PLUS_Master_Promissory_Note_Flag_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public NSLDS_Loan_Limit_FlagObjectType Undergraduate_Subsidized_Loan_Limit_Flag_Reference
		{
			get
			{
				return this.undergraduate_Subsidized_Loan_Limit_Flag_ReferenceField;
			}
			set
			{
				this.undergraduate_Subsidized_Loan_Limit_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Undergraduate_Subsidized_Loan_Limit_Flag_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public NSLDS_Loan_Limit_FlagObjectType Undergraduate_Combined_Loan_Limit_Flag_Reference
		{
			get
			{
				return this.undergraduate_Combined_Loan_Limit_Flag_ReferenceField;
			}
			set
			{
				this.undergraduate_Combined_Loan_Limit_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Undergraduate_Combined_Loan_Limit_Flag_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public NSLDS_Loan_Limit_FlagObjectType Graduate_Subsidized_Loan_Limit_Flag_Reference
		{
			get
			{
				return this.graduate_Subsidized_Loan_Limit_Flag_ReferenceField;
			}
			set
			{
				this.graduate_Subsidized_Loan_Limit_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Graduate_Subsidized_Loan_Limit_Flag_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public NSLDS_Loan_Limit_FlagObjectType Graduate_Combined_Loan_Limit_Flag_Reference
		{
			get
			{
				return this.graduate_Combined_Loan_Limit_Flag_ReferenceField;
			}
			set
			{
				this.graduate_Combined_Loan_Limit_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Graduate_Combined_Loan_Limit_Flag_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Pell_Lifetime_Eligibility_Used
		{
			get
			{
				return this.pell_Lifetime_Eligibility_UsedField;
			}
			set
			{
				this.pell_Lifetime_Eligibility_UsedField = value;
				this.RaisePropertyChanged("Pell_Lifetime_Eligibility_Used");
			}
		}

		[XmlIgnore]
		public bool Pell_Lifetime_Eligibility_UsedSpecified
		{
			get
			{
				return this.pell_Lifetime_Eligibility_UsedFieldSpecified;
			}
			set
			{
				this.pell_Lifetime_Eligibility_UsedFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Lifetime_Eligibility_UsedSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public bool Subsidized_Usage_Limit_Applies_Flag
		{
			get
			{
				return this.subsidized_Usage_Limit_Applies_FlagField;
			}
			set
			{
				this.subsidized_Usage_Limit_Applies_FlagField = value;
				this.RaisePropertyChanged("Subsidized_Usage_Limit_Applies_Flag");
			}
		}

		[XmlIgnore]
		public bool Subsidized_Usage_Limit_Applies_FlagSpecified
		{
			get
			{
				return this.subsidized_Usage_Limit_Applies_FlagFieldSpecified;
			}
			set
			{
				this.subsidized_Usage_Limit_Applies_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Subsidized_Usage_Limit_Applies_FlagSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public decimal Subsidized_Usage_Period
		{
			get
			{
				return this.subsidized_Usage_PeriodField;
			}
			set
			{
				this.subsidized_Usage_PeriodField = value;
				this.RaisePropertyChanged("Subsidized_Usage_Period");
			}
		}

		[XmlIgnore]
		public bool Subsidized_Usage_PeriodSpecified
		{
			get
			{
				return this.subsidized_Usage_PeriodFieldSpecified;
			}
			set
			{
				this.subsidized_Usage_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Subsidized_Usage_PeriodSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public NSLDS_Overpayment_FlagObjectType Pell_Overpayment_Flag_Reference
		{
			get
			{
				return this.pell_Overpayment_Flag_ReferenceField;
			}
			set
			{
				this.pell_Overpayment_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Pell_Overpayment_Flag_Reference");
			}
		}

		[XmlElement(Order = 36)]
		public NSLDS_Overpayment_FlagObjectType SEOG_Overpayment_Flag_Reference
		{
			get
			{
				return this.sEOG_Overpayment_Flag_ReferenceField;
			}
			set
			{
				this.sEOG_Overpayment_Flag_ReferenceField = value;
				this.RaisePropertyChanged("SEOG_Overpayment_Flag_Reference");
			}
		}

		[XmlElement(Order = 37)]
		public NSLDS_Overpayment_FlagObjectType Perkins_Overpayment_Flag_Reference
		{
			get
			{
				return this.perkins_Overpayment_Flag_ReferenceField;
			}
			set
			{
				this.perkins_Overpayment_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Perkins_Overpayment_Flag_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public NSLDS_Overpayment_FlagObjectType TEACH_Grant_Overpayment_Flag_Reference
		{
			get
			{
				return this.tEACH_Grant_Overpayment_Flag_ReferenceField;
			}
			set
			{
				this.tEACH_Grant_Overpayment_Flag_ReferenceField = value;
				this.RaisePropertyChanged("TEACH_Grant_Overpayment_Flag_Reference");
			}
		}

		[XmlElement(Order = 39)]
		public NSLDS_Overpayment_FlagObjectType Iraq_and_Afghanistan_Service_Grant_Overpayment_Flag_Reference
		{
			get
			{
				return this.iraq_and_Afghanistan_Service_Grant_Overpayment_Flag_ReferenceField;
			}
			set
			{
				this.iraq_and_Afghanistan_Service_Grant_Overpayment_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Iraq_and_Afghanistan_Service_Grant_Overpayment_Flag_Reference");
			}
		}

		[XmlElement(Order = 40)]
		public NSLDS_Limit_FlagObjectType Pell_Lifetime_Limit_Flag_Reference
		{
			get
			{
				return this.pell_Lifetime_Limit_Flag_ReferenceField;
			}
			set
			{
				this.pell_Lifetime_Limit_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Pell_Lifetime_Limit_Flag_Reference");
			}
		}

		[XmlElement("NSLDS_Pell_Grant_Data", Order = 41)]
		public NSLDS_Pell_Grant_DataType[] NSLDS_Pell_Grant_Data
		{
			get
			{
				return this.nSLDS_Pell_Grant_DataField;
			}
			set
			{
				this.nSLDS_Pell_Grant_DataField = value;
				this.RaisePropertyChanged("NSLDS_Pell_Grant_Data");
			}
		}

		[XmlElement("NSLDS_TEACH_Grant_Data", Order = 42)]
		public NSLDS_TEACH_Grant_DataType[] NSLDS_TEACH_Grant_Data
		{
			get
			{
				return this.nSLDS_TEACH_Grant_DataField;
			}
			set
			{
				this.nSLDS_TEACH_Grant_DataField = value;
				this.RaisePropertyChanged("NSLDS_TEACH_Grant_Data");
			}
		}

		[XmlElement("NSLDS_Loan_Data", Order = 43)]
		public NSLDS_Loan_DataType[] NSLDS_Loan_Data
		{
			get
			{
				return this.nSLDS_Loan_DataField;
			}
			set
			{
				this.nSLDS_Loan_DataField = value;
				this.RaisePropertyChanged("NSLDS_Loan_Data");
			}
		}

		[XmlElement(Order = 44)]
		public NSLDS_Student_DataType NSLDS_Student_Data
		{
			get
			{
				return this.nSLDS_Student_DataField;
			}
			set
			{
				this.nSLDS_Student_DataField = value;
				this.RaisePropertyChanged("NSLDS_Student_Data");
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
