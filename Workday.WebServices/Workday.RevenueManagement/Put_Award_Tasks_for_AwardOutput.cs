using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Tasks_for_AwardOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Tasks_for_Award_ResponseType Put_Award_Tasks_for_Award_Response;

		public Put_Award_Tasks_for_AwardOutput()
		{
		}

		public Put_Award_Tasks_for_AwardOutput(Put_Award_Tasks_for_Award_ResponseType Put_Award_Tasks_for_Award_Response)
		{
			this.Put_Award_Tasks_for_Award_Response = Put_Award_Tasks_for_Award_Response;
		}
	}
}
