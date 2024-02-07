using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Organization_Reference_IDsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Organization_Reference_IDs_ResponseType Get_Organization_Reference_IDs_Response;

		public Get_Organization_Reference_IDsOutput()
		{
		}

		public Get_Organization_Reference_IDsOutput(Get_Organization_Reference_IDs_ResponseType Get_Organization_Reference_IDs_Response)
		{
			this.Get_Organization_Reference_IDs_Response = Get_Organization_Reference_IDs_Response;
		}
	}
}
