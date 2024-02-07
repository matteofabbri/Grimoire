using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Worker_Tax_TreatiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Tax_Treaties_ResponseType Get_Worker_Tax_Treaties_Response;

		public Get_Payroll_Worker_Tax_TreatiesOutput()
		{
		}

		public Get_Payroll_Worker_Tax_TreatiesOutput(Get_Worker_Tax_Treaties_ResponseType Get_Worker_Tax_Treaties_Response)
		{
			this.Get_Worker_Tax_Treaties_Response = Get_Worker_Tax_Treaties_Response;
		}
	}
}
