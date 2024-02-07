using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Meeting_PatternsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Meeting_Patterns_RequestType Get_Meeting_Patterns_Request;

		public Get_Meeting_PatternsInput()
		{
		}

		public Get_Meeting_PatternsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Meeting_Patterns_RequestType Get_Meeting_Patterns_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Meeting_Patterns_Request = Get_Meeting_Patterns_Request;
		}
	}
}
