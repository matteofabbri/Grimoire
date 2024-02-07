using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Financial_AidPortClient : ClientBase<Financial_AidPort>, Financial_AidPort
	{
		public Financial_AidPortClient()
		{
		}

		public Financial_AidPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Financial_AidPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Financial_AidPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Financial_AidPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ISIR_TransactionsOutput Financial_AidPort.Get_ISIR_Transactions(Get_ISIR_TransactionsInput request)
		{
			return base.Channel.Get_ISIR_Transactions(request);
		}

		public Get_ISIR_Transactions_ResponseType Get_ISIR_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_ISIR_Transactions_RequestType Get_ISIR_Transactions_Request)
		{
			return ((Financial_AidPort)this).Get_ISIR_Transactions(new Get_ISIR_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ISIR_Transactions_Request = Get_ISIR_Transactions_Request
			}).Get_ISIR_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ISIR_TransactionsOutput> Financial_AidPort.Get_ISIR_TransactionsAsync(Get_ISIR_TransactionsInput request)
		{
			return base.Channel.Get_ISIR_TransactionsAsync(request);
		}

		public Task<Get_ISIR_TransactionsOutput> Get_ISIR_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_ISIR_Transactions_RequestType Get_ISIR_Transactions_Request)
		{
			return ((Financial_AidPort)this).Get_ISIR_TransactionsAsync(new Get_ISIR_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ISIR_Transactions_Request = Get_ISIR_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ISIR_TransactionOutput Financial_AidPort.Put_ISIR_Transaction(Put_ISIR_TransactionInput request)
		{
			return base.Channel.Put_ISIR_Transaction(request);
		}

		public Put_ISIR_Transaction_ResponseType Put_ISIR_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_ISIR_Transaction_RequestType Put_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Put_ISIR_Transaction(new Put_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_ISIR_Transaction_Request = Put_ISIR_Transaction_Request
			}).Put_ISIR_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ISIR_TransactionOutput> Financial_AidPort.Put_ISIR_TransactionAsync(Put_ISIR_TransactionInput request)
		{
			return base.Channel.Put_ISIR_TransactionAsync(request);
		}

		public Task<Put_ISIR_TransactionOutput> Put_ISIR_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_ISIR_Transaction_RequestType Put_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Put_ISIR_TransactionAsync(new Put_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_ISIR_Transaction_Request = Put_ISIR_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Award_ItemsOutput Financial_AidPort.Get_Student_Award_Items(Get_Student_Award_ItemsInput request)
		{
			return base.Channel.Get_Student_Award_Items(request);
		}

		public Get_Student_Award_Items_ResponseType Get_Student_Award_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Award_Items_RequestType Get_Student_Award_Items_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Award_Items(new Get_Student_Award_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Award_Items_Request = Get_Student_Award_Items_Request
			}).Get_Student_Award_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Award_ItemsOutput> Financial_AidPort.Get_Student_Award_ItemsAsync(Get_Student_Award_ItemsInput request)
		{
			return base.Channel.Get_Student_Award_ItemsAsync(request);
		}

		public Task<Get_Student_Award_ItemsOutput> Get_Student_Award_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Award_Items_RequestType Get_Student_Award_Items_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Award_ItemsAsync(new Get_Student_Award_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Award_Items_Request = Get_Student_Award_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Award_ItemOutput Financial_AidPort.Put_Student_Award_Item(Put_Student_Award_ItemInput request)
		{
			return base.Channel.Put_Student_Award_Item(request);
		}

		public Put_Student_Award_Item_ResponseType Put_Student_Award_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Award_Item_RequestType Put_Student_Award_Item_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Award_Item(new Put_Student_Award_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Award_Item_Request = Put_Student_Award_Item_Request
			}).Put_Student_Award_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Award_ItemOutput> Financial_AidPort.Put_Student_Award_ItemAsync(Put_Student_Award_ItemInput request)
		{
			return base.Channel.Put_Student_Award_ItemAsync(request);
		}

		public Task<Put_Student_Award_ItemOutput> Put_Student_Award_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Award_Item_RequestType Put_Student_Award_Item_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Award_ItemAsync(new Put_Student_Award_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Award_Item_Request = Put_Student_Award_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Anticipated_DisbursementsOutput Financial_AidPort.Get_Student_Anticipated_Disbursements(Get_Student_Anticipated_DisbursementsInput request)
		{
			return base.Channel.Get_Student_Anticipated_Disbursements(request);
		}

		public Get_Student_Anticipated_Disbursements_ResponseType Get_Student_Anticipated_Disbursements(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Anticipated_Disbursements_RequestType Get_Student_Anticipated_Disbursements_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Anticipated_Disbursements(new Get_Student_Anticipated_DisbursementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Anticipated_Disbursements_Request = Get_Student_Anticipated_Disbursements_Request
			}).Get_Student_Anticipated_Disbursements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Anticipated_DisbursementsOutput> Financial_AidPort.Get_Student_Anticipated_DisbursementsAsync(Get_Student_Anticipated_DisbursementsInput request)
		{
			return base.Channel.Get_Student_Anticipated_DisbursementsAsync(request);
		}

		public Task<Get_Student_Anticipated_DisbursementsOutput> Get_Student_Anticipated_DisbursementsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Anticipated_Disbursements_RequestType Get_Student_Anticipated_Disbursements_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Anticipated_DisbursementsAsync(new Get_Student_Anticipated_DisbursementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Anticipated_Disbursements_Request = Get_Student_Anticipated_Disbursements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Anticipated_DisbursementOutput Financial_AidPort.Put_Student_Anticipated_Disbursement(Put_Student_Anticipated_DisbursementInput request)
		{
			return base.Channel.Put_Student_Anticipated_Disbursement(request);
		}

		public Put_Student_Anticipated_Disbursement_ResponseType Put_Student_Anticipated_Disbursement(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Anticipated_Disbursement_RequestType Put_Student_Anticipated_Disbursement_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Anticipated_Disbursement(new Put_Student_Anticipated_DisbursementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Anticipated_Disbursement_Request = Put_Student_Anticipated_Disbursement_Request
			}).Put_Student_Anticipated_Disbursement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Anticipated_DisbursementOutput> Financial_AidPort.Put_Student_Anticipated_DisbursementAsync(Put_Student_Anticipated_DisbursementInput request)
		{
			return base.Channel.Put_Student_Anticipated_DisbursementAsync(request);
		}

		public Task<Put_Student_Anticipated_DisbursementOutput> Put_Student_Anticipated_DisbursementAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Anticipated_Disbursement_RequestType Put_Student_Anticipated_Disbursement_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Anticipated_DisbursementAsync(new Put_Student_Anticipated_DisbursementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Anticipated_Disbursement_Request = Put_Student_Anticipated_Disbursement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Preliminary_AwardsOutput Financial_AidPort.Get_Student_Preliminary_Awards(Get_Student_Preliminary_AwardsInput request)
		{
			return base.Channel.Get_Student_Preliminary_Awards(request);
		}

		public Get_Student_Preliminary_Awards_ResponseType Get_Student_Preliminary_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Preliminary_Awards_RequestType Get_Student_Preliminary_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Preliminary_Awards(new Get_Student_Preliminary_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Preliminary_Awards_Request = Get_Student_Preliminary_Awards_Request
			}).Get_Student_Preliminary_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Preliminary_AwardsOutput> Financial_AidPort.Get_Student_Preliminary_AwardsAsync(Get_Student_Preliminary_AwardsInput request)
		{
			return base.Channel.Get_Student_Preliminary_AwardsAsync(request);
		}

		public Task<Get_Student_Preliminary_AwardsOutput> Get_Student_Preliminary_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Preliminary_Awards_RequestType Get_Student_Preliminary_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Preliminary_AwardsAsync(new Get_Student_Preliminary_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Preliminary_Awards_Request = Get_Student_Preliminary_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Preliminary_AwardOutput Financial_AidPort.Put_Student_Preliminary_Award(Put_Student_Preliminary_AwardInput request)
		{
			return base.Channel.Put_Student_Preliminary_Award(request);
		}

		public Put_Student_Preliminary_Award_ResponseType Put_Student_Preliminary_Award(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Preliminary_Award_RequestType Put_Student_Preliminary_Award_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Preliminary_Award(new Put_Student_Preliminary_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Preliminary_Award_Request = Put_Student_Preliminary_Award_Request
			}).Put_Student_Preliminary_Award_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Preliminary_AwardOutput> Financial_AidPort.Put_Student_Preliminary_AwardAsync(Put_Student_Preliminary_AwardInput request)
		{
			return base.Channel.Put_Student_Preliminary_AwardAsync(request);
		}

		public Task<Put_Student_Preliminary_AwardOutput> Put_Student_Preliminary_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Preliminary_Award_RequestType Put_Student_Preliminary_Award_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Preliminary_AwardAsync(new Put_Student_Preliminary_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Preliminary_Award_Request = Put_Student_Preliminary_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Status_for_ISIR_TransactionOutput Financial_AidPort.Put_Status_for_ISIR_Transaction(Put_Status_for_ISIR_TransactionInput request)
		{
			return base.Channel.Put_Status_for_ISIR_Transaction(request);
		}

		public Put_Status_for_ISIR_Transaction_ResponseType Put_Status_for_ISIR_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Status_for_ISIR_Transaction_RequestType Put_Status_for_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Put_Status_for_ISIR_Transaction(new Put_Status_for_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Status_for_ISIR_Transaction_Request = Put_Status_for_ISIR_Transaction_Request
			}).Put_Status_for_ISIR_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Status_for_ISIR_TransactionOutput> Financial_AidPort.Put_Status_for_ISIR_TransactionAsync(Put_Status_for_ISIR_TransactionInput request)
		{
			return base.Channel.Put_Status_for_ISIR_TransactionAsync(request);
		}

		public Task<Put_Status_for_ISIR_TransactionOutput> Put_Status_for_ISIR_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Status_for_ISIR_Transaction_RequestType Put_Status_for_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Put_Status_for_ISIR_TransactionAsync(new Put_Status_for_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Status_for_ISIR_Transaction_Request = Put_Status_for_ISIR_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Financial_Aid_PackagesOutput Financial_AidPort.Get_Financial_Aid_Packages(Get_Financial_Aid_PackagesInput request)
		{
			return base.Channel.Get_Financial_Aid_Packages(request);
		}

		public Get_Financial_Aid_Packages_ResponseType Get_Financial_Aid_Packages(Workday_Common_HeaderType Workday_Common_Header, Get_Financial_Aid_Packages_RequestType Get_Financial_Aid_Packages_Request)
		{
			return ((Financial_AidPort)this).Get_Financial_Aid_Packages(new Get_Financial_Aid_PackagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Financial_Aid_Packages_Request = Get_Financial_Aid_Packages_Request
			}).Get_Financial_Aid_Packages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Financial_Aid_PackagesOutput> Financial_AidPort.Get_Financial_Aid_PackagesAsync(Get_Financial_Aid_PackagesInput request)
		{
			return base.Channel.Get_Financial_Aid_PackagesAsync(request);
		}

		public Task<Get_Financial_Aid_PackagesOutput> Get_Financial_Aid_PackagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Financial_Aid_Packages_RequestType Get_Financial_Aid_Packages_Request)
		{
			return ((Financial_AidPort)this).Get_Financial_Aid_PackagesAsync(new Get_Financial_Aid_PackagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Financial_Aid_Packages_Request = Get_Financial_Aid_Packages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Aggregate_AwardsOutput Financial_AidPort.Get_Student_Aggregate_Awards(Get_Student_Aggregate_AwardsInput request)
		{
			return base.Channel.Get_Student_Aggregate_Awards(request);
		}

		public Get_Student_Aggregate_Awards_ResponseType Get_Student_Aggregate_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Aggregate_Awards_RequestType Get_Student_Aggregate_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Aggregate_Awards(new Get_Student_Aggregate_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Aggregate_Awards_Request = Get_Student_Aggregate_Awards_Request
			}).Get_Student_Aggregate_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Aggregate_AwardsOutput> Financial_AidPort.Get_Student_Aggregate_AwardsAsync(Get_Student_Aggregate_AwardsInput request)
		{
			return base.Channel.Get_Student_Aggregate_AwardsAsync(request);
		}

		public Task<Get_Student_Aggregate_AwardsOutput> Get_Student_Aggregate_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Aggregate_Awards_RequestType Get_Student_Aggregate_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Aggregate_AwardsAsync(new Get_Student_Aggregate_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Aggregate_Awards_Request = Get_Student_Aggregate_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Manual_AwardsOutput Financial_AidPort.Get_Student_Manual_Awards(Get_Student_Manual_AwardsInput request)
		{
			return base.Channel.Get_Student_Manual_Awards(request);
		}

		public Get_Student_Manual_Awards_ResponseType Get_Student_Manual_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Manual_Awards_RequestType Get_Student_Manual_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Manual_Awards(new Get_Student_Manual_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Manual_Awards_Request = Get_Student_Manual_Awards_Request
			}).Get_Student_Manual_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Manual_AwardsOutput> Financial_AidPort.Get_Student_Manual_AwardsAsync(Get_Student_Manual_AwardsInput request)
		{
			return base.Channel.Get_Student_Manual_AwardsAsync(request);
		}

		public Task<Get_Student_Manual_AwardsOutput> Get_Student_Manual_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Manual_Awards_RequestType Get_Student_Manual_Awards_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Manual_AwardsAsync(new Get_Student_Manual_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Manual_Awards_Request = Get_Student_Manual_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Sponsor_ContractsOutput Financial_AidPort.Get_Student_Sponsor_Contracts(Get_Student_Sponsor_ContractsInput request)
		{
			return base.Channel.Get_Student_Sponsor_Contracts(request);
		}

		public Get_Student_Sponsor_Contracts_ResponseType Get_Student_Sponsor_Contracts(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Sponsor_Contracts_RequestType Get_Student_Sponsor_Contracts_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Sponsor_Contracts(new Get_Student_Sponsor_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Sponsor_Contracts_Request = Get_Student_Sponsor_Contracts_Request
			}).Get_Student_Sponsor_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Sponsor_ContractsOutput> Financial_AidPort.Get_Student_Sponsor_ContractsAsync(Get_Student_Sponsor_ContractsInput request)
		{
			return base.Channel.Get_Student_Sponsor_ContractsAsync(request);
		}

		public Task<Get_Student_Sponsor_ContractsOutput> Get_Student_Sponsor_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Sponsor_Contracts_RequestType Get_Student_Sponsor_Contracts_Request)
		{
			return ((Financial_AidPort)this).Get_Student_Sponsor_ContractsAsync(new Get_Student_Sponsor_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Sponsor_Contracts_Request = Get_Student_Sponsor_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Sponsor_ContractOutput Financial_AidPort.Put_Student_Sponsor_Contract(Put_Student_Sponsor_ContractInput request)
		{
			return base.Channel.Put_Student_Sponsor_Contract(request);
		}

		public Put_Student_Sponsor_Contract_ResponseType Put_Student_Sponsor_Contract(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Sponsor_Contract_RequestType Put_Student_Sponsor_Contract_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Sponsor_Contract(new Put_Student_Sponsor_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Sponsor_Contract_Request = Put_Student_Sponsor_Contract_Request
			}).Put_Student_Sponsor_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Sponsor_ContractOutput> Financial_AidPort.Put_Student_Sponsor_ContractAsync(Put_Student_Sponsor_ContractInput request)
		{
			return base.Channel.Put_Student_Sponsor_ContractAsync(request);
		}

		public Task<Put_Student_Sponsor_ContractOutput> Put_Student_Sponsor_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Sponsor_Contract_RequestType Put_Student_Sponsor_Contract_Request)
		{
			return ((Financial_AidPort)this).Put_Student_Sponsor_ContractAsync(new Put_Student_Sponsor_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Sponsor_Contract_Request = Put_Student_Sponsor_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_ISIR_Transaction(Import_ISIR_TransactionInput request)
		{
			return base.Channel.Import_ISIR_Transaction(request);
		}

		public Put_Import_Process_ResponseType Import_ISIR_Transaction(Workday_Common_HeaderType Workday_Common_Header, Import_ISIR_Transaction_RequestType Import_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Import_ISIR_Transaction(new Import_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ISIR_Transaction_Request = Import_ISIR_Transaction_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_ISIR_TransactionAsync(Import_ISIR_TransactionInput request)
		{
			return base.Channel.Import_ISIR_TransactionAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_ISIR_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Import_ISIR_Transaction_RequestType Import_ISIR_Transaction_Request)
		{
			return ((Financial_AidPort)this).Import_ISIR_TransactionAsync(new Import_ISIR_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ISIR_Transaction_Request = Import_ISIR_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_Status_for_ISIR_Transactions(Import_Status_for_ISIR_TransactionsInput request)
		{
			return base.Channel.Import_Status_for_ISIR_Transactions(request);
		}

		public Put_Import_Process_ResponseType Import_Status_for_ISIR_Transactions(Workday_Common_HeaderType Workday_Common_Header, Import_Status_for_ISIR_Transactions_RequestType Import_Status_for_ISIR_Transactions_Request)
		{
			return ((Financial_AidPort)this).Import_Status_for_ISIR_Transactions(new Import_Status_for_ISIR_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Status_for_ISIR_Transactions_Request = Import_Status_for_ISIR_Transactions_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_Status_for_ISIR_TransactionsAsync(Import_Status_for_ISIR_TransactionsInput request)
		{
			return base.Channel.Import_Status_for_ISIR_TransactionsAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_Status_for_ISIR_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Status_for_ISIR_Transactions_RequestType Import_Status_for_ISIR_Transactions_Request)
		{
			return ((Financial_AidPort)this).Import_Status_for_ISIR_TransactionsAsync(new Import_Status_for_ISIR_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Status_for_ISIR_Transactions_Request = Import_Status_for_ISIR_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_Financial_Aid_Packages(Import_Financial_Aid_PackagesInput request)
		{
			return base.Channel.Import_Financial_Aid_Packages(request);
		}

		public Put_Import_Process_ResponseType Import_Financial_Aid_Packages(Workday_Common_HeaderType Workday_Common_Header, Import_Financial_Aid_Package_RequestType Import_Financial_Aid_Package_Request)
		{
			return ((Financial_AidPort)this).Import_Financial_Aid_Packages(new Import_Financial_Aid_PackagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Financial_Aid_Package_Request = Import_Financial_Aid_Package_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_Financial_Aid_PackagesAsync(Import_Financial_Aid_PackagesInput request)
		{
			return base.Channel.Import_Financial_Aid_PackagesAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_Financial_Aid_PackagesAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Financial_Aid_Package_RequestType Import_Financial_Aid_Package_Request)
		{
			return ((Financial_AidPort)this).Import_Financial_Aid_PackagesAsync(new Import_Financial_Aid_PackagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Financial_Aid_Package_Request = Import_Financial_Aid_Package_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_NSLDS_Transactions(Import_NSLDS_TransactionsInput request)
		{
			return base.Channel.Import_NSLDS_Transactions(request);
		}

		public Put_Import_Process_ResponseType Import_NSLDS_Transactions(Workday_Common_HeaderType Workday_Common_Header, Import_NSLDS_Transaction_RequestType Import_NSLDS_Transaction_Request)
		{
			return ((Financial_AidPort)this).Import_NSLDS_Transactions(new Import_NSLDS_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_NSLDS_Transaction_Request = Import_NSLDS_Transaction_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_NSLDS_TransactionsAsync(Import_NSLDS_TransactionsInput request)
		{
			return base.Channel.Import_NSLDS_TransactionsAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_NSLDS_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_NSLDS_Transaction_RequestType Import_NSLDS_Transaction_Request)
		{
			return ((Financial_AidPort)this).Import_NSLDS_TransactionsAsync(new Import_NSLDS_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_NSLDS_Transaction_Request = Import_NSLDS_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_Student_Aggregate_Awards(Import_Student_Aggregate_AwardsInput request)
		{
			return base.Channel.Import_Student_Aggregate_Awards(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Aggregate_Awards(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Aggregate_Award_RequestType Import_Student_Aggregate_Award_Request)
		{
			return ((Financial_AidPort)this).Import_Student_Aggregate_Awards(new Import_Student_Aggregate_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Aggregate_Award_Request = Import_Student_Aggregate_Award_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_Student_Aggregate_AwardsAsync(Import_Student_Aggregate_AwardsInput request)
		{
			return base.Channel.Import_Student_Aggregate_AwardsAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_Student_Aggregate_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Aggregate_Award_RequestType Import_Student_Aggregate_Award_Request)
		{
			return ((Financial_AidPort)this).Import_Student_Aggregate_AwardsAsync(new Import_Student_Aggregate_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Aggregate_Award_Request = Import_Student_Aggregate_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_ISIR_TransactionOutput Financial_AidPort.Import_Student_Manual_Award(Import_Student_Manual_AwardInput request)
		{
			return base.Channel.Import_Student_Manual_Award(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Manual_Award(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Manual_Award_RequestType Import_Student_Manual_Award_Request)
		{
			return ((Financial_AidPort)this).Import_Student_Manual_Award(new Import_Student_Manual_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Manual_Award_Request = Import_Student_Manual_Award_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_ISIR_TransactionOutput> Financial_AidPort.Import_Student_Manual_AwardAsync(Import_Student_Manual_AwardInput request)
		{
			return base.Channel.Import_Student_Manual_AwardAsync(request);
		}

		public Task<Import_ISIR_TransactionOutput> Import_Student_Manual_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Manual_Award_RequestType Import_Student_Manual_Award_Request)
		{
			return ((Financial_AidPort)this).Import_Student_Manual_AwardAsync(new Import_Student_Manual_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Manual_Award_Request = Import_Student_Manual_Award_Request
			});
		}
	}
}
