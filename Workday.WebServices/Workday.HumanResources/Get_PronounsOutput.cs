using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PronounsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Pronouns_ResponseType Get_Pronouns_Response;

		public Get_PronounsOutput()
		{
		}

		public Get_PronounsOutput(Get_Pronouns_ResponseType Get_Pronouns_Response)
		{
			this.Get_Pronouns_Response = Get_Pronouns_Response;
		}
	}
}
