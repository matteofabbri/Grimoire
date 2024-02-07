using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_Creditor_IdentifiersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Company_Creditor_Identifiers_ResponseType Get_Company_Creditor_Identifiers_Response;

		public Get_Company_Creditor_IdentifiersOutput()
		{
		}

		public Get_Company_Creditor_IdentifiersOutput(Get_Company_Creditor_Identifiers_ResponseType Get_Company_Creditor_Identifiers_Response)
		{
			this.Get_Company_Creditor_Identifiers_Response = Get_Company_Creditor_Identifiers_Response;
		}
	}
}
