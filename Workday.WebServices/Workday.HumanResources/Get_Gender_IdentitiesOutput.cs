using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Gender_IdentitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Gender_Identities_ResponseType Get_Gender_Identities_Response;

		public Get_Gender_IdentitiesOutput()
		{
		}

		public Get_Gender_IdentitiesOutput(Get_Gender_Identities_ResponseType Get_Gender_Identities_Response)
		{
			this.Get_Gender_Identities_Response = Get_Gender_Identities_Response;
		}
	}
}
