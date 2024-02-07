using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Practical_LearningOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Practical_Learning_ResponseType Put_Practical_Learning_Response;

		public Put_Practical_LearningOutput()
		{
		}

		public Put_Practical_LearningOutput(Put_Practical_Learning_ResponseType Put_Practical_Learning_Response)
		{
			this.Put_Practical_Learning_Response = Put_Practical_Learning_Response;
		}
	}
}
