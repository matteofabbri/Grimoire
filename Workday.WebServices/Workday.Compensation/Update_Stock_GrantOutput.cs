using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Stock_GrantOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Stock_Grant_ResponseType Update_Stock_Grant_Response;

		public Update_Stock_GrantOutput()
		{
		}

		public Update_Stock_GrantOutput(Update_Stock_Grant_ResponseType Update_Stock_Grant_Response)
		{
			this.Update_Stock_Grant_Response = Update_Stock_Grant_Response;
		}
	}
}
