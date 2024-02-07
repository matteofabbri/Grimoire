using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Marketing_Activity_DefinitionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Marketing_Activity_Definitions_RequestType Get_Marketing_Activity_Definitions_Request;

		public Get_Marketing_Activity_DefinitionsInput()
		{
		}

		public Get_Marketing_Activity_DefinitionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Marketing_Activity_Definitions_RequestType Get_Marketing_Activity_Definitions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Marketing_Activity_Definitions_Request = Get_Marketing_Activity_Definitions_Request;
		}
	}
}
