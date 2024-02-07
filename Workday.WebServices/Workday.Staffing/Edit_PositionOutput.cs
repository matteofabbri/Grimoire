using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_PositionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Position_Event_ResponseType Edit_Position_Event_Response;

		public Edit_PositionOutput()
		{
		}

		public Edit_PositionOutput(Edit_Position_Event_ResponseType Edit_Position_Event_Response)
		{
			this.Edit_Position_Event_Response = Edit_Position_Event_Response;
		}
	}
}
