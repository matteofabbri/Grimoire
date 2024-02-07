using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Marketing_Activity_DefinitionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Marketing_Activity_Definitions_ResponseType Get_Marketing_Activity_Definitions_Response;

		public Get_Marketing_Activity_DefinitionsOutput()
		{
		}

		public Get_Marketing_Activity_DefinitionsOutput(Get_Marketing_Activity_Definitions_ResponseType Get_Marketing_Activity_Definitions_Response)
		{
			this.Get_Marketing_Activity_Definitions_Response = Get_Marketing_Activity_Definitions_Response;
		}
	}
}
