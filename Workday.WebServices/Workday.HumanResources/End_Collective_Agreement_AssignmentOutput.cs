using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Collective_Agreement_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Collective_Agreement_Assignment_Event_ResponseType End_Collective_Agreement_Assignment_Event_Response;

		public End_Collective_Agreement_AssignmentOutput()
		{
		}

		public End_Collective_Agreement_AssignmentOutput(End_Collective_Agreement_Assignment_Event_ResponseType End_Collective_Agreement_Assignment_Event_Response)
		{
			this.End_Collective_Agreement_Assignment_Event_Response = End_Collective_Agreement_Assignment_Event_Response;
		}
	}
}
