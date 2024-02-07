using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Message_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Message_Template_ResponseType Get_Message_Template_Response;

		public Get_Message_TemplateOutput()
		{
		}

		public Get_Message_TemplateOutput(Get_Message_Template_ResponseType Get_Message_Template_Response)
		{
			this.Get_Message_Template_Response = Get_Message_Template_Response;
		}
	}
}
