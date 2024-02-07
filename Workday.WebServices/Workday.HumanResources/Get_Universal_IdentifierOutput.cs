using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Universal_IdentifierOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Universal_Identifiers_ResponseType Get_Universal_Identifiers_Response;

		public Get_Universal_IdentifierOutput()
		{
		}

		public Get_Universal_IdentifierOutput(Get_Universal_Identifiers_ResponseType Get_Universal_Identifiers_Response)
		{
			this.Get_Universal_Identifiers_Response = Get_Universal_Identifiers_Response;
		}
	}
}
