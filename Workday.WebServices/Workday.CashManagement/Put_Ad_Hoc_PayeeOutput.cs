using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ad_Hoc_PayeeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ad_Hoc_Payee_ResponseType Put_Ad_Hoc_Payee_Response;

		public Put_Ad_Hoc_PayeeOutput()
		{
		}

		public Put_Ad_Hoc_PayeeOutput(Put_Ad_Hoc_Payee_ResponseType Put_Ad_Hoc_Payee_Response)
		{
			this.Put_Ad_Hoc_Payee_Response = Put_Ad_Hoc_Payee_Response;
		}
	}
}
