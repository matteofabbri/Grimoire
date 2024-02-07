using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Former_WorkerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Former_Worker_ResponseType Put_Former_Worker_Response;

		public Put_Former_WorkerOutput()
		{
		}

		public Put_Former_WorkerOutput(Put_Former_Worker_ResponseType Put_Former_Worker_Response)
		{
			this.Put_Former_Worker_Response = Put_Former_Worker_Response;
		}
	}
}
