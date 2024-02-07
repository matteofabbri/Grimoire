using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Task_Type_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Task_Type_Groups_ResponseType Get_Award_Task_Type_Groups_Response;

		public Get_Award_Task_Type_GroupsOutput()
		{
		}

		public Get_Award_Task_Type_GroupsOutput(Get_Award_Task_Type_Groups_ResponseType Get_Award_Task_Type_Groups_Response)
		{
			this.Get_Award_Task_Type_Groups_Response = Get_Award_Task_Type_Groups_Response;
		}
	}
}
