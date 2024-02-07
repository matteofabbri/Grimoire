using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_CompetenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Competencies_ResponseType Manage_Competencies_Response;

		public Manage_CompetenciesOutput()
		{
		}

		public Manage_CompetenciesOutput(Manage_Competencies_ResponseType Manage_Competencies_Response)
		{
			this.Manage_Competencies_Response = Manage_Competencies_Response;
		}
	}
}
