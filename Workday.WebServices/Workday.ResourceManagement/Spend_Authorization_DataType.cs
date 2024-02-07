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
	public class Spend_Authorization_DataType : INotifyPropertyChanged
	{
		private string spend_Authorization_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string spend_Authorization_NumberField;

		private string budget_Check_StatusField;

		private Payment_TypeObjectType reimbursement_Payment_Type_ReferenceField;

		private DateTime spend_Authorization_DateField;

		private DateTime spend_End_DateField;

		private bool spend_End_DateFieldSpecified;

		private Business_PurposeObjectType business_Purpose_ReferenceField;

		private string descriptionField;

		private decimal remaining_BalanceField;

		private bool remaining_BalanceFieldSpecified;

		private decimal estimated_AmountField;

		private bool estimated_AmountFieldSpecified;

		private decimal cash_Advance_Requested_AmountField;

		private bool cash_Advance_Requested_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string justificationField;

		private Spend_Authorization_Line_DataType[] spend_Authorization_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Authorization_ID
		{
			get
			{
				return this.spend_Authorization_IDField;
			}
			set
			{
				this.spend_Authorization_IDField = value;
				this.RaisePropertyChanged("Spend_Authorization_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
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
		public string Spend_Authorization_Number
		{
			get
			{
				return this.spend_Authorization_NumberField;
			}
			set
			{
				this.spend_Authorization_NumberField = value;
				this.RaisePropertyChanged("Spend_Authorization_Number");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Payment_TypeObjectType Reimbursement_Payment_Type_Reference
		{
			get
			{
				return this.reimbursement_Payment_Type_ReferenceField;
			}
			set
			{
				this.reimbursement_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Reimbursement_Payment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Spend_Authorization_Date
		{
			get
			{
				return this.spend_Authorization_DateField;
			}
			set
			{
				this.spend_Authorization_DateField = value;
				this.RaisePropertyChanged("Spend_Authorization_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Spend_End_Date
		{
			get
			{
				return this.spend_End_DateField;
			}
			set
			{
				this.spend_End_DateField = value;
				this.RaisePropertyChanged("Spend_End_Date");
			}
		}

		[XmlIgnore]
		public bool Spend_End_DateSpecified
		{
			get
			{
				return this.spend_End_DateFieldSpecified;
			}
			set
			{
				this.spend_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Spend_End_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Remaining_Balance
		{
			get
			{
				return this.remaining_BalanceField;
			}
			set
			{
				this.remaining_BalanceField = value;
				this.RaisePropertyChanged("Remaining_Balance");
			}
		}

		[XmlIgnore]
		public bool Remaining_BalanceSpecified
		{
			get
			{
				return this.remaining_BalanceFieldSpecified;
			}
			set
			{
				this.remaining_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Remaining_BalanceSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Estimated_Amount
		{
			get
			{
				return this.estimated_AmountField;
			}
			set
			{
				this.estimated_AmountField = value;
				this.RaisePropertyChanged("Estimated_Amount");
			}
		}

		[XmlIgnore]
		public bool Estimated_AmountSpecified
		{
			get
			{
				return this.estimated_AmountFieldSpecified;
			}
			set
			{
				this.estimated_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Cash_Advance_Requested_Amount
		{
			get
			{
				return this.cash_Advance_Requested_AmountField;
			}
			set
			{
				this.cash_Advance_Requested_AmountField = value;
				this.RaisePropertyChanged("Cash_Advance_Requested_Amount");
			}
		}

		[XmlIgnore]
		public bool Cash_Advance_Requested_AmountSpecified
		{
			get
			{
				return this.cash_Advance_Requested_AmountFieldSpecified;
			}
			set
			{
				this.cash_Advance_Requested_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Cash_Advance_Requested_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public string Justification
		{
			get
			{
				return this.justificationField;
			}
			set
			{
				this.justificationField = value;
				this.RaisePropertyChanged("Justification");
			}
		}

		[XmlElement("Spend_Authorization_Line_Replacement_Data", Order = 17)]
		public Spend_Authorization_Line_DataType[] Spend_Authorization_Line_Replacement_Data
		{
			get
			{
				return this.spend_Authorization_Line_Replacement_DataField;
			}
			set
			{
				this.spend_Authorization_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Spend_Authorization_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 18)]
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
