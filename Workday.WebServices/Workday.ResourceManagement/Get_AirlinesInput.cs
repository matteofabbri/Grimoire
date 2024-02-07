using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AirlinesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Airlines_RequestType Get_Airlines_Request;

		public Get_AirlinesInput()
		{
		}

		public Get_AirlinesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Airlines_RequestType Get_Airlines_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Airlines_Request = Get_Airlines_Request;
		}
	}
}
