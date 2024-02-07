using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CompaniesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Companies_ResponseType Get_Companies_Response;

		public Get_CompaniesOutput()
		{
		}

		public Get_CompaniesOutput(Get_Companies_ResponseType Get_Companies_Response)
		{
			this.Get_Companies_Response = Get_Companies_Response;
		}
	}
}
