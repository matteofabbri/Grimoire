using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_OpportunitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Opportunities_ResponseType Get_Opportunities_Response;

		public Get_OpportunitiesOutput()
		{
		}

		public Get_OpportunitiesOutput(Get_Opportunities_ResponseType Get_Opportunities_Response)
		{
			this.Get_Opportunities_Response = Get_Opportunities_Response;
		}
	}
}
