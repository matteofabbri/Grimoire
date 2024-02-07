using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transaction_Tax_StatusesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Transaction_Tax_Statuses_ResponseType Get_Transaction_Tax_Statuses_Response;

		public Get_Transaction_Tax_StatusesOutput()
		{
		}

		public Get_Transaction_Tax_StatusesOutput(Get_Transaction_Tax_Statuses_ResponseType Get_Transaction_Tax_Statuses_Response)
		{
			this.Get_Transaction_Tax_Statuses_Response = Get_Transaction_Tax_Statuses_Response;
		}
	}
}
