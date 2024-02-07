using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_VAT_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_VAT_Groups_ResponseType Get_VAT_Groups_Response;

		public Get_VAT_GroupsOutput()
		{
		}

		public Get_VAT_GroupsOutput(Get_VAT_Groups_ResponseType Get_VAT_Groups_Response)
		{
			this.Get_VAT_Groups_Response = Get_VAT_Groups_Response;
		}
	}
}
