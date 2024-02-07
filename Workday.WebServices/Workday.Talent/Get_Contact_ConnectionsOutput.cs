using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Contact_ConnectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Contact_Connections_ResponseType Get_Contact_Connections_Response;

		public Get_Contact_ConnectionsOutput()
		{
		}

		public Get_Contact_ConnectionsOutput(Get_Contact_Connections_ResponseType Get_Contact_Connections_Response)
		{
			this.Get_Contact_Connections_Response = Get_Contact_Connections_Response;
		}
	}
}
