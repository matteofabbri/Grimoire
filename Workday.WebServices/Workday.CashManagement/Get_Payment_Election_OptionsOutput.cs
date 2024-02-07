using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_Election_OptionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Election_Options_ResponseType Get_Payment_Election_Options_Response;

		public Get_Payment_Election_OptionsOutput()
		{
		}

		public Get_Payment_Election_OptionsOutput(Get_Payment_Election_Options_ResponseType Get_Payment_Election_Options_Response)
		{
			this.Get_Payment_Election_Options_Response = Get_Payment_Election_Options_Response;
		}
	}
}
