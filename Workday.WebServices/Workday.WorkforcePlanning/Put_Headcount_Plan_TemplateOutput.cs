using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Headcount_Plan_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Headcount_Plan_Template_ResponseType Put_Headcount_Plan_Template_Response;

		public Put_Headcount_Plan_TemplateOutput()
		{
		}

		public Put_Headcount_Plan_TemplateOutput(Put_Headcount_Plan_Template_ResponseType Put_Headcount_Plan_Template_Response)
		{
			this.Put_Headcount_Plan_Template_Response = Put_Headcount_Plan_Template_Response;
		}
	}
}
