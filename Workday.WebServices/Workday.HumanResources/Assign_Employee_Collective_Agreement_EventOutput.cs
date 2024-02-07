using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Employee_Collective_Agreement_EventOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Employee_Collective_Agreement_Event_ResponseType Assign_Employee_Collective_Agreement_Event_Response;

		public Assign_Employee_Collective_Agreement_EventOutput()
		{
		}

		public Assign_Employee_Collective_Agreement_EventOutput(Assign_Employee_Collective_Agreement_Event_ResponseType Assign_Employee_Collective_Agreement_Event_Response)
		{
			this.Assign_Employee_Collective_Agreement_Event_Response = Assign_Employee_Collective_Agreement_Event_Response;
		}
	}
}
