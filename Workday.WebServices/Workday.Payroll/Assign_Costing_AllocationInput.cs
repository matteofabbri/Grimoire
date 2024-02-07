using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Costing_AllocationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Costing_Allocation_RequestType Assign_Costing_Allocation_Request;

		public Assign_Costing_AllocationInput()
		{
		}

		public Assign_Costing_AllocationInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Costing_Allocation_RequestType Assign_Costing_Allocation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Costing_Allocation_Request = Assign_Costing_Allocation_Request;
		}
	}
}
