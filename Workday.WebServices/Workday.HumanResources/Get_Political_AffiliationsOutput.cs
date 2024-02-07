using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Political_AffiliationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Political_Affiliations_ResponseType Get_Political_Affiliations_Response;

		public Get_Political_AffiliationsOutput()
		{
		}

		public Get_Political_AffiliationsOutput(Get_Political_Affiliations_ResponseType Get_Political_Affiliations_Response)
		{
			this.Get_Political_Affiliations_Response = Get_Political_Affiliations_Response;
		}
	}
}
