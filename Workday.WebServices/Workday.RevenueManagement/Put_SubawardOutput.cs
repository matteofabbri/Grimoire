using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubawardOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subaward_ResponseType Put_Subaward_Response;

		public Put_SubawardOutput()
		{
		}

		public Put_SubawardOutput(Put_Subaward_ResponseType Put_Subaward_Response)
		{
			this.Put_Subaward_Response = Put_Subaward_Response;
		}
	}
}
