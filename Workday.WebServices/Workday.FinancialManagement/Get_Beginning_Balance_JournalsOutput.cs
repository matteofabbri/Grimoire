using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Beginning_Balance_JournalsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Beginning_Balance_Journals_ResponseType Get_Beginning_Balance_Journals_Response;

		public Get_Beginning_Balance_JournalsOutput()
		{
		}

		public Get_Beginning_Balance_JournalsOutput(Get_Beginning_Balance_Journals_ResponseType Get_Beginning_Balance_Journals_Response)
		{
			this.Get_Beginning_Balance_Journals_Response = Get_Beginning_Balance_Journals_Response;
		}
	}
}
