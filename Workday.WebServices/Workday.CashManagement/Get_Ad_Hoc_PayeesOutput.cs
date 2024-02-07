using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ad_Hoc_PayeesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ad_Hoc_Payees_ResponseType Get_Ad_Hoc_Payees_Response;

		public Get_Ad_Hoc_PayeesOutput()
		{
		}

		public Get_Ad_Hoc_PayeesOutput(Get_Ad_Hoc_Payees_ResponseType Get_Ad_Hoc_Payees_Response)
		{
			this.Get_Ad_Hoc_Payees_Response = Get_Ad_Hoc_Payees_Response;
		}
	}
}
