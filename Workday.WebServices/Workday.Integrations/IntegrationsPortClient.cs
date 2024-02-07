using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class IntegrationsPortClient : ClientBase<IntegrationsPort>, IntegrationsPort
	{
		public IntegrationsPortClient()
		{
		}

		public IntegrationsPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public IntegrationsPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public IntegrationsPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public IntegrationsPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Integration_SystemsOutput IntegrationsPort.Get_Integration_Systems(Get_Integration_SystemsInput request)
		{
			return base.Channel.Get_Integration_Systems(request);
		}

		public Get_Integration_Systems_ResponseType Get_Integration_Systems(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Systems_RequestType Get_Integration_Systems_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_Systems(new Get_Integration_SystemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Systems_Request = Get_Integration_Systems_Request
			}).Get_Integration_Systems_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Integration_SystemsOutput> IntegrationsPort.Get_Integration_SystemsAsync(Get_Integration_SystemsInput request)
		{
			return base.Channel.Get_Integration_SystemsAsync(request);
		}

		public Task<Get_Integration_SystemsOutput> Get_Integration_SystemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Systems_RequestType Get_Integration_Systems_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_SystemsAsync(new Get_Integration_SystemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Systems_Request = Get_Integration_Systems_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_MessageOutput IntegrationsPort.Put_Integration_Message(Put_Integration_MessageInput request)
		{
			return base.Channel.Put_Integration_Message(request);
		}

		public Put_Integration_Message_ResponseType Put_Integration_Message(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Message_RequestType Put_Integration_Message_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_Message(new Put_Integration_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Message_Request = Put_Integration_Message_Request
			}).Put_Integration_Message_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_MessageOutput> IntegrationsPort.Put_Integration_MessageAsync(Put_Integration_MessageInput request)
		{
			return base.Channel.Put_Integration_MessageAsync(request);
		}

		public Task<Put_Integration_MessageOutput> Put_Integration_MessageAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Message_RequestType Put_Integration_Message_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_MessageAsync(new Put_Integration_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Message_Request = Put_Integration_Message_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_EventOutput IntegrationsPort.Put_Integration_Event(Put_Integration_EventInput request)
		{
			return base.Channel.Put_Integration_Event(request);
		}

		public Put_Integration_Event_ResponseType Put_Integration_Event(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Event_RequestType Put_Integration_Event_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_Event(new Put_Integration_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Event_Request = Put_Integration_Event_Request
			}).Put_Integration_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_EventOutput> IntegrationsPort.Put_Integration_EventAsync(Put_Integration_EventInput request)
		{
			return base.Channel.Put_Integration_EventAsync(request);
		}

		public Task<Put_Integration_EventOutput> Put_Integration_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Event_RequestType Put_Integration_Event_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_EventAsync(new Put_Integration_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Event_Request = Put_Integration_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Event_DetailOutput IntegrationsPort.Get_Event_Detail(Get_Event_DetailInput request)
		{
			return base.Channel.Get_Event_Detail(request);
		}

		public Get_Event_Details_ResponseType Get_Event_Detail(Workday_Common_HeaderType Workday_Common_Header, Get_Event_Details_RequestType Get_Event_Details_Request)
		{
			return ((IntegrationsPort)this).Get_Event_Detail(new Get_Event_DetailInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Event_Details_Request = Get_Event_Details_Request
			}).Get_Event_Details_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Event_DetailOutput> IntegrationsPort.Get_Event_DetailAsync(Get_Event_DetailInput request)
		{
			return base.Channel.Get_Event_DetailAsync(request);
		}

		public Task<Get_Event_DetailOutput> Get_Event_DetailAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Event_Details_RequestType Get_Event_Details_Request)
		{
			return ((IntegrationsPort)this).Get_Event_DetailAsync(new Get_Event_DetailInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Event_Details_Request = Get_Event_Details_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Sequence_GeneratorsOutput IntegrationsPort.Get_Sequence_Generators(Get_Sequence_GeneratorsInput request)
		{
			return base.Channel.Get_Sequence_Generators(request);
		}

		public Get_Sequence_Generators_ResponseType Get_Sequence_Generators(Workday_Common_HeaderType Workday_Common_Header, Get_Sequence_Generators_RequestType Get_Sequence_Generators_Request)
		{
			return ((IntegrationsPort)this).Get_Sequence_Generators(new Get_Sequence_GeneratorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sequence_Generators_Request = Get_Sequence_Generators_Request
			}).Get_Sequence_Generators_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Sequence_GeneratorsOutput> IntegrationsPort.Get_Sequence_GeneratorsAsync(Get_Sequence_GeneratorsInput request)
		{
			return base.Channel.Get_Sequence_GeneratorsAsync(request);
		}

		public Task<Get_Sequence_GeneratorsOutput> Get_Sequence_GeneratorsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sequence_Generators_RequestType Get_Sequence_Generators_Request)
		{
			return ((IntegrationsPort)this).Get_Sequence_GeneratorsAsync(new Get_Sequence_GeneratorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sequence_Generators_Request = Get_Sequence_Generators_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Sequence_GeneratorOutput IntegrationsPort.Put_Sequence_Generator(Put_Sequence_GeneratorInput request)
		{
			return base.Channel.Put_Sequence_Generator(request);
		}

		public Put_Sequence_Generator_ResponseType Put_Sequence_Generator(Workday_Common_HeaderType Workday_Common_Header, Put_Sequence_Generator_RequestType Put_Sequence_Generator_Request)
		{
			return ((IntegrationsPort)this).Put_Sequence_Generator(new Put_Sequence_GeneratorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sequence_Generator_Request = Put_Sequence_Generator_Request
			}).Put_Sequence_Generator_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Sequence_GeneratorOutput> IntegrationsPort.Put_Sequence_GeneratorAsync(Put_Sequence_GeneratorInput request)
		{
			return base.Channel.Put_Sequence_GeneratorAsync(request);
		}

		public Task<Put_Sequence_GeneratorOutput> Put_Sequence_GeneratorAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sequence_Generator_RequestType Put_Sequence_Generator_Request)
		{
			return ((IntegrationsPort)this).Put_Sequence_GeneratorAsync(new Put_Sequence_GeneratorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sequence_Generator_Request = Put_Sequence_Generator_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Increment_Sequence_GeneratorOutput IntegrationsPort.Increment_Sequence_Generator(Increment_Sequence_GeneratorInput request)
		{
			return base.Channel.Increment_Sequence_Generator(request);
		}

		public Increment_Sequence_Generator_ResponseType Increment_Sequence_Generator(Workday_Common_HeaderType Workday_Common_Header, Increment_Sequence_Generator_RequestType Increment_Sequence_Generator_Request)
		{
			return ((IntegrationsPort)this).Increment_Sequence_Generator(new Increment_Sequence_GeneratorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Increment_Sequence_Generator_Request = Increment_Sequence_Generator_Request
			}).Increment_Sequence_Generator_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Increment_Sequence_GeneratorOutput> IntegrationsPort.Increment_Sequence_GeneratorAsync(Increment_Sequence_GeneratorInput request)
		{
			return base.Channel.Increment_Sequence_GeneratorAsync(request);
		}

		public Task<Increment_Sequence_GeneratorOutput> Increment_Sequence_GeneratorAsync(Workday_Common_HeaderType Workday_Common_Header, Increment_Sequence_Generator_RequestType Increment_Sequence_Generator_Request)
		{
			return ((IntegrationsPort)this).Increment_Sequence_GeneratorAsync(new Increment_Sequence_GeneratorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Increment_Sequence_Generator_Request = Increment_Sequence_Generator_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_SystemOutput IntegrationsPort.Put_Integration_System(Put_Integration_SystemInput request)
		{
			return base.Channel.Put_Integration_System(request);
		}

		public Put_Integration_System_ResponseType Put_Integration_System(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_RequestType Put_Integration_System_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_System(new Put_Integration_SystemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_System_Request = Put_Integration_System_Request
			}).Put_Integration_System_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_SystemOutput> IntegrationsPort.Put_Integration_SystemAsync(Put_Integration_SystemInput request)
		{
			return base.Channel.Put_Integration_SystemAsync(request);
		}

		public Task<Put_Integration_SystemOutput> Put_Integration_SystemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_RequestType Put_Integration_System_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_SystemAsync(new Put_Integration_SystemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_System_Request = Put_Integration_System_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Integration_EventsOutput IntegrationsPort.Get_Integration_Events(Get_Integration_EventsInput request)
		{
			return base.Channel.Get_Integration_Events(request);
		}

		public Get_Integration_Events_ResponseType Get_Integration_Events(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Events_RequestType Get_Integration_Events_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_Events(new Get_Integration_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Events_Request = Get_Integration_Events_Request
			}).Get_Integration_Events_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Integration_EventsOutput> IntegrationsPort.Get_Integration_EventsAsync(Get_Integration_EventsInput request)
		{
			return base.Channel.Get_Integration_EventsAsync(request);
		}

		public Task<Get_Integration_EventsOutput> Get_Integration_EventsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Events_RequestType Get_Integration_Events_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_EventsAsync(new Get_Integration_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Events_Request = Get_Integration_Events_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Business_ProcessOutput IntegrationsPort.Cancel_Business_Process(Cancel_Business_ProcessInput request)
		{
			return base.Channel.Cancel_Business_Process(request);
		}

		public Cancel_Business_Process_ResponseType Cancel_Business_Process(Workday_Common_HeaderType Workday_Common_Header, Cancel_Business_Process_RequestType Cancel_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Cancel_Business_Process(new Cancel_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Business_Process_Request = Cancel_Business_Process_Request
			}).Cancel_Business_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Business_ProcessOutput> IntegrationsPort.Cancel_Business_ProcessAsync(Cancel_Business_ProcessInput request)
		{
			return base.Channel.Cancel_Business_ProcessAsync(request);
		}

		public Task<Cancel_Business_ProcessOutput> Cancel_Business_ProcessAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Business_Process_RequestType Cancel_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Cancel_Business_ProcessAsync(new Cancel_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Business_Process_Request = Cancel_Business_Process_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Launch_IntegrationOutput IntegrationsPort.Launch_Integration(Launch_IntegrationInput request)
		{
			return base.Channel.Launch_Integration(request);
		}

		public Launch_Integration_Event_ResponseType Launch_Integration(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_RequestType Launch_Integration_Event_Request)
		{
			return ((IntegrationsPort)this).Launch_Integration(new Launch_IntegrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Integration_Event_Request = Launch_Integration_Event_Request
			}).Launch_Integration_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Launch_IntegrationOutput> IntegrationsPort.Launch_IntegrationAsync(Launch_IntegrationInput request)
		{
			return base.Channel.Launch_IntegrationAsync(request);
		}

		public Task<Launch_IntegrationOutput> Launch_IntegrationAsync(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_RequestType Launch_Integration_Event_Request)
		{
			return ((IntegrationsPort)this).Launch_IntegrationAsync(new Launch_IntegrationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Integration_Event_Request = Launch_Integration_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Rescind_Business_ProcessOutput IntegrationsPort.Rescind_Business_Process(Rescind_Business_ProcessInput request)
		{
			return base.Channel.Rescind_Business_Process(request);
		}

		public Rescind_Business_Process_ResponseType Rescind_Business_Process(Workday_Common_HeaderType Workday_Common_Header, Rescind_Business_Process_RequestType Rescind_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Rescind_Business_Process(new Rescind_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Rescind_Business_Process_Request = Rescind_Business_Process_Request
			}).Rescind_Business_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Rescind_Business_ProcessOutput> IntegrationsPort.Rescind_Business_ProcessAsync(Rescind_Business_ProcessInput request)
		{
			return base.Channel.Rescind_Business_ProcessAsync(request);
		}

		public Task<Rescind_Business_ProcessOutput> Rescind_Business_ProcessAsync(Workday_Common_HeaderType Workday_Common_Header, Rescind_Business_Process_RequestType Rescind_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Rescind_Business_ProcessAsync(new Rescind_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Rescind_Business_Process_Request = Rescind_Business_Process_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Integration_System_UsersOutput IntegrationsPort.Get_Integration_System_Users(Get_Integration_System_UsersInput request)
		{
			return base.Channel.Get_Integration_System_Users(request);
		}

		public Get_Integration_System_Users_ResponseType Get_Integration_System_Users(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_System_Users_RequestType Get_Integration_System_Users_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_System_Users(new Get_Integration_System_UsersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_System_Users_Request = Get_Integration_System_Users_Request
			}).Get_Integration_System_Users_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Integration_System_UsersOutput> IntegrationsPort.Get_Integration_System_UsersAsync(Get_Integration_System_UsersInput request)
		{
			return base.Channel.Get_Integration_System_UsersAsync(request);
		}

		public Task<Get_Integration_System_UsersOutput> Get_Integration_System_UsersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_System_Users_RequestType Get_Integration_System_Users_Request)
		{
			return ((IntegrationsPort)this).Get_Integration_System_UsersAsync(new Get_Integration_System_UsersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_System_Users_Request = Get_Integration_System_Users_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_System_UserOutput IntegrationsPort.Put_Integration_System_User(Put_Integration_System_UserInput request)
		{
			return base.Channel.Put_Integration_System_User(request);
		}

		public Put_Integration_System_User_ResponseType Put_Integration_System_User(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_User_RequestType Put_Integration_System_User_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_System_User(new Put_Integration_System_UserInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_System_User_Request = Put_Integration_System_User_Request
			}).Put_Integration_System_User_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_System_UserOutput> IntegrationsPort.Put_Integration_System_UserAsync(Put_Integration_System_UserInput request)
		{
			return base.Channel.Put_Integration_System_UserAsync(request);
		}

		public Task<Put_Integration_System_UserOutput> Put_Integration_System_UserAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_User_RequestType Put_Integration_System_User_Request)
		{
			return ((IntegrationsPort)this).Put_Integration_System_UserAsync(new Put_Integration_System_UserInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_System_User_Request = Put_Integration_System_User_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SubscriptionsOutput IntegrationsPort.Get_Subscriptions(Get_SubscriptionsInput request)
		{
			return base.Channel.Get_Subscriptions(request);
		}

		public Get_Subscriptions_ResponseType Get_Subscriptions(Workday_Common_HeaderType Workday_Common_Header, Get_Subscriptions_RequestType Get_Subscriptions_Request)
		{
			return ((IntegrationsPort)this).Get_Subscriptions(new Get_SubscriptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subscriptions_Request = Get_Subscriptions_Request
			}).Get_Subscriptions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SubscriptionsOutput> IntegrationsPort.Get_SubscriptionsAsync(Get_SubscriptionsInput request)
		{
			return base.Channel.Get_SubscriptionsAsync(request);
		}

		public Task<Get_SubscriptionsOutput> Get_SubscriptionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subscriptions_RequestType Get_Subscriptions_Request)
		{
			return ((IntegrationsPort)this).Get_SubscriptionsAsync(new Get_SubscriptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subscriptions_Request = Get_Subscriptions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SubscriptionOutput IntegrationsPort.Put_Subscription(Put_SubscriptionInput request)
		{
			return base.Channel.Put_Subscription(request);
		}

		public Put_Subscription_ResponseType Put_Subscription(Workday_Common_HeaderType Workday_Common_Header, Put_Subscription_RequestType Put_Subscription_Request)
		{
			return ((IntegrationsPort)this).Put_Subscription(new Put_SubscriptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subscription_Request = Put_Subscription_Request
			}).Put_Subscription_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SubscriptionOutput> IntegrationsPort.Put_SubscriptionAsync(Put_SubscriptionInput request)
		{
			return base.Channel.Put_SubscriptionAsync(request);
		}

		public Task<Put_SubscriptionOutput> Put_SubscriptionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subscription_RequestType Put_Subscription_Request)
		{
			return ((IntegrationsPort)this).Put_SubscriptionAsync(new Put_SubscriptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subscription_Request = Put_Subscription_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Launch_EIBOutput IntegrationsPort.Launch_EIB(Launch_EIBInput request)
		{
			return base.Channel.Launch_EIB(request);
		}

		public Launch_EIB_ResponseType Launch_EIB(Workday_Common_HeaderType Workday_Common_Header, Launch_EIB_RequestType Launch_EIB_Request)
		{
			return ((IntegrationsPort)this).Launch_EIB(new Launch_EIBInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_EIB_Request = Launch_EIB_Request
			}).Launch_EIB_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Launch_EIBOutput> IntegrationsPort.Launch_EIBAsync(Launch_EIBInput request)
		{
			return base.Channel.Launch_EIBAsync(request);
		}

		public Task<Launch_EIBOutput> Launch_EIBAsync(Workday_Common_HeaderType Workday_Common_Header, Launch_EIB_RequestType Launch_EIB_Request)
		{
			return ((IntegrationsPort)this).Launch_EIBAsync(new Launch_EIBInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_EIB_Request = Launch_EIB_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ReferencesOutput IntegrationsPort.Get_References(Get_ReferencesInput request)
		{
			return base.Channel.Get_References(request);
		}

		public Get_References_ResponseType Get_References(Workday_Common_HeaderType Workday_Common_Header, Get_References_RequestType Get_References_Request)
		{
			return ((IntegrationsPort)this).Get_References(new Get_ReferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_References_Request = Get_References_Request
			}).Get_References_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ReferencesOutput> IntegrationsPort.Get_ReferencesAsync(Get_ReferencesInput request)
		{
			return base.Channel.Get_ReferencesAsync(request);
		}

		public Task<Get_ReferencesOutput> Get_ReferencesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_References_RequestType Get_References_Request)
		{
			return ((IntegrationsPort)this).Get_ReferencesAsync(new Get_ReferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_References_Request = Get_References_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Event_DocumentsOutput IntegrationsPort.Get_Event_Documents(Get_Event_DocumentsInput request)
		{
			return base.Channel.Get_Event_Documents(request);
		}

		public Get_Event_Documents_ResponseType Get_Event_Documents(Workday_Common_HeaderType Workday_Common_Header, Get_Event_Documents_RequestType Get_Event_Documents_Request)
		{
			return ((IntegrationsPort)this).Get_Event_Documents(new Get_Event_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Event_Documents_Request = Get_Event_Documents_Request
			}).Get_Event_Documents_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Event_DocumentsOutput> IntegrationsPort.Get_Event_DocumentsAsync(Get_Event_DocumentsInput request)
		{
			return base.Channel.Get_Event_DocumentsAsync(request);
		}

		public Task<Get_Event_DocumentsOutput> Get_Event_DocumentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Event_Documents_RequestType Get_Event_Documents_Request)
		{
			return ((IntegrationsPort)this).Get_Event_DocumentsAsync(new Get_Event_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Event_Documents_Request = Get_Event_Documents_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ReferenceOutput IntegrationsPort.Put_Reference(Put_ReferenceInput request)
		{
			return base.Channel.Put_Reference(request);
		}

		public Put_Reference_ResponseType Put_Reference(Workday_Common_HeaderType Workday_Common_Header, Put_Reference_RequestType Put_Reference_Request)
		{
			return ((IntegrationsPort)this).Put_Reference(new Put_ReferenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Reference_Request = Put_Reference_Request
			}).Put_Reference_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ReferenceOutput> IntegrationsPort.Put_ReferenceAsync(Put_ReferenceInput request)
		{
			return base.Channel.Put_ReferenceAsync(request);
		}

		public Task<Put_ReferenceOutput> Put_ReferenceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Reference_RequestType Put_Reference_Request)
		{
			return ((IntegrationsPort)this).Put_ReferenceAsync(new Put_ReferenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Reference_Request = Put_Reference_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Approve_Business_ProcessOutput IntegrationsPort.Approve_Business_Process(Approve_Business_ProcessInput request)
		{
			return base.Channel.Approve_Business_Process(request);
		}

		public Approve_Business_Process_ResponseType Approve_Business_Process(Workday_Common_HeaderType Workday_Common_Header, Approve_Business_Process_RequestType Approve_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Approve_Business_Process(new Approve_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Approve_Business_Process_Request = Approve_Business_Process_Request
			}).Approve_Business_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Approve_Business_ProcessOutput> IntegrationsPort.Approve_Business_ProcessAsync(Approve_Business_ProcessInput request)
		{
			return base.Channel.Approve_Business_ProcessAsync(request);
		}

		public Task<Approve_Business_ProcessOutput> Approve_Business_ProcessAsync(Workday_Common_HeaderType Workday_Common_Header, Approve_Business_Process_RequestType Approve_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Approve_Business_ProcessAsync(new Approve_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Approve_Business_Process_Request = Approve_Business_Process_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Deny_Business_ProcessOutput IntegrationsPort.Deny_Business_Process(Deny_Business_ProcessInput request)
		{
			return base.Channel.Deny_Business_Process(request);
		}

		public Deny_Business_Process_ResponseType Deny_Business_Process(Workday_Common_HeaderType Workday_Common_Header, Deny_Business_Process_RequestType Deny_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Deny_Business_Process(new Deny_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Deny_Business_Process_Request = Deny_Business_Process_Request
			}).Deny_Business_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Deny_Business_ProcessOutput> IntegrationsPort.Deny_Business_ProcessAsync(Deny_Business_ProcessInput request)
		{
			return base.Channel.Deny_Business_ProcessAsync(request);
		}

		public Task<Deny_Business_ProcessOutput> Deny_Business_ProcessAsync(Workday_Common_HeaderType Workday_Common_Header, Deny_Business_Process_RequestType Deny_Business_Process_Request)
		{
			return ((IntegrationsPort)this).Deny_Business_ProcessAsync(new Deny_Business_ProcessInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Deny_Business_Process_Request = Deny_Business_Process_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Import_Process_MessagesOutput IntegrationsPort.Get_Import_Process_Messages(Get_Import_Process_MessagesInput request)
		{
			return base.Channel.Get_Import_Process_Messages(request);
		}

		public Get_Import_Process_Messages_ResponseType Get_Import_Process_Messages(Workday_Common_HeaderType Workday_Common_Header, Get_Import_Process_Messages_RequestType Get_Import_Process_Messages_Request)
		{
			return ((IntegrationsPort)this).Get_Import_Process_Messages(new Get_Import_Process_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Import_Process_Messages_Request = Get_Import_Process_Messages_Request
			}).Get_Import_Process_Messages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Import_Process_MessagesOutput> IntegrationsPort.Get_Import_Process_MessagesAsync(Get_Import_Process_MessagesInput request)
		{
			return base.Channel.Get_Import_Process_MessagesAsync(request);
		}

		public Task<Get_Import_Process_MessagesOutput> Get_Import_Process_MessagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Import_Process_Messages_RequestType Get_Import_Process_Messages_Request)
		{
			return ((IntegrationsPort)this).Get_Import_Process_MessagesAsync(new Get_Import_Process_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Import_Process_Messages_Request = Get_Import_Process_Messages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Import_ProcessesOutput IntegrationsPort.Get_Import_Processes(Get_Import_ProcessesInput request)
		{
			return base.Channel.Get_Import_Processes(request);
		}

		public Get_Import_Processes_ResponseType Get_Import_Processes(Workday_Common_HeaderType Workday_Common_Header, Get_Import_Processes_RequestType Get_Import_Processes_Request)
		{
			return ((IntegrationsPort)this).Get_Import_Processes(new Get_Import_ProcessesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Import_Processes_Request = Get_Import_Processes_Request
			}).Get_Import_Processes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Import_ProcessesOutput> IntegrationsPort.Get_Import_ProcessesAsync(Get_Import_ProcessesInput request)
		{
			return base.Channel.Get_Import_ProcessesAsync(request);
		}

		public Task<Get_Import_ProcessesOutput> Get_Import_ProcessesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Import_Processes_RequestType Get_Import_Processes_Request)
		{
			return ((IntegrationsPort)this).Get_Import_ProcessesAsync(new Get_Import_ProcessesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Import_Processes_Request = Get_Import_Processes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Reassign_Business_Process_StepOutput IntegrationsPort.Reassign_Business_Process_Step(Reassign_Business_Process_StepInput request)
		{
			return base.Channel.Reassign_Business_Process_Step(request);
		}

		public Reassign_Business_Process_Step_ResponseType Reassign_Business_Process_Step(Workday_Common_HeaderType Workday_Common_Header, Reassign_Business_Process_Step_RequestType Reassign_Business_Process_Step_Request)
		{
			return ((IntegrationsPort)this).Reassign_Business_Process_Step(new Reassign_Business_Process_StepInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reassign_Business_Process_Step_Request = Reassign_Business_Process_Step_Request
			}).Reassign_Business_Process_Step_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Reassign_Business_Process_StepOutput> IntegrationsPort.Reassign_Business_Process_StepAsync(Reassign_Business_Process_StepInput request)
		{
			return base.Channel.Reassign_Business_Process_StepAsync(request);
		}

		public Task<Reassign_Business_Process_StepOutput> Reassign_Business_Process_StepAsync(Workday_Common_HeaderType Workday_Common_Header, Reassign_Business_Process_Step_RequestType Reassign_Business_Process_Step_Request)
		{
			return ((IntegrationsPort)this).Reassign_Business_Process_StepAsync(new Reassign_Business_Process_StepInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reassign_Business_Process_Step_Request = Reassign_Business_Process_Step_Request
			});
		}
	}
}
