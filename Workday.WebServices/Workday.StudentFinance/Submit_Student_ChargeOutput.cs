using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_ChargeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Charge_ResponseType Submit_Student_Charge_Response;

		public Submit_Student_ChargeOutput()
		{
		}

		public Submit_Student_ChargeOutput(Submit_Student_Charge_ResponseType Submit_Student_Charge_Response)
		{
			this.Submit_Student_Charge_Response = Submit_Student_Charge_Response;
		}
	}
}
