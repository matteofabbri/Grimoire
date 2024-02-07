using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Payment_Election_EnrollmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Payment_Election_Enrollment_RequestType Submit_Payment_Election_Enrollment_Request;

		public Submit_Payment_Election_EnrollmentInput()
		{
		}

		public Submit_Payment_Election_EnrollmentInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Payment_Election_Enrollment_RequestType Submit_Payment_Election_Enrollment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Payment_Election_Enrollment_Request = Submit_Payment_Election_Enrollment_Request;
		}
	}
}
