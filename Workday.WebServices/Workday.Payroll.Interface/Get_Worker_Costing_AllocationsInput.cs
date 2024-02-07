using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_Costing_AllocationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request;

		public Get_Worker_Costing_AllocationsInput()
		{
		}

		public Get_Worker_Costing_AllocationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Worker_Costing_Allocations_Request = Get_Worker_Costing_Allocations_Request;
		}
	}
}
