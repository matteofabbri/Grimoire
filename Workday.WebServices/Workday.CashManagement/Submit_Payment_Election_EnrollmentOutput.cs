using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Payment_Election_EnrollmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Election_Enrollment_ResponseType Put_Payment_Election_Enrollment_Response;

		public Submit_Payment_Election_EnrollmentOutput()
		{
		}

		public Submit_Payment_Election_EnrollmentOutput(Put_Payment_Election_Enrollment_ResponseType Put_Payment_Election_Enrollment_Response)
		{
			this.Put_Payment_Election_Enrollment_Response = Put_Payment_Election_Enrollment_Response;
		}
	}
}
