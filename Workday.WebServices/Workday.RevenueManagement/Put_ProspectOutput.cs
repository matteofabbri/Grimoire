using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ProspectOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Prospect_ResponseType Put_Prospect_Response;

		public Put_ProspectOutput()
		{
		}

		public Put_ProspectOutput(Put_Prospect_ResponseType Put_Prospect_Response)
		{
			this.Put_Prospect_Response = Put_Prospect_Response;
		}
	}
}
