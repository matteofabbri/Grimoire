using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_CompaniesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Companies_ResponseType Get_Workday_Companies_Response;

		public Get_Workday_CompaniesOutput()
		{
		}

		public Get_Workday_CompaniesOutput(Get_Workday_Companies_ResponseType Get_Workday_Companies_Response)
		{
			this.Get_Workday_Companies_Response = Get_Workday_Companies_Response;
		}
	}
}
