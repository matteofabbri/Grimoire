using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Deduction_RecipientOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Deduction_Recipient_ResponseType Put_Payroll_Deduction_Recipient_Response;

		public Put_Payroll_Deduction_RecipientOutput()
		{
		}

		public Put_Payroll_Deduction_RecipientOutput(Put_Payroll_Deduction_Recipient_ResponseType Put_Payroll_Deduction_Recipient_Response)
		{
			this.Put_Payroll_Deduction_Recipient_Response = Put_Payroll_Deduction_Recipient_Response;
		}
	}
}
