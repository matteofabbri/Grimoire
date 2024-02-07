using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_Recruiting_CampaignOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Recruiting_Campaign_ResponseType Submit_Student_Recruiting_Campaign_Response;

		public Submit_Student_Recruiting_CampaignOutput()
		{
		}

		public Submit_Student_Recruiting_CampaignOutput(Submit_Student_Recruiting_Campaign_ResponseType Submit_Student_Recruiting_Campaign_Response)
		{
			this.Submit_Student_Recruiting_Campaign_Response = Submit_Student_Recruiting_Campaign_Response;
		}
	}
}
