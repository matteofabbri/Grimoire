using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Cash_Management", ConfigurationName = "Cash_ManagementService.Cash_ManagementPort")]
	public interface Cash_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Ad_Hoc_Bank_TransactionOutput Submit_Ad_Hoc_Bank_Transaction(Submit_Ad_Hoc_Bank_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Ad_Hoc_Bank_TransactionOutput> Submit_Ad_Hoc_Bank_TransactionAsync(Submit_Ad_Hoc_Bank_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_AccountsOutput Get_Bank_Accounts(Get_Bank_AccountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_AccountsOutput> Get_Bank_AccountsAsync(Get_Bank_AccountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Bank_AccountOutput Put_Bank_Account(Put_Bank_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Bank_AccountOutput> Put_Bank_AccountAsync(Put_Bank_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Financial_InstitutionsOutput Get_Financial_Institutions(Get_Financial_InstitutionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Financial_InstitutionsOutput> Get_Financial_InstitutionsAsync(Get_Financial_InstitutionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Financial_InstitutionOutput Put_Financial_Institution(Put_Financial_InstitutionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Financial_InstitutionOutput> Put_Financial_InstitutionAsync(Put_Financial_InstitutionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_BranchesOutput Get_Bank_Branches(Get_Bank_BranchesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_BranchesOutput> Get_Bank_BranchesAsync(Get_Bank_BranchesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Bank_BranchOutput Put_Bank_Branch(Put_Bank_BranchInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Bank_BranchOutput> Put_Bank_BranchAsync(Put_Bank_BranchInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Petty_Cash_AccountsOutput Get_Petty_Cash_Accounts(Get_Petty_Cash_AccountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Petty_Cash_AccountsOutput> Get_Petty_Cash_AccountsAsync(Get_Petty_Cash_AccountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Petty_Cash_AccountOutput Put_Petty_Cash_Account(Put_Petty_Cash_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Petty_Cash_AccountOutput> Put_Petty_Cash_AccountAsync(Put_Petty_Cash_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Ad_Hoc_Bank_TransactionOutput Cancel_Ad_Hoc_Bank_Transaction(Cancel_Ad_Hoc_Bank_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Ad_Hoc_Bank_TransactionOutput> Cancel_Ad_Hoc_Bank_TransactionAsync(Cancel_Ad_Hoc_Bank_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_Entity_ContactsOutput Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Business_Entity_ContactOutput Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_Election_EnrollmentsOutput Get_Payment_Election_Enrollments(Get_Payment_Election_EnrollmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_Election_EnrollmentsOutput> Get_Payment_Election_EnrollmentsAsync(Get_Payment_Election_EnrollmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Payment_Election_EnrollmentOutput Submit_Payment_Election_Enrollment(Submit_Payment_Election_EnrollmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Payment_Election_EnrollmentOutput> Submit_Payment_Election_EnrollmentAsync(Submit_Payment_Election_EnrollmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ad_Hoc_Bank_TransactionsOutput Get_Ad_Hoc_Bank_Transactions(Get_Ad_Hoc_Bank_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ad_Hoc_Bank_TransactionsOutput> Get_Ad_Hoc_Bank_TransactionsAsync(Get_Ad_Hoc_Bank_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_Acknowledgement_MessageOutput Put_Payment_Acknowledgement_Message(Put_Payment_Acknowledgement_MessageInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_Acknowledgement_MessageOutput> Put_Payment_Acknowledgement_MessageAsync(Put_Payment_Acknowledgement_MessageInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ad_Hoc_PaymentsOutput Get_Ad_Hoc_Payments(Get_Ad_Hoc_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ad_Hoc_PaymentsOutput> Get_Ad_Hoc_PaymentsAsync(Get_Ad_Hoc_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Ad_Hoc_PaymentOutput Submit_Ad_Hoc_Payment(Submit_Ad_Hoc_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Ad_Hoc_PaymentOutput> Submit_Ad_Hoc_PaymentAsync(Submit_Ad_Hoc_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Ad_Hoc_PaymentOutput Cancel_Ad_Hoc_Payment(Cancel_Ad_Hoc_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Ad_Hoc_PaymentOutput> Cancel_Ad_Hoc_PaymentAsync(Cancel_Ad_Hoc_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PaymentsOutput Get_Payments(Get_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PaymentsOutput> Get_PaymentsAsync(Get_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_MessagesOutput Get_Payment_Messages(Get_Payment_MessagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Get_Payment_MessagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payment_Election_OptionsOutput Get_Payment_Election_Options(Get_Payment_Election_OptionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payment_Election_OptionsOutput> Get_Payment_Election_OptionsAsync(Get_Payment_Election_OptionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payment_Election_OptionOutput Put_Payment_Election_Option(Put_Payment_Election_OptionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payment_Election_OptionOutput> Put_Payment_Election_OptionAsync(Put_Payment_Election_OptionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Bank_Statement_FileOutput Put_Bank_Statement_File(Put_Bank_Statement_FileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Bank_Statement_FileOutput> Put_Bank_Statement_FileAsync(Put_Bank_Statement_FileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Bank_StatementOutput Put_Bank_Statement(Put_Bank_StatementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Bank_StatementOutput> Put_Bank_StatementAsync(Put_Bank_StatementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_Statement_FilesOutput Get_Bank_Statement_Files(Get_Bank_Statement_FilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_Statement_FilesOutput> Get_Bank_Statement_FilesAsync(Get_Bank_Statement_FilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_StatementsOutput Get_Bank_Statements(Get_Bank_StatementsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_StatementsOutput> Get_Bank_StatementsAsync(Get_Bank_StatementsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_DonorsOutput Get_Donors(Get_DonorsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_DonorsOutput> Get_DonorsAsync(Get_DonorsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DonorOutput Put_Donor(Put_DonorInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DonorOutput> Put_DonorAsync(Put_DonorInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Donor_ContributionsOutput Get_Donor_Contributions(Get_Donor_ContributionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Donor_ContributionsOutput> Get_Donor_ContributionsAsync(Get_Donor_ContributionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Donor_ContributionOutput Submit_Donor_Contribution(Submit_Donor_ContributionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Donor_ContributionOutput> Submit_Donor_ContributionAsync(Submit_Donor_ContributionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Investment_StatementsOutput Get_Investment_Statements(Get_Investment_StatementsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Investment_StatementsOutput> Get_Investment_StatementsAsync(Get_Investment_StatementsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Investment_StatementOutput Submit_Investment_Statement(Submit_Investment_StatementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Investment_StatementOutput> Submit_Investment_StatementAsync(Submit_Investment_StatementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Investment_Pool_PurchasesOutput Get_Investment_Pool_Purchases(Get_Investment_Pool_PurchasesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Investment_Pool_PurchasesOutput> Get_Investment_Pool_PurchasesAsync(Get_Investment_Pool_PurchasesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Investment_Pool_PurchaseOutput Submit_Investment_Pool_Purchase(Submit_Investment_Pool_PurchaseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Investment_Pool_PurchaseOutput> Submit_Investment_Pool_PurchaseAsync(Submit_Investment_Pool_PurchaseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Investment_Pool_TransfersOutput Get_Investment_Pool_Transfers(Get_Investment_Pool_TransfersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Investment_Pool_TransfersOutput> Get_Investment_Pool_TransfersAsync(Get_Investment_Pool_TransfersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ad_Hoc_PayeesOutput Get_Ad_Hoc_Payees(Get_Ad_Hoc_PayeesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ad_Hoc_PayeesOutput> Get_Ad_Hoc_PayeesAsync(Get_Ad_Hoc_PayeesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Ad_Hoc_PayeeOutput Put_Ad_Hoc_Payee(Put_Ad_Hoc_PayeeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Ad_Hoc_PayeeOutput> Put_Ad_Hoc_PayeeAsync(Put_Ad_Hoc_PayeeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Investment_Pool_TransferOutput Submit_Investment_Pool_Transfer(Submit_Investment_Pool_TransferInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Investment_Pool_TransferOutput> Submit_Investment_Pool_TransferAsync(Submit_Investment_Pool_TransferInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Investment_Pool_SaleOutput Submit_Investment_Pool_Sale(Submit_Investment_Pool_SaleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Investment_Pool_SaleOutput> Submit_Investment_Pool_SaleAsync(Submit_Investment_Pool_SaleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Investment_Pool_SalesOutput Get_Investment_Pool_Sales(Get_Investment_Pool_SalesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Investment_Pool_SalesOutput> Get_Investment_Pool_SalesAsync(Get_Investment_Pool_SalesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Investment_Pool_AdjustmentOutput Submit_Investment_Pool_Adjustment(Submit_Investment_Pool_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Investment_Pool_AdjustmentOutput> Submit_Investment_Pool_AdjustmentAsync(Submit_Investment_Pool_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Investment_Pool_AdjustmentsOutput Get_Investment_Pool_Adjustments(Get_Investment_Pool_AdjustmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Investment_Pool_AdjustmentsOutput> Get_Investment_Pool_AdjustmentsAsync(Get_Investment_Pool_AdjustmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_Account_TransfersOutput Get_Bank_Account_Transfers(Get_Bank_Account_TransfersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_Account_TransfersOutput> Get_Bank_Account_TransfersAsync(Get_Bank_Account_TransfersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Bank_Account_TransferOutput Submit_Bank_Account_Transfer(Submit_Bank_Account_TransferInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Bank_Account_TransferOutput> Submit_Bank_Account_TransferAsync(Submit_Bank_Account_TransferInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Bank_Statement_Custom_Code_SetsOutput Get_Bank_Statement_Custom_Code_Sets(Get_Bank_Statement_Custom_Code_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Bank_Statement_Custom_Code_SetsOutput> Get_Bank_Statement_Custom_Code_SetsAsync(Get_Bank_Statement_Custom_Code_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Bank_Statement_Custom_Code_SetOutput Put_Bank_Statement_Custom_Code_Set(Put_Bank_Statement_Custom_Code_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Bank_Statement_Custom_Code_SetOutput> Put_Bank_Statement_Custom_Code_SetAsync(Put_Bank_Statement_Custom_Code_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Intraday_Bank_StatementsOutput Get_Intraday_Bank_Statements(Get_Intraday_Bank_StatementsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Intraday_Bank_StatementsOutput> Get_Intraday_Bank_StatementsAsync(Get_Intraday_Bank_StatementsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Investment_Pool_Catchup_Payout_CriteriaOutput Put_Investment_Pool_Catchup_Payout_Criteria(Put_Investment_Pool_Catchup_Payout_CriteriaInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Investment_Pool_Catchup_Payout_CriteriaOutput> Put_Investment_Pool_Catchup_Payout_CriteriaAsync(Put_Investment_Pool_Catchup_Payout_CriteriaInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Investment_Pool_TransactionOutput Cancel_Investment_Pool_Transaction(Cancel_Investment_Pool_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Investment_Pool_TransactionOutput> Cancel_Investment_Pool_TransactionAsync(Cancel_Investment_Pool_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Recalculate_Bank_Statement_BalanceOutput Recalculate_Bank_Statement_Balance(Recalculate_Bank_Statement_BalanceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Recalculate_Bank_Statement_BalanceOutput> Recalculate_Bank_Statement_BalanceAsync(Recalculate_Bank_Statement_BalanceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Donor_ContributionOutput Cancel_Donor_Contribution(Cancel_Donor_ContributionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Donor_ContributionOutput> Cancel_Donor_ContributionAsync(Cancel_Donor_ContributionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Bank_StatementOutput Import_Bank_Statement(Import_Bank_StatementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Bank_StatementOutput> Import_Bank_StatementAsync(Import_Bank_StatementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Bank_StatementOutput Import_Ad_hoc_Bank_Transaction(Import_Ad_hoc_Bank_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Bank_StatementOutput> Import_Ad_hoc_Bank_TransactionAsync(Import_Ad_hoc_Bank_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Bank_StatementOutput Import_Intraday_Bank_Statement(Import_Intraday_Bank_StatementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Bank_StatementOutput> Import_Intraday_Bank_StatementAsync(Import_Intraday_Bank_StatementInput request);
	}
}
