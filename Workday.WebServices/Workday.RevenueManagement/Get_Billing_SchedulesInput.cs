using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Billing_SchedulesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Billing_Schedules_RequestType Get_Billing_Schedules_Request;

		public Get_Billing_SchedulesInput()
		{
		}

		public Get_Billing_SchedulesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Billing_Schedules_RequestType Get_Billing_Schedules_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Billing_Schedules_Request = Get_Billing_Schedules_Request;
		}
	}
}
