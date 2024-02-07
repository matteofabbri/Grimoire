using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_DisabilityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Disability_ResponseType Put_Disability_Response;

		public Put_DisabilityOutput()
		{
		}

		public Put_DisabilityOutput(Put_Disability_ResponseType Put_Disability_Response)
		{
			this.Put_Disability_Response = Put_Disability_Response;
		}
	}
}
