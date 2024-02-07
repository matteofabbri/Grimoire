using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Revenue_Recognition_Schedule_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Revenue_Recognition_Schedule_Template_ResponseType Put_Revenue_Recognition_Schedule_Template_Response;

		public Put_Revenue_Recognition_Schedule_TemplateOutput()
		{
		}

		public Put_Revenue_Recognition_Schedule_TemplateOutput(Put_Revenue_Recognition_Schedule_Template_ResponseType Put_Revenue_Recognition_Schedule_Template_Response)
		{
			this.Put_Revenue_Recognition_Schedule_Template_Response = Put_Revenue_Recognition_Schedule_Template_Response;
		}
	}
}
