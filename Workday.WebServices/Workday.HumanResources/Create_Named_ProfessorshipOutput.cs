using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Named_ProfessorshipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Named_Professorship_ResponseType Create_Named_Professorship_Response;

		public Create_Named_ProfessorshipOutput()
		{
		}

		public Create_Named_ProfessorshipOutput(Create_Named_Professorship_ResponseType Create_Named_Professorship_Response)
		{
			this.Create_Named_Professorship_Response = Create_Named_Professorship_Response;
		}
	}
}
