using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Grant_COBRA_EligibilityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Grant_COBRA_Eligibility_ResponseType Grant_COBRA_Eligibility_Response;

		public Grant_COBRA_EligibilityOutput()
		{
		}

		public Grant_COBRA_EligibilityOutput(Grant_COBRA_Eligibility_ResponseType Grant_COBRA_Eligibility_Response)
		{
			this.Grant_COBRA_Eligibility_Response = Grant_COBRA_Eligibility_Response;
		}
	}
}
