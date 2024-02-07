using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_Document_DeliveriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Document_Deliveries_ResponseType Get_Tax_Document_Deliveries_Response;

		public Get_Tax_Document_DeliveriesOutput()
		{
		}

		public Get_Tax_Document_DeliveriesOutput(Get_Tax_Document_Deliveries_ResponseType Get_Tax_Document_Deliveries_Response)
		{
			this.Get_Tax_Document_Deliveries_Response = Get_Tax_Document_Deliveries_Response;
		}
	}
}
