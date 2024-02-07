using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_ReviewsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Employee_Reviews_ResponseType Get_Employee_Reviews_Response;

		public Get_Employee_ReviewsOutput()
		{
		}

		public Get_Employee_ReviewsOutput(Get_Employee_Reviews_ResponseType Get_Employee_Reviews_Response)
		{
			this.Get_Employee_Reviews_Response = Get_Employee_Reviews_Response;
		}
	}
}
