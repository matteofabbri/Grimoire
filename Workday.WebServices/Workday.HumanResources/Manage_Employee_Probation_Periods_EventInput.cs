using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Employee_Probation_Periods_EventInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Employee_Probation_Periods_Event_RequestType Manage_Employee_Probation_Periods_Event_Request;

		public Manage_Employee_Probation_Periods_EventInput()
		{
		}

		public Manage_Employee_Probation_Periods_EventInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Employee_Probation_Periods_Event_RequestType Manage_Employee_Probation_Periods_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Employee_Probation_Periods_Event_Request = Manage_Employee_Probation_Periods_Event_Request;
		}
	}
}
