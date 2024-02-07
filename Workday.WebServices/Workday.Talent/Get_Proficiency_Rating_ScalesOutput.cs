using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Proficiency_Rating_ScalesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Proficiency_Rating_Scales_ResponseType Get_Proficiency_Rating_Scales_Response;

		public Get_Proficiency_Rating_ScalesOutput()
		{
		}

		public Get_Proficiency_Rating_ScalesOutput(Get_Proficiency_Rating_Scales_ResponseType Get_Proficiency_Rating_Scales_Response)
		{
			this.Get_Proficiency_Rating_Scales_Response = Get_Proficiency_Rating_Scales_Response;
		}
	}
}
