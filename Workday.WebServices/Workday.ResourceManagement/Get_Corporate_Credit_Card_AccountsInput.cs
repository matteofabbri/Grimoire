using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Corporate_Credit_Card_AccountsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Corporate_Credit_Card_Accounts_RequestType Get_Corporate_Credit_Card_Accounts_Request;

		public Get_Corporate_Credit_Card_AccountsInput()
		{
		}

		public Get_Corporate_Credit_Card_AccountsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Corporate_Credit_Card_Accounts_RequestType Get_Corporate_Credit_Card_Accounts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Corporate_Credit_Card_Accounts_Request = Get_Corporate_Credit_Card_Accounts_Request;
		}
	}
}
