using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Competency_ClassesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Competency_Classes_ResponseType Get_Competency_Classes_Response;

		public Get_Competency_ClassesOutput()
		{
		}

		public Get_Competency_ClassesOutput(Get_Competency_Classes_ResponseType Get_Competency_Classes_Response)
		{
			this.Get_Competency_Classes_Response = Get_Competency_Classes_Response;
		}
	}
}
