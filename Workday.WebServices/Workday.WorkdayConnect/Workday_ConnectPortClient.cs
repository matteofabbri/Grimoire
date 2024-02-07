using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Workday_ConnectPortClient : ClientBase<Workday_ConnectPort>, Workday_ConnectPort
	{
		public Workday_ConnectPortClient()
		{
		}

		public Workday_ConnectPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Workday_ConnectPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workday_ConnectPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Workday_ConnectPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Message_TemplateOutput Workday_ConnectPort.Put_Message_Template(Put_Message_TemplateInput request)
		{
			return base.Channel.Put_Message_Template(request);
		}

		public Put_Message_Template_ResponseType Put_Message_Template(Workday_Common_HeaderType Workday_Common_Header, Put_Message_Template_RequestType Put_Message_Template_Request)
		{
			return ((Workday_ConnectPort)this).Put_Message_Template(new Put_Message_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Message_Template_Request = Put_Message_Template_Request
			}).Put_Message_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Message_TemplateOutput> Workday_ConnectPort.Put_Message_TemplateAsync(Put_Message_TemplateInput request)
		{
			return base.Channel.Put_Message_TemplateAsync(request);
		}

		public Task<Put_Message_TemplateOutput> Put_Message_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Message_Template_RequestType Put_Message_Template_Request)
		{
			return ((Workday_ConnectPort)this).Put_Message_TemplateAsync(new Put_Message_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Message_Template_Request = Put_Message_Template_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Message_TemplateOutput Workday_ConnectPort.Get_Message_Template(Get_Message_TemplateInput request)
		{
			return base.Channel.Get_Message_Template(request);
		}

		public Get_Message_Template_ResponseType Get_Message_Template(Workday_Common_HeaderType Workday_Common_Header, Get_Message_Template_RequestType Get_Message_Template_Request)
		{
			return ((Workday_ConnectPort)this).Get_Message_Template(new Get_Message_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Message_Template_Request = Get_Message_Template_Request
			}).Get_Message_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Message_TemplateOutput> Workday_ConnectPort.Get_Message_TemplateAsync(Get_Message_TemplateInput request)
		{
			return base.Channel.Get_Message_TemplateAsync(request);
		}

		public Task<Get_Message_TemplateOutput> Get_Message_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Message_Template_RequestType Get_Message_Template_Request)
		{
			return ((Workday_ConnectPort)this).Get_Message_TemplateAsync(new Get_Message_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Message_Template_Request = Get_Message_Template_Request
			});
		}
	}
}
