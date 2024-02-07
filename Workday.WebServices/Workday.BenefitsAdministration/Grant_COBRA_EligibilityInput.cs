using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Grant_COBRA_EligibilityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Grant_COBRA_Eligibility_RequestType Grant_COBRA_Eligibility_Request;

		public Grant_COBRA_EligibilityInput()
		{
		}

		public Grant_COBRA_EligibilityInput(Workday_Common_HeaderType Workday_Common_Header, Grant_COBRA_Eligibility_RequestType Grant_COBRA_Eligibility_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Grant_COBRA_Eligibility_Request = Grant_COBRA_Eligibility_Request;
		}
	}
}
