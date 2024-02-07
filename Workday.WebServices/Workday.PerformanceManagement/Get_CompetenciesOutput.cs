using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CompetenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Competencies_ResponseType Get_Competencies_Response;

		public Get_CompetenciesOutput()
		{
		}

		public Get_CompetenciesOutput(Get_Competencies_ResponseType Get_Competencies_Response)
		{
			this.Get_Competencies_Response = Get_Competencies_Response;
		}
	}
}
