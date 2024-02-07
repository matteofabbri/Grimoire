using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sequence_GeneratorsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sequence_Generators_ResponseType Get_Sequence_Generators_Response;

		public Get_Sequence_GeneratorsOutput()
		{
		}

		public Get_Sequence_GeneratorsOutput(Get_Sequence_Generators_ResponseType Get_Sequence_Generators_Response)
		{
			this.Get_Sequence_Generators_Response = Get_Sequence_Generators_Response;
		}
	}
}
