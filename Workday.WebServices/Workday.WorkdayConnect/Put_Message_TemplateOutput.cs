using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Message_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Message_Template_ResponseType Put_Message_Template_Response;

		public Put_Message_TemplateOutput()
		{
		}

		public Put_Message_TemplateOutput(Put_Message_Template_ResponseType Put_Message_Template_Response)
		{
			this.Put_Message_Template_Response = Put_Message_Template_Response;
		}
	}
}
