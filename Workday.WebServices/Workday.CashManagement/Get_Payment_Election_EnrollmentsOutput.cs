using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_Election_EnrollmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Election_Enrollments_ResponseType Get_Payment_Election_Enrollments_Response;

		public Get_Payment_Election_EnrollmentsOutput()
		{
		}

		public Get_Payment_Election_EnrollmentsOutput(Get_Payment_Election_Enrollments_ResponseType Get_Payment_Election_Enrollments_Response)
		{
			this.Get_Payment_Election_Enrollments_Response = Get_Payment_Election_Enrollments_Response;
		}
	}
}
