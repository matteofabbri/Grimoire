using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Procurement_Card_Transaction_VerificationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Procurement_Card_Transaction_Verifications_ResponseType Get_Procurement_Card_Transaction_Verifications_Response;

		public Get_Procurement_Card_Transaction_VerificationsOutput()
		{
		}

		public Get_Procurement_Card_Transaction_VerificationsOutput(Get_Procurement_Card_Transaction_Verifications_ResponseType Get_Procurement_Card_Transaction_Verifications_Response)
		{
			this.Get_Procurement_Card_Transaction_Verifications_Response = Get_Procurement_Card_Transaction_Verifications_Response;
		}
	}
}
