using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_Progress_for_StudentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Progress_for_Student_ResponseType Get_Academic_Progress_for_Student_Response;

		public Get_Academic_Progress_for_StudentOutput()
		{
		}

		public Get_Academic_Progress_for_StudentOutput(Get_Academic_Progress_for_Student_ResponseType Get_Academic_Progress_for_Student_Response)
		{
			this.Get_Academic_Progress_for_Student_Response = Get_Academic_Progress_for_Student_Response;
		}
	}
}
