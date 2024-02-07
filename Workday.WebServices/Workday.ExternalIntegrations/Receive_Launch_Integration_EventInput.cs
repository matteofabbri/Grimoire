using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Receive_Launch_Integration_EventInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_Integration_Event_DataRootType Launch_Integration_Event_Data;

		public Receive_Launch_Integration_EventInput()
		{
		}

		public Receive_Launch_Integration_EventInput(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_DataRootType Launch_Integration_Event_Data)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Launch_Integration_Event_Data = Launch_Integration_Event_Data;
		}
	}
}
