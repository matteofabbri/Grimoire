using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_RecruitmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Recruitments_ResponseType Get_Student_Recruitments_Response;

		public Get_Student_RecruitmentsOutput()
		{
		}

		public Get_Student_RecruitmentsOutput(Get_Student_Recruitments_ResponseType Get_Student_Recruitments_Response)
		{
			this.Get_Student_Recruitments_Response = Get_Student_Recruitments_Response;
		}
	}
}
