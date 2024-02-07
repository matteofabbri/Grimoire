using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Educational_Institution_CourseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Educational_Institution_Course_ResponseType Get_Educational_Institution_Course_Response;

		public Get_Educational_Institution_CourseOutput()
		{
		}

		public Get_Educational_Institution_CourseOutput(Get_Educational_Institution_Course_ResponseType Get_Educational_Institution_Course_Response)
		{
			this.Get_Educational_Institution_Course_Response = Get_Educational_Institution_Course_Response;
		}
	}
}
