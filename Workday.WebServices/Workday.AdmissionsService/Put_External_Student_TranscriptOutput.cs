using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Student_TranscriptOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Student_Transcript_ResponseType Put_External_Student_Transcript_Response;

		public Put_External_Student_TranscriptOutput()
		{
		}

		public Put_External_Student_TranscriptOutput(Put_External_Student_Transcript_ResponseType Put_External_Student_Transcript_Response)
		{
			this.Put_External_Student_Transcript_Response = Put_External_Student_Transcript_Response;
		}
	}
}
