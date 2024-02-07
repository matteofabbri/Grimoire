using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Period_SchedulesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Period_Schedules_RequestType Get_Period_Schedules_Request;

		public Get_Period_SchedulesInput()
		{
		}

		public Get_Period_SchedulesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Schedules_RequestType Get_Period_Schedules_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Period_Schedules_Request = Get_Period_Schedules_Request;
		}
	}
}
