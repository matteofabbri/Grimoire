using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Recurring_Journal_TemplatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Recurring_Journal_Templates_ResponseType Get_Recurring_Journal_Templates_Response;

		public Get_Recurring_Journal_TemplatesOutput()
		{
		}

		public Get_Recurring_Journal_TemplatesOutput(Get_Recurring_Journal_Templates_ResponseType Get_Recurring_Journal_Templates_Response)
		{
			this.Get_Recurring_Journal_Templates_Response = Get_Recurring_Journal_Templates_Response;
		}
	}
}
