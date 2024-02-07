using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Background_CheckOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Background_Check_ResponseType Put_Background_Check_Response;

		public Put_Background_CheckOutput()
		{
		}

		public Put_Background_CheckOutput(Put_Background_Check_ResponseType Put_Background_Check_Response)
		{
			this.Put_Background_Check_Response = Put_Background_Check_Response;
		}
	}
}
