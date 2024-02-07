using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_FrequencyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Frequency_ResponseType Put_Frequency_Response;

		public Put_FrequencyOutput()
		{
		}

		public Put_FrequencyOutput(Put_Frequency_ResponseType Put_Frequency_Response)
		{
			this.Put_Frequency_Response = Put_Frequency_Response;
		}
	}
}
