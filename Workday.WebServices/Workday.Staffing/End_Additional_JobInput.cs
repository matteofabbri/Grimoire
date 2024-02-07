using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Additional_JobInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Additional_Job_RequestType End_Additional_Job_Request;

		public End_Additional_JobInput()
		{
		}

		public End_Additional_JobInput(Workday_Common_HeaderType Workday_Common_Header, End_Additional_Job_RequestType End_Additional_Job_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.End_Additional_Job_Request = End_Additional_Job_Request;
		}
	}
}
