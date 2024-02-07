using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Period_Reporting_CalendarsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Period_Reporting_Calendars_ResponseType Get_Period_Reporting_Calendars_Response;

		public Get_Period_Reporting_CalendarsOutput()
		{
		}

		public Get_Period_Reporting_CalendarsOutput(Get_Period_Reporting_Calendars_ResponseType Get_Period_Reporting_Calendars_Response)
		{
			this.Get_Period_Reporting_Calendars_Response = Get_Period_Reporting_Calendars_Response;
		}
	}
}
