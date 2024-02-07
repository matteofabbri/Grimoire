using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_TagOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Tag_ResponseType Put_Student_Tag_Response;

		public Put_Student_TagOutput()
		{
		}

		public Put_Student_TagOutput(Put_Student_Tag_ResponseType Put_Student_Tag_Response)
		{
			this.Put_Student_Tag_Response = Put_Student_Tag_Response;
		}
	}
}
