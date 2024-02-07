using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Bank_StatementsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Bank_Statements_RequestType Get_Bank_Statements_Request;

		public Get_Bank_StatementsInput()
		{
		}

		public Get_Bank_StatementsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statements_RequestType Get_Bank_Statements_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Bank_Statements_Request = Get_Bank_Statements_Request;
		}
	}
}
