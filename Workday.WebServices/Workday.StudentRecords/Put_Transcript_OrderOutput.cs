using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Transcript_OrderOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Transcript_Order_ResponseType Put_Transcript_Order_Response;

		public Put_Transcript_OrderOutput()
		{
		}

		public Put_Transcript_OrderOutput(Put_Transcript_Order_ResponseType Put_Transcript_Order_Response)
		{
			this.Put_Transcript_Order_Response = Put_Transcript_Order_Response;
		}
	}
}
