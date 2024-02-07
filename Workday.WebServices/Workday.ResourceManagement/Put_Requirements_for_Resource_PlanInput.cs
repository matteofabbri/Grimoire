using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Requirements_for_Resource_PlanInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Requirements_for_Resource_Plan_RequestType Put_Requirements_for_Resource_Plan_Request;

		public Put_Requirements_for_Resource_PlanInput()
		{
		}

		public Put_Requirements_for_Resource_PlanInput(Workday_Common_HeaderType Workday_Common_Header, Put_Requirements_for_Resource_Plan_RequestType Put_Requirements_for_Resource_Plan_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Requirements_for_Resource_Plan_Request = Put_Requirements_for_Resource_Plan_Request;
		}
	}
}
