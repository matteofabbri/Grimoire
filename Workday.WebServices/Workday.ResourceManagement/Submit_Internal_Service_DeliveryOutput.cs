using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Internal_Service_DeliveryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Internal_Service_Delivery_ResponseType Submit_Internal_Service_Delivery_Response;

		public Submit_Internal_Service_DeliveryOutput()
		{
		}

		public Submit_Internal_Service_DeliveryOutput(Submit_Internal_Service_Delivery_ResponseType Submit_Internal_Service_Delivery_Response)
		{
			this.Submit_Internal_Service_Delivery_Response = Submit_Internal_Service_Delivery_Response;
		}
	}
}
