using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Workers_Compensation_CodeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Workers_Compensation_Code_ResponseType Put_Workers_Compensation_Code_Response;

		public Put_Workers_Compensation_CodeOutput()
		{
		}

		public Put_Workers_Compensation_CodeOutput(Put_Workers_Compensation_Code_ResponseType Put_Workers_Compensation_Code_Response)
		{
			this.Put_Workers_Compensation_Code_Response = Put_Workers_Compensation_Code_Response;
		}
	}
}
