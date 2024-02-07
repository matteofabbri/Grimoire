using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_OrganizationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Organizations_ResponseType Get_Organizations_Response;

		public Get_OrganizationsOutput()
		{
		}

		public Get_OrganizationsOutput(Get_Organizations_ResponseType Get_Organizations_Response)
		{
			this.Get_Organizations_Response = Get_Organizations_Response;
		}
	}
}
