using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Provisioning_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Provisioning_Group_ResponseType Put_Provisioning_Group_Response;

		public Put_Provisioning_GroupOutput()
		{
		}

		public Put_Provisioning_GroupOutput(Put_Provisioning_Group_ResponseType Put_Provisioning_Group_Response)
		{
			this.Put_Provisioning_Group_Response = Put_Provisioning_Group_Response;
		}
	}
}
