using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Campus_Engagement", ConfigurationName = "Campus_EngagementService.Campus_EngagementPort")]
	public interface Campus_EngagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Engagement_External_ItemsOutput Get_Engagement_External_Items(Get_Engagement_External_ItemsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Engagement_External_ItemsOutput> Get_Engagement_External_ItemsAsync(Get_Engagement_External_ItemsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Engagement_External_ItemOutput Put_Engagement_External_Item(Put_Engagement_External_ItemInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Engagement_External_ItemOutput> Put_Engagement_External_ItemAsync(Put_Engagement_External_ItemInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Engagement_ConversationOutput Put_Engagement_Conversation(Put_Engagement_ConversationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Engagement_ConversationOutput> Put_Engagement_ConversationAsync(Put_Engagement_ConversationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Engagement_ConversationsOutput Get_Engagement_Conversations(Get_Engagement_ConversationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Engagement_ConversationsOutput> Get_Engagement_ConversationsAsync(Get_Engagement_ConversationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Engagement_Conversation_TagOutput Put_Engagement_Conversation_Tag(Put_Engagement_Conversation_TagInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Engagement_Conversation_TagOutput> Put_Engagement_Conversation_TagAsync(Put_Engagement_Conversation_TagInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Engagement_Conversation_TagsOutput Get_Engagement_Conversation_Tags(Get_Engagement_Conversation_TagsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Engagement_Conversation_TagsOutput> Get_Engagement_Conversation_TagsAsync(Get_Engagement_Conversation_TagsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Engagement_RecordOutput Put_Engagement_Record(Put_Engagement_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Engagement_RecordOutput> Put_Engagement_RecordAsync(Put_Engagement_RecordInput request);
	}
}
