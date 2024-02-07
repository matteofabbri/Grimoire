using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AwardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Awards_RequestType Get_Awards_Request;

		public Get_AwardsInput()
		{
		}

		public Get_AwardsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Awards_RequestType Get_Awards_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Awards_Request = Get_Awards_Request;
		}
	}
}
