using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Period_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Period_Schedule_ResponseType Put_Period_Schedule_Response;

		public Put_Period_ScheduleOutput()
		{
		}

		public Put_Period_ScheduleOutput(Put_Period_Schedule_ResponseType Put_Period_Schedule_Response)
		{
			this.Put_Period_Schedule_Response = Put_Period_Schedule_Response;
		}
	}
}
