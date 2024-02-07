using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Paycheck_DeliveriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Paycheck_Deliveries_ResponseType Get_Paycheck_Deliveries_Response;

		public Get_Paycheck_DeliveriesOutput()
		{
		}

		public Get_Paycheck_DeliveriesOutput(Get_Paycheck_Deliveries_ResponseType Get_Paycheck_Deliveries_Response)
		{
			this.Get_Paycheck_Deliveries_Response = Get_Paycheck_Deliveries_Response;
		}
	}
}
