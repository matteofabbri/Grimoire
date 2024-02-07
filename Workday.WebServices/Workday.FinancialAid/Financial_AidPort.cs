using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Financial_Aid", ConfigurationName = "Financial_AidService.Financial_AidPort")]
	public interface Financial_AidPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ISIR_TransactionsOutput Get_ISIR_Transactions(Get_ISIR_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ISIR_TransactionsOutput> Get_ISIR_TransactionsAsync(Get_ISIR_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ISIR_TransactionOutput Put_ISIR_Transaction(Put_ISIR_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ISIR_TransactionOutput> Put_ISIR_TransactionAsync(Put_ISIR_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Award_ItemsOutput Get_Student_Award_Items(Get_Student_Award_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Award_ItemsOutput> Get_Student_Award_ItemsAsync(Get_Student_Award_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Award_ItemOutput Put_Student_Award_Item(Put_Student_Award_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Award_ItemOutput> Put_Student_Award_ItemAsync(Put_Student_Award_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Anticipated_DisbursementsOutput Get_Student_Anticipated_Disbursements(Get_Student_Anticipated_DisbursementsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Anticipated_DisbursementsOutput> Get_Student_Anticipated_DisbursementsAsync(Get_Student_Anticipated_DisbursementsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Anticipated_DisbursementOutput Put_Student_Anticipated_Disbursement(Put_Student_Anticipated_DisbursementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Anticipated_DisbursementOutput> Put_Student_Anticipated_DisbursementAsync(Put_Student_Anticipated_DisbursementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Preliminary_AwardsOutput Get_Student_Preliminary_Awards(Get_Student_Preliminary_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Preliminary_AwardsOutput> Get_Student_Preliminary_AwardsAsync(Get_Student_Preliminary_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Preliminary_AwardOutput Put_Student_Preliminary_Award(Put_Student_Preliminary_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Preliminary_AwardOutput> Put_Student_Preliminary_AwardAsync(Put_Student_Preliminary_AwardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Status_for_ISIR_TransactionOutput Put_Status_for_ISIR_Transaction(Put_Status_for_ISIR_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Status_for_ISIR_TransactionOutput> Put_Status_for_ISIR_TransactionAsync(Put_Status_for_ISIR_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Financial_Aid_PackagesOutput Get_Financial_Aid_Packages(Get_Financial_Aid_PackagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Financial_Aid_PackagesOutput> Get_Financial_Aid_PackagesAsync(Get_Financial_Aid_PackagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Aggregate_AwardsOutput Get_Student_Aggregate_Awards(Get_Student_Aggregate_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Aggregate_AwardsOutput> Get_Student_Aggregate_AwardsAsync(Get_Student_Aggregate_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Manual_AwardsOutput Get_Student_Manual_Awards(Get_Student_Manual_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Manual_AwardsOutput> Get_Student_Manual_AwardsAsync(Get_Student_Manual_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Sponsor_ContractsOutput Get_Student_Sponsor_Contracts(Get_Student_Sponsor_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Sponsor_ContractsOutput> Get_Student_Sponsor_ContractsAsync(Get_Student_Sponsor_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Sponsor_ContractOutput Put_Student_Sponsor_Contract(Put_Student_Sponsor_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Sponsor_ContractOutput> Put_Student_Sponsor_ContractAsync(Put_Student_Sponsor_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_ISIR_Transaction(Import_ISIR_TransactionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_ISIR_TransactionAsync(Import_ISIR_TransactionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_Status_for_ISIR_Transactions(Import_Status_for_ISIR_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_Status_for_ISIR_TransactionsAsync(Import_Status_for_ISIR_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_Financial_Aid_Packages(Import_Financial_Aid_PackagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_Financial_Aid_PackagesAsync(Import_Financial_Aid_PackagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_NSLDS_Transactions(Import_NSLDS_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_NSLDS_TransactionsAsync(Import_NSLDS_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_Student_Aggregate_Awards(Import_Student_Aggregate_AwardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_Student_Aggregate_AwardsAsync(Import_Student_Aggregate_AwardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_ISIR_TransactionOutput Import_Student_Manual_Award(Import_Student_Manual_AwardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_ISIR_TransactionOutput> Import_Student_Manual_AwardAsync(Import_Student_Manual_AwardInput request);
	}
}
