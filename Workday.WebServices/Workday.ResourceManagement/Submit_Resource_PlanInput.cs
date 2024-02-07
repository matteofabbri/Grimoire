using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Resource_PlanInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Resource_Plan_RequestType Submit_Resource_Plan_Request;

		public Submit_Resource_PlanInput()
		{
		}

		public Submit_Resource_PlanInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Resource_Plan_RequestType Submit_Resource_Plan_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Resource_Plan_Request = Submit_Resource_Plan_Request;
		}
	}
}
