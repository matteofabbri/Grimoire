using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payment_TermOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Term_ResponseType Put_Payment_Term_Response;

		public Put_Payment_TermOutput()
		{
		}

		public Put_Payment_TermOutput(Put_Payment_Term_ResponseType Put_Payment_Term_Response)
		{
			this.Put_Payment_Term_Response = Put_Payment_Term_Response;
		}
	}
}
