using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Fields_Of_StudyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request;

		public Get_Fields_Of_StudyInput()
		{
		}

		public Get_Fields_Of_StudyInput(Workday_Common_HeaderType Workday_Common_Header, Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Fields_Of_Study_Request = Get_Fields_Of_Study_Request;
		}
	}
}
