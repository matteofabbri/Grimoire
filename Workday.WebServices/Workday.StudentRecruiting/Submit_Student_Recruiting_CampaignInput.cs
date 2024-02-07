using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_Recruiting_CampaignInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Recruiting_Campaign_RequestType Submit_Student_Recruiting_Campaign_Request;

		public Submit_Student_Recruiting_CampaignInput()
		{
		}

		public Submit_Student_Recruiting_CampaignInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiting_Campaign_RequestType Submit_Student_Recruiting_Campaign_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Student_Recruiting_Campaign_Request = Submit_Student_Recruiting_Campaign_Request;
		}
	}
}
