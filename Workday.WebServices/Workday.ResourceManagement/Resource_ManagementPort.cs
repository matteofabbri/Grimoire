using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Resource_Management", ConfigurationName = "ResourceManagement.Resource_ManagementPort")]
	public interface Resource_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_InvoiceOutput Submit_Supplier_Invoice(Submit_Supplier_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_InvoiceOutput> Submit_Supplier_InvoiceAsync(Submit_Supplier_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Resource_CategoriesOutput Get_Resource_Categories(Get_Resource_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Resource_CategoriesOutput> Get_Resource_CategoriesAsync(Get_Resource_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Resource_CategoryOutput Put_Resource_Category(Put_Resource_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Resource_CategoryOutput> Put_Resource_CategoryAsync(Put_Resource_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_Item_GroupsOutput Get_Purchase_Item_Groups(Get_Purchase_Item_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_Item_GroupsOutput> Get_Purchase_Item_GroupsAsync(Get_Purchase_Item_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Purchase_Item_GroupOutput Put_Purchase_Item_Group(Put_Purchase_Item_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Purchase_Item_GroupOutput> Put_Purchase_Item_GroupAsync(Put_Purchase_Item_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_ItemsOutput Get_Expense_Items(Get_Expense_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_ItemsOutput> Get_Expense_ItemsAsync(Get_Expense_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_ItemsOutput Get_Purchase_Items(Get_Purchase_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_ItemsOutput> Get_Purchase_ItemsAsync(Get_Purchase_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Purchase_ItemOutput Put_Purchase_Item(Put_Purchase_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Purchase_ItemOutput> Put_Purchase_ItemAsync(Put_Purchase_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_ItemOutput Put_Expense_Item(Put_Expense_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_ItemOutput> Put_Expense_ItemAsync(Put_Expense_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SuppliersOutput Get_Suppliers(Get_SuppliersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SuppliersOutput> Get_SuppliersAsync(Get_SuppliersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SupplierOutput Put_Supplier(Put_SupplierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SupplierOutput> Put_SupplierAsync(Put_SupplierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Invoice_AdjustmentOutput Submit_Supplier_Invoice_Adjustment(Submit_Supplier_Invoice_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Invoice_AdjustmentOutput> Submit_Supplier_Invoice_AdjustmentAsync(Submit_Supplier_Invoice_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Item_GroupsOutput Get_Expense_Item_Groups(Get_Expense_Item_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Item_GroupsOutput> Get_Expense_Item_GroupsAsync(Get_Expense_Item_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Item_GroupOutput Put_Expense_Item_Group(Put_Expense_Item_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Item_GroupOutput> Put_Expense_Item_GroupAsync(Put_Expense_Item_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Supplier_InvoiceOutput Cancel_Supplier_Invoice(Cancel_Supplier_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Supplier_InvoiceOutput> Cancel_Supplier_InvoiceAsync(Cancel_Supplier_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Supplier_Invoice_AdjustmentOutput Cancel_Supplier_Invoice_Adjustment(Cancel_Supplier_Invoice_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Supplier_Invoice_AdjustmentOutput> Cancel_Supplier_Invoice_AdjustmentAsync(Cancel_Supplier_Invoice_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PO_for_PO_Issue_OutboundOutput Get_PO_for_PO_Issue_Outbound(Get_PO_for_PO_Issue_OutboundInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PO_for_PO_Issue_OutboundOutput> Get_PO_for_PO_Issue_OutboundAsync(Get_PO_for_PO_Issue_OutboundInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_CategoriesOutput Get_Supplier_Categories(Get_Supplier_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_CategoriesOutput> Get_Supplier_CategoriesAsync(Get_Supplier_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Supplier_CategoryOutput Put_Supplier_Category(Put_Supplier_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Supplier_CategoryOutput> Put_Supplier_CategoryAsync(Put_Supplier_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Supplier_GroupOutput Put_Supplier_Group(Put_Supplier_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Supplier_GroupOutput> Put_Supplier_GroupAsync(Put_Supplier_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_GroupsOutput Get_Supplier_Groups(Get_Supplier_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_GroupsOutput> Get_Supplier_GroupsAsync(Get_Supplier_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Catalog_LoadOutput Submit_Catalog_Load(Submit_Catalog_LoadInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Catalog_LoadOutput> Submit_Catalog_LoadAsync(Submit_Catalog_LoadInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_TimesheetsOutput Get_Timesheets(Get_TimesheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_TimesheetsOutput> Get_TimesheetsAsync(Get_TimesheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Corporate_Credit_Card_AccountsOutput Get_Corporate_Credit_Card_Accounts(Get_Corporate_Credit_Card_AccountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Corporate_Credit_Card_AccountsOutput> Get_Corporate_Credit_Card_AccountsAsync(Get_Corporate_Credit_Card_AccountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Corporate_Credit_Card_AccountOutput Put_Corporate_Credit_Card_Account(Put_Corporate_Credit_Card_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Corporate_Credit_Card_AccountOutput> Put_Corporate_Credit_Card_AccountAsync(Put_Corporate_Credit_Card_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Credit_CardsOutput Get_Expense_Credit_Cards(Get_Expense_Credit_CardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Credit_CardsOutput> Get_Expense_Credit_CardsAsync(Get_Expense_Credit_CardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Credit_CardOutput Put_Expense_Credit_Card(Put_Expense_Credit_CardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Credit_CardOutput> Put_Expense_Credit_CardAsync(Put_Expense_Credit_CardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Entity_ContactsOutput Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_Entity_ContactOutput Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_InvoicesOutput Get_Supplier_Invoices(Get_Supplier_InvoicesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_InvoicesOutput> Get_Supplier_InvoicesAsync(Get_Supplier_InvoicesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Invoice_AdjustmentsOutput Get_Supplier_Invoice_Adjustments(Get_Supplier_Invoice_AdjustmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Invoice_AdjustmentsOutput> Get_Supplier_Invoice_AdjustmentsAsync(Get_Supplier_Invoice_AdjustmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Catalog_LoadsOutput Get_Catalog_Loads(Get_Catalog_LoadsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Catalog_LoadsOutput> Get_Catalog_LoadsAsync(Get_Catalog_LoadsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Invoice_HistoriesOutput Get_Supplier_Invoice_Histories(Get_Supplier_Invoice_HistoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Invoice_HistoriesOutput> Get_Supplier_Invoice_HistoriesAsync(Get_Supplier_Invoice_HistoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Supplier_Invoice_HistoryOutput Put_Supplier_Invoice_History(Put_Supplier_Invoice_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Supplier_Invoice_HistoryOutput> Put_Supplier_Invoice_HistoryAsync(Put_Supplier_Invoice_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Worker_RolesOutput Get_Project_Worker_Roles(Get_Project_Worker_RolesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Worker_RolesOutput> Get_Project_Worker_RolesAsync(Get_Project_Worker_RolesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Worker_RoleOutput Put_Project_Worker_Role(Put_Project_Worker_RoleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Worker_RoleOutput> Put_Project_Worker_RoleAsync(Put_Project_Worker_RoleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_TasksOutput Get_Project_Tasks(Get_Project_TasksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_TasksOutput> Get_Project_TasksAsync(Get_Project_TasksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_TaskOutput Put_Project_Task(Put_Project_TaskInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_TaskOutput> Put_Project_TaskAsync(Put_Project_TaskInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_PhasesOutput Get_Project_Phases(Get_Project_PhasesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_PhasesOutput> Get_Project_PhasesAsync(Get_Project_PhasesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_PhaseOutput Put_Project_Phase(Put_Project_PhaseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_PhaseOutput> Put_Project_PhaseAsync(Put_Project_PhaseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Expense_ReportOutput Submit_Expense_Report(Submit_Expense_ReportInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Expense_ReportOutput> Submit_Expense_ReportAsync(Submit_Expense_ReportInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_ReportsOutput Get_Expense_Reports(Get_Expense_ReportsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_ReportsOutput> Get_Expense_ReportsAsync(Get_Expense_ReportsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Expense_ReportOutput Cancel_Expense_Report(Cancel_Expense_ReportInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Expense_ReportOutput> Cancel_Expense_ReportAsync(Cancel_Expense_ReportInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Purchase_OrderOutput Submit_Purchase_Order(Submit_Purchase_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Purchase_OrderOutput> Submit_Purchase_OrderAsync(Submit_Purchase_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Order_ContractsOutput Get_Supplier_Order_Contracts(Get_Supplier_Order_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Order_ContractsOutput> Get_Supplier_Order_ContractsAsync(Get_Supplier_Order_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_OrdersOutput Get_Purchase_Orders(Get_Purchase_OrdersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_OrdersOutput> Get_Purchase_OrdersAsync(Get_Purchase_OrdersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Policy_GroupsOutput Get_Expense_Policy_Groups(Get_Expense_Policy_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Policy_GroupsOutput> Get_Expense_Policy_GroupsAsync(Get_Expense_Policy_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Policy_GroupOutput Put_Expense_Policy_Group(Put_Expense_Policy_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Policy_GroupOutput> Put_Expense_Policy_GroupAsync(Put_Expense_Policy_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Rate_Table_RulesOutput Get_Expense_Rate_Table_Rules(Get_Expense_Rate_Table_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Rate_Table_RulesOutput> Get_Expense_Rate_Table_RulesAsync(Get_Expense_Rate_Table_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Rate_Table_RuleOutput Put_Expense_Rate_Table_Rule(Put_Expense_Rate_Table_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Rate_Table_RuleOutput> Put_Expense_Rate_Table_RuleAsync(Put_Expense_Rate_Table_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Rate_TablesOutput Get_Expense_Rate_Tables(Get_Expense_Rate_TablesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Rate_TablesOutput> Get_Expense_Rate_TablesAsync(Get_Expense_Rate_TablesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Rate_TableOutput Put_Expense_Rate_Table(Put_Expense_Rate_TableInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Rate_TableOutput> Put_Expense_Rate_TableAsync(Put_Expense_Rate_TableInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Spend_Category_HierarchyOutput Put_Spend_Category_Hierarchy(Put_Spend_Category_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Spend_Category_HierarchyOutput> Put_Spend_Category_HierarchyAsync(Put_Spend_Category_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Spend_Category_HierarchiesOutput Get_Spend_Category_Hierarchies(Get_Spend_Category_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Spend_Category_HierarchiesOutput> Get_Spend_Category_HierarchiesAsync(Get_Spend_Category_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Expense_Report_for_ApplicantOutput Submit_Expense_Report_for_Applicant(Submit_Expense_Report_for_ApplicantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Expense_Report_for_ApplicantOutput> Submit_Expense_Report_for_ApplicantAsync(Submit_Expense_Report_for_ApplicantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Timesheets_Time_In_Time_OutOutput Get_Payroll_Timesheets_Time_In_Time_Out(Get_Payroll_Timesheets_Time_In_Time_OutInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Timesheets_Time_In_Time_OutOutput> Get_Payroll_Timesheets_Time_In_Time_OutAsync(Get_Payroll_Timesheets_Time_In_Time_OutInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Timesheets_Total_HoursOutput Get_Payroll_Timesheets_Total_Hours(Get_Payroll_Timesheets_Total_HoursInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Timesheets_Total_HoursOutput> Get_Payroll_Timesheets_Total_HoursAsync(Get_Payroll_Timesheets_Total_HoursInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_TimesheetsOutput Get_Project_Timesheets(Get_Project_TimesheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_TimesheetsOutput> Get_Project_TimesheetsAsync(Get_Project_TimesheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Project_TimesheetOutput Submit_Project_Timesheet(Submit_Project_TimesheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Project_TimesheetOutput> Submit_Project_TimesheetAsync(Submit_Project_TimesheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_TimesheetOutput Cancel_Timesheet(Cancel_TimesheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_TimesheetOutput> Cancel_TimesheetAsync(Cancel_TimesheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Travel_ProfilesOutput Get_Travel_Profiles(Get_Travel_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Travel_ProfilesOutput> Get_Travel_ProfilesAsync(Get_Travel_ProfilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Credit_Card_Transaction_FilesOutput Get_Expense_Credit_Card_Transaction_Files(Get_Expense_Credit_Card_Transaction_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Credit_Card_Transaction_FilesOutput> Get_Expense_Credit_Card_Transaction_FilesAsync(Get_Expense_Credit_Card_Transaction_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Credit_Card_Transaction_FileOutput Put_Expense_Credit_Card_Transaction_File(Put_Expense_Credit_Card_Transaction_FileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Credit_Card_Transaction_FileOutput> Put_Expense_Credit_Card_Transaction_FileAsync(Put_Expense_Credit_Card_Transaction_FileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Credit_Card_TransactionsOutput Get_Expense_Credit_Card_Transactions(Get_Expense_Credit_Card_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Credit_Card_TransactionsOutput> Get_Expense_Credit_Card_TransactionsAsync(Get_Expense_Credit_Card_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Credit_Card_TransactionOutput Put_Expense_Credit_Card_Transaction(Put_Expense_Credit_Card_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Credit_Card_TransactionOutput> Put_Expense_Credit_Card_TransactionAsync(Put_Expense_Credit_Card_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Card_Holder_Listing_FileOutput Put_Card_Holder_Listing_File(Put_Card_Holder_Listing_FileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Card_Holder_Listing_FileOutput> Put_Card_Holder_Listing_FileAsync(Put_Card_Holder_Listing_FileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Card_Holder_Listing_FilesOutput Get_Card_Holder_Listing_Files(Get_Card_Holder_Listing_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Card_Holder_Listing_FilesOutput> Get_Card_Holder_Listing_FilesAsync(Get_Card_Holder_Listing_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Expense_Item_Attribute_GroupOutput Put_Expense_Item_Attribute_Group(Put_Expense_Item_Attribute_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Expense_Item_Attribute_GroupOutput> Put_Expense_Item_Attribute_GroupAsync(Put_Expense_Item_Attribute_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Expense_Item_Attribute_GroupsOutput Get_Expense_Item_Attribute_Groups(Get_Expense_Item_Attribute_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Expense_Item_Attribute_GroupsOutput> Get_Expense_Item_Attribute_GroupsAsync(Get_Expense_Item_Attribute_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Invoice_ContractOutput Submit_Supplier_Invoice_Contract(Submit_Supplier_Invoice_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Invoice_ContractOutput> Submit_Supplier_Invoice_ContractAsync(Submit_Supplier_Invoice_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Order_ContractOutput Submit_Supplier_Order_Contract(Submit_Supplier_Order_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Order_ContractOutput> Submit_Supplier_Order_ContractAsync(Submit_Supplier_Order_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ReceiptsOutput Get_Receipts(Get_ReceiptsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ReceiptsOutput> Get_ReceiptsAsync(Get_ReceiptsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_ReceiptOutput Submit_Receipt(Submit_ReceiptInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_ReceiptOutput> Submit_ReceiptAsync(Submit_ReceiptInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Register_AssetOutput Register_Asset(Register_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Register_AssetOutput> Register_AssetAsync(Register_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Catalog_ItemsOutput Get_Catalog_Items(Get_Catalog_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Catalog_ItemsOutput> Get_Catalog_ItemsAsync(Get_Catalog_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Purchase_OrderOutput Cancel_Purchase_Order(Cancel_Purchase_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Purchase_OrderOutput> Cancel_Purchase_OrderAsync(Cancel_Purchase_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_RequisitionsOutput Get_Requisitions(Get_RequisitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_RequisitionsOutput> Get_RequisitionsAsync(Get_RequisitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Asset_Book_RulesOutput Get_Asset_Book_Rules(Get_Asset_Book_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Asset_Book_RulesOutput> Get_Asset_Book_RulesAsync(Get_Asset_Book_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Asset_Book_RulesOutput Put_Asset_Book_Rules(Put_Asset_Book_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Asset_Book_RulesOutput> Put_Asset_Book_RulesAsync(Put_Asset_Book_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_RequisitionOutput Cancel_Requisition(Cancel_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_RequisitionOutput> Cancel_RequisitionAsync(Cancel_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Issue_AssetOutput Issue_Asset(Issue_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Issue_AssetOutput> Issue_AssetAsync(Issue_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_RequisitionOutput Submit_Requisition(Submit_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_RequisitionOutput> Submit_RequisitionAsync(Submit_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Adjust_Asset_CostOutput Adjust_Asset_Cost(Adjust_Asset_CostInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Adjust_Asset_CostOutput> Adjust_Asset_CostAsync(Adjust_Asset_CostInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_AssetOutput Edit_Asset(Edit_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_AssetOutput> Edit_AssetAsync(Edit_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Asset_Useful_LifeOutput Update_Asset_Useful_Life(Update_Asset_Useful_LifeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Asset_Useful_LifeOutput> Update_Asset_Useful_LifeAsync(Update_Asset_Useful_LifeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Transfer_AssetOutput Transfer_Asset(Transfer_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Transfer_AssetOutput> Transfer_AssetAsync(Transfer_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Spend_AuthorizationOutput Submit_Spend_Authorization(Submit_Spend_AuthorizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Spend_AuthorizationOutput> Submit_Spend_AuthorizationAsync(Submit_Spend_AuthorizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Spend_AuthorizationsOutput Get_Spend_Authorizations(Get_Spend_AuthorizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Spend_AuthorizationsOutput> Get_Spend_AuthorizationsAsync(Get_Spend_AuthorizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Invoice_SchedulesOutput Get_Supplier_Invoice_Schedules(Get_Supplier_Invoice_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Invoice_SchedulesOutput> Get_Supplier_Invoice_SchedulesAsync(Get_Supplier_Invoice_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_Order_SchedulesOutput Get_Purchase_Order_Schedules(Get_Purchase_Order_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_Order_SchedulesOutput> Get_Purchase_Order_SchedulesAsync(Get_Purchase_Order_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_ContractOutput Submit_Supplier_Contract(Submit_Supplier_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_ContractOutput> Submit_Supplier_ContractAsync(Submit_Supplier_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_ContractsOutput Get_Supplier_Contracts(Get_Supplier_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_ContractsOutput> Get_Supplier_ContractsAsync(Get_Supplier_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_AirlinesOutput Get_Airlines(Get_AirlinesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_AirlinesOutput> Get_AirlinesAsync(Get_AirlinesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_AirlineOutput Put_Airline(Put_AirlineInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_AirlineOutput> Put_AirlineAsync(Put_AirlineInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_HotelsOutput Get_Hotels(Get_HotelsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_HotelsOutput> Get_HotelsAsync(Get_HotelsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_HotelOutput Put_Hotel(Put_HotelInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_HotelOutput> Put_HotelAsync(Put_HotelInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Car_Rental_AgenciesOutput Get_Car_Rental_Agencies(Get_Car_Rental_AgenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Car_Rental_AgenciesOutput> Get_Car_Rental_AgenciesAsync(Get_Car_Rental_AgenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Car_Rental_AgencyOutput Put_Car_Rental_Agency(Put_Car_Rental_AgencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Car_Rental_AgencyOutput> Put_Car_Rental_AgencyAsync(Put_Car_Rental_AgencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Travel_CitiesOutput Get_Travel_Cities(Get_Travel_CitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Travel_CitiesOutput> Get_Travel_CitiesAsync(Get_Travel_CitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Travel_CityOutput Put_Travel_City(Put_Travel_CityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Travel_CityOutput> Put_Travel_CityAsync(Put_Travel_CityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_AirportsOutput Get_Airports(Get_AirportsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_AirportsOutput> Get_AirportsAsync(Get_AirportsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_AirportOutput Put_Airport(Put_AirportInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_AirportOutput> Put_AirportAsync(Put_AirportInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Transfer_Asset_To_Different_CompanyOutput Transfer_Asset_To_Different_Company(Transfer_Asset_To_Different_CompanyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Transfer_Asset_To_Different_CompanyOutput> Transfer_Asset_To_Different_CompanyAsync(Transfer_Asset_To_Different_CompanyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_AssetsOutput Get_Assets(Get_AssetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_AssetsOutput> Get_AssetsAsync(Get_AssetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Impair_AssetOutput Impair_Asset(Impair_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Impair_AssetOutput> Impair_AssetAsync(Impair_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Reinstate_AssetOutput Reinstate_Asset(Reinstate_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Reinstate_AssetOutput> Reinstate_AssetAsync(Reinstate_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Dispose_AssetOutput Dispose_Asset(Dispose_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Dispose_AssetOutput> Dispose_AssetAsync(Dispose_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Asset_Book_ConfigurationsOutput Get_Asset_Book_Configurations(Get_Asset_Book_ConfigurationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Asset_Book_ConfigurationsOutput> Get_Asset_Book_ConfigurationsAsync(Get_Asset_Book_ConfigurationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Asset_Book_ConfigurationOutput Update_Asset_Book_Configuration(Update_Asset_Book_ConfigurationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Asset_Book_ConfigurationOutput> Update_Asset_Book_ConfigurationAsync(Update_Asset_Book_ConfigurationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Scenario_GroupsOutput Get_Project_Scenario_Groups(Get_Project_Scenario_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Scenario_GroupsOutput> Get_Project_Scenario_GroupsAsync(Get_Project_Scenario_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Scenario_GroupOutput Put_Project_Scenario_Group(Put_Project_Scenario_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Scenario_GroupOutput> Put_Project_Scenario_GroupAsync(Put_Project_Scenario_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_ScenariosOutput Get_Project_Scenarios(Get_Project_ScenariosInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_ScenariosOutput> Get_Project_ScenariosAsync(Get_Project_ScenariosInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Project_ScenarioOutput Submit_Project_Scenario(Submit_Project_ScenarioInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Project_ScenarioOutput> Submit_Project_ScenarioAsync(Submit_Project_ScenarioInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Remove_AssetOutput Remove_Asset(Remove_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Remove_AssetOutput> Remove_AssetAsync(Remove_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_ReceiptOutput Cancel_Receipt(Cancel_ReceiptInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_ReceiptOutput> Cancel_ReceiptAsync(Cancel_ReceiptInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Prepaid_Spend_AmortizationsOutput Get_Prepaid_Spend_Amortizations(Get_Prepaid_Spend_AmortizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Prepaid_Spend_AmortizationsOutput> Get_Prepaid_Spend_AmortizationsAsync(Get_Prepaid_Spend_AmortizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Prepaid_Spend_AmortizationOutput Submit_Prepaid_Spend_Amortization(Submit_Prepaid_Spend_AmortizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Prepaid_Spend_AmortizationOutput> Submit_Prepaid_Spend_AmortizationAsync(Submit_Prepaid_Spend_AmortizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Invoice_ScheduleOutput Submit_Supplier_Invoice_Schedule(Submit_Supplier_Invoice_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Invoice_ScheduleOutput> Submit_Supplier_Invoice_ScheduleAsync(Submit_Supplier_Invoice_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Suspend_Asset_DepreciationOutput Suspend_Asset_Depreciation(Suspend_Asset_DepreciationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Suspend_Asset_DepreciationOutput> Suspend_Asset_DepreciationAsync(Suspend_Asset_DepreciationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Remove_Supplier_Contract_Line_HoldOutput Remove_Supplier_Contract_Line_Hold(Remove_Supplier_Contract_Line_HoldInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Remove_Supplier_Contract_Line_HoldOutput> Remove_Supplier_Contract_Line_HoldAsync(Remove_Supplier_Contract_Line_HoldInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Supplier_Contract_Line_HoldOutput Add_Supplier_Contract_Line_Hold(Add_Supplier_Contract_Line_HoldInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Supplier_Contract_Line_HoldOutput> Add_Supplier_Contract_Line_HoldAsync(Add_Supplier_Contract_Line_HoldInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Purchase_Order_ScheduleOutput Submit_Purchase_Order_Schedule(Submit_Purchase_Order_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Purchase_Order_ScheduleOutput> Submit_Purchase_Order_ScheduleAsync(Submit_Purchase_Order_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Prepaid_Spend_Amortization_ScheduleOutput Submit_Prepaid_Spend_Amortization_Schedule(Submit_Prepaid_Spend_Amortization_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Prepaid_Spend_Amortization_ScheduleOutput> Submit_Prepaid_Spend_Amortization_ScheduleAsync(Submit_Prepaid_Spend_Amortization_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Prepaid_Spend_Amortization_SchedulesOutput Get_Prepaid_Spend_Amortization_Schedules(Get_Prepaid_Spend_Amortization_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Prepaid_Spend_Amortization_SchedulesOutput> Get_Prepaid_Spend_Amortization_SchedulesAsync(Get_Prepaid_Spend_Amortization_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_AssetOutput Get_Project_Asset(Get_Project_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_AssetOutput> Get_Project_AssetAsync(Get_Project_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_AssetOutput Put_Project_Asset(Put_Project_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_AssetOutput> Put_Project_AssetAsync(Put_Project_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Resume_Asset_DepreciationOutput Resume_Asset_Depreciation(Resume_Asset_DepreciationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Resume_Asset_DepreciationOutput> Resume_Asset_DepreciationAsync(Resume_Asset_DepreciationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Asset_Pooling_RulesOutput Get_Asset_Pooling_Rules(Get_Asset_Pooling_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Asset_Pooling_RulesOutput> Get_Asset_Pooling_RulesAsync(Get_Asset_Pooling_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Asset_Pooling_RuleOutput Put_Asset_Pooling_Rule(Put_Asset_Pooling_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Asset_Pooling_RuleOutput> Put_Asset_Pooling_RuleAsync(Put_Asset_Pooling_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_SupplierOutput Submit_Supplier(Submit_SupplierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_SupplierOutput> Submit_SupplierAsync(Submit_SupplierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_ReturnOutput Submit_Return(Submit_ReturnInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_ReturnOutput> Submit_ReturnAsync(Submit_ReturnInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ReturnsOutput Get_Returns(Get_ReturnsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ReturnsOutput> Get_ReturnsAsync(Get_ReturnsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Place_Asset_in_ServiceOutput Place_Asset_in_Service(Place_Asset_in_ServiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Place_Asset_in_ServiceOutput> Place_Asset_in_ServiceAsync(Place_Asset_in_ServiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Workday_Project_HierarchyOutput Submit_Workday_Project_Hierarchy(Submit_Workday_Project_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Workday_Project_HierarchyOutput> Submit_Workday_Project_HierarchyAsync(Submit_Workday_Project_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workday_Project_HierarchiesOutput Get_Workday_Project_Hierarchies(Get_Workday_Project_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workday_Project_HierarchiesOutput> Get_Workday_Project_HierarchiesAsync(Get_Workday_Project_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workday_Project_Hierarchies_without_DependenciesOutput Get_Workday_Project_Hierarchies_without_Dependencies(Get_Workday_Project_Hierarchies_without_DependenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workday_Project_Hierarchies_without_DependenciesOutput> Get_Workday_Project_Hierarchies_without_DependenciesAsync(Get_Workday_Project_Hierarchies_without_DependenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Procurement_Card_Transaction_VerificationsOutput Get_Procurement_Card_Transaction_Verifications(Get_Procurement_Card_Transaction_VerificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Procurement_Card_Transaction_VerificationsOutput> Get_Procurement_Card_Transaction_VerificationsAsync(Get_Procurement_Card_Transaction_VerificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Procurement_Card_Transaction_VerificationOutput Submit_Procurement_Card_Transaction_Verification(Submit_Procurement_Card_Transaction_VerificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Procurement_Card_Transaction_VerificationOutput> Submit_Procurement_Card_Transaction_VerificationAsync(Submit_Procurement_Card_Transaction_VerificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Procurement_Mass_CloseOutput Get_Procurement_Mass_Close(Get_Procurement_Mass_CloseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Procurement_Mass_CloseOutput> Get_Procurement_Mass_CloseAsync(Get_Procurement_Mass_CloseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Procurement_Mass_CloseOutput Submit_Procurement_Mass_Close(Submit_Procurement_Mass_CloseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Procurement_Mass_CloseOutput> Submit_Procurement_Mass_CloseAsync(Submit_Procurement_Mass_CloseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Travel_Booking_FilesOutput Get_Travel_Booking_Files(Get_Travel_Booking_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Travel_Booking_FilesOutput> Get_Travel_Booking_FilesAsync(Get_Travel_Booking_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Task_ResourcesOutput Put_Project_Task_Resources(Put_Project_Task_ResourcesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Task_ResourcesOutput> Put_Project_Task_ResourcesAsync(Put_Project_Task_ResourcesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Task_ResourcesOutput Get_Project_Task_Resources(Get_Project_Task_ResourcesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Task_ResourcesOutput> Get_Project_Task_ResourcesAsync(Get_Project_Task_ResourcesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_ProjectOutput Submit_Project(Submit_ProjectInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_ProjectOutput> Submit_ProjectAsync(Submit_ProjectInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ProjectsOutput Get_Projects(Get_ProjectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ProjectsOutput> Get_ProjectsAsync(Get_ProjectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_PlansOutput Get_Project_Plans(Get_Project_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_PlansOutput> Get_Project_PlansAsync(Get_Project_PlansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_PlanOutput Put_Project_Plan(Put_Project_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_PlanOutput> Put_Project_PlanAsync(Put_Project_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Resource_PlanOutput Submit_Resource_Plan(Submit_Resource_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Resource_PlanOutput> Submit_Resource_PlanAsync(Submit_Resource_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Resource_PlansOutput Get_Resource_Plans(Get_Resource_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Resource_PlansOutput> Get_Resource_PlansAsync(Get_Resource_PlansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Request_for_QuoteOutput Get_Request_for_Quote(Get_Request_for_QuoteInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Request_for_QuoteOutput> Get_Request_for_QuoteAsync(Get_Request_for_QuoteInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Request_for_QuoteOutput Submit_Request_for_Quote(Submit_Request_for_QuoteInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Request_for_QuoteOutput> Submit_Request_for_QuoteAsync(Submit_Request_for_QuoteInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Reclassify_AssetOutput Reclassify_Asset(Reclassify_AssetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Reclassify_AssetOutput> Reclassify_AssetAsync(Reclassify_AssetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Request_for_Quote_ResponsesOutput Get_Request_for_Quote_Responses(Get_Request_for_Quote_ResponsesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Request_for_Quote_ResponsesOutput> Get_Request_for_Quote_ResponsesAsync(Get_Request_for_Quote_ResponsesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Request_for_Quote_ResponseOutput Submit_Request_for_Quote_Response(Submit_Request_for_Quote_ResponseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Request_for_Quote_ResponseOutput> Submit_Request_for_Quote_ResponseAsync(Submit_Request_for_Quote_ResponseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_ConnectionsOutput Get_Supplier_Connections(Get_Supplier_ConnectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_ConnectionsOutput> Get_Supplier_ConnectionsAsync(Get_Supplier_ConnectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_ConnectionOutput Submit_Supplier_Connection(Submit_Supplier_ConnectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_ConnectionOutput> Submit_Supplier_ConnectionAsync(Submit_Supplier_ConnectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Requirements_for_Resource_PlanOutput Put_Requirements_for_Resource_Plan(Put_Requirements_for_Resource_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Requirements_for_Resource_PlanOutput> Put_Requirements_for_Resource_PlanAsync(Put_Requirements_for_Resource_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Requirements_for_Resource_PlanOutput Get_Requirements_for_Resource_Plan(Get_Requirements_for_Resource_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Requirements_for_Resource_PlanOutput> Get_Requirements_for_Resource_PlanAsync(Get_Requirements_for_Resource_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Request_for_Quote_AwardsOutput Get_Request_for_Quote_Awards(Get_Request_for_Quote_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Request_for_Quote_AwardsOutput> Get_Request_for_Quote_AwardsAsync(Get_Request_for_Quote_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Request_for_Quote_AwardOutput Submit_Request_for_Quote_Award(Submit_Request_for_Quote_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Request_for_Quote_AwardOutput> Submit_Request_for_Quote_AwardAsync(Submit_Request_for_Quote_AwardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_GuestsOutput Get_Guests(Get_GuestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_GuestsOutput> Get_GuestsAsync(Get_GuestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Guest_Listing_FilesOutput Get_Guest_Listing_Files(Get_Guest_Listing_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Guest_Listing_FilesOutput> Get_Guest_Listing_FilesAsync(Get_Guest_Listing_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Contact_InformationOutput Submit_Supplier_Contact_Information(Submit_Supplier_Contact_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Contact_InformationOutput> Submit_Supplier_Contact_InformationAsync(Submit_Supplier_Contact_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Contact_InformationOutput Get_Supplier_Contact_Information(Get_Supplier_Contact_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Contact_InformationOutput> Get_Supplier_Contact_InformationAsync(Get_Supplier_Contact_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Resource_ForecastsOutput Get_Resource_Forecasts(Get_Resource_ForecastsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Resource_ForecastsOutput> Get_Resource_ForecastsAsync(Get_Resource_ForecastsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Cash_Advance_RepaymentOutput Put_Cash_Advance_Repayment(Put_Cash_Advance_RepaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Cash_Advance_RepaymentOutput> Put_Cash_Advance_RepaymentAsync(Put_Cash_Advance_RepaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Cash_Advance_RepaymentsOutput Get_Cash_Advance_Repayments(Get_Cash_Advance_RepaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Cash_Advance_RepaymentsOutput> Get_Cash_Advance_RepaymentsAsync(Get_Cash_Advance_RepaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_Order_Change_OrdersOutput Get_Purchase_Order_Change_Orders(Get_Purchase_Order_Change_OrdersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_Order_Change_OrdersOutput> Get_Purchase_Order_Change_OrdersAsync(Get_Purchase_Order_Change_OrdersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Purchase_Order_Change_OrderOutput Submit_Purchase_Order_Change_Order(Submit_Purchase_Order_Change_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Purchase_Order_Change_OrderOutput> Submit_Purchase_Order_Change_OrderAsync(Submit_Purchase_Order_Change_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Maintain_Asset_SharesOutput Maintain_Asset_Shares(Maintain_Asset_SharesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Maintain_Asset_SharesOutput> Maintain_Asset_SharesAsync(Maintain_Asset_SharesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Asset_SharesOutput Get_Asset_Shares(Get_Asset_SharesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Asset_SharesOutput> Get_Asset_SharesAsync(Get_Asset_SharesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Request_for_Quote_ResponseOutput Cancel_Request_for_Quote_Response(Cancel_Request_for_Quote_ResponseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Request_for_Quote_ResponseOutput> Cancel_Request_for_Quote_ResponseAsync(Cancel_Request_for_Quote_ResponseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Project_Standard_Cost_Rate_SheetsOutput Get_Project_Standard_Cost_Rate_Sheets(Get_Project_Standard_Cost_Rate_SheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Project_Standard_Cost_Rate_SheetsOutput> Get_Project_Standard_Cost_Rate_SheetsAsync(Get_Project_Standard_Cost_Rate_SheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Project_Standard_Cost_Rate_SheetOutput Put_Project_Standard_Cost_Rate_Sheet(Put_Project_Standard_Cost_Rate_SheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Project_Standard_Cost_Rate_SheetOutput> Put_Project_Standard_Cost_Rate_SheetAsync(Put_Project_Standard_Cost_Rate_SheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Internal_Service_DeliveriesOutput Get_Internal_Service_Deliveries(Get_Internal_Service_DeliveriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Internal_Service_DeliveriesOutput> Get_Internal_Service_DeliveriesAsync(Get_Internal_Service_DeliveriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Expense_Report_for_NonWorkerOutput Submit_Expense_Report_for_NonWorker(Submit_Expense_Report_for_NonWorkerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Expense_Report_for_NonWorkerOutput> Submit_Expense_Report_for_NonWorkerAsync(Submit_Expense_Report_for_NonWorkerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Internal_Service_DeliveryOutput Submit_Internal_Service_Delivery(Submit_Internal_Service_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Internal_Service_DeliveryOutput> Submit_Internal_Service_DeliveryAsync(Submit_Internal_Service_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Internal_Service_DeliveryOutput Cancel_Internal_Service_Delivery(Cancel_Internal_Service_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Internal_Service_DeliveryOutput> Cancel_Internal_Service_DeliveryAsync(Cancel_Internal_Service_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Internal_Service_ProvidersOutput Get_Internal_Service_Providers(Get_Internal_Service_ProvidersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Internal_Service_ProvidersOutput> Get_Internal_Service_ProvidersAsync(Get_Internal_Service_ProvidersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Internal_Service_ProviderOutput Put_Internal_Service_Provider(Put_Internal_Service_ProviderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Internal_Service_ProviderOutput> Put_Internal_Service_ProviderAsync(Put_Internal_Service_ProviderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Internal_CatalogsOutput Get_Internal_Catalogs(Get_Internal_CatalogsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Internal_CatalogsOutput> Get_Internal_CatalogsAsync(Get_Internal_CatalogsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Internal_CatalogOutput Put_Internal_Catalog(Put_Internal_CatalogInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Internal_CatalogOutput> Put_Internal_CatalogAsync(Put_Internal_CatalogInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Credit_Card_Code_MappingsOutput Get_Credit_Card_Code_Mappings(Get_Credit_Card_Code_MappingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Credit_Card_Code_MappingsOutput> Get_Credit_Card_Code_MappingsAsync(Get_Credit_Card_Code_MappingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Credit_Card_Code_MappingOutput Put_Credit_Card_Code_Mapping(Put_Credit_Card_Code_MappingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Credit_Card_Code_MappingOutput> Put_Credit_Card_Code_MappingAsync(Put_Credit_Card_Code_MappingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_Invoice_RequestsOutput Get_Supplier_Invoice_Requests(Get_Supplier_Invoice_RequestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_Invoice_RequestsOutput> Get_Supplier_Invoice_RequestsAsync(Get_Supplier_Invoice_RequestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Supplier_Invoice_RequestOutput Submit_Supplier_Invoice_Request(Submit_Supplier_Invoice_RequestInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Supplier_Invoice_RequestOutput> Submit_Supplier_Invoice_RequestAsync(Submit_Supplier_Invoice_RequestInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Procurement_Document_AttachmentOutput Put_Procurement_Document_Attachment(Put_Procurement_Document_AttachmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Procurement_Document_AttachmentOutput> Put_Procurement_Document_AttachmentAsync(Put_Procurement_Document_AttachmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Adjust_Asset_In_Service_DateOutput Adjust_Asset_In_Service_Date(Adjust_Asset_In_Service_DateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Adjust_Asset_In_Service_DateOutput> Adjust_Asset_In_Service_DateAsync(Adjust_Asset_In_Service_DateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Advanced_Ship_NoticeOutput Submit_Advanced_Ship_Notice(Submit_Advanced_Ship_NoticeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Advanced_Ship_NoticeOutput> Submit_Advanced_Ship_NoticeAsync(Submit_Advanced_Ship_NoticeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Advanced_Ship_NoticesOutput Get_Advanced_Ship_Notices(Get_Advanced_Ship_NoticesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Advanced_Ship_NoticesOutput> Get_Advanced_Ship_NoticesAsync(Get_Advanced_Ship_NoticesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Purchase_Order_AcknowledgementOutput Submit_Purchase_Order_Acknowledgement(Submit_Purchase_Order_AcknowledgementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Purchase_Order_AcknowledgementOutput> Submit_Purchase_Order_AcknowledgementAsync(Submit_Purchase_Order_AcknowledgementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Advanced_Ship_NoticeOutput Cancel_Advanced_Ship_Notice(Cancel_Advanced_Ship_NoticeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Advanced_Ship_NoticeOutput> Cancel_Advanced_Ship_NoticeAsync(Cancel_Advanced_Ship_NoticeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_Travel_Profile_Listing_FilesOutput Get_Worker_Travel_Profile_Listing_Files(Get_Worker_Travel_Profile_Listing_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_Travel_Profile_Listing_FilesOutput> Get_Worker_Travel_Profile_Listing_FilesAsync(Get_Worker_Travel_Profile_Listing_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Purchase_Order_AcknowledgementOutput Get_Purchase_Order_Acknowledgement(Get_Purchase_Order_AcknowledgementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Purchase_Order_AcknowledgementOutput> Get_Purchase_Order_AcknowledgementAsync(Get_Purchase_Order_AcknowledgementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Supplier_Invoice(Import_Supplier_InvoiceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Supplier_InvoiceAsync(Import_Supplier_InvoiceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Travel_Booking_Records(Import_Travel_Booking_RecordsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Travel_Booking_RecordsAsync(Import_Travel_Booking_RecordsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Credit_Card_Transactions(Import_Credit_Card_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Credit_Card_TransactionsAsync(Import_Credit_Card_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Catalog_Load(Import_Catalog_LoadInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Catalog_LoadAsync(Import_Catalog_LoadInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Credit_Cards(Import_Credit_CardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Credit_CardsAsync(Import_Credit_CardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Guests(Import_GuestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_GuestsAsync(Import_GuestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Resource_Forecast(Import_Resource_ForecastInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Resource_ForecastAsync(Import_Resource_ForecastInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Expense_Rate_Table(Import_Expense_Rate_TableInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Expense_Rate_TableAsync(Import_Expense_Rate_TableInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Supplier_InvoiceOutput Import_Travel_Profiles(Import_Travel_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Supplier_InvoiceOutput> Import_Travel_ProfilesAsync(Import_Travel_ProfilesInput request);
	}
}
