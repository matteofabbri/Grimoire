using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Competency_ClassOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Competency_Class_ResponseType Put_Competency_Class_Response;

		public Put_Competency_ClassOutput()
		{
		}

		public Put_Competency_ClassOutput(Put_Competency_Class_ResponseType Put_Competency_Class_Response)
		{
			this.Put_Competency_Class_Response = Put_Competency_Class_Response;
		}
	}
}
