using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_PositionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Position_RequestType Edit_Position_Request;

		public Edit_PositionInput()
		{
		}

		public Edit_PositionInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_RequestType Edit_Position_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Position_Request = Edit_Position_Request;
		}
	}
}
