using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Staffing", ConfigurationName = "Staffing.StaffingPort")]
	public interface StaffingPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Terminate_EmployeeOutput Terminate_Employee(Terminate_EmployeeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Terminate_EmployeeOutput> Terminate_EmployeeAsync(Terminate_EmployeeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_WorkersOutput Get_Workers(Get_WorkersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_WorkersOutput> Get_WorkersAsync(Get_WorkersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_PositionOutput Edit_Position(Edit_PositionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_PositionOutput> Edit_PositionAsync(Edit_PositionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Hire_EmployeeOutput Hire_Employee(Hire_EmployeeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Hire_EmployeeOutput> Hire_EmployeeAsync(Hire_EmployeeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ApplicantsOutput Get_Applicants(Get_ApplicantsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ApplicantsOutput> Get_ApplicantsAsync(Get_ApplicantsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_OrganizationOutput Assign_Organization(Assign_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_OrganizationOutput> Assign_OrganizationAsync(Assign_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ApplicantOutput Put_Applicant(Put_ApplicantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ApplicantOutput> Put_ApplicantAsync(Put_ApplicantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Contingent_Worker_ContractOutput End_Contingent_Worker_Contract(End_Contingent_Worker_ContractInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Contingent_Worker_ContractOutput> End_Contingent_Worker_ContractAsync(End_Contingent_Worker_ContractInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Contract_Contingent_WorkerOutput Contract_Contingent_Worker(Contract_Contingent_WorkerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Contract_Contingent_WorkerOutput> Contract_Contingent_WorkerAsync(Contract_Contingent_WorkerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DependentOutput Put_Dependent(Put_DependentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DependentOutput> Put_DependentAsync(Put_DependentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_PositionOutput Create_Position(Create_PositionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_PositionOutput> Create_PositionAsync(Create_PositionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PositionsOutput Get_Positions(Get_PositionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PositionsOutput> Get_PositionsAsync(Get_PositionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Service_DatesOutput Edit_Service_Dates(Edit_Service_DatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Service_DatesOutput> Edit_Service_DatesAsync(Edit_Service_DatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrganizationsOutput Get_Organizations(Get_OrganizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Get_OrganizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Additional_JobOutput End_Additional_Job(End_Additional_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Additional_JobOutput> End_Additional_JobAsync(End_Additional_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Additional_JobOutput Add_Additional_Job(Add_Additional_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Additional_JobOutput> Add_Additional_JobAsync(Add_Additional_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Retiree_StatusOutput Add_Retiree_Status(Add_Retiree_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Retiree_StatusOutput> Add_Retiree_StatusAsync(Add_Retiree_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Remove_Retiree_StatusOutput Remove_Retiree_Status(Remove_Retiree_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Remove_Retiree_StatusOutput> Remove_Retiree_StatusAsync(Remove_Retiree_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Maintain_Employee_ContractsOutput Maintain_Employee_Contracts(Maintain_Employee_ContractsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Maintain_Employee_ContractsOutput> Maintain_Employee_ContractsAsync(Maintain_Employee_ContractsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Citizenship_StatusesOutput Get_Citizenship_Statuses(Get_Citizenship_StatusesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Citizenship_StatusesOutput> Get_Citizenship_StatusesAsync(Get_Citizenship_StatusesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Citizenship_StatusOutput Put_Citizenship_Status(Put_Citizenship_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Citizenship_StatusOutput> Put_Citizenship_StatusAsync(Put_Citizenship_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Position_RestrictionsOutput Edit_Position_Restrictions(Edit_Position_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Position_RestrictionsOutput> Edit_Position_RestrictionsAsync(Edit_Position_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Classification_GroupsOutput Get_Job_Classification_Groups(Get_Job_Classification_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Classification_GroupsOutput> Get_Job_Classification_GroupsAsync(Get_Job_Classification_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Classification_GroupOutput Put_Job_Classification_Group(Put_Job_Classification_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Classification_GroupOutput> Put_Job_Classification_GroupAsync(Put_Job_Classification_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_FamiliesOutput Get_Job_Families(Get_Job_FamiliesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_FamiliesOutput> Get_Job_FamiliesAsync(Get_Job_FamiliesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_FamilyOutput Put_Job_Family(Put_Job_FamilyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_FamilyOutput> Put_Job_FamilyAsync(Put_Job_FamilyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Family_GroupsOutput Get_Job_Family_Groups(Get_Job_Family_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Family_GroupsOutput> Get_Job_Family_GroupsAsync(Get_Job_Family_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Family_GroupOutput Put_Job_Family_Group(Put_Job_Family_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Family_GroupOutput> Put_Job_Family_GroupAsync(Put_Job_Family_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Start_International_AssignmentOutput Start_International_Assignment(Start_International_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Start_International_AssignmentOutput> Start_International_AssignmentAsync(Start_International_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_International_AssignmentOutput End_International_Assignment(End_International_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_International_AssignmentOutput> End_International_AssignmentAsync(End_International_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Organization_RolesOutput Assign_Organization_Roles(Assign_Organization_RolesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Organization_RolesOutput> Assign_Organization_RolesAsync(Assign_Organization_RolesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Worker_DocumentOutput Put_Worker_Document(Put_Worker_DocumentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Worker_DocumentOutput> Put_Worker_DocumentAsync(Put_Worker_DocumentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_DocumentsOutput Get_Worker_Documents(Get_Worker_DocumentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_DocumentsOutput> Get_Worker_DocumentsAsync(Get_Worker_DocumentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_JobOutput Change_Job(Change_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_JobOutput> Change_JobAsync(Change_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Switch_Primary_JobOutput Switch_Primary_Job(Switch_Primary_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Switch_Primary_JobOutput> Switch_Primary_JobAsync(Switch_Primary_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Close_PositionOutput Close_Position(Close_PositionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Close_PositionOutput> Close_PositionAsync(Close_PositionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Set_Hiring_RestrictionsOutput Set_Hiring_Restrictions(Set_Hiring_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Set_Hiring_RestrictionsOutput> Set_Hiring_RestrictionsAsync(Set_Hiring_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Hiring_RestrictionsOutput Edit_Hiring_Restrictions(Edit_Hiring_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Hiring_RestrictionsOutput> Edit_Hiring_RestrictionsAsync(Edit_Hiring_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Hire_Event_Proposed_Worker_IDOutput Put_Hire_Event_Proposed_Worker_ID(Put_Hire_Event_Proposed_Worker_IDInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Hire_Event_Proposed_Worker_IDOutput> Put_Hire_Event_Proposed_Worker_IDAsync(Put_Hire_Event_Proposed_Worker_IDInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Worker_Additional_DataOutput Edit_Worker_Additional_Data(Edit_Worker_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Worker_Additional_DataOutput> Edit_Worker_Additional_DataAsync(Edit_Worker_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Position_Restrictions_Additional_DataOutput Edit_Position_Restrictions_Additional_Data(Edit_Position_Restrictions_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Position_Restrictions_Additional_DataOutput> Edit_Position_Restrictions_Additional_DataAsync(Edit_Position_Restrictions_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Move_Workers_By_OrganizationOutput Move_Workers_By_Organization(Move_Workers_By_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Move_Workers_By_OrganizationOutput> Move_Workers_By_OrganizationAsync(Move_Workers_By_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Organization_AssignmentsOutput Change_Organization_Assignments(Change_Organization_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Organization_AssignmentsOutput> Change_Organization_AssignmentsAsync(Change_Organization_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_RolesOutput Assign_Roles(Assign_RolesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_RolesOutput> Assign_RolesAsync(Assign_RolesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Employment_Eligibility_StatusOutput Put_Student_Employment_Eligibility_Status(Put_Student_Employment_Eligibility_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Employment_Eligibility_StatusOutput> Put_Student_Employment_Eligibility_StatusAsync(Put_Student_Employment_Eligibility_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Employment_Eligibility_DataOutput Get_Student_Employment_Eligibility_Data(Get_Student_Employment_Eligibility_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Employment_Eligibility_DataOutput> Get_Student_Employment_Eligibility_DataAsync(Get_Student_Employment_Eligibility_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Notice_Period_Eligibility_RuleOutput Put_Notice_Period_Eligibility_Rule(Put_Notice_Period_Eligibility_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Notice_Period_Eligibility_RuleOutput> Put_Notice_Period_Eligibility_RuleAsync(Put_Notice_Period_Eligibility_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Maintain_Notice_Periods_for_CountryOutput Put_Maintain_Notice_Periods_for_Country(Put_Maintain_Notice_Periods_for_CountryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Maintain_Notice_Periods_for_CountryOutput> Put_Maintain_Notice_Periods_for_CountryAsync(Put_Maintain_Notice_Periods_for_CountryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Notice_Period_Eligibility_RulesOutput Get_Notice_Period_Eligibility_Rules(Get_Notice_Period_Eligibility_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Notice_Period_Eligibility_RulesOutput> Get_Notice_Period_Eligibility_RulesAsync(Get_Notice_Period_Eligibility_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Maintain_Notice_Periods_For_CountryOutput Get_Maintain_Notice_Periods_For_Country(Get_Maintain_Notice_Periods_For_CountryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Maintain_Notice_Periods_For_CountryOutput> Get_Maintain_Notice_Periods_For_CountryAsync(Get_Maintain_Notice_Periods_For_CountryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Edit_Notice_Periods_EventOutput Put_Edit_Notice_Periods_Event(Put_Edit_Notice_Periods_EventInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Edit_Notice_Periods_EventOutput> Put_Edit_Notice_Periods_EventAsync(Put_Edit_Notice_Periods_EventInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Notice_PeriodsOutput Get_Notice_Periods(Get_Notice_PeriodsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Notice_PeriodsOutput> Get_Notice_PeriodsAsync(Get_Notice_PeriodsInput request);
	}
}
