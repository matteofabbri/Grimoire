using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Close_Mentorship_ReasonsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Close_Mentorship_Reasons_ResponseType Get_Close_Mentorship_Reasons_Response;

		public Get_Close_Mentorship_ReasonsOutput()
		{
		}

		public Get_Close_Mentorship_ReasonsOutput(Get_Close_Mentorship_Reasons_ResponseType Get_Close_Mentorship_Reasons_Response)
		{
			this.Get_Close_Mentorship_Reasons_Response = Get_Close_Mentorship_Reasons_Response;
		}
	}
}
