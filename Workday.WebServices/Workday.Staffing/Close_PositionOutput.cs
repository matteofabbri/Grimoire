using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_PositionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Position_ResponseType Close_Position_Response;

		public Close_PositionOutput()
		{
		}

		public Close_PositionOutput(Close_Position_ResponseType Close_Position_Response)
		{
			this.Close_Position_Response = Close_Position_Response;
		}
	}
}
