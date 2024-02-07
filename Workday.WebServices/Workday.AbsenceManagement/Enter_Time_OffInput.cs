using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Enter_Time_OffInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Enter_Time_Off_RequestType Enter_Time_Off_Request;

		public Enter_Time_OffInput()
		{
		}

		public Enter_Time_OffInput(Workday_Common_HeaderType Workday_Common_Header, Enter_Time_Off_RequestType Enter_Time_Off_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Enter_Time_Off_Request = Enter_Time_Off_Request;
		}
	}
}
