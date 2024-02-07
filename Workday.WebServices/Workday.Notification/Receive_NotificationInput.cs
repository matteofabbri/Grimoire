using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Notification
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Receive_NotificationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Notification_DataRootType Notification_Data;

		public Receive_NotificationInput()
		{
		}

		public Receive_NotificationInput(Workday_Common_HeaderType Workday_Common_Header, Notification_DataRootType Notification_Data)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Notification_Data = Notification_Data;
		}
	}
}
