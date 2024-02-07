using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Absence_Management", ConfigurationName = "Absence_ManagementService.Absence_ManagementPort")]
	public interface Absence_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Adjust_Time_OffOutput Adjust_Time_Off(Adjust_Time_OffInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Adjust_Time_OffOutput> Adjust_Time_OffAsync(Adjust_Time_OffInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Adjust_Time_OffOutput Enter_Time_Off(Enter_Time_OffInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Adjust_Time_OffOutput> Enter_Time_OffAsync(Enter_Time_OffInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Absence_InputOutput Put_Absence_Input(Put_Absence_InputInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Absence_InputOutput> Put_Absence_InputAsync(Put_Absence_InputInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Absence_InputsOutput Get_Absence_Inputs(Get_Absence_InputsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Absence_InputsOutput> Get_Absence_InputsAsync(Get_Absence_InputsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Leave_of_AbsenceOutput Request_Leave_of_Absence(Request_Leave_of_AbsenceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Leave_of_AbsenceOutput> Request_Leave_of_AbsenceAsync(Request_Leave_of_AbsenceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Request_Return_from_Leave_of_AbsenceOutput Request_Return_from_Leave_of_Absence(Request_Return_from_Leave_of_AbsenceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Request_Return_from_Leave_of_AbsenceOutput> Request_Return_from_Leave_of_AbsenceAsync(Request_Return_from_Leave_of_AbsenceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Override_BalancesOutput Get_Override_Balances(Get_Override_BalancesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Override_BalancesOutput> Get_Override_BalancesAsync(Get_Override_BalancesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Override_BalanceOutput Put_Override_Balance(Put_Override_BalanceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Override_BalanceOutput> Put_Override_BalanceAsync(Put_Override_BalanceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Time_Off_Plan_BalancesOutput Get_Time_Off_Plan_Balances(Get_Time_Off_Plan_BalancesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Time_Off_Plan_BalancesOutput> Get_Time_Off_Plan_BalancesAsync(Get_Time_Off_Plan_BalancesInput request);
	}
}
