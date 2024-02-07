using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Extracurricular_ActivityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Extracurricular_Activity_ResponseType Put_Extracurricular_Activity_Response;

		public Put_Extracurricular_ActivityOutput()
		{
		}

		public Put_Extracurricular_ActivityOutput(Put_Extracurricular_Activity_ResponseType Put_Extracurricular_Activity_Response)
		{
			this.Put_Extracurricular_Activity_Response = Put_Extracurricular_Activity_Response;
		}
	}
}
