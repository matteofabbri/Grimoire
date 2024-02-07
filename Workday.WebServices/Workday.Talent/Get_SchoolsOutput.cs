using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SchoolsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Schools_ResponseType Get_Schools_Response;

		public Get_SchoolsOutput()
		{
		}

		public Get_SchoolsOutput(Get_Schools_ResponseType Get_Schools_Response)
		{
			this.Get_Schools_Response = Get_Schools_Response;
		}
	}
}
