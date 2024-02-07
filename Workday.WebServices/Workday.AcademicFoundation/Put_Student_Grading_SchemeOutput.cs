using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Grading_SchemeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Grading_Scheme_ResponseType Put_Student_Grading_Scheme_Response;

		public Put_Student_Grading_SchemeOutput()
		{
		}

		public Put_Student_Grading_SchemeOutput(Put_Student_Grading_Scheme_ResponseType Put_Student_Grading_Scheme_Response)
		{
			this.Put_Student_Grading_Scheme_Response = Put_Student_Grading_Scheme_Response;
		}
	}
}
