using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Identity_ManagementPortClient : ClientBase<Identity_ManagementPort>, Identity_ManagementPort
	{
		public Identity_ManagementPortClient()
		{
		}

		public Identity_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Identity_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Identity_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Identity_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Unidentified_SignonsOutput Identity_ManagementPort.Get_Unidentified_Signons(Get_Unidentified_SignonsInput request)
		{
			return base.Channel.Get_Unidentified_Signons(request);
		}

		public Get_Unidentified_Signons_ResponseType Get_Unidentified_Signons(Workday_Common_HeaderType Workday_Common_Header, Get_Unidentified_Signons_RequestType Get_Unidentified_Signons_Request)
		{
			return ((Identity_ManagementPort)this).Get_Unidentified_Signons(new Get_Unidentified_SignonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Unidentified_Signons_Request = Get_Unidentified_Signons_Request
			}).Get_Unidentified_Signons_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Unidentified_SignonsOutput> Identity_ManagementPort.Get_Unidentified_SignonsAsync(Get_Unidentified_SignonsInput request)
		{
			return base.Channel.Get_Unidentified_SignonsAsync(request);
		}

		public Task<Get_Unidentified_SignonsOutput> Get_Unidentified_SignonsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Unidentified_Signons_RequestType Get_Unidentified_Signons_Request)
		{
			return ((Identity_ManagementPort)this).Get_Unidentified_SignonsAsync(new Get_Unidentified_SignonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Unidentified_Signons_Request = Get_Unidentified_Signons_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workday_Account_SignonsOutput Identity_ManagementPort.Get_Workday_Account_Signons(Get_Workday_Account_SignonsInput request)
		{
			return base.Channel.Get_Workday_Account_Signons(request);
		}

		public Get_Workday_Account_Signons_ResponseType Get_Workday_Account_Signons(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Account_Signons_RequestType Get_Workday_Account_Signons_Request)
		{
			return ((Identity_ManagementPort)this).Get_Workday_Account_Signons(new Get_Workday_Account_SignonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Account_Signons_Request = Get_Workday_Account_Signons_Request
			}).Get_Workday_Account_Signons_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workday_Account_SignonsOutput> Identity_ManagementPort.Get_Workday_Account_SignonsAsync(Get_Workday_Account_SignonsInput request)
		{
			return base.Channel.Get_Workday_Account_SignonsAsync(request);
		}

		public Task<Get_Workday_Account_SignonsOutput> Get_Workday_Account_SignonsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Account_Signons_RequestType Get_Workday_Account_Signons_Request)
		{
			return ((Identity_ManagementPort)this).Get_Workday_Account_SignonsAsync(new Get_Workday_Account_SignonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Account_Signons_Request = Get_Workday_Account_Signons_Request
			});
		}
	}
}
