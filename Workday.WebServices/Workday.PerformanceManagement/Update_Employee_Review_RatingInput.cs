using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Employee_Review_RatingInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Employee_Review_Rating_RequestType Update_Employee_Review_Rating_Request;

		public Update_Employee_Review_RatingInput()
		{
		}

		public Update_Employee_Review_RatingInput(Workday_Common_HeaderType Workday_Common_Header, Update_Employee_Review_Rating_RequestType Update_Employee_Review_Rating_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Update_Employee_Review_Rating_Request = Update_Employee_Review_Rating_Request;
		}
	}
}
