using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Leave_of_AbsenceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Leave_of_Absence_RequestType Request_Leave_of_Absence_Request;

		public Request_Leave_of_AbsenceInput()
		{
		}

		public Request_Leave_of_AbsenceInput(Workday_Common_HeaderType Workday_Common_Header, Request_Leave_of_Absence_RequestType Request_Leave_of_Absence_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_Leave_of_Absence_Request = Request_Leave_of_Absence_Request;
		}
	}
}
