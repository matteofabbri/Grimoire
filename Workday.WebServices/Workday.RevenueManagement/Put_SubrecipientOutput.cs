using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubrecipientOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subrecipient_ResponseType Put_Subrecipient_Response;

		public Put_SubrecipientOutput()
		{
		}

		public Put_SubrecipientOutput(Put_Subrecipient_ResponseType Put_Subrecipient_Response)
		{
			this.Put_Subrecipient_Response = Put_Subrecipient_Response;
		}
	}
}
