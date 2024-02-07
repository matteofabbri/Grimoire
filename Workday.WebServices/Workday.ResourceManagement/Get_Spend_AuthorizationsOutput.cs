using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Spend_AuthorizationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Spend_Authorizations_ResponseType Get_Spend_Authorizations_Response;

		public Get_Spend_AuthorizationsOutput()
		{
		}

		public Get_Spend_AuthorizationsOutput(Get_Spend_Authorizations_ResponseType Get_Spend_Authorizations_Response)
		{
			this.Get_Spend_Authorizations_Response = Get_Spend_Authorizations_Response;
		}
	}
}
