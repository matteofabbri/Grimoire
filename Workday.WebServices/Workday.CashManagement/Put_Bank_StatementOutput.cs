using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Bank_StatementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Bank_Statement_ResponseType Put_Bank_Statement_Response;

		public Put_Bank_StatementOutput()
		{
		}

		public Put_Bank_StatementOutput(Put_Bank_Statement_ResponseType Put_Bank_Statement_Response)
		{
			this.Put_Bank_Statement_Response = Put_Bank_Statement_Response;
		}
	}
}
