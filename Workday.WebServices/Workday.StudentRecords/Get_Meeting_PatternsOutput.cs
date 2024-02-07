using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Meeting_PatternsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Meeting_Patterns_ResponseType Get_Meeting_Patterns_Response;

		public Get_Meeting_PatternsOutput()
		{
		}

		public Get_Meeting_PatternsOutput(Get_Meeting_Patterns_ResponseType Get_Meeting_Patterns_Response)
		{
			this.Get_Meeting_Patterns_Response = Get_Meeting_Patterns_Response;
		}
	}
}
