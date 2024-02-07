using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_IntegrationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_Integration_Event_RequestType Launch_Integration_Event_Request;

		public Launch_IntegrationInput()
		{
		}

		public Launch_IntegrationInput(Workday_Common_HeaderType Workday_Common_Header, Launch_Integration_Event_RequestType Launch_Integration_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Launch_Integration_Event_Request = Launch_Integration_Event_Request;
		}
	}
}
