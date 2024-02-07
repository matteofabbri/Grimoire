using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_EstablishmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Establishment_ResponseType Assign_Establishment_Response;

		public Assign_EstablishmentOutput()
		{
		}

		public Assign_EstablishmentOutput(Assign_Establishment_ResponseType Assign_Establishment_Response)
		{
			this.Assign_Establishment_Response = Assign_Establishment_Response;
		}
	}
}
