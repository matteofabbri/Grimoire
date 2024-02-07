using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Effort_Certifying_TextsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Effort_Certifying_Texts_ResponseType Get_Effort_Certifying_Texts_Response;

		public Get_Effort_Certifying_TextsOutput()
		{
		}

		public Get_Effort_Certifying_TextsOutput(Get_Effort_Certifying_Texts_ResponseType Get_Effort_Certifying_Texts_Response)
		{
			this.Get_Effort_Certifying_Texts_Response = Get_Effort_Certifying_Texts_Response;
		}
	}
}
