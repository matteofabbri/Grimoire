using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_PositionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Position_ResponseType Create_Position_Response;

		public Create_PositionOutput()
		{
		}

		public Create_PositionOutput(Create_Position_ResponseType Create_Position_Response)
		{
			this.Create_Position_Response = Create_Position_Response;
		}
	}
}
