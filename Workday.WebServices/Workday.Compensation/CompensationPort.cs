using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Compensation", ConfigurationName = "CompensationService.CompensationPort")]
	public interface CompensationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Previous_System_Compensation_HistoryOutput Put_Previous_System_Compensation_History(Put_Previous_System_Compensation_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Previous_System_Compensation_HistoryOutput> Put_Previous_System_Compensation_HistoryAsync(Put_Previous_System_Compensation_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Previous_System_Compensation_HistoryOutput Get_Previous_System_Compensation_History(Get_Previous_System_Compensation_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Previous_System_Compensation_HistoryOutput> Get_Previous_System_Compensation_HistoryAsync(Get_Previous_System_Compensation_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Bonus_PaymentOutput Request_Bonus_Payment(Request_Bonus_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Bonus_PaymentOutput> Request_Bonus_PaymentAsync(Request_Bonus_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Employee_Merit_AdjustmentOutput Request_Employee_Merit_Adjustment(Request_Employee_Merit_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Employee_Merit_AdjustmentOutput> Request_Employee_Merit_AdjustmentAsync(Request_Employee_Merit_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_OneTime_PaymentOutput Request_OneTime_Payment(Request_OneTime_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_OneTime_PaymentOutput> Request_OneTime_PaymentAsync(Request_OneTime_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Compensation_ChangeOutput Request_Compensation_Change(Request_Compensation_ChangeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Compensation_ChangeOutput> Request_Compensation_ChangeAsync(Request_Compensation_ChangeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Eligible_EarningsOutput Put_Eligible_Earnings(Put_Eligible_EarningsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Eligible_EarningsOutput> Put_Eligible_EarningsAsync(Put_Eligible_EarningsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Eligible_EarningsOutput Get_Eligible_Earnings(Get_Eligible_EarningsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Eligible_EarningsOutput> Get_Eligible_EarningsAsync(Get_Eligible_EarningsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_MatricesOutput Get_Compensation_Matrices(Get_Compensation_MatricesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_MatricesOutput> Get_Compensation_MatricesAsync(Get_Compensation_MatricesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_MatrixOutput Put_Compensation_Matrix(Put_Compensation_MatrixInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_MatrixOutput> Put_Compensation_MatrixAsync(Put_Compensation_MatrixInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_GradesOutput Get_Compensation_Grades(Get_Compensation_GradesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_GradesOutput> Get_Compensation_GradesAsync(Get_Compensation_GradesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_GradeOutput Put_Compensation_Grade(Put_Compensation_GradeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_GradeOutput> Put_Compensation_GradeAsync(Put_Compensation_GradeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_PlansOutput Get_Compensation_Plans(Get_Compensation_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_PlansOutput> Get_Compensation_PlansAsync(Get_Compensation_PlansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_PlansOutput Put_Compensation_Plans(Put_Compensation_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_PlansOutput> Put_Compensation_PlansAsync(Put_Compensation_PlansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Future_Payment_Plan_AssignmentsOutput Get_Future_Payment_Plan_Assignments(Get_Future_Payment_Plan_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Future_Payment_Plan_AssignmentsOutput> Get_Future_Payment_Plan_AssignmentsAsync(Get_Future_Payment_Plan_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Future_Payment_Plan_AssignmentOutput Put_Future_Payment_Plan_Assignment(Put_Future_Payment_Plan_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Future_Payment_Plan_AssignmentOutput> Put_Future_Payment_Plan_AssignmentAsync(Put_Future_Payment_Plan_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_ScorecardsOutput Get_Compensation_Scorecards(Get_Compensation_ScorecardsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_ScorecardsOutput> Get_Compensation_ScorecardsAsync(Get_Compensation_ScorecardsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_ScorecardOutput Put_Compensation_Scorecard(Put_Compensation_ScorecardInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_ScorecardOutput> Put_Compensation_ScorecardAsync(Put_Compensation_ScorecardInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Benchmark_JobOutput Put_Benchmark_Job(Put_Benchmark_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Benchmark_JobOutput> Put_Benchmark_JobAsync(Put_Benchmark_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Benchmark_JobsOutput Get_Benchmark_Jobs(Get_Benchmark_JobsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Benchmark_JobsOutput> Get_Benchmark_JobsAsync(Get_Benchmark_JobsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Stock_GrantOutput Update_Stock_Grant(Update_Stock_GrantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Stock_GrantOutput> Update_Stock_GrantAsync(Update_Stock_GrantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Stock_GrantOutput Add_Stock_Grant(Add_Stock_GrantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Stock_GrantOutput> Add_Stock_GrantAsync(Add_Stock_GrantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_Eligibility_RuleOutput Put_Compensation_Eligibility_Rule(Put_Compensation_Eligibility_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_Eligibility_RuleOutput> Put_Compensation_Eligibility_RuleAsync(Put_Compensation_Eligibility_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_Eligibility_RulesOutput Get_Compensation_Eligibility_Rules(Get_Compensation_Eligibility_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_Eligibility_RulesOutput> Get_Compensation_Eligibility_RulesAsync(Get_Compensation_Eligibility_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_Eligibility_RulesOutput Get_Compensation_Eligibility_Rules_without_Dependencies(Get_Compensation_Eligibility_Rules_without_DependenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_Eligibility_RulesOutput> Get_Compensation_Eligibility_Rules_without_DependenciesAsync(Get_Compensation_Eligibility_Rules_without_DependenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Compensation_Scorecard_ResultOutput Put_Compensation_Scorecard_Result(Put_Compensation_Scorecard_ResultInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Compensation_Scorecard_ResultOutput> Put_Compensation_Scorecard_ResultAsync(Put_Compensation_Scorecard_ResultInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Compensation_Scorecard_ResultsOutput Get_Compensation_Scorecard_Results(Get_Compensation_Scorecard_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Compensation_Scorecard_ResultsOutput> Get_Compensation_Scorecard_ResultsAsync(Get_Compensation_Scorecard_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Launch_Employee_Severance_WorksheetOutput Launch_Employee_Severance_Worksheet(Launch_Employee_Severance_WorksheetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Launch_Employee_Severance_WorksheetOutput> Launch_Employee_Severance_WorksheetAsync(Launch_Employee_Severance_WorksheetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Period_Activity_TasksOutput Get_Period_Activity_Tasks(Get_Period_Activity_TasksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Period_Activity_TasksOutput> Get_Period_Activity_TasksAsync(Get_Period_Activity_TasksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Period_Activity_TaskOutput Put_Period_Activity_Task(Put_Period_Activity_TaskInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Period_Activity_TaskOutput> Put_Period_Activity_TaskAsync(Put_Period_Activity_TaskInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Eligible_Period_Activities_for_EmployeeOutput Assign_Eligible_Period_Activities_for_Employee(Assign_Eligible_Period_Activities_for_EmployeeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Eligible_Period_Activities_for_EmployeeOutput> Assign_Eligible_Period_Activities_for_EmployeeAsync(Assign_Eligible_Period_Activities_for_EmployeeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Period_Activity_Rate_MatrixOutput Put_Period_Activity_Rate_Matrix(Put_Period_Activity_Rate_MatrixInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Period_Activity_Rate_MatrixOutput> Put_Period_Activity_Rate_MatrixAsync(Put_Period_Activity_Rate_MatrixInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Period_Activity_Rate_MatricesOutput Get_Period_Activity_Rate_Matrices(Get_Period_Activity_Rate_MatricesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Period_Activity_Rate_MatricesOutput> Get_Period_Activity_Rate_MatricesAsync(Get_Period_Activity_Rate_MatricesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Period_Activity_Pay_AssignmentsOutput Manage_Period_Activity_Pay_Assignments(Manage_Period_Activity_Pay_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Period_Activity_Pay_AssignmentsOutput> Manage_Period_Activity_Pay_AssignmentsAsync(Manage_Period_Activity_Pay_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Stock_Participation_Rate_TableOutput Put_Stock_Participation_Rate_Table(Put_Stock_Participation_Rate_TableInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Stock_Participation_Rate_TableOutput> Put_Stock_Participation_Rate_TableAsync(Put_Stock_Participation_Rate_TableInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Stock_Participation_Rate_TablesOutput Get_Stock_Participation_Rate_Tables(Get_Stock_Participation_Rate_TablesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Stock_Participation_Rate_TablesOutput> Get_Stock_Participation_Rate_TablesAsync(Get_Stock_Participation_Rate_TablesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OneTime_Payment_Plan_Configurable_CategoriesOutput Get_OneTime_Payment_Plan_Configurable_Categories(Get_OneTime_Payment_Plan_Configurable_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OneTime_Payment_Plan_Configurable_CategoriesOutput> Get_OneTime_Payment_Plan_Configurable_CategoriesAsync(Get_OneTime_Payment_Plan_Configurable_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_OneTime_Payment_Plan_Configurable_CategoryOutput Put_OneTime_Payment_Plan_Configurable_Category(Put_OneTime_Payment_Plan_Configurable_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_OneTime_Payment_Plan_Configurable_CategoryOutput> Put_OneTime_Payment_Plan_Configurable_CategoryAsync(Put_OneTime_Payment_Plan_Configurable_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Requisition_Compensation_ChangeOutput Request_Requisition_Compensation_Change(Request_Requisition_Compensation_ChangeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Requisition_Compensation_ChangeOutput> Request_Requisition_Compensation_ChangeAsync(Request_Requisition_Compensation_ChangeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Eligible_Earnings_OverrideOutput Import_Eligible_Earnings_Override(Import_Eligible_Earnings_OverrideInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Eligible_Earnings_OverrideOutput> Import_Eligible_Earnings_OverrideAsync(Import_Eligible_Earnings_OverrideInput request);
	}
}
