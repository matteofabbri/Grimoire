using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Financial_Management", ConfigurationName = "Financial_ManagementService.Financial_ManagementPort")]
	public interface Financial_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Accounting_JournalOutput Submit_Accounting_Journal(Submit_Accounting_JournalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Accounting_JournalOutput> Submit_Accounting_JournalAsync(Submit_Accounting_JournalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Currency_Conversion_RateOutput Put_Currency_Conversion_Rate(Put_Currency_Conversion_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Currency_Conversion_RateOutput> Put_Currency_Conversion_RateAsync(Put_Currency_Conversion_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_JournalsOutput Get_Journals(Get_JournalsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_JournalsOutput> Get_JournalsAsync(Get_JournalsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CompaniesOutput Get_Companies(Get_CompaniesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CompaniesOutput> Get_CompaniesAsync(Get_CompaniesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_CategoriesOutput Get_Revenue_Categories(Get_Revenue_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_CategoriesOutput> Get_Revenue_CategoriesAsync(Get_Revenue_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Resource_CategoriesOutput Get_Resource_Categories(Get_Resource_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Resource_CategoriesOutput> Get_Resource_CategoriesAsync(Get_Resource_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Resource_CategoryOutput Put_Resource_Category(Put_Resource_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Resource_CategoryOutput> Put_Resource_CategoryAsync(Put_Resource_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Revenue_CategoryOutput Put_Revenue_Category(Put_Revenue_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Revenue_CategoryOutput> Put_Revenue_CategoryAsync(Put_Revenue_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_TermsOutput Get_Payment_Terms(Get_Payment_TermsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_TermsOutput> Get_Payment_TermsAsync(Get_Payment_TermsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_TermOutput Put_Payment_Term(Put_Payment_TermInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_TermOutput> Put_Payment_TermAsync(Put_Payment_TermInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Transaction_Tax_CodesOutput Get_Transaction_Tax_Codes(Get_Transaction_Tax_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Transaction_Tax_CodesOutput> Get_Transaction_Tax_CodesAsync(Get_Transaction_Tax_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Transaction_Tax_CodeOutput Put_Transaction_Tax_Code(Put_Transaction_Tax_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Transaction_Tax_CodeOutput> Put_Transaction_Tax_CodeAsync(Put_Transaction_Tax_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_ApplicabilitiesOutput Get_Tax_Applicabilities(Get_Tax_ApplicabilitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_ApplicabilitiesOutput> Get_Tax_ApplicabilitiesAsync(Get_Tax_ApplicabilitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_ApplicabilityOutput Put_Tax_Applicability(Put_Tax_ApplicabilityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_ApplicabilityOutput> Put_Tax_ApplicabilityAsync(Put_Tax_ApplicabilityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_TypesOutput Get_Payment_Types(Get_Payment_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_TypesOutput> Get_Payment_TypesAsync(Get_Payment_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_TypeOutput Put_Payment_Type(Put_Payment_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_TypeOutput> Put_Payment_TypeAsync(Put_Payment_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Transaction_Tax_RatesOutput Get_Transaction_Tax_Rates(Get_Transaction_Tax_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Transaction_Tax_RatesOutput> Get_Transaction_Tax_RatesAsync(Get_Transaction_Tax_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Transaction_Tax_RateOutput Put_Transaction_Tax_Rate(Put_Transaction_Tax_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Transaction_Tax_RateOutput> Put_Transaction_Tax_RateAsync(Put_Transaction_Tax_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supplier_CategoriesOutput Get_Supplier_Categories(Get_Supplier_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supplier_CategoriesOutput> Get_Supplier_CategoriesAsync(Get_Supplier_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Supplier_CategoryOutput Put_Supplier_Category(Put_Supplier_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Supplier_CategoryOutput> Put_Supplier_CategoryAsync(Put_Supplier_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Customer_CategoriesOutput Get_Customer_Categories(Get_Customer_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Customer_CategoriesOutput> Get_Customer_CategoriesAsync(Get_Customer_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Customer_CategoryOutput Put_Customer_Category(Put_Customer_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Customer_CategoryOutput> Put_Customer_CategoryAsync(Put_Customer_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Currency_Rate_TypesOutput Get_Currency_Rate_Types(Get_Currency_Rate_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Currency_Rate_TypesOutput> Get_Currency_Rate_TypesAsync(Get_Currency_Rate_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Currency_Rate_TypeOutput Put_Currency_Rate_Type(Put_Currency_Rate_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Currency_Rate_TypeOutput> Put_Currency_Rate_TypeAsync(Put_Currency_Rate_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Currency_Conversion_RatesOutput Get_Currency_Conversion_Rates(Get_Currency_Conversion_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Currency_Conversion_RatesOutput> Get_Currency_Conversion_RatesAsync(Get_Currency_Conversion_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_CategoriesOutput Get_Tax_Categories(Get_Tax_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_CategoriesOutput> Get_Tax_CategoriesAsync(Get_Tax_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_CategoryOutput Put_Tax_Category(Put_Tax_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_CategoryOutput> Put_Tax_CategoryAsync(Put_Tax_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_AuthoritiesOutput Get_Tax_Authorities(Get_Tax_AuthoritiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_AuthoritiesOutput> Get_Tax_AuthoritiesAsync(Get_Tax_AuthoritiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_AuthorityOutput Put_Tax_Authority(Put_Tax_AuthorityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_AuthorityOutput> Put_Tax_AuthorityAsync(Put_Tax_AuthorityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Receivable_Writeoff_CategoriesOutput Get_Receivable_Writeoff_Categories(Get_Receivable_Writeoff_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Receivable_Writeoff_CategoriesOutput> Get_Receivable_Writeoff_CategoriesAsync(Get_Receivable_Writeoff_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Receivable_Writeoff_CategoryOutput Put_Receivable_Writeoff_Category(Put_Receivable_Writeoff_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Receivable_Writeoff_CategoryOutput> Put_Receivable_Writeoff_CategoryAsync(Put_Receivable_Writeoff_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Journal_SourcesOutput Get_Journal_Sources(Get_Journal_SourcesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Journal_SourcesOutput> Get_Journal_SourcesAsync(Get_Journal_SourcesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Journal_SourceOutput Put_Journal_Source(Put_Journal_SourceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Journal_SourceOutput> Put_Journal_SourceAsync(Put_Journal_SourceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Account_SetsOutput Get_Account_Sets(Get_Account_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Account_SetsOutput> Get_Account_SetsAsync(Get_Account_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Account_SetOutput Put_Account_Set(Put_Account_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Account_SetOutput> Put_Account_SetAsync(Put_Account_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Account_Posting_Rule_SetsOutput Get_Account_Posting_Rule_Sets(Get_Account_Posting_Rule_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Account_Posting_Rule_SetsOutput> Get_Account_Posting_Rule_SetsAsync(Get_Account_Posting_Rule_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Account_Posting_Rule_SetOutput Put_Account_Posting_Rule_Set(Put_Account_Posting_Rule_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Account_Posting_Rule_SetOutput> Put_Account_Posting_Rule_SetAsync(Put_Account_Posting_Rule_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ledger_Account_SummariesOutput Get_Ledger_Account_Summaries(Get_Ledger_Account_SummariesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ledger_Account_SummariesOutput> Get_Ledger_Account_SummariesAsync(Get_Ledger_Account_SummariesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Ledger_Account_SummaryOutput Put_Ledger_Account_Summary(Put_Ledger_Account_SummaryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Ledger_Account_SummaryOutput> Put_Ledger_Account_SummaryAsync(Put_Ledger_Account_SummaryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Accounting_JournalOutput Cancel_Accounting_Journal(Cancel_Accounting_JournalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Accounting_JournalOutput> Cancel_Accounting_JournalAsync(Cancel_Accounting_JournalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Entity_ContactsOutput Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_Entity_ContactOutput Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrganizationsOutput Get_Organizations(Get_OrganizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Get_OrganizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Plan_DetailsOutput Get_Business_Plan_Details(Get_Business_Plan_DetailsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Plan_DetailsOutput> Get_Business_Plan_DetailsAsync(Get_Business_Plan_DetailsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Beginning_Balance_JournalsOutput Get_Beginning_Balance_Journals(Get_Beginning_Balance_JournalsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Beginning_Balance_JournalsOutput> Get_Beginning_Balance_JournalsAsync(Get_Beginning_Balance_JournalsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Beginning_Balance_JournalOutput Put_Beginning_Balance_Journal(Put_Beginning_Balance_JournalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Beginning_Balance_JournalOutput> Put_Beginning_Balance_JournalAsync(Put_Beginning_Balance_JournalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Recurring_Journal_TemplatesOutput Get_Recurring_Journal_Templates(Get_Recurring_Journal_TemplatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Recurring_Journal_TemplatesOutput> Get_Recurring_Journal_TemplatesAsync(Get_Recurring_Journal_TemplatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Recurring_Journal_TemplateOutput Put_Recurring_Journal_Template(Put_Recurring_Journal_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Recurring_Journal_TemplateOutput> Put_Recurring_Journal_TemplateAsync(Put_Recurring_Journal_TemplateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Intercompany_ProfilesOutput Get_Intercompany_Profiles(Get_Intercompany_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Intercompany_ProfilesOutput> Get_Intercompany_ProfilesAsync(Get_Intercompany_ProfilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Intercompany_ProfileOutput Put_Intercompany_Profile(Put_Intercompany_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Intercompany_ProfileOutput> Put_Intercompany_ProfileAsync(Put_Intercompany_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Custom_Validation_RulesOutput Get_Custom_Validation_Rules(Get_Custom_Validation_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Custom_Validation_RulesOutput> Get_Custom_Validation_RulesAsync(Get_Custom_Validation_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Custom_Validation_RuleOutput Put_Custom_Validation_Rule(Put_Custom_Validation_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Custom_Validation_RuleOutput> Put_Custom_Validation_RuleAsync(Put_Custom_Validation_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Statistic_DefinitionsOutput Get_Statistic_Definitions(Get_Statistic_DefinitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Statistic_DefinitionsOutput> Get_Statistic_DefinitionsAsync(Get_Statistic_DefinitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Statistic_DefinitionOutput Put_Statistic_Definition(Put_Statistic_DefinitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Statistic_DefinitionOutput> Put_Statistic_DefinitionAsync(Put_Statistic_DefinitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_StatisticsOutput Get_Statistics(Get_StatisticsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_StatisticsOutput> Get_StatisticsAsync(Get_StatisticsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_StatisticOutput Put_Statistic(Put_StatisticInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_StatisticOutput> Put_StatisticAsync(Put_StatisticInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Custom_WorktagsOutput Get_Custom_Worktags(Get_Custom_WorktagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Custom_WorktagsOutput> Get_Custom_WorktagsAsync(Get_Custom_WorktagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Custom_WorktagOutput Put_Custom_Worktag(Put_Custom_WorktagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Custom_WorktagOutput> Put_Custom_WorktagAsync(Put_Custom_WorktagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Funding_SourcesOutput Get_Funding_Sources(Get_Funding_SourcesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Funding_SourcesOutput> Get_Funding_SourcesAsync(Get_Funding_SourcesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Funding_SourceOutput Put_Funding_Source(Put_Funding_SourceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Funding_SourceOutput> Put_Funding_SourceAsync(Put_Funding_SourceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Fund_TypesOutput Get_Fund_Types(Get_Fund_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Fund_TypesOutput> Get_Fund_TypesAsync(Get_Fund_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Fund_TypeOutput Put_Fund_Type(Put_Fund_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Fund_TypeOutput> Put_Fund_TypeAsync(Put_Fund_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_FundsOutput Get_Funds(Get_FundsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_FundsOutput> Get_FundsAsync(Get_FundsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_FundOutput Put_Fund(Put_FundInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_FundOutput> Put_FundAsync(Put_FundInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PaymentsOutput Get_Payments(Get_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PaymentsOutput> Get_PaymentsAsync(Get_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_MessagesOutput Get_Payment_Messages(Get_Payment_MessagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Get_Payment_MessagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_RegionsOutput Get_Regions(Get_RegionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_RegionsOutput> Get_RegionsAsync(Get_RegionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Cost_CentersOutput Get_Cost_Centers(Get_Cost_CentersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Cost_CentersOutput> Get_Cost_CentersAsync(Get_Cost_CentersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Cost_CenterOutput Put_Cost_Center(Put_Cost_CenterInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Cost_CenterOutput> Put_Cost_CenterAsync(Put_Cost_CenterInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Account_SetsOutput Get_Account_Sets_Without_Dependencies(Get_Account_Sets_Without_DependenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Account_SetsOutput> Get_Account_Sets_Without_DependenciesAsync(Get_Account_Sets_Without_DependenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Custom_Validation_RulesOutput Get_Custom_Validation_Rules_without_Dependencies(Get_Custom_Validation_Rules_without_DependenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Custom_Validation_RulesOutput> Get_Custom_Validation_Rules_without_DependenciesAsync(Get_Custom_Validation_Rules_without_DependenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Spend_Category_HierarchyOutput Put_Spend_Category_Hierarchy(Put_Spend_Category_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Spend_Category_HierarchyOutput> Put_Spend_Category_HierarchyAsync(Put_Spend_Category_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Spend_Category_HierarchiesOutput Get_Spend_Category_Hierarchies(Get_Spend_Category_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Spend_Category_HierarchiesOutput> Get_Spend_Category_HierarchiesAsync(Get_Spend_Category_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workday_CompaniesOutput Get_Workday_Companies(Get_Workday_CompaniesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workday_CompaniesOutput> Get_Workday_CompaniesAsync(Get_Workday_CompaniesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Position_BudgetsOutput Get_Position_Budgets(Get_Position_BudgetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Position_BudgetsOutput> Get_Position_BudgetsAsync(Get_Position_BudgetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_InvestorOutput Put_Investor(Put_InvestorInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_InvestorOutput> Put_InvestorAsync(Put_InvestorInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_InvestorsOutput Get_Investors(Get_InvestorsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_InvestorsOutput> Get_InvestorsAsync(Get_InvestorsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Company_1099_MISC_DataOutput Get_Company_1099_MISC_Data(Get_Company_1099_MISC_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Company_1099_MISC_DataOutput> Get_Company_1099_MISC_DataAsync(Get_Company_1099_MISC_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_Sales_ItemsOutput Get_Basic_Sales_Items(Get_Basic_Sales_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_Sales_ItemsOutput> Get_Basic_Sales_ItemsAsync(Get_Basic_Sales_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_Sales_ItemOutput Put_Basic_Sales_Item(Put_Basic_Sales_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_Sales_ItemOutput> Put_Basic_Sales_ItemAsync(Put_Basic_Sales_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_ProjectsOutput Get_Basic_Projects(Get_Basic_ProjectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_ProjectsOutput> Get_Basic_ProjectsAsync(Get_Basic_ProjectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_ProjectOutput Put_Basic_Project(Put_Basic_ProjectInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_ProjectOutput> Put_Basic_ProjectAsync(Put_Basic_ProjectInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_SuppliersOutput Get_Basic_Suppliers(Get_Basic_SuppliersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_SuppliersOutput> Get_Basic_SuppliersAsync(Get_Basic_SuppliersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_SupplierOutput Put_Basic_Supplier(Put_Basic_SupplierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_SupplierOutput> Put_Basic_SupplierAsync(Put_Basic_SupplierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_CustomersOutput Get_Basic_Customers(Get_Basic_CustomersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_CustomersOutput> Get_Basic_CustomersAsync(Get_Basic_CustomersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_CustomerOutput Put_Basic_Customer(Put_Basic_CustomerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_CustomerOutput> Put_Basic_CustomerAsync(Put_Basic_CustomerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Accounting_JournalOutput Unpost_Accounting_Journal(Unpost_Accounting_JournalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Accounting_JournalOutput> Unpost_Accounting_JournalAsync(Unpost_Accounting_JournalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_1099_MISCsOutput Get_1099_MISCs(Get_1099_MISCsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_1099_MISCsOutput> Get_1099_MISCsAsync(Get_1099_MISCsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Fund_HierarchyOutput Put_Fund_Hierarchy(Put_Fund_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Fund_HierarchyOutput> Put_Fund_HierarchyAsync(Put_Fund_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Fund_HierarchiesOutput Get_Fund_Hierarchies(Get_Fund_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Fund_HierarchiesOutput> Get_Fund_HierarchiesAsync(Get_Fund_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_GrantOutput Put_Grant(Put_GrantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_GrantOutput> Put_GrantAsync(Put_GrantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_GrantsOutput Get_Grants(Get_GrantsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_GrantsOutput> Get_GrantsAsync(Get_GrantsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_UnitOutput Put_Business_Unit(Put_Business_UnitInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_UnitOutput> Put_Business_UnitAsync(Put_Business_UnitInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_UnitsOutput Get_Business_Units(Get_Business_UnitsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_UnitsOutput> Get_Business_UnitsAsync(Get_Business_UnitsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_Unit_HierarchyOutput Put_Business_Unit_Hierarchy(Put_Business_Unit_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_Unit_HierarchyOutput> Put_Business_Unit_HierarchyAsync(Put_Business_Unit_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Unit_HierarchiesOutput Get_Business_Unit_Hierarchies(Get_Business_Unit_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Unit_HierarchiesOutput> Get_Business_Unit_HierarchiesAsync(Get_Business_Unit_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SurveysOutput Get_Surveys(Get_SurveysInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SurveysOutput> Get_SurveysAsync(Get_SurveysInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ProgramOutput Put_Program(Put_ProgramInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ProgramOutput> Put_ProgramAsync(Put_ProgramInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ProgramsOutput Get_Programs(Get_ProgramsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ProgramsOutput> Get_ProgramsAsync(Get_ProgramsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Program_HierarchyOutput Put_Program_Hierarchy(Put_Program_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Program_HierarchyOutput> Put_Program_HierarchyAsync(Put_Program_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SurveyOutput Put_Survey(Put_SurveyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SurveyOutput> Put_SurveyAsync(Put_SurveyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Program_HierarchiesOutput Get_Program_Hierarchies(Get_Program_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Program_HierarchiesOutput> Get_Program_HierarchiesAsync(Get_Program_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Object_Class_SetOutput Put_Object_Class_Set(Put_Object_Class_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Object_Class_SetOutput> Put_Object_Class_SetAsync(Put_Object_Class_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Object_Class_SetsOutput Get_Object_Class_Sets(Get_Object_Class_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Object_Class_SetsOutput> Get_Object_Class_SetsAsync(Get_Object_Class_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Search_SettingsOutput Get_Search_Settings(Get_Search_SettingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Search_SettingsOutput> Get_Search_SettingsAsync(Get_Search_SettingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Search_SettingsOutput Put_Search_Settings(Put_Search_SettingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Search_SettingsOutput> Put_Search_SettingsAsync(Put_Search_SettingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Effort_Certification_Change_Reason_CodeOutput Put_Effort_Certification_Change_Reason_Code(Put_Effort_Certification_Change_Reason_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Effort_Certification_Change_Reason_CodeOutput> Put_Effort_Certification_Change_Reason_CodeAsync(Put_Effort_Certification_Change_Reason_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Effort_Certification_Change_Reason_CodesOutput Get_Effort_Certification_Change_Reason_Codes(Get_Effort_Certification_Change_Reason_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Effort_Certification_Change_Reason_CodesOutput> Get_Effort_Certification_Change_Reason_CodesAsync(Get_Effort_Certification_Change_Reason_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Effort_Certifying_TextsOutput Get_Effort_Certifying_Texts(Get_Effort_Certifying_TextsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Effort_Certifying_TextsOutput> Get_Effort_Certifying_TextsAsync(Get_Effort_Certifying_TextsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Effort_Certification_Eligibility_RulesOutput Get_Effort_Certification_Eligibility_Rules(Get_Effort_Certification_Eligibility_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Effort_Certification_Eligibility_RulesOutput> Get_Effort_Certification_Eligibility_RulesAsync(Get_Effort_Certification_Eligibility_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Effort_Certifying_TextOutput Put_Effort_Certifying_Text(Put_Effort_Certifying_TextInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Effort_Certifying_TextOutput> Put_Effort_Certifying_TextAsync(Put_Effort_Certifying_TextInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Effort_Certification_TypesOutput Get_Effort_Certification_Types(Get_Effort_Certification_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Effort_Certification_TypesOutput> Get_Effort_Certification_TypesAsync(Get_Effort_Certification_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Effort_Certification_TypeOutput Put_Effort_Certification_Type(Put_Effort_Certification_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Effort_Certification_TypeOutput> Put_Effort_Certification_TypeAsync(Put_Effort_Certification_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Currency_Conversion_RatesOutput Put_Currency_Conversion_Rates(Put_Currency_Conversion_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Currency_Conversion_RatesOutput> Put_Currency_Conversion_RatesAsync(Put_Currency_Conversion_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Grant_HierarchiesOutput Get_Grant_Hierarchies(Get_Grant_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Grant_HierarchiesOutput> Get_Grant_HierarchiesAsync(Get_Grant_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Grant_HierarchyOutput Put_Grant_Hierarchy(Put_Grant_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Grant_HierarchyOutput> Put_Grant_HierarchyAsync(Put_Grant_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_1099_MISC_AdjustmentsOutput Get_1099_MISC_Adjustments(Get_1099_MISC_AdjustmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_1099_MISC_AdjustmentsOutput> Get_1099_MISC_AdjustmentsAsync(Get_1099_MISC_AdjustmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_1099_MISC_AdjustmentOutput Submit_1099_MISC_Adjustment(Submit_1099_MISC_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_1099_MISC_AdjustmentOutput> Submit_1099_MISC_AdjustmentAsync(Submit_1099_MISC_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_GrantsOutput Get_Basic_Grants(Get_Basic_GrantsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_GrantsOutput> Get_Basic_GrantsAsync(Get_Basic_GrantsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_GrantOutput Put_Basic_Grant(Put_Basic_GrantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_GrantOutput> Put_Basic_GrantAsync(Put_Basic_GrantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Award_Personnel_ResponsibilitiesOutput Get_Award_Personnel_Responsibilities(Get_Award_Personnel_ResponsibilitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Award_Personnel_ResponsibilitiesOutput> Get_Award_Personnel_ResponsibilitiesAsync(Get_Award_Personnel_ResponsibilitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Award_Personnel_ResponsibilityOutput Put_Award_Personnel_Responsibility(Put_Award_Personnel_ResponsibilityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Award_Personnel_ResponsibilityOutput> Put_Award_Personnel_ResponsibilityAsync(Put_Award_Personnel_ResponsibilityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Proposal_GrantsOutput Get_Proposal_Grants(Get_Proposal_GrantsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Proposal_GrantsOutput> Get_Proposal_GrantsAsync(Get_Proposal_GrantsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Proposal_GrantOutput Put_Proposal_Grant(Put_Proposal_GrantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Proposal_GrantOutput> Put_Proposal_GrantAsync(Put_Proposal_GrantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_GiftsOutput Get_Gifts(Get_GiftsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_GiftsOutput> Get_GiftsAsync(Get_GiftsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_GiftOutput Submit_Gift(Submit_GiftInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_GiftOutput> Submit_GiftAsync(Submit_GiftInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Beginning_Balance_Translation_AmountsOutput Put_Beginning_Balance_Translation_Amounts(Put_Beginning_Balance_Translation_AmountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Beginning_Balance_Translation_AmountsOutput> Put_Beginning_Balance_Translation_AmountsAsync(Put_Beginning_Balance_Translation_AmountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Beginning_Balance_Translation_AmountsOutput Get_Beginning_Balance_Translation_Amounts(Get_Beginning_Balance_Translation_AmountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Beginning_Balance_Translation_AmountsOutput> Get_Beginning_Balance_Translation_AmountsAsync(Get_Beginning_Balance_Translation_AmountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Revenue_Category_HierarchiesOutput Get_Revenue_Category_Hierarchies(Get_Revenue_Category_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Revenue_Category_HierarchiesOutput> Get_Revenue_Category_HierarchiesAsync(Get_Revenue_Category_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Revenue_Category_HierarchyOutput Put_Revenue_Category_Hierarchy(Put_Revenue_Category_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Revenue_Category_HierarchyOutput> Put_Revenue_Category_HierarchyAsync(Put_Revenue_Category_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Gift_HierarchiesOutput Get_Gift_Hierarchies(Get_Gift_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Gift_HierarchiesOutput> Get_Gift_HierarchiesAsync(Get_Gift_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Gift_HierarchyOutput Put_Gift_Hierarchy(Put_Gift_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Gift_HierarchyOutput> Put_Gift_HierarchyAsync(Put_Gift_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Contingent_Worker_Tax_Authority_Form_TypeOutput Put_Contingent_Worker_Tax_Authority_Form_Type(Put_Contingent_Worker_Tax_Authority_Form_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Contingent_Worker_Tax_Authority_Form_TypeOutput> Put_Contingent_Worker_Tax_Authority_Form_TypeAsync(Put_Contingent_Worker_Tax_Authority_Form_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_1042S_Income_CodesOutput Get_1042S_Income_Codes(Get_1042S_Income_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_1042S_Income_CodesOutput> Get_1042S_Income_CodesAsync(Get_1042S_Income_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Basic_GiftsOutput Get_Basic_Gifts(Get_Basic_GiftsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Basic_GiftsOutput> Get_Basic_GiftsAsync(Get_Basic_GiftsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Basic_GiftOutput Put_Basic_Gift(Put_Basic_GiftInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Basic_GiftOutput> Put_Basic_GiftAsync(Put_Basic_GiftInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_1042S_Income_CodeOutput Put_1042S_Income_Code(Put_1042S_Income_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_1042S_Income_CodeOutput> Put_1042S_Income_CodeAsync(Put_1042S_Income_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_LoansOutput Get_Loans(Get_LoansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_LoansOutput> Get_LoansAsync(Get_LoansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_LoanOutput Put_Loan(Put_LoanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_LoanOutput> Put_LoanAsync(Put_LoanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Loan_Investor_TypesOutput Get_Loan_Investor_Types(Get_Loan_Investor_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Loan_Investor_TypesOutput> Get_Loan_Investor_TypesAsync(Get_Loan_Investor_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Loan_Referral_TypesOutput Get_Loan_Referral_Types(Get_Loan_Referral_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Loan_Referral_TypesOutput> Get_Loan_Referral_TypesAsync(Get_Loan_Referral_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Loan_Investor_TypeOutput Put_Loan_Investor_Type(Put_Loan_Investor_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Loan_Investor_TypeOutput> Put_Loan_Investor_TypeAsync(Put_Loan_Investor_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Loan_Referral_TypeOutput Put_Loan_Referral_Type(Put_Loan_Referral_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Loan_Referral_TypeOutput> Put_Loan_Referral_TypeAsync(Put_Loan_Referral_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Alternate_Account_Set_MappingOutput Put_Alternate_Account_Set_Mapping(Put_Alternate_Account_Set_MappingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Alternate_Account_Set_MappingOutput> Put_Alternate_Account_Set_MappingAsync(Put_Alternate_Account_Set_MappingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Alternate_Account_Set_MappingsOutput Get_Alternate_Account_Set_Mappings(Get_Alternate_Account_Set_MappingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Alternate_Account_Set_MappingsOutput> Get_Alternate_Account_Set_MappingsAsync(Get_Alternate_Account_Set_MappingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Third_Party_Calculated_Tax_InformationOutput Put_Third_Party_Calculated_Tax_Information(Put_Third_Party_Calculated_Tax_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Third_Party_Calculated_Tax_InformationOutput> Put_Third_Party_Calculated_Tax_InformationAsync(Put_Third_Party_Calculated_Tax_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Fringe_Rate_TableOutput Put_Fringe_Rate_Table(Put_Fringe_Rate_TableInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Fringe_Rate_TableOutput> Put_Fringe_Rate_TableAsync(Put_Fringe_Rate_TableInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Budget_Fringe_Rate_TablesOutput Get_Budget_Fringe_Rate_Tables(Get_Budget_Fringe_Rate_TablesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Budget_Fringe_Rate_TablesOutput> Get_Budget_Fringe_Rate_TablesAsync(Get_Budget_Fringe_Rate_TablesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Escheatment_ItemsOutput Get_Escheatment_Items(Get_Escheatment_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Escheatment_ItemsOutput> Get_Escheatment_ItemsAsync(Get_Escheatment_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Escheatment_ItemsOutput Submit_Escheatment_Items(Submit_Escheatment_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Escheatment_ItemsOutput> Submit_Escheatment_ItemsAsync(Submit_Escheatment_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Gift_Secured_AttachmentOutput Put_Gift_Secured_Attachment(Put_Gift_Secured_AttachmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Gift_Secured_AttachmentOutput> Put_Gift_Secured_AttachmentAsync(Put_Gift_Secured_AttachmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Related_Worktags_for_WorktagsOutput Get_Related_Worktags_for_Worktags(Get_Related_Worktags_for_WorktagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Related_Worktags_for_WorktagsOutput> Get_Related_Worktags_for_WorktagsAsync(Get_Related_Worktags_for_WorktagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Related_Worktags_for_WorktagOutput Put_Related_Worktags_for_Worktag(Put_Related_Worktags_for_WorktagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Related_Worktags_for_WorktagOutput> Put_Related_Worktags_for_WorktagAsync(Put_Related_Worktags_for_WorktagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Integration_Worktag_Mapping_Source_SystemsOutput Get_Integration_Worktag_Mapping_Source_Systems(Get_Integration_Worktag_Mapping_Source_SystemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Integration_Worktag_Mapping_Source_SystemsOutput> Get_Integration_Worktag_Mapping_Source_SystemsAsync(Get_Integration_Worktag_Mapping_Source_SystemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_Worktag_Mapping_Source_SystemOutput Put_Integration_Worktag_Mapping_Source_System(Put_Integration_Worktag_Mapping_Source_SystemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_Worktag_Mapping_Source_SystemOutput> Put_Integration_Worktag_Mapping_Source_SystemAsync(Put_Integration_Worktag_Mapping_Source_SystemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Integration_Worktag_MappingsOutput Get_Integration_Worktag_Mappings(Get_Integration_Worktag_MappingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Integration_Worktag_MappingsOutput> Get_Integration_Worktag_MappingsAsync(Get_Integration_Worktag_MappingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_Worktag_MappingOutput Put_Integration_Worktag_Mapping(Put_Integration_Worktag_MappingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_Worktag_MappingOutput> Put_Integration_Worktag_MappingAsync(Put_Integration_Worktag_MappingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Escheatable_Payment_Notification_DateOutput Put_Escheatable_Payment_Notification_Date(Put_Escheatable_Payment_Notification_DateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Escheatable_Payment_Notification_DateOutput> Put_Escheatable_Payment_Notification_DateAsync(Put_Escheatable_Payment_Notification_DateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Spend_RestrictionOutput Put_Spend_Restriction(Put_Spend_RestrictionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Spend_RestrictionOutput> Put_Spend_RestrictionAsync(Put_Spend_RestrictionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Spend_RestrictionsOutput Get_Spend_Restrictions(Get_Spend_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Spend_RestrictionsOutput> Get_Spend_RestrictionsAsync(Get_Spend_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Transaction_Tax_StatusesOutput Get_Transaction_Tax_Statuses(Get_Transaction_Tax_StatusesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Transaction_Tax_StatusesOutput> Get_Transaction_Tax_StatusesAsync(Get_Transaction_Tax_StatusesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Transaction_Tax_StatusOutput Put_Transaction_Tax_Status(Put_Transaction_Tax_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Transaction_Tax_StatusOutput> Put_Transaction_Tax_StatusAsync(Put_Transaction_Tax_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Withholding_Tax_StatusOutput Put_Withholding_Tax_Status(Put_Withholding_Tax_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Withholding_Tax_StatusOutput> Put_Withholding_Tax_StatusAsync(Put_Withholding_Tax_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Withholding_Tax_StatusOutput Get_Withholding_Tax_Status(Get_Withholding_Tax_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Withholding_Tax_StatusOutput> Get_Withholding_Tax_StatusAsync(Get_Withholding_Tax_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Withholding_Tax_RatesOutput Get_Withholding_Tax_Rates(Get_Withholding_Tax_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Withholding_Tax_RatesOutput> Get_Withholding_Tax_RatesAsync(Get_Withholding_Tax_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Withholding_Tax_RateOutput Put_Withholding_Tax_Rate(Put_Withholding_Tax_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Withholding_Tax_RateOutput> Put_Withholding_Tax_RateAsync(Put_Withholding_Tax_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Suspense_Account_RulesOutput Get_Suspense_Account_Rules(Get_Suspense_Account_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Suspense_Account_RulesOutput> Get_Suspense_Account_RulesAsync(Get_Suspense_Account_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Suspense_Account_RuleOutput Put_Suspense_Account_Rule(Put_Suspense_Account_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Suspense_Account_RuleOutput> Put_Suspense_Account_RuleAsync(Put_Suspense_Account_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Headcount_PlanOutput Get_Headcount_Plan(Get_Headcount_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Headcount_PlanOutput> Get_Headcount_PlanAsync(Get_Headcount_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Transaction_Tax_Item_GroupsOutput Get_Transaction_Tax_Item_Groups(Get_Transaction_Tax_Item_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Transaction_Tax_Item_GroupsOutput> Get_Transaction_Tax_Item_GroupsAsync(Get_Transaction_Tax_Item_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Transaction_Tax_Item_GroupOutput Put_Transaction_Tax_Item_Group(Put_Transaction_Tax_Item_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Transaction_Tax_Item_GroupOutput> Put_Transaction_Tax_Item_GroupAsync(Put_Transaction_Tax_Item_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Withholding_Tax_Item_GroupsOutput Get_Withholding_Tax_Item_Groups(Get_Withholding_Tax_Item_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Withholding_Tax_Item_GroupsOutput> Get_Withholding_Tax_Item_GroupsAsync(Get_Withholding_Tax_Item_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Withholding_Tax_Item_GroupOutput Put_Withholding_Tax_Item_Group(Put_Withholding_Tax_Item_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Withholding_Tax_Item_GroupOutput> Put_Withholding_Tax_Item_GroupAsync(Put_Withholding_Tax_Item_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Default_Values_for_WorktagsOutput Get_Default_Values_for_Worktags(Get_Default_Values_for_WorktagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Default_Values_for_WorktagsOutput> Get_Default_Values_for_WorktagsAsync(Get_Default_Values_for_WorktagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Default_Values_for_WorktagOutput Put_Default_Values_for_Worktag(Put_Default_Values_for_WorktagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Default_Values_for_WorktagOutput> Put_Default_Values_for_WorktagAsync(Put_Default_Values_for_WorktagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_VAT_GroupsOutput Get_VAT_Groups(Get_VAT_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_VAT_GroupsOutput> Get_VAT_GroupsAsync(Get_VAT_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_VAT_GroupOutput Put_VAT_Group(Put_VAT_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_VAT_GroupOutput> Put_VAT_GroupAsync(Put_VAT_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Withholding_Tax_CodesOutput Get_Withholding_Tax_Codes(Get_Withholding_Tax_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Withholding_Tax_CodesOutput> Get_Withholding_Tax_CodesAsync(Get_Withholding_Tax_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Withholding_Tax_CodeOutput Put_Withholding_Tax_Code(Put_Withholding_Tax_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Withholding_Tax_CodeOutput> Put_Withholding_Tax_CodeAsync(Put_Withholding_Tax_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_Rule_Exception_GroupsOutput Get_Tax_Rule_Exception_Groups(Get_Tax_Rule_Exception_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_Rule_Exception_GroupsOutput> Get_Tax_Rule_Exception_GroupsAsync(Get_Tax_Rule_Exception_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_Rule_Exception_GroupOutput Put_Tax_Rule_Exception_Group(Put_Tax_Rule_Exception_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_Rule_Exception_GroupOutput> Put_Tax_Rule_Exception_GroupAsync(Put_Tax_Rule_Exception_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Default_Funding_SourcesOutput Get_Default_Funding_Sources(Get_Default_Funding_SourcesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Default_Funding_SourcesOutput> Get_Default_Funding_SourcesAsync(Get_Default_Funding_SourcesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Default_Funding_SourceOutput Put_Default_Funding_Source(Put_Default_Funding_SourceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Default_Funding_SourceOutput> Put_Default_Funding_SourceAsync(Put_Default_Funding_SourceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Funding_Source_RulesOutput Get_Funding_Source_Rules(Get_Funding_Source_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Funding_Source_RulesOutput> Get_Funding_Source_RulesAsync(Get_Funding_Source_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Funding_Source_RuleOutput Put_Funding_Source_Rule(Put_Funding_Source_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Funding_Source_RuleOutput> Put_Funding_Source_RuleAsync(Put_Funding_Source_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Revaluation_RunOutput Submit_Revaluation_Run(Submit_Revaluation_RunInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Revaluation_RunOutput> Submit_Revaluation_RunAsync(Submit_Revaluation_RunInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Accounting_Journal(Import_Accounting_JournalInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_Accounting_JournalAsync(Import_Accounting_JournalInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Budget_Amendment(Import_Budget_AmendmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_Budget_AmendmentAsync(Import_Budget_AmendmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Position_Budget(Import_Position_BudgetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_Position_BudgetAsync(Import_Position_BudgetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Budget(Import_BudgetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_BudgetAsync(Import_BudgetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Statistic(Import_StatisticInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_StatisticAsync(Import_StatisticInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Headcount_Plan(Import_Headcount_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_Headcount_PlanAsync(Import_Headcount_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Accounting_JournalOutput Import_Currency_Conversion_Rates(Import_Currency_Conversion_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Accounting_JournalOutput> Import_Currency_Conversion_RatesAsync(Import_Currency_Conversion_RatesInput request);
	}
}
