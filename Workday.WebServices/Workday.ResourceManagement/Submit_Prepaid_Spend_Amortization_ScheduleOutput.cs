using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Prepaid_Spend_Amortization_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Prepaid_Spend_Amortization_Schedule_ResponseType Submit_Prepaid_Spend_Amortization_Schedule_Response;

		public Submit_Prepaid_Spend_Amortization_ScheduleOutput()
		{
		}

		public Submit_Prepaid_Spend_Amortization_ScheduleOutput(Submit_Prepaid_Spend_Amortization_Schedule_ResponseType Submit_Prepaid_Spend_Amortization_Schedule_Response)
		{
			this.Submit_Prepaid_Spend_Amortization_Schedule_Response = Submit_Prepaid_Spend_Amortization_Schedule_Response;
		}
	}
}
