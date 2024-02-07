using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Social_Benefits_LocalityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Social_Benefits_Locality_ResponseType Put_Social_Benefits_Locality_Response;

		public Put_Social_Benefits_LocalityOutput()
		{
		}

		public Put_Social_Benefits_LocalityOutput(Put_Social_Benefits_Locality_ResponseType Put_Social_Benefits_Locality_Response)
		{
			this.Put_Social_Benefits_Locality_Response = Put_Social_Benefits_Locality_Response;
		}
	}
}
