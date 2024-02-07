using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SchoolOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_School_ResponseType Put_School_Response;

		public Put_SchoolOutput()
		{
		}

		public Put_SchoolOutput(Put_School_ResponseType Put_School_Response)
		{
			this.Put_School_Response = Put_School_Response;
		}
	}
}
