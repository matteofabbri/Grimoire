using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Evidence_of_InsurabilityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Evidence_of_Insurability_ResponseType Put_Evidence_of_Insurability_Response;

		public Put_Evidence_of_InsurabilityOutput()
		{
		}

		public Put_Evidence_of_InsurabilityOutput(Put_Evidence_of_Insurability_ResponseType Put_Evidence_of_Insurability_Response)
		{
			this.Put_Evidence_of_Insurability_Response = Put_Evidence_of_Insurability_Response;
		}
	}
}
