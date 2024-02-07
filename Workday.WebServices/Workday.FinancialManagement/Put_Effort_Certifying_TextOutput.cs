using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Effort_Certifying_TextOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Effort_Certifying_Text_ResponseType Put_Effort_Certifying_Text_Response;

		public Put_Effort_Certifying_TextOutput()
		{
		}

		public Put_Effort_Certifying_TextOutput(Put_Effort_Certifying_Text_ResponseType Put_Effort_Certifying_Text_Response)
		{
			this.Put_Effort_Certifying_Text_Response = Put_Effort_Certifying_Text_Response;
		}
	}
}
