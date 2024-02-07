using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_Status_Rule_SetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Status_Rule_Sets_ResponseType Get_Work_Status_Rule_Sets_Response;

		public Get_Work_Status_Rule_SetsOutput()
		{
		}

		public Get_Work_Status_Rule_SetsOutput(Get_Work_Status_Rule_Sets_ResponseType Get_Work_Status_Rule_Sets_Response)
		{
			this.Get_Work_Status_Rule_Sets_Response = Get_Work_Status_Rule_Sets_Response;
		}
	}
}
