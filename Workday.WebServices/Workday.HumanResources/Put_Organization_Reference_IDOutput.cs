using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Organization_Reference_IDOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Organization_Reference_ID_ResponseType Put_Organization_Reference_ID_Response;

		public Put_Organization_Reference_IDOutput()
		{
		}

		public Put_Organization_Reference_IDOutput(Put_Organization_Reference_ID_ResponseType Put_Organization_Reference_ID_Response)
		{
			this.Put_Organization_Reference_ID_Response = Put_Organization_Reference_ID_Response;
		}
	}
}
