using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_WWS_DataType : INotifyPropertyChanged
	{
		private bool vAT_on_PaymentField;

		private bool vAT_on_PaymentFieldSpecified;

		private bool generate_Award_Costs_at_Business_Process_CompletionField;

		private bool generate_Award_Costs_at_Business_Process_CompletionFieldSpecified;

		private DateTime begin_Effective_Date_To_Generate_Award_CostsField;

		private bool begin_Effective_Date_To_Generate_Award_CostsFieldSpecified;

		private Tax_ApplicabilityObjectType default_Tax_Applicability_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Tax_ID_DataType[] tax_ID_DataField;

		private Tax_Status_DataType[] tax_Status_DataField;

		private Industry_Code_DataType[] industry_Code_DataField;

		private Unique_IdentifierObjectType workers_Compensation_Carrier_ReferenceField;

		private Organization_Common_DataType organization_DataField;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Custom_OrganizationObjectType[] organization_Container_ReferenceField;

		private Contact_Information_DataType contact_DataField;

		private Company_Accounting_Details_DataType accounting_DataField;

		private Company_Customer_Payment_Auto_Application_Configuration_DataType customer_Payment_Auto_Application_Configuration_DataField;

		private Journal_Sequence_Settings_DataType journal_Sequence_Settings_DataField;

		private Company_Procurement_Options_DataType procurement_Options_DataField;

		private Supplier_Account_Options_DataType supplier_Account_Options_DataField;

		private Sequence_GeneratorObjectType customer_Contract_Sequence_Generator_ReferenceField;

		private Business_Form_LayoutObjectType mandate_Prenotification_Business_Form_Layout_ReferenceField;

		private Sequence_GeneratorObjectType award_Contract_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType award_Proposal_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType customer_Invoice_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType supplier_Invoice_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType customer_Refund_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType journal_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType requisition_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType purchase_Order_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType purchase_Order_Acknowledgement_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType advanced_Ship_Notice_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType receipt_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType spend_Authorization_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType expense_Reports_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType supplier_Contracts_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType settlement_Run_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType prenote_Run_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType receipt_Accrual_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType outsourced_Payment_Group_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType procurement_Card_Transaction_Verification_Sequence_Generator_ReferenceField;

		private Sequence_GeneratorObjectType ad_Hoc_Bank_Transaction_Sequence_Generator_ReferenceField;

		private Business_Form_LayoutObjectType mandate_Business_Form_Layout_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Stock_Requests_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Pick_Lists_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Ship_Lists_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Returns_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Count_Sheets_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Par_Counts_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Goods_Deliveries_Generator_ReferenceField;

		private Sequence_GeneratorObjectType inventory_Goods_Delivery_Runs_Generator_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool VAT_on_Payment
		{
			get
			{
				return this.vAT_on_PaymentField;
			}
			set
			{
				this.vAT_on_PaymentField = value;
				this.RaisePropertyChanged("VAT_on_Payment");
			}
		}

		[XmlIgnore]
		public bool VAT_on_PaymentSpecified
		{
			get
			{
				return this.vAT_on_PaymentFieldSpecified;
			}
			set
			{
				this.vAT_on_PaymentFieldSpecified = value;
				this.RaisePropertyChanged("VAT_on_PaymentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Generate_Award_Costs_at_Business_Process_Completion
		{
			get
			{
				return this.generate_Award_Costs_at_Business_Process_CompletionField;
			}
			set
			{
				this.generate_Award_Costs_at_Business_Process_CompletionField = value;
				this.RaisePropertyChanged("Generate_Award_Costs_at_Business_Process_Completion");
			}
		}

		[XmlIgnore]
		public bool Generate_Award_Costs_at_Business_Process_CompletionSpecified
		{
			get
			{
				return this.generate_Award_Costs_at_Business_Process_CompletionFieldSpecified;
			}
			set
			{
				this.generate_Award_Costs_at_Business_Process_CompletionFieldSpecified = value;
				this.RaisePropertyChanged("Generate_Award_Costs_at_Business_Process_CompletionSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Begin_Effective_Date_To_Generate_Award_Costs
		{
			get
			{
				return this.begin_Effective_Date_To_Generate_Award_CostsField;
			}
			set
			{
				this.begin_Effective_Date_To_Generate_Award_CostsField = value;
				this.RaisePropertyChanged("Begin_Effective_Date_To_Generate_Award_Costs");
			}
		}

		[XmlIgnore]
		public bool Begin_Effective_Date_To_Generate_Award_CostsSpecified
		{
			get
			{
				return this.begin_Effective_Date_To_Generate_Award_CostsFieldSpecified;
			}
			set
			{
				this.begin_Effective_Date_To_Generate_Award_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Effective_Date_To_Generate_Award_CostsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Tax_ApplicabilityObjectType Default_Tax_Applicability_Reference
		{
			get
			{
				return this.default_Tax_Applicability_ReferenceField;
			}
			set
			{
				this.default_Tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Tax_CodeObjectType Default_Tax_Code_Reference
		{
			get
			{
				return this.default_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Code_Reference");
			}
		}

		[XmlElement("Tax_ID_Data", Order = 5)]
		public Tax_ID_DataType[] Tax_ID_Data
		{
			get
			{
				return this.tax_ID_DataField;
			}
			set
			{
				this.tax_ID_DataField = value;
				this.RaisePropertyChanged("Tax_ID_Data");
			}
		}

		[XmlElement("Tax_Status_Data", Order = 6)]
		public Tax_Status_DataType[] Tax_Status_Data
		{
			get
			{
				return this.tax_Status_DataField;
			}
			set
			{
				this.tax_Status_DataField = value;
				this.RaisePropertyChanged("Tax_Status_Data");
			}
		}

		[XmlElement("Industry_Code_Data", Order = 7)]
		public Industry_Code_DataType[] Industry_Code_Data
		{
			get
			{
				return this.industry_Code_DataField;
			}
			set
			{
				this.industry_Code_DataField = value;
				this.RaisePropertyChanged("Industry_Code_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Unique_IdentifierObjectType Workers_Compensation_Carrier_Reference
		{
			get
			{
				return this.workers_Compensation_Carrier_ReferenceField;
			}
			set
			{
				this.workers_Compensation_Carrier_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Compensation_Carrier_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Organization_Common_DataType Organization_Data
		{
			get
			{
				return this.organization_DataField;
			}
			set
			{
				this.organization_DataField = value;
				this.RaisePropertyChanged("Organization_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement("Organization_Container_Reference", Order = 11)]
		public Custom_OrganizationObjectType[] Organization_Container_Reference
		{
			get
			{
				return this.organization_Container_ReferenceField;
			}
			set
			{
				this.organization_Container_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Container_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Company_Accounting_Details_DataType Accounting_Data
		{
			get
			{
				return this.accounting_DataField;
			}
			set
			{
				this.accounting_DataField = value;
				this.RaisePropertyChanged("Accounting_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Company_Customer_Payment_Auto_Application_Configuration_DataType Customer_Payment_Auto_Application_Configuration_Data
		{
			get
			{
				return this.customer_Payment_Auto_Application_Configuration_DataField;
			}
			set
			{
				this.customer_Payment_Auto_Application_Configuration_DataField = value;
				this.RaisePropertyChanged("Customer_Payment_Auto_Application_Configuration_Data");
			}
		}

		[XmlElement(Order = 15)]
		public Journal_Sequence_Settings_DataType Journal_Sequence_Settings_Data
		{
			get
			{
				return this.journal_Sequence_Settings_DataField;
			}
			set
			{
				this.journal_Sequence_Settings_DataField = value;
				this.RaisePropertyChanged("Journal_Sequence_Settings_Data");
			}
		}

		[XmlElement(Order = 16)]
		public Company_Procurement_Options_DataType Procurement_Options_Data
		{
			get
			{
				return this.procurement_Options_DataField;
			}
			set
			{
				this.procurement_Options_DataField = value;
				this.RaisePropertyChanged("Procurement_Options_Data");
			}
		}

		[XmlElement(Order = 17)]
		public Supplier_Account_Options_DataType Supplier_Account_Options_Data
		{
			get
			{
				return this.supplier_Account_Options_DataField;
			}
			set
			{
				this.supplier_Account_Options_DataField = value;
				this.RaisePropertyChanged("Supplier_Account_Options_Data");
			}
		}

		[XmlElement(Order = 18)]
		public Sequence_GeneratorObjectType Customer_Contract_Sequence_Generator_Reference
		{
			get
			{
				return this.customer_Contract_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.customer_Contract_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Sequence_Generator_Reference");
			}
		}

		[XmlElement("Mandate_Pre-notification_Business_Form_Layout_Reference", Order = 19)]
		public Business_Form_LayoutObjectType Mandate_Prenotification_Business_Form_Layout_Reference
		{
			get
			{
				return this.mandate_Prenotification_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.mandate_Prenotification_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Mandate_Prenotification_Business_Form_Layout_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Sequence_GeneratorObjectType Award_Contract_Sequence_Generator_Reference
		{
			get
			{
				return this.award_Contract_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.award_Contract_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Sequence_GeneratorObjectType Award_Proposal_Sequence_Generator_Reference
		{
			get
			{
				return this.award_Proposal_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.award_Proposal_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Sequence_GeneratorObjectType Customer_Invoice_Sequence_Generator_Reference
		{
			get
			{
				return this.customer_Invoice_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Sequence_GeneratorObjectType Supplier_Invoice_Sequence_Generator_Reference
		{
			get
			{
				return this.supplier_Invoice_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public Sequence_GeneratorObjectType Customer_Refund_Sequence_Generator_Reference
		{
			get
			{
				return this.customer_Refund_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.customer_Refund_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Refund_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Sequence_GeneratorObjectType Journal_Sequence_Generator_Reference
		{
			get
			{
				return this.journal_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.journal_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Sequence_GeneratorObjectType Requisition_Sequence_Generator_Reference
		{
			get
			{
				return this.requisition_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.requisition_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public Sequence_GeneratorObjectType Purchase_Order_Sequence_Generator_Reference
		{
			get
			{
				return this.purchase_Order_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.purchase_Order_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public Sequence_GeneratorObjectType Purchase_Order_Acknowledgement_Sequence_Generator_Reference
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public Sequence_GeneratorObjectType Advanced_Ship_Notice_Sequence_Generator_Reference
		{
			get
			{
				return this.advanced_Ship_Notice_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.advanced_Ship_Notice_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Sequence_GeneratorObjectType Receipt_Sequence_Generator_Reference
		{
			get
			{
				return this.receipt_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.receipt_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Receipt_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public Sequence_GeneratorObjectType Spend_Authorization_Sequence_Generator_Reference
		{
			get
			{
				return this.spend_Authorization_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.spend_Authorization_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Authorization_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public Sequence_GeneratorObjectType Expense_Reports_Sequence_Generator_Reference
		{
			get
			{
				return this.expense_Reports_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.expense_Reports_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Reports_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public Sequence_GeneratorObjectType Supplier_Contracts_Sequence_Generator_Reference
		{
			get
			{
				return this.supplier_Contracts_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.supplier_Contracts_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contracts_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public Sequence_GeneratorObjectType Settlement_Run_Sequence_Generator_Reference
		{
			get
			{
				return this.settlement_Run_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.settlement_Run_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_Run_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public Sequence_GeneratorObjectType Prenote_Run_Sequence_Generator_Reference
		{
			get
			{
				return this.prenote_Run_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.prenote_Run_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Prenote_Run_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 36)]
		public Sequence_GeneratorObjectType Receipt_Accrual_Sequence_Generator_Reference
		{
			get
			{
				return this.receipt_Accrual_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.receipt_Accrual_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Receipt_Accrual_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 37)]
		public Sequence_GeneratorObjectType Outsourced_Payment_Group_Sequence_Generator_Reference
		{
			get
			{
				return this.outsourced_Payment_Group_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.outsourced_Payment_Group_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Outsourced_Payment_Group_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public Sequence_GeneratorObjectType Procurement_Card_Transaction_Verification_Sequence_Generator_Reference
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 39)]
		public Sequence_GeneratorObjectType Ad_Hoc_Bank_Transaction_Sequence_Generator_Reference
		{
			get
			{
				return this.ad_Hoc_Bank_Transaction_Sequence_Generator_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Bank_Transaction_Sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Bank_Transaction_Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 40)]
		public Business_Form_LayoutObjectType Mandate_Business_Form_Layout_Reference
		{
			get
			{
				return this.mandate_Business_Form_Layout_ReferenceField;
			}
			set
			{
				this.mandate_Business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Mandate_Business_Form_Layout_Reference");
			}
		}

		[XmlElement(Order = 41)]
		public Sequence_GeneratorObjectType Inventory_Stock_Requests_Generator_Reference
		{
			get
			{
				return this.inventory_Stock_Requests_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Requests_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Requests_Generator_Reference");
			}
		}

		[XmlElement(Order = 42)]
		public Sequence_GeneratorObjectType Inventory_Pick_Lists_Generator_Reference
		{
			get
			{
				return this.inventory_Pick_Lists_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Pick_Lists_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Pick_Lists_Generator_Reference");
			}
		}

		[XmlElement(Order = 43)]
		public Sequence_GeneratorObjectType Inventory_Ship_Lists_Generator_Reference
		{
			get
			{
				return this.inventory_Ship_Lists_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Ship_Lists_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Ship_Lists_Generator_Reference");
			}
		}

		[XmlElement(Order = 44)]
		public Sequence_GeneratorObjectType Inventory_Returns_Generator_Reference
		{
			get
			{
				return this.inventory_Returns_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Returns_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Returns_Generator_Reference");
			}
		}

		[XmlElement(Order = 45)]
		public Sequence_GeneratorObjectType Inventory_Count_Sheets_Generator_Reference
		{
			get
			{
				return this.inventory_Count_Sheets_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Count_Sheets_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Count_Sheets_Generator_Reference");
			}
		}

		[XmlElement(Order = 46)]
		public Sequence_GeneratorObjectType Inventory_Par_Counts_Generator_Reference
		{
			get
			{
				return this.inventory_Par_Counts_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Par_Counts_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Par_Counts_Generator_Reference");
			}
		}

		[XmlElement(Order = 47)]
		public Sequence_GeneratorObjectType Inventory_Goods_Deliveries_Generator_Reference
		{
			get
			{
				return this.inventory_Goods_Deliveries_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Goods_Deliveries_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Goods_Deliveries_Generator_Reference");
			}
		}

		[XmlElement(Order = 48)]
		public Sequence_GeneratorObjectType Inventory_Goods_Delivery_Runs_Generator_Reference
		{
			get
			{
				return this.inventory_Goods_Delivery_Runs_Generator_ReferenceField;
			}
			set
			{
				this.inventory_Goods_Delivery_Runs_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Goods_Delivery_Runs_Generator_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
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
