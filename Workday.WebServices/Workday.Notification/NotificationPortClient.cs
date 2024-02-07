using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Notification
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class NotificationPortClient : ClientBase<NotificationPort>, NotificationPort
	{
		public NotificationPortClient()
		{
		}

		public NotificationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public NotificationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public NotificationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public NotificationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		void NotificationPort.Receive_Notification(Receive_NotificationInput request)
		{
			base.Channel.Receive_Notification(request);
		}

		public void Receive_Notification(Workday_Common_HeaderType Workday_Common_Header, Notification_DataRootType Notification_Data)
		{
			((NotificationPort)this).Receive_Notification(new Receive_NotificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Notification_Data = Notification_Data
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task NotificationPort.Receive_NotificationAsync(Receive_NotificationInput request)
		{
			return base.Channel.Receive_NotificationAsync(request);
		}

		public Task Receive_NotificationAsync(Workday_Common_HeaderType Workday_Common_Header, Notification_DataRootType Notification_Data)
		{
			return ((NotificationPort)this).Receive_NotificationAsync(new Receive_NotificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Notification_Data = Notification_Data
			});
		}
	}
}
