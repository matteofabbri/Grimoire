using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Benchmark_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Benchmark_Job_ResponseType Put_Benchmark_Job_Response;

		public Put_Benchmark_JobOutput()
		{
		}

		public Put_Benchmark_JobOutput(Put_Benchmark_Job_ResponseType Put_Benchmark_Job_Response)
		{
			this.Put_Benchmark_Job_Response = Put_Benchmark_Job_Response;
		}
	}
}
