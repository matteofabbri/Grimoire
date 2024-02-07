using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DisabilitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Disabilities_ResponseType Get_Disabilities_Response;

		public Get_DisabilitiesOutput()
		{
		}

		public Get_DisabilitiesOutput(Get_Disabilities_ResponseType Get_Disabilities_Response)
		{
			this.Get_Disabilities_Response = Get_Disabilities_Response;
		}
	}
}
