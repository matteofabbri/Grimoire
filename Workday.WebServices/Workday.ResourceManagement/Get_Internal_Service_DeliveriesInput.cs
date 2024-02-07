using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Internal_Service_DeliveriesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Internal_Service_Deliveries_RequestType Get_Internal_Service_Deliveries_Request;

		public Get_Internal_Service_DeliveriesInput()
		{
		}

		public Get_Internal_Service_DeliveriesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Deliveries_RequestType Get_Internal_Service_Deliveries_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Internal_Service_Deliveries_Request = Get_Internal_Service_Deliveries_Request;
		}
	}
}
