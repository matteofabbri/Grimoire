using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Award_AmendmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Award_Amendment_RequestType Submit_Award_Amendment_Request;

		public Submit_Award_AmendmentInput()
		{
		}

		public Submit_Award_AmendmentInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Amendment_RequestType Submit_Award_Amendment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Award_Amendment_Request = Submit_Award_Amendment_Request;
		}
	}
}
