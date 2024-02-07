using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Lifecycle_StatusesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Lifecycle_Statuses_ResponseType Get_Award_Lifecycle_Statuses_Response;

		public Get_Award_Lifecycle_StatusesOutput()
		{
		}

		public Get_Award_Lifecycle_StatusesOutput(Get_Award_Lifecycle_Statuses_ResponseType Get_Award_Lifecycle_Statuses_Response)
		{
			this.Get_Award_Lifecycle_Statuses_Response = Get_Award_Lifecycle_Statuses_Response;
		}
	}
}
