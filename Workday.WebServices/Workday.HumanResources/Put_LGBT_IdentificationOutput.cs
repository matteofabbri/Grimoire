using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_LGBT_IdentificationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_LGBT_Identification_ResponseType Put_LGBT_Identification_Response;

		public Put_LGBT_IdentificationOutput()
		{
		}

		public Put_LGBT_IdentificationOutput(Put_LGBT_Identification_ResponseType Put_LGBT_Identification_Response)
		{
			this.Put_LGBT_Identification_Response = Put_LGBT_Identification_Response;
		}
	}
}
