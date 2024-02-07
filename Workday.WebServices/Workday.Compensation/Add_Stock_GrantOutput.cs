using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Stock_GrantOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Stock_Grant_ResponseType Add_Stock_Grant_Response;

		public Add_Stock_GrantOutput()
		{
		}

		public Add_Stock_GrantOutput(Add_Stock_Grant_ResponseType Add_Stock_Grant_Response)
		{
			this.Add_Stock_Grant_Response = Add_Stock_Grant_Response;
		}
	}
}
