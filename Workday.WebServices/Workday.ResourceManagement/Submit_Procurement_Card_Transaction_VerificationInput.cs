using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Procurement_Card_Transaction_VerificationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Procurement_Card_Transaction_Verification_RequestType Submit_Procurement_Card_Transaction_Verification_Request;

		public Submit_Procurement_Card_Transaction_VerificationInput()
		{
		}

		public Submit_Procurement_Card_Transaction_VerificationInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Procurement_Card_Transaction_Verification_RequestType Submit_Procurement_Card_Transaction_Verification_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Procurement_Card_Transaction_Verification_Request = Submit_Procurement_Card_Transaction_Verification_Request;
		}
	}
}
