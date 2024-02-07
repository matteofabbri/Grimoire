using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Professional_AffiliationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Professional_Affiliations_ResponseType Manage_Professional_Affiliations_Response;

		public Manage_Professional_AffiliationsOutput()
		{
		}

		public Manage_Professional_AffiliationsOutput(Manage_Professional_Affiliations_ResponseType Manage_Professional_Affiliations_Response)
		{
			this.Manage_Professional_Affiliations_Response = Manage_Professional_Affiliations_Response;
		}
	}
}
