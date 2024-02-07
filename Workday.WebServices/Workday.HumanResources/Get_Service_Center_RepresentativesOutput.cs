using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Service_Center_RepresentativesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Service_Center_Representatives_ResponseType Get_Service_Center_Representatives_Response;

		public Get_Service_Center_RepresentativesOutput()
		{
		}

		public Get_Service_Center_RepresentativesOutput(Get_Service_Center_Representatives_ResponseType Get_Service_Center_Representatives_Response)
		{
			this.Get_Service_Center_Representatives_Response = Get_Service_Center_Representatives_Response;
		}
	}
}
