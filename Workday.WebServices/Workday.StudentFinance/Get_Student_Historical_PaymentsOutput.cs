using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Historical_PaymentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Historical_Payments_ResponseType Get_Student_Historical_Payments_Response;

		public Get_Student_Historical_PaymentsOutput()
		{
		}

		public Get_Student_Historical_PaymentsOutput(Get_Student_Historical_Payments_ResponseType Get_Student_Historical_Payments_Response)
		{
			this.Get_Student_Historical_Payments_Response = Get_Student_Historical_Payments_Response;
		}
	}
}
