using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Procurement_Card_Transaction_VerificationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Procurement_Card_Transaction_Verification_ResponseType Submit_Procurement_Card_Transaction_Verification_Response;

		public Submit_Procurement_Card_Transaction_VerificationOutput()
		{
		}

		public Submit_Procurement_Card_Transaction_VerificationOutput(Submit_Procurement_Card_Transaction_Verification_ResponseType Submit_Procurement_Card_Transaction_Verification_Response)
		{
			this.Submit_Procurement_Card_Transaction_Verification_Response = Submit_Procurement_Card_Transaction_Verification_Response;
		}
	}
}
