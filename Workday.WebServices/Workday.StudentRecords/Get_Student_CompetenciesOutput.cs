using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_CompetenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Competencies_ResponseType Get_Student_Competencies_Response;

		public Get_Student_CompetenciesOutput()
		{
		}

		public Get_Student_CompetenciesOutput(Get_Student_Competencies_ResponseType Get_Student_Competencies_Response)
		{
			this.Get_Student_Competencies_Response = Get_Student_Competencies_Response;
		}
	}
}
