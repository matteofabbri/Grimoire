using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Event_DetailOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Event_Details_ResponseType Get_Event_Details_Response;

		public Get_Event_DetailOutput()
		{
		}

		public Get_Event_DetailOutput(Get_Event_Details_ResponseType Get_Event_Details_Response)
		{
			this.Get_Event_Details_Response = Get_Event_Details_Response;
		}
	}
}
