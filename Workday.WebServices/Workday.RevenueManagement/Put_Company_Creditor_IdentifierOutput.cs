using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Company_Creditor_IdentifierOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Company_Creditor_Identifier_ResponseType Put_Company_Creditor_Identifier_Response;

		public Put_Company_Creditor_IdentifierOutput()
		{
		}

		public Put_Company_Creditor_IdentifierOutput(Put_Company_Creditor_Identifier_ResponseType Put_Company_Creditor_Identifier_Response)
		{
			this.Put_Company_Creditor_Identifier_Response = Put_Company_Creditor_Identifier_Response;
		}
	}
}
