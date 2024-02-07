using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Course_SectionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Course_Section_RequestType Submit_Course_Section_Request;

		public Submit_Course_SectionInput()
		{
		}

		public Submit_Course_SectionInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Course_Section_RequestType Submit_Course_Section_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Course_Section_Request = Submit_Course_Section_Request;
		}
	}
}
