using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/External_Integrations", ConfigurationName = "External_IntegrationsService.External_IntegrationsPort")]
	public interface External_IntegrationsPort
	{
		[OperationContract(IsOneWay = true, Action = ""), ServiceKnownType(typeof(Launch_Integration_Event_DataType)), XmlSerializerFormat(SupportFaults = true)]
		void Receive_Launch_Integration_Event(Receive_Launch_Integration_EventInput request);

		[OperationContract(IsOneWay = true, Action = "")]
		Task Receive_Launch_Integration_EventAsync(Receive_Launch_Integration_EventInput request);
	}
}
