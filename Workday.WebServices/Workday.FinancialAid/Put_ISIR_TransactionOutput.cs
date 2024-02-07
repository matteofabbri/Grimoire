using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ISIR_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_ISIR_Transaction_ResponseType Put_ISIR_Transaction_Response;

		public Put_ISIR_TransactionOutput()
		{
		}

		public Put_ISIR_TransactionOutput(Put_ISIR_Transaction_ResponseType Put_ISIR_Transaction_Response)
		{
			this.Put_ISIR_Transaction_Response = Put_ISIR_Transaction_Response;
		}
	}
}
