using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_ROE_Prior_Period_History_ResultsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_ROE_Prior_Period_History_Results_ResponseType Put_Payroll_ROE_Prior_Period_History_Results_Response;

		public Put_Payroll_ROE_Prior_Period_History_ResultsOutput()
		{
		}

		public Put_Payroll_ROE_Prior_Period_History_ResultsOutput(Put_Payroll_ROE_Prior_Period_History_Results_ResponseType Put_Payroll_ROE_Prior_Period_History_Results_Response)
		{
			this.Put_Payroll_ROE_Prior_Period_History_Results_Response = Put_Payroll_ROE_Prior_Period_History_Results_Response;
		}
	}
}
