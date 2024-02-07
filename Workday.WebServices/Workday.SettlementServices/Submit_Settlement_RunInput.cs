using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Settlement_RunInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Settlement_Run_RequestType Submit_Settlement_Run_Request;

		public Submit_Settlement_RunInput()
		{
		}

		public Submit_Settlement_RunInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Settlement_Run_RequestType Submit_Settlement_Run_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Settlement_Run_Request = Submit_Settlement_Run_Request;
		}
	}
}
