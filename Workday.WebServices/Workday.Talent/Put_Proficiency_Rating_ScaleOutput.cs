using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Proficiency_Rating_ScaleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Proficiency_Rating_Scale_ResponseType Put_Proficiency_Rating_Scale_Response;

		public Put_Proficiency_Rating_ScaleOutput()
		{
		}

		public Put_Proficiency_Rating_ScaleOutput(Put_Proficiency_Rating_Scale_ResponseType Put_Proficiency_Rating_Scale_Response)
		{
			this.Put_Proficiency_Rating_Scale_Response = Put_Proficiency_Rating_Scale_Response;
		}
	}
}
