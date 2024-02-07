using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Successor_EmployersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Successor_Employers_ResponseType Get_Successor_Employers_Response;

		public Get_Successor_EmployersOutput()
		{
		}

		public Get_Successor_EmployersOutput(Get_Successor_Employers_ResponseType Get_Successor_Employers_Response)
		{
			this.Get_Successor_Employers_Response = Get_Successor_Employers_Response;
		}
	}
}
