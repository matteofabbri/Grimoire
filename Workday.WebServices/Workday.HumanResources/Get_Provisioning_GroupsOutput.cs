using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Provisioning_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Provisioning_Groups_ResponseType Provisioning_Groups_Response;

		public Get_Provisioning_GroupsOutput()
		{
		}

		public Get_Provisioning_GroupsOutput(Provisioning_Groups_ResponseType Provisioning_Groups_Response)
		{
			this.Provisioning_Groups_Response = Provisioning_Groups_Response;
		}
	}
}
