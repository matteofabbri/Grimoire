using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LoansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Loans_ResponseType Get_Loans_Response;

		public Get_LoansOutput()
		{
		}

		public Get_LoansOutput(Get_Loans_ResponseType Get_Loans_Response)
		{
			this.Get_Loans_Response = Get_Loans_Response;
		}
	}
}
