using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Period_Reporting_CalendarOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Period_Reporting_Calendar_ResponseType Put_Period_Reporting_Calendar_Response;

		public Put_Period_Reporting_CalendarOutput()
		{
		}

		public Put_Period_Reporting_CalendarOutput(Put_Period_Reporting_Calendar_ResponseType Put_Period_Reporting_Calendar_Response)
		{
			this.Put_Period_Reporting_Calendar_Response = Put_Period_Reporting_Calendar_Response;
		}
	}
}
