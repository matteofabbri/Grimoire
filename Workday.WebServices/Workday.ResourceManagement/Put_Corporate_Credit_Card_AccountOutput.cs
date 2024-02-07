using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Corporate_Credit_Card_AccountOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Corporate_Credit_Card_Account_ResponseType Put_Corporate_Credit_Card_Account_Response;

		public Put_Corporate_Credit_Card_AccountOutput()
		{
		}

		public Put_Corporate_Credit_Card_AccountOutput(Put_Corporate_Credit_Card_Account_ResponseType Put_Corporate_Credit_Card_Account_Response)
		{
			this.Put_Corporate_Credit_Card_Account_Response = Put_Corporate_Credit_Card_Account_Response;
		}
	}
}
