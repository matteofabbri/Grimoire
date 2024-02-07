using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ReceiptsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Receipts_ResponseType Get_Receipts_Response;

		public Get_ReceiptsOutput()
		{
		}

		public Get_ReceiptsOutput(Get_Receipts_ResponseType Get_Receipts_Response)
		{
			this.Get_Receipts_Response = Get_Receipts_Response;
		}
	}
}
