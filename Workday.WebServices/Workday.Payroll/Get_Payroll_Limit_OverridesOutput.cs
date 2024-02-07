using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Limit_OverridesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Limit_Overrides_ResponseType Get_Payroll_Limit_Overrides_Response;

		public Get_Payroll_Limit_OverridesOutput()
		{
		}

		public Get_Payroll_Limit_OverridesOutput(Get_Payroll_Limit_Overrides_ResponseType Get_Payroll_Limit_Overrides_Response)
		{
			this.Get_Payroll_Limit_Overrides_Response = Get_Payroll_Limit_Overrides_Response;
		}
	}
}
