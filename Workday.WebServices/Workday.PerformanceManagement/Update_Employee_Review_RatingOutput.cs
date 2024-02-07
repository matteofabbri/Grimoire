using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Employee_Review_RatingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Employee_Review_Rating_ResponseType Update_Employee_Review_Rating_Response;

		public Update_Employee_Review_RatingOutput()
		{
		}

		public Update_Employee_Review_RatingOutput(Update_Employee_Review_Rating_ResponseType Update_Employee_Review_Rating_Response)
		{
			this.Update_Employee_Review_Rating_Response = Update_Employee_Review_Rating_Response;
		}
	}
}
