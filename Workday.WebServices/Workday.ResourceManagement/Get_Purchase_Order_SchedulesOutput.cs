using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Purchase_Order_SchedulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Purchase_Order_Schedules_ResponseType Get_Purchase_Order_Schedules_Response;

		public Get_Purchase_Order_SchedulesOutput()
		{
		}

		public Get_Purchase_Order_SchedulesOutput(Get_Purchase_Order_Schedules_ResponseType Get_Purchase_Order_Schedules_Response)
		{
			this.Get_Purchase_Order_Schedules_Response = Get_Purchase_Order_Schedules_Response;
		}
	}
}
