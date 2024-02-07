using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class External_IntegrationsPortClient : ClientBase<External_IntegrationsPort>, External_IntegrationsPort
	{
		public External_IntegrationsPortClient()
		{
		}

		public External_IntegrationsPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public External_IntegrationsPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public External_IntegrationsPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public External_IntegrationsPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		void External_IntegrationsPort.Receive_Launch_Integration_Event(Receive_Launch_Integration_EventInput request)
		{
			base.Channel.Receive_Launch_Integration_Event(request);
		}

		public void Receive_Launch_Integration_Event(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_DataRootType Launch_Integration_Event_Data)
		{
			((External_IntegrationsPort)this).Receive_Launch_Integration_Event(new Receive_Launch_Integration_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Integration_Event_Data = Launch_Integration_Event_Data
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task External_IntegrationsPort.Receive_Launch_Integration_EventAsync(Receive_Launch_Integration_EventInput request)
		{
			return base.Channel.Receive_Launch_Integration_EventAsync(request);
		}

		public Task Receive_Launch_Integration_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_DataRootType Launch_Integration_Event_Data)
		{
			return ((External_IntegrationsPort)this).Receive_Launch_Integration_EventAsync(new Receive_Launch_Integration_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Launch_Integration_Event_Data = Launch_Integration_Event_Data
			});
		}
	}
}
