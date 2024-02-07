using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_IDsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_IDs_ResponseType Get_Payroll_IDs_Response;

		public Get_Payroll_IDsOutput()
		{
		}

		public Get_Payroll_IDsOutput(Get_Payroll_IDs_ResponseType Get_Payroll_IDs_Response)
		{
			this.Get_Payroll_IDs_Response = Get_Payroll_IDs_Response;
		}
	}
}
