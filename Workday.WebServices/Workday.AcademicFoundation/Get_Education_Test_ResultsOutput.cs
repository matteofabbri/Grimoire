using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Education_Test_ResultsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Education_Test_Results_ResponseType Get_Education_Test_Results_Response;

		public Get_Education_Test_ResultsOutput()
		{
		}

		public Get_Education_Test_ResultsOutput(Get_Education_Test_Results_ResponseType Get_Education_Test_Results_Response)
		{
			this.Get_Education_Test_Results_Response = Get_Education_Test_Results_Response;
		}
	}
}
