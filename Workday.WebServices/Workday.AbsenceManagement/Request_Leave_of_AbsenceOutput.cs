using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Leave_of_AbsenceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Leave_of_Absence_ResponseType Request_Leave_of_Absence_Response;

		public Request_Leave_of_AbsenceOutput()
		{
		}

		public Request_Leave_of_AbsenceOutput(Request_Leave_of_Absence_ResponseType Request_Leave_of_Absence_Response)
		{
			this.Request_Leave_of_Absence_Response = Request_Leave_of_Absence_Response;
		}
	}
}
