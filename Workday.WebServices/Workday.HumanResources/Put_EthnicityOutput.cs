using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_EthnicityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ethnicity_ResponseType Put_Ethnicity_Response;

		public Put_EthnicityOutput()
		{
		}

		public Put_EthnicityOutput(Put_Ethnicity_ResponseType Put_Ethnicity_Response)
		{
			this.Put_Ethnicity_Response = Put_Ethnicity_Response;
		}
	}
}
