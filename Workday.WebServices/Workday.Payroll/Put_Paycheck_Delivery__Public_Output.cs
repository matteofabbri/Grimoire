using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Paycheck_Delivery__Public_Output
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Paycheck_Delivery__Public__ResponseType Put_Paycheck_Delivery__Public__Response;

		public Put_Paycheck_Delivery__Public_Output()
		{
		}

		public Put_Paycheck_Delivery__Public_Output(Put_Paycheck_Delivery__Public__ResponseType Put_Paycheck_Delivery__Public__Response)
		{
			this.Put_Paycheck_Delivery__Public__Response = Put_Paycheck_Delivery__Public__Response;
		}
	}
}
