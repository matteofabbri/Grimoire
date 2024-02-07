using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Start_International_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Start_International_Assignment_ResponseType Start_International_Assignment_Response;

		public Start_International_AssignmentOutput()
		{
		}

		public Start_International_AssignmentOutput(Start_International_Assignment_ResponseType Start_International_Assignment_Response)
		{
			this.Start_International_Assignment_Response = Start_International_Assignment_Response;
		}
	}
}
