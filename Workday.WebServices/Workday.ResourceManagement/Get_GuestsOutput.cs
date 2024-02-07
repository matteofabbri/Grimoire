using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_GuestsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Guests_ResponseType Get_Guests_Response;

		public Get_GuestsOutput()
		{
		}

		public Get_GuestsOutput(Get_Guests_ResponseType Get_Guests_Response)
		{
			this.Get_Guests_Response = Get_Guests_Response;
		}
	}
}
