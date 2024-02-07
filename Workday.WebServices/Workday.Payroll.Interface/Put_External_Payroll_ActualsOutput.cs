using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Payroll_ActualsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public External_Pay_Actual_ResponseType External_Pay_Actual_Response;

		public Put_External_Payroll_ActualsOutput()
		{
		}

		public Put_External_Payroll_ActualsOutput(External_Pay_Actual_ResponseType External_Pay_Actual_Response)
		{
			this.External_Pay_Actual_Response = External_Pay_Actual_Response;
		}
	}
}
