using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Close_Mentorship_ReasonOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Close_Mentorship_Reason_ResponseType Put_Close_Mentorship_Reason_Response;

		public Put_Close_Mentorship_ReasonOutput()
		{
		}

		public Put_Close_Mentorship_ReasonOutput(Put_Close_Mentorship_Reason_ResponseType Put_Close_Mentorship_Reason_Response)
		{
			this.Put_Close_Mentorship_Reason_Response = Put_Close_Mentorship_Reason_Response;
		}
	}
}
