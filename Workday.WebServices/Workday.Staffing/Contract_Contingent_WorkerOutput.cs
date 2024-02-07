using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Contract_Contingent_WorkerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Contract_Contingent_Worker_ResponseType Contract_Contingent_Worker_Response;

		public Contract_Contingent_WorkerOutput()
		{
		}

		public Contract_Contingent_WorkerOutput(Contract_Contingent_Worker_ResponseType Contract_Contingent_Worker_Response)
		{
			this.Contract_Contingent_Worker_Response = Contract_Contingent_Worker_Response;
		}
	}
}
