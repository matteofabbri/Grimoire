using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Internal_Service_DeliveriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Internal_Service_Deliveries_ResponseType Get_Internal_Service_Deliveries_Response;

		public Get_Internal_Service_DeliveriesOutput()
		{
		}

		public Get_Internal_Service_DeliveriesOutput(Get_Internal_Service_Deliveries_ResponseType Get_Internal_Service_Deliveries_Response)
		{
			this.Get_Internal_Service_Deliveries_Response = Get_Internal_Service_Deliveries_Response;
		}
	}
}
