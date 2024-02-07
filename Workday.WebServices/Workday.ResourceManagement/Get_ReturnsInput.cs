using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ReturnsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Returns_RequestType Get_Returns_Request;

		public Get_ReturnsInput()
		{
		}

		public Get_ReturnsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Returns_RequestType Get_Returns_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Returns_Request = Get_Returns_Request;
		}
	}
}
