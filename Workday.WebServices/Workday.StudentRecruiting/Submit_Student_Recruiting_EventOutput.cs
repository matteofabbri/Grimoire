using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_Recruiting_EventOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Recruiting_Event_ResponseType Submit_Student_Recruiting_Event_Response;

		public Submit_Student_Recruiting_EventOutput()
		{
		}

		public Submit_Student_Recruiting_EventOutput(Submit_Student_Recruiting_Event_ResponseType Submit_Student_Recruiting_Event_Response)
		{
			this.Submit_Student_Recruiting_Event_Response = Submit_Student_Recruiting_Event_Response;
		}
	}
}
