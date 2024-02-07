using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Costing_AllocationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Costing_Allocation_ResponseType Assign_Costing_Allocation_Response;

		public Assign_Costing_AllocationOutput()
		{
		}

		public Assign_Costing_AllocationOutput(Assign_Costing_Allocation_ResponseType Assign_Costing_Allocation_Response)
		{
			this.Assign_Costing_Allocation_Response = Assign_Costing_Allocation_Response;
		}
	}
}
