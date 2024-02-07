using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_TermsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Terms_ResponseType Get_Payment_Terms_Response;

		public Get_Payment_TermsOutput()
		{
		}

		public Get_Payment_TermsOutput(Get_Payment_Terms_ResponseType Get_Payment_Terms_Response)
		{
			this.Get_Payment_Terms_Response = Get_Payment_Terms_Response;
		}
	}
}
