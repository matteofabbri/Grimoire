using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_JournalsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Journals_ResponseType Get_Journals_Response;

		public Get_JournalsOutput()
		{
		}

		public Get_JournalsOutput(Get_Journals_ResponseType Get_Journals_Response)
		{
			this.Get_Journals_Response = Get_Journals_Response;
		}
	}
}
