using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_FundsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Funds_ResponseType Get_Funds_Response;

		public Get_FundsOutput()
		{
		}

		public Get_FundsOutput(Get_Funds_ResponseType Get_Funds_Response)
		{
			this.Get_Funds_Response = Get_Funds_Response;
		}
	}
}
