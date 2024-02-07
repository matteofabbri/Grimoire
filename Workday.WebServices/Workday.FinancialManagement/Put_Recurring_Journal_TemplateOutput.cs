using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Recurring_Journal_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Recurring_Journal_Template_ResponseType Put_Recurring_Journal_Template_Response;

		public Put_Recurring_Journal_TemplateOutput()
		{
		}

		public Put_Recurring_Journal_TemplateOutput(Put_Recurring_Journal_Template_ResponseType Put_Recurring_Journal_Template_Response)
		{
			this.Put_Recurring_Journal_Template_Response = Put_Recurring_Journal_Template_Response;
		}
	}
}
