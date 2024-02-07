using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_PronounOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Pronoun_ResponseType Put_Pronoun_Response;

		public Put_PronounOutput()
		{
		}

		public Put_PronounOutput(Put_Pronoun_ResponseType Put_Pronoun_Response)
		{
			this.Put_Pronoun_Response = Put_Pronoun_Response;
		}
	}
}
