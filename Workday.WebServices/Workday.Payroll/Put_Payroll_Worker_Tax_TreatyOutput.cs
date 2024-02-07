using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Worker_Tax_TreatyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Worker_Tax_Treaty_ResponseType Put_Worker_Tax_Treaty_Response;

		public Put_Payroll_Worker_Tax_TreatyOutput()
		{
		}

		public Put_Payroll_Worker_Tax_TreatyOutput(Put_Worker_Tax_Treaty_ResponseType Put_Worker_Tax_Treaty_Response)
		{
			this.Put_Worker_Tax_Treaty_Response = Put_Worker_Tax_Treaty_Response;
		}
	}
}
