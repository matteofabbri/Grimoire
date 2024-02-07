using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_External_Student_TranscriptsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_External_Student_Transcript_RequestType Import_External_Student_Transcript_Request;

		public Import_External_Student_TranscriptsInput()
		{
		}

		public Import_External_Student_TranscriptsInput(Workday_Common_HeaderType Workday_Common_Header, Import_External_Student_Transcript_RequestType Import_External_Student_Transcript_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_External_Student_Transcript_Request = Import_External_Student_Transcript_Request;
		}
	}
}
