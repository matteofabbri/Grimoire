using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Employee_Probation_Periods_EventOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Employee_Probation_Periods_Event_ResponseType Manage_Employee_Probation_Periods_Event_Response;

		public Manage_Employee_Probation_Periods_EventOutput()
		{
		}

		public Manage_Employee_Probation_Periods_EventOutput(Manage_Employee_Probation_Periods_Event_ResponseType Manage_Employee_Probation_Periods_Event_Response)
		{
			this.Manage_Employee_Probation_Periods_Event_Response = Manage_Employee_Probation_Periods_Event_Response;
		}
	}
}
