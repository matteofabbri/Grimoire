using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_System_UserOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_System_User_ResponseType Put_Integration_System_User_Response;

		public Put_Integration_System_UserOutput()
		{
		}

		public Put_Integration_System_UserOutput(Put_Integration_System_User_ResponseType Put_Integration_System_User_Response)
		{
			this.Put_Integration_System_User_Response = Put_Integration_System_User_Response;
		}
	}
}
