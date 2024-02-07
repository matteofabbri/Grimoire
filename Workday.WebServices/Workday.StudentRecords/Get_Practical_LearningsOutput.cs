using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Practical_LearningsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Practical_Learnings_ResponseType Get_Practical_Learnings_Response;

		public Get_Practical_LearningsOutput()
		{
		}

		public Get_Practical_LearningsOutput(Get_Practical_Learnings_ResponseType Get_Practical_Learnings_Response)
		{
			this.Get_Practical_Learnings_Response = Get_Practical_Learnings_Response;
		}
	}
}
