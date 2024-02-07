using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Start_Performance_ReviewOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Start_Performance_Review_ResponseType Start_Performance_Review_Response;

		public Start_Performance_ReviewOutput()
		{
		}

		public Start_Performance_ReviewOutput(Start_Performance_Review_ResponseType Start_Performance_Review_Response)
		{
			this.Start_Performance_Review_Response = Start_Performance_Review_Response;
		}
	}
}
