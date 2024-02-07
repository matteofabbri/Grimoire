using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_1099_MISC_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_1099_Electronic_Filing_Run_ResponseType Get_1099_Electronic_Filing_Run_Response;

		public Get_Company_1099_MISC_DataOutput()
		{
		}

		public Get_Company_1099_MISC_DataOutput(Get_1099_Electronic_Filing_Run_ResponseType Get_1099_Electronic_Filing_Run_Response)
		{
			this.Get_1099_Electronic_Filing_Run_Response = Get_1099_Electronic_Filing_Run_Response;
		}
	}
}
