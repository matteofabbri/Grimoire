using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Social_Benefits_LocalitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Social_Benefits_Localities_ResponseType Get_Social_Benefits_Localities_Response;

		public Get_Social_Benefits_LocalitiesOutput()
		{
		}

		public Get_Social_Benefits_LocalitiesOutput(Get_Social_Benefits_Localities_ResponseType Get_Social_Benefits_Localities_Response)
		{
			this.Get_Social_Benefits_Localities_Response = Get_Social_Benefits_Localities_Response;
		}
	}
}
