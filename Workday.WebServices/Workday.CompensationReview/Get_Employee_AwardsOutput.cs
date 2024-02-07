using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_AwardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Employee_Awards_ResponseType Get_Employee_Awards_Response;

		public Get_Employee_AwardsOutput()
		{
		}

		public Get_Employee_AwardsOutput(Get_Employee_Awards_ResponseType Get_Employee_Awards_Response)
		{
			this.Get_Employee_Awards_Response = Get_Employee_Awards_Response;
		}
	}
}
