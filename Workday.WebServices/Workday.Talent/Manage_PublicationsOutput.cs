using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_PublicationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Publications_ResponseType Manage_Publications_Response;

		public Manage_PublicationsOutput()
		{
		}

		public Manage_PublicationsOutput(Manage_Publications_ResponseType Manage_Publications_Response)
		{
			this.Manage_Publications_Response = Manage_Publications_Response;
		}
	}
}
