using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Internal_Service_DeliveryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Internal_Service_Delivery_ResponseType Cancel_Internal_Service_Delivery_Response;

		public Cancel_Internal_Service_DeliveryOutput()
		{
		}

		public Cancel_Internal_Service_DeliveryOutput(Cancel_Internal_Service_Delivery_ResponseType Cancel_Internal_Service_Delivery_Response)
		{
			this.Cancel_Internal_Service_Delivery_Response = Cancel_Internal_Service_Delivery_Response;
		}
	}
}
