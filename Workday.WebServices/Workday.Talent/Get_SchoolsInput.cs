using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SchoolsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Schools_RequestType Get_Schools_Request;

		public Get_SchoolsInput()
		{
		}

		public Get_SchoolsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Schools_RequestType Get_Schools_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Schools_Request = Get_Schools_Request;
		}
	}
}
