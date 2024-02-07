using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Gender_IdentityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Gender_Identity_ResponseType Put_Gender_Identity_Response;

		public Put_Gender_IdentityOutput()
		{
		}

		public Put_Gender_IdentityOutput(Put_Gender_Identity_ResponseType Put_Gender_Identity_Response)
		{
			this.Put_Gender_Identity_Response = Put_Gender_Identity_Response;
		}
	}
}
