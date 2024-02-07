using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Revenue_Management", ConfigurationName = "RevenueManagement.Revenue_ManagementPort")]
	public interface Revenue_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ProspectOutput Put_Prospect(Put_ProspectInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ProspectOutput> Put_ProspectAsync(Put_ProspectInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_OpportunityOutput Put_Opportunity(Put_OpportunityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_OpportunityOutput> Put_OpportunityAsync(Put_OpportunityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_RequestOutput Put_Customer_Request(Put_Customer_RequestInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_RequestOutput> Put_Customer_RequestAsync(Put_Customer_RequestInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_InvoicesOutput Get_Customer_Invoices(Get_Customer_InvoicesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_InvoicesOutput> Get_Customer_InvoicesAsync(Get_Customer_InvoicesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CustomersOutput Get_Customers(Get_CustomersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CustomersOutput> Get_CustomersAsync(Get_CustomersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ProspectsOutput Get_Prospects(Get_ProspectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ProspectsOutput> Get_ProspectsAsync(Get_ProspectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_RequestsOutput Get_Customer_Requests(Get_Customer_RequestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_RequestsOutput> Get_Customer_RequestsAsync(Get_Customer_RequestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OpportunitiesOutput Get_Opportunities(Get_OpportunitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OpportunitiesOutput> Get_OpportunitiesAsync(Get_OpportunitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_RefundsOutput Get_Customer_Refunds(Get_Customer_RefundsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_RefundsOutput> Get_Customer_RefundsAsync(Get_Customer_RefundsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_ActivityOutput Get_Customer_Activity(Get_Customer_ActivityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_ActivityOutput> Get_Customer_ActivityAsync(Get_Customer_ActivityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_CategoriesOutput Get_Revenue_Categories(Get_Revenue_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_CategoriesOutput> Get_Revenue_CategoriesAsync(Get_Revenue_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Revenue_CategoryOutput Put_Revenue_Category(Put_Revenue_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Revenue_CategoryOutput> Put_Revenue_CategoryAsync(Put_Revenue_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Sales_Item_GroupsOutput Get_Sales_Item_Groups(Get_Sales_Item_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Sales_Item_GroupsOutput> Get_Sales_Item_GroupsAsync(Get_Sales_Item_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Sales_Item_GroupOutput Put_Sales_Item_Group(Put_Sales_Item_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Sales_Item_GroupOutput> Put_Sales_Item_GroupAsync(Put_Sales_Item_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_InvoiceOutput Submit_Customer_Invoice(Submit_Customer_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_InvoiceOutput> Submit_Customer_InvoiceAsync(Submit_Customer_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Sales_ItemsOutput Get_Sales_Items(Get_Sales_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Sales_ItemsOutput> Get_Sales_ItemsAsync(Get_Sales_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Sales_ItemOutput Put_Sales_Item(Put_Sales_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Sales_ItemOutput> Put_Sales_ItemAsync(Put_Sales_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_Invoice_AdjustmentOutput Submit_Customer_Invoice_Adjustment(Submit_Customer_Invoice_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_Invoice_AdjustmentOutput> Submit_Customer_Invoice_AdjustmentAsync(Submit_Customer_Invoice_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Customer_InvoiceOutput Cancel_Customer_Invoice(Cancel_Customer_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Customer_InvoiceOutput> Cancel_Customer_InvoiceAsync(Cancel_Customer_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Customer_Invoice_AdjustmentOutput Cancel_Customer_Invoice_Adjustment(Cancel_Customer_Invoice_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Customer_Invoice_AdjustmentOutput> Cancel_Customer_Invoice_AdjustmentAsync(Cancel_Customer_Invoice_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_CategoriesOutput Get_Customer_Categories(Get_Customer_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_CategoriesOutput> Get_Customer_CategoriesAsync(Get_Customer_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_CategoryOutput Put_Customer_Category(Put_Customer_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_CategoryOutput> Put_Customer_CategoryAsync(Put_Customer_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_GroupsOutput Get_Customer_Groups(Get_Customer_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_GroupsOutput> Get_Customer_GroupsAsync(Get_Customer_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_GroupOutput Put_Customer_Group(Put_Customer_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_GroupOutput> Put_Customer_GroupAsync(Put_Customer_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Cash_SaleOutput Put_Cash_Sale(Put_Cash_SaleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Cash_SaleOutput> Put_Cash_SaleAsync(Put_Cash_SaleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Cash_SaleOutput Cancel_Cash_Sale(Cancel_Cash_SaleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Cash_SaleOutput> Cancel_Cash_SaleAsync(Cancel_Cash_SaleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Entity_ContactsOutput Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_Entity_ContactOutput Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CustomerOutput Put_Customer(Put_CustomerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CustomerOutput> Put_CustomerAsync(Put_CustomerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_Invoice_AdjustmentsOutput Get_Customer_Invoice_Adjustments(Get_Customer_Invoice_AdjustmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_Invoice_AdjustmentsOutput> Get_Customer_Invoice_AdjustmentsAsync(Get_Customer_Invoice_AdjustmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Cash_SalesOutput Get_Cash_Sales(Get_Cash_SalesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Cash_SalesOutput> Get_Cash_SalesAsync(Get_Cash_SalesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Cash_SaleOutput Submit_Cash_Sale(Submit_Cash_SaleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Cash_SaleOutput> Submit_Cash_SaleAsync(Submit_Cash_SaleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Merchant_Customer_ProfileOutput Get_Merchant_Customer_Profile(Get_Merchant_Customer_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Merchant_Customer_ProfileOutput> Get_Merchant_Customer_ProfileAsync(Get_Merchant_Customer_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Merchant_Customer_ProfileOutput Put_Merchant_Customer_Profile(Put_Merchant_Customer_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Merchant_Customer_ProfileOutput> Put_Merchant_Customer_ProfileAsync(Put_Merchant_Customer_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Credit_Card_AuthorizationOutput Get_Credit_Card_Authorization(Get_Credit_Card_AuthorizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Credit_Card_AuthorizationOutput> Get_Credit_Card_AuthorizationAsync(Get_Credit_Card_AuthorizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Credit_Card_AuthorizationOutput Put_Credit_Card_Authorization(Put_Credit_Card_AuthorizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Credit_Card_AuthorizationOutput> Put_Credit_Card_AuthorizationAsync(Put_Credit_Card_AuthorizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_ContractsOutput Get_Customer_Contracts(Get_Customer_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_ContractsOutput> Get_Customer_ContractsAsync(Get_Customer_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_ContractOutput Submit_Customer_Contract(Submit_Customer_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_ContractOutput> Submit_Customer_ContractAsync(Submit_Customer_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_PaymentOutput Put_Customer_Payment(Put_Customer_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_PaymentOutput> Put_Customer_PaymentAsync(Put_Customer_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_PaymentsOutput Get_Customer_Payments(Get_Customer_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_PaymentsOutput> Get_Customer_PaymentsAsync(Get_Customer_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_DepositsOutput Get_Customer_Deposits(Get_Customer_DepositsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_DepositsOutput> Get_Customer_DepositsAsync(Get_Customer_DepositsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_DepositOutput Submit_Customer_Deposit(Submit_Customer_DepositInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_DepositOutput> Submit_Customer_DepositAsync(Submit_Customer_DepositInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_AwardsOutput Get_Awards(Get_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_AwardsOutput> Get_AwardsAsync(Get_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_AwardOutput Submit_Award(Submit_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_AwardOutput> Submit_AwardAsync(Submit_AwardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Administration_Basis_TypesOutput Get_Facilities_and_Administration_Basis_Types(Get_Facilities_and_Administration_Basis_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Administration_Basis_TypesOutput> Get_Facilities_and_Administration_Basis_TypesAsync(Get_Facilities_and_Administration_Basis_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Administration_Basis_TypeOutput Put_Facilities_and_Administration_Basis_Type(Put_Facilities_and_Administration_Basis_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Administration_Basis_TypeOutput> Put_Facilities_and_Administration_Basis_TypeAsync(Put_Facilities_and_Administration_Basis_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Administration_Object_Class_MappingsOutput Get_Facilities_and_Administration_Object_Class_Mappings(Get_Facilities_and_Administration_Object_Class_MappingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Administration_Object_Class_MappingsOutput> Get_Facilities_and_Administration_Object_Class_MappingsAsync(Get_Facilities_and_Administration_Object_Class_MappingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Administration_Object_Class_MappingOutput Put_Facilities_and_Administration_Object_Class_Mapping(Put_Facilities_and_Administration_Object_Class_MappingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Administration_Object_Class_MappingOutput> Put_Facilities_and_Administration_Object_Class_MappingAsync(Put_Facilities_and_Administration_Object_Class_MappingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SponsorsOutput Get_Sponsors(Get_SponsorsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SponsorsOutput> Get_SponsorsAsync(Get_SponsorsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SponsorOutput Put_Sponsor(Put_SponsorInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SponsorOutput> Put_SponsorAsync(Put_SponsorInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_RefundOutput Submit_Customer_Refund(Submit_Customer_RefundInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_RefundOutput> Submit_Customer_RefundAsync(Submit_Customer_RefundInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_SchedulesOutput Get_Award_Schedules(Get_Award_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_SchedulesOutput> Get_Award_SchedulesAsync(Get_Award_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_ScheduleOutput Put_Award_Schedule(Put_Award_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_ScheduleOutput> Put_Award_ScheduleAsync(Put_Award_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_Date_MilestonesOutput Get_Customer_Date_Milestones(Get_Customer_Date_MilestonesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_Date_MilestonesOutput> Get_Customer_Date_MilestonesAsync(Get_Customer_Date_MilestonesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_Date_MilestoneOutput Put_Customer_Date_Milestone(Put_Customer_Date_MilestoneInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_Date_MilestoneOutput> Put_Customer_Date_MilestoneAsync(Put_Customer_Date_MilestoneInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Billing_SchedulesOutput Get_Billing_Schedules(Get_Billing_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Billing_SchedulesOutput> Get_Billing_SchedulesAsync(Get_Billing_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Billing_ScheduleOutput Submit_Billing_Schedule(Submit_Billing_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Billing_ScheduleOutput> Submit_Billing_ScheduleAsync(Submit_Billing_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Admin_Cost_Rate_Type_TypesOutput Get_Facilities_and_Admin_Cost_Rate_Type_Types(Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Admin_Cost_Rate_Type_TypesOutput> Get_Facilities_and_Admin_Cost_Rate_Type_TypesAsync(Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_Recognition_SchedulesOutput Get_Revenue_Recognition_Schedules(Get_Revenue_Recognition_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_Recognition_SchedulesOutput> Get_Revenue_Recognition_SchedulesAsync(Get_Revenue_Recognition_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Revenue_Recognition_ScheduleOutput Submit_Revenue_Recognition_Schedule(Submit_Revenue_Recognition_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Revenue_Recognition_ScheduleOutput> Submit_Revenue_Recognition_ScheduleAsync(Submit_Revenue_Recognition_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Administration_Rate_AgreementsOutput Get_Facilities_and_Administration_Rate_Agreements(Get_Facilities_and_Administration_Rate_AgreementsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Administration_Rate_AgreementsOutput> Get_Facilities_and_Administration_Rate_AgreementsAsync(Get_Facilities_and_Administration_Rate_AgreementsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Administration_Rate_AgreementOutput Put_Facilities_and_Administration_Rate_Agreement(Put_Facilities_and_Administration_Rate_AgreementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Administration_Rate_AgreementOutput> Put_Facilities_and_Administration_Rate_AgreementAsync(Put_Facilities_and_Administration_Rate_AgreementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput Put_Facilities_and_Admin_Cost_Rate_Type_Type(Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput> Put_Facilities_and_Admin_Cost_Rate_Type_TypeAsync(Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Administration_ExceptionsOutput Get_Facilities_and_Administration_Exceptions(Get_Facilities_and_Administration_ExceptionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Administration_ExceptionsOutput> Get_Facilities_and_Administration_ExceptionsAsync(Get_Facilities_and_Administration_ExceptionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Administration_ExceptionOutput Put_Facilities_and_Administration_Exception(Put_Facilities_and_Administration_ExceptionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Administration_ExceptionOutput> Put_Facilities_and_Administration_ExceptionAsync(Put_Facilities_and_Administration_ExceptionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_ProposalsOutput Get_Award_Proposals(Get_Award_ProposalsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_ProposalsOutput> Get_Award_ProposalsAsync(Get_Award_ProposalsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Award_ProposalOutput Submit_Award_Proposal(Submit_Award_ProposalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Award_ProposalOutput> Submit_Award_ProposalAsync(Submit_Award_ProposalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Customer_ContractOutput Cancel_Customer_Contract(Cancel_Customer_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Customer_ContractOutput> Cancel_Customer_ContractAsync(Cancel_Customer_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesOutput Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles(Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesOutput> Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesAsync(Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile(Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput> Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileAsync(Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_Category_HierarchiesOutput Get_Revenue_Category_Hierarchies(Get_Revenue_Category_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_Category_HierarchiesOutput> Get_Revenue_Category_HierarchiesAsync(Get_Revenue_Category_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Revenue_Category_HierarchyOutput Put_Revenue_Category_Hierarchy(Put_Revenue_Category_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Revenue_Category_HierarchyOutput> Put_Revenue_Category_HierarchyAsync(Put_Revenue_Category_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Award_AmendmentOutput Submit_Award_Amendment(Submit_Award_AmendmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Award_AmendmentOutput> Submit_Award_AmendmentAsync(Submit_Award_AmendmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Proposal_Submission_TypesOutput Get_Award_Proposal_Submission_Types(Get_Award_Proposal_Submission_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Proposal_Submission_TypesOutput> Get_Award_Proposal_Submission_TypesAsync(Get_Award_Proposal_Submission_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Proposal_Submission_TypeOutput Put_Award_Proposal_Submission_Type(Put_Award_Proposal_Submission_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Proposal_Submission_TypeOutput> Put_Award_Proposal_Submission_TypeAsync(Put_Award_Proposal_Submission_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Proposal_Lifecycle_StatusesOutput Get_Award_Proposal_Lifecycle_Statuses(Get_Award_Proposal_Lifecycle_StatusesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Proposal_Lifecycle_StatusesOutput> Get_Award_Proposal_Lifecycle_StatusesAsync(Get_Award_Proposal_Lifecycle_StatusesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Proposal_Lifecycle_StatusOutput Put_Award_Proposal_Lifecycle_Status(Put_Award_Proposal_Lifecycle_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Proposal_Lifecycle_StatusOutput> Put_Award_Proposal_Lifecycle_StatusAsync(Put_Award_Proposal_Lifecycle_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_Contract_AmendmentOutput Submit_Customer_Contract_Amendment(Submit_Customer_Contract_AmendmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_Contract_AmendmentOutput> Submit_Customer_Contract_AmendmentAsync(Submit_Customer_Contract_AmendmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_Contract_AmendmentsOutput Get_Customer_Contract_Amendments(Get_Customer_Contract_AmendmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_Contract_AmendmentsOutput> Get_Customer_Contract_AmendmentsAsync(Get_Customer_Contract_AmendmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_ConnectionOutput Put_Business_Connection(Put_Business_ConnectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_ConnectionOutput> Put_Business_ConnectionAsync(Put_Business_ConnectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_ConnectionsOutput Get_Business_Connections(Get_Business_ConnectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_ConnectionsOutput> Get_Business_ConnectionsAsync(Get_Business_ConnectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Task_Type_GroupsOutput Get_Award_Task_Type_Groups(Get_Award_Task_Type_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Task_Type_GroupsOutput> Get_Award_Task_Type_GroupsAsync(Get_Award_Task_Type_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_TasksOutput Get_Award_Tasks(Get_Award_TasksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_TasksOutput> Get_Award_TasksAsync(Get_Award_TasksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Tasks_for_AwardOutput Put_Award_Tasks_for_Award(Put_Award_Tasks_for_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Tasks_for_AwardOutput> Put_Award_Tasks_for_AwardAsync(Put_Award_Tasks_for_AwardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Task_Type_GroupOutput Put_Award_Task_Type_Group(Put_Award_Task_Type_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Task_Type_GroupOutput> Put_Award_Task_Type_GroupAsync(Put_Award_Task_Type_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Task_StatusesOutput Get_Award_Task_Statuses(Get_Award_Task_StatusesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Task_StatusesOutput> Get_Award_Task_StatusesAsync(Get_Award_Task_StatusesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Task_StatusOutput Put_Award_Task_Status(Put_Award_Task_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Task_StatusOutput> Put_Award_Task_StatusAsync(Put_Award_Task_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_Recognition_Schedule_TemplatesOutput Get_Revenue_Recognition_Schedule_Templates(Get_Revenue_Recognition_Schedule_TemplatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_Recognition_Schedule_TemplatesOutput> Get_Revenue_Recognition_Schedule_TemplatesAsync(Get_Revenue_Recognition_Schedule_TemplatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Revenue_Recognition_Schedule_TemplateOutput Put_Revenue_Recognition_Schedule_Template(Put_Revenue_Recognition_Schedule_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Revenue_Recognition_Schedule_TemplateOutput> Put_Revenue_Recognition_Schedule_TemplateAsync(Put_Revenue_Recognition_Schedule_TemplateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Rate_CategoryOutput Put_Project_Rate_Category(Put_Project_Rate_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Rate_CategoryOutput> Put_Project_Rate_CategoryAsync(Put_Project_Rate_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Rate_CategoriesOutput Get_Project_Rate_Categories(Get_Project_Rate_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Rate_CategoriesOutput> Get_Project_Rate_CategoriesAsync(Get_Project_Rate_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contract_Rate_SheetsOutput Get_Contract_Rate_Sheets(Get_Contract_Rate_SheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contract_Rate_SheetsOutput> Get_Contract_Rate_SheetsAsync(Get_Contract_Rate_SheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Contract_Rate_SheetOutput Put_Contract_Rate_Sheet(Put_Contract_Rate_SheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Contract_Rate_SheetOutput> Put_Contract_Rate_SheetAsync(Put_Contract_Rate_SheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Correct_AwardOutput Correct_Award(Correct_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Correct_AwardOutput> Correct_AwardAsync(Correct_AwardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Usage_Based_TransactionOutput Put_Usage_Based_Transaction(Put_Usage_Based_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Usage_Based_TransactionOutput> Put_Usage_Based_TransactionAsync(Put_Usage_Based_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Usage_Based_TransactionsOutput Get_Usage_Based_Transactions(Get_Usage_Based_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Usage_Based_TransactionsOutput> Get_Usage_Based_TransactionsAsync(Get_Usage_Based_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Billing_Rate_SheetsOutput Get_Project_Billing_Rate_Sheets(Get_Project_Billing_Rate_SheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Billing_Rate_SheetsOutput> Get_Project_Billing_Rate_SheetsAsync(Get_Project_Billing_Rate_SheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Billing_Rate_SheetOutput Put_Project_Billing_Rate_Sheet(Put_Project_Billing_Rate_SheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Billing_Rate_SheetOutput> Put_Project_Billing_Rate_SheetAsync(Put_Project_Billing_Rate_SheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Companies_as_Business_EntitiesOutput Get_Companies_as_Business_Entities(Get_Companies_as_Business_EntitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Companies_as_Business_EntitiesOutput> Get_Companies_as_Business_EntitiesAsync(Get_Companies_as_Business_EntitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Company_as_Business_EntityOutput Put_Company_as_Business_Entity(Put_Company_as_Business_EntityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Company_as_Business_EntityOutput> Put_Company_as_Business_EntityAsync(Put_Company_as_Business_EntityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_Invoice_Collection_InformationOutput Put_Customer_Invoice_Collection_Information(Put_Customer_Invoice_Collection_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_Invoice_Collection_InformationOutput> Put_Customer_Invoice_Collection_InformationAsync(Put_Customer_Invoice_Collection_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_Invoice_Adjustment_Collection_InformationOutput Put_Customer_Invoice_Adjustment_Collection_Information(Put_Customer_Invoice_Adjustment_Collection_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_Invoice_Adjustment_Collection_InformationOutput> Put_Customer_Invoice_Adjustment_Collection_InformationAsync(Put_Customer_Invoice_Adjustment_Collection_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Lifecycle_StatusOutput Put_Award_Lifecycle_Status(Put_Award_Lifecycle_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Lifecycle_StatusOutput> Put_Award_Lifecycle_StatusAsync(Put_Award_Lifecycle_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Lifecycle_StatusesOutput Get_Award_Lifecycle_Statuses(Get_Award_Lifecycle_StatusesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Lifecycle_StatusesOutput> Get_Award_Lifecycle_StatusesAsync(Get_Award_Lifecycle_StatusesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Sales_Item_Fair_Value_Price_ListsOutput Get_Sales_Item_Fair_Value_Price_Lists(Get_Sales_Item_Fair_Value_Price_ListsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Sales_Item_Fair_Value_Price_ListsOutput> Get_Sales_Item_Fair_Value_Price_ListsAsync(Get_Sales_Item_Fair_Value_Price_ListsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Sales_Item_Fair_Value_Price_ListOutput Put_Sales_Item_Fair_Value_Price_List(Put_Sales_Item_Fair_Value_Price_ListInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Sales_Item_Fair_Value_Price_ListOutput> Put_Sales_Item_Fair_Value_Price_ListAsync(Put_Sales_Item_Fair_Value_Price_ListInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Subrecipient_Risk_RecordsOutput Get_Subrecipient_Risk_Records(Get_Subrecipient_Risk_RecordsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Subrecipient_Risk_RecordsOutput> Get_Subrecipient_Risk_RecordsAsync(Get_Subrecipient_Risk_RecordsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Subrecipient_Risk_RecordOutput Put_Subrecipient_Risk_Record(Put_Subrecipient_Risk_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Subrecipient_Risk_RecordOutput> Put_Subrecipient_Risk_RecordAsync(Put_Subrecipient_Risk_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Subaward_Risk_AssessmentsOutput Get_Subaward_Risk_Assessments(Get_Subaward_Risk_AssessmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Subaward_Risk_AssessmentsOutput> Get_Subaward_Risk_AssessmentsAsync(Get_Subaward_Risk_AssessmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Subaward_Risk_AssessmentOutput Put_Subaward_Risk_Assessment(Put_Subaward_Risk_AssessmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Subaward_Risk_AssessmentOutput> Put_Subaward_Risk_AssessmentAsync(Put_Subaward_Risk_AssessmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SubrecipientOutput Put_Subrecipient(Put_SubrecipientInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SubrecipientOutput> Put_SubrecipientAsync(Put_SubrecipientInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SubrecipientsOutput Get_Subrecipients(Get_SubrecipientsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SubrecipientsOutput> Get_SubrecipientsAsync(Get_SubrecipientsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contact_TypesOutput Get_Contact_Types(Get_Contact_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contact_TypesOutput> Get_Contact_TypesAsync(Get_Contact_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Contact_TypeOutput Put_Contact_Type(Put_Contact_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Contact_TypeOutput> Put_Contact_TypeAsync(Put_Contact_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SubawardsOutput Get_Subawards(Get_SubawardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SubawardsOutput> Get_SubawardsAsync(Get_SubawardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SubawardOutput Put_Subaward(Put_SubawardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SubawardOutput> Put_SubawardAsync(Put_SubawardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ad_Hoc_Billable_TransactionsOutput Get_Ad_Hoc_Billable_Transactions(Get_Ad_Hoc_Billable_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ad_Hoc_Billable_TransactionsOutput> Get_Ad_Hoc_Billable_TransactionsAsync(Get_Ad_Hoc_Billable_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Ad_Hoc_Billable_TransactionOutput Put_Ad_Hoc_Billable_Transaction(Put_Ad_Hoc_Billable_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Ad_Hoc_Billable_TransactionOutput> Put_Ad_Hoc_Billable_TransactionAsync(Put_Ad_Hoc_Billable_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Catalog_of_Federal_Domestic_AssistanceOutput Put_Catalog_of_Federal_Domestic_Assistance(Put_Catalog_of_Federal_Domestic_AssistanceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Catalog_of_Federal_Domestic_AssistanceOutput> Put_Catalog_of_Federal_Domestic_AssistanceAsync(Put_Catalog_of_Federal_Domestic_AssistanceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Catalog_of_Federal_Domestic_AssistanceOutput Get_Catalog_of_Federal_Domestic_Assistance(Get_Catalog_of_Federal_Domestic_AssistanceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Catalog_of_Federal_Domestic_AssistanceOutput> Get_Catalog_of_Federal_Domestic_AssistanceAsync(Get_Catalog_of_Federal_Domestic_AssistanceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Revenue_Recognition_ScheduleOutput Cancel_Revenue_Recognition_Schedule(Cancel_Revenue_Recognition_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Revenue_Recognition_ScheduleOutput> Cancel_Revenue_Recognition_ScheduleAsync(Cancel_Revenue_Recognition_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_TaskOutput Put_Award_Task(Put_Award_TaskInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_TaskOutput> Put_Award_TaskAsync(Put_Award_TaskInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_GroupsOutput Get_Award_Groups(Get_Award_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_GroupsOutput> Get_Award_GroupsAsync(Get_Award_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_GroupOutput Put_Award_Group(Put_Award_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_GroupOutput> Put_Award_GroupAsync(Put_Award_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Salary_CapsOutput Get_Salary_Caps(Get_Salary_CapsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Salary_CapsOutput> Get_Salary_CapsAsync(Get_Salary_CapsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Salary_CapOutput Put_Salary_Cap(Put_Salary_CapInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Salary_CapOutput> Put_Salary_CapAsync(Put_Salary_CapInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Task_List_TemplatesOutput Get_Award_Task_List_Templates(Get_Award_Task_List_TemplatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Task_List_TemplatesOutput> Get_Award_Task_List_TemplatesAsync(Get_Award_Task_List_TemplatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Task_List_TemplateOutput Put_Award_Task_List_Template(Put_Award_Task_List_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Task_List_TemplateOutput> Put_Award_Task_List_TemplateAsync(Put_Award_Task_List_TemplateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_Contract_Renewal_TermsOutput Get_Customer_Contract_Renewal_Terms(Get_Customer_Contract_Renewal_TermsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_Contract_Renewal_TermsOutput> Get_Customer_Contract_Renewal_TermsAsync(Get_Customer_Contract_Renewal_TermsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_Contract_Renewal_TermsOutput Put_Customer_Contract_Renewal_Terms(Put_Customer_Contract_Renewal_TermsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_Contract_Renewal_TermsOutput> Put_Customer_Contract_Renewal_TermsAsync(Put_Customer_Contract_Renewal_TermsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Company_Creditor_IdentifierOutput Put_Company_Creditor_Identifier(Put_Company_Creditor_IdentifierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Company_Creditor_IdentifierOutput> Put_Company_Creditor_IdentifierAsync(Put_Company_Creditor_IdentifierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Company_Creditor_IdentifiersOutput Get_Company_Creditor_Identifiers(Get_Company_Creditor_IdentifiersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Company_Creditor_IdentifiersOutput> Get_Company_Creditor_IdentifiersAsync(Get_Company_Creditor_IdentifiersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Salary_Over_The_Cap_TypesOutput Get_Salary_Over_The_Cap_Types(Get_Salary_Over_The_Cap_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Salary_Over_The_Cap_TypesOutput> Get_Salary_Over_The_Cap_TypesAsync(Get_Salary_Over_The_Cap_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Salary_Over_the_Cap_TypeOutput Put_Salary_Over_the_Cap_Type(Put_Salary_Over_the_Cap_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Salary_Over_the_Cap_TypeOutput> Put_Salary_Over_the_Cap_TypeAsync(Put_Salary_Over_the_Cap_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Lifecycle_Status_Update_RulesOutput Get_Award_Lifecycle_Status_Update_Rules(Get_Award_Lifecycle_Status_Update_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Lifecycle_Status_Update_RulesOutput> Get_Award_Lifecycle_Status_Update_RulesAsync(Get_Award_Lifecycle_Status_Update_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Lifecycle_Status_Update_RuleOutput Put_Award_Lifecycle_Status_Update_Rule(Put_Award_Lifecycle_Status_Update_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Lifecycle_Status_Update_RuleOutput> Put_Award_Lifecycle_Status_Update_RuleAsync(Put_Award_Lifecycle_Status_Update_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Order_Fulfillment_TransactionOutput Put_Order_Fulfillment_Transaction(Put_Order_Fulfillment_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Order_Fulfillment_TransactionOutput> Put_Order_Fulfillment_TransactionAsync(Put_Order_Fulfillment_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Order_Fulfillment_TransactionsOutput Get_Order_Fulfillment_Transactions(Get_Order_Fulfillment_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Order_Fulfillment_TransactionsOutput> Get_Order_Fulfillment_TransactionsAsync(Get_Order_Fulfillment_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Consolidated_InvoiceOutput Cancel_Consolidated_Invoice(Cancel_Consolidated_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Consolidated_InvoiceOutput> Cancel_Consolidated_InvoiceAsync(Cancel_Consolidated_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Customer_Contract_Change_OrderOutput Submit_Customer_Contract_Change_Order(Submit_Customer_Contract_Change_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Customer_Contract_Change_OrderOutput> Submit_Customer_Contract_Change_OrderAsync(Submit_Customer_Contract_Change_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Percent_Complete_ProjectsOutput Get_Percent_Complete_Projects(Get_Percent_Complete_ProjectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Percent_Complete_ProjectsOutput> Get_Percent_Complete_ProjectsAsync(Get_Percent_Complete_ProjectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Percent_Complete_ProjectOutput Put_Percent_Complete_Project(Put_Percent_Complete_ProjectInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Percent_Complete_ProjectOutput> Put_Percent_Complete_ProjectAsync(Put_Percent_Complete_ProjectInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Deferred_Cost_TransactionOutput Put_Deferred_Cost_Transaction(Put_Deferred_Cost_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Deferred_Cost_TransactionOutput> Put_Deferred_Cost_TransactionAsync(Put_Deferred_Cost_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Deferred_Cost_TransactionsOutput Get_Deferred_Cost_Transactions(Get_Deferred_Cost_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Deferred_Cost_TransactionsOutput> Get_Deferred_Cost_TransactionsAsync(Get_Deferred_Cost_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Consolidated_InvoicesOutput Get_Consolidated_Invoices(Get_Consolidated_InvoicesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Consolidated_InvoicesOutput> Get_Consolidated_InvoicesAsync(Get_Consolidated_InvoicesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Consolidated_InvoiceOutput Put_Consolidated_Invoice(Put_Consolidated_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Consolidated_InvoiceOutput> Put_Consolidated_InvoiceAsync(Put_Consolidated_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Alternate_Customer_ContractsOutput Get_Alternate_Customer_Contracts(Get_Alternate_Customer_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Alternate_Customer_ContractsOutput> Get_Alternate_Customer_ContractsAsync(Get_Alternate_Customer_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Alternate_Customer_ContractOutput Put_Alternate_Customer_Contract(Put_Alternate_Customer_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Alternate_Customer_ContractOutput> Put_Alternate_Customer_ContractAsync(Put_Alternate_Customer_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Dunning_Level_GroupsOutput Get_Dunning_Level_Groups(Get_Dunning_Level_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Dunning_Level_GroupsOutput> Get_Dunning_Level_GroupsAsync(Get_Dunning_Level_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Dunning_Level_GroupOutput Put_Dunning_Level_Group(Put_Dunning_Level_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Dunning_Level_GroupOutput> Put_Dunning_Level_GroupAsync(Put_Dunning_Level_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Usage_Billing_RateOutput Put_Usage_Billing_Rate(Put_Usage_Billing_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Usage_Billing_RateOutput> Put_Usage_Billing_RateAsync(Put_Usage_Billing_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Usage_Billing_RatesOutput Get_Usage_Billing_Rates(Get_Usage_Billing_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Usage_Billing_RatesOutput> Get_Usage_Billing_RatesAsync(Get_Usage_Billing_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Customer_InvoiceOutput Import_Customer_Invoice(Import_Customer_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Customer_InvoiceOutput> Import_Customer_InvoiceAsync(Import_Customer_InvoiceInput request);
	}
}
