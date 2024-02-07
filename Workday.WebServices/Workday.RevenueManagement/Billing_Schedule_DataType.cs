using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Billing_Schedule_DataType : INotifyPropertyChanged
	{
		private string billing_Schedule_Reference_IDField;

		private bool generate_InstallmentsField;

		private bool generate_InstallmentsFieldSpecified;

		private bool submitField;

		private bool submitFieldSpecified;

		private Billing_TypeObjectType billing_Type_ReferenceField;

		private Document_StatusObjectType[] schedule_Status_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Billable_EntityObjectType billTo_Customer_ReferenceField;

		private Address_ReferenceObjectType bill_To_Address_ReferenceField;

		private Address_Information_DataType[] bill_To_Address_DataField;

		private bool populate_with_Default_Bill_To_ContactsField;

		private bool populate_with_Default_Bill_To_ContactsFieldSpecified;

		private Business_Entity_ContactObjectType[] billTo_Contact_ReferenceField;

		private Schedule_Distribution_MethodObjectType billing_Method_ReferenceField;

		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private bool use_From_DateField;

		private bool use_From_DateFieldSpecified;

		private bool use_To_DateField;

		private bool use_To_DateFieldSpecified;

		private decimal day_of_MonthField;

		private bool day_of_MonthFieldSpecified;

		private Schedule_TypeObjectType schedule_Type_ReferenceField;

		private string schedule_DescriptionField;

		private Milestone_AbstractObjectType[] milestone_ReferenceField;

		private bool schedule_On_HoldField;

		private bool schedule_On_HoldFieldSpecified;

		private bool autoSubmit_Invoices_for_ApprovalField;

		private bool autoSubmit_Invoices_for_ApprovalFieldSpecified;

		private bool review_Not_Required_to_BillField;

		private bool review_Not_Required_to_BillFieldSpecified;

		private Project_Invoice_Summary_DefinitionObjectType project_Invoice_Summary_Definition_ReferenceField;

		private Billing_CycleObjectType billing_Cycle_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string pO_NumberField;

		private Customer_Invoice_TypeObjectType invoice_Type_ReferenceField;

		private string invoice_MemoField;

		private Receivable_Contract_Line_AbstractObjectType[] contract_Line_ReferenceField;

		private Billing_Installment_DataType[] billing_Installment_DataField;

		private Customer_Contract_Schedule_Installment_Schedule_DataType[] billing_Schedule_Installment_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Billing_Schedule_Reference_ID
		{
			get
			{
				return this.billing_Schedule_Reference_IDField;
			}
			set
			{
				this.billing_Schedule_Reference_IDField = value;
				this.RaisePropertyChanged("Billing_Schedule_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Generate_Installments
		{
			get
			{
				return this.generate_InstallmentsField;
			}
			set
			{
				this.generate_InstallmentsField = value;
				this.RaisePropertyChanged("Generate_Installments");
			}
		}

		[XmlIgnore]
		public bool Generate_InstallmentsSpecified
		{
			get
			{
				return this.generate_InstallmentsFieldSpecified;
			}
			set
			{
				this.generate_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Generate_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Billing_TypeObjectType Billing_Type_Reference
		{
			get
			{
				return this.billing_Type_ReferenceField;
			}
			set
			{
				this.billing_Type_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Type_Reference");
			}
		}

		[XmlElement("Schedule_Status_Reference", Order = 4)]
		public Document_StatusObjectType[] Schedule_Status_Reference
		{
			get
			{
				return this.schedule_Status_ReferenceField;
			}
			set
			{
				this.schedule_Status_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement("Bill-To_Customer_Reference", Order = 7)]
		public Billable_EntityObjectType BillTo_Customer_Reference
		{
			get
			{
				return this.billTo_Customer_ReferenceField;
			}
			set
			{
				this.billTo_Customer_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Customer_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Address_ReferenceObjectType Bill_To_Address_Reference
		{
			get
			{
				return this.bill_To_Address_ReferenceField;
			}
			set
			{
				this.bill_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Address_Reference");
			}
		}

		[XmlElement("Bill_To_Address_Data", Order = 9)]
		public Address_Information_DataType[] Bill_To_Address_Data
		{
			get
			{
				return this.bill_To_Address_DataField;
			}
			set
			{
				this.bill_To_Address_DataField = value;
				this.RaisePropertyChanged("Bill_To_Address_Data");
			}
		}

		[XmlElement(Order = 10)]
		public bool Populate_with_Default_Bill_To_Contacts
		{
			get
			{
				return this.populate_with_Default_Bill_To_ContactsField;
			}
			set
			{
				this.populate_with_Default_Bill_To_ContactsField = value;
				this.RaisePropertyChanged("Populate_with_Default_Bill_To_Contacts");
			}
		}

		[XmlIgnore]
		public bool Populate_with_Default_Bill_To_ContactsSpecified
		{
			get
			{
				return this.populate_with_Default_Bill_To_ContactsFieldSpecified;
			}
			set
			{
				this.populate_with_Default_Bill_To_ContactsFieldSpecified = value;
				this.RaisePropertyChanged("Populate_with_Default_Bill_To_ContactsSpecified");
			}
		}

		[XmlElement("Bill-To_Contact_Reference", Order = 11)]
		public Business_Entity_ContactObjectType[] BillTo_Contact_Reference
		{
			get
			{
				return this.billTo_Contact_ReferenceField;
			}
			set
			{
				this.billTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Contact_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Schedule_Distribution_MethodObjectType Billing_Method_Reference
		{
			get
			{
				return this.billing_Method_ReferenceField;
			}
			set
			{
				this.billing_Method_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Method_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Frequency_BehaviorObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Number_of_Installments
		{
			get
			{
				return this.number_of_InstallmentsField;
			}
			set
			{
				this.number_of_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Installments");
			}
		}

		[XmlIgnore]
		public bool Number_of_InstallmentsSpecified
		{
			get
			{
				return this.number_of_InstallmentsFieldSpecified;
			}
			set
			{
				this.number_of_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Use_From_Date
		{
			get
			{
				return this.use_From_DateField;
			}
			set
			{
				this.use_From_DateField = value;
				this.RaisePropertyChanged("Use_From_Date");
			}
		}

		[XmlIgnore]
		public bool Use_From_DateSpecified
		{
			get
			{
				return this.use_From_DateFieldSpecified;
			}
			set
			{
				this.use_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_From_DateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Use_To_Date
		{
			get
			{
				return this.use_To_DateField;
			}
			set
			{
				this.use_To_DateField = value;
				this.RaisePropertyChanged("Use_To_Date");
			}
		}

		[XmlIgnore]
		public bool Use_To_DateSpecified
		{
			get
			{
				return this.use_To_DateFieldSpecified;
			}
			set
			{
				this.use_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_To_DateSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Day_of_Month
		{
			get
			{
				return this.day_of_MonthField;
			}
			set
			{
				this.day_of_MonthField = value;
				this.RaisePropertyChanged("Day_of_Month");
			}
		}

		[XmlIgnore]
		public bool Day_of_MonthSpecified
		{
			get
			{
				return this.day_of_MonthFieldSpecified;
			}
			set
			{
				this.day_of_MonthFieldSpecified = value;
				this.RaisePropertyChanged("Day_of_MonthSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Schedule_TypeObjectType Schedule_Type_Reference
		{
			get
			{
				return this.schedule_Type_ReferenceField;
			}
			set
			{
				this.schedule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Type_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public string Schedule_Description
		{
			get
			{
				return this.schedule_DescriptionField;
			}
			set
			{
				this.schedule_DescriptionField = value;
				this.RaisePropertyChanged("Schedule_Description");
			}
		}

		[XmlElement("Milestone_Reference", Order = 22)]
		public Milestone_AbstractObjectType[] Milestone_Reference
		{
			get
			{
				return this.milestone_ReferenceField;
			}
			set
			{
				this.milestone_ReferenceField = value;
				this.RaisePropertyChanged("Milestone_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public bool Schedule_On_Hold
		{
			get
			{
				return this.schedule_On_HoldField;
			}
			set
			{
				this.schedule_On_HoldField = value;
				this.RaisePropertyChanged("Schedule_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Schedule_On_HoldSpecified
		{
			get
			{
				return this.schedule_On_HoldFieldSpecified;
			}
			set
			{
				this.schedule_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Schedule_On_HoldSpecified");
			}
		}

		[XmlElement("Auto-Submit_Invoices_for_Approval", Order = 24)]
		public bool AutoSubmit_Invoices_for_Approval
		{
			get
			{
				return this.autoSubmit_Invoices_for_ApprovalField;
			}
			set
			{
				this.autoSubmit_Invoices_for_ApprovalField = value;
				this.RaisePropertyChanged("AutoSubmit_Invoices_for_Approval");
			}
		}

		[XmlIgnore]
		public bool AutoSubmit_Invoices_for_ApprovalSpecified
		{
			get
			{
				return this.autoSubmit_Invoices_for_ApprovalFieldSpecified;
			}
			set
			{
				this.autoSubmit_Invoices_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("AutoSubmit_Invoices_for_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public bool Review_Not_Required_to_Bill
		{
			get
			{
				return this.review_Not_Required_to_BillField;
			}
			set
			{
				this.review_Not_Required_to_BillField = value;
				this.RaisePropertyChanged("Review_Not_Required_to_Bill");
			}
		}

		[XmlIgnore]
		public bool Review_Not_Required_to_BillSpecified
		{
			get
			{
				return this.review_Not_Required_to_BillFieldSpecified;
			}
			set
			{
				this.review_Not_Required_to_BillFieldSpecified = value;
				this.RaisePropertyChanged("Review_Not_Required_to_BillSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public Project_Invoice_Summary_DefinitionObjectType Project_Invoice_Summary_Definition_Reference
		{
			get
			{
				return this.project_Invoice_Summary_Definition_ReferenceField;
			}
			set
			{
				this.project_Invoice_Summary_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Project_Invoice_Summary_Definition_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public Billing_CycleObjectType Billing_Cycle_Reference
		{
			get
			{
				return this.billing_Cycle_ReferenceField;
			}
			set
			{
				this.billing_Cycle_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Cycle_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
		public string PO_Number
		{
			get
			{
				return this.pO_NumberField;
			}
			set
			{
				this.pO_NumberField = value;
				this.RaisePropertyChanged("PO_Number");
			}
		}

		[XmlElement(Order = 31)]
		public Customer_Invoice_TypeObjectType Invoice_Type_Reference
		{
			get
			{
				return this.invoice_Type_ReferenceField;
			}
			set
			{
				this.invoice_Type_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Type_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public string Invoice_Memo
		{
			get
			{
				return this.invoice_MemoField;
			}
			set
			{
				this.invoice_MemoField = value;
				this.RaisePropertyChanged("Invoice_Memo");
			}
		}

		[XmlElement("Contract_Line_Reference", Order = 33)]
		public Receivable_Contract_Line_AbstractObjectType[] Contract_Line_Reference
		{
			get
			{
				return this.contract_Line_ReferenceField;
			}
			set
			{
				this.contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Reference");
			}
		}

		[XmlElement("Billing_Installment_Data", Order = 34)]
		public Billing_Installment_DataType[] Billing_Installment_Data
		{
			get
			{
				return this.billing_Installment_DataField;
			}
			set
			{
				this.billing_Installment_DataField = value;
				this.RaisePropertyChanged("Billing_Installment_Data");
			}
		}

		[XmlElement("Billing_Schedule_Installment_Schedule_Data", Order = 35)]
		public Customer_Contract_Schedule_Installment_Schedule_DataType[] Billing_Schedule_Installment_Schedule_Data
		{
			get
			{
				return this.billing_Schedule_Installment_Schedule_DataField;
			}
			set
			{
				this.billing_Schedule_Installment_Schedule_DataField = value;
				this.RaisePropertyChanged("Billing_Schedule_Installment_Schedule_Data");
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
