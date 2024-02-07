using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_Levy_Deduction_RestrictionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Levy_Deduction_Restrictions_ResponseType Get_Tax_Levy_Deduction_Restrictions_Response;

		public Get_Tax_Levy_Deduction_RestrictionsOutput()
		{
		}

		public Get_Tax_Levy_Deduction_RestrictionsOutput(Get_Tax_Levy_Deduction_Restrictions_ResponseType Get_Tax_Levy_Deduction_Restrictions_Response)
		{
			this.Get_Tax_Levy_Deduction_Restrictions_Response = Get_Tax_Levy_Deduction_Restrictions_Response;
		}
	}
}
