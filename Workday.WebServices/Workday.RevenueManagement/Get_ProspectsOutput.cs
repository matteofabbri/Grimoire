using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ProspectsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prospects_ResponseType Get_Prospects_Response;

		public Get_ProspectsOutput()
		{
		}

		public Get_ProspectsOutput(Get_Prospects_ResponseType Get_Prospects_Response)
		{
			this.Get_Prospects_Response = Get_Prospects_Response;
		}
	}
}
