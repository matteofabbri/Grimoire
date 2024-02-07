using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Workday_Extensibility", ConfigurationName = "WorkdayExtensibility.Workday_ExtensibilityPort")]
	public interface Workday_ExtensibilityPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Custom_ListsOutput Get_Custom_Lists(Get_Custom_ListsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Custom_ListsOutput> Get_Custom_ListsAsync(Get_Custom_ListsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Custom_ListOutput Put_Custom_List(Put_Custom_ListInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Custom_ListOutput> Put_Custom_ListAsync(Put_Custom_ListInput request);
	}
}
