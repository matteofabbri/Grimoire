using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Benchmark_JobsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Benchmark_Jobs_ResponseType Get_Benchmark_Jobs_Response;

		public Get_Benchmark_JobsOutput()
		{
		}

		public Get_Benchmark_JobsOutput(Get_Benchmark_Jobs_ResponseType Get_Benchmark_Jobs_Response)
		{
			this.Get_Benchmark_Jobs_Response = Get_Benchmark_Jobs_Response;
		}
	}
}
