using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Cost_CentersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Cost_Centers_ResponseType Get_Cost_Centers_Response;

		public Get_Cost_CentersOutput()
		{
		}

		public Get_Cost_CentersOutput(Get_Cost_Centers_ResponseType Get_Cost_Centers_Response)
		{
			this.Get_Cost_Centers_Response = Get_Cost_Centers_Response;
		}
	}
}
