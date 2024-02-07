using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Educational_Institution_CourseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Educational_Institution_Course_RequestType Get_Educational_Institution_Course_Request;

		public Get_Educational_Institution_CourseInput()
		{
		}

		public Get_Educational_Institution_CourseInput(Workday_Common_HeaderType Workday_Common_Header, Get_Educational_Institution_Course_RequestType Get_Educational_Institution_Course_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Educational_Institution_Course_Request = Get_Educational_Institution_Course_Request;
		}
	}
}
