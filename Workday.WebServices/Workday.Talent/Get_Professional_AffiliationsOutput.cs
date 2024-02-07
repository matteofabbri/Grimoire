using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Professional_AffiliationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Professional_Affiliations_ResponseType Get_Professional_Affiliations_Response;

		public Get_Professional_AffiliationsOutput()
		{
		}

		public Get_Professional_AffiliationsOutput(Get_Professional_Affiliations_ResponseType Get_Professional_Affiliations_Response)
		{
			this.Get_Professional_Affiliations_Response = Get_Professional_Affiliations_Response;
		}
	}
}
