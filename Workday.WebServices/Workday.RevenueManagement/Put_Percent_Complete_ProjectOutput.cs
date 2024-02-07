using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Percent_Complete_ProjectOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Percent_Complete_Project_ResponseType Put_Percent_Complete_Project_Response;

		public Put_Percent_Complete_ProjectOutput()
		{
		}

		public Put_Percent_Complete_ProjectOutput(Put_Percent_Complete_Project_ResponseType Put_Percent_Complete_Project_Response)
		{
			this.Put_Percent_Complete_Project_Response = Put_Percent_Complete_Project_Response;
		}
	}
}
