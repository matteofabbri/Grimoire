using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_ApplicabilityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Applicability_ResponseType Put_Tax_Applicability_Response;

		public Put_Tax_ApplicabilityOutput()
		{
		}

		public Put_Tax_ApplicabilityOutput(Put_Tax_Applicability_ResponseType Put_Tax_Applicability_Response)
		{
			this.Put_Tax_Applicability_Response = Put_Tax_Applicability_Response;
		}
	}
}
