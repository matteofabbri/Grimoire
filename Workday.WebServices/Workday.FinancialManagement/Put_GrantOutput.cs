using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_GrantOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Grant_ResponseType Put_Grant_Response;

		public Put_GrantOutput()
		{
		}

		public Put_GrantOutput(Put_Grant_ResponseType Put_Grant_Response)
		{
			this.Put_Grant_Response = Put_Grant_Response;
		}
	}
}
