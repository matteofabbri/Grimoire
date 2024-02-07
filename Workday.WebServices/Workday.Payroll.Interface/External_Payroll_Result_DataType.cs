using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Payroll_Result_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Pay_GroupObjectType pay_Group_ReferenceField;

		private DateTime period_DateField;

		private DateTime payment_DateField;

		private string check_NumberField;

		private string batch_IDField;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		private decimal net_AmountField;

		private bool net_AmountFieldSpecified;

		private decimal allowance_Plan_1_AmountField;

		private bool allowance_Plan_1_AmountFieldSpecified;

		private decimal allowance_Plan_2_AmountField;

		private bool allowance_Plan_2_AmountFieldSpecified;

		private decimal bonus_Plan_1_AmountField;

		private bool bonus_Plan_1_AmountFieldSpecified;

		private decimal bonus_Plan_2_AmountField;

		private bool bonus_Plan_2_AmountFieldSpecified;

		private decimal commission_Plan_1_AmountField;

		private bool commission_Plan_1_AmountFieldSpecified;

		private decimal commission_Plan_2_AmountField;

		private bool commission_Plan_2_AmountFieldSpecified;

		private decimal eR_Paid_Deductions_1_AmountField;

		private bool eR_Paid_Deductions_1_AmountFieldSpecified;

		private decimal eR_Paid_Deductions_2_AmountField;

		private bool eR_Paid_Deductions_2_AmountFieldSpecified;

		private decimal imputed_Income_1_AmountField;

		private bool imputed_Income_1_AmountFieldSpecified;

		private decimal imputed_Income_2_AmountField;

		private bool imputed_Income_2_AmountFieldSpecified;

		private decimal merit_Plan_1_AmountField;

		private bool merit_Plan_1_AmountFieldSpecified;

		private decimal merit_Plan_2_AmountField;

		private bool merit_Plan_2_AmountFieldSpecified;

		private decimal non_Cash_Taxable_Benefits_AmountField;

		private bool non_Cash_Taxable_Benefits_AmountFieldSpecified;

		private decimal overtime_Amount_1Field;

		private bool overtime_Amount_1FieldSpecified;

		private decimal overtime_Hours_1Field;

		private bool overtime_Hours_1FieldSpecified;

		private decimal overtime_Amount_2Field;

		private bool overtime_Amount_2FieldSpecified;

		private decimal overtime_Hours_2Field;

		private bool overtime_Hours_2FieldSpecified;

		private decimal post_Tax_Deductions_AmountField;

		private bool post_Tax_Deductions_AmountFieldSpecified;

		private decimal post_Tax_Deductions_2_AmountField;

		private bool post_Tax_Deductions_2_AmountFieldSpecified;

		private decimal post_Tax_Deductions_3_AmountField;

		private bool post_Tax_Deductions_3_AmountFieldSpecified;

		private decimal post_Tax_Deductions_4_AmountField;

		private bool post_Tax_Deductions_4_AmountFieldSpecified;

		private decimal pre_Tax_Deductions_AmountField;

		private bool pre_Tax_Deductions_AmountFieldSpecified;

		private decimal pre_Tax_Deductions_2_AmountField;

		private bool pre_Tax_Deductions_2_AmountFieldSpecified;

		private decimal pre_Tax_Deductions_3_AmountField;

		private bool pre_Tax_Deductions_3_AmountFieldSpecified;

		private decimal pre_Tax_Deductions_4_AmountField;

		private bool pre_Tax_Deductions_4_AmountFieldSpecified;

		private decimal salary_Plan_1_AmountField;

		private bool salary_Plan_1_AmountFieldSpecified;

		private decimal salary_Plan_2_AmountField;

		private bool salary_Plan_2_AmountFieldSpecified;

		private decimal statutory_Taxes_Employee_AmountField;

		private bool statutory_Taxes_Employee_AmountFieldSpecified;

		private decimal statutory_Taxes_Employer_AmountField;

		private bool statutory_Taxes_Employer_AmountFieldSpecified;

		private decimal stock_Plan_1_AmountField;

		private bool stock_Plan_1_AmountFieldSpecified;

		private decimal stock_Plan_2_AmountField;

		private bool stock_Plan_2_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Pay_GroupObjectType Pay_Group_Reference
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Period_Date
		{
			get
			{
				return this.period_DateField;
			}
			set
			{
				this.period_DateField = value;
				this.RaisePropertyChanged("Period_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Check_Number
		{
			get
			{
				return this.check_NumberField;
			}
			set
			{
				this.check_NumberField = value;
				this.RaisePropertyChanged("Check_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Allowance_Plan_1_Amount
		{
			get
			{
				return this.allowance_Plan_1_AmountField;
			}
			set
			{
				this.allowance_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Allowance_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Allowance_Plan_1_AmountSpecified
		{
			get
			{
				return this.allowance_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.allowance_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Allowance_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Allowance_Plan_2_Amount
		{
			get
			{
				return this.allowance_Plan_2_AmountField;
			}
			set
			{
				this.allowance_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Allowance_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Allowance_Plan_2_AmountSpecified
		{
			get
			{
				return this.allowance_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.allowance_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Allowance_Plan_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Bonus_Plan_1_Amount
		{
			get
			{
				return this.bonus_Plan_1_AmountField;
			}
			set
			{
				this.bonus_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Bonus_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Bonus_Plan_1_AmountSpecified
		{
			get
			{
				return this.bonus_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.bonus_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Bonus_Plan_2_Amount
		{
			get
			{
				return this.bonus_Plan_2_AmountField;
			}
			set
			{
				this.bonus_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Bonus_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Bonus_Plan_2_AmountSpecified
		{
			get
			{
				return this.bonus_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.bonus_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Plan_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Commission_Plan_1_Amount
		{
			get
			{
				return this.commission_Plan_1_AmountField;
			}
			set
			{
				this.commission_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Commission_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Commission_Plan_1_AmountSpecified
		{
			get
			{
				return this.commission_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.commission_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Commission_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Commission_Plan_2_Amount
		{
			get
			{
				return this.commission_Plan_2_AmountField;
			}
			set
			{
				this.commission_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Commission_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Commission_Plan_2_AmountSpecified
		{
			get
			{
				return this.commission_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.commission_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Commission_Plan_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal ER_Paid_Deductions_1_Amount
		{
			get
			{
				return this.eR_Paid_Deductions_1_AmountField;
			}
			set
			{
				this.eR_Paid_Deductions_1_AmountField = value;
				this.RaisePropertyChanged("ER_Paid_Deductions_1_Amount");
			}
		}

		[XmlIgnore]
		public bool ER_Paid_Deductions_1_AmountSpecified
		{
			get
			{
				return this.eR_Paid_Deductions_1_AmountFieldSpecified;
			}
			set
			{
				this.eR_Paid_Deductions_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("ER_Paid_Deductions_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal ER_Paid_Deductions_2_Amount
		{
			get
			{
				return this.eR_Paid_Deductions_2_AmountField;
			}
			set
			{
				this.eR_Paid_Deductions_2_AmountField = value;
				this.RaisePropertyChanged("ER_Paid_Deductions_2_Amount");
			}
		}

		[XmlIgnore]
		public bool ER_Paid_Deductions_2_AmountSpecified
		{
			get
			{
				return this.eR_Paid_Deductions_2_AmountFieldSpecified;
			}
			set
			{
				this.eR_Paid_Deductions_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("ER_Paid_Deductions_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Imputed_Income_1_Amount
		{
			get
			{
				return this.imputed_Income_1_AmountField;
			}
			set
			{
				this.imputed_Income_1_AmountField = value;
				this.RaisePropertyChanged("Imputed_Income_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Imputed_Income_1_AmountSpecified
		{
			get
			{
				return this.imputed_Income_1_AmountFieldSpecified;
			}
			set
			{
				this.imputed_Income_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Imputed_Income_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Imputed_Income_2_Amount
		{
			get
			{
				return this.imputed_Income_2_AmountField;
			}
			set
			{
				this.imputed_Income_2_AmountField = value;
				this.RaisePropertyChanged("Imputed_Income_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Imputed_Income_2_AmountSpecified
		{
			get
			{
				return this.imputed_Income_2_AmountFieldSpecified;
			}
			set
			{
				this.imputed_Income_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Imputed_Income_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Merit_Plan_1_Amount
		{
			get
			{
				return this.merit_Plan_1_AmountField;
			}
			set
			{
				this.merit_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Merit_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Merit_Plan_1_AmountSpecified
		{
			get
			{
				return this.merit_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.merit_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Merit_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Merit_Plan_2_Amount
		{
			get
			{
				return this.merit_Plan_2_AmountField;
			}
			set
			{
				this.merit_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Merit_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Merit_Plan_2_AmountSpecified
		{
			get
			{
				return this.merit_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.merit_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Merit_Plan_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Non_Cash_Taxable_Benefits_Amount
		{
			get
			{
				return this.non_Cash_Taxable_Benefits_AmountField;
			}
			set
			{
				this.non_Cash_Taxable_Benefits_AmountField = value;
				this.RaisePropertyChanged("Non_Cash_Taxable_Benefits_Amount");
			}
		}

		[XmlIgnore]
		public bool Non_Cash_Taxable_Benefits_AmountSpecified
		{
			get
			{
				return this.non_Cash_Taxable_Benefits_AmountFieldSpecified;
			}
			set
			{
				this.non_Cash_Taxable_Benefits_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Non_Cash_Taxable_Benefits_AmountSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Overtime_Amount_1
		{
			get
			{
				return this.overtime_Amount_1Field;
			}
			set
			{
				this.overtime_Amount_1Field = value;
				this.RaisePropertyChanged("Overtime_Amount_1");
			}
		}

		[XmlIgnore]
		public bool Overtime_Amount_1Specified
		{
			get
			{
				return this.overtime_Amount_1FieldSpecified;
			}
			set
			{
				this.overtime_Amount_1FieldSpecified = value;
				this.RaisePropertyChanged("Overtime_Amount_1Specified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Overtime_Hours_1
		{
			get
			{
				return this.overtime_Hours_1Field;
			}
			set
			{
				this.overtime_Hours_1Field = value;
				this.RaisePropertyChanged("Overtime_Hours_1");
			}
		}

		[XmlIgnore]
		public bool Overtime_Hours_1Specified
		{
			get
			{
				return this.overtime_Hours_1FieldSpecified;
			}
			set
			{
				this.overtime_Hours_1FieldSpecified = value;
				this.RaisePropertyChanged("Overtime_Hours_1Specified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Overtime_Amount_2
		{
			get
			{
				return this.overtime_Amount_2Field;
			}
			set
			{
				this.overtime_Amount_2Field = value;
				this.RaisePropertyChanged("Overtime_Amount_2");
			}
		}

		[XmlIgnore]
		public bool Overtime_Amount_2Specified
		{
			get
			{
				return this.overtime_Amount_2FieldSpecified;
			}
			set
			{
				this.overtime_Amount_2FieldSpecified = value;
				this.RaisePropertyChanged("Overtime_Amount_2Specified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Overtime_Hours_2
		{
			get
			{
				return this.overtime_Hours_2Field;
			}
			set
			{
				this.overtime_Hours_2Field = value;
				this.RaisePropertyChanged("Overtime_Hours_2");
			}
		}

		[XmlIgnore]
		public bool Overtime_Hours_2Specified
		{
			get
			{
				return this.overtime_Hours_2FieldSpecified;
			}
			set
			{
				this.overtime_Hours_2FieldSpecified = value;
				this.RaisePropertyChanged("Overtime_Hours_2Specified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Post_Tax_Deductions_Amount
		{
			get
			{
				return this.post_Tax_Deductions_AmountField;
			}
			set
			{
				this.post_Tax_Deductions_AmountField = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_Amount");
			}
		}

		[XmlIgnore]
		public bool Post_Tax_Deductions_AmountSpecified
		{
			get
			{
				return this.post_Tax_Deductions_AmountFieldSpecified;
			}
			set
			{
				this.post_Tax_Deductions_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_AmountSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public decimal Post_Tax_Deductions_2_Amount
		{
			get
			{
				return this.post_Tax_Deductions_2_AmountField;
			}
			set
			{
				this.post_Tax_Deductions_2_AmountField = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Post_Tax_Deductions_2_AmountSpecified
		{
			get
			{
				return this.post_Tax_Deductions_2_AmountFieldSpecified;
			}
			set
			{
				this.post_Tax_Deductions_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public decimal Post_Tax_Deductions_3_Amount
		{
			get
			{
				return this.post_Tax_Deductions_3_AmountField;
			}
			set
			{
				this.post_Tax_Deductions_3_AmountField = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_3_Amount");
			}
		}

		[XmlIgnore]
		public bool Post_Tax_Deductions_3_AmountSpecified
		{
			get
			{
				return this.post_Tax_Deductions_3_AmountFieldSpecified;
			}
			set
			{
				this.post_Tax_Deductions_3_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_3_AmountSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public decimal Post_Tax_Deductions_4_Amount
		{
			get
			{
				return this.post_Tax_Deductions_4_AmountField;
			}
			set
			{
				this.post_Tax_Deductions_4_AmountField = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_4_Amount");
			}
		}

		[XmlIgnore]
		public bool Post_Tax_Deductions_4_AmountSpecified
		{
			get
			{
				return this.post_Tax_Deductions_4_AmountFieldSpecified;
			}
			set
			{
				this.post_Tax_Deductions_4_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Post_Tax_Deductions_4_AmountSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public decimal Pre_Tax_Deductions_Amount
		{
			get
			{
				return this.pre_Tax_Deductions_AmountField;
			}
			set
			{
				this.pre_Tax_Deductions_AmountField = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_Amount");
			}
		}

		[XmlIgnore]
		public bool Pre_Tax_Deductions_AmountSpecified
		{
			get
			{
				return this.pre_Tax_Deductions_AmountFieldSpecified;
			}
			set
			{
				this.pre_Tax_Deductions_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_AmountSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public decimal Pre_Tax_Deductions_2_Amount
		{
			get
			{
				return this.pre_Tax_Deductions_2_AmountField;
			}
			set
			{
				this.pre_Tax_Deductions_2_AmountField = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Pre_Tax_Deductions_2_AmountSpecified
		{
			get
			{
				return this.pre_Tax_Deductions_2_AmountFieldSpecified;
			}
			set
			{
				this.pre_Tax_Deductions_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal Pre_Tax_Deductions_3_Amount
		{
			get
			{
				return this.pre_Tax_Deductions_3_AmountField;
			}
			set
			{
				this.pre_Tax_Deductions_3_AmountField = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_3_Amount");
			}
		}

		[XmlIgnore]
		public bool Pre_Tax_Deductions_3_AmountSpecified
		{
			get
			{
				return this.pre_Tax_Deductions_3_AmountFieldSpecified;
			}
			set
			{
				this.pre_Tax_Deductions_3_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_3_AmountSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Pre_Tax_Deductions_4_Amount
		{
			get
			{
				return this.pre_Tax_Deductions_4_AmountField;
			}
			set
			{
				this.pre_Tax_Deductions_4_AmountField = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_4_Amount");
			}
		}

		[XmlIgnore]
		public bool Pre_Tax_Deductions_4_AmountSpecified
		{
			get
			{
				return this.pre_Tax_Deductions_4_AmountFieldSpecified;
			}
			set
			{
				this.pre_Tax_Deductions_4_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pre_Tax_Deductions_4_AmountSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public decimal Salary_Plan_1_Amount
		{
			get
			{
				return this.salary_Plan_1_AmountField;
			}
			set
			{
				this.salary_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Salary_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Salary_Plan_1_AmountSpecified
		{
			get
			{
				return this.salary_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.salary_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Salary_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public decimal Salary_Plan_2_Amount
		{
			get
			{
				return this.salary_Plan_2_AmountField;
			}
			set
			{
				this.salary_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Salary_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Salary_Plan_2_AmountSpecified
		{
			get
			{
				return this.salary_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.salary_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Salary_Plan_2_AmountSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public decimal Statutory_Taxes_Employee_Amount
		{
			get
			{
				return this.statutory_Taxes_Employee_AmountField;
			}
			set
			{
				this.statutory_Taxes_Employee_AmountField = value;
				this.RaisePropertyChanged("Statutory_Taxes_Employee_Amount");
			}
		}

		[XmlIgnore]
		public bool Statutory_Taxes_Employee_AmountSpecified
		{
			get
			{
				return this.statutory_Taxes_Employee_AmountFieldSpecified;
			}
			set
			{
				this.statutory_Taxes_Employee_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Statutory_Taxes_Employee_AmountSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public decimal Statutory_Taxes_Employer_Amount
		{
			get
			{
				return this.statutory_Taxes_Employer_AmountField;
			}
			set
			{
				this.statutory_Taxes_Employer_AmountField = value;
				this.RaisePropertyChanged("Statutory_Taxes_Employer_Amount");
			}
		}

		[XmlIgnore]
		public bool Statutory_Taxes_Employer_AmountSpecified
		{
			get
			{
				return this.statutory_Taxes_Employer_AmountFieldSpecified;
			}
			set
			{
				this.statutory_Taxes_Employer_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Statutory_Taxes_Employer_AmountSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Stock_Plan_1_Amount
		{
			get
			{
				return this.stock_Plan_1_AmountField;
			}
			set
			{
				this.stock_Plan_1_AmountField = value;
				this.RaisePropertyChanged("Stock_Plan_1_Amount");
			}
		}

		[XmlIgnore]
		public bool Stock_Plan_1_AmountSpecified
		{
			get
			{
				return this.stock_Plan_1_AmountFieldSpecified;
			}
			set
			{
				this.stock_Plan_1_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Stock_Plan_1_AmountSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public decimal Stock_Plan_2_Amount
		{
			get
			{
				return this.stock_Plan_2_AmountField;
			}
			set
			{
				this.stock_Plan_2_AmountField = value;
				this.RaisePropertyChanged("Stock_Plan_2_Amount");
			}
		}

		[XmlIgnore]
		public bool Stock_Plan_2_AmountSpecified
		{
			get
			{
				return this.stock_Plan_2_AmountFieldSpecified;
			}
			set
			{
				this.stock_Plan_2_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Stock_Plan_2_AmountSpecified");
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
