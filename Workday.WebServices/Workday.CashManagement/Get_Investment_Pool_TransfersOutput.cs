using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Investment_Pool_TransfersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Investment_Pool_Transfers_ResponseType Get_Investment_Pool_Transfers_Response;

		public Get_Investment_Pool_TransfersOutput()
		{
		}

		public Get_Investment_Pool_TransfersOutput(Get_Investment_Pool_Transfers_ResponseType Get_Investment_Pool_Transfers_Response)
		{
			this.Get_Investment_Pool_Transfers_Response = Get_Investment_Pool_Transfers_Response;
		}
	}
}
