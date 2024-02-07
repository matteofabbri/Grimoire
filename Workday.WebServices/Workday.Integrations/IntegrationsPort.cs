using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Integrations", ConfigurationName = "IntegrationsService.IntegrationsPort")]
	public interface IntegrationsPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Integration_SystemsOutput Get_Integration_Systems(Get_Integration_SystemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Integration_SystemsOutput> Get_Integration_SystemsAsync(Get_Integration_SystemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_MessageOutput Put_Integration_Message(Put_Integration_MessageInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_MessageOutput> Put_Integration_MessageAsync(Put_Integration_MessageInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_EventOutput Put_Integration_Event(Put_Integration_EventInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_EventOutput> Put_Integration_EventAsync(Put_Integration_EventInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Event_DetailOutput Get_Event_Detail(Get_Event_DetailInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Event_DetailOutput> Get_Event_DetailAsync(Get_Event_DetailInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Sequence_GeneratorsOutput Get_Sequence_Generators(Get_Sequence_GeneratorsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Sequence_GeneratorsOutput> Get_Sequence_GeneratorsAsync(Get_Sequence_GeneratorsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Sequence_GeneratorOutput Put_Sequence_Generator(Put_Sequence_GeneratorInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Sequence_GeneratorOutput> Put_Sequence_GeneratorAsync(Put_Sequence_GeneratorInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Increment_Sequence_GeneratorOutput Increment_Sequence_Generator(Increment_Sequence_GeneratorInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Increment_Sequence_GeneratorOutput> Increment_Sequence_GeneratorAsync(Increment_Sequence_GeneratorInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_SystemOutput Put_Integration_System(Put_Integration_SystemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_SystemOutput> Put_Integration_SystemAsync(Put_Integration_SystemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Integration_EventsOutput Get_Integration_Events(Get_Integration_EventsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Integration_EventsOutput> Get_Integration_EventsAsync(Get_Integration_EventsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Business_ProcessOutput Cancel_Business_Process(Cancel_Business_ProcessInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Business_ProcessOutput> Cancel_Business_ProcessAsync(Cancel_Business_ProcessInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Launch_IntegrationOutput Launch_Integration(Launch_IntegrationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Launch_IntegrationOutput> Launch_IntegrationAsync(Launch_IntegrationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Rescind_Business_ProcessOutput Rescind_Business_Process(Rescind_Business_ProcessInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Rescind_Business_ProcessOutput> Rescind_Business_ProcessAsync(Rescind_Business_ProcessInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Integration_System_UsersOutput Get_Integration_System_Users(Get_Integration_System_UsersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Integration_System_UsersOutput> Get_Integration_System_UsersAsync(Get_Integration_System_UsersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Integration_System_UserOutput Put_Integration_System_User(Put_Integration_System_UserInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Integration_System_UserOutput> Put_Integration_System_UserAsync(Put_Integration_System_UserInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SubscriptionsOutput Get_Subscriptions(Get_SubscriptionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SubscriptionsOutput> Get_SubscriptionsAsync(Get_SubscriptionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SubscriptionOutput Put_Subscription(Put_SubscriptionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SubscriptionOutput> Put_SubscriptionAsync(Put_SubscriptionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Launch_EIBOutput Launch_EIB(Launch_EIBInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Launch_EIBOutput> Launch_EIBAsync(Launch_EIBInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ReferencesOutput Get_References(Get_ReferencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ReferencesOutput> Get_ReferencesAsync(Get_ReferencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Event_DocumentsOutput Get_Event_Documents(Get_Event_DocumentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Event_DocumentsOutput> Get_Event_DocumentsAsync(Get_Event_DocumentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ReferenceOutput Put_Reference(Put_ReferenceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ReferenceOutput> Put_ReferenceAsync(Put_ReferenceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Approve_Business_ProcessOutput Approve_Business_Process(Approve_Business_ProcessInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Approve_Business_ProcessOutput> Approve_Business_ProcessAsync(Approve_Business_ProcessInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Deny_Business_ProcessOutput Deny_Business_Process(Deny_Business_ProcessInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Deny_Business_ProcessOutput> Deny_Business_ProcessAsync(Deny_Business_ProcessInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Import_Process_MessagesOutput Get_Import_Process_Messages(Get_Import_Process_MessagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Import_Process_MessagesOutput> Get_Import_Process_MessagesAsync(Get_Import_Process_MessagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Import_ProcessesOutput Get_Import_Processes(Get_Import_ProcessesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Import_ProcessesOutput> Get_Import_ProcessesAsync(Get_Import_ProcessesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Reassign_Business_Process_StepOutput Reassign_Business_Process_Step(Reassign_Business_Process_StepInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Reassign_Business_Process_StepOutput> Reassign_Business_Process_StepAsync(Reassign_Business_Process_StepInput request);
	}
}
