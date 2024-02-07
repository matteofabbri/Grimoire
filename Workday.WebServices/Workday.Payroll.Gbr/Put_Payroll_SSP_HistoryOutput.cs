using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_SSP_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_SSP_History_ResponseType Put_Payroll_SSP_History_Response;

		public Put_Payroll_SSP_HistoryOutput()
		{
		}

		public Put_Payroll_SSP_HistoryOutput(Put_Payroll_SSP_History_ResponseType Put_Payroll_SSP_History_Response)
		{
			this.Put_Payroll_SSP_History_Response = Put_Payroll_SSP_History_Response;
		}
	}
}
