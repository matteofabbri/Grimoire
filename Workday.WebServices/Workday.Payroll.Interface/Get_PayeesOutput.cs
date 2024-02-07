using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PayeesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payees_ResponseType Get_Payees_Response;

		public Get_PayeesOutput()
		{
		}

		public Get_PayeesOutput(Get_Payees_ResponseType Get_Payees_Response)
		{
			this.Get_Payees_Response = Get_Payees_Response;
		}
	}
}
