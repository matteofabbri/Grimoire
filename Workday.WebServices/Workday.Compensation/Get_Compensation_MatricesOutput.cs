using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Compensation_MatricesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Compensation_Matrices_ResponseType Get_Compensation_Matrices_Response;

		public Get_Compensation_MatricesOutput()
		{
		}

		public Get_Compensation_MatricesOutput(Get_Compensation_Matrices_ResponseType Get_Compensation_Matrices_Response)
		{
			this.Get_Compensation_Matrices_Response = Get_Compensation_Matrices_Response;
		}
	}
}
