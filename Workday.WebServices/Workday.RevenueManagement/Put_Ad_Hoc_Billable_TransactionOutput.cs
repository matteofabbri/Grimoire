using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ad_Hoc_Billable_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ad_Hoc_Billable_Transaction_ResponseType Put_Ad_Hoc_Billable_Transaction_Response;

		public Put_Ad_Hoc_Billable_TransactionOutput()
		{
		}

		public Put_Ad_Hoc_Billable_TransactionOutput(Put_Ad_Hoc_Billable_Transaction_ResponseType Put_Ad_Hoc_Billable_Transaction_Response)
		{
			this.Put_Ad_Hoc_Billable_Transaction_Response = Put_Ad_Hoc_Billable_Transaction_Response;
		}
	}
}
