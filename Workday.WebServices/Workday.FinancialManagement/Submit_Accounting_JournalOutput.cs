using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Accounting_JournalOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Accounting_Journal_ResponseType Submit_Accounting_Journal_Response;

		public Submit_Accounting_JournalOutput()
		{
		}

		public Submit_Accounting_JournalOutput(Submit_Accounting_Journal_ResponseType Submit_Accounting_Journal_Response)
		{
			this.Submit_Accounting_Journal_Response = Submit_Accounting_Journal_Response;
		}
	}
}
