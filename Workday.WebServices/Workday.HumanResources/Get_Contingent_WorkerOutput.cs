using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Contingent_WorkerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Contingent_WorkerType Contingent_Worker;

		public Get_Contingent_WorkerOutput()
		{
		}

		public Get_Contingent_WorkerOutput(Contingent_WorkerType Contingent_Worker)
		{
			this.Contingent_Worker = Contingent_Worker;
		}
	}
}
