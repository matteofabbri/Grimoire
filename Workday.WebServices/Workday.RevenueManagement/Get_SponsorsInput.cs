using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SponsorsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sponsors_RequestType Get_Sponsors_Request;

		public Get_SponsorsInput()
		{
		}

		public Get_SponsorsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Sponsors_RequestType Get_Sponsors_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Sponsors_Request = Get_Sponsors_Request;
		}
	}
}
