using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_PositionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Position_RequestType Close_Position_Request;

		public Close_PositionInput()
		{
		}

		public Close_PositionInput(Workday_Common_HeaderType Workday_Common_Header, Close_Position_RequestType Close_Position_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Close_Position_Request = Close_Position_Request;
		}
	}
}
