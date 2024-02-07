using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Lifecycle_Status_Update_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Lifecycle_Status_Update_Rules_ResponseType Get_Award_Lifecycle_Status_Update_Rules_Response;

		public Get_Award_Lifecycle_Status_Update_RulesOutput()
		{
		}

		public Get_Award_Lifecycle_Status_Update_RulesOutput(Get_Award_Lifecycle_Status_Update_Rules_ResponseType Get_Award_Lifecycle_Status_Update_Rules_Response)
		{
			this.Get_Award_Lifecycle_Status_Update_Rules_Response = Get_Award_Lifecycle_Status_Update_Rules_Response;
		}
	}
}
