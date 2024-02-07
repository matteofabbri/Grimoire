using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Named_ProfessorshipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Named_Professorship_ResponseType Edit_Named_Professorship_Response;

		public Edit_Named_ProfessorshipOutput()
		{
		}

		public Edit_Named_ProfessorshipOutput(Edit_Named_Professorship_ResponseType Edit_Named_Professorship_Response)
		{
			this.Edit_Named_Professorship_Response = Edit_Named_Professorship_Response;
		}
	}
}
