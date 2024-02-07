using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Period_SchedulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Period_Schedules_ResponseType Get_Period_Schedules_Response;

		public Get_Period_SchedulesOutput()
		{
		}

		public Get_Period_SchedulesOutput(Get_Period_Schedules_ResponseType Get_Period_Schedules_Response)
		{
			this.Get_Period_Schedules_Response = Get_Period_Schedules_Response;
		}
	}
}
