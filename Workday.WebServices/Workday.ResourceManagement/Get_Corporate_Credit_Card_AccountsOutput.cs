using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Corporate_Credit_Card_AccountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Corporate_Credit_Card_Accounts_ResponseType Get_Corporate_Credit_Card_Accounts_Response;

		public Get_Corporate_Credit_Card_AccountsOutput()
		{
		}

		public Get_Corporate_Credit_Card_AccountsOutput(Get_Corporate_Credit_Card_Accounts_ResponseType Get_Corporate_Credit_Card_Accounts_Response)
		{
			this.Get_Corporate_Credit_Card_Accounts_Response = Get_Corporate_Credit_Card_Accounts_Response;
		}
	}
}
