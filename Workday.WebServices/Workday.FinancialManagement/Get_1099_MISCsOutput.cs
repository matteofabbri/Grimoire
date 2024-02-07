using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_1099_MISCsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_1099_Miscs_ResponseType Get_1099_Miscs_Response;

		public Get_1099_MISCsOutput()
		{
		}

		public Get_1099_MISCsOutput(Get_1099_Miscs_ResponseType Get_1099_Miscs_Response)
		{
			this.Get_1099_Miscs_Response = Get_1099_Miscs_Response;
		}
	}
}
