using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_FundOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Fund_ResponseType Put_Fund_Response;

		public Put_FundOutput()
		{
		}

		public Put_FundOutput(Put_Fund_ResponseType Put_Fund_Response)
		{
			this.Put_Fund_Response = Put_Fund_Response;
		}
	}
}
