using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Sequence_GeneratorOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sequence_Generator_ResponseType Put_Sequence_Generator_Response;

		public Put_Sequence_GeneratorOutput()
		{
		}

		public Put_Sequence_GeneratorOutput(Put_Sequence_Generator_ResponseType Put_Sequence_Generator_Response)
		{
			this.Put_Sequence_Generator_Response = Put_Sequence_Generator_Response;
		}
	}
}
