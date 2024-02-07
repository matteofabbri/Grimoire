using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Contingent_Worker_ContractOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Contingent_Worker_Contract_ResponseType End_Contingent_Worker_Contract_Response;

		public End_Contingent_Worker_ContractOutput()
		{
		}

		public End_Contingent_Worker_ContractOutput(End_Contingent_Worker_Contract_ResponseType End_Contingent_Worker_Contract_Response)
		{
			this.End_Contingent_Worker_Contract_Response = End_Contingent_Worker_Contract_Response;
		}
	}
}
