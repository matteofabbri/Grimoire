using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Approve_Business_ProcessInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Approve_Business_Process_RequestType Approve_Business_Process_Request;

		public Approve_Business_ProcessInput()
		{
		}

		public Approve_Business_ProcessInput(Workday_Common_HeaderType Workday_Common_Header, Approve_Business_Process_RequestType Approve_Business_Process_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Approve_Business_Process_Request = Approve_Business_Process_Request;
		}
	}
}
