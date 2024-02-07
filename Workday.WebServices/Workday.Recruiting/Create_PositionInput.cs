using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_PositionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Position_RequestType Create_Position_Request;

		public Create_PositionInput()
		{
		}

		public Create_PositionInput(Workday_Common_HeaderType Workday_Common_Header, Create_Position_RequestType Create_Position_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Create_Position_Request = Create_Position_Request;
		}
	}
}
