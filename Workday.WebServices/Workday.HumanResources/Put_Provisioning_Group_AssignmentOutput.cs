using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Provisioning_Group_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Provisioning_Group_Assignment_ResponseType Put_Provisioning_Group_Assignment_Response;

		public Put_Provisioning_Group_AssignmentOutput()
		{
		}

		public Put_Provisioning_Group_AssignmentOutput(Put_Provisioning_Group_Assignment_ResponseType Put_Provisioning_Group_Assignment_Response)
		{
			this.Put_Provisioning_Group_Assignment_Response = Put_Provisioning_Group_Assignment_Response;
		}
	}
}
