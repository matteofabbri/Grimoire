using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class StaffingPortClient : ClientBase<StaffingPort>, StaffingPort
	{
		public StaffingPortClient()
		{
		}

		public StaffingPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public StaffingPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StaffingPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public StaffingPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Terminate_EmployeeOutput StaffingPort.Terminate_Employee(Terminate_EmployeeInput request)
		{
			return base.Channel.Terminate_Employee(request);
		}

		public Terminate_Employee_Event_ResponseType Terminate_Employee(Workday_Common_HeaderType Workday_Common_Header, Terminate_Employee_RequestType Terminate_Employee_Request)
		{
			return ((StaffingPort)this).Terminate_Employee(new Terminate_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Terminate_Employee_Request = Terminate_Employee_Request
			}).Terminate_Employee_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Terminate_EmployeeOutput> StaffingPort.Terminate_EmployeeAsync(Terminate_EmployeeInput request)
		{
			return base.Channel.Terminate_EmployeeAsync(request);
		}

		public Task<Terminate_EmployeeOutput> Terminate_EmployeeAsync(Workday_Common_HeaderType Workday_Common_Header, Terminate_Employee_RequestType Terminate_Employee_Request)
		{
			return ((StaffingPort)this).Terminate_EmployeeAsync(new Terminate_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Terminate_Employee_Request = Terminate_Employee_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_WorkersOutput StaffingPort.Get_Workers(Get_WorkersInput request)
		{
			return base.Channel.Get_Workers(request);
		}

		public Get_Workers_ResponseRootType Get_Workers(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_RequestType Get_Workers_Request)
		{
			return ((StaffingPort)this).Get_Workers(new Get_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Request = Get_Workers_Request
			}).Get_Workers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_WorkersOutput> StaffingPort.Get_WorkersAsync(Get_WorkersInput request)
		{
			return base.Channel.Get_WorkersAsync(request);
		}

		public Task<Get_WorkersOutput> Get_WorkersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_RequestType Get_Workers_Request)
		{
			return ((StaffingPort)this).Get_WorkersAsync(new Get_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Request = Get_Workers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_PositionOutput StaffingPort.Edit_Position(Edit_PositionInput request)
		{
			return base.Channel.Edit_Position(request);
		}

		public Edit_Position_Event_ResponseType Edit_Position(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_RequestType Edit_Position_Request)
		{
			return ((StaffingPort)this).Edit_Position(new Edit_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Request = Edit_Position_Request
			}).Edit_Position_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_PositionOutput> StaffingPort.Edit_PositionAsync(Edit_PositionInput request)
		{
			return base.Channel.Edit_PositionAsync(request);
		}

		public Task<Edit_PositionOutput> Edit_PositionAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_RequestType Edit_Position_Request)
		{
			return ((StaffingPort)this).Edit_PositionAsync(new Edit_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Request = Edit_Position_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Hire_EmployeeOutput StaffingPort.Hire_Employee(Hire_EmployeeInput request)
		{
			return base.Channel.Hire_Employee(request);
		}

		public Hire_Employee_Event_ResponseType Hire_Employee(Workday_Common_HeaderType Workday_Common_Header, Hire_Employee_RequestType Hire_Employee_Request)
		{
			return ((StaffingPort)this).Hire_Employee(new Hire_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Hire_Employee_Request = Hire_Employee_Request
			}).Hire_Employee_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Hire_EmployeeOutput> StaffingPort.Hire_EmployeeAsync(Hire_EmployeeInput request)
		{
			return base.Channel.Hire_EmployeeAsync(request);
		}

		public Task<Hire_EmployeeOutput> Hire_EmployeeAsync(Workday_Common_HeaderType Workday_Common_Header, Hire_Employee_RequestType Hire_Employee_Request)
		{
			return ((StaffingPort)this).Hire_EmployeeAsync(new Hire_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Hire_Employee_Request = Hire_Employee_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ApplicantsOutput StaffingPort.Get_Applicants(Get_ApplicantsInput request)
		{
			return base.Channel.Get_Applicants(request);
		}

		public Get_Applicants_ResponseType Get_Applicants(Workday_Common_HeaderType Workday_Common_Header, Get_Applicants_RequestType Get_Applicants_Request)
		{
			return ((StaffingPort)this).Get_Applicants(new Get_ApplicantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Applicants_Request = Get_Applicants_Request
			}).Get_Applicants_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ApplicantsOutput> StaffingPort.Get_ApplicantsAsync(Get_ApplicantsInput request)
		{
			return base.Channel.Get_ApplicantsAsync(request);
		}

		public Task<Get_ApplicantsOutput> Get_ApplicantsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Applicants_RequestType Get_Applicants_Request)
		{
			return ((StaffingPort)this).Get_ApplicantsAsync(new Get_ApplicantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Applicants_Request = Get_Applicants_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_OrganizationOutput StaffingPort.Assign_Organization(Assign_OrganizationInput request)
		{
			return base.Channel.Assign_Organization(request);
		}

		public Assign_Organization_ResponseType Assign_Organization(Workday_Common_HeaderType Workday_Common_Header, Assign_Organization_RequestType Assign_Organization_Request)
		{
			return ((StaffingPort)this).Assign_Organization(new Assign_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Organization_Request = Assign_Organization_Request
			}).Assign_Organization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_OrganizationOutput> StaffingPort.Assign_OrganizationAsync(Assign_OrganizationInput request)
		{
			return base.Channel.Assign_OrganizationAsync(request);
		}

		public Task<Assign_OrganizationOutput> Assign_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Organization_RequestType Assign_Organization_Request)
		{
			return ((StaffingPort)this).Assign_OrganizationAsync(new Assign_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Organization_Request = Assign_Organization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ApplicantOutput StaffingPort.Put_Applicant(Put_ApplicantInput request)
		{
			return base.Channel.Put_Applicant(request);
		}

		public Put_Applicant_ResponseType Put_Applicant(Workday_Common_HeaderType Workday_Common_Header, Put_Applicant_RequestType Put_Applicant_Request)
		{
			return ((StaffingPort)this).Put_Applicant(new Put_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Applicant_Request = Put_Applicant_Request
			}).Put_Applicant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ApplicantOutput> StaffingPort.Put_ApplicantAsync(Put_ApplicantInput request)
		{
			return base.Channel.Put_ApplicantAsync(request);
		}

		public Task<Put_ApplicantOutput> Put_ApplicantAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Applicant_RequestType Put_Applicant_Request)
		{
			return ((StaffingPort)this).Put_ApplicantAsync(new Put_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Applicant_Request = Put_Applicant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Contingent_Worker_ContractOutput StaffingPort.End_Contingent_Worker_Contract(End_Contingent_Worker_ContractInput request)
		{
			return base.Channel.End_Contingent_Worker_Contract(request);
		}

		public End_Contingent_Worker_Contract_ResponseType End_Contingent_Worker_Contract(Workday_Common_HeaderType Workday_Common_Header, End_Contingent_Worker_Contract_RequestType End_Contingent_Worker_Contract_Request)
		{
			return ((StaffingPort)this).End_Contingent_Worker_Contract(new End_Contingent_Worker_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Contingent_Worker_Contract_Request = End_Contingent_Worker_Contract_Request
			}).End_Contingent_Worker_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Contingent_Worker_ContractOutput> StaffingPort.End_Contingent_Worker_ContractAsync(End_Contingent_Worker_ContractInput request)
		{
			return base.Channel.End_Contingent_Worker_ContractAsync(request);
		}

		public Task<End_Contingent_Worker_ContractOutput> End_Contingent_Worker_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, End_Contingent_Worker_Contract_RequestType End_Contingent_Worker_Contract_Request)
		{
			return ((StaffingPort)this).End_Contingent_Worker_ContractAsync(new End_Contingent_Worker_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Contingent_Worker_Contract_Request = End_Contingent_Worker_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Contract_Contingent_WorkerOutput StaffingPort.Contract_Contingent_Worker(Contract_Contingent_WorkerInput request)
		{
			return base.Channel.Contract_Contingent_Worker(request);
		}

		public Contract_Contingent_Worker_ResponseType Contract_Contingent_Worker(Workday_Common_HeaderType Workday_Common_Header, Contract_Contingent_Worker_RequestType Contract_Contingent_Worker_Request)
		{
			return ((StaffingPort)this).Contract_Contingent_Worker(new Contract_Contingent_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contract_Contingent_Worker_Request = Contract_Contingent_Worker_Request
			}).Contract_Contingent_Worker_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Contract_Contingent_WorkerOutput> StaffingPort.Contract_Contingent_WorkerAsync(Contract_Contingent_WorkerInput request)
		{
			return base.Channel.Contract_Contingent_WorkerAsync(request);
		}

		public Task<Contract_Contingent_WorkerOutput> Contract_Contingent_WorkerAsync(Workday_Common_HeaderType Workday_Common_Header, Contract_Contingent_Worker_RequestType Contract_Contingent_Worker_Request)
		{
			return ((StaffingPort)this).Contract_Contingent_WorkerAsync(new Contract_Contingent_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contract_Contingent_Worker_Request = Contract_Contingent_Worker_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DependentOutput StaffingPort.Put_Dependent(Put_DependentInput request)
		{
			return base.Channel.Put_Dependent(request);
		}

		public Put_Dependent_ResponseType Put_Dependent(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((StaffingPort)this).Put_Dependent(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			}).Put_Dependent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DependentOutput> StaffingPort.Put_DependentAsync(Put_DependentInput request)
		{
			return base.Channel.Put_DependentAsync(request);
		}

		public Task<Put_DependentOutput> Put_DependentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((StaffingPort)this).Put_DependentAsync(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_PositionOutput StaffingPort.Create_Position(Create_PositionInput request)
		{
			return base.Channel.Create_Position(request);
		}

		public Create_Position_ResponseType Create_Position(Workday_Common_HeaderType Workday_Common_Header, Create_Position_RequestType Create_Position_Request)
		{
			return ((StaffingPort)this).Create_Position(new Create_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Position_Request = Create_Position_Request
			}).Create_Position_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_PositionOutput> StaffingPort.Create_PositionAsync(Create_PositionInput request)
		{
			return base.Channel.Create_PositionAsync(request);
		}

		public Task<Create_PositionOutput> Create_PositionAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Position_RequestType Create_Position_Request)
		{
			return ((StaffingPort)this).Create_PositionAsync(new Create_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Position_Request = Create_Position_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PositionsOutput StaffingPort.Get_Positions(Get_PositionsInput request)
		{
			return base.Channel.Get_Positions(request);
		}

		public Get_Positions_ResponseType Get_Positions(Workday_Common_HeaderType Workday_Common_Header, Get_Positions_RequestType Get_Positions_Request)
		{
			return ((StaffingPort)this).Get_Positions(new Get_PositionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Positions_Request = Get_Positions_Request
			}).Get_Positions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PositionsOutput> StaffingPort.Get_PositionsAsync(Get_PositionsInput request)
		{
			return base.Channel.Get_PositionsAsync(request);
		}

		public Task<Get_PositionsOutput> Get_PositionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Positions_RequestType Get_Positions_Request)
		{
			return ((StaffingPort)this).Get_PositionsAsync(new Get_PositionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Positions_Request = Get_Positions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Service_DatesOutput StaffingPort.Edit_Service_Dates(Edit_Service_DatesInput request)
		{
			return base.Channel.Edit_Service_Dates(request);
		}

		public Edit_Service_Dates_ResponseType Edit_Service_Dates(Workday_Common_HeaderType Workday_Common_Header, Edit_Service_Dates_RequestType Edit_Service_Dates_Request)
		{
			return ((StaffingPort)this).Edit_Service_Dates(new Edit_Service_DatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Service_Dates_Request = Edit_Service_Dates_Request
			}).Edit_Service_Dates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Service_DatesOutput> StaffingPort.Edit_Service_DatesAsync(Edit_Service_DatesInput request)
		{
			return base.Channel.Edit_Service_DatesAsync(request);
		}

		public Task<Edit_Service_DatesOutput> Edit_Service_DatesAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Service_Dates_RequestType Edit_Service_Dates_Request)
		{
			return ((StaffingPort)this).Edit_Service_DatesAsync(new Edit_Service_DatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Service_Dates_Request = Edit_Service_Dates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrganizationsOutput StaffingPort.Get_Organizations(Get_OrganizationsInput request)
		{
			return base.Channel.Get_Organizations(request);
		}

		public Get_Organizations_ResponseType Get_Organizations(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((StaffingPort)this).Get_Organizations(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			}).Get_Organizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrganizationsOutput> StaffingPort.Get_OrganizationsAsync(Get_OrganizationsInput request)
		{
			return base.Channel.Get_OrganizationsAsync(request);
		}

		public Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((StaffingPort)this).Get_OrganizationsAsync(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Additional_JobOutput StaffingPort.End_Additional_Job(End_Additional_JobInput request)
		{
			return base.Channel.End_Additional_Job(request);
		}

		public End_Additional_Employee_Job_Event_ResponseType End_Additional_Job(Workday_Common_HeaderType Workday_Common_Header, End_Additional_Job_RequestType End_Additional_Job_Request)
		{
			return ((StaffingPort)this).End_Additional_Job(new End_Additional_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Additional_Job_Request = End_Additional_Job_Request
			}).End_Additional_Employee_Job_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Additional_JobOutput> StaffingPort.End_Additional_JobAsync(End_Additional_JobInput request)
		{
			return base.Channel.End_Additional_JobAsync(request);
		}

		public Task<End_Additional_JobOutput> End_Additional_JobAsync(Workday_Common_HeaderType Workday_Common_Header, End_Additional_Job_RequestType End_Additional_Job_Request)
		{
			return ((StaffingPort)this).End_Additional_JobAsync(new End_Additional_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Additional_Job_Request = End_Additional_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Additional_JobOutput StaffingPort.Add_Additional_Job(Add_Additional_JobInput request)
		{
			return base.Channel.Add_Additional_Job(request);
		}

		public Add_Additional_Job_Event_ResponseType Add_Additional_Job(Workday_Common_HeaderType Workday_Common_Header, Add_Additional_Job_RequestType Add_Additional_Job_Request)
		{
			return ((StaffingPort)this).Add_Additional_Job(new Add_Additional_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Additional_Job_Request = Add_Additional_Job_Request
			}).Add_Additional_Job_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Additional_JobOutput> StaffingPort.Add_Additional_JobAsync(Add_Additional_JobInput request)
		{
			return base.Channel.Add_Additional_JobAsync(request);
		}

		public Task<Add_Additional_JobOutput> Add_Additional_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Additional_Job_RequestType Add_Additional_Job_Request)
		{
			return ((StaffingPort)this).Add_Additional_JobAsync(new Add_Additional_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Additional_Job_Request = Add_Additional_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Retiree_StatusOutput StaffingPort.Add_Retiree_Status(Add_Retiree_StatusInput request)
		{
			return base.Channel.Add_Retiree_Status(request);
		}

		public Add_Retiree_Status_ResponseType Add_Retiree_Status(Workday_Common_HeaderType Workday_Common_Header, Add_Retiree_Status_RequestType Add_Retiree_Status_Request)
		{
			return ((StaffingPort)this).Add_Retiree_Status(new Add_Retiree_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Retiree_Status_Request = Add_Retiree_Status_Request
			}).Add_Retiree_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Retiree_StatusOutput> StaffingPort.Add_Retiree_StatusAsync(Add_Retiree_StatusInput request)
		{
			return base.Channel.Add_Retiree_StatusAsync(request);
		}

		public Task<Add_Retiree_StatusOutput> Add_Retiree_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Retiree_Status_RequestType Add_Retiree_Status_Request)
		{
			return ((StaffingPort)this).Add_Retiree_StatusAsync(new Add_Retiree_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Retiree_Status_Request = Add_Retiree_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Remove_Retiree_StatusOutput StaffingPort.Remove_Retiree_Status(Remove_Retiree_StatusInput request)
		{
			return base.Channel.Remove_Retiree_Status(request);
		}

		public Remove_Retiree_Status_ResponseType Remove_Retiree_Status(Workday_Common_HeaderType Workday_Common_Header, Remove_Retiree_Status_RequestType Remove_Retiree_Status_Request)
		{
			return ((StaffingPort)this).Remove_Retiree_Status(new Remove_Retiree_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Retiree_Status_Request = Remove_Retiree_Status_Request
			}).Remove_Retiree_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Remove_Retiree_StatusOutput> StaffingPort.Remove_Retiree_StatusAsync(Remove_Retiree_StatusInput request)
		{
			return base.Channel.Remove_Retiree_StatusAsync(request);
		}

		public Task<Remove_Retiree_StatusOutput> Remove_Retiree_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Remove_Retiree_Status_RequestType Remove_Retiree_Status_Request)
		{
			return ((StaffingPort)this).Remove_Retiree_StatusAsync(new Remove_Retiree_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Retiree_Status_Request = Remove_Retiree_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Maintain_Employee_ContractsOutput StaffingPort.Maintain_Employee_Contracts(Maintain_Employee_ContractsInput request)
		{
			return base.Channel.Maintain_Employee_Contracts(request);
		}

		public Maintain_Employee_Contracts_ResponseType Maintain_Employee_Contracts(Workday_Common_HeaderType Workday_Common_Header, Maintain_Employee_Contracts_RequestType Maintain_Employee_Contracts_Request)
		{
			return ((StaffingPort)this).Maintain_Employee_Contracts(new Maintain_Employee_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Employee_Contracts_Request = Maintain_Employee_Contracts_Request
			}).Maintain_Employee_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Maintain_Employee_ContractsOutput> StaffingPort.Maintain_Employee_ContractsAsync(Maintain_Employee_ContractsInput request)
		{
			return base.Channel.Maintain_Employee_ContractsAsync(request);
		}

		public Task<Maintain_Employee_ContractsOutput> Maintain_Employee_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Maintain_Employee_Contracts_RequestType Maintain_Employee_Contracts_Request)
		{
			return ((StaffingPort)this).Maintain_Employee_ContractsAsync(new Maintain_Employee_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Employee_Contracts_Request = Maintain_Employee_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Citizenship_StatusesOutput StaffingPort.Get_Citizenship_Statuses(Get_Citizenship_StatusesInput request)
		{
			return base.Channel.Get_Citizenship_Statuses(request);
		}

		public Get_Citizenship_Statuses_ResponseType Get_Citizenship_Statuses(Workday_Common_HeaderType Workday_Common_Header, Get_Citizenship_Statuses_RequestType Get_Citizenship_Statuses_Request)
		{
			return ((StaffingPort)this).Get_Citizenship_Statuses(new Get_Citizenship_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Citizenship_Statuses_Request = Get_Citizenship_Statuses_Request
			}).Get_Citizenship_Statuses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Citizenship_StatusesOutput> StaffingPort.Get_Citizenship_StatusesAsync(Get_Citizenship_StatusesInput request)
		{
			return base.Channel.Get_Citizenship_StatusesAsync(request);
		}

		public Task<Get_Citizenship_StatusesOutput> Get_Citizenship_StatusesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Citizenship_Statuses_RequestType Get_Citizenship_Statuses_Request)
		{
			return ((StaffingPort)this).Get_Citizenship_StatusesAsync(new Get_Citizenship_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Citizenship_Statuses_Request = Get_Citizenship_Statuses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Citizenship_StatusOutput StaffingPort.Put_Citizenship_Status(Put_Citizenship_StatusInput request)
		{
			return base.Channel.Put_Citizenship_Status(request);
		}

		public Put_Citizenship_Status_ResponseType Put_Citizenship_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Citizenship_Status_RequestType Put_Citizenship_Status_Request)
		{
			return ((StaffingPort)this).Put_Citizenship_Status(new Put_Citizenship_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Citizenship_Status_Request = Put_Citizenship_Status_Request
			}).Put_Citizenship_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Citizenship_StatusOutput> StaffingPort.Put_Citizenship_StatusAsync(Put_Citizenship_StatusInput request)
		{
			return base.Channel.Put_Citizenship_StatusAsync(request);
		}

		public Task<Put_Citizenship_StatusOutput> Put_Citizenship_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Citizenship_Status_RequestType Put_Citizenship_Status_Request)
		{
			return ((StaffingPort)this).Put_Citizenship_StatusAsync(new Put_Citizenship_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Citizenship_Status_Request = Put_Citizenship_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Position_RestrictionsOutput StaffingPort.Edit_Position_Restrictions(Edit_Position_RestrictionsInput request)
		{
			return base.Channel.Edit_Position_Restrictions(request);
		}

		public Edit_Positon_Restriction_ResponseType Edit_Position_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_RequestType Edit_Position_Restrictions_Request)
		{
			return ((StaffingPort)this).Edit_Position_Restrictions(new Edit_Position_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Request = Edit_Position_Restrictions_Request
			}).Edit_Positon_Restriction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Position_RestrictionsOutput> StaffingPort.Edit_Position_RestrictionsAsync(Edit_Position_RestrictionsInput request)
		{
			return base.Channel.Edit_Position_RestrictionsAsync(request);
		}

		public Task<Edit_Position_RestrictionsOutput> Edit_Position_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_RequestType Edit_Position_Restrictions_Request)
		{
			return ((StaffingPort)this).Edit_Position_RestrictionsAsync(new Edit_Position_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Request = Edit_Position_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Classification_GroupsOutput StaffingPort.Get_Job_Classification_Groups(Get_Job_Classification_GroupsInput request)
		{
			return base.Channel.Get_Job_Classification_Groups(request);
		}

		public Get_Job_Classification_Groups_ResponseType Get_Job_Classification_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Classification_Groups_RequestType Get_Job_Classification_Groups_Request)
		{
			return ((StaffingPort)this).Get_Job_Classification_Groups(new Get_Job_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Classification_Groups_Request = Get_Job_Classification_Groups_Request
			}).Get_Job_Classification_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Classification_GroupsOutput> StaffingPort.Get_Job_Classification_GroupsAsync(Get_Job_Classification_GroupsInput request)
		{
			return base.Channel.Get_Job_Classification_GroupsAsync(request);
		}

		public Task<Get_Job_Classification_GroupsOutput> Get_Job_Classification_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Classification_Groups_RequestType Get_Job_Classification_Groups_Request)
		{
			return ((StaffingPort)this).Get_Job_Classification_GroupsAsync(new Get_Job_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Classification_Groups_Request = Get_Job_Classification_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Classification_GroupOutput StaffingPort.Put_Job_Classification_Group(Put_Job_Classification_GroupInput request)
		{
			return base.Channel.Put_Job_Classification_Group(request);
		}

		public Put_Job_Classification_Group_ResponseType Put_Job_Classification_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Classification_Group_RequestType Put_Job_Classification_Group_Request)
		{
			return ((StaffingPort)this).Put_Job_Classification_Group(new Put_Job_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Classification_Group_Request = Put_Job_Classification_Group_Request
			}).Put_Job_Classification_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Classification_GroupOutput> StaffingPort.Put_Job_Classification_GroupAsync(Put_Job_Classification_GroupInput request)
		{
			return base.Channel.Put_Job_Classification_GroupAsync(request);
		}

		public Task<Put_Job_Classification_GroupOutput> Put_Job_Classification_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Classification_Group_RequestType Put_Job_Classification_Group_Request)
		{
			return ((StaffingPort)this).Put_Job_Classification_GroupAsync(new Put_Job_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Classification_Group_Request = Put_Job_Classification_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_FamiliesOutput StaffingPort.Get_Job_Families(Get_Job_FamiliesInput request)
		{
			return base.Channel.Get_Job_Families(request);
		}

		public Get_Job_Families_ResponseType Get_Job_Families(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Families_RequestType Get_Job_Families_Request)
		{
			return ((StaffingPort)this).Get_Job_Families(new Get_Job_FamiliesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Families_Request = Get_Job_Families_Request
			}).Get_Job_Families_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_FamiliesOutput> StaffingPort.Get_Job_FamiliesAsync(Get_Job_FamiliesInput request)
		{
			return base.Channel.Get_Job_FamiliesAsync(request);
		}

		public Task<Get_Job_FamiliesOutput> Get_Job_FamiliesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Families_RequestType Get_Job_Families_Request)
		{
			return ((StaffingPort)this).Get_Job_FamiliesAsync(new Get_Job_FamiliesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Families_Request = Get_Job_Families_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_FamilyOutput StaffingPort.Put_Job_Family(Put_Job_FamilyInput request)
		{
			return base.Channel.Put_Job_Family(request);
		}

		public Put_Job_Family_ResponseType Put_Job_Family(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_RequestType Put_Job_Family_Request)
		{
			return ((StaffingPort)this).Put_Job_Family(new Put_Job_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Request = Put_Job_Family_Request
			}).Put_Job_Family_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_FamilyOutput> StaffingPort.Put_Job_FamilyAsync(Put_Job_FamilyInput request)
		{
			return base.Channel.Put_Job_FamilyAsync(request);
		}

		public Task<Put_Job_FamilyOutput> Put_Job_FamilyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_RequestType Put_Job_Family_Request)
		{
			return ((StaffingPort)this).Put_Job_FamilyAsync(new Put_Job_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Request = Put_Job_Family_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Family_GroupsOutput StaffingPort.Get_Job_Family_Groups(Get_Job_Family_GroupsInput request)
		{
			return base.Channel.Get_Job_Family_Groups(request);
		}

		public Get_Job_Family_Groups_ResponseType Get_Job_Family_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Family_Groups_RequestType Get_Job_Family_Groups_Request)
		{
			return ((StaffingPort)this).Get_Job_Family_Groups(new Get_Job_Family_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Family_Groups_Request = Get_Job_Family_Groups_Request
			}).Get_Job_Family_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Family_GroupsOutput> StaffingPort.Get_Job_Family_GroupsAsync(Get_Job_Family_GroupsInput request)
		{
			return base.Channel.Get_Job_Family_GroupsAsync(request);
		}

		public Task<Get_Job_Family_GroupsOutput> Get_Job_Family_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Family_Groups_RequestType Get_Job_Family_Groups_Request)
		{
			return ((StaffingPort)this).Get_Job_Family_GroupsAsync(new Get_Job_Family_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Family_Groups_Request = Get_Job_Family_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Family_GroupOutput StaffingPort.Put_Job_Family_Group(Put_Job_Family_GroupInput request)
		{
			return base.Channel.Put_Job_Family_Group(request);
		}

		public Put_Job_Family_Group_ResponseType Put_Job_Family_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_Group_RequestType Put_Job_Family_Group_Request)
		{
			return ((StaffingPort)this).Put_Job_Family_Group(new Put_Job_Family_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Group_Request = Put_Job_Family_Group_Request
			}).Put_Job_Family_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Family_GroupOutput> StaffingPort.Put_Job_Family_GroupAsync(Put_Job_Family_GroupInput request)
		{
			return base.Channel.Put_Job_Family_GroupAsync(request);
		}

		public Task<Put_Job_Family_GroupOutput> Put_Job_Family_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_Group_RequestType Put_Job_Family_Group_Request)
		{
			return ((StaffingPort)this).Put_Job_Family_GroupAsync(new Put_Job_Family_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Group_Request = Put_Job_Family_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Start_International_AssignmentOutput StaffingPort.Start_International_Assignment(Start_International_AssignmentInput request)
		{
			return base.Channel.Start_International_Assignment(request);
		}

		public Start_International_Assignment_ResponseType Start_International_Assignment(Workday_Common_HeaderType Workday_Common_Header, Start_International_Assignment_RequestType Start_International_Assignment_Request)
		{
			return ((StaffingPort)this).Start_International_Assignment(new Start_International_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Start_International_Assignment_Request = Start_International_Assignment_Request
			}).Start_International_Assignment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Start_International_AssignmentOutput> StaffingPort.Start_International_AssignmentAsync(Start_International_AssignmentInput request)
		{
			return base.Channel.Start_International_AssignmentAsync(request);
		}

		public Task<Start_International_AssignmentOutput> Start_International_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, Start_International_Assignment_RequestType Start_International_Assignment_Request)
		{
			return ((StaffingPort)this).Start_International_AssignmentAsync(new Start_International_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Start_International_Assignment_Request = Start_International_Assignment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_International_AssignmentOutput StaffingPort.End_International_Assignment(End_International_AssignmentInput request)
		{
			return base.Channel.End_International_Assignment(request);
		}

		public End_International_Assignment_for_Employee_Event_ResponseType End_International_Assignment(Workday_Common_HeaderType Workday_Common_Header, End_International_Assignment_for_Employee_Event_RequestType End_International_Assignment_for_Employee_Event_Request)
		{
			return ((StaffingPort)this).End_International_Assignment(new End_International_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_International_Assignment_for_Employee_Event_Request = End_International_Assignment_for_Employee_Event_Request
			}).End_International_Assignment_for_Employee_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_International_AssignmentOutput> StaffingPort.End_International_AssignmentAsync(End_International_AssignmentInput request)
		{
			return base.Channel.End_International_AssignmentAsync(request);
		}

		public Task<End_International_AssignmentOutput> End_International_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, End_International_Assignment_for_Employee_Event_RequestType End_International_Assignment_for_Employee_Event_Request)
		{
			return ((StaffingPort)this).End_International_AssignmentAsync(new End_International_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_International_Assignment_for_Employee_Event_Request = End_International_Assignment_for_Employee_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Organization_RolesOutput StaffingPort.Assign_Organization_Roles(Assign_Organization_RolesInput request)
		{
			return base.Channel.Assign_Organization_Roles(request);
		}

		public Assign_Organization_Roles_ResponseType Assign_Organization_Roles(Workday_Common_HeaderType Workday_Common_Header, Assign_Organization_Roles_RequestType Assign_Organization_Roles_Request)
		{
			return ((StaffingPort)this).Assign_Organization_Roles(new Assign_Organization_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Organization_Roles_Request = Assign_Organization_Roles_Request
			}).Assign_Organization_Roles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Organization_RolesOutput> StaffingPort.Assign_Organization_RolesAsync(Assign_Organization_RolesInput request)
		{
			return base.Channel.Assign_Organization_RolesAsync(request);
		}

		public Task<Assign_Organization_RolesOutput> Assign_Organization_RolesAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Organization_Roles_RequestType Assign_Organization_Roles_Request)
		{
			return ((StaffingPort)this).Assign_Organization_RolesAsync(new Assign_Organization_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Organization_Roles_Request = Assign_Organization_Roles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Worker_DocumentOutput StaffingPort.Put_Worker_Document(Put_Worker_DocumentInput request)
		{
			return base.Channel.Put_Worker_Document(request);
		}

		public Put_Worker_Document_ResponseType Put_Worker_Document(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Document_RequestType Put_Worker_Document_Request)
		{
			return ((StaffingPort)this).Put_Worker_Document(new Put_Worker_DocumentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Document_Request = Put_Worker_Document_Request
			}).Put_Worker_Document_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Worker_DocumentOutput> StaffingPort.Put_Worker_DocumentAsync(Put_Worker_DocumentInput request)
		{
			return base.Channel.Put_Worker_DocumentAsync(request);
		}

		public Task<Put_Worker_DocumentOutput> Put_Worker_DocumentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Document_RequestType Put_Worker_Document_Request)
		{
			return ((StaffingPort)this).Put_Worker_DocumentAsync(new Put_Worker_DocumentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Document_Request = Put_Worker_Document_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_DocumentsOutput StaffingPort.Get_Worker_Documents(Get_Worker_DocumentsInput request)
		{
			return base.Channel.Get_Worker_Documents(request);
		}

		public Get_Worker_Documents_ResponseType Get_Worker_Documents(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Documents_RequestType Get_Worker_Documents_Request)
		{
			return ((StaffingPort)this).Get_Worker_Documents(new Get_Worker_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Documents_Request = Get_Worker_Documents_Request
			}).Get_Worker_Documents_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_DocumentsOutput> StaffingPort.Get_Worker_DocumentsAsync(Get_Worker_DocumentsInput request)
		{
			return base.Channel.Get_Worker_DocumentsAsync(request);
		}

		public Task<Get_Worker_DocumentsOutput> Get_Worker_DocumentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Documents_RequestType Get_Worker_Documents_Request)
		{
			return ((StaffingPort)this).Get_Worker_DocumentsAsync(new Get_Worker_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Documents_Request = Get_Worker_Documents_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_JobOutput StaffingPort.Change_Job(Change_JobInput request)
		{
			return base.Channel.Change_Job(request);
		}

		public Change_Job_ResponseType Change_Job(Workday_Common_HeaderType Workday_Common_Header, Change_Job_RequestType Change_Job_Request)
		{
			return ((StaffingPort)this).Change_Job(new Change_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Job_Request = Change_Job_Request
			}).Change_Job_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_JobOutput> StaffingPort.Change_JobAsync(Change_JobInput request)
		{
			return base.Channel.Change_JobAsync(request);
		}

		public Task<Change_JobOutput> Change_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Job_RequestType Change_Job_Request)
		{
			return ((StaffingPort)this).Change_JobAsync(new Change_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Job_Request = Change_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Switch_Primary_JobOutput StaffingPort.Switch_Primary_Job(Switch_Primary_JobInput request)
		{
			return base.Channel.Switch_Primary_Job(request);
		}

		public Switch_Primary_Job_Event_ResponseType Switch_Primary_Job(Workday_Common_HeaderType Workday_Common_Header, Switch_Primary_Job_RequestType Switch_Primary_Job_Request)
		{
			return ((StaffingPort)this).Switch_Primary_Job(new Switch_Primary_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Switch_Primary_Job_Request = Switch_Primary_Job_Request
			}).Switch_Primary_Job_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Switch_Primary_JobOutput> StaffingPort.Switch_Primary_JobAsync(Switch_Primary_JobInput request)
		{
			return base.Channel.Switch_Primary_JobAsync(request);
		}

		public Task<Switch_Primary_JobOutput> Switch_Primary_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Switch_Primary_Job_RequestType Switch_Primary_Job_Request)
		{
			return ((StaffingPort)this).Switch_Primary_JobAsync(new Switch_Primary_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Switch_Primary_Job_Request = Switch_Primary_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Close_PositionOutput StaffingPort.Close_Position(Close_PositionInput request)
		{
			return base.Channel.Close_Position(request);
		}

		public Close_Position_ResponseType Close_Position(Workday_Common_HeaderType Workday_Common_Header, Close_Position_RequestType Close_Position_Request)
		{
			return ((StaffingPort)this).Close_Position(new Close_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Position_Request = Close_Position_Request
			}).Close_Position_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Close_PositionOutput> StaffingPort.Close_PositionAsync(Close_PositionInput request)
		{
			return base.Channel.Close_PositionAsync(request);
		}

		public Task<Close_PositionOutput> Close_PositionAsync(Workday_Common_HeaderType Workday_Common_Header, Close_Position_RequestType Close_Position_Request)
		{
			return ((StaffingPort)this).Close_PositionAsync(new Close_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Position_Request = Close_Position_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Set_Hiring_RestrictionsOutput StaffingPort.Set_Hiring_Restrictions(Set_Hiring_RestrictionsInput request)
		{
			return base.Channel.Set_Hiring_Restrictions(request);
		}

		public Set_Hiring_Restrictions_ResponseType Set_Hiring_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Set_Hiring_Restrictions_RequestType Set_Hiring_Restrictions_Request)
		{
			return ((StaffingPort)this).Set_Hiring_Restrictions(new Set_Hiring_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Set_Hiring_Restrictions_Request = Set_Hiring_Restrictions_Request
			}).Set_Hiring_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Set_Hiring_RestrictionsOutput> StaffingPort.Set_Hiring_RestrictionsAsync(Set_Hiring_RestrictionsInput request)
		{
			return base.Channel.Set_Hiring_RestrictionsAsync(request);
		}

		public Task<Set_Hiring_RestrictionsOutput> Set_Hiring_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Set_Hiring_Restrictions_RequestType Set_Hiring_Restrictions_Request)
		{
			return ((StaffingPort)this).Set_Hiring_RestrictionsAsync(new Set_Hiring_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Set_Hiring_Restrictions_Request = Set_Hiring_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Hiring_RestrictionsOutput StaffingPort.Edit_Hiring_Restrictions(Edit_Hiring_RestrictionsInput request)
		{
			return base.Channel.Edit_Hiring_Restrictions(request);
		}

		public Edit_Hiring_Restrictions_ResponseType Edit_Hiring_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Edit_Hiring_Restrictions_RequestType Edit_Hiring_Restrictions_Request)
		{
			return ((StaffingPort)this).Edit_Hiring_Restrictions(new Edit_Hiring_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Hiring_Restrictions_Request = Edit_Hiring_Restrictions_Request
			}).Edit_Hiring_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Hiring_RestrictionsOutput> StaffingPort.Edit_Hiring_RestrictionsAsync(Edit_Hiring_RestrictionsInput request)
		{
			return base.Channel.Edit_Hiring_RestrictionsAsync(request);
		}

		public Task<Edit_Hiring_RestrictionsOutput> Edit_Hiring_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Hiring_Restrictions_RequestType Edit_Hiring_Restrictions_Request)
		{
			return ((StaffingPort)this).Edit_Hiring_RestrictionsAsync(new Edit_Hiring_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Hiring_Restrictions_Request = Edit_Hiring_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Hire_Event_Proposed_Worker_IDOutput StaffingPort.Put_Hire_Event_Proposed_Worker_ID(Put_Hire_Event_Proposed_Worker_IDInput request)
		{
			return base.Channel.Put_Hire_Event_Proposed_Worker_ID(request);
		}

		public Put_Hire_Event_Proposed_Worker_ID_ResponseType Put_Hire_Event_Proposed_Worker_ID(Workday_Common_HeaderType Workday_Common_Header, Put_Hire_Event_Proposed_Worker_ID_RequestType Put_Hire_Event_Proposed_Worker_ID_Request)
		{
			return ((StaffingPort)this).Put_Hire_Event_Proposed_Worker_ID(new Put_Hire_Event_Proposed_Worker_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Hire_Event_Proposed_Worker_ID_Request = Put_Hire_Event_Proposed_Worker_ID_Request
			}).Put_Hire_Event_Proposed_Worker_ID_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Hire_Event_Proposed_Worker_IDOutput> StaffingPort.Put_Hire_Event_Proposed_Worker_IDAsync(Put_Hire_Event_Proposed_Worker_IDInput request)
		{
			return base.Channel.Put_Hire_Event_Proposed_Worker_IDAsync(request);
		}

		public Task<Put_Hire_Event_Proposed_Worker_IDOutput> Put_Hire_Event_Proposed_Worker_IDAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Hire_Event_Proposed_Worker_ID_RequestType Put_Hire_Event_Proposed_Worker_ID_Request)
		{
			return ((StaffingPort)this).Put_Hire_Event_Proposed_Worker_IDAsync(new Put_Hire_Event_Proposed_Worker_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Hire_Event_Proposed_Worker_ID_Request = Put_Hire_Event_Proposed_Worker_ID_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Worker_Additional_DataOutput StaffingPort.Edit_Worker_Additional_Data(Edit_Worker_Additional_DataInput request)
		{
			return base.Channel.Edit_Worker_Additional_Data(request);
		}

		public Edit_Worker_Additional_Data_ResponseType Edit_Worker_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Edit_Worker_Additional_Data_RequestType Edit_Worker_Additional_Data_Request)
		{
			return ((StaffingPort)this).Edit_Worker_Additional_Data(new Edit_Worker_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Worker_Additional_Data_Request = Edit_Worker_Additional_Data_Request
			}).Edit_Worker_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Worker_Additional_DataOutput> StaffingPort.Edit_Worker_Additional_DataAsync(Edit_Worker_Additional_DataInput request)
		{
			return base.Channel.Edit_Worker_Additional_DataAsync(request);
		}

		public Task<Edit_Worker_Additional_DataOutput> Edit_Worker_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Worker_Additional_Data_RequestType Edit_Worker_Additional_Data_Request)
		{
			return ((StaffingPort)this).Edit_Worker_Additional_DataAsync(new Edit_Worker_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Worker_Additional_Data_Request = Edit_Worker_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Position_Restrictions_Additional_DataOutput StaffingPort.Edit_Position_Restrictions_Additional_Data(Edit_Position_Restrictions_Additional_DataInput request)
		{
			return base.Channel.Edit_Position_Restrictions_Additional_Data(request);
		}

		public Edit_Position_Restrictions_Additional_Data_ResponseType Edit_Position_Restrictions_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_Additional_Data_RequestType Edit_Position_Restrictions_Additional_Data_Request)
		{
			return ((StaffingPort)this).Edit_Position_Restrictions_Additional_Data(new Edit_Position_Restrictions_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Additional_Data_Request = Edit_Position_Restrictions_Additional_Data_Request
			}).Edit_Position_Restrictions_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Position_Restrictions_Additional_DataOutput> StaffingPort.Edit_Position_Restrictions_Additional_DataAsync(Edit_Position_Restrictions_Additional_DataInput request)
		{
			return base.Channel.Edit_Position_Restrictions_Additional_DataAsync(request);
		}

		public Task<Edit_Position_Restrictions_Additional_DataOutput> Edit_Position_Restrictions_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_Additional_Data_RequestType Edit_Position_Restrictions_Additional_Data_Request)
		{
			return ((StaffingPort)this).Edit_Position_Restrictions_Additional_DataAsync(new Edit_Position_Restrictions_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Additional_Data_Request = Edit_Position_Restrictions_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Move_Workers_By_OrganizationOutput StaffingPort.Move_Workers_By_Organization(Move_Workers_By_OrganizationInput request)
		{
			return base.Channel.Move_Workers_By_Organization(request);
		}

		public Move_Workers_By_Organization_ResponseType Move_Workers_By_Organization(Workday_Common_HeaderType Workday_Common_Header, Move_Workers_By_Organization_RequestType Move_Workers_By_Organization_Request)
		{
			return ((StaffingPort)this).Move_Workers_By_Organization(new Move_Workers_By_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Workers_By_Organization_Request = Move_Workers_By_Organization_Request
			}).Move_Workers_By_Organization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Move_Workers_By_OrganizationOutput> StaffingPort.Move_Workers_By_OrganizationAsync(Move_Workers_By_OrganizationInput request)
		{
			return base.Channel.Move_Workers_By_OrganizationAsync(request);
		}

		public Task<Move_Workers_By_OrganizationOutput> Move_Workers_By_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Move_Workers_By_Organization_RequestType Move_Workers_By_Organization_Request)
		{
			return ((StaffingPort)this).Move_Workers_By_OrganizationAsync(new Move_Workers_By_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Workers_By_Organization_Request = Move_Workers_By_Organization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Organization_AssignmentsOutput StaffingPort.Change_Organization_Assignments(Change_Organization_AssignmentsInput request)
		{
			return base.Channel.Change_Organization_Assignments(request);
		}

		public Change_Organization_Assignments_ResponseType Change_Organization_Assignments(Workday_Common_HeaderType Workday_Common_Header, Change_Organization_Assignments_RequestType Change_Organization_Assignments_Request)
		{
			return ((StaffingPort)this).Change_Organization_Assignments(new Change_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Organization_Assignments_Request = Change_Organization_Assignments_Request
			}).Change_Organization_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Organization_AssignmentsOutput> StaffingPort.Change_Organization_AssignmentsAsync(Change_Organization_AssignmentsInput request)
		{
			return base.Channel.Change_Organization_AssignmentsAsync(request);
		}

		public Task<Change_Organization_AssignmentsOutput> Change_Organization_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Organization_Assignments_RequestType Change_Organization_Assignments_Request)
		{
			return ((StaffingPort)this).Change_Organization_AssignmentsAsync(new Change_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Organization_Assignments_Request = Change_Organization_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_RolesOutput StaffingPort.Assign_Roles(Assign_RolesInput request)
		{
			return base.Channel.Assign_Roles(request);
		}

		public Assign_Roles_ResponseType Assign_Roles(Workday_Common_HeaderType Workday_Common_Header, Assign_Roles_RequestType Assign_Roles_Request)
		{
			return ((StaffingPort)this).Assign_Roles(new Assign_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Roles_Request = Assign_Roles_Request
			}).Assign_Roles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_RolesOutput> StaffingPort.Assign_RolesAsync(Assign_RolesInput request)
		{
			return base.Channel.Assign_RolesAsync(request);
		}

		public Task<Assign_RolesOutput> Assign_RolesAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Roles_RequestType Assign_Roles_Request)
		{
			return ((StaffingPort)this).Assign_RolesAsync(new Assign_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Roles_Request = Assign_Roles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Employment_Eligibility_StatusOutput StaffingPort.Put_Student_Employment_Eligibility_Status(Put_Student_Employment_Eligibility_StatusInput request)
		{
			return base.Channel.Put_Student_Employment_Eligibility_Status(request);
		}

		public Put_Student_Employment_Eligibility_Status_ResponseType Put_Student_Employment_Eligibility_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Employment_Eligibility_Status_RequestType Put_Student_Employment_Eligibility_Status_Request)
		{
			return ((StaffingPort)this).Put_Student_Employment_Eligibility_Status(new Put_Student_Employment_Eligibility_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Employment_Eligibility_Status_Request = Put_Student_Employment_Eligibility_Status_Request
			}).Put_Student_Employment_Eligibility_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Employment_Eligibility_StatusOutput> StaffingPort.Put_Student_Employment_Eligibility_StatusAsync(Put_Student_Employment_Eligibility_StatusInput request)
		{
			return base.Channel.Put_Student_Employment_Eligibility_StatusAsync(request);
		}

		public Task<Put_Student_Employment_Eligibility_StatusOutput> Put_Student_Employment_Eligibility_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Employment_Eligibility_Status_RequestType Put_Student_Employment_Eligibility_Status_Request)
		{
			return ((StaffingPort)this).Put_Student_Employment_Eligibility_StatusAsync(new Put_Student_Employment_Eligibility_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Employment_Eligibility_Status_Request = Put_Student_Employment_Eligibility_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Employment_Eligibility_DataOutput StaffingPort.Get_Student_Employment_Eligibility_Data(Get_Student_Employment_Eligibility_DataInput request)
		{
			return base.Channel.Get_Student_Employment_Eligibility_Data(request);
		}

		public Get_Student_Employment_Eligibility_Data_ResponseType Get_Student_Employment_Eligibility_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Employment_Eligibility_Data_RequestType Get_Student_Employment_Eligibility_Data_Request)
		{
			return ((StaffingPort)this).Get_Student_Employment_Eligibility_Data(new Get_Student_Employment_Eligibility_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Employment_Eligibility_Data_Request = Get_Student_Employment_Eligibility_Data_Request
			}).Get_Student_Employment_Eligibility_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Employment_Eligibility_DataOutput> StaffingPort.Get_Student_Employment_Eligibility_DataAsync(Get_Student_Employment_Eligibility_DataInput request)
		{
			return base.Channel.Get_Student_Employment_Eligibility_DataAsync(request);
		}

		public Task<Get_Student_Employment_Eligibility_DataOutput> Get_Student_Employment_Eligibility_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Employment_Eligibility_Data_RequestType Get_Student_Employment_Eligibility_Data_Request)
		{
			return ((StaffingPort)this).Get_Student_Employment_Eligibility_DataAsync(new Get_Student_Employment_Eligibility_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Employment_Eligibility_Data_Request = Get_Student_Employment_Eligibility_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Notice_Period_Eligibility_RuleOutput StaffingPort.Put_Notice_Period_Eligibility_Rule(Put_Notice_Period_Eligibility_RuleInput request)
		{
			return base.Channel.Put_Notice_Period_Eligibility_Rule(request);
		}

		public Put_Notice_Period_Eligibility_Rule_ResponseType Put_Notice_Period_Eligibility_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Notice_Period_Eligibility_Rule_RequestType Put_Notice_Period_Eligibility_Rule_Request)
		{
			return ((StaffingPort)this).Put_Notice_Period_Eligibility_Rule(new Put_Notice_Period_Eligibility_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Notice_Period_Eligibility_Rule_Request = Put_Notice_Period_Eligibility_Rule_Request
			}).Put_Notice_Period_Eligibility_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Notice_Period_Eligibility_RuleOutput> StaffingPort.Put_Notice_Period_Eligibility_RuleAsync(Put_Notice_Period_Eligibility_RuleInput request)
		{
			return base.Channel.Put_Notice_Period_Eligibility_RuleAsync(request);
		}

		public Task<Put_Notice_Period_Eligibility_RuleOutput> Put_Notice_Period_Eligibility_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Notice_Period_Eligibility_Rule_RequestType Put_Notice_Period_Eligibility_Rule_Request)
		{
			return ((StaffingPort)this).Put_Notice_Period_Eligibility_RuleAsync(new Put_Notice_Period_Eligibility_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Notice_Period_Eligibility_Rule_Request = Put_Notice_Period_Eligibility_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Maintain_Notice_Periods_for_CountryOutput StaffingPort.Put_Maintain_Notice_Periods_for_Country(Put_Maintain_Notice_Periods_for_CountryInput request)
		{
			return base.Channel.Put_Maintain_Notice_Periods_for_Country(request);
		}

		public Put_Maintain_Notice_Periods_for_Country_ResponseType Put_Maintain_Notice_Periods_for_Country(Workday_Common_HeaderType Workday_Common_Header, Put_Maintain_Notice_Periods_for_Country_RequestType Put_Maintain_Notice_Periods_for_Country_Request)
		{
			return ((StaffingPort)this).Put_Maintain_Notice_Periods_for_Country(new Put_Maintain_Notice_Periods_for_CountryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Maintain_Notice_Periods_for_Country_Request = Put_Maintain_Notice_Periods_for_Country_Request
			}).Put_Maintain_Notice_Periods_for_Country_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Maintain_Notice_Periods_for_CountryOutput> StaffingPort.Put_Maintain_Notice_Periods_for_CountryAsync(Put_Maintain_Notice_Periods_for_CountryInput request)
		{
			return base.Channel.Put_Maintain_Notice_Periods_for_CountryAsync(request);
		}

		public Task<Put_Maintain_Notice_Periods_for_CountryOutput> Put_Maintain_Notice_Periods_for_CountryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Maintain_Notice_Periods_for_Country_RequestType Put_Maintain_Notice_Periods_for_Country_Request)
		{
			return ((StaffingPort)this).Put_Maintain_Notice_Periods_for_CountryAsync(new Put_Maintain_Notice_Periods_for_CountryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Maintain_Notice_Periods_for_Country_Request = Put_Maintain_Notice_Periods_for_Country_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Notice_Period_Eligibility_RulesOutput StaffingPort.Get_Notice_Period_Eligibility_Rules(Get_Notice_Period_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Notice_Period_Eligibility_Rules(request);
		}

		public Get_Notice_Period_Eligibility_Rules_ResponseType Get_Notice_Period_Eligibility_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Notice_Period_Eligibility_Rules_RequestType Get_Notice_Period_Eligibility_Rules_Request)
		{
			return ((StaffingPort)this).Get_Notice_Period_Eligibility_Rules(new Get_Notice_Period_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Notice_Period_Eligibility_Rules_Request = Get_Notice_Period_Eligibility_Rules_Request
			}).Get_Notice_Period_Eligibility_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Notice_Period_Eligibility_RulesOutput> StaffingPort.Get_Notice_Period_Eligibility_RulesAsync(Get_Notice_Period_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Notice_Period_Eligibility_RulesAsync(request);
		}

		public Task<Get_Notice_Period_Eligibility_RulesOutput> Get_Notice_Period_Eligibility_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Notice_Period_Eligibility_Rules_RequestType Get_Notice_Period_Eligibility_Rules_Request)
		{
			return ((StaffingPort)this).Get_Notice_Period_Eligibility_RulesAsync(new Get_Notice_Period_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Notice_Period_Eligibility_Rules_Request = Get_Notice_Period_Eligibility_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Maintain_Notice_Periods_For_CountryOutput StaffingPort.Get_Maintain_Notice_Periods_For_Country(Get_Maintain_Notice_Periods_For_CountryInput request)
		{
			return base.Channel.Get_Maintain_Notice_Periods_For_Country(request);
		}

		public Get_Maintain_Notice_Periods_For_Country_ResponseType Get_Maintain_Notice_Periods_For_Country(Workday_Common_HeaderType Workday_Common_Header, Get_Maintain_Notice_Periods_For_Country_RequestType Get_Maintain_Notice_Periods_For_Country_Request)
		{
			return ((StaffingPort)this).Get_Maintain_Notice_Periods_For_Country(new Get_Maintain_Notice_Periods_For_CountryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Maintain_Notice_Periods_For_Country_Request = Get_Maintain_Notice_Periods_For_Country_Request
			}).Get_Maintain_Notice_Periods_For_Country_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Maintain_Notice_Periods_For_CountryOutput> StaffingPort.Get_Maintain_Notice_Periods_For_CountryAsync(Get_Maintain_Notice_Periods_For_CountryInput request)
		{
			return base.Channel.Get_Maintain_Notice_Periods_For_CountryAsync(request);
		}

		public Task<Get_Maintain_Notice_Periods_For_CountryOutput> Get_Maintain_Notice_Periods_For_CountryAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Maintain_Notice_Periods_For_Country_RequestType Get_Maintain_Notice_Periods_For_Country_Request)
		{
			return ((StaffingPort)this).Get_Maintain_Notice_Periods_For_CountryAsync(new Get_Maintain_Notice_Periods_For_CountryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Maintain_Notice_Periods_For_Country_Request = Get_Maintain_Notice_Periods_For_Country_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Edit_Notice_Periods_EventOutput StaffingPort.Put_Edit_Notice_Periods_Event(Put_Edit_Notice_Periods_EventInput request)
		{
			return base.Channel.Put_Edit_Notice_Periods_Event(request);
		}

		public Put_Edit_Notice_Periods_Event_ResponseType Put_Edit_Notice_Periods_Event(Workday_Common_HeaderType Workday_Common_Header, Put_Edit_Notice_Periods_Event_RequestType Put_Edit_Notice_Periods_Event_Request)
		{
			return ((StaffingPort)this).Put_Edit_Notice_Periods_Event(new Put_Edit_Notice_Periods_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Edit_Notice_Periods_Event_Request = Put_Edit_Notice_Periods_Event_Request
			}).Put_Edit_Notice_Periods_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Edit_Notice_Periods_EventOutput> StaffingPort.Put_Edit_Notice_Periods_EventAsync(Put_Edit_Notice_Periods_EventInput request)
		{
			return base.Channel.Put_Edit_Notice_Periods_EventAsync(request);
		}

		public Task<Put_Edit_Notice_Periods_EventOutput> Put_Edit_Notice_Periods_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Edit_Notice_Periods_Event_RequestType Put_Edit_Notice_Periods_Event_Request)
		{
			return ((StaffingPort)this).Put_Edit_Notice_Periods_EventAsync(new Put_Edit_Notice_Periods_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Edit_Notice_Periods_Event_Request = Put_Edit_Notice_Periods_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Notice_PeriodsOutput StaffingPort.Get_Notice_Periods(Get_Notice_PeriodsInput request)
		{
			return base.Channel.Get_Notice_Periods(request);
		}

		public Get_Notice_Periods_for_Notice_Period_Target_ResponseType Get_Notice_Periods(Workday_Common_HeaderType Workday_Common_Header, Get_Notice_Periods_RequestType Get_Notice_Periods_Request)
		{
			return ((StaffingPort)this).Get_Notice_Periods(new Get_Notice_PeriodsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Notice_Periods_Request = Get_Notice_Periods_Request
			}).Get_Notice_Periods_for_Notice_Period_Target_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Notice_PeriodsOutput> StaffingPort.Get_Notice_PeriodsAsync(Get_Notice_PeriodsInput request)
		{
			return base.Channel.Get_Notice_PeriodsAsync(request);
		}

		public Task<Get_Notice_PeriodsOutput> Get_Notice_PeriodsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Notice_Periods_RequestType Get_Notice_Periods_Request)
		{
			return ((StaffingPort)this).Get_Notice_PeriodsAsync(new Get_Notice_PeriodsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Notice_Periods_Request = Get_Notice_Periods_Request
			});
		}
	}
}
