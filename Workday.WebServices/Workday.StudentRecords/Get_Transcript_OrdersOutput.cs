using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transcript_OrdersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Transcript_Orders_ResponseType Get_Transcript_Orders_Response;

		public Get_Transcript_OrdersOutput()
		{
		}

		public Get_Transcript_OrdersOutput(Get_Transcript_Orders_ResponseType Get_Transcript_Orders_Response)
		{
			this.Get_Transcript_Orders_Response = Get_Transcript_Orders_Response;
		}
	}
}
