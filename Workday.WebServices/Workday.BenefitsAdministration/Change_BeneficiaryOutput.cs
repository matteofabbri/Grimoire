using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_BeneficiaryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Beneficiary_ResponseType Change_Beneficiary_Response;

		public Change_BeneficiaryOutput()
		{
		}

		public Change_BeneficiaryOutput(Change_Beneficiary_ResponseType Change_Beneficiary_Response)
		{
			this.Change_Beneficiary_Response = Change_Beneficiary_Response;
		}
	}
}
