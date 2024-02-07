using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_Payment_DatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Company_Payment_Dates_ResponseType Get_Company_Payment_Dates_Response;

		public Get_Company_Payment_DatesOutput()
		{
		}

		public Get_Company_Payment_DatesOutput(Get_Company_Payment_Dates_ResponseType Get_Company_Payment_Dates_Response)
		{
			this.Get_Company_Payment_Dates_Response = Get_Company_Payment_Dates_Response;
		}
	}
}
