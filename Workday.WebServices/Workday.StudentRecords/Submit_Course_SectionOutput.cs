using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Course_SectionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Course_Section_ResponseType Submit_Course_Section_Response;

		public Submit_Course_SectionOutput()
		{
		}

		public Submit_Course_SectionOutput(Submit_Course_Section_ResponseType Submit_Course_Section_Response)
		{
			this.Submit_Course_Section_Response = Submit_Course_Section_Response;
		}
	}
}
