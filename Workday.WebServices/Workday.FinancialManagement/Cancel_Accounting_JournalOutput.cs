using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Accounting_JournalOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Accounting_Journal_ResponseType Cancel_Accounting_Journal_Response;

		public Cancel_Accounting_JournalOutput()
		{
		}

		public Cancel_Accounting_JournalOutput(Cancel_Accounting_Journal_ResponseType Cancel_Accounting_Journal_Response)
		{
			this.Cancel_Accounting_Journal_Response = Cancel_Accounting_Journal_Response;
		}
	}
}
