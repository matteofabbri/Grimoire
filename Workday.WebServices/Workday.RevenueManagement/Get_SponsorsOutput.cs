using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SponsorsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sponsors_ResponseType Get_Sponsors_Response;

		public Get_SponsorsOutput()
		{
		}

		public Get_SponsorsOutput(Get_Sponsors_ResponseType Get_Sponsors_Response)
		{
			this.Get_Sponsors_Response = Get_Sponsors_Response;
		}
	}
}
