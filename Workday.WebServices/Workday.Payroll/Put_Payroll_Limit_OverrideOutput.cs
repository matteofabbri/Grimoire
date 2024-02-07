using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Limit_OverrideOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Limit_Override_ResponseType Put_Payroll_Limit_Override_Response;

		public Put_Payroll_Limit_OverrideOutput()
		{
		}

		public Put_Payroll_Limit_OverrideOutput(Put_Payroll_Limit_Override_ResponseType Put_Payroll_Limit_Override_Response)
		{
			this.Put_Payroll_Limit_Override_Response = Put_Payroll_Limit_Override_Response;
		}
	}
}
