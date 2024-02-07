using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Invoice_SchedulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Invoice_Schedules_ResponseType Get_Supplier_Invoice_Schedules_Response;

		public Get_Supplier_Invoice_SchedulesOutput()
		{
		}

		public Get_Supplier_Invoice_SchedulesOutput(Get_Supplier_Invoice_Schedules_ResponseType Get_Supplier_Invoice_Schedules_Response)
		{
			this.Get_Supplier_Invoice_Schedules_Response = Get_Supplier_Invoice_Schedules_Response;
		}
	}
}
