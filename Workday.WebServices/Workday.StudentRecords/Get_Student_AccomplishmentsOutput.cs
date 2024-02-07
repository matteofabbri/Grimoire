using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_AccomplishmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Accomplishments_ResponseType Get_Student_Accomplishments_Response;

		public Get_Student_AccomplishmentsOutput()
		{
		}

		public Get_Student_AccomplishmentsOutput(Get_Student_Accomplishments_ResponseType Get_Student_Accomplishments_Response)
		{
			this.Get_Student_Accomplishments_Response = Get_Student_Accomplishments_Response;
		}
	}
}
