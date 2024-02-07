using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubrecipientsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subrecipients_ResponseType Get_Subrecipients_Response;

		public Get_SubrecipientsOutput()
		{
		}

		public Get_SubrecipientsOutput(Get_Subrecipients_ResponseType Get_Subrecipients_Response)
		{
			this.Get_Subrecipients_Response = Get_Subrecipients_Response;
		}
	}
}
