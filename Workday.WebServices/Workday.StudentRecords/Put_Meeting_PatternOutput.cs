using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Meeting_PatternOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Meeting_Pattern_ResponseType Put_Meeting_Pattern_Response;

		public Put_Meeting_PatternOutput()
		{
		}

		public Put_Meeting_PatternOutput(Put_Meeting_Pattern_ResponseType Put_Meeting_Pattern_Response)
		{
			this.Put_Meeting_Pattern_Response = Put_Meeting_Pattern_Response;
		}
	}
}
