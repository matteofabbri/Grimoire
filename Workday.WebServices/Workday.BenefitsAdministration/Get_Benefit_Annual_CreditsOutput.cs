using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Benefit_Annual_CreditsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Benefit_Annual_Credits_ResponseType Get_Benefit_Annual_Credits_Response;

		public Get_Benefit_Annual_CreditsOutput()
		{
		}

		public Get_Benefit_Annual_CreditsOutput(Get_Benefit_Annual_Credits_ResponseType Get_Benefit_Annual_Credits_Response)
		{
			this.Get_Benefit_Annual_Credits_Response = Get_Benefit_Annual_Credits_Response;
		}
	}
}
