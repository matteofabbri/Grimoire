using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Reference_Letter_for_WorkerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Reference_Letter_for_Worker_ResponseType Create_Reference_Letter_for_Worker_Response;

		public Create_Reference_Letter_for_WorkerOutput()
		{
		}

		public Create_Reference_Letter_for_WorkerOutput(Create_Reference_Letter_for_Worker_ResponseType Create_Reference_Letter_for_Worker_Response)
		{
			this.Create_Reference_Letter_for_Worker_Response = Create_Reference_Letter_for_Worker_Response;
		}
	}
}
