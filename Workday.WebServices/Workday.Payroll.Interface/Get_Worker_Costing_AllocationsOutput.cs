using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Costing_AllocationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Costing_Allocations_ResponseType Get_Worker_Costing_Allocations_Response;

		public Get_Worker_Costing_AllocationsOutput()
		{
		}

		public Get_Worker_Costing_AllocationsOutput(Get_Worker_Costing_Allocations_ResponseType Get_Worker_Costing_Allocations_Response)
		{
			this.Get_Worker_Costing_Allocations_Response = Get_Worker_Costing_Allocations_Response;
		}
	}
}
