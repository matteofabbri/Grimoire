using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Workday_ExtensibilityPortClient : ClientBase<Workday_ExtensibilityPort>, Workday_ExtensibilityPort
	{
		public Workday_ExtensibilityPortClient()
		{
		}

		public Workday_ExtensibilityPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Workday_ExtensibilityPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workday_ExtensibilityPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workday_ExtensibilityPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Custom_ListsOutput Workday_ExtensibilityPort.Get_Custom_Lists(Get_Custom_ListsInput request)
		{
			return base.Channel.Get_Custom_Lists(request);
		}

		public Get_Custom_Lists_ResponseType Get_Custom_Lists(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Lists_RequestType Get_Custom_Lists_Request)
		{
			return ((Workday_ExtensibilityPort)this).Get_Custom_Lists(new Get_Custom_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Lists_Request = Get_Custom_Lists_Request
			}).Get_Custom_Lists_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Custom_ListsOutput> Workday_ExtensibilityPort.Get_Custom_ListsAsync(Get_Custom_ListsInput request)
		{
			return base.Channel.Get_Custom_ListsAsync(request);
		}

		public Task<Get_Custom_ListsOutput> Get_Custom_ListsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Lists_RequestType Get_Custom_Lists_Request)
		{
			return ((Workday_ExtensibilityPort)this).Get_Custom_ListsAsync(new Get_Custom_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Lists_Request = Get_Custom_Lists_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Custom_ListOutput Workday_ExtensibilityPort.Put_Custom_List(Put_Custom_ListInput request)
		{
			return base.Channel.Put_Custom_List(request);
		}

		public Put_Custom_List_ResponseType Put_Custom_List(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_List_RequestType Put_Custom_List_Request)
		{
			return ((Workday_ExtensibilityPort)this).Put_Custom_List(new Put_Custom_ListInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_List_Request = Put_Custom_List_Request
			}).Put_Custom_List_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Custom_ListOutput> Workday_ExtensibilityPort.Put_Custom_ListAsync(Put_Custom_ListInput request)
		{
			return base.Channel.Put_Custom_ListAsync(request);
		}

		public Task<Put_Custom_ListOutput> Put_Custom_ListAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_List_RequestType Put_Custom_List_Request)
		{
			return ((Workday_ExtensibilityPort)this).Put_Custom_ListAsync(new Put_Custom_ListInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_List_Request = Put_Custom_List_Request
			});
		}
	}
}
