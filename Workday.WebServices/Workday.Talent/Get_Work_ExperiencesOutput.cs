using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_ExperiencesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Experiences_ResponseType Get_Work_Experiences_Response;

		public Get_Work_ExperiencesOutput()
		{
		}

		public Get_Work_ExperiencesOutput(Get_Work_Experiences_ResponseType Get_Work_Experiences_Response)
		{
			this.Get_Work_Experiences_Response = Get_Work_Experiences_Response;
		}
	}
}
