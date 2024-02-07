using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Committee_DefinitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Committee_Definition_ResponseType Get_Committee_Definition_Response;

		public Get_Committee_DefinitionOutput()
		{
		}

		public Get_Committee_DefinitionOutput(Get_Committee_Definition_ResponseType Get_Committee_Definition_Response)
		{
			this.Get_Committee_Definition_Response = Get_Committee_Definition_Response;
		}
	}
}
