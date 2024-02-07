using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_Course_Withdraw_RegistrationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Course_Withdraw_Registration_ResponseType Submit_Student_Course_Withdraw_Registration_Response;

		public Submit_Student_Course_Withdraw_RegistrationOutput()
		{
		}

		public Submit_Student_Course_Withdraw_RegistrationOutput(Submit_Student_Course_Withdraw_Registration_ResponseType Submit_Student_Course_Withdraw_Registration_Response)
		{
			this.Submit_Student_Course_Withdraw_Registration_Response = Submit_Student_Course_Withdraw_Registration_Response;
		}
	}
}
