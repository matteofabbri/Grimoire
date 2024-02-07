using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Rescind_Business_ProcessInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Rescind_Business_Process_RequestType Rescind_Business_Process_Request;

		public Rescind_Business_ProcessInput()
		{
		}

		public Rescind_Business_ProcessInput(Workday_Common_HeaderType Workday_Common_Header, Rescind_Business_Process_RequestType Rescind_Business_Process_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Rescind_Business_Process_Request = Rescind_Business_Process_Request;
		}
	}
}
