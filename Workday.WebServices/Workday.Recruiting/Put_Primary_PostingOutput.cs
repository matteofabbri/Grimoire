using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Primary_PostingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Primary_Posting_ResponseType Put_Primary_Posting_Response;

		public Put_Primary_PostingOutput()
		{
		}

		public Put_Primary_PostingOutput(Put_Primary_Posting_ResponseType Put_Primary_Posting_Response)
		{
			this.Put_Primary_Posting_Response = Put_Primary_Posting_Response;
		}
	}
}
