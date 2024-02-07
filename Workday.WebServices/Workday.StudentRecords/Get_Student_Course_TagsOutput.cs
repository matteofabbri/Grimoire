using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Course_TagsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Course_Tags_ResponseType Get_Student_Course_Tags_Response;

		public Get_Student_Course_TagsOutput()
		{
		}

		public Get_Student_Course_TagsOutput(Get_Student_Course_Tags_ResponseType Get_Student_Course_Tags_Response)
		{
			this.Get_Student_Course_Tags_Response = Get_Student_Course_Tags_Response;
		}
	}
}
