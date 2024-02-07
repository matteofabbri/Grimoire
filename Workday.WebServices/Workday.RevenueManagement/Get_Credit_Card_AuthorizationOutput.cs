using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Credit_Card_AuthorizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Credit_Card_Authorization_ResponseType Get_Credit_Card_Authorization_Response;

		public Get_Credit_Card_AuthorizationOutput()
		{
		}

		public Get_Credit_Card_AuthorizationOutput(Get_Credit_Card_Authorization_ResponseType Get_Credit_Card_Authorization_Response)
		{
			this.Get_Credit_Card_Authorization_Response = Get_Credit_Card_Authorization_Response;
		}
	}
}
