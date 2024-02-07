using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Educational_Institution_DistrictsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Educational_Institution_Districts_ResponseType Get_Student_Educational_Institution_Districts_Response;

		public Get_Student_Educational_Institution_DistrictsOutput()
		{
		}

		public Get_Student_Educational_Institution_DistrictsOutput(Get_Student_Educational_Institution_Districts_ResponseType Get_Student_Educational_Institution_Districts_Response)
		{
			this.Get_Student_Educational_Institution_Districts_Response = Get_Student_Educational_Institution_Districts_Response;
		}
	}
}
