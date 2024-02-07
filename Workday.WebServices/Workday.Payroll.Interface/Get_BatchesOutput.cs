using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_BatchesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Batches_ResponseType Get_Batches_Response;

		public Get_BatchesOutput()
		{
		}

		public Get_BatchesOutput(Get_Batches_ResponseType Get_Batches_Response)
		{
			this.Get_Batches_Response = Get_Batches_Response;
		}
	}
}
