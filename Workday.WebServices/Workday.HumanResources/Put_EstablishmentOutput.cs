using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_EstablishmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Establishment_ResponseType Put_Establishment_Response;

		public Put_EstablishmentOutput()
		{
		}

		public Put_EstablishmentOutput(Put_Establishment_ResponseType Put_Establishment_Response)
		{
			this.Put_Establishment_Response = Put_Establishment_Response;
		}
	}
}
