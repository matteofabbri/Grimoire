using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Adjust_Time_OffInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Adjust_Time_Off_RequestType Adjust_Time_Off_Request;

		public Adjust_Time_OffInput()
		{
		}

		public Adjust_Time_OffInput(Workday_Common_HeaderType Workday_Common_Header, Adjust_Time_Off_RequestType Adjust_Time_Off_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Adjust_Time_Off_Request = Adjust_Time_Off_Request;
		}
	}
}
