using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transaction_Tax_CodesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Codes_ResponseType Get_Tax_Codes_Response;

		public Get_Transaction_Tax_CodesOutput()
		{
		}

		public Get_Transaction_Tax_CodesOutput(Get_Tax_Codes_ResponseType Get_Tax_Codes_Response)
		{
			this.Get_Tax_Codes_Response = Get_Tax_Codes_Response;
		}
	}
}
