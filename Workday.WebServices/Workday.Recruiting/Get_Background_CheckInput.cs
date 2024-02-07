using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Background_CheckInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Background_Check_RequestType Get_Background_Check_Request;

		public Get_Background_CheckInput()
		{
		}

		public Get_Background_CheckInput(Workday_Common_HeaderType Workday_Common_Header, Get_Background_Check_RequestType Get_Background_Check_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Background_Check_Request = Get_Background_Check_Request;
		}
	}
}
