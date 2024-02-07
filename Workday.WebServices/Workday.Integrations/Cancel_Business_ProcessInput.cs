using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Business_ProcessInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Business_Process_RequestType Cancel_Business_Process_Request;

		public Cancel_Business_ProcessInput()
		{
		}

		public Cancel_Business_ProcessInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Business_Process_RequestType Cancel_Business_Process_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Business_Process_Request = Cancel_Business_Process_Request;
		}
	}
}
