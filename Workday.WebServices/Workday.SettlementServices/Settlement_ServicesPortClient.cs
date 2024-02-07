using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Settlement_ServicesPortClient : ClientBase<Settlement_ServicesPort>, Settlement_ServicesPort
	{
		public Settlement_ServicesPortClient()
		{
		}

		public Settlement_ServicesPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Settlement_ServicesPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Settlement_ServicesPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Settlement_ServicesPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_TypesOutput Settlement_ServicesPort.Get_Payment_Types(Get_Payment_TypesInput request)
		{
			return base.Channel.Get_Payment_Types(request);
		}

		public Get_Payment_Types_ResponseType Get_Payment_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Types_RequestType Get_Payment_Types_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Payment_Types(new Get_Payment_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Types_Request = Get_Payment_Types_Request
			}).Get_Payment_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_TypesOutput> Settlement_ServicesPort.Get_Payment_TypesAsync(Get_Payment_TypesInput request)
		{
			return base.Channel.Get_Payment_TypesAsync(request);
		}

		public Task<Get_Payment_TypesOutput> Get_Payment_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Types_RequestType Get_Payment_Types_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Payment_TypesAsync(new Get_Payment_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Types_Request = Get_Payment_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_TypeOutput Settlement_ServicesPort.Put_Payment_Type(Put_Payment_TypeInput request)
		{
			return base.Channel.Put_Payment_Type(request);
		}

		public Put_Payment_Type_ResponseType Put_Payment_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Type_RequestType Put_Payment_Type_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Payment_Type(new Put_Payment_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Type_Request = Put_Payment_Type_Request
			}).Put_Payment_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_TypeOutput> Settlement_ServicesPort.Put_Payment_TypeAsync(Put_Payment_TypeInput request)
		{
			return base.Channel.Put_Payment_TypeAsync(request);
		}

		public Task<Put_Payment_TypeOutput> Put_Payment_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Type_RequestType Put_Payment_Type_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Payment_TypeAsync(new Put_Payment_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Type_Request = Put_Payment_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_Acknowledgement_MessageOutput Settlement_ServicesPort.Put_Payment_Acknowledgement_Message(Put_Payment_Acknowledgement_MessageInput request)
		{
			return base.Channel.Put_Payment_Acknowledgement_Message(request);
		}

		public Put_Payment_Acknowledgement_Message_ResponseType Put_Payment_Acknowledgement_Message(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Acknowledgement_Message_RequestType Put_Payment_Acknowledgement_Message_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Payment_Acknowledgement_Message(new Put_Payment_Acknowledgement_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Acknowledgement_Message_Request = Put_Payment_Acknowledgement_Message_Request
			}).Put_Payment_Acknowledgement_Message_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_Acknowledgement_MessageOutput> Settlement_ServicesPort.Put_Payment_Acknowledgement_MessageAsync(Put_Payment_Acknowledgement_MessageInput request)
		{
			return base.Channel.Put_Payment_Acknowledgement_MessageAsync(request);
		}

		public Task<Put_Payment_Acknowledgement_MessageOutput> Put_Payment_Acknowledgement_MessageAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Acknowledgement_Message_RequestType Put_Payment_Acknowledgement_Message_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Payment_Acknowledgement_MessageAsync(new Put_Payment_Acknowledgement_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Acknowledgement_Message_Request = Put_Payment_Acknowledgement_Message_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PaymentsOutput Settlement_ServicesPort.Get_Payments(Get_PaymentsInput request)
		{
			return base.Channel.Get_Payments(request);
		}

		public Get_Payments_ResponseType Get_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Payments(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			}).Get_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PaymentsOutput> Settlement_ServicesPort.Get_PaymentsAsync(Get_PaymentsInput request)
		{
			return base.Channel.Get_PaymentsAsync(request);
		}

		public Task<Get_PaymentsOutput> Get_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Settlement_ServicesPort)this).Get_PaymentsAsync(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_MessagesOutput Settlement_ServicesPort.Get_Payment_Messages(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_Messages(request);
		}

		public Get_Payment_Messages_ResponseType Get_Payment_Messages(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Payment_Messages(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			}).Get_Payment_Messages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_MessagesOutput> Settlement_ServicesPort.Get_Payment_MessagesAsync(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_MessagesAsync(request);
		}

		public Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Payment_MessagesAsync(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Escheatment_ItemsOutput Settlement_ServicesPort.Get_Escheatment_Items(Get_Escheatment_ItemsInput request)
		{
			return base.Channel.Get_Escheatment_Items(request);
		}

		public Get_Escheatment_Items_ResponseType Get_Escheatment_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Escheatment_Items(new Get_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Escheatment_Items_Request = Get_Escheatment_Items_Request
			}).Get_Escheatment_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Escheatment_ItemsOutput> Settlement_ServicesPort.Get_Escheatment_ItemsAsync(Get_Escheatment_ItemsInput request)
		{
			return base.Channel.Get_Escheatment_ItemsAsync(request);
		}

		public Task<Get_Escheatment_ItemsOutput> Get_Escheatment_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request)
		{
			return ((Settlement_ServicesPort)this).Get_Escheatment_ItemsAsync(new Get_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Escheatment_Items_Request = Get_Escheatment_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Escheatment_ItemsOutput Settlement_ServicesPort.Submit_Escheatment_Items(Submit_Escheatment_ItemsInput request)
		{
			return base.Channel.Submit_Escheatment_Items(request);
		}

		public Submit_Escheatment_Items_ResponseType Submit_Escheatment_Items(Workday_Common_HeaderType Workday_Common_Header, Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request)
		{
			return ((Settlement_ServicesPort)this).Submit_Escheatment_Items(new Submit_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Escheatment_Items_Request = Submit_Escheatment_Items_Request
			}).Submit_Escheatment_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Escheatment_ItemsOutput> Settlement_ServicesPort.Submit_Escheatment_ItemsAsync(Submit_Escheatment_ItemsInput request)
		{
			return base.Channel.Submit_Escheatment_ItemsAsync(request);
		}

		public Task<Submit_Escheatment_ItemsOutput> Submit_Escheatment_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request)
		{
			return ((Settlement_ServicesPort)this).Submit_Escheatment_ItemsAsync(new Submit_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Escheatment_Items_Request = Submit_Escheatment_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Escheatable_Payment_Notification_DateOutput Settlement_ServicesPort.Put_Escheatable_Payment_Notification_Date(Put_Escheatable_Payment_Notification_DateInput request)
		{
			return base.Channel.Put_Escheatable_Payment_Notification_Date(request);
		}

		public Put_Escheatable_Payment_Notification_Date_ResponseType Put_Escheatable_Payment_Notification_Date(Workday_Common_HeaderType Workday_Common_Header, Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Escheatable_Payment_Notification_Date(new Put_Escheatable_Payment_Notification_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Escheatable_Payment_Notification_Date_Request = Put_Escheatable_Payment_Notification_Date_Request
			}).Put_Escheatable_Payment_Notification_Date_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Escheatable_Payment_Notification_DateOutput> Settlement_ServicesPort.Put_Escheatable_Payment_Notification_DateAsync(Put_Escheatable_Payment_Notification_DateInput request)
		{
			return base.Channel.Put_Escheatable_Payment_Notification_DateAsync(request);
		}

		public Task<Put_Escheatable_Payment_Notification_DateOutput> Put_Escheatable_Payment_Notification_DateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request)
		{
			return ((Settlement_ServicesPort)this).Put_Escheatable_Payment_Notification_DateAsync(new Put_Escheatable_Payment_Notification_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Escheatable_Payment_Notification_Date_Request = Put_Escheatable_Payment_Notification_Date_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Settlement_RunOutput Settlement_ServicesPort.Submit_Settlement_Run(Submit_Settlement_RunInput request)
		{
			return base.Channel.Submit_Settlement_Run(request);
		}

		public Submit_Settlement_Run_ResponseType Submit_Settlement_Run(Workday_Common_HeaderType Workday_Common_Header, Submit_Settlement_Run_RequestType Submit_Settlement_Run_Request)
		{
			return ((Settlement_ServicesPort)this).Submit_Settlement_Run(new Submit_Settlement_RunInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Settlement_Run_Request = Submit_Settlement_Run_Request
			}).Submit_Settlement_Run_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Settlement_RunOutput> Settlement_ServicesPort.Submit_Settlement_RunAsync(Submit_Settlement_RunInput request)
		{
			return base.Channel.Submit_Settlement_RunAsync(request);
		}

		public Task<Submit_Settlement_RunOutput> Submit_Settlement_RunAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Settlement_Run_RequestType Submit_Settlement_Run_Request)
		{
			return ((Settlement_ServicesPort)this).Submit_Settlement_RunAsync(new Submit_Settlement_RunInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Settlement_Run_Request = Submit_Settlement_Run_Request
			});
		}
	}
}
