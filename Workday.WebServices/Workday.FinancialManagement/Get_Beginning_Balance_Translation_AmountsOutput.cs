using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Beginning_Balance_Translation_AmountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Beginning_Balance_Translation_Amounts_ResponseType Get_Beginning_Balance_Translation_Amounts_Response;

		public Get_Beginning_Balance_Translation_AmountsOutput()
		{
		}

		public Get_Beginning_Balance_Translation_AmountsOutput(Get_Beginning_Balance_Translation_Amounts_ResponseType Get_Beginning_Balance_Translation_Amounts_Response)
		{
			this.Get_Beginning_Balance_Translation_Amounts_Response = Get_Beginning_Balance_Translation_Amounts_Response;
		}
	}
}
