using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Correct_AwardOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Correct_Award_ResponseType Correct_Award_Response;

		public Correct_AwardOutput()
		{
		}

		public Correct_AwardOutput(Correct_Award_ResponseType Correct_Award_Response)
		{
			this.Correct_Award_Response = Correct_Award_Response;
		}
	}
}
