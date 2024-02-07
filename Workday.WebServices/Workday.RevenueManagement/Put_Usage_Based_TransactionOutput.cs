using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Usage_Based_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Usage_Based_Transaction_ResponseType Put_Usage_Based_Transaction_Response;

		public Put_Usage_Based_TransactionOutput()
		{
		}

		public Put_Usage_Based_TransactionOutput(Put_Usage_Based_Transaction_ResponseType Put_Usage_Based_Transaction_Response)
		{
			this.Put_Usage_Based_Transaction_Response = Put_Usage_Based_Transaction_Response;
		}
	}
}
