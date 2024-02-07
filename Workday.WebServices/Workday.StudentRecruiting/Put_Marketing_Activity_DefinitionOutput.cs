using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Marketing_Activity_DefinitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Marketing_Activity_Definition_ResponseType Put_Marketing_Activity_Definition_Response;

		public Put_Marketing_Activity_DefinitionOutput()
		{
		}

		public Put_Marketing_Activity_DefinitionOutput(Put_Marketing_Activity_Definition_ResponseType Put_Marketing_Activity_Definition_Response)
		{
			this.Put_Marketing_Activity_Definition_Response = Put_Marketing_Activity_Definition_Response;
		}
	}
}
