using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ProjectsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Projects_RequestType Get_Projects_Request;

		public Get_ProjectsInput()
		{
		}

		public Get_ProjectsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Projects_RequestType Get_Projects_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Projects_Request = Get_Projects_Request;
		}
	}
}
