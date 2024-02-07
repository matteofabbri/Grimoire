using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Workday_Connect", ConfigurationName = "WorkdayConnect.Workday_ConnectPort")]
	public interface Workday_ConnectPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Message_TemplateOutput Put_Message_Template(Put_Message_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Message_TemplateOutput> Put_Message_TemplateAsync(Put_Message_TemplateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Message_TemplateOutput Get_Message_Template(Get_Message_TemplateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Message_TemplateOutput> Get_Message_TemplateAsync(Get_Message_TemplateInput request);
	}
}
