using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Unpost_Accounting_JournalInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Unpost_Accounting_Journal_RequestType Unpost_Accounting_Journal_Request;

		public Unpost_Accounting_JournalInput()
		{
		}

		public Unpost_Accounting_JournalInput(Workday_Common_HeaderType Workday_Common_Header, Unpost_Accounting_Journal_RequestType Unpost_Accounting_Journal_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Unpost_Accounting_Journal_Request = Unpost_Accounting_Journal_Request;
		}
	}
}
