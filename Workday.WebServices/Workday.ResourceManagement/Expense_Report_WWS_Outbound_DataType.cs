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
	public class Expense_Report_WWS_Outbound_DataType : INotifyPropertyChanged
	{
		private string expense_Report_IDField;

		private Expense_PayeeObjectType expense_Payee_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string expense_Report_NumberField;

		private DateTime expense_Report_DateField;

		private bool expense_Report_DateFieldSpecified;

		private DateTime expense_Report_Approval_DateField;

		private bool expense_Report_Approval_DateFieldSpecified;

		private string expense_Report_StatusField;

		private string budget_Check_StatusField;

		private CommitteeObjectType committee_ReferenceField;

		private Business_PurposeObjectType business_Purpose_ReferenceField;

		private decimal expense_Report_Total_AmountField;

		private bool expense_Report_Total_AmountFieldSpecified;

		private decimal expense_Report_Total_Reimbursement_AmountField;

		private bool expense_Report_Total_Reimbursement_AmountFieldSpecified;

		private decimal cash_Advance_Applied_AmountField;

		private bool cash_Advance_Applied_AmountFieldSpecified;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Spend_AuthorizationObjectType spend_Authorization_ReferenceField;

		private bool final_Expense_Report_for_Spend_AuthorizationField;

		private bool final_Expense_Report_for_Spend_AuthorizationFieldSpecified;

		private SupplierObjectType supplier_ReferenceField;

		private string memoField;

		private Expense_Report_Line_WWS_Outbound_DataType[] expense_Report_Lines_Reference_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Expense_Report_ID
		{
			get
			{
				return this.expense_Report_IDField;
			}
			set
			{
				this.expense_Report_IDField = value;
				this.RaisePropertyChanged("Expense_Report_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_PayeeObjectType Expense_Payee_Reference
		{
			get
			{
				return this.expense_Payee_ReferenceField;
			}
			set
			{
				this.expense_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Reference");
			}
		}

		[XmlElement(Order = 2)]
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
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Expense_Report_Number
		{
			get
			{
				return this.expense_Report_NumberField;
			}
			set
			{
				this.expense_Report_NumberField = value;
				this.RaisePropertyChanged("Expense_Report_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Expense_Report_Date
		{
			get
			{
				return this.expense_Report_DateField;
			}
			set
			{
				this.expense_Report_DateField = value;
				this.RaisePropertyChanged("Expense_Report_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_DateSpecified
		{
			get
			{
				return this.expense_Report_DateFieldSpecified;
			}
			set
			{
				this.expense_Report_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Expense_Report_Approval_Date
		{
			get
			{
				return this.expense_Report_Approval_DateField;
			}
			set
			{
				this.expense_Report_Approval_DateField = value;
				this.RaisePropertyChanged("Expense_Report_Approval_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_Approval_DateSpecified
		{
			get
			{
				return this.expense_Report_Approval_DateFieldSpecified;
			}
			set
			{
				this.expense_Report_Approval_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_Approval_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Expense_Report_Status
		{
			get
			{
				return this.expense_Report_StatusField;
			}
			set
			{
				this.expense_Report_StatusField = value;
				this.RaisePropertyChanged("Expense_Report_Status");
			}
		}

		[XmlElement(Order = 9)]
		public string Budget_Check_Status
		{
			get
			{
				return this.budget_Check_StatusField;
			}
			set
			{
				this.budget_Check_StatusField = value;
				this.RaisePropertyChanged("Budget_Check_Status");
			}
		}

		[XmlElement(Order = 10)]
		public CommitteeObjectType Committee_Reference
		{
			get
			{
				return this.committee_ReferenceField;
			}
			set
			{
				this.committee_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Business_PurposeObjectType Business_Purpose_Reference
		{
			get
			{
				return this.business_Purpose_ReferenceField;
			}
			set
			{
				this.business_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Business_Purpose_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Expense_Report_Total_Amount
		{
			get
			{
				return this.expense_Report_Total_AmountField;
			}
			set
			{
				this.expense_Report_Total_AmountField = value;
				this.RaisePropertyChanged("Expense_Report_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_Total_AmountSpecified
		{
			get
			{
				return this.expense_Report_Total_AmountFieldSpecified;
			}
			set
			{
				this.expense_Report_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Expense_Report_Total_Reimbursement_Amount
		{
			get
			{
				return this.expense_Report_Total_Reimbursement_AmountField;
			}
			set
			{
				this.expense_Report_Total_Reimbursement_AmountField = value;
				this.RaisePropertyChanged("Expense_Report_Total_Reimbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Expense_Report_Total_Reimbursement_AmountSpecified
		{
			get
			{
				return this.expense_Report_Total_Reimbursement_AmountFieldSpecified;
			}
			set
			{
				this.expense_Report_Total_Reimbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_Total_Reimbursement_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Cash_Advance_Applied_Amount
		{
			get
			{
				return this.cash_Advance_Applied_AmountField;
			}
			set
			{
				this.cash_Advance_Applied_AmountField = value;
				this.RaisePropertyChanged("Cash_Advance_Applied_Amount");
			}
		}

		[XmlIgnore]
		public bool Cash_Advance_Applied_AmountSpecified
		{
			get
			{
				return this.cash_Advance_Applied_AmountFieldSpecified;
			}
			set
			{
				this.cash_Advance_Applied_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Cash_Advance_Applied_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Spend_AuthorizationObjectType Spend_Authorization_Reference
		{
			get
			{
				return this.spend_Authorization_ReferenceField;
			}
			set
			{
				this.spend_Authorization_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Authorization_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public bool Final_Expense_Report_for_Spend_Authorization
		{
			get
			{
				return this.final_Expense_Report_for_Spend_AuthorizationField;
			}
			set
			{
				this.final_Expense_Report_for_Spend_AuthorizationField = value;
				this.RaisePropertyChanged("Final_Expense_Report_for_Spend_Authorization");
			}
		}

		[XmlIgnore]
		public bool Final_Expense_Report_for_Spend_AuthorizationSpecified
		{
			get
			{
				return this.final_Expense_Report_for_Spend_AuthorizationFieldSpecified;
			}
			set
			{
				this.final_Expense_Report_for_Spend_AuthorizationFieldSpecified = value;
				this.RaisePropertyChanged("Final_Expense_Report_for_Spend_AuthorizationSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public SupplierObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Expense_Report_Lines_Reference_Data", Order = 20)]
		public Expense_Report_Line_WWS_Outbound_DataType[] Expense_Report_Lines_Reference_Data
		{
			get
			{
				return this.expense_Report_Lines_Reference_DataField;
			}
			set
			{
				this.expense_Report_Lines_Reference_DataField = value;
				this.RaisePropertyChanged("Expense_Report_Lines_Reference_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 21)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
