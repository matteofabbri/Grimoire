using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Education_Test_ResultOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Education_Test_Result_ResponseType Put_Education_Test_Result_Response;

		public Put_Education_Test_ResultOutput()
		{
		}

		public Put_Education_Test_ResultOutput(Put_Education_Test_Result_ResponseType Put_Education_Test_Result_Response)
		{
			this.Put_Education_Test_Result_Response = Put_Education_Test_Result_Response;
		}
	}
}
