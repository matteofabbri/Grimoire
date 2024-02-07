using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_Invoice_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Invoice_Schedule_ResponseType Submit_Supplier_Invoice_Schedule_Response;

		public Submit_Supplier_Invoice_ScheduleOutput()
		{
		}

		public Submit_Supplier_Invoice_ScheduleOutput(Submit_Supplier_Invoice_Schedule_ResponseType Submit_Supplier_Invoice_Schedule_Response)
		{
			this.Submit_Supplier_Invoice_Schedule_Response = Submit_Supplier_Invoice_Schedule_Response;
		}
	}
}
