using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Correct_AwardInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Correct_Award_RequestType Correct_Award_Request;

		public Correct_AwardInput()
		{
		}

		public Correct_AwardInput(Workday_Common_HeaderType Workday_Common_Header, Correct_Award_RequestType Correct_Award_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Correct_Award_Request = Correct_Award_Request;
		}
	}
}
