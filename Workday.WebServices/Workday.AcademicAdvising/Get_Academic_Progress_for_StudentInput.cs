using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_Progress_for_StudentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Progress_for_Student_RequestType Get_Academic_Progress_for_Student_Request;

		public Get_Academic_Progress_for_StudentInput()
		{
		}

		public Get_Academic_Progress_for_StudentInput(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Progress_for_Student_RequestType Get_Academic_Progress_for_Student_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Academic_Progress_for_Student_Request = Get_Academic_Progress_for_Student_Request;
		}
	}
}
