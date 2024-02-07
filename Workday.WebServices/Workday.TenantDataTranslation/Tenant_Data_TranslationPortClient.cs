using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.TenantDataTranslation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Tenant_Data_TranslationPortClient : ClientBase<Tenant_Data_TranslationPort>, Tenant_Data_TranslationPort
	{
		public Tenant_Data_TranslationPortClient()
		{
		}

		public Tenant_Data_TranslationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Tenant_Data_TranslationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Tenant_Data_TranslationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Tenant_Data_TranslationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Translatable_Tenant_Data_PublicOutput Tenant_Data_TranslationPort.Get_Translatable_Tenant_Data_Public(Get_Translatable_Tenant_Data_PublicInput request)
		{
			return base.Channel.Get_Translatable_Tenant_Data_Public(request);
		}

		public Get_Translatable_Tenant_Data_Public_ResponseType Get_Translatable_Tenant_Data_Public(Workday_Common_HeaderType Workday_Common_Header, Get_Translatable_Tenant_Data_Public_RequestType Get_Translatable_Tenant_Data_Public_Request)
		{
			return ((Tenant_Data_TranslationPort)this).Get_Translatable_Tenant_Data_Public(new Get_Translatable_Tenant_Data_PublicInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Translatable_Tenant_Data_Public_Request = Get_Translatable_Tenant_Data_Public_Request
			}).Get_Translatable_Tenant_Data_Public_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Translatable_Tenant_Data_PublicOutput> Tenant_Data_TranslationPort.Get_Translatable_Tenant_Data_PublicAsync(Get_Translatable_Tenant_Data_PublicInput request)
		{
			return base.Channel.Get_Translatable_Tenant_Data_PublicAsync(request);
		}

		public Task<Get_Translatable_Tenant_Data_PublicOutput> Get_Translatable_Tenant_Data_PublicAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Translatable_Tenant_Data_Public_RequestType Get_Translatable_Tenant_Data_Public_Request)
		{
			return ((Tenant_Data_TranslationPort)this).Get_Translatable_Tenant_Data_PublicAsync(new Get_Translatable_Tenant_Data_PublicInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Translatable_Tenant_Data_Public_Request = Get_Translatable_Tenant_Data_Public_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Translatable_Tenant_Data_PublicOutput Tenant_Data_TranslationPort.Put_Translatable_Tenant_Data_Public(Put_Translatable_Tenant_Data_PublicInput request)
		{
			return base.Channel.Put_Translatable_Tenant_Data_Public(request);
		}

		public Put_Translatable_Tenant_Data_Public_ResponseType Put_Translatable_Tenant_Data_Public(Workday_Common_HeaderType Workday_Common_Header, Put_Translatable_Tenant_Data_Public_RequestType Put_Translatable_Tenant_Data_Public_Request)
		{
			return ((Tenant_Data_TranslationPort)this).Put_Translatable_Tenant_Data_Public(new Put_Translatable_Tenant_Data_PublicInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Translatable_Tenant_Data_Public_Request = Put_Translatable_Tenant_Data_Public_Request
			}).Put_Translatable_Tenant_Data_Public_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Translatable_Tenant_Data_PublicOutput> Tenant_Data_TranslationPort.Put_Translatable_Tenant_Data_PublicAsync(Put_Translatable_Tenant_Data_PublicInput request)
		{
			return base.Channel.Put_Translatable_Tenant_Data_PublicAsync(request);
		}

		public Task<Put_Translatable_Tenant_Data_PublicOutput> Put_Translatable_Tenant_Data_PublicAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Translatable_Tenant_Data_Public_RequestType Put_Translatable_Tenant_Data_Public_Request)
		{
			return ((Tenant_Data_TranslationPort)this).Put_Translatable_Tenant_Data_PublicAsync(new Put_Translatable_Tenant_Data_PublicInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Translatable_Tenant_Data_Public_Request = Put_Translatable_Tenant_Data_Public_Request
			});
		}
	}
}
