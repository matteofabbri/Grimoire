using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Committee_DefinitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Committee_Definition_ResponseType Maintain_Committee_Definition_Response;

		public Maintain_Committee_DefinitionOutput()
		{
		}

		public Maintain_Committee_DefinitionOutput(Maintain_Committee_Definition_ResponseType Maintain_Committee_Definition_Response)
		{
			this.Maintain_Committee_Definition_Response = Maintain_Committee_Definition_Response;
		}
	}
}
