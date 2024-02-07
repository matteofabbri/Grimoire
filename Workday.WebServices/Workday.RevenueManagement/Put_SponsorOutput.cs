using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SponsorOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sponsor_ResponseType Put_Sponsor_Response;

		public Put_SponsorOutput()
		{
		}

		public Put_SponsorOutput(Put_Sponsor_ResponseType Put_Sponsor_Response)
		{
			this.Put_Sponsor_Response = Put_Sponsor_Response;
		}
	}
}
