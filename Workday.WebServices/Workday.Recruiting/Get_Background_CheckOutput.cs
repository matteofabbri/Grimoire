using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Background_CheckOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Background_Check_ResponseType Get_Background_Check_Response;

		public Get_Background_CheckOutput()
		{
		}

		public Get_Background_CheckOutput(Get_Background_Check_ResponseType Get_Background_Check_Response)
		{
			this.Get_Background_Check_Response = Get_Background_Check_Response;
		}
	}
}
