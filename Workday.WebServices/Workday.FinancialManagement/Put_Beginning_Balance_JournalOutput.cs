using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Beginning_Balance_JournalOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Beginning_Balance_Journal_ResponseType Put_Beginning_Balance_Journal_Response;

		public Put_Beginning_Balance_JournalOutput()
		{
		}

		public Put_Beginning_Balance_JournalOutput(Put_Beginning_Balance_Journal_ResponseType Put_Beginning_Balance_Journal_Response)
		{
			this.Put_Beginning_Balance_Journal_Response = Put_Beginning_Balance_Journal_Response;
		}
	}
}
