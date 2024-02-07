using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Time_Tracking", ConfigurationName = "TimeTrackingService.Time_TrackingPort")]
	public interface Time_TrackingPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Time_Clock_EventsOutput Put_Time_Clock_Events(Put_Time_Clock_EventsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Time_Clock_EventsOutput> Put_Time_Clock_EventsAsync(Put_Time_Clock_EventsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Work_ScheduleOutput Assign_Work_Schedule(Assign_Work_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Work_ScheduleOutput> Assign_Work_ScheduleAsync(Assign_Work_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Reported_Time_BlocksOutput Import_Reported_Time_Blocks(Import_Reported_Time_BlocksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Reported_Time_BlocksOutput> Import_Reported_Time_BlocksAsync(Import_Reported_Time_BlocksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Reported_Time_BlocksOutput Import_Time_Clock_Events(Import_Time_Clock_EventsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Reported_Time_BlocksOutput> Import_Time_Clock_EventsAsync(Import_Time_Clock_EventsInput request);
	}
}
