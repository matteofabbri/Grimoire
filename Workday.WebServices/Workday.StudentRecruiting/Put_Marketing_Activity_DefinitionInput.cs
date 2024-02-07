using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Marketing_Activity_DefinitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Marketing_Activity_Definition_RequestType Put_Marketing_Activity_Definition_Request;

		public Put_Marketing_Activity_DefinitionInput()
		{
		}

		public Put_Marketing_Activity_DefinitionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Marketing_Activity_Definition_RequestType Put_Marketing_Activity_Definition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Marketing_Activity_Definition_Request = Put_Marketing_Activity_Definition_Request;
		}
	}
}
