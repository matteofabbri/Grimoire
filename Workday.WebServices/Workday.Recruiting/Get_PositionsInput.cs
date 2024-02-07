using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PositionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Positions_RequestType Get_Positions_Request;

		public Get_PositionsInput()
		{
		}

		public Get_PositionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Positions_RequestType Get_Positions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Positions_Request = Get_Positions_Request;
		}
	}
}
