using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Job_InterestsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Job_Interests_ResponseType Edit_Job_Interests_Response;

		public Edit_Job_InterestsOutput()
		{
		}

		public Edit_Job_InterestsOutput(Edit_Job_Interests_ResponseType Edit_Job_Interests_Response)
		{
			this.Edit_Job_Interests_Response = Edit_Job_Interests_Response;
		}
	}
}
