using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Close_Mentorship_ReasonsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Close_Mentorship_Reasons_RequestType Get_Close_Mentorship_Reasons_Request;

		public Get_Close_Mentorship_ReasonsInput()
		{
		}

		public Get_Close_Mentorship_ReasonsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Close_Mentorship_Reasons_RequestType Get_Close_Mentorship_Reasons_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Close_Mentorship_Reasons_Request = Get_Close_Mentorship_Reasons_Request;
		}
	}
}
