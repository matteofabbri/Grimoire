using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Intraday_Bank_StatementInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Intraday_Bank_Statement_RequestType Import_Intraday_Bank_Statement_Request;

		public Import_Intraday_Bank_StatementInput()
		{
		}

		public Import_Intraday_Bank_StatementInput(Workday_Common_HeaderType Workday_Common_Header, Import_Intraday_Bank_Statement_RequestType Import_Intraday_Bank_Statement_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Intraday_Bank_Statement_Request = Import_Intraday_Bank_Statement_Request;
		}
	}
}
