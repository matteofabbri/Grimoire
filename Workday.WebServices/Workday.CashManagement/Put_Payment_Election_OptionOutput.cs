using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payment_Election_OptionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Election_Option_ResponseType Put_Payment_Election_Option_Response;

		public Put_Payment_Election_OptionOutput()
		{
		}

		public Put_Payment_Election_OptionOutput(Put_Payment_Election_Option_ResponseType Put_Payment_Election_Option_Response)
		{
			this.Put_Payment_Election_Option_Response = Put_Payment_Election_Option_Response;
		}
	}
}
