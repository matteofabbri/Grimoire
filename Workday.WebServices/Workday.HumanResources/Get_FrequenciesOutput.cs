using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_FrequenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Frequencies_ResponseType Get_Frequencies_Response;

		public Get_FrequenciesOutput()
		{
		}

		public Get_FrequenciesOutput(Get_Frequencies_ResponseType Get_Frequencies_Response)
		{
			this.Get_Frequencies_Response = Get_Frequencies_Response;
		}
	}
}
