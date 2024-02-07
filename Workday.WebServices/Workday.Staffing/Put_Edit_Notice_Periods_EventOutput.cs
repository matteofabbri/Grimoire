using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Edit_Notice_Periods_EventOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Edit_Notice_Periods_Event_ResponseType Put_Edit_Notice_Periods_Event_Response;

		public Put_Edit_Notice_Periods_EventOutput()
		{
		}

		public Put_Edit_Notice_Periods_EventOutput(Put_Edit_Notice_Periods_Event_ResponseType Put_Edit_Notice_Periods_Event_Response)
		{
			this.Put_Edit_Notice_Periods_Event_Response = Put_Edit_Notice_Periods_Event_Response;
		}
	}
}
