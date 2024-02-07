using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workers_Compensation_CodesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workers_Compensation_Codes_ResponseType Get_Workers_Compensation_Codes_Response;

		public Get_Workers_Compensation_CodesOutput()
		{
		}

		public Get_Workers_Compensation_CodesOutput(Get_Workers_Compensation_Codes_ResponseType Get_Workers_Compensation_Codes_Response)
		{
			this.Get_Workers_Compensation_Codes_Response = Get_Workers_Compensation_Codes_Response;
		}
	}
}
