using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_Levy_Deduction_RestrictionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Levy_Deduction_Restriction_ResponseType Put_Tax_Levy_Deduction_Restriction_Response;

		public Put_Tax_Levy_Deduction_RestrictionOutput()
		{
		}

		public Put_Tax_Levy_Deduction_RestrictionOutput(Put_Tax_Levy_Deduction_Restriction_ResponseType Put_Tax_Levy_Deduction_Restriction_Response)
		{
			this.Put_Tax_Levy_Deduction_Restriction_Response = Put_Tax_Levy_Deduction_Restriction_Response;
		}
	}
}
