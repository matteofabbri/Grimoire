using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Position_for_SuccessionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Position_for_Succession_ResponseType Put_Position_for_Succession_Response;

		public Put_Position_for_SuccessionOutput()
		{
		}

		public Put_Position_for_SuccessionOutput(Put_Position_for_Succession_ResponseType Put_Position_for_Succession_Response)
		{
			this.Put_Position_for_Succession_Response = Put_Position_for_Succession_Response;
		}
	}
}
