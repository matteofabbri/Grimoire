using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Financial_InstitutionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Financial_Institutions_ResponseType Get_Financial_Institutions_Response;

		public Get_Financial_InstitutionsOutput()
		{
		}

		public Get_Financial_InstitutionsOutput(Get_Financial_Institutions_ResponseType Get_Financial_Institutions_Response)
		{
			this.Get_Financial_Institutions_Response = Get_Financial_Institutions_Response;
		}
	}
}
