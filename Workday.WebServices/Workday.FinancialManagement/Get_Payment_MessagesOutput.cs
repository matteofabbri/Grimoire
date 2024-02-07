using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_MessagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Messages_ResponseType Get_Payment_Messages_Response;

		public Get_Payment_MessagesOutput()
		{
		}

		public Get_Payment_MessagesOutput(Get_Payment_Messages_ResponseType Get_Payment_Messages_Response)
		{
			this.Get_Payment_Messages_Response = Get_Payment_Messages_Response;
		}
	}
}
