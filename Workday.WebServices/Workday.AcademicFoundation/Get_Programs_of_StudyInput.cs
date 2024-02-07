using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Programs_of_StudyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Programs_of_Study_RequestType Get_Programs_of_Study_Request;

		public Get_Programs_of_StudyInput()
		{
		}

		public Get_Programs_of_StudyInput(Workday_Common_HeaderType Workday_Common_Header, Get_Programs_of_Study_RequestType Get_Programs_of_Study_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Programs_of_Study_Request = Get_Programs_of_Study_Request;
		}
	}
}
