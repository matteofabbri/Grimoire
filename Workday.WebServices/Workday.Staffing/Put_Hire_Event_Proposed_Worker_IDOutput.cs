using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Hire_Event_Proposed_Worker_IDOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Hire_Event_Proposed_Worker_ID_ResponseType Put_Hire_Event_Proposed_Worker_ID_Response;

		public Put_Hire_Event_Proposed_Worker_IDOutput()
		{
		}

		public Put_Hire_Event_Proposed_Worker_IDOutput(Put_Hire_Event_Proposed_Worker_ID_ResponseType Put_Hire_Event_Proposed_Worker_ID_Response)
		{
			this.Put_Hire_Event_Proposed_Worker_ID_Response = Put_Hire_Event_Proposed_Worker_ID_Response;
		}
	}
}
