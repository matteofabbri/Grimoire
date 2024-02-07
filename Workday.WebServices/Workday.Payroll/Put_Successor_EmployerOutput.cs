using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Successor_EmployerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Successor_Employer_ResponseType Put_Successor_Employer_Response;

		public Put_Successor_EmployerOutput()
		{
		}

		public Put_Successor_EmployerOutput(Put_Successor_Employer_ResponseType Put_Successor_Employer_Response)
		{
			this.Put_Successor_Employer_Response = Put_Successor_Employer_Response;
		}
	}
}
