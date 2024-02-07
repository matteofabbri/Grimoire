using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Campus_EngagementPortClient : ClientBase<Campus_EngagementPort>, Campus_EngagementPort
	{
		public Campus_EngagementPortClient()
		{
		}

		public Campus_EngagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Campus_EngagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Campus_EngagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Campus_EngagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Engagement_External_ItemsOutput Campus_EngagementPort.Get_Engagement_External_Items(Get_Engagement_External_ItemsInput request)
		{
			return base.Channel.Get_Engagement_External_Items(request);
		}

		public Get_Engagement_External_Items_ResponseType Get_Engagement_External_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_External_Items_RequestType Get_Engagement_External_Items_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_External_Items(new Get_Engagement_External_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_External_Items_Request = Get_Engagement_External_Items_Request
			}).Get_Engagement_External_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Engagement_External_ItemsOutput> Campus_EngagementPort.Get_Engagement_External_ItemsAsync(Get_Engagement_External_ItemsInput request)
		{
			return base.Channel.Get_Engagement_External_ItemsAsync(request);
		}

		public Task<Get_Engagement_External_ItemsOutput> Get_Engagement_External_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_External_Items_RequestType Get_Engagement_External_Items_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_External_ItemsAsync(new Get_Engagement_External_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_External_Items_Request = Get_Engagement_External_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Engagement_External_ItemOutput Campus_EngagementPort.Put_Engagement_External_Item(Put_Engagement_External_ItemInput request)
		{
			return base.Channel.Put_Engagement_External_Item(request);
		}

		public Put_Engagement_External_Item_ResponseType Put_Engagement_External_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_External_Item_RequestType Put_Engagement_External_Item_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_External_Item(new Put_Engagement_External_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_External_Item_Request = Put_Engagement_External_Item_Request
			}).Put_Engagement_External_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Engagement_External_ItemOutput> Campus_EngagementPort.Put_Engagement_External_ItemAsync(Put_Engagement_External_ItemInput request)
		{
			return base.Channel.Put_Engagement_External_ItemAsync(request);
		}

		public Task<Put_Engagement_External_ItemOutput> Put_Engagement_External_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_External_Item_RequestType Put_Engagement_External_Item_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_External_ItemAsync(new Put_Engagement_External_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_External_Item_Request = Put_Engagement_External_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Engagement_ConversationOutput Campus_EngagementPort.Put_Engagement_Conversation(Put_Engagement_ConversationInput request)
		{
			return base.Channel.Put_Engagement_Conversation(request);
		}

		public Put_Engagement_Conversation_ResponseType Put_Engagement_Conversation(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Conversation_RequestType Put_Engagement_Conversation_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_Conversation(new Put_Engagement_ConversationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Conversation_Request = Put_Engagement_Conversation_Request
			}).Put_Engagement_Conversation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Engagement_ConversationOutput> Campus_EngagementPort.Put_Engagement_ConversationAsync(Put_Engagement_ConversationInput request)
		{
			return base.Channel.Put_Engagement_ConversationAsync(request);
		}

		public Task<Put_Engagement_ConversationOutput> Put_Engagement_ConversationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Conversation_RequestType Put_Engagement_Conversation_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_ConversationAsync(new Put_Engagement_ConversationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Conversation_Request = Put_Engagement_Conversation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Engagement_ConversationsOutput Campus_EngagementPort.Get_Engagement_Conversations(Get_Engagement_ConversationsInput request)
		{
			return base.Channel.Get_Engagement_Conversations(request);
		}

		public Get_Engagement_Conversations_ResponseType Get_Engagement_Conversations(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_Conversations_RequestType Get_Engagement_Conversations_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_Conversations(new Get_Engagement_ConversationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_Conversations_Request = Get_Engagement_Conversations_Request
			}).Get_Engagement_Conversations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Engagement_ConversationsOutput> Campus_EngagementPort.Get_Engagement_ConversationsAsync(Get_Engagement_ConversationsInput request)
		{
			return base.Channel.Get_Engagement_ConversationsAsync(request);
		}

		public Task<Get_Engagement_ConversationsOutput> Get_Engagement_ConversationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_Conversations_RequestType Get_Engagement_Conversations_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_ConversationsAsync(new Get_Engagement_ConversationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_Conversations_Request = Get_Engagement_Conversations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Engagement_Conversation_TagOutput Campus_EngagementPort.Put_Engagement_Conversation_Tag(Put_Engagement_Conversation_TagInput request)
		{
			return base.Channel.Put_Engagement_Conversation_Tag(request);
		}

		public Put_Engagement_Conversation_Tag_ResponseType Put_Engagement_Conversation_Tag(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Conversation_Tag_RequestType Put_Engagement_Conversation_Tag_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_Conversation_Tag(new Put_Engagement_Conversation_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Conversation_Tag_Request = Put_Engagement_Conversation_Tag_Request
			}).Put_Engagement_Conversation_Tag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Engagement_Conversation_TagOutput> Campus_EngagementPort.Put_Engagement_Conversation_TagAsync(Put_Engagement_Conversation_TagInput request)
		{
			return base.Channel.Put_Engagement_Conversation_TagAsync(request);
		}

		public Task<Put_Engagement_Conversation_TagOutput> Put_Engagement_Conversation_TagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Conversation_Tag_RequestType Put_Engagement_Conversation_Tag_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_Conversation_TagAsync(new Put_Engagement_Conversation_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Conversation_Tag_Request = Put_Engagement_Conversation_Tag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Engagement_Conversation_TagsOutput Campus_EngagementPort.Get_Engagement_Conversation_Tags(Get_Engagement_Conversation_TagsInput request)
		{
			return base.Channel.Get_Engagement_Conversation_Tags(request);
		}

		public Get_Engagement_Conversation_Tags_ResponseType Get_Engagement_Conversation_Tags(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_Conversation_Tags_RequestType Get_Engagement_Conversation_Tags_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_Conversation_Tags(new Get_Engagement_Conversation_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_Conversation_Tags_Request = Get_Engagement_Conversation_Tags_Request
			}).Get_Engagement_Conversation_Tags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Engagement_Conversation_TagsOutput> Campus_EngagementPort.Get_Engagement_Conversation_TagsAsync(Get_Engagement_Conversation_TagsInput request)
		{
			return base.Channel.Get_Engagement_Conversation_TagsAsync(request);
		}

		public Task<Get_Engagement_Conversation_TagsOutput> Get_Engagement_Conversation_TagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Engagement_Conversation_Tags_RequestType Get_Engagement_Conversation_Tags_Request)
		{
			return ((Campus_EngagementPort)this).Get_Engagement_Conversation_TagsAsync(new Get_Engagement_Conversation_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Engagement_Conversation_Tags_Request = Get_Engagement_Conversation_Tags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Engagement_RecordOutput Campus_EngagementPort.Put_Engagement_Record(Put_Engagement_RecordInput request)
		{
			return base.Channel.Put_Engagement_Record(request);
		}

		public Put_Engagement_Record_ResponseType Put_Engagement_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Record_RequestType Put_Engagement_Record_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_Record(new Put_Engagement_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Record_Request = Put_Engagement_Record_Request
			}).Put_Engagement_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Engagement_RecordOutput> Campus_EngagementPort.Put_Engagement_RecordAsync(Put_Engagement_RecordInput request)
		{
			return base.Channel.Put_Engagement_RecordAsync(request);
		}

		public Task<Put_Engagement_RecordOutput> Put_Engagement_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Record_RequestType Put_Engagement_Record_Request)
		{
			return ((Campus_EngagementPort)this).Put_Engagement_RecordAsync(new Put_Engagement_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Engagement_Record_Request = Put_Engagement_Record_Request
			});
		}
	}
}
