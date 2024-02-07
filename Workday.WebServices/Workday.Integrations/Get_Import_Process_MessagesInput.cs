using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Import_Process_MessagesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Import_Process_Messages_RequestType Get_Import_Process_Messages_Request;

		public Get_Import_Process_MessagesInput()
		{
		}

		public Get_Import_Process_MessagesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Import_Process_Messages_RequestType Get_Import_Process_Messages_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Import_Process_Messages_Request = Get_Import_Process_Messages_Request;
		}
	}
}
