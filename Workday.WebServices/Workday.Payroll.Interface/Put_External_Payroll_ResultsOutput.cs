using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Payroll_ResultsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Payroll_Results_ResponseType Put_External_Payroll_Results_Response;

		public Put_External_Payroll_ResultsOutput()
		{
		}

		public Put_External_Payroll_ResultsOutput(Put_External_Payroll_Results_ResponseType Put_External_Payroll_Results_Response)
		{
			this.Put_External_Payroll_Results_Response = Put_External_Payroll_Results_Response;
		}
	}
}
