using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Spend_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Spend_Restrictions_ResponseType Get_Spend_Restrictions_Response;

		public Get_Spend_RestrictionsOutput()
		{
		}

		public Get_Spend_RestrictionsOutput(Get_Spend_Restrictions_ResponseType Get_Spend_Restrictions_Response)
		{
			this.Get_Spend_Restrictions_Response = Get_Spend_Restrictions_Response;
		}
	}
}
