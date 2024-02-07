using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Succession_PoolOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Succession_Pool_ResponseType Manage_Succession_Pool_Response;

		public Manage_Succession_PoolOutput()
		{
		}

		public Manage_Succession_PoolOutput(Manage_Succession_Pool_ResponseType Manage_Succession_Pool_Response)
		{
			this.Manage_Succession_Pool_Response = Manage_Succession_Pool_Response;
		}
	}
}
