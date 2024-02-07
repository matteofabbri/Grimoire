using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Task_List_TemplateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Task_List_Template_ResponseType Put_Award_Task_List_Template_Response;

		public Put_Award_Task_List_TemplateOutput()
		{
		}

		public Put_Award_Task_List_TemplateOutput(Put_Award_Task_List_Template_ResponseType Put_Award_Task_List_Template_Response)
		{
			this.Put_Award_Task_List_Template_Response = Put_Award_Task_List_Template_Response;
		}
	}
}
