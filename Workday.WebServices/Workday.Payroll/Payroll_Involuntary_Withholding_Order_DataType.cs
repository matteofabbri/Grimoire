using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Involuntary_Withholding_Order_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private Withholding_Order_TypeObjectType withholding_Order_Type_ReferenceField;

		private object itemField;

		private string withholding_Order_Additional_Order_NumberField;

		private DateTime order_DateField;

		private DateTime received_DateField;

		private DateTime begin_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private bool inactive_OrderField;

		private bool inactive_OrderFieldSpecified;

		private Withholding_Order_Amount_TypeObjectType withholding_Order_Amount_Type_ReferenceField;

		private decimal item1Field;

		private Item1ChoiceType item1ElementNameField;

		private FrequencyObjectType pay_Period_Frequency_ReferenceField;

		private decimal total_Debt_AmountField;

		private bool total_Debt_AmountFieldSpecified;

		private decimal monthly_LimitField;

		private bool monthly_LimitFieldSpecified;

		private Payroll_Tax_AuthorityObjectType issued_in_ReferenceField;

		private Deduction_RecipientObjectType deduction_Recipient_ReferenceField;

		private string originating_AuthorityField;

		private string memoField;

		private object item2Field;

		private Federal_Student_Loan_Specific_DataType[] federal_Student_Loan_DataField;

		private Withholding_Order_Fee_DataType[] withholding_Order_Fee_DataField;

		private Withholding_Order_Withholding_FrequencyObjectType[] withholding_Order_Withholding_Frequency_DataField;

		private CurrencyObjectType currency_ReferenceField;

		private Address_Information_DataType[] deduction_Recipient_Address_DataField;

		private string withholding_Order_IDField;

		private string copied_MessageField;

		private string copied_ToField;

		private string copied_FromField;

		private string processing_MessageField;

		private DateTime copied_From_DateField;

		private bool copied_From_DateFieldSpecified;

		private DateTime copied_To_DateField;

		private bool copied_To_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Reference
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

		[XmlElement(Order = 1)]
		public Withholding_Order_TypeObjectType Withholding_Order_Type_Reference
		{
			get
			{
				return this.withholding_Order_Type_ReferenceField;
			}
			set
			{
				this.withholding_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Type_Reference");
			}
		}

		[XmlElement("Case_Number", typeof(string), Order = 2), XmlElement("Withholding_Order_Case_Reference", typeof(Withholding_Order_CaseObjectType), Order = 2)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 3)]
		public string Withholding_Order_Additional_Order_Number
		{
			get
			{
				return this.withholding_Order_Additional_Order_NumberField;
			}
			set
			{
				this.withholding_Order_Additional_Order_NumberField = value;
				this.RaisePropertyChanged("Withholding_Order_Additional_Order_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Order_Date
		{
			get
			{
				return this.order_DateField;
			}
			set
			{
				this.order_DateField = value;
				this.RaisePropertyChanged("Order_Date");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Received_Date
		{
			get
			{
				return this.received_DateField;
			}
			set
			{
				this.received_DateField = value;
				this.RaisePropertyChanged("Received_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public bool Inactive_Order
		{
			get
			{
				return this.inactive_OrderField;
			}
			set
			{
				this.inactive_OrderField = value;
				this.RaisePropertyChanged("Inactive_Order");
			}
		}

		[XmlIgnore]
		public bool Inactive_OrderSpecified
		{
			get
			{
				return this.inactive_OrderFieldSpecified;
			}
			set
			{
				this.inactive_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_OrderSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Withholding_Order_Amount_TypeObjectType Withholding_Order_Amount_Type_Reference
		{
			get
			{
				return this.withholding_Order_Amount_Type_ReferenceField;
			}
			set
			{
				this.withholding_Order_Amount_Type_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Amount_Type_Reference");
			}
		}

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Withholding_Order_Amount", typeof(decimal), Order = 11), XmlElement("Withholding_Order_Amount_as_Percent", typeof(decimal), Order = 11)]
		public decimal Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 12), XmlIgnore]
		public Item1ChoiceType Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
			}
		}

		[XmlElement(Order = 13)]
		public FrequencyObjectType Pay_Period_Frequency_Reference
		{
			get
			{
				return this.pay_Period_Frequency_ReferenceField;
			}
			set
			{
				this.pay_Period_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Period_Frequency_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Total_Debt_Amount
		{
			get
			{
				return this.total_Debt_AmountField;
			}
			set
			{
				this.total_Debt_AmountField = value;
				this.RaisePropertyChanged("Total_Debt_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Debt_AmountSpecified
		{
			get
			{
				return this.total_Debt_AmountFieldSpecified;
			}
			set
			{
				this.total_Debt_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Debt_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Monthly_Limit
		{
			get
			{
				return this.monthly_LimitField;
			}
			set
			{
				this.monthly_LimitField = value;
				this.RaisePropertyChanged("Monthly_Limit");
			}
		}

		[XmlIgnore]
		public bool Monthly_LimitSpecified
		{
			get
			{
				return this.monthly_LimitFieldSpecified;
			}
			set
			{
				this.monthly_LimitFieldSpecified = value;
				this.RaisePropertyChanged("Monthly_LimitSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public Payroll_Tax_AuthorityObjectType Issued_in_Reference
		{
			get
			{
				return this.issued_in_ReferenceField;
			}
			set
			{
				this.issued_in_ReferenceField = value;
				this.RaisePropertyChanged("Issued_in_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Deduction_RecipientObjectType Deduction_Recipient_Reference
		{
			get
			{
				return this.deduction_Recipient_ReferenceField;
			}
			set
			{
				this.deduction_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public string Originating_Authority
		{
			get
			{
				return this.originating_AuthorityField;
			}
			set
			{
				this.originating_AuthorityField = value;
				this.RaisePropertyChanged("Originating_Authority");
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

		[XmlElement("Bankruptcy_Order_Data", typeof(Bankruptcy_Order_Specific_DataType), Order = 20), XmlElement("Creditor_Garnishment_Data", typeof(Creditor_Garnishment_Specific_DataType), Order = 20), XmlElement("Federal_Tax_Levy_Data", typeof(Federal_Tax_Levy_Specific_DataType), Order = 20), XmlElement("Payroll_Support_Order_Lump_Sum_Data", typeof(Payroll_Support_Order_Lump_Sum_DataType), Order = 20), XmlElement("State_Tax_Levy_Order_Data", typeof(State_Tax_Levy_Order_DataType), Order = 20), XmlElement("Support_Order_Data", typeof(Payroll_Support_Order_DataType), Order = 20), XmlElement("Wage_Assignment_Data", typeof(Wage_Assignment_Specific_DataType), Order = 20)]
		public object Item2
		{
			get
			{
				return this.item2Field;
			}
			set
			{
				this.item2Field = value;
				this.RaisePropertyChanged("Item2");
			}
		}

		[XmlElement("Federal_Student_Loan_Data", Order = 21)]
		public Federal_Student_Loan_Specific_DataType[] Federal_Student_Loan_Data
		{
			get
			{
				return this.federal_Student_Loan_DataField;
			}
			set
			{
				this.federal_Student_Loan_DataField = value;
				this.RaisePropertyChanged("Federal_Student_Loan_Data");
			}
		}

		[XmlElement("Withholding_Order_Fee_Data", Order = 22)]
		public Withholding_Order_Fee_DataType[] Withholding_Order_Fee_Data
		{
			get
			{
				return this.withholding_Order_Fee_DataField;
			}
			set
			{
				this.withholding_Order_Fee_DataField = value;
				this.RaisePropertyChanged("Withholding_Order_Fee_Data");
			}
		}

		[XmlArray(Order = 23), XmlArrayItem("Withholding_Order_Withholding_Frequency_Reference", typeof(Withholding_Order_Withholding_FrequencyObjectType), IsNullable = false)]
		public Withholding_Order_Withholding_FrequencyObjectType[] Withholding_Order_Withholding_Frequency_Data
		{
			get
			{
				return this.withholding_Order_Withholding_Frequency_DataField;
			}
			set
			{
				this.withholding_Order_Withholding_Frequency_DataField = value;
				this.RaisePropertyChanged("Withholding_Order_Withholding_Frequency_Data");
			}
		}

		[XmlElement(Order = 24)]
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

		[XmlElement("Deduction_Recipient_Address_Data", Order = 25)]
		public Address_Information_DataType[] Deduction_Recipient_Address_Data
		{
			get
			{
				return this.deduction_Recipient_Address_DataField;
			}
			set
			{
				this.deduction_Recipient_Address_DataField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Address_Data");
			}
		}

		[XmlElement(Order = 26)]
		public string Withholding_Order_ID
		{
			get
			{
				return this.withholding_Order_IDField;
			}
			set
			{
				this.withholding_Order_IDField = value;
				this.RaisePropertyChanged("Withholding_Order_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Copied_Message
		{
			get
			{
				return this.copied_MessageField;
			}
			set
			{
				this.copied_MessageField = value;
				this.RaisePropertyChanged("Copied_Message");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Copied_To
		{
			get
			{
				return this.copied_ToField;
			}
			set
			{
				this.copied_ToField = value;
				this.RaisePropertyChanged("Copied_To");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Copied_From
		{
			get
			{
				return this.copied_FromField;
			}
			set
			{
				this.copied_FromField = value;
				this.RaisePropertyChanged("Copied_From");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Processing_Message
		{
			get
			{
				return this.processing_MessageField;
			}
			set
			{
				this.processing_MessageField = value;
				this.RaisePropertyChanged("Processing_Message");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Copied_From_Date
		{
			get
			{
				return this.copied_From_DateField;
			}
			set
			{
				this.copied_From_DateField = value;
				this.RaisePropertyChanged("Copied_From_Date");
			}
		}

		[XmlIgnore]
		public bool Copied_From_DateSpecified
		{
			get
			{
				return this.copied_From_DateFieldSpecified;
			}
			set
			{
				this.copied_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Copied_From_DateSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Copied_To_Date
		{
			get
			{
				return this.copied_To_DateField;
			}
			set
			{
				this.copied_To_DateField = value;
				this.RaisePropertyChanged("Copied_To_Date");
			}
		}

		[XmlIgnore]
		public bool Copied_To_DateSpecified
		{
			get
			{
				return this.copied_To_DateFieldSpecified;
			}
			set
			{
				this.copied_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Copied_To_DateSpecified");
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
