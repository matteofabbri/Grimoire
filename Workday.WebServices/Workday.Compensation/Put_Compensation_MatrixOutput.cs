using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Compensation_MatrixOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Compensation_Matrix_ResponseType Put_Compensation_Matrix_Response;

		public Put_Compensation_MatrixOutput()
		{
		}

		public Put_Compensation_MatrixOutput(Put_Compensation_Matrix_ResponseType Put_Compensation_Matrix_Response)
		{
			this.Put_Compensation_Matrix_Response = Put_Compensation_Matrix_Response;
		}
	}
}
