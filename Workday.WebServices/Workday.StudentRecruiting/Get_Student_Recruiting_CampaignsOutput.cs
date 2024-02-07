using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Recruiting_CampaignsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Recruiting_Campaigns_ResponseType Get_Student_Recruiting_Campaigns_Response;

		public Get_Student_Recruiting_CampaignsOutput()
		{
		}

		public Get_Student_Recruiting_CampaignsOutput(Get_Student_Recruiting_Campaigns_ResponseType Get_Student_Recruiting_Campaigns_Response)
		{
			this.Get_Student_Recruiting_Campaigns_Response = Get_Student_Recruiting_Campaigns_Response;
		}
	}
}
