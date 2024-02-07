using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reassign_Business_Process_StepInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reassign_Business_Process_Step_RequestType Reassign_Business_Process_Step_Request;

		public Reassign_Business_Process_StepInput()
		{
		}

		public Reassign_Business_Process_StepInput(Workday_Common_HeaderType Workday_Common_Header, Reassign_Business_Process_Step_RequestType Reassign_Business_Process_Step_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Reassign_Business_Process_Step_Request = Reassign_Business_Process_Step_Request;
		}
	}
}
