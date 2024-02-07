using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Adjust_Time_OffOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Time_Off_Event_ResponseType Time_Off_Event_Response;

		public Adjust_Time_OffOutput()
		{
		}

		public Adjust_Time_OffOutput(Time_Off_Event_ResponseType Time_Off_Event_Response)
		{
			this.Time_Off_Event_Response = Time_Off_Event_Response;
		}
	}
}
