using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Lifecycle_Status_Update_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Lifecycle_Status_Update_Rule_ResponseType Put_Award_Lifecycle_Status_Update_Rule_Response;

		public Put_Award_Lifecycle_Status_Update_RuleOutput()
		{
		}

		public Put_Award_Lifecycle_Status_Update_RuleOutput(Put_Award_Lifecycle_Status_Update_Rule_ResponseType Put_Award_Lifecycle_Status_Update_Rule_Response)
		{
			this.Put_Award_Lifecycle_Status_Update_Rule_Response = Put_Award_Lifecycle_Status_Update_Rule_Response;
		}
	}
}
