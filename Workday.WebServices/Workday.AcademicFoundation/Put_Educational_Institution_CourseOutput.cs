using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Educational_Institution_CourseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Educational_Institution_Course_ResponseType Put_Educational_Institution_Course_Response;

		public Put_Educational_Institution_CourseOutput()
		{
		}

		public Put_Educational_Institution_CourseOutput(Put_Educational_Institution_Course_ResponseType Put_Educational_Institution_Course_Response)
		{
			this.Put_Educational_Institution_Course_Response = Put_Educational_Institution_Course_Response;
		}
	}
}
