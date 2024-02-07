using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SponsorInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sponsor_RequestType Put_Sponsor_Request;

		public Put_SponsorInput()
		{
		}

		public Put_SponsorInput(Workday_Common_HeaderType Workday_Common_Header, Put_Sponsor_RequestType Put_Sponsor_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Sponsor_Request = Put_Sponsor_Request;
		}
	}
}
