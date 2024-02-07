using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Payroll_Interface", ConfigurationName = "Payroll.Interface.Payroll_InterfacePort")]
	public interface Payroll_InterfacePort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PayeesOutput Get_Payees(Get_PayeesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PayeesOutput> Get_PayeesAsync(Get_PayeesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Payroll_InputOutput Put_External_Payroll_Input(Put_External_Payroll_InputInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Payroll_InputOutput> Put_External_Payroll_InputAsync(Put_External_Payroll_InputInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_External_Pay_GroupsOutput Get_External_Pay_Groups(Get_External_Pay_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_External_Pay_GroupsOutput> Get_External_Pay_GroupsAsync(Get_External_Pay_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_BatchesOutput Get_Batches(Get_BatchesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_BatchesOutput> Get_BatchesAsync(Get_BatchesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_BatchOutput Put_Batch(Put_BatchInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_BatchOutput> Put_BatchAsync(Put_BatchInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_External_Payroll_InputsOutput Get_External_Payroll_Inputs(Get_External_Payroll_InputsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_External_Payroll_InputsOutput> Get_External_Payroll_InputsAsync(Get_External_Payroll_InputsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Payroll_ActualsOutput Put_External_Payroll_Actuals(Put_External_Payroll_ActualsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Payroll_ActualsOutput> Put_External_Payroll_ActualsAsync(Put_External_Payroll_ActualsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Period_SchedulesOutput Get_Period_Schedules(Get_Period_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Period_SchedulesOutput> Get_Period_SchedulesAsync(Get_Period_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Period_ScheduleOutput Put_Period_Schedule(Put_Period_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Period_ScheduleOutput> Put_Period_ScheduleAsync(Put_Period_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Payroll_ResultsOutput Put_External_Payroll_Results(Put_External_Payroll_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Payroll_ResultsOutput> Put_External_Payroll_ResultsAsync(Put_External_Payroll_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Pay_GroupOutput Put_External_Pay_Group(Put_External_Pay_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Pay_GroupOutput> Put_External_Pay_GroupAsync(Put_External_Pay_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_Costing_AllocationsOutput Get_Worker_Costing_Allocations(Get_Worker_Costing_AllocationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_Costing_AllocationsOutput> Get_Worker_Costing_AllocationsAsync(Get_Worker_Costing_AllocationsInput request);
	}
}
