using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Basic_GiftOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Basic_Gift_ResponseType Put_Basic_Gift_Response;

		public Put_Basic_GiftOutput()
		{
		}

		public Put_Basic_GiftOutput(Put_Basic_Gift_ResponseType Put_Basic_Gift_Response)
		{
			this.Put_Basic_Gift_Response = Put_Basic_Gift_Response;
		}
	}
}
