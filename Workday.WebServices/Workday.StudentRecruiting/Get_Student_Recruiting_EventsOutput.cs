using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Recruiting_EventsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Recruiting_Events_ResponseType Get_Student_Recruiting_Events_Response;

		public Get_Student_Recruiting_EventsOutput()
		{
		}

		public Get_Student_Recruiting_EventsOutput(Get_Student_Recruiting_Events_ResponseType Get_Student_Recruiting_Events_Response)
		{
			this.Get_Student_Recruiting_Events_Response = Get_Student_Recruiting_Events_Response;
		}
	}
}
