using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AwardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Awards_ResponseType Get_Awards_Response;

		public Get_AwardsOutput()
		{
		}

		public Get_AwardsOutput(Get_Awards_ResponseType Get_Awards_Response)
		{
			this.Get_Awards_Response = Get_Awards_Response;
		}
	}
}
