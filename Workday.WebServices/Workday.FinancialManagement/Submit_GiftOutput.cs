using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_GiftOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Gift_ResponseType Submit_Gift_Response;

		public Submit_GiftOutput()
		{
		}

		public Submit_GiftOutput(Submit_Gift_ResponseType Submit_Gift_Response)
		{
			this.Submit_Gift_Response = Submit_Gift_Response;
		}
	}
}
