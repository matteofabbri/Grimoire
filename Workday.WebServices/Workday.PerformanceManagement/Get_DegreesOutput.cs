using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DegreesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Degrees_ResponseType Get_Degrees_Response;

		public Get_DegreesOutput()
		{
		}

		public Get_DegreesOutput(Get_Degrees_ResponseType Get_Degrees_Response)
		{
			this.Get_Degrees_Response = Get_Degrees_Response;
		}
	}
}
