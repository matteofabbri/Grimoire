using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_Student_TranscriptsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Student_Transcripts_ResponseType Get_External_Student_Transcripts_Response;

		public Get_External_Student_TranscriptsOutput()
		{
		}

		public Get_External_Student_TranscriptsOutput(Get_External_Student_Transcripts_ResponseType Get_External_Student_Transcripts_Response)
		{
			this.Get_External_Student_Transcripts_Response = Get_External_Student_Transcripts_Response;
		}
	}
}
