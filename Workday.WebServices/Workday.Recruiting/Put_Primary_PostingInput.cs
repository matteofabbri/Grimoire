using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Primary_PostingInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Primary_Posting_RequestType Put_Primary_Posting_Request;

		public Put_Primary_PostingInput()
		{
		}

		public Put_Primary_PostingInput(Workday_Common_HeaderType Workday_Common_Header, Put_Primary_Posting_RequestType Put_Primary_Posting_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Primary_Posting_Request = Put_Primary_Posting_Request;
		}
	}
}
