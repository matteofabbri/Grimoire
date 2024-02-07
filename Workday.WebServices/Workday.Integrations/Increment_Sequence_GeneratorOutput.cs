using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Increment_Sequence_GeneratorOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Increment_Sequence_Generator_ResponseType Increment_Sequence_Generator_Response;

		public Increment_Sequence_GeneratorOutput()
		{
		}

		public Increment_Sequence_GeneratorOutput(Increment_Sequence_Generator_ResponseType Increment_Sequence_Generator_Response)
		{
			this.Increment_Sequence_Generator_Response = Increment_Sequence_Generator_Response;
		}
	}
}
