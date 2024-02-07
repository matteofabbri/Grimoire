using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Education_Test_ResultsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Import_Process_ResponseType Put_Import_Process_Response;

		public Import_Education_Test_ResultsOutput()
		{
		}

		public Import_Education_Test_ResultsOutput(Put_Import_Process_ResponseType Put_Import_Process_Response)
		{
			this.Put_Import_Process_Response = Put_Import_Process_Response;
		}
	}
}
