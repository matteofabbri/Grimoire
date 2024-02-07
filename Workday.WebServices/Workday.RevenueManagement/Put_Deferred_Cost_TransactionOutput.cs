using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Deferred_Cost_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Deferred_Cost_Transaction_ResponseType Put_Deferred_Cost_Transaction_Response;

		public Put_Deferred_Cost_TransactionOutput()
		{
		}

		public Put_Deferred_Cost_TransactionOutput(Put_Deferred_Cost_Transaction_ResponseType Put_Deferred_Cost_Transaction_Response)
		{
			this.Put_Deferred_Cost_Transaction_Response = Put_Deferred_Cost_Transaction_Response;
		}
	}
}
