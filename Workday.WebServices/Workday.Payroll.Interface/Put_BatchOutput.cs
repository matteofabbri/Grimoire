using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_BatchOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Batch_ResponseType Put_Batch_Response;

		public Put_BatchOutput()
		{
		}

		public Put_BatchOutput(Put_Batch_ResponseType Put_Batch_Response)
		{
			this.Put_Batch_Response = Put_Batch_Response;
		}
	}
}
