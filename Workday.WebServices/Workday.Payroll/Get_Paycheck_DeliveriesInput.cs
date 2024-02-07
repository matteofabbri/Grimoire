using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Paycheck_DeliveriesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Paycheck_Deliveries_RequestType Get_Paycheck_Deliveries_Request;

		public Get_Paycheck_DeliveriesInput()
		{
		}

		public Get_Paycheck_DeliveriesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Paycheck_Deliveries_RequestType Get_Paycheck_Deliveries_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Paycheck_Deliveries_Request = Get_Paycheck_Deliveries_Request;
		}
	}
}
